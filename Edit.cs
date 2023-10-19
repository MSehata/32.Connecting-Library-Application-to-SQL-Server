using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _32.Connecting_Library_Application_to_SQL_Server
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Titlename = txtNewTitleName.Text;
            string Titletype = txtNewTitleType.Text;
            string Titleprice = txtNewTitlePrice.Text;

            string oid = txtTitleID.Text;
            string oname = txtTitleName.Text;

            if (string.IsNullOrWhiteSpace(Titlename) || string.IsNullOrWhiteSpace(Titletype) ||
                string.IsNullOrWhiteSpace(Titleprice) || string.IsNullOrWhiteSpace(oid) || string.IsNullOrWhiteSpace(oname))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                string connectionString = "Data Source=MINDWORX;Initial Catalog=pubs;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string editQuery = "UPDATE titles SET title = @Titlename, type = @Titletype, price = @Titleprice WHERE title_id = @oid AND title = @oname";

                    using (SqlCommand command = new SqlCommand(editQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Titlename", Titlename);
                        command.Parameters.AddWithValue("@Titletype", Titletype);
                        command.Parameters.AddWithValue("@Titleprice", Titleprice);
                        command.Parameters.AddWithValue("@oid", oid);
                        command.Parameters.AddWithValue("@oname", oname);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Title has been edited!");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check your input.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
