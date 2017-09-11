namespace FoxArp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_HideKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ShowKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSpeed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbDeviece
            // 
            this.cbbDeviece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeviece.FormattingEnabled = true;
            this.cbbDeviece.Location = new System.Drawing.Point(84, 13);
            this.cbbDeviece.Name = "cbbDeviece";
            this.cbbDeviece.Size = new System.Drawing.Size(315, 20);
            this.cbbDeviece.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择网卡";
            // 
            // tbxGateWayIp
            // 
            this.tbxGateWayIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGateWayIp.Location = new System.Drawing.Point(84, 44);
            this.tbxGateWayIp.Name = "tbxGateWayIp";
            this.tbxGateWayIp.Size = new System.Drawing.Size(107, 21);
            this.tbxGateWayIp.TabIndex = 1;
            this.tbxGateWayIp.Text = "192.168.1.1";
            // 
            // tbxGateWayMac
            // 
            this.tbxGateWayMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGateWayMac.Location = new System.Drawing.Point(278, 44);
            this.tbxGateWayMac.Name = "tbxGateWayMac";
            this.tbxGateWayMac.Size = new System.Drawing.Size(121, 21);
            this.tbxGateWayMac.TabIndex = 3;
            this.tbxGateWayMac.Text = "00:00:00:00:00:00";
            // 
            // tbxAtackIp
            // 
            this.tbxAtackIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAtackIp.Location = new System.Drawing.Point(84, 71);
            this.tbxAtackIp.Name = "tbxAtackIp";
            this.tbxAtackIp.Size = new System.Drawing.Size(107, 21);
            this.tbxAtackIp.TabIndex = 4;
            this.tbxAtackIp.Text = "192.168.1.2";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(84, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(199, 113);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCopyRight
            // 
            this.btnCopyRight.Location = new System.Drawing.Point(324, 159);
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
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "网关IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "攻击IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "攻击速度";
            // 
            // nudSendSpeed
            // 
            this.nudSendSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSendSpeed.Location = new System.Drawing.Point(279, 71);
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
            this.nudSendSpeed.Size = new System.Drawing.Size(120, 21);
            this.nudSendSpeed.TabIndex = 5;
            this.nudSendSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSendSpeed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnGetGateWayMac
            // 
            this.btnGetGateWayMac.Location = new System.Drawing.Point(199, 44);
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
            this.tabControl1.Size = new System.Drawing.Size(465, 215);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGetGateWayMac);
            this.tabPage1.Controls.Add(this.cbbDeviece);
            this.tabPage1.Controls.Add(this.nudSendSpeed);
            this.tabPage1.Controls.Add(this.tbxGateWayIp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbxGateWayMac);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbxAtackIp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.btnCopyRight);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 113);
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
            this.tabPage2.Size = new System.Drawing.Size(457, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置键位";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_HideKey
            // 
            this.textBox_HideKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_HideKey.Location = new System.Drawing.Point(107, 54);
            this.textBox_HideKey.Name = "textBox_HideKey";
            this.textBox_HideKey.Size = new System.Drawing.Size(100, 21);
            this.textBox_HideKey.TabIndex = 1;
            this.textBox_HideKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_HideKey_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "设置隐藏键位";
            // 
            // textBox_ShowKey
            // 
            this.textBox_ShowKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ShowKey.Location = new System.Drawing.Point(107, 15);
            this.textBox_ShowKey.Name = "textBox_ShowKey";
            this.textBox_ShowKey.Size = new System.Drawing.Size(100, 21);
            this.textBox_ShowKey.TabIndex = 1;
            this.textBox_ShowKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ShowKey_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "设置显示键位";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 215);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "反向ARP欺骗工具　";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSpeed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

