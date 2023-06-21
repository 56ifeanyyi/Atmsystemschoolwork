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
using static System.Windows.Forms.AxHost;

namespace Coursework

{

    public partial class Register : Form

    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;


        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iUdeagwu\Aston\System Development module\Coursework submissions\Coursework\ClientDatabase.mdf"";Integrated Security=True");
            connection.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            // Get the length of mobile number and pin input
            int numberLength = txtBoxMobileNumber.Text.Length;
            int pinLength = txtBoxPin.Text.Length;
            int dailyLimit = 0;
            // Check if mobile number, pin, and initial balance are empty or if their lengths are not valid
            if (string.IsNullOrWhiteSpace(txtBoxMobileNumber.Text) &&
               
                string.IsNullOrWhiteSpace(txtBoxPin.Text) &&string.IsNullOrWhiteSpace(tbInitialBalance.Text) && numberLength != 11 && pinLength!=4) 
            {
                // Show a message box indicating that a valid mobile number and pin are required for registration
                MessageBox.Show("Please enter a valid your mobile number and pin in order to register your account");

            }
            else {
                command = new SqlCommand("select * from ClientTable where mobileNumber='" + txtBoxMobileNumber.Text + "'", connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    MessageBox.Show("This user already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reader.Close();
                    command = new SqlCommand("INSERT into ClientTable values(@mobileNumber,@pin,@balance, GETDATE(),@dailyLimit)", connection);
                    command.Parameters.AddWithValue("mobileNumber", txtBoxMobileNumber.Text);
                    command.Parameters.AddWithValue("pin", txtBoxPin.Text);
                    command.Parameters.AddWithValue("balance", tbInitialBalance.Text);
                    command.Parameters.AddWithValue("dailyLimit", dailyLimit);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            // Create a new instance of the Login form and show it, then hide the register form
            Login login = new Login();
            login.Show();
            this.Hide();
            
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the register page and create a new instance of the Login form and show it
            this.Close();
            Login login = new Login();
            login.Show();
            

        }

        private void txtBoxMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // used to only allow digits to be entered in the textbox can be commented out etc to allow the use of backspace if need be
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBoxPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // used to only allow digits to be entered in the textbox can be commented out etc to allow the use of backspace if need be
            e.Handled = !char.IsNumber(e.KeyChar);
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // used to only allow digits to be entered in the textbox can be commented out etc to allow the use of backspace if need be
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the register page and create a new instance of the Login form and show it
            this.Close();
            Login login = new Login();
            login.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbInitialBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInitialBalance_Click(object sender, EventArgs e)
        {

        }
    }

 
}
