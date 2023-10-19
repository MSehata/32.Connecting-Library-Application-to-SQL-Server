using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Policy;
using System.Data.Sql;
using Habanero.DB;
using Habanero.Base;

namespace _32.Connecting_Library_Application_to_SQL_Server
{
    public partial class Form1 : Form
    {
        static SqlConnection connectionString = new SqlConnection(@"Data Source=MINDWORX;Initial Catalog=pubs;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();

        }

        public static DataTable dataAdapterSelect(string sqlQuery)
        {
            // This method will convert any Select string to a query.
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            return dt;
        }



        public static void sqlCommandQueryReader(string sqlQuery)
        {
            SqlCommand myCommand = new SqlCommand(sqlQuery, connectionString);
            myCommand.Connection.Open();
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
            }
            myCommand.Connection.Close();
           
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";

                // Define columns programmatically
                dataGridView1.Columns.Add("title_id", "Title ID");
                dataGridView1.Columns.Add("pub_name", "Publisher Name");
                dataGridView1.Columns.Add("price", "Price");
                dataGridView1.Columns.Add("ytd_sales", "YTD Sales");
                dataGridView1.Columns.Add("title", "Title");
                dataGridView1.Columns.Add("type", "Type");

                DataTable dt = dataAdapterSelect(sqlQuery);

                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);
                }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sqlQuery = "SELECT title_id,title,type,pub_name,price,ytd_sales FROM titles inner join publishers ON titles.pub_id = publishers.pub_id";

            DataTable dt = dataAdapterSelect(sqlQuery);

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["pub_name"], dr["price"], dr["ytd_sales"], dr["title"], dr["type"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();

            // Show the Add form
            addForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete deleteForm = new Delete();
            deleteForm.Show();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.Show();
        }

        private void tabAuthors_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "Data Source=MINDWORX;Initial Catalog=pubs;Integrated Security=True"; // Modify with your database connection details.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve authors data
                string sqlQuery2 = "SELECT * FROM authors ORDER BY au_fname ASC";
                DataTable dt2 = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery2, connection))
                {
                    adapter.Fill(dt2);
                }

                dataGridView2.Rows.Clear();

                foreach (DataRow dr in dt2.Rows)
                {
                    dataGridView2.Rows.Add(dr["au_id"], dr["au_fname"], dr["phone"], dr["address"], dr["city"]);
                }

                // Retrieve and display author book counts
                string sqlQuery3 = "SELECT authors.au_fname, COUNT(titleauthor.title_id) as authorcount FROM authors INNER JOIN titleauthor ON authors.au_id = titleauthor.au_id GROUP BY authors.au_fname";
                DataTable dt3 = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery3, connection))
                {
                    adapter.Fill(dt3);
                }

                dataGridView2.Rows.Clear();

                foreach (DataRow dr in dt3.Rows)
                {
                    dataGridView2.Rows.Add(dr["au_fname"], dr["authorcount"]);
                }
            }
        }
    }
}

