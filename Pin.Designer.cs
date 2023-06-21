namespace Coursework
{
    partial class Pin
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
            this.lblOldPIn = new System.Windows.Forms.Label();
            this.lblNewPin = new System.Windows.Forms.Label();
            this.lblConfirmPin = new System.Windows.Forms.Label();
            this.txtBoxOldPin = new System.Windows.Forms.TextBox();
            this.txtBoxNewPin = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmPin = new System.Windows.Forms.TextBox();
            this.btnConfirmPin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPIn
            // 
            this.lblOldPIn.AutoSize = true;
            this.lblOldPIn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPIn.Location = new System.Drawing.Point(47, 81);
            this.lblOldPIn.Name = "lblOldPIn";
            this.lblOldPIn.Size = new System.Drawing.Size(113, 34);
            this.lblOldPIn.TabIndex = 0;
            this.lblOldPIn.Text = "Old Pin";
            // 
            // lblNewPin
            // 
            this.lblNewPin.AutoSize = true;
            this.lblNewPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPin.Location = new System.Drawing.Point(46, 202);
            this.lblNewPin.Name = "lblNewPin";
            this.lblNewPin.Size = new System.Drawing.Size(145, 39);
            this.lblNewPin.TabIndex = 1;
            this.lblNewPin.Text = "New Pin";
            // 
            // lblConfirmPin
            // 
            this.lblConfirmPin.AutoSize = true;
            this.lblConfirmPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPin.Location = new System.Drawing.Point(46, 343);
            this.lblConfirmPin.Name = "lblConfirmPin";
            this.lblConfirmPin.Size = new System.Drawing.Size(196, 39);
            this.lblConfirmPin.TabIndex = 2;
            this.lblConfirmPin.Text = "Confirm Pin";
            // 
            // txtBoxOldPin
            // 
            this.txtBoxOldPin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxOldPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOldPin.Location = new System.Drawing.Point(306, 74);
            this.txtBoxOldPin.MaxLength = 4;
            this.txtBoxOldPin.Name = "txtBoxOldPin";
            this.txtBoxOldPin.Size = new System.Drawing.Size(216, 47);
            this.txtBoxOldPin.TabIndex = 3;
            this.txtBoxOldPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOldPin_KeyPress);
            // 
            // txtBoxNewPin
            // 
            this.txtBoxNewPin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxNewPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPin.Location = new System.Drawing.Point(306, 202);
            this.txtBoxNewPin.MaxLength = 4;
            this.txtBoxNewPin.Name = "txtBoxNewPin";
            this.txtBoxNewPin.Size = new System.Drawing.Size(216, 47);
            this.txtBoxNewPin.TabIndex = 4;
            this.txtBoxNewPin.TextChanged += new System.EventHandler(this.txtBoxNewPin_TextChanged);
            this.txtBoxNewPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNewPin_KeyPress);
            // 
            // txtBoxConfirmPin
            // 
            this.txtBoxConfirmPin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBoxConfirmPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPin.Location = new System.Drawing.Point(306, 340);
            this.txtBoxConfirmPin.MaxLength = 4;
            this.txtBoxConfirmPin.Name = "txtBoxConfirmPin";
            this.txtBoxConfirmPin.Size = new System.Drawing.Size(216, 47);
            this.txtBoxConfirmPin.TabIndex = 5;
            this.txtBoxConfirmPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxConfirmPin_KeyPress);
            // 
            // btnConfirmPin
            // 
            this.btnConfirmPin.BackColor = System.Drawing.Color.Black;
            this.btnConfirmPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmPin.Location = new System.Drawing.Point(201, 481);
            this.btnConfirmPin.Name = "btnConfirmPin";
            this.btnConfirmPin.Size = new System.Drawing.Size(221, 71);
            this.btnConfirmPin.TabIndex = 6;
            this.btnConfirmPin.Text = "Change Pin";
            this.btnConfirmPin.UseVisualStyleBackColor = false;
            this.btnConfirmPin.Click += new System.EventHandler(this.btnConfirmPin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(587, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 54);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(648, 604);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirmPin);
            this.Controls.Add(this.txtBoxConfirmPin);
            this.Controls.Add(this.txtBoxNewPin);
            this.Controls.Add(this.txtBoxOldPin);
            this.Controls.Add(this.lblConfirmPin);
            this.Controls.Add(this.lblNewPin);
            this.Controls.Add(this.lblOldPIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin";
            this.Load += new System.EventHandler(this.Pin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPIn;
        private System.Windows.Forms.Label lblNewPin;
        private System.Windows.Forms.Label lblConfirmPin;
        private System.Windows.Forms.TextBox txtBoxOldPin;
        private System.Windows.Forms.TextBox txtBoxNewPin;
        private System.Windows.Forms.TextBox txtBoxConfirmPin;
        private System.Windows.Forms.Button btnConfirmPin;
        private System.Windows.Forms.Button btnClose;
    }
}