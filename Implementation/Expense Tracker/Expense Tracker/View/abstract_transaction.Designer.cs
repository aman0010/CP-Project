namespace Expense_Tracker.View
{
    partial class abstract_transaction
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_category = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.btn_action = new System.Windows.Forms.Button();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.Location = new System.Drawing.Point(58, 58);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(125, 32);
            this.label_heading.TabIndex = 0;
            this.label_heading.Text = "heading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(196, 282);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(430, 112);
            this.txt_description.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // combo_category
            // 
            this.combo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_category.FormattingEnabled = true;
            this.combo_category.Location = new System.Drawing.Point(195, 242);
            this.combo_category.Name = "combo_category";
            this.combo_category.Size = new System.Drawing.Size(431, 33);
            this.combo_category.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(195, 199);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 30);
            this.dateTimePicker.TabIndex = 4;
            // 
            // num_amount
            // 
            this.num_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_amount.Location = new System.Drawing.Point(195, 154);
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(228, 30);
            this.num_amount.TabIndex = 5;
            // 
            // btn_action
            // 
            this.btn_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_action.Location = new System.Drawing.Point(195, 425);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(138, 39);
            this.btn_action.TabIndex = 6;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.Btn_action_Click);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcategory.Location = new System.Drawing.Point(648, 244);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(104, 52);
            this.btn_addcategory.TabIndex = 7;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.Btn_addcategory_Click);
            // 
            // combo_type
            // 
            this.combo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_type.IntegralHeight = false;
            this.combo_type.Items.AddRange(new object[] {
            "Expense",
            "Income"});
            this.combo_type.Location = new System.Drawing.Point(178, 57);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(164, 33);
            this.combo_type.TabIndex = 8;
            this.combo_type.SelectionChangeCommitted += new System.EventHandler(this.Combo_type_SelectionChangeCommitted);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(488, 425);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 39);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // abstract_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.combo_type);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.num_amount);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.combo_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_heading);
            this.Name = "abstract_transaction";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Abstract_transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_category;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown num_amount;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.Button btn_delete;
    }
}