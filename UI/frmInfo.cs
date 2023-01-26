using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }
        
        private void chbLanguange_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLanguange.Checked == true)
            {
                pbxİnfoTr.Visible = false;
                pbxİnfoEng.Visible = true;
            }
            else if (chbLanguange.Checked == false)
            {
                pbxİnfoTr.Visible = true;
                pbxİnfoEng.Visible = false;
            }
            

        }

        private void frmInfo_Load_1(object sender, EventArgs e)
        {
            pbxİnfoTr.Visible = true;
        }
    }
}
