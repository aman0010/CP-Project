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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abstract_view));
            this.label_title = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(299, 78);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(75, 32);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "Title";
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
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(12, 245);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(175, 39);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(12, 200);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(175, 39);
            this.btn_graph.TabIndex = 5;
            this.btn_graph.Text = "Graph";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.Btn_graph_Click);
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(12, 155);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(175, 39);
            this.btn_category.TabIndex = 7;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.Btn_category_Click);
            // 
            // btn_transaction
            // 
            this.btn_transaction.AccessibleName = "";
            this.btn_transaction.Location = new System.Drawing.Point(12, 110);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(175, 39);
            this.btn_transaction.TabIndex = 8;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.Btn_transaction_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hide.BackgroundImage")));
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hide.Location = new System.Drawing.Point(127, 46);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(60, 60);
            this.btn_hide.TabIndex = 12;
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.Btn_hide_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_show.BackgroundImage")));
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show.Location = new System.Drawing.Point(12, 46);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(60, 60);
            this.btn_show.TabIndex = 12;
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Visible = false;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = global::Expense_Tracker.Properties.Resources.refresh;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Location = new System.Drawing.Point(859, 132);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(62, 62);
            this.btn_refresh.TabIndex = 17;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // combo_month
            // 
            this.combo_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_month.FormattingEnabled = true;
            this.combo_month.Location = new System.Drawing.Point(495, 220);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(121, 28);
            this.combo_month.TabIndex = 19;
            this.combo_month.SelectionChangeCommitted += new System.EventHandler(this.Combo_month_SelectionChangeCommitted);
            // 
            // abstract_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.combo_month);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_transaction);
            this.Name = "abstract_view";
            this.Text = "abstract_view";
            this.Load += new System.EventHandler(this.Abstract_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox combo_month;
    }
}