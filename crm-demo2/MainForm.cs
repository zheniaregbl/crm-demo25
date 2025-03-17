namespace crm_demo2
{
    public partial class MainForm : Form
    {
        private StatisticsConteroller _StatisticsConteroller;

        public MainForm()
        {
            InitializeComponent();
            _StatisticsConteroller = new StatisticsConteroller();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestListForm requestListForm = new RequestListForm();
            requestListForm.FormClosed += SomeForm_FormClosed;
            requestListForm.Show();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm(null)
            {
                Text = "���������� ����� ������"
            };
            requestForm.FormClosed += SomeForm_FormClosed;

            requestForm.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.FormClosed += SomeForm_FormClosed;
            reportForm.Show();
        }

        private void _UpdateStatistics()
        {
            label1.Text = $"���������� �������� ������: {_StatisticsConteroller.GetOpenRequestQuantity()}";
            label2.Text = $"���������� �������� ������: {_StatisticsConteroller.GetCloseRequestQuantity()}";
            label3.Text = $"���������� ����������: {_StatisticsConteroller.GetClientQuantity()}";
            label4.Text = $"���������� ��������: {_StatisticsConteroller.GetMasterQuantity()}";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _UpdateStatistics();
        }

        private void SomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _UpdateStatistics();
        }
    }
}
