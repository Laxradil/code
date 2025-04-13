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


namespace simplelogin
{
    public partial class Classform : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brion\Documents\simplelogin\loginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Classform()
        {
            InitializeComponent();
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            try
            {
                using (SqlConnection con = connect)
                {
                    string query = "SELECT ClassName, Day, Time, Teacher FROM Schedule";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message);
            }
        } 

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uploadform lForm = new Uploadform();
            lForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classform Cform = new Classform();
            Cform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrEmpty(txtClass.Text) || string.IsNullOrEmpty(txtDay.Text) ||
                string.IsNullOrEmpty(txtTime.Text) || string.IsNullOrEmpty(txtTeacher.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Using the existing 'connect' object
                string query = "INSERT INTO Schedule (ClassName, Day, Time, Teacher) VALUES (@Class, @Day, @Time, @Teacher)";
                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Class", txtClass.Text);
                cmd.Parameters.AddWithValue("@Day", txtDay.Text);
                cmd.Parameters.AddWithValue("@Time", txtTime.Text);
                cmd.Parameters.AddWithValue("@Teacher", txtTeacher.Text);

                connect.Open();  // Open the connection
                cmd.ExecuteNonQuery();  // Execute the insert command
                connect.Close();  // Close the connection

                // Reload the schedule after insertion
                LoadSchedule();

                // Clear the input fields
                txtClass.Clear();
                txtDay.Clear();
                txtTime.Clear();
                txtTeacher.Clear();

                // Confirmation message
                MessageBox.Show("Class schedule successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding schedule: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                string className = selectedRow.Cells["ClassName"].Value.ToString();
                string day = selectedRow.Cells["Day"].Value.ToString();
                string time = selectedRow.Cells["Time"].Value.ToString();
                string teacher = selectedRow.Cells["Teacher"].Value.ToString();

                var confirmResult = MessageBox.Show("Are you sure to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brion\Documents\simplelogin\loginData.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            string query = "DELETE FROM Schedule WHERE ClassName = @ClassName AND Day = @Day AND Time = @Time AND Teacher = @Teacher";
                            SqlCommand cmd = new SqlCommand(query, con);

                            cmd.Parameters.AddWithValue("@ClassName", className);
                            cmd.Parameters.AddWithValue("@Day", day);
                            cmd.Parameters.AddWithValue("@Time", time);
                            cmd.Parameters.AddWithValue("@Teacher", teacher);

                            con.Open();  // Open the connection
                            cmd.ExecuteNonQuery();  // Execute the delete command
                        }

                        LoadSchedule(); // Reload the schedule after deletion
                        MessageBox.Show("Class schedule successfully deleted!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting schedule: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void Class_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void Oras_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teacher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

