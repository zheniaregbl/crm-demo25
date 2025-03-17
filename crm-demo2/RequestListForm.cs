using Npgsql;
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
    public partial class RequestListForm : Form
    {
        private RequestController _RequestController;
        private List<Request> _Requests = new List<Request>();

        public RequestListForm()
        {
            InitializeComponent();
            _CreateColumns();
            statusField.SelectedIndex = 0;

            _RequestController = new RequestController();
        }

        private void RequestListForm_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid(searchField.Text, statusField.Text);
        }

        private void _CreateColumns()
        {
            requestDataGridView.Columns.Add("id", "Номер заявки");
            requestDataGridView.Columns.Add("start_date", "Дата добавления");
            requestDataGridView.Columns.Add("home_tech", "Вид техники");
            requestDataGridView.Columns.Add("status", "Статус");
            requestDataGridView.Columns.Add("master", "Ответственный мастер");
        }

        private void _ReadSingleRow(Request request)
        {

            string master = request.Master?.Name ?? "Не назначен";
            string startDate = request.StartDate.ToString("d");

            requestDataGridView.Rows.Add(request.Id, startDate, request.HomeTech.Type.Name, request.Status, master);
        }

        private void _RefreshDataGrid(string inputRequestId, string inputRequestStatus)
        {
            if (!string.IsNullOrEmpty(inputRequestId))
            {
                if (long.TryParse(inputRequestId, out long requestId))
                {
                    if (inputRequestStatus != "любой")
                    {
                        _Requests = _RequestController.GetRequestsByIdAndStatus(requestId, inputRequestStatus);
                    }
                    else
                    {
                        _Requests = _RequestController.GetRequestsById(requestId);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный номер заявки. Пожалуйста, введите целое число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (inputRequestStatus != "любой")
            {
                _Requests = _RequestController.GetRequestsByStatus(inputRequestStatus);
            }
            else
            {
                _Requests = _RequestController.GetAllRequests();
            }

            requestDataGridView.Rows.Clear();

            foreach (Request request in _Requests)
            {
                _ReadSingleRow(request);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _RefreshDataGrid(searchField.Text, statusField.Text);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (requestDataGridView.CurrentRow != null)
            {
                RequestForm requestForm = new RequestForm(_Requests[requestDataGridView.CurrentRow.Index])
                {
                    Text = "Редактирование заявки"
                };

                requestForm.FormClosed += RequestForm_FormClosed;

                requestForm.Show();
            }
        }

        private void RequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _RefreshDataGrid(searchField.Text, statusField.Text);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            _RequestController.DeleteRequest(_Requests[requestDataGridView.CurrentRow.Index].Id);
            _RefreshDataGrid(searchField.Text, statusField.Text);
        }
    }
}
