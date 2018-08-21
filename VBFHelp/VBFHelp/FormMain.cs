using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace VBFHelp
{
    public partial class FormMain : Form
    {

        public string VBFFilePath;
        public string LogFileSavePath;
        public string UpgradeFilePath_OTA;
        public string UpgradeFilePath_SOC;
        public string UpgradeFilePath_UBI;

        public VBF_API myVBF = new VBF_API();
        public ADB_API myAdb = new ADB_API();


        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.InitialDirectory = "c:\\";
            if ((null == VBFFilePath) || (" " == VBFFilePath))
            {
                openFileDialog.InitialDirectory = "c:\\";
            }
            else
            {
                openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(VBFFilePath);
            }

            openFileDialog.Filter = "所有文件(*.*)|*.*"; // 如果需要筛选txt文件（"Files (*.txt)|*.txt"）

            openFileDialog.RestoreDirectory = true;

            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                VBFFilePath = openFileDialog.FileName;
                this.textBox_VbfPath.Clear();
                this.textBox_VbfPath.Text = VBFFilePath;

                richTextBox_Log.Text = "";
            }
        }

        private void button_CalcCrc_Click(object sender, EventArgs e)
        {
            if (null == VBFFilePath) 
            {
                MessageBox.Show("Error: 未找到VBF文件");

                return;
            }

            byte[] buf;
            CAN_File canFile = new CAN_File();
            canFile.name = new byte[200];
            canFile.block_array = new CAN_Block[99];
            for (int i = 0; i < canFile.block_array.Length; i++) 
            {
                canFile.block_array[i].flash_addr = new byte[4];
                canFile.block_array[i].size = new byte[4];
                canFile.block_array[i].checksum = new byte[2];  
            }
            
            canFile.erase_size = new byte[4];
            canFile.crc32 = new byte[4];

            myVBF.ReadFile(VBFFilePath, out buf);
            string strLog;
            myVBF.nswCANGetVbfInfo(0, buf, buf.Length, canFile, out strLog);

            textBox_CrcResult.Text = String.Format("0x{0:X}", myVBF.Crc32);
            textBox_CrcResultStream.Text = String.Format("0x{0:X}", myVBF.Crc32Stream);

            richTextBox_Log.AppendText(strLog);
        }

        private void button_CalcCrcStream_Click(object sender, EventArgs e)
        {
            if (null == VBFFilePath)
            {
                MessageBox.Show("Error: 未找到VBF文件");

                return;
            }

            byte[] buf;
            CAN_File canFile = new CAN_File();
            canFile.name = new byte[200];
            canFile.block_array = new CAN_Block[10];
            canFile.block_array[0].flash_addr = new byte[4];
            canFile.block_array[0].size = new byte[4];
            canFile.block_array[0].checksum = new byte[2];
            canFile.erase_size = new byte[4];
            canFile.crc32 = new byte[4];

            myVBF.ReadFile(VBFFilePath, out buf);
            string strLog;
            myVBF.nswCANGetVbfInfo(1, buf, buf.Length, canFile, out strLog);

            textBox_CrcResult.Text = String.Format("0x{0:X}", myVBF.Crc32);
            textBox_CrcResultStream.Text = String.Format("0x{0:X}", myVBF.Crc32Stream);

            richTextBox_Log.AppendText(strLog);
        }

        private void button_LogBrowsePath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();

                dialog.Description = "请选择Log文件保存路径";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LogFileSavePath = dialog.SelectedPath;
                    textBox_LogSavePath.Text = dialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
            } 
        }

        private void button_LogStartRead_Click(object sender, EventArgs e)
        {
            string CurrentPath = System.IO.Directory.GetCurrentDirectory();
            string ExeFileName = CurrentPath + "\\Depends\\adb_win\\";  // adb.exe path
            string strCallAdbCmd = ExeFileName + "adb pull /app/log";    // adb pull cmd
            strCallAdbCmd += " " + textBox_LogSavePath.Text + "\\TboxLog_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");    // log save directory

            richTextBox_PullLog.AppendText("开始读取log...\n");
            richTextBox_PullLog.AppendText(strCallAdbCmd + "\n");

            string strLog;
            myAdb.runCmd(null, strCallAdbCmd, out strLog);

            richTextBox_PullLog.AppendText(strLog + "\n");
            richTextBox_PullLog.AppendText("读取Log完成" + "\n");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (("" == textBox_LogSavePath.Text) || (null == textBox_LogSavePath.Text))
            {
                textBox_LogSavePath.Text = System.IO.Directory.GetCurrentDirectory();
            }


            textBox_UpgradeDestPathOTA.Text = "/app/";
            textBox_UpgradeDestPathOTA.ReadOnly = true;
            textBox_UpgradeDestPathSOC.Text = "/app/";
            textBox_UpgradeDestPathSOC.ReadOnly = true;
            textBox_UpgradeDestPathUBI.Text = "/app/";
            textBox_UpgradeDestPathUBI.ReadOnly = true;

            button_BrowseFilePathUBI.Enabled = false;
            textBox_UpgradeFilePathUBI.Enabled = false;

        }

        private void button_BrowseFilePathOTA_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDlg = new OpenFileDialog();

                fileDlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                fileDlg.Filter = "ALL Files(*.*)|*.*"; // 如果需要筛选txt文件（"Files (*.txt)|*.txt"）
                fileDlg.RestoreDirectory = true;
                fileDlg.FilterIndex = 1;
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    UpgradeFilePath_OTA = fileDlg.FileName;
                    textBox_UpgradeFilePathOTA.Text = fileDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.ToString());
            } 
        }

        private void button_BrowseFilePathSOC_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDlg = new OpenFileDialog();

                fileDlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                fileDlg.Filter = "ALL Files(*.*)|*.*"; // 如果需要筛选txt文件（"Files (*.txt)|*.txt"）
                fileDlg.RestoreDirectory = true;
                fileDlg.FilterIndex = 1;
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    UpgradeFilePath_SOC = fileDlg.FileName;
                    textBox_UpgradeFilePathSOC.Text = fileDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.ToString());
            } 
        }

        private void button_BrowseFilePathUBI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDlg = new OpenFileDialog();

                fileDlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
                fileDlg.Filter = "ALL Files(*.*)|*.*"; // 如果需要筛选txt文件（"Files (*.txt)|*.txt"）
                fileDlg.RestoreDirectory = true;
                fileDlg.FilterIndex = 1;
                if (fileDlg.ShowDialog() == DialogResult.OK)
                {
                    UpgradeFilePath_UBI = fileDlg.FileName;
                    textBox_UpgradeFilePathUBI.Text = fileDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.ToString());
            } 
        }

        private void button_UpgradeStart_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_UpgradeLog.AppendText("开始升级" + "\n");

                string CurrentPath = System.IO.Directory.GetCurrentDirectory();
                string ExeFileName = CurrentPath + "\\Depends\\adb_win\\";  // adb.exe path
                string strCallAdbCmd;
                string strLog;

                //string strCallAdbCmd = ExeFileName + "adb remount";    // adb remount cmd

                //richTextBox_UpgradeLog.AppendText(strCallAdbCmd + "\n");
                
                //myAdb.runCmd(null, strCallAdbCmd, out strLog);

                //richTextBox_UpgradeLog.AppendText(strLog + "\n");


                if (textBox_UpgradeFilePathOTA.Text != "")
                {
                    richTextBox_UpgradeLog.AppendText("找到OTA升级文件，准备升级" + "\n");

                    strCallAdbCmd = ExeFileName + "adb push " + UpgradeFilePath_OTA;    // adb push cmd
                    strCallAdbCmd += " " + textBox_UpgradeDestPathOTA.Text;    // 目标目录

                    richTextBox_UpgradeLog.AppendText(strCallAdbCmd + "\n");
                    myAdb.runCmd(null, strCallAdbCmd, out strLog);

                    richTextBox_UpgradeLog.AppendText(strLog + "\n");
                    richTextBox_UpgradeLog.AppendText("OTA文件升级完成" + "\n");
                }

                if (textBox_UpgradeFilePathSOC.Text != "")
                {
                    richTextBox_UpgradeLog.AppendText("找到SOC升级文件，准备升级" + "\n");

                    strCallAdbCmd = ExeFileName + "adb push " + UpgradeFilePath_SOC;    // adb push cmd
                    strCallAdbCmd += " " + textBox_UpgradeDestPathSOC.Text;    // 目标目录

                    richTextBox_UpgradeLog.AppendText(strCallAdbCmd + "\n");
                    myAdb.runCmd(null, strCallAdbCmd, out strLog);

                    richTextBox_UpgradeLog.AppendText(strLog + "\n");
                    richTextBox_UpgradeLog.AppendText("SOC文件升级完成" + "\n");
                }

                if (textBox_UpgradeFilePathUBI.Text != "")
                {
                    richTextBox_UpgradeLog.AppendText("找到UBI升级文件，准备升级" + "\n");

                    strCallAdbCmd = ExeFileName + "adb push " + UpgradeFilePath_UBI;    // adb push cmd
                    strCallAdbCmd += " " + textBox_UpgradeDestPathUBI.Text;    // 目标目录

                    richTextBox_UpgradeLog.AppendText(strCallAdbCmd + "\n");
                    myAdb.runCmd(null, strCallAdbCmd, out strLog);

                    richTextBox_UpgradeLog.AppendText(strLog + "\n");
                    richTextBox_UpgradeLog.AppendText("UBI文件升级完成" + "\n");
                }

                richTextBox_UpgradeLog.AppendText("全部升级流程结束" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.ToString());
            } 





        }
    }
}
