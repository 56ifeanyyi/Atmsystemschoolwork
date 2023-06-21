using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace Coursework
{
    public partial class atmSystem : Form
    {
        SqlConnection connection;
        SqlDataReader reader;
        private string mobileNumber;
        private int initialBalance;
        private DateTime lastLoggedin;
        


        public atmSystem(string mobileNumber, int initialBalance, DateTime lastLoggedIn)
        { // Initialize the form with the logged-in user and initial balance
            InitializeComponent();

            this.mobileNumber = mobileNumber;
            this.initialBalance = initialBalance;
            this.lastLoggedin = lastLoggedIn;
            lblloggedInUser.Text = "User:" + mobileNumber;
            lblCash.Text = "$" + initialBalance.ToString();
            //equates the initial balance to the cash label so it can display it on the atm system
            lblLastLoggedIn.Text = lastLoggedIn.ToString();
            //equates the last logged in time to the last log in label so it can display it on the atm system



        }

        private void atmSystem_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\iUdeagwu\Aston\System Development module\Coursework submissions\Coursework\ClientDatabase.mdf"";Integrated Security=True");
            connection.Open();
            lblloggedInUser.Visible = true;
            // makes the label for the user visible
            lblCash.Visible = true;
            //makes the cash visible



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {


            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void lblloggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {


            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the amount to withdraw:", "Withdrawal", "");
            int amount;
            
            

            // tries to parse the users input as an integer
            if (int.TryParse(input, out amount))
            {
                if (amount % 10 == 0)
                {
                    SqlCommand checkDailyLimit = new SqlCommand("SELECT dailyLimit FROM ClientTable where mobileNumber = @mobileNumber",connection);
                    //selects the daily limit from the clienttable
                    checkDailyLimit.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                    SqlDataReader checkDailyLimitRead =  checkDailyLimit.ExecuteReader();
                    // executes the command 
                    if (checkDailyLimitRead.Read())
                        //if it reads
                    {
                int dailyLimit = (int)checkDailyLimitRead["dailyLimit"];
                        //store the daily limit inside a local variable called daily limit
                                
                        int moneyWithdrawn = dailyLimit + amount;
                        checkDailyLimitRead.Close();
                        //equaltes the total money withdrawn to the dailylimit + amount
                        if (moneyWithdrawn < 1000)
                        // checks if the money withdrawn is less than 1000 or will be less than 1000
                        //if it is allow the withdrawal process to heppen
                        {
                            if (initialBalance >= amount)
                            {
                                //checks if the money in account is greater or equal to the amount they want to withdraw
                                checkDailyLimitRead.Close();
                                // Subtract the withdrawal amount from the balance
                                initialBalance -= amount;

                                // Update the balance label
                                lblCash.Text = "$" + initialBalance.ToString();

                                // Show a success message
                                MessageBox.Show("Withdrawal successful.");
                                SqlCommand updateBalance = new SqlCommand("UPDATE ClientTable SET initialBalance = @initialBalance where mobileNumber = @mobileNumber", connection);
                                //updates the balance in the table with the new balance 
                                updateBalance.Parameters.AddWithValue("@initialBalance", initialBalance);
                                updateBalance.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                                updateBalance.ExecuteNonQuery();


                                SqlCommand updateDailyLimit = new SqlCommand("UPDATE ClientTable SET dailyLimit = @dailyLimit where mobileNumber = @mobileNumber", connection);
                                //updates the amount of money they have withdrawn
                                updateDailyLimit.Parameters.AddWithValue("@dailyLimit", moneyWithdrawn);
                                updateDailyLimit.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                                updateDailyLimit.ExecuteNonQuery();

                            }
                            else
                            {
                                checkDailyLimitRead.Close();
                                // Show an error message if the user doesn't have enough balance
                                MessageBox.Show("Insufficient funds. Please enter a smaller amount.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You have reached your limit for the day");
                        }
                    }

                    // if successful Check if the user has enough balance to make the withdrawal
                    
                }
                else
                {
                    MessageBox.Show("You can only withdraw a mutltipe of 10 and you have a daily limit" +
                        "of 1000 a day");
                }

            }


            else
            {
                // Show an error message if the user's input is not a valid integer
                MessageBox.Show("Please enter a valid number.");

            }
        }







        private void btnCheckBalance_Click(object sender, EventArgs e)
        {


            // Create a new SQL command to retrieve the money of that particular user from the database
            SqlCommand command = new SqlCommand("SELECT initialBalance FROM ClientTable WHERE mobileNumber = @mobileNumber", connection);
            //use to ensure the sql command sees@mobile number as a parameter and not a continuation of statment
            command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
            // execute the command and equate the result to a local variable

            int moneyInAccount = (int)command.ExecuteScalar();
            // Display the account balance in a message box
            MessageBox.Show("Your account balance is: $" + moneyInAccount.ToString());
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pin pin = new Pin(mobileNumber, initialBalance, lastLoggedin);
            pin.Show();



        }

        private void lblLastLoggedIn_Click(object sender, EventArgs e)
        {

        }
    }
}
