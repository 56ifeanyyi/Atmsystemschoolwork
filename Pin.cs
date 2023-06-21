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

    public partial class Pin : Form
    {
        SqlConnection connection;
        private string mobileNumber;
        private int initialBalance;
        private DateTime lastLoggedIn;
        public Pin(string mobileNumber, int initialBalance, DateTime lastLoggedIn)
        {
            InitializeComponent();
            this.mobileNumber = mobileNumber;
            this.initialBalance = initialBalance;   
            this.lastLoggedIn = lastLoggedIn;  
        }

        private void Pin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iUdeagwu\Aston\System Development module\Coursework submissions\Coursework\ClientDatabase.mdf"";Integrated Security=True");
            connection.Open();
        }

        private void btnConfirmPin_Click(object sender, EventArgs e)
        {
            int oldPin = int.Parse(txtBoxOldPin.Text);
            int newPin = int.Parse(txtBoxNewPin.Text);
            int confirmNewPin = int.Parse(txtBoxConfirmPin.Text);
            int newpinLength = txtBoxNewPin.Text.Length;
            String checking = "Select * from ClientTable where pin = @oldPin";
            // selects from the table where the pin is the old pin
            SqlCommand cmd = new SqlCommand(checking, connection);
            cmd.Parameters.AddWithValue("@oldPin", oldPin);
            SqlDataReader executeChecker = cmd.ExecuteReader();
            // runs the command
            if (executeChecker.Read())
            
            {
                // if the old pin exists in the database
                if (newpinLength == 4)
                    //check if the user entered 4 numbers in the new pin slot
                {



                    if (newPin == confirmNewPin)
                    {

                        //checks if the new pin and the confirm new pin are the same, if they are
                        //allows the change of pin to happen
                        //updates the database
                        string sql = "UPDATE ClientTable SET pin = @confirmNewPin WHERE pin = @oldPin";


                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@confirmNewPin", confirmNewPin);
                            command.Parameters.AddWithValue("@oldPin", oldPin);
                            executeChecker.Close();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Your pin has been changed");
                        }

                    }
                    else
                    {
                        // if they are not, says this
                        MessageBox.Show("Your new pin do not match the confirm pin. Thanks");
                        executeChecker.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough numbers for the pin");
                }
                
            }
            else
            {
                MessageBox.Show("Your old pin is not correct");
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            atmSystem atmSystem = new atmSystem(mobileNumber, initialBalance, lastLoggedIn);
            atmSystem.Show();

        }

        private void txtBoxOldPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBoxNewPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxConfirmPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtBoxNewPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
