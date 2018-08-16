namespace VBFHelp
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_PullLog = new System.Windows.Forms.TabPage();
            this.richTextBox_PullLog = new System.Windows.Forms.RichTextBox();
            this.button_LogStartRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LogBrowsePath = new System.Windows.Forms.Button();
            this.textBox_LogSavePath = new System.Windows.Forms.TextBox();
            this.tabPage_Upgrade = new System.Windows.Forms.TabPage();
            this.button_UpgradeStart = new System.Windows.Forms.Button();
            this.richTextBox_UpgradeLog = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_BrowseFilePathUBI = new System.Windows.Forms.Button();
            this.button_BrowseFilePathSOC = new System.Windows.Forms.Button();
            this.button_BrowseFilePathOTA = new System.Windows.Forms.Button();
            this.textBox_UpgradeFilePathUBI = new System.Windows.Forms.TextBox();
            this.textBox_UpgradeDestPathUBI = new System.Windows.Forms.TextBox();
            this.textBox_UpgradeFilePathSOC = new System.Windows.Forms.TextBox();
            this.textBox_UpgradeDestPathSOC = new System.Windows.Forms.TextBox();
            this.textBox_UpgradeFilePathOTA = new System.Windows.Forms.TextBox();
            this.textBox_UpgradeDestPathOTA = new System.Windows.Forms.TextBox();
            this.tabPage_VBFParse = new System.Windows.Forms.TabPage();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.button_CalcCrc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Browser = new System.Windows.Forms.Button();
            this.textBox_CrcResult = new System.Windows.Forms.TextBox();
            this.textBox_VbfPath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_PullLog.SuspendLayout();
            this.tabPage_Upgrade.SuspendLayout();
            this.tabPage_VBFParse.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.推出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.推出ToolStripMenuItem.Text = "退出";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_PullLog);
            this.tabControl1.Controls.Add(this.tabPage_Upgrade);
            this.tabControl1.Controls.Add(this.tabPage_VBFParse);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 656);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_PullLog
            // 
            this.tabPage_PullLog.Controls.Add(this.richTextBox_PullLog);
            this.tabPage_PullLog.Controls.Add(this.button_LogStartRead);
            this.tabPage_PullLog.Controls.Add(this.label2);
            this.tabPage_PullLog.Controls.Add(this.button_LogBrowsePath);
            this.tabPage_PullLog.Controls.Add(this.textBox_LogSavePath);
            this.tabPage_PullLog.Location = new System.Drawing.Point(4, 34);
            this.tabPage_PullLog.Name = "tabPage_PullLog";
            this.tabPage_PullLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PullLog.Size = new System.Drawing.Size(1256, 618);
            this.tabPage_PullLog.TabIndex = 1;
            this.tabPage_PullLog.Text = "读取Log";
            this.tabPage_PullLog.UseVisualStyleBackColor = true;
            // 
            // richTextBox_PullLog
            // 
            this.richTextBox_PullLog.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_PullLog.Location = new System.Drawing.Point(6, 219);
            this.richTextBox_PullLog.Name = "richTextBox_PullLog";
            this.richTextBox_PullLog.Size = new System.Drawing.Size(1242, 391);
            this.richTextBox_PullLog.TabIndex = 13;
            this.richTextBox_PullLog.Text = "";
            // 
            // button_LogStartRead
            // 
            this.button_LogStartRead.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_LogStartRead.Location = new System.Drawing.Point(865, 107);
            this.button_LogStartRead.Name = "button_LogStartRead";
            this.button_LogStartRead.Size = new System.Drawing.Size(143, 35);
            this.button_LogStartRead.TabIndex = 12;
            this.button_LogStartRead.Text = "开始读取Log";
            this.button_LogStartRead.UseVisualStyleBackColor = true;
            this.button_LogStartRead.Click += new System.EventHandler(this.button_LogStartRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log保存路径：";
            // 
            // button_LogBrowsePath
            // 
            this.button_LogBrowsePath.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_LogBrowsePath.Location = new System.Drawing.Point(865, 36);
            this.button_LogBrowsePath.Name = "button_LogBrowsePath";
            this.button_LogBrowsePath.Size = new System.Drawing.Size(101, 33);
            this.button_LogBrowsePath.TabIndex = 10;
            this.button_LogBrowsePath.Text = "Browse...";
            this.button_LogBrowsePath.UseVisualStyleBackColor = true;
            this.button_LogBrowsePath.Click += new System.EventHandler(this.button_LogBrowsePath_Click);
            // 
            // textBox_LogSavePath
            // 
            this.textBox_LogSavePath.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_LogSavePath.Location = new System.Drawing.Point(169, 36);
            this.textBox_LogSavePath.Name = "textBox_LogSavePath";
            this.textBox_LogSavePath.Size = new System.Drawing.Size(690, 33);
            this.textBox_LogSavePath.TabIndex = 9;
            // 
            // tabPage_Upgrade
            // 
            this.tabPage_Upgrade.Controls.Add(this.button_UpgradeStart);
            this.tabPage_Upgrade.Controls.Add(this.richTextBox_UpgradeLog);
            this.tabPage_Upgrade.Controls.Add(this.label8);
            this.tabPage_Upgrade.Controls.Add(this.label6);
            this.tabPage_Upgrade.Controls.Add(this.label4);
            this.tabPage_Upgrade.Controls.Add(this.label7);
            this.tabPage_Upgrade.Controls.Add(this.label5);
            this.tabPage_Upgrade.Controls.Add(this.label3);
            this.tabPage_Upgrade.Controls.Add(this.button_BrowseFilePathUBI);
            this.tabPage_Upgrade.Controls.Add(this.button_BrowseFilePathSOC);
            this.tabPage_Upgrade.Controls.Add(this.button_BrowseFilePathOTA);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeFilePathUBI);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeDestPathUBI);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeFilePathSOC);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeDestPathSOC);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeFilePathOTA);
            this.tabPage_Upgrade.Controls.Add(this.textBox_UpgradeDestPathOTA);
            this.tabPage_Upgrade.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Upgrade.Name = "tabPage_Upgrade";
            this.tabPage_Upgrade.Size = new System.Drawing.Size(1256, 618);
            this.tabPage_Upgrade.TabIndex = 2;
            this.tabPage_Upgrade.Text = "软件升级";
            this.tabPage_Upgrade.UseVisualStyleBackColor = true;
            // 
            // button_UpgradeStart
            // 
            this.button_UpgradeStart.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_UpgradeStart.Location = new System.Drawing.Point(827, 222);
            this.button_UpgradeStart.Name = "button_UpgradeStart";
            this.button_UpgradeStart.Size = new System.Drawing.Size(101, 35);
            this.button_UpgradeStart.TabIndex = 16;
            this.button_UpgradeStart.Text = "开始";
            this.button_UpgradeStart.UseVisualStyleBackColor = true;
            this.button_UpgradeStart.Click += new System.EventHandler(this.button_UpgradeStart_Click);
            // 
            // richTextBox_UpgradeLog
            // 
            this.richTextBox_UpgradeLog.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_UpgradeLog.Location = new System.Drawing.Point(3, 410);
            this.richTextBox_UpgradeLog.Name = "richTextBox_UpgradeLog";
            this.richTextBox_UpgradeLog.Size = new System.Drawing.Size(1242, 205);
            this.richTextBox_UpgradeLog.TabIndex = 15;
            this.richTextBox_UpgradeLog.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(17, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "UBI升级文件路径:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "SOC升级文件路径:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "OTA升级文件路径:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(972, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "目标路径:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(972, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "目标路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(972, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "目标路径:";
            // 
            // button_BrowseFilePathUBI
            // 
            this.button_BrowseFilePathUBI.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BrowseFilePathUBI.Location = new System.Drawing.Point(827, 146);
            this.button_BrowseFilePathUBI.Name = "button_BrowseFilePathUBI";
            this.button_BrowseFilePathUBI.Size = new System.Drawing.Size(101, 33);
            this.button_BrowseFilePathUBI.TabIndex = 13;
            this.button_BrowseFilePathUBI.Text = "Browse...";
            this.button_BrowseFilePathUBI.UseVisualStyleBackColor = true;
            this.button_BrowseFilePathUBI.Click += new System.EventHandler(this.button_BrowseFilePathUBI_Click);
            // 
            // button_BrowseFilePathSOC
            // 
            this.button_BrowseFilePathSOC.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BrowseFilePathSOC.Location = new System.Drawing.Point(827, 81);
            this.button_BrowseFilePathSOC.Name = "button_BrowseFilePathSOC";
            this.button_BrowseFilePathSOC.Size = new System.Drawing.Size(101, 33);
            this.button_BrowseFilePathSOC.TabIndex = 13;
            this.button_BrowseFilePathSOC.Text = "Browse...";
            this.button_BrowseFilePathSOC.UseVisualStyleBackColor = true;
            this.button_BrowseFilePathSOC.Click += new System.EventHandler(this.button_BrowseFilePathSOC_Click);
            // 
            // button_BrowseFilePathOTA
            // 
            this.button_BrowseFilePathOTA.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BrowseFilePathOTA.Location = new System.Drawing.Point(827, 21);
            this.button_BrowseFilePathOTA.Name = "button_BrowseFilePathOTA";
            this.button_BrowseFilePathOTA.Size = new System.Drawing.Size(101, 33);
            this.button_BrowseFilePathOTA.TabIndex = 13;
            this.button_BrowseFilePathOTA.Text = "Browse...";
            this.button_BrowseFilePathOTA.UseVisualStyleBackColor = true;
            this.button_BrowseFilePathOTA.Click += new System.EventHandler(this.button_BrowseFilePathOTA_Click);
            // 
            // textBox_UpgradeFilePathUBI
            // 
            this.textBox_UpgradeFilePathUBI.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeFilePathUBI.Location = new System.Drawing.Point(204, 146);
            this.textBox_UpgradeFilePathUBI.Name = "textBox_UpgradeFilePathUBI";
            this.textBox_UpgradeFilePathUBI.Size = new System.Drawing.Size(617, 33);
            this.textBox_UpgradeFilePathUBI.TabIndex = 12;
            // 
            // textBox_UpgradeDestPathUBI
            // 
            this.textBox_UpgradeDestPathUBI.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeDestPathUBI.Location = new System.Drawing.Point(1066, 147);
            this.textBox_UpgradeDestPathUBI.Name = "textBox_UpgradeDestPathUBI";
            this.textBox_UpgradeDestPathUBI.Size = new System.Drawing.Size(173, 33);
            this.textBox_UpgradeDestPathUBI.TabIndex = 12;
            // 
            // textBox_UpgradeFilePathSOC
            // 
            this.textBox_UpgradeFilePathSOC.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeFilePathSOC.Location = new System.Drawing.Point(204, 81);
            this.textBox_UpgradeFilePathSOC.Name = "textBox_UpgradeFilePathSOC";
            this.textBox_UpgradeFilePathSOC.Size = new System.Drawing.Size(617, 33);
            this.textBox_UpgradeFilePathSOC.TabIndex = 12;
            // 
            // textBox_UpgradeDestPathSOC
            // 
            this.textBox_UpgradeDestPathSOC.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeDestPathSOC.Location = new System.Drawing.Point(1066, 82);
            this.textBox_UpgradeDestPathSOC.Name = "textBox_UpgradeDestPathSOC";
            this.textBox_UpgradeDestPathSOC.Size = new System.Drawing.Size(173, 33);
            this.textBox_UpgradeDestPathSOC.TabIndex = 12;
            // 
            // textBox_UpgradeFilePathOTA
            // 
            this.textBox_UpgradeFilePathOTA.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeFilePathOTA.Location = new System.Drawing.Point(204, 21);
            this.textBox_UpgradeFilePathOTA.Name = "textBox_UpgradeFilePathOTA";
            this.textBox_UpgradeFilePathOTA.Size = new System.Drawing.Size(617, 33);
            this.textBox_UpgradeFilePathOTA.TabIndex = 12;
            // 
            // textBox_UpgradeDestPathOTA
            // 
            this.textBox_UpgradeDestPathOTA.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_UpgradeDestPathOTA.Location = new System.Drawing.Point(1066, 22);
            this.textBox_UpgradeDestPathOTA.Name = "textBox_UpgradeDestPathOTA";
            this.textBox_UpgradeDestPathOTA.Size = new System.Drawing.Size(173, 33);
            this.textBox_UpgradeDestPathOTA.TabIndex = 12;
            // 
            // tabPage_VBFParse
            // 
            this.tabPage_VBFParse.Controls.Add(this.richTextBox_Log);
            this.tabPage_VBFParse.Controls.Add(this.button_CalcCrc);
            this.tabPage_VBFParse.Controls.Add(this.label1);
            this.tabPage_VBFParse.Controls.Add(this.button_Browser);
            this.tabPage_VBFParse.Controls.Add(this.textBox_CrcResult);
            this.tabPage_VBFParse.Controls.Add(this.textBox_VbfPath);
            this.tabPage_VBFParse.Location = new System.Drawing.Point(4, 34);
            this.tabPage_VBFParse.Name = "tabPage_VBFParse";
            this.tabPage_VBFParse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VBFParse.Size = new System.Drawing.Size(1256, 618);
            this.tabPage_VBFParse.TabIndex = 0;
            this.tabPage_VBFParse.Text = "VBF解析";
            this.tabPage_VBFParse.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Log.Location = new System.Drawing.Point(8, 313);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.Size = new System.Drawing.Size(1240, 284);
            this.richTextBox_Log.TabIndex = 8;
            this.richTextBox_Log.Text = "";
            // 
            // button_CalcCrc
            // 
            this.button_CalcCrc.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CalcCrc.Location = new System.Drawing.Point(567, 196);
            this.button_CalcCrc.Name = "button_CalcCrc";
            this.button_CalcCrc.Size = new System.Drawing.Size(143, 35);
            this.button_CalcCrc.TabIndex = 7;
            this.button_CalcCrc.Text = "开始计算CRC";
            this.button_CalcCrc.UseVisualStyleBackColor = true;
            this.button_CalcCrc.Click += new System.EventHandler(this.button_CalcCrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "VBF文件：";
            // 
            // button_Browser
            // 
            this.button_Browser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Browser.Location = new System.Drawing.Point(812, 87);
            this.button_Browser.Name = "button_Browser";
            this.button_Browser.Size = new System.Drawing.Size(101, 33);
            this.button_Browser.TabIndex = 3;
            this.button_Browser.Text = "Browse...";
            this.button_Browser.UseVisualStyleBackColor = true;
            this.button_Browser.Click += new System.EventHandler(this.button_Browser_Click);
            // 
            // textBox_CrcResult
            // 
            this.textBox_CrcResult.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CrcResult.Location = new System.Drawing.Point(747, 198);
            this.textBox_CrcResult.Name = "textBox_CrcResult";
            this.textBox_CrcResult.Size = new System.Drawing.Size(192, 33);
            this.textBox_CrcResult.TabIndex = 2;
            // 
            // textBox_VbfPath
            // 
            this.textBox_VbfPath.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_VbfPath.Location = new System.Drawing.Point(116, 87);
            this.textBox_VbfPath.Name = "textBox_VbfPath";
            this.textBox_VbfPath.Size = new System.Drawing.Size(690, 33);
            this.textBox_VbfPath.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "VBF Help V1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_PullLog.ResumeLayout(false);
            this.tabPage_PullLog.PerformLayout();
            this.tabPage_Upgrade.ResumeLayout(false);
            this.tabPage_Upgrade.PerformLayout();
            this.tabPage_VBFParse.ResumeLayout(false);
            this.tabPage_VBFParse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推出ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_VBFParse;
        private System.Windows.Forms.TabPage tabPage_PullLog;
        public System.Windows.Forms.Button button_CalcCrc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_Browser;
        public System.Windows.Forms.TextBox textBox_VbfPath;
        public System.Windows.Forms.RichTextBox richTextBox_Log;
        public System.Windows.Forms.TextBox textBox_CrcResult;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.RichTextBox richTextBox_PullLog;
        public System.Windows.Forms.Button button_LogStartRead;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_LogBrowsePath;
        public System.Windows.Forms.TextBox textBox_LogSavePath;
        private System.Windows.Forms.TabPage tabPage_Upgrade;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_BrowseFilePathOTA;
        public System.Windows.Forms.TextBox textBox_UpgradeFilePathOTA;
        public System.Windows.Forms.TextBox textBox_UpgradeDestPathOTA;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button_BrowseFilePathUBI;
        public System.Windows.Forms.Button button_BrowseFilePathSOC;
        public System.Windows.Forms.TextBox textBox_UpgradeFilePathUBI;
        public System.Windows.Forms.TextBox textBox_UpgradeDestPathUBI;
        public System.Windows.Forms.TextBox textBox_UpgradeFilePathSOC;
        public System.Windows.Forms.TextBox textBox_UpgradeDestPathSOC;
        public System.Windows.Forms.RichTextBox richTextBox_UpgradeLog;
        public System.Windows.Forms.Button button_UpgradeStart;
    }
}

