using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFileScanner
{
    public partial class FileMD5 : Form
    {
        public FileMD5()
        {
            InitializeComponent();
        }

        public void SetFileName(string fileName)
        {
            this.txtFile.Text = fileName;
        }

        public void SetFileMD5(string fileMD5)
        {
            this.txtMD5.Text = fileMD5;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtMD5.Text);
            MessageBox.Show("MD5码已经Copy到粘贴板", "特来电文件扫描工具");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtMD5.Text);
            this.Close();
        }
    }
}
