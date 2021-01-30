using FastFileScanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFileScanner
{
    public partial class FastFileScaner : Form
    {
        public FastFileScaner()
        {
            InitializeComponent();
            var file = Path.Combine(Application.StartupPath, "文件扫描结果-" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv");
            this.linkLabelExcel.Text = file;
            this.btnMd5File.Text = file;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.Description = "请选择要扫描的文件夹";            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.SelectedPath;
            }
        }

        private void btnScanFile_Click(object sender, EventArgs e)
        {
            var scanFolder = txtFile.Text.Trim();

            if (string.IsNullOrEmpty(scanFolder))
            {
                MessageBox.Show("请选择要扫描的文件夹.", "文件扫描工具");
                return;
            }

            var start = DateTime.Now;
            this.toolStripStatusLabel1.Text = "文件扫描中...";
            var result = new List<ScanFileInfo>(1024);

            ScanFiles(scanFolder, result);

            if (chkShow.Checked)
                this.dataGridFile.DataSource = result;

            this.toolStripStatusLabel1.Text = "文件扫描完成.文件总计:" + result.Count + "个, 累计耗时:"+(DateTime.Now- start).TotalSeconds+"秒.";

            if (chkExcel.Checked)
            {
                var file = FileScanExporter.ExportCSV(Application.StartupPath, result);
                this.linkLabelExcel.Text = file;
                this.txtFile.Text = file;
                MessageBox.Show("扫描结果已经导出:" + linkLabelExcel.Text, "文件扫描工具");
            }
        }

        private void ScanFiles(string path, List<ScanFileInfo> fileList)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    var scanFile = new ScanFileInfo();
                    this.toolStripStatusLabel1.Text = "文件累计扫描:" + fileList.Count + "个, 当前文件:" + file;
                    statusStrip1.Update();
                    try
                    {
                        if (File.Exists(file) == false) continue;
                        fileList.Add(scanFile);
                        var fileinfo = new FileInfo(file);

                        scanFile.FilePath = fileinfo.DirectoryName;
                        scanFile.FileName = fileinfo.Name;
                        scanFile.FileSize = fileinfo.Length;
                        scanFile.Extension = fileinfo.Extension;
                        scanFile.LastModifyTime = fileinfo.LastWriteTime;
                        if(chkMD5.Checked)
                         scanFile.FileMd5 = GetMD5HashFromFile(file);

                        var scanFolder = txtFile.Text.Trim();
                        var subDir = fileinfo.DirectoryName.Remove(0, scanFolder.Length+1);
                        var subDirItems = subDir.Split('\\');
                        if (subDirItems != null && subDirItems.Length > 0)
                        {
                            for (int i = 0; i < subDirItems.Length; i++)
                            {
                                switch (i)
                                {
                                    case 0:
                                        scanFile.SubDir1 = subDirItems[i];
                                        break;
                                    case 1:
                                        scanFile.SubDir2 = subDirItems[i];
                                        break;
                                    case 2:
                                        scanFile.SubDir3 = subDirItems[i];
                                        break;
                                    case 3:
                                        scanFile.SubDir4 = subDirItems[i];
                                        break;
                                    case 4:
                                        scanFile.SubDir5 = subDirItems[i];
                                        break;
                                    case 5:
                                        scanFile.SubDir6 = subDirItems[i];
                                        break;
                                    case 6:
                                        scanFile.SubDir7 = subDirItems[i];
                                        break;
                                    case 7:
                                        scanFile.SubDir8 = subDirItems[i];
                                        break;
                                    case 9:
                                        scanFile.SubDir10 = subDirItems[i];
                                        break;
                                    case 10:
                                        scanFile.SubDir11 = subDirItems[i];
                                        break;
                                    case 11:
                                        scanFile.SubDir12 = subDirItems[i];
                                        break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        scanFile.ExceptionMsg = ex.Message;
                    }
                }
                foreach (string dir in Directory.GetDirectories(path))
                {
                    ScanFiles(dir, fileList);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="fileName">文件绝对路径</param>
        /// <returns>MD5值</returns>
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
            }
        }

        private void btnmd5Scan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要计算MD5的文件";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.btnMd5File.Text = openFileDialog.FileName;
            }            
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.btnMd5File.Text))
            {
                MessageBox.Show("请选择要计算MD5码的文件.", "文件扫描工具");
                return;
            }

            //var md5 = new FileMD5();
            //md5.SetFileName(this.btnMd5File.Text);
            //md5.SetFileMD5(GetMD5HashFromFile(this.btnMd5File.Text));
            //md5.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var excel = linkLabelExcel.Text;
            if (File.Exists(excel) == false) return;
            System.Diagnostics.Process.Start(excel);
            //File.Open(excel, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}
