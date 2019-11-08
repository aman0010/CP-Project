namespace Expense_Tracker.View
{
    partial class abstract_category
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
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_action = new System.Windows.Forms.Button();
            this.radio_expense = new System.Windows.Forms.RadioButton();
            this.radio_income = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(216, 163);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(430, 112);
            this.txt_description.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(72, 58);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(75, 32);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(216, 117);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(430, 30);
            this.txt_name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category Type";
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(216, 406);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(137, 42);
            this.btn_action.TabIndex = 8;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // radio_expense
            // 
            this.radio_expense.AutoSize = true;
            this.radio_expense.Checked = true;
            this.radio_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_expense.Location = new System.Drawing.Point(216, 294);
            this.radio_expense.Name = "radio_expense";
            this.radio_expense.Size = new System.Drawing.Size(110, 29);
            this.radio_expense.TabIndex = 9;
            this.radio_expense.TabStop = true;
            this.radio_expense.Text = "Expense";
            this.radio_expense.UseVisualStyleBackColor = true;
            // 
            // radio_income
            // 
            this.radio_income.AutoSize = true;
            this.radio_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_income.Location = new System.Drawing.Point(216, 345);
            this.radio_income.Name = "radio_income";
            this.radio_income.Size = new System.Drawing.Size(97, 29);
            this.radio_income.TabIndex = 9;
            this.radio_income.Text = "Income";
            this.radio_income.UseVisualStyleBackColor = true;
            // 
            // abstract_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.radio_income);
            this.Controls.Add(this.radio_expense);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label4);
            this.Name = "abstract_category";
            this.Text = "add_category";
            this.Load += new System.EventHandler(this.Abstract_category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.RadioButton radio_expense;
        private System.Windows.Forms.RadioButton radio_income;
    }
}