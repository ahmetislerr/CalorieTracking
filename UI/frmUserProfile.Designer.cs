namespace UI
{
    partial class frmUserProfile
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
            this.pctbUserPicture = new System.Windows.Forms.PictureBox();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.dgvWeeklyMonthlyReport = new System.Windows.Forms.DataGridView();
            this.dtpDailyReport = new System.Windows.Forms.DateTimePicker();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.lblSelectedDailyReport = new System.Windows.Forms.Label();
            this.cmbMealSelection = new System.Windows.Forms.ComboBox();
            this.dvgComparisonReport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvComparisonReport = new System.Windows.Forms.DataGridView();
            this.rbmounthlyComparison = new System.Windows.Forms.RadioButton();
            this.rbWeeklyComparison = new System.Windows.Forms.RadioButton();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnStatisticsForm = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMonthlyReport)).BeginInit();
            this.dvgComparisonReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbUserPicture
            // 
            this.pctbUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbUserPicture.Location = new System.Drawing.Point(12, 11);
            this.pctbUserPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbUserPicture.Name = "pctbUserPicture";
            this.pctbUserPicture.Size = new System.Drawing.Size(181, 140);
            this.pctbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbUserPicture.TabIndex = 0;
            this.pctbUserPicture.TabStop = false;
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Location = new System.Drawing.Point(211, 46);
            this.dgvDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.RowTemplate.Height = 29;
            this.dgvDailyReport.Size = new System.Drawing.Size(398, 141);
            this.dgvDailyReport.TabIndex = 1;
            // 
            // dgvWeeklyMonthlyReport
            // 
            this.dgvWeeklyMonthlyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeeklyMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyMonthlyReport.Location = new System.Drawing.Point(627, 46);
            this.dgvWeeklyMonthlyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWeeklyMonthlyReport.Name = "dgvWeeklyMonthlyReport";
            this.dgvWeeklyMonthlyReport.RowHeadersWidth = 51;
            this.dgvWeeklyMonthlyReport.RowTemplate.Height = 29;
            this.dgvWeeklyMonthlyReport.Size = new System.Drawing.Size(379, 141);
            this.dgvWeeklyMonthlyReport.TabIndex = 2;
            // 
            // dtpDailyReport
            // 
            this.dtpDailyReport.Location = new System.Drawing.Point(432, 11);
            this.dtpDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDailyReport.Name = "dtpDailyReport";
            this.dtpDailyReport.Size = new System.Drawing.Size(177, 23);
            this.dtpDailyReport.TabIndex = 3;
            this.dtpDailyReport.ValueChanged += new System.EventHandler(this.dtpDailyReport_ValueChanged);
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeekly.Location = new System.Drawing.Point(745, 14);
            this.rbWeekly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(67, 19);
            this.rbWeekly.TabIndex = 4;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.CheckedChanged += new System.EventHandler(this.rbWeekly_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMonthly.Location = new System.Drawing.Point(917, 14);
            this.rbMonthly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(71, 19);
            this.rbMonthly.TabIndex = 5;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // lblSelectedDailyReport
            // 
            this.lblSelectedDailyReport.AutoSize = true;
            this.lblSelectedDailyReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedDailyReport.Location = new System.Drawing.Point(224, 15);
            this.lblSelectedDailyReport.Name = "lblSelectedDailyReport";
            this.lblSelectedDailyReport.Size = new System.Drawing.Size(134, 15);
            this.lblSelectedDailyReport.TabIndex = 6;
            this.lblSelectedDailyReport.Text = "Selected Daily Report :";
            // 
            // cmbMealSelection
            // 
            this.cmbMealSelection.FormattingEnabled = true;
            this.cmbMealSelection.Location = new System.Drawing.Point(107, 20);
            this.cmbMealSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMealSelection.Name = "cmbMealSelection";
            this.cmbMealSelection.Size = new System.Drawing.Size(210, 23);
            this.cmbMealSelection.TabIndex = 7;
            this.cmbMealSelection.SelectedIndexChanged += new System.EventHandler(this.cmbMealSelection_SelectedIndexChanged);
            // 
            // dvgComparisonReport
            // 
            this.dvgComparisonReport.Controls.Add(this.label1);
            this.dvgComparisonReport.Controls.Add(this.dgvComparisonReport);
            this.dvgComparisonReport.Controls.Add(this.rbmounthlyComparison);
            this.dvgComparisonReport.Controls.Add(this.rbWeeklyComparison);
            this.dvgComparisonReport.Controls.Add(this.cmbMealSelection);
            this.dvgComparisonReport.Location = new System.Drawing.Point(211, 218);
            this.dvgComparisonReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgComparisonReport.Name = "dvgComparisonReport";
            this.dvgComparisonReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgComparisonReport.Size = new System.Drawing.Size(803, 236);
            this.dvgComparisonReport.TabIndex = 8;
            this.dvgComparisonReport.TabStop = false;
            this.dvgComparisonReport.Text = "Comparison Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Meals";
            // 
            // dgvComparisonReport
            // 
            this.dgvComparisonReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparisonReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparisonReport.Location = new System.Drawing.Point(12, 55);
            this.dgvComparisonReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComparisonReport.Name = "dgvComparisonReport";
            this.dgvComparisonReport.RowHeadersWidth = 51;
            this.dgvComparisonReport.RowTemplate.Height = 29;
            this.dgvComparisonReport.Size = new System.Drawing.Size(765, 177);
            this.dgvComparisonReport.TabIndex = 10;
            // 
            // rbmounthlyComparison
            // 
            this.rbmounthlyComparison.AutoSize = true;
            this.rbmounthlyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbmounthlyComparison.Location = new System.Drawing.Point(530, 18);
            this.rbmounthlyComparison.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbmounthlyComparison.Name = "rbmounthlyComparison";
            this.rbmounthlyComparison.Size = new System.Drawing.Size(71, 19);
            this.rbmounthlyComparison.TabIndex = 9;
            this.rbmounthlyComparison.TabStop = true;
            this.rbmounthlyComparison.Text = "Monthly";
            this.rbmounthlyComparison.UseVisualStyleBackColor = true;
            this.rbmounthlyComparison.CheckedChanged += new System.EventHandler(this.rbmounthlyComparison_CheckedChanged);
            // 
            // rbWeeklyComparison
            // 
            this.rbWeeklyComparison.AutoSize = true;
            this.rbWeeklyComparison.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbWeeklyComparison.Location = new System.Drawing.Point(389, 18);
            this.rbWeeklyComparison.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbWeeklyComparison.Name = "rbWeeklyComparison";
            this.rbWeeklyComparison.Size = new System.Drawing.Size(67, 19);
            this.rbWeeklyComparison.TabIndex = 8;
            this.rbWeeklyComparison.TabStop = true;
            this.rbWeeklyComparison.Text = "Weekly";
            this.rbWeeklyComparison.UseVisualStyleBackColor = true;
            this.rbWeeklyComparison.CheckedChanged += new System.EventHandler(this.rbWeeklyComparison_CheckedChanged);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.Location = new System.Drawing.Point(211, 467);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(346, 40);
            this.btnAddMeal.TabIndex = 9;
            this.btnAddMeal.Text = "Add a Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnStatisticsForm
            // 
            this.btnStatisticsForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatisticsForm.Location = new System.Drawing.Point(600, 467);
            this.btnStatisticsForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatisticsForm.Name = "btnStatisticsForm";
            this.btnStatisticsForm.Size = new System.Drawing.Size(414, 40);
            this.btnStatisticsForm.TabIndex = 10;
            this.btnStatisticsForm.Text = "Statistics Form";
            this.btnStatisticsForm.UseVisualStyleBackColor = true;
            this.btnStatisticsForm.Click += new System.EventHandler(this.btnStatisticsForm_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Location = new System.Drawing.Point(14, 164);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(179, 140);
            this.lblUserInfo.TabIndex = 11;
            this.lblUserInfo.Text = "User Info";
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 568);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnStatisticsForm);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.dvgComparisonReport);
            this.Controls.Add(this.lblSelectedDailyReport);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.dtpDailyReport);
            this.Controls.Add(this.dgvWeeklyMonthlyReport);
            this.Controls.Add(this.dgvDailyReport);
            this.Controls.Add(this.pctbUserPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserProfile";
            this.Text = "UserProfileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserProfile_FormClosing);
            this.Load += new System.EventHandler(this.UserProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMonthlyReport)).EndInit();
            this.dvgComparisonReport.ResumeLayout(false);
            this.dvgComparisonReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparisonReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctbUserPicture;
        private DataGridView dgvDailyReport;
        private DataGridView dgvWeeklyMonthlyReport;
        private DateTimePicker dtpDailyReport;
        private RadioButton rbWeekly;
        private RadioButton rbMonthly;
        private Label lblSelectedDailyReport;
        private ComboBox cmbMealSelection;
        private GroupBox dvgComparisonReport;
        private DataGridView dgvComparisonReport;
        private RadioButton rbmounthlyComparison;
        private RadioButton rbWeeklyComparison;
        private Button btnAddMeal;
        private Button btnStatisticsForm;
        private Label lblUserInfo;
        private Label label1;
    }
}