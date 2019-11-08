namespace Expense_Tracker.View
{
    partial class transaction
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
            this.textBox_expense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.dataGridView_expense = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_income = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_editIncome = new System.Windows.Forms.Button();
            this.btn_editExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Expense";
            // 
            // textBox_expense
            // 
            this.textBox_expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_expense.Location = new System.Drawing.Point(380, 122);
            this.textBox_expense.Name = "textBox_expense";
            this.textBox_expense.ReadOnly = true;
            this.textBox_expense.Size = new System.Drawing.Size(83, 49);
            this.textBox_expense.TabIndex = 13;
            this.textBox_expense.TabStop = false;
            this.textBox_expense.Text = "0";
            this.textBox_expense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Income";
            // 
            // textBox_income
            // 
            this.textBox_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_income.Location = new System.Drawing.Point(536, 122);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.ReadOnly = true;
            this.textBox_income.Size = new System.Drawing.Size(83, 49);
            this.textBox_income.TabIndex = 13;
            this.textBox_income.TabStop = false;
            this.textBox_income.Text = "0";
            this.textBox_income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Balance";
            // 
            // textBox_balance
            // 
            this.textBox_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_balance.Location = new System.Drawing.Point(691, 122);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.ReadOnly = true;
            this.textBox_balance.Size = new System.Drawing.Size(83, 49);
            this.textBox_balance.TabIndex = 13;
            this.textBox_balance.TabStop = false;
            this.textBox_balance.Text = "0";
            this.textBox_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.AllowUserToAddRows = false;
            this.dataGridView_expense.AllowUserToDeleteRows = false;
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Location = new System.Drawing.Point(251, 283);
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.ReadOnly = true;
            this.dataGridView_expense.RowHeadersWidth = 51;
            this.dataGridView_expense.RowTemplate.Height = 24;
            this.dataGridView_expense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_expense.Size = new System.Drawing.Size(726, 154);
            this.dataGridView_expense.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expense";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Income";
            // 
            // dataGridView_income
            // 
            this.dataGridView_income.AllowUserToAddRows = false;
            this.dataGridView_income.AllowUserToDeleteRows = false;
            this.dataGridView_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_income.Location = new System.Drawing.Point(251, 487);
            this.dataGridView_income.Name = "dataGridView_income";
            this.dataGridView_income.ReadOnly = true;
            this.dataGridView_income.RowHeadersWidth = 51;
            this.dataGridView_income.RowTemplate.Height = 24;
            this.dataGridView_income.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_income.Size = new System.Drawing.Size(726, 163);
            this.dataGridView_income.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Expense_Tracker.Properties.Resources.add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(915, 674);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 61);
            this.btn_add.TabIndex = 15;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_editIncome
            // 
            this.btn_editIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editIncome.Location = new System.Drawing.Point(731, 682);
            this.btn_editIncome.Name = "btn_editIncome";
            this.btn_editIncome.Size = new System.Drawing.Size(171, 45);
            this.btn_editIncome.TabIndex = 20;
            this.btn_editIncome.Text = "Edit Income";
            this.btn_editIncome.UseVisualStyleBackColor = true;
            this.btn_editIncome.Click += new System.EventHandler(this.Btn_editIncome_Click);
            // 
            // btn_editExpense
            // 
            this.btn_editExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editExpense.Location = new System.Drawing.Point(731, 439);
            this.btn_editExpense.Name = "btn_editExpense";
            this.btn_editExpense.Size = new System.Drawing.Size(171, 45);
            this.btn_editExpense.TabIndex = 20;
            this.btn_editExpense.Text = "Edit Expense";
            this.btn_editExpense.UseVisualStyleBackColor = true;
            this.btn_editExpense.Click += new System.EventHandler(this.Btn_editExpense_Click);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1006, 747);
            this.Controls.Add(this.btn_editExpense);
            this.Controls.Add(this.btn_editIncome);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView_income);
            this.Controls.Add(this.dataGridView_expense);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_expense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "transaction";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox_expense, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox_income, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox_balance, 0);
            this.Controls.SetChildIndex(this.dataGridView_expense, 0);
            this.Controls.SetChildIndex(this.dataGridView_income, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.btn_editIncome, 0);
            this.Controls.SetChildIndex(this.btn_editExpense, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_expense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.DataGridView dataGridView_expense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_income;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_editIncome;
        private System.Windows.Forms.Button btn_editExpense;
    }
}
