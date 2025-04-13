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
using System.IO; 
using System.Diagnostics;

namespace simplelogin
{
    public partial class Uploadform : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brion\Documents\simplelogin\loginData.mdf;Integrated Security=True;Connect Timeout=30");

        public Uploadform()
        {
            InitializeComponent();
            LoadPdfList();
        }
        private void LoadPdfList()
        {
            listboxfiles.Items.Clear(); // Clear list before adding new items
            string loggedInUser = UserSession.GetUsername(); // Get current user

            if (string.IsNullOrEmpty(loggedInUser))
            {
                MessageBox.Show("No active session detected. Please log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT Id, FileName FROM PdfFiles WHERE UploadedBy = @UploadedBy"; // Only fetch user-specific files

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@UploadedBy", loggedInUser);

                if (connect.State != ConnectionState.Open)
                    connect.Open();

                using (SqlDataReader reader = cmd.ExecuteReader()) // Read data
                {
                    while (reader.Read()) // Loop through each record
                    {
                        listboxfiles.Items.Add(reader["Id"] + " - " + reader["FileName"]);
                        // Format: "1 - FileName.pdf"
                    }
                }
                connect.Close();
            }
        }

        private void Uploadform_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Menuform sForm = new Menuform();
            sForm.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {

            acct_info.Visible = true;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            acct_info.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                byte[] pdfData = File.ReadAllBytes(filePath);
                string fileName = Path.GetFileName(filePath);
                string loggedInUser = UserSession.GetUsername(); // Get logged-in user

                if (string.IsNullOrEmpty(loggedInUser))
                {
                    MessageBox.Show("No active session detected. Please log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO PdfFiles (FileName, PdfData, UploadedBy) VALUES (@FileName, @PdfData, @UploadedBy)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@PdfData", pdfData);
                    cmd.Parameters.AddWithValue("@UploadedBy", loggedInUser); // Store uploader's username

                    if (connect.State != ConnectionState.Open)
                        connect.Open();

                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

                MessageBox.Show("PDF Uploaded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPdfList();
            }
        }

        private void listboxfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxfiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a PDF to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(listboxfiles.SelectedItem.ToString().Split('-')[0].Trim());
            // Extracts the PDF ID from "1 - FileName.pdf"

            string query = "SELECT PdfData FROM PdfFiles WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@Id", selectedId);

                if (connect.State != ConnectionState.Open)
                    connect.Open();

                byte[] pdfData = cmd.ExecuteScalar() as byte[];
                connect.Close();

                if (pdfData != null)
                {
                    string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.pdf");
                    File.WriteAllBytes(tempFilePath, pdfData);
                    System.Diagnostics.Process.Start(tempFilePath); // Opens the PDF
                }
                else
                {
                    MessageBox.Show("Error retrieving the PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (listboxfiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a PDF to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(listboxfiles.SelectedItem.ToString().Split('-')[0].Trim());
            string loggedInUser = UserSession.GetUsername();

            string query = "SELECT PdfData FROM PdfFiles WHERE Id = @Id AND UploadedBy = @UploadedBy"; // Ensuring user-specific access

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@Id", selectedId);
                cmd.Parameters.AddWithValue("@UploadedBy", loggedInUser); // Restrict access to current user

                if (connect.State != ConnectionState.Open)
                    connect.Open();

                byte[] pdfData = cmd.ExecuteScalar() as byte[];
                connect.Close();

                if (pdfData != null)
                {
                    string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.pdf");
                    File.WriteAllBytes(tempFilePath, pdfData);
                    Process.Start(tempFilePath); // Open PDF
                }
                else
                {
                    MessageBox.Show("You do not have permission to view this file.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listboxfiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a PDF to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(listboxfiles.SelectedItem.ToString().Split('-')[0].Trim());
            string loggedInUser = UserSession.GetUsername();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this PDF?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM PdfFiles WHERE Id = @Id AND UploadedBy = @UploadedBy"; // Prevent unauthorized deletion

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.Parameters.AddWithValue("@UploadedBy", loggedInUser); // Ensure only uploader can delete

                    if (connect.State != ConnectionState.Open)
                        connect.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("PDF Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPdfList(); // Refresh ListBox
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to delete this file.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
