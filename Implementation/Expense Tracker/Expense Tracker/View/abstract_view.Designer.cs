namespace Expense_Tracker.View
{
    partial class abstract_view
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
            this.label_heading = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_expense = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(299, 78);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(129, 32);
            this.label_heading.TabIndex = 11;
            this.label_heading.Text = "Heading";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(810, 58);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(129, 37);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(125, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "Hide";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(12, 290);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(175, 39);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(12, 245);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(175, 39);
            this.btn_graph.TabIndex = 5;
            this.btn_graph.Text = "Graph";
            this.btn_graph.UseVisualStyleBackColor = true;
            // 
            // btn_income
            // 
            this.btn_income.Location = new System.Drawing.Point(12, 200);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(175, 39);
            this.btn_income.TabIndex = 6;
            this.btn_income.Text = "Income";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.Btn_income_Click);
            // 
            // btn_expense
            // 
            this.btn_expense.Location = new System.Drawing.Point(12, 155);
            this.btn_expense.Name = "btn_expense";
            this.btn_expense.Size = new System.Drawing.Size(175, 39);
            this.btn_expense.TabIndex = 7;
            this.btn_expense.Text = "Expense";
            this.btn_expense.UseVisualStyleBackColor = true;
            this.btn_expense.Click += new System.EventHandler(this.Btn_expense_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AccessibleName = "";
            this.btn_dashboard.Location = new System.Drawing.Point(12, 110);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(175, 39);
            this.btn_dashboard.TabIndex = 8;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // abstract_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label_heading);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.btn_income);
            this.Controls.Add(this.btn_expense);
            this.Controls.Add(this.btn_dashboard);
            this.Name = "abstract_view";
            this.Text = "abstract_view";
            this.Load += new System.EventHandler(this.Abstract_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_expense;
        private System.Windows.Forms.Button btn_dashboard;
    }
}