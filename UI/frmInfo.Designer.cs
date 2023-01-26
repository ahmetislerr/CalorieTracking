namespace UI
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            this.pbxİnfoTr = new System.Windows.Forms.PictureBox();
            this.pbxİnfoEng = new System.Windows.Forms.PictureBox();
            this.chbLanguange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxİnfoTr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxİnfoEng)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxİnfoTr
            // 
            this.pbxİnfoTr.Image = ((System.Drawing.Image)(resources.GetObject("pbxİnfoTr.Image")));
            this.pbxİnfoTr.Location = new System.Drawing.Point(12, 12);
            this.pbxİnfoTr.Name = "pbxİnfoTr";
            this.pbxİnfoTr.Size = new System.Drawing.Size(776, 401);
            this.pbxİnfoTr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxİnfoTr.TabIndex = 0;
            this.pbxİnfoTr.TabStop = false;
            this.pbxİnfoTr.Visible = false;
            // 
            // pbxİnfoEng
            // 
            this.pbxİnfoEng.Image = ((System.Drawing.Image)(resources.GetObject("pbxİnfoEng.Image")));
            this.pbxİnfoEng.Location = new System.Drawing.Point(12, 12);
            this.pbxİnfoEng.Name = "pbxİnfoEng";
            this.pbxİnfoEng.Size = new System.Drawing.Size(776, 401);
            this.pbxİnfoEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxİnfoEng.TabIndex = 0;
            this.pbxİnfoEng.TabStop = false;
            this.pbxİnfoEng.Visible = false;
            // 
            // chbLanguange
            // 
            this.chbLanguange.AutoSize = true;
            this.chbLanguange.Location = new System.Drawing.Point(363, 419);
            this.chbLanguange.Name = "chbLanguange";
            this.chbLanguange.Size = new System.Drawing.Size(64, 19);
            this.chbLanguange.TabIndex = 1;
            this.chbLanguange.Text = "English";
            this.chbLanguange.UseVisualStyleBackColor = true;
            this.chbLanguange.CheckedChanged += new System.EventHandler(this.chbLanguange_CheckedChanged);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbLanguange);
            this.Controls.Add(this.pbxİnfoEng);
            this.Controls.Add(this.pbxİnfoTr);
            this.Name = "frmInfo";
            this.Text = "frmInfo";
            this.Load += new System.EventHandler(this.frmInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbxİnfoTr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxİnfoEng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxİnfoTr;
        private PictureBox pbxİnfoEng;
        private CheckBox chbLanguange;
    }
}