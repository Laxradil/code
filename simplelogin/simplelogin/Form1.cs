using simplelogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace simplelogin
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brion\Documents\simplelogin\loginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbutt_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                // Hash the entered password before checking it
                string hashedPassword = HashPassword(login_password.Text);

                string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", login_username.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Use hashed password

                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        // Start a session for the logged-in user
                        UserSession.StartSession(login_username.Text, "user@example.com");

                        MessageBox.Show("Logged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open menu form
                        Menuform sForm = new Menuform();
                        sForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            } 
            else
            {
                this.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '•';;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            SIGNUP sForm = new SIGNUP();
            sForm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
