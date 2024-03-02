using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Practic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sahal Sajeed\\Documents\\StudentData.mdf\";Integrated Security=True;Connect Timeout=30");
            connection.Open();
            String QUERRY = "INSERT INTO stdTable VALUES(@fname, @lname, @email, @address)";
            SqlCommand command = new SqlCommand(QUERRY, connection);
            command.Parameters.AddWithValue("@fname", fname.Text);
            command.Parameters.AddWithValue("@lname", lname.Text);
            command.Parameters.AddWithValue("@email", email.Text);
            command.Parameters.AddWithValue("@address", address.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student Data Added Successfully");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
    }
}
