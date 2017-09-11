namespace FoxArp
{
    partial class WinForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.cbbDeviece = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGateWayIp = new System.Windows.Forms.TextBox();
            this.tbxGateWayMac = new System.Windows.Forms.TextBox();
            this.tbxAtackIp = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCopyRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSendSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnGetGateWayMac = new System.Windows.Forms.Button();
            this.bgwArpSend = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myContainer1 = new WindowsControlLibrary.MyContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ScanStop = new System.Windows.Forms.Button();
            this.btn_ScanNet = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_HideKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ShowKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSpeed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbDeviece
            // 
            this.cbbDeviece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeviece.FormattingEnabled = true;
            this.cbbDeviece.Location = new System.Drawing.Point(82, 18);
            this.cbbDeviece.Name = "cbbDeviece";
            this.cbbDeviece.Size = new System.Drawing.Size(315, 20);
            this.cbbDeviece.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择网卡";
            // 
            // tbxGateWayIp
            // 
            this.tbxGateWayIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGateWayIp.Location = new System.Drawing.Point(82, 49);
            this.tbxGateWayIp.Name = "tbxGateWayIp";
            this.tbxGateWayIp.Size = new System.Drawing.Size(107, 21);
            this.tbxGateWayIp.TabIndex = 1;
            this.tbxGateWayIp.Text = "192.168.1.1";
            this.tbxGateWayIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGateWayIp_KeyPress);
            // 
            // tbxGateWayMac
            // 
            this.tbxGateWayMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGateWayMac.Location = new System.Drawing.Point(276, 49);
            this.tbxGateWayMac.Name = "tbxGateWayMac";
            this.tbxGateWayMac.Size = new System.Drawing.Size(121, 21);
            this.tbxGateWayMac.TabIndex = 3;
            this.tbxGateWayMac.Text = "00:00:00:00:00:00";
            // 
            // tbxAtackIp
            // 
            this.tbxAtackIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAtackIp.Location = new System.Drawing.Point(82, 79);
            this.tbxAtackIp.Name = "tbxAtackIp";
            this.tbxAtackIp.Size = new System.Drawing.Size(107, 21);
            this.tbxAtackIp.TabIndex = 4;
            this.tbxAtackIp.Text = "192.168.1.2";
            this.tbxAtackIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGateWayIp_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCopyRight
            // 
            this.btnCopyRight.Location = new System.Drawing.Point(309, 117);
            this.btnCopyRight.Name = "btnCopyRight";
            this.btnCopyRight.Size = new System.Drawing.Size(75, 23);
            this.btnCopyRight.TabIndex = 8;
            this.btnCopyRight.Text = "版权信息";
            this.btnCopyRight.UseVisualStyleBackColor = true;
            this.btnCopyRight.Click += new System.EventHandler(this.btnCopyRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "网关IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "开始IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "攻击速度";
            // 
            // nudSendSpeed
            // 
            this.nudSendSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSendSpeed.Location = new System.Drawing.Point(276, 80);
            this.nudSendSpeed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSendSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSendSpeed.Name = "nudSendSpeed";
            this.nudSendSpeed.Size = new System.Drawing.Size(108, 21);
            this.nudSendSpeed.TabIndex = 5;
            this.nudSendSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSendSpeed.ValueChanged += new System.EventHandler(this.nudSendSpeed_ValueChanged);
            this.nudSendSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSendSpeed_KeyPress);
            // 
            // btnGetGateWayMac
            // 
            this.btnGetGateWayMac.Location = new System.Drawing.Point(197, 49);
            this.btnGetGateWayMac.Name = "btnGetGateWayMac";
            this.btnGetGateWayMac.Size = new System.Drawing.Size(61, 23);
            this.btnGetGateWayMac.TabIndex = 2;
            this.btnGetGateWayMac.Text = "获取MAC";
            this.btnGetGateWayMac.UseVisualStyleBackColor = true;
            this.btnGetGateWayMac.Click += new System.EventHandler(this.btnGetGateWayMac_Click);
            // 
            // bgwArpSend
            // 
            this.bgwArpSend.WorkerSupportsCancellation = true;
            this.bgwArpSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwArpSend_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 221);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.myContainer1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myContainer1
            // 
            this.myContainer1.ActiveControl = null;
            this.myContainer1.AutoScroll = true;
            this.myContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.myContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myContainer1.Items = ((System.Collections.ArrayList)(resources.GetObject("myContainer1.Items")));
            this.myContainer1.Location = new System.Drawing.Point(3, 240);
            this.myContainer1.Name = "myContainer1";
            this.myContainer1.Size = new System.Drawing.Size(403, 0);
            this.myContainer1.TabIndex = 15;
            this.myContainer1.Text = "myContainer1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_ScanStop);
            this.panel2.Controls.Add(this.btn_ScanNet);
            this.panel2.Controls.Add(this.textBox_IP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 38);
            this.panel2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "网段";
            // 
            // btn_ScanStop
            // 
            this.btn_ScanStop.Enabled = false;
            this.btn_ScanStop.Location = new System.Drawing.Point(110, 6);
            this.btn_ScanStop.Name = "btn_ScanStop";
            this.btn_ScanStop.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanStop.TabIndex = 16;
            this.btn_ScanStop.Text = "停止扫描";
            this.btn_ScanStop.UseVisualStyleBackColor = true;
            this.btn_ScanStop.Click += new System.EventHandler(this.btn_ScanStop_Click);
            // 
            // btn_ScanNet
            // 
            this.btn_ScanNet.Location = new System.Drawing.Point(18, 6);
            this.btn_ScanNet.Name = "btn_ScanNet";
            this.btn_ScanNet.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanNet.TabIndex = 15;
            this.btn_ScanNet.Text = "扫描网络";
            this.btn_ScanNet.UseVisualStyleBackColor = true;
            this.btn_ScanNet.Click += new System.EventHandler(this.btn_ScanNet_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IP.Location = new System.Drawing.Point(253, 9);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(107, 21);
            this.textBox_IP.TabIndex = 4;
            this.textBox_IP.Text = "192.168.1";
            this.textBox_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGateWayIp_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnCopyRight);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGetGateWayMac);
            this.panel1.Controls.Add(this.tbxAtackIp);
            this.panel1.Controls.Add(this.cbbDeviece);
            this.panel1.Controls.Add(this.nudSendSpeed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxGateWayIp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxGateWayMac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 199);
            this.panel1.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "折叠/展开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "隐藏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox_HideKey);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_ShowKey);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置键位";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "确定键位";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_HideKey
            // 
            this.textBox_HideKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_HideKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox_HideKey.Location = new System.Drawing.Point(111, 22);
            this.textBox_HideKey.Name = "textBox_HideKey";
            this.textBox_HideKey.Size = new System.Drawing.Size(100, 21);
            this.textBox_HideKey.TabIndex = 1;
            this.textBox_HideKey.Text = "F11";
            this.textBox_HideKey.TextChanged += new System.EventHandler(this.textBox_HideKey_TextChanged);
            this.textBox_HideKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HideKey_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "设置隐藏键位:";
            // 
            // textBox_ShowKey
            // 
            this.textBox_ShowKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ShowKey.ForeColor = System.Drawing.Color.Red;
            this.textBox_ShowKey.Location = new System.Drawing.Point(111, 56);
            this.textBox_ShowKey.Name = "textBox_ShowKey";
            this.textBox_ShowKey.Size = new System.Drawing.Size(100, 21);
            this.textBox_ShowKey.TabIndex = 1;
            this.textBox_ShowKey.Text = "F12";
            this.textBox_ShowKey.TextChanged += new System.EventHandler(this.textBox_ShowKey_TextChanged);
            this.textBox_ShowKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ShowKey_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "设置显示键位:";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 221);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "反向ARP欺骗工具　";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSpeed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDeviece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxGateWayIp;
        private System.Windows.Forms.TextBox tbxGateWayMac;
        private System.Windows.Forms.TextBox tbxAtackIp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCopyRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSendSpeed;
        private System.Windows.Forms.Button btnGetGateWayMac;
        private System.ComponentModel.BackgroundWorker bgwArpSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_ShowKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_HideKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        public WindowsControlLibrary.MyContainer myContainer1;
        private System.Windows.Forms.Button btn_ScanNet;
        private System.Windows.Forms.Button btn_ScanStop;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

