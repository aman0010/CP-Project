namespace Expense_Tracker.View
{
    partial class report
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_income)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_expense
            // 
            this.dataGridView_expense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_expense.Location = new System.Drawing.Point(235, 300);
            this.dataGridView_expense.Name = "dataGridView_expense";
            this.dataGridView_expense.RowHeadersWidth = 51;
            this.dataGridView_expense.RowTemplate.Height = 24;
            this.dataGridView_expense.Size = new System.Drawing.Size(685, 189);
            this.dataGridView_expense.TabIndex = 20;
            // 
            // dataGridView_income
            // 
            this.dataGridView_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_income.Location = new System.Drawing.Point(236, 535);
            this.dataGridView_income.Name = "dataGridView_income";
            this.dataGridView_income.RowHeadersWidth = 51;
            this.dataGridView_income.RowTemplate.Height = 24;
            this.dataGridView_income.Size = new System.Drawing.Size(685, 189);
            this.dataGridView_income.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Income";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_income);
            this.Controls.Add(this.dataGridView_expense);
            this.Name = "report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.Controls.SetChildIndex(this.dataGridView_expense, 0);
            this.Controls.SetChildIndex(this.dataGridView_income, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
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
    }
}
