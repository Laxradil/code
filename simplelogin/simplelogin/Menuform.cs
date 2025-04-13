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


namespace simplelogin
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Uploadform lForm = new Uploadform();
            lForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classform Cform = new Classform();
            Cform.Show();
            this.Hide();
        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            string loggedInUser = UserSession.GetUsername();
            labelWelcome.Text = "Welcome, " + loggedInUser; // Make sure labelWelcome exists
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuform sForm = new Menuform();
            sForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classform Cform = new Classform();
            Cform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uploadform lForm = new Uploadform();
            lForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menuform sForm = new Menuform();
            sForm.Show();
            this.Hide();
        }

        private void logoutbutt_Click(object sender, EventArgs e)
        {
            UserSession.EndSession();
            MessageBox.Show("Logged out successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
