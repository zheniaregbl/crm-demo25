using crm_demo2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm_demo2
{
    public partial class ReportForm : Form
    {
        private RequestController _RequestController;
        private List<ReportRequest> _Requests = new List<ReportRequest>();

        public ReportForm()
        {
            InitializeComponent();
            _CreateColumns();

            _RequestController = new RequestController();
        }

        private void _CreateColumns()
        {
            dataGridView1.Columns.Add("id", "Номер заявки");
            dataGridView1.Columns.Add("start_date", "Дата добавления");
            dataGridView1.Columns.Add("completion_date", "Дата выполнения");
            dataGridView1.Columns.Add("problem", "Проблема");
            dataGridView1.Columns.Add("client_name", "Заказчик");
            dataGridView1.Columns.Add("client_phone", "Номер заказчика");
            dataGridView1.Columns.Add("master_name", "Мастер");
            dataGridView1.Columns.Add("master_phone", "Номер мастера");
            dataGridView1.Columns.Add("tech_model", "Модель техники");
            dataGridView1.Columns.Add("tech_type", "Тип техники");
        }

        private void _ReadSingleRow(ReportRequest request)
        {
            string master = request.MasterName == null ? "-" : request.MasterName;
            string masterPhone = request.MasterPhone == null ? "-" : request.MasterPhone;
            string startDate = request.StartDate.ToString("d");
            string completionDate = request.CompletionDate?.ToString("d") ?? "-";

            dataGridView1.Rows.Add(request.Id, startDate, completionDate, request.Problem, request.ClientName, request.ClientPhone, request.MasterName, request.MasterPhone, request.TechModel, request.TechType);
        }

        private void _RefreshDataGrid()
        {
            _Requests = _RequestController.GetReportRequestByDates(fromDatePicker.Value, toDatePicker.Value);

            dataGridView1.Rows.Clear();

            foreach (ReportRequest request in _Requests)
            {
                _ReadSingleRow(request);
            }
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            if (fromDatePicker.Value > toDatePicker.Value)
            {
                MessageBox.Show("Дата начала периода не может быть больше даты конца периода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Отчет сформирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataGrid();
            }
        }
    }
}
