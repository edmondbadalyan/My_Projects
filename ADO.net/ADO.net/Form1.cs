using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\.; Integrated Security = True");
            connection.Open();
            string query = "select Id, Title, Rating, file_size_kb,duration_seconds from songs";
            using SqlCommand command = new SqlCommand(query, connection);

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string title = reader.GetString(1);
                int rating = reader.GetByte(2);
                int file_size = reader.GetInt32(3);
                int duration_seconds = reader.GetInt32(4);

                 


                listView1.Items.Add(new ListViewItem(new string[] { id.ToString(), title, rating.ToString(),
                     file_size.ToString(), duration_seconds.ToString()
                }));


            }

            
            int sum = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                sum += int.Parse(item.SubItems[columnFileSizeKb.Index].Text);
            }
            sumFileSize.Text = $"Sum File Size: {sum} KB";

            int sum1 = 0;
            foreach (ListViewItem item in listView1)
            {
                sum1 += int.Parse(item.SubItems[columnDuration.Index].Text);
            }
            sumDuration.Text = $"Total Duration: {sum1} ";

        }

    private void sumFileSize_Click(object sender, EventArgs e)
        {
            
        }

        private void sumDuration_Click(object sender, EventArgs e)
        {
            
        }
    }
}
