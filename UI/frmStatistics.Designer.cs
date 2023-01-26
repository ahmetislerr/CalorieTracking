namespace UI
{
    partial class frmStatistics
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
            this.cmbChooseCategory = new System.Windows.Forms.ComboBox();
            this.dgvChooseFood = new System.Windows.Forms.DataGridView();
            this.dgvMealReport = new System.Windows.Forms.DataGridView();
            this.btnBackUserForm = new System.Windows.Forms.Button();
            this.rbtnBreakfast = new System.Windows.Forms.RadioButton();
            this.rbtnLunch = new System.Windows.Forms.RadioButton();
            this.rbtnSnack = new System.Windows.Forms.RadioButton();
            this.rbtnDinner = new System.Windows.Forms.RadioButton();
            this.lblChooseCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChooseCategory
            // 
            this.cmbChooseCategory.FormattingEnabled = true;
            this.cmbChooseCategory.Location = new System.Drawing.Point(196, 77);
            this.cmbChooseCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseCategory.Name = "cmbChooseCategory";
            this.cmbChooseCategory.Size = new System.Drawing.Size(182, 23);
            this.cmbChooseCategory.TabIndex = 0;
            this.cmbChooseCategory.SelectedIndexChanged += new System.EventHandler(this.cmbChooseCategory_SelectedIndexChanged);
            // 
            // dgvChooseFood
            // 
            this.dgvChooseFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChooseFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseFood.Location = new System.Drawing.Point(26, 135);
            this.dgvChooseFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChooseFood.Name = "dgvChooseFood";
            this.dgvChooseFood.RowHeadersWidth = 51;
            this.dgvChooseFood.RowTemplate.Height = 29;
            this.dgvChooseFood.Size = new System.Drawing.Size(476, 146);
            this.dgvChooseFood.TabIndex = 1;
            // 
            // dgvMealReport
            // 
            this.dgvMealReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealReport.Location = new System.Drawing.Point(26, 322);
            this.dgvMealReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealReport.Name = "dgvMealReport";
            this.dgvMealReport.RowHeadersWidth = 51;
            this.dgvMealReport.RowTemplate.Height = 29;
            this.dgvMealReport.Size = new System.Drawing.Size(476, 189);
            this.dgvMealReport.TabIndex = 2;
            // 
            // btnBackUserForm
            // 
            this.btnBackUserForm.Location = new System.Drawing.Point(341, 516);
            this.btnBackUserForm.Name = "btnBackUserForm";
            this.btnBackUserForm.Size = new System.Drawing.Size(161, 35);
            this.btnBackUserForm.TabIndex = 3;
            this.btnBackUserForm.Text = "Back To User Form";
            this.btnBackUserForm.UseVisualStyleBackColor = true;
            this.btnBackUserForm.Click += new System.EventHandler(this.btnBackUserForm_Click);
            // 
            // rbtnBreakfast
            // 
            this.rbtnBreakfast.AutoSize = true;
            this.rbtnBreakfast.Location = new System.Drawing.Point(27, 39);
            this.rbtnBreakfast.Name = "rbtnBreakfast";
            this.rbtnBreakfast.Size = new System.Drawing.Size(73, 19);
            this.rbtnBreakfast.TabIndex = 4;
            this.rbtnBreakfast.TabStop = true;
            this.rbtnBreakfast.Text = "Breakfast";
            this.rbtnBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbtnLunch
            // 
            this.rbtnLunch.AutoSize = true;
            this.rbtnLunch.Location = new System.Drawing.Point(111, 39);
            this.rbtnLunch.Name = "rbtnLunch";
            this.rbtnLunch.Size = new System.Drawing.Size(58, 19);
            this.rbtnLunch.TabIndex = 5;
            this.rbtnLunch.TabStop = true;
            this.rbtnLunch.Text = "Lunch";
            this.rbtnLunch.UseVisualStyleBackColor = true;
            // 
            // rbtnSnack
            // 
            this.rbtnSnack.AutoSize = true;
            this.rbtnSnack.Location = new System.Drawing.Point(178, 39);
            this.rbtnSnack.Name = "rbtnSnack";
            this.rbtnSnack.Size = new System.Drawing.Size(56, 19);
            this.rbtnSnack.TabIndex = 6;
            this.rbtnSnack.TabStop = true;
            this.rbtnSnack.Text = "Snack";
            this.rbtnSnack.UseVisualStyleBackColor = true;
            // 
            // rbtnDinner
            // 
            this.rbtnDinner.AutoSize = true;
            this.rbtnDinner.Location = new System.Drawing.Point(240, 39);
            this.rbtnDinner.Name = "rbtnDinner";
            this.rbtnDinner.Size = new System.Drawing.Size(60, 19);
            this.rbtnDinner.TabIndex = 7;
            this.rbtnDinner.TabStop = true;
            this.rbtnDinner.Text = "Dinner";
            this.rbtnDinner.UseVisualStyleBackColor = true;
            // 
            // lblChooseCategory
            // 
            this.lblChooseCategory.AutoSize = true;
            this.lblChooseCategory.Location = new System.Drawing.Point(24, 79);
            this.lblChooseCategory.Name = "lblChooseCategory";
            this.lblChooseCategory.Size = new System.Drawing.Size(140, 15);
            this.lblChooseCategory.TabIndex = 8;
            this.lblChooseCategory.Text = "Please Choose Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Foods Eatten by Meals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Most Eaten Food";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 576);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChooseCategory);
            this.Controls.Add(this.rbtnDinner);
            this.Controls.Add(this.rbtnSnack);
            this.Controls.Add(this.rbtnLunch);
            this.Controls.Add(this.rbtnBreakfast);
            this.Controls.Add(this.btnBackUserForm);
            this.Controls.Add(this.dgvMealReport);
            this.Controls.Add(this.dgvChooseFood);
            this.Controls.Add(this.cmbChooseCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStatistics";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbChooseCategory;
        private DataGridView dgvChooseFood;
        private DataGridView dgvMealReport;
        private Button btnBackUserForm;
        private RadioButton rbtnBreakfast;
        private RadioButton rbtnLunch;
        private RadioButton rbtnSnack;
        private RadioButton rbtnDinner;
        private Label lblChooseCategory;
        private Label label1;
        private Label label2;
    }
}