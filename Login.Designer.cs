namespace Coursework
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbLGPMobileNumber = new System.Windows.Forms.TextBox();
            this.tbLGPPin = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelS = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcboxUser = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcboxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxUser)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLGPMobileNumber
            // 
            this.tbLGPMobileNumber.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbLGPMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLGPMobileNumber.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLGPMobileNumber.Location = new System.Drawing.Point(79, 13);
            this.tbLGPMobileNumber.MaxLength = 11;
            this.tbLGPMobileNumber.Name = "tbLGPMobileNumber";
            this.tbLGPMobileNumber.Size = new System.Drawing.Size(277, 45);
            this.tbLGPMobileNumber.TabIndex = 2;
            this.tbLGPMobileNumber.TextChanged += new System.EventHandler(this.tbLGPMobileNumber_TextChanged);
            this.tbLGPMobileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLGPMobileNumber_KeyPress);
            // 
            // tbLGPPin
            // 
            this.tbLGPPin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbLGPPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLGPPin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLGPPin.Location = new System.Drawing.Point(76, 14);
            this.tbLGPPin.MaxLength = 4;
            this.tbLGPPin.Name = "tbLGPPin";
            this.tbLGPPin.Size = new System.Drawing.Size(280, 45);
            this.tbLGPPin.TabIndex = 3;
            this.tbLGPPin.TextChanged += new System.EventHandler(this.tbLGPPin_TextChanged);
            this.tbLGPPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLGPPin_KeyPress);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.Location = new System.Drawing.Point(387, 470);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(131, 47);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateNewAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewAccount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnCreateNewAccount.Location = new System.Drawing.Point(321, 577);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(265, 47);
            this.btnCreateNewAccount.TabIndex = 5;
            this.btnCreateNewAccount.Text = "Create New Account";
            this.btnCreateNewAccount.UseVisualStyleBackColor = false;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelS);
            this.panel1.Controls.Add(this.labelA);
            this.panel1.Controls.Add(this.labelW);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 660);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.BackColor = System.Drawing.Color.Transparent;
            this.labelS.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelS.Location = new System.Drawing.Point(69, 470);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(109, 34);
            this.labelS.TabIndex = 3;
            this.labelS.Text = "System";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelA.Location = new System.Drawing.Point(88, 374);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(72, 34);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "ATM";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.BackColor = System.Drawing.Color.Transparent;
            this.labelW.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelW.Location = new System.Drawing.Point(12, 280);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(219, 30);
            this.labelW.TabIndex = 1;
            this.labelW.Text = "Welcome to your";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Black;
            this.btnX.Location = new System.Drawing.Point(617, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(57, 53);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(275, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log into your account";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcboxUser);
            this.panel2.Controls.Add(this.tbLGPMobileNumber);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(246, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 71);
            this.panel2.TabIndex = 8;
            // 
            // pcboxUser
            // 
            this.pcboxUser.Image = ((System.Drawing.Image)(resources.GetObject("pcboxUser.Image")));
            this.pcboxUser.Location = new System.Drawing.Point(3, 3);
            this.pcboxUser.Name = "pcboxUser";
            this.pcboxUser.Size = new System.Drawing.Size(70, 65);
            this.pcboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxUser.TabIndex = 3;
            this.pcboxUser.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.pcboxLogo);
            this.panel3.Controls.Add(this.tbLGPPin);
            this.panel3.Location = new System.Drawing.Point(246, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 77);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pcboxLogo
            // 
            this.pcboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcboxLogo.Image")));
            this.pcboxLogo.Location = new System.Drawing.Point(3, 14);
            this.pcboxLogo.Name = "pcboxLogo";
            this.pcboxLogo.Size = new System.Drawing.Size(67, 54);
            this.pcboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxLogo.TabIndex = 4;
            this.pcboxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(670, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateNewAccount);
            this.Controls.Add(this.btnLogIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLGPMobileNumber;
        private System.Windows.Forms.TextBox tbLGPPin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcboxUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcboxLogo;
    }
}