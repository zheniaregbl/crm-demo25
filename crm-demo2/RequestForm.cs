using crm_demo2.Controller;
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
    public partial class RequestForm : Form
    {
        private Request? _Request;
        private RequestController _RequestController;
        private TechTypeController _TechTypeController;
        private UserController _UserController;
        private List<TechType> _TechTypes = new List<TechType>();
        private List<User> _Clients = new List<User>();

        public RequestForm(Request? request)
        {
            InitializeComponent();
            _Request = request;
            _RequestController = new RequestController();
            _TechTypeController = new TechTypeController();
            _UserController = new UserController();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            _Clients = _UserController.GetAllClient();
            _TechTypes = _TechTypeController.GetAllTypes();

            long maxId = _RequestController.GetMaxRequestId();


            foreach (string client in _Clients.Select(client => client.Name).ToList())
            {
                clientField.Items.Add(client);
            }

            foreach (string type in _TechTypes.Select(type => type.Name).ToList())
            {
                typeField.Items.Add(type);
            }

            if (_Request == null)
            {
                saveButton.Text = "Добавить";
                numberField.Text = (maxId + 1).ToString();
            }
            else
            {
                saveButton.Text = "Сохранить";

                numberField.Text = _Request!.Id.ToString();
                dateTimePicker1.Value = _Request.StartDate;
                typeField.SelectedIndex = _TechTypes.IndexOf(_TechTypes.FirstOrDefault(type => type.Name == _Request.HomeTech.Type.Name)!);
                modelField.Text = _Request.HomeTech.Model;
                clientField.SelectedIndex = _Clients.IndexOf(_Clients.FirstOrDefault(client => client.Name == _Request.Client.Name)!);
                phoneField.Text = _Request.Client.Phone;
                descriptionField.Text = _Request.Problem;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_Request == null)
            {
                if (modelField.Text != "" && clientField.Text != "" && phoneField.Text != "" && descriptionField.Text != "")
                {
                    _RequestController.AddRequestWithHomeTech(
                        _TechTypes.FirstOrDefault(type => type.Name == typeField.Text)!.Id,
                        modelField.Text,
                        _Clients.FirstOrDefault(client => client.Name == clientField.Text)!.Id,
                        descriptionField.Text,
                        "новая",
                        dateTimePicker1.Value
                    );

                    MessageBox.Show("Заявка успешно добавлена.", "Запись добавлена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Для добавления заявки необходимо заполнить все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (modelField.Text != "" && clientField.Text != "" && phoneField.Text != "" && descriptionField.Text != "")
                {
                    _RequestController.UpdateRequestWithHomeTech(
                        _Request.Id,
                        _Request.HomeTech.Id,
                        _TechTypes[typeField.SelectedIndex].Id,
                        modelField.Text,
                        _Clients[clientField.SelectedIndex].Id,
                        descriptionField.Text,
                        dateTimePicker1.Value
                    );

                    MessageBox.Show("Заявка успешно изменена.", "Запись изменена", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Для сохранения заявки необходимо заполнить все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
