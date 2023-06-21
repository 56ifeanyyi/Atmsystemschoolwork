namespace Coursework
{
    partial class atmSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atmSystem));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblloggedInUser = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblUserMoney = new System.Windows.Forms.Label();
            this.btnCashWithdrawal = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPin = new System.Windows.Forms.Button();
            this.lblLastLoggedIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogout.Location = new System.Drawing.Point(12, 577);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(225, 60);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblloggedInUser
            // 
            this.lblloggedInUser.AutoSize = true;
            this.lblloggedInUser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedInUser.ForeColor = System.Drawing.Color.Black;
            this.lblloggedInUser.Location = new System.Drawing.Point(315, 109);
            this.lblloggedInUser.Name = "lblloggedInUser";
            this.lblloggedInUser.Size = new System.Drawing.Size(225, 34);
            this.lblloggedInUser.TabIndex = 1;
            this.lblloggedInUser.Text = "Mobile Number";
            this.lblloggedInUser.Visible = false;
            this.lblloggedInUser.Click += new System.EventHandler(this.lblloggedInUser_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.Black;
            this.lblCash.Location = new System.Drawing.Point(476, 165);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(97, 39);
            this.lblCash.TabIndex = 3;
            this.lblCash.Text = "Cash";
            this.lblCash.Visible = false;
            // 
            // lblUserMoney
            // 
            this.lblUserMoney.AutoSize = true;
            this.lblUserMoney.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMoney.ForeColor = System.Drawing.Color.Black;
            this.lblUserMoney.Location = new System.Drawing.Point(314, 165);
            this.lblUserMoney.Name = "lblUserMoney";
            this.lblUserMoney.Size = new System.Drawing.Size(156, 39);
            this.lblUserMoney.TabIndex = 4;
            this.lblUserMoney.Text = "Balance:";
            // 
            // btnCashWithdrawal
            // 
            this.btnCashWithdrawal.BackColor = System.Drawing.Color.Black;
            this.btnCashWithdrawal.FlatAppearance.BorderSize = 0;
            this.btnCashWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashWithdrawal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashWithdrawal.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCashWithdrawal.Location = new System.Drawing.Point(3, 242);
            this.btnCashWithdrawal.Name = "btnCashWithdrawal";
            this.btnCashWithdrawal.Size = new System.Drawing.Size(237, 74);
            this.btnCashWithdrawal.TabIndex = 5;
            this.btnCashWithdrawal.Text = "Withdraw Money";
            this.btnCashWithdrawal.UseVisualStyleBackColor = false;
            this.btnCashWithdrawal.Click += new System.EventHandler(this.btnCashWithdrawal_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.Black;
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheckBalance.Location = new System.Drawing.Point(3, 322);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(237, 74);
            this.btnCheckBalance.TabIndex = 6;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(602, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnPin);
            this.panel1.Controls.Add(this.btnCashWithdrawal);
            this.panel1.Controls.Add(this.btnCheckBalance);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 660);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnPin
            // 
            this.btnPin.FlatAppearance.BorderSize = 0;
            this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPin.Location = new System.Drawing.Point(12, 430);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(225, 60);
            this.btnPin.TabIndex = 12;
            this.btnPin.Text = "Change Pin";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // lblLastLoggedIn
            // 
            this.lblLastLoggedIn.AutoSize = true;
            this.lblLastLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLoggedIn.Location = new System.Drawing.Point(422, 595);
            this.lblLastLoggedIn.Name = "lblLastLoggedIn";
            this.lblLastLoggedIn.Size = new System.Drawing.Size(141, 25);
            this.lblLastLoggedIn.TabIndex = 13;
            this.lblLastLoggedIn.Text = "Last log in time";
            this.lblLastLoggedIn.Click += new System.EventHandler(this.lblLastLoggedIn_Click);
            // 
            // atmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(670, 660);
            this.Controls.Add(this.lblLastLoggedIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUserMoney);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblloggedInUser);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "atmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.atmSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblloggedInUser;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblUserMoney;
        private System.Windows.Forms.Button btnCashWithdrawal;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Label lblLastLoggedIn;
    }
}