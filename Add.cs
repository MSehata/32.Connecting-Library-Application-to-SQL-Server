using Habanero.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _32.Connecting_Library_Application_to_SQL_Server
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string titleID = txtTitleID.Text;
            string titleName = txtTitleName.Text;
            string titleType = txtTitleType.Text;
            string pubid = comboPublisherID.Text;
            string price = txtPrice.Text;
            string pubDate = txtPublishDate.Text;

            string connectionString = "Data Source=MINDWORX;Initial Catalog=pubs;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO titles (title_id, title, type, pub_id, price, pubdate) " +
                                         "VALUES (@titleID, @titleName, @titleType, @pubid, @price, @pubDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@titleID", titleID);
                        command.Parameters.AddWithValue("@titleName", titleName);
                        command.Parameters.AddWithValue("@titleType", titleType);
                        command.Parameters.AddWithValue("@pubid", pubid);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@pubDate", pubDate);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information inserted!");
                        }
                        else
                        {
                            MessageBox.Show("Insertion failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet.publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.pubsDataSet.publishers);

        }
    }
}