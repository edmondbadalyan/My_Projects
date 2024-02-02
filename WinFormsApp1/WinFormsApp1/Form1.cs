using System.Data;
using System.Diagnostics;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            // Create a DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Memory", typeof(long));

            // Populate the DataTable with process information
            foreach (Process process in processes)
            {
                dt.Rows.Add(process.ProcessName, process.Id, process.WorkingSet64);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение списка процессов
            Process[] processes = Process.GetProcesses();

            // Создание DataTable и добавление данных о процессах
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Memory", typeof(long));

            foreach (Process process in processes)
            {
                dt.Rows.Add(process.ProcessName, process.Id, process.WorkingSet64);
            }

            // Обновление dataGridView
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedProcessId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                Process selectedProcess = Process.GetProcessById(selectedProcessId);
                if (selectedProcess != null)
                {
                    try
                    {
                        selectedProcess.Kill(); // Убиваем выбранный процесс
                         // Обновляем список процессов в dataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при завершении процесса: " + ex.Message);
                    }
                }
            }
        }
    }
}
