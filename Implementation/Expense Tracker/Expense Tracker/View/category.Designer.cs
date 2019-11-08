namespace Expense_Tracker.View
{
    partial class category
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
            this.dataGridView_expense = new System.Windows.Forms.DataGridView();
            this.dataGridView_income = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_editIncome = new System.Windows.Forms.Button();
            this.btn_editExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Location = new System.Drawing.Point(266, 200);
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.RowHeadersWidth = 51;
            this.dataGridView_expense.RowTemplate.Height = 24;
            this.dataGridView_expense.Size = new System.Drawing.Size(310, 445);
            this.dataGridView_expense.TabIndex = 13;
            //this.dataGridView_expense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_expense_CellContentClick);
            // 
            // dataGridView_income
            // 
            this.dataGridView_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_income.Location = new System.Drawing.Point(617, 200);
            this.dataGridView_income.Name = "dataGridView_income";
            this.dataGridView_income.RowHeadersWidth = 51;
            this.dataGridView_income.RowTemplate.Height = 24;
            this.dataGridView_income.Size = new System.Drawing.Size(310, 445);
            this.dataGridView_income.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Income";
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Expense_Tracker.Properties.Resources.add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(859, 651);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 61);
            this.btn_add.TabIndex = 18;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_editIncome
            // 
            this.btn_editIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editIncome.Location = new System.Drawing.Point(679, 656);
            this.btn_editIncome.Name = "btn_editIncome";
            this.btn_editIncome.Size = new System.Drawing.Size(161, 45);
            this.btn_editIncome.TabIndex = 21;
            this.btn_editIncome.Text = "Edit Income";
            this.btn_editIncome.UseVisualStyleBackColor = true;
            this.btn_editIncome.Click += new System.EventHandler(this.Btn_editIncome_Click);
            // 
            // btn_editExpense
            // 
            this.btn_editExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editExpense.Location = new System.Drawing.Point(415, 656);
            this.btn_editExpense.Name = "btn_editExpense";
            this.btn_editExpense.Size = new System.Drawing.Size(161, 45);
            this.btn_editExpense.TabIndex = 21;
            this.btn_editExpense.Text = "Edit Expense";
            this.btn_editExpense.UseVisualStyleBackColor = true;
            this.btn_editExpense.Click += new System.EventHandler(this.Btn_editExpense_Click);
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_editExpense);
            this.Controls.Add(this.btn_editIncome);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_income);
            this.Controls.Add(this.dataGridView_expense);
            this.Name = "category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.Controls.SetChildIndex(this.dataGridView_expense, 0);
            this.Controls.SetChildIndex(this.dataGridView_income, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.btn_editIncome, 0);
            this.Controls.SetChildIndex(this.btn_editExpense, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_expense;
        private System.Windows.Forms.DataGridView dataGridView_income;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_editIncome;
        private System.Windows.Forms.Button btn_editExpense;
    }
}
