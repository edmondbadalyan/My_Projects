using System.Data;
using System.Data.SqlClient;

namespace Datatable_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Rating", typeof(int));

            table.Rows.Add(1, "Dramatic", 4);
            table.Rows.Add(2, "Wadachi", 3);
            table.Rows.Add(3, "Oddloop", 5);

            dataGridView1.DataSource = table;

            table.Rows.Add(4, "Say It", 5);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void executeCommand_Click(object sender, EventArgs e)
        {
            using IDbConnection conn = new SqlConnection();
        }
    }
}
