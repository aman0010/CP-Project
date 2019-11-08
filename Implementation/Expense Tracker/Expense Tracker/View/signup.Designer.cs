namespace Expense_Tracker.View
{
    partial class signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signup_signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_signup_repassword = new System.Windows.Forms.TextBox();
            this.txt_signup_password = new System.Windows.Forms.TextBox();
            this.txt_signup_lname = new System.Windows.Forms.TextBox();
            this.txt_signup_fname = new System.Windows.Forms.TextBox();
            this.txt_signup_username = new System.Windows.Forms.TextBox();
            this.btn_signup_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sign Up";
            // 
            // btn_signup_signup
            // 
            this.btn_signup_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup_signup.Location = new System.Drawing.Point(249, 479);
            this.btn_signup_signup.Name = "btn_signup_signup";
            this.btn_signup_signup.Size = new System.Drawing.Size(155, 42);
            this.btn_signup_signup.TabIndex = 6;
            this.btn_signup_signup.Text = "Sign Up";
            this.btn_signup_signup.UseVisualStyleBackColor = true;
            this.btn_signup_signup.Click += new System.EventHandler(this.Btn_signup_signup_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Re-enter Password";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // txt_signup_repassword
            // 
            this.txt_signup_repassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signup_repassword.Location = new System.Drawing.Point(129, 382);
            this.txt_signup_repassword.Multiline = true;
            this.txt_signup_repassword.Name = "txt_signup_repassword";
            this.txt_signup_repassword.PasswordChar = '#';
            this.txt_signup_repassword.Size = new System.Drawing.Size(275, 30);
            this.txt_signup_repassword.TabIndex = 5;
            this.txt_signup_repassword.UseSystemPasswordChar = true;
            // 
            // txt_signup_password
            // 
            this.txt_signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signup_password.Location = new System.Drawing.Point(129, 321);
            this.txt_signup_password.Multiline = true;
            this.txt_signup_password.Name = "txt_signup_password";
            this.txt_signup_password.PasswordChar = '#';
            this.txt_signup_password.Size = new System.Drawing.Size(275, 30);
            this.txt_signup_password.TabIndex = 4;
            this.txt_signup_password.UseSystemPasswordChar = true;
            // 
            // txt_signup_lname
            // 
            this.txt_signup_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signup_lname.Location = new System.Drawing.Point(273, 262);
            this.txt_signup_lname.Multiline = true;
            this.txt_signup_lname.Name = "txt_signup_lname";
            this.txt_signup_lname.Size = new System.Drawing.Size(131, 30);
            this.txt_signup_lname.TabIndex = 3;
            // 
            // txt_signup_fname
            // 
            this.txt_signup_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signup_fname.Location = new System.Drawing.Point(129, 261);
            this.txt_signup_fname.Multiline = true;
            this.txt_signup_fname.Name = "txt_signup_fname";
            this.txt_signup_fname.Size = new System.Drawing.Size(131, 30);
            this.txt_signup_fname.TabIndex = 2;
            // 
            // txt_signup_username
            // 
            this.txt_signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signup_username.Location = new System.Drawing.Point(129, 202);
            this.txt_signup_username.Multiline = true;
            this.txt_signup_username.Name = "txt_signup_username";
            this.txt_signup_username.Size = new System.Drawing.Size(275, 30);
            this.txt_signup_username.TabIndex = 1;
            // 
            // btn_signup_back
            // 
            this.btn_signup_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup_back.Location = new System.Drawing.Point(819, 123);
            this.btn_signup_back.Name = "btn_signup_back";
            this.btn_signup_back.Size = new System.Drawing.Size(131, 42);
            this.btn_signup_back.TabIndex = 7;
            this.btn_signup_back.Text = "Back";
            this.btn_signup_back.UseVisualStyleBackColor = true;
            this.btn_signup_back.Click += new System.EventHandler(this.Btn_signup_back_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signup_signup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_signup_repassword);
            this.Controls.Add(this.txt_signup_password);
            this.Controls.Add(this.txt_signup_lname);
            this.Controls.Add(this.txt_signup_fname);
            this.Controls.Add(this.txt_signup_username);
            this.Controls.Add(this.btn_signup_back);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signup_signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_signup_repassword;
        private System.Windows.Forms.TextBox txt_signup_password;
        private System.Windows.Forms.TextBox txt_signup_lname;
        private System.Windows.Forms.TextBox txt_signup_fname;
        private System.Windows.Forms.TextBox txt_signup_username;
        private System.Windows.Forms.Button btn_signup_back;
    }
}