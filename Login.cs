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

namespace Coursework
{
    public partial class Login : Form

    {
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)

        {

            command = new SqlCommand("SELECT * FROM ClientTable WHERE mobileNumber = @mobileNumber AND pin = @pin", connection);
            command.Parameters.AddWithValue("@mobileNumber", tbLGPMobileNumber.Text);
            command.Parameters.AddWithValue("@pin", tbLGPPin.Text);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                DateTime lastLoginTime = (DateTime)reader["lastLoggedIn"];
                int initialBalance = (int)reader["initialBalance"];
                reader.Close();

                command = new SqlCommand("UPDATE ClientTable SET lastLoggedIn = GETDATE() WHERE mobileNumber = @mobileNumber", connection);
                command.Parameters.AddWithValue("@mobileNumber", tbLGPMobileNumber.Text);
                command.ExecuteNonQuery();
                this.Hide();
                // Create and show a new instance of the atmSystem form with the mobile number and initial balance of the client
                atmSystem atmSystem = new atmSystem(tbLGPMobileNumber.Text, initialBalance, lastLoginTime);
                atmSystem.Show();
                reader.Close();

            }
            else
            {
                reader.Close ();
                MessageBox.Show("This user does not exist in our system");
            }



        }

        private void tbLGPMobileNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iUdeagwu\Aston\System Development module\Coursework submissions\Coursework\ClientDatabase.mdf"";Integrated Security=True");
            connection.Open();
        }

        private void tbLGPMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // used to only allow digits to be entered in the textbox can be commented out etc to allow the use of backspace if need be
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void tbLGPPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // used to only allow digits to be entered in the textbox can be commented out etc to allow the use of backspace if need be
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void lblLGMobileNumber_Click(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            //create and show a new instance of the register form, then hide the login form
            Register register = new Register();
            register.Show();
            this.Hide();

        }
            
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLGPIn_Click(object sender, EventArgs e)
        {

        }

       
        
        
        
        private void tbLGPPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
