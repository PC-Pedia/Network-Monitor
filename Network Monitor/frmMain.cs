using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Network_Monitor
{
    public partial class frmMain : Form
    {
        private const double BYTE = 1;
        private const double KILOBYTE = 1024 * BYTE;
        private const double MEGABYTE = 1024 * KILOBYTE;
        private const double GIGABYTE = 1024 * MEGABYTE;
        private const double BIT_BYTE_RATIO = 8.0;

        private const string PER_SECOND = "/s";

        private NetworkInterface mCurrentNetworkInterface;
        private long mCurrentBytesReceived;
        private long mCurrentBytesSent;

        public frmMain()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpMoreInfo.Visible = false;

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                dropdownNetwork.Items.Add(ni.Name);
            }
            dropdownNetwork.Tag = interfaces;
            dropdownNetwork.SelectedIndex = 0;
            dropdownMaxDownloadSpeedUnits.SelectedIndex = 2;
            dropdownMaxUploadSpeedUnits.SelectedIndex = 1;
        }

        private void dropdownNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Stop();

            mCurrentNetworkInterface = ((NetworkInterface[])dropdownNetwork.Tag)[dropdownNetwork.SelectedIndex];
            IPInterfaceStatistics ipStats = mCurrentNetworkInterface.GetIPStatistics();
            mCurrentBytesReceived = ipStats.BytesReceived;
            mCurrentBytesSent = ipStats.BytesSent;
            UpdateMaxSpeed();
            UpdateUploadDownloadTotal();

            timer.Start();
        }

        private void UpdateMaxSpeed()
        {
            lblMaxSpeed.Text = ToDigitalInformationUnits(mCurrentNetworkInterface.Speed, true, rbtnBytes.Checked);
        }

        private void UpdateUploadDownloadTotal()
        {
            lblDownload.Text = ToDigitalInformationUnits(mCurrentBytesReceived, false, rbtnBytes.Checked);
            lblUpload.Text = ToDigitalInformationUnits(mCurrentBytesSent, false, rbtnBytes.Checked);
        }

        private static string ToDigitalInformationUnits(long bytes, bool perSecond, bool useBytes)
        {
            if (bytes > GIGABYTE)
            {
                double dBytes = bytes / GIGABYTE;
                return String.Format("{0:F2} G{1}{2}",
                    useBytes ? dBytes : dBytes * BIT_BYTE_RATIO,
                    useBytes ? 'B' : 'b',
                    perSecond ? PER_SECOND : String.Empty);
            }
            else if (bytes > MEGABYTE)
            {
                double dBytes = bytes / MEGABYTE;
                return String.Format("{0:F2} M{1}{2}",
                    useBytes ? dBytes : dBytes * BIT_BYTE_RATIO,
                    useBytes ? 'B' : 'b',
                    perSecond ? PER_SECOND : String.Empty);
            }
            else if (bytes > KILOBYTE)
            {
                double dBytes = bytes / KILOBYTE;
                return String.Format("{0:F2} K{1}{2}",
                    useBytes ? dBytes : dBytes * BIT_BYTE_RATIO,
                    useBytes ? 'B' : 'b',
                    perSecond ? PER_SECOND : String.Empty);
            }
            else // if (l > BYTE)
            {
                double dBytes = bytes / BYTE;
                return String.Format("{0:F2} {1}{2}",
                    useBytes ? dBytes : dBytes * BIT_BYTE_RATIO,
                    useBytes ? "Bytes" : "bits",
                    perSecond ? PER_SECOND : String.Empty);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            IPInterfaceStatistics ipStats = mCurrentNetworkInterface.GetIPStatistics();
            long downloadSpeed = ipStats.BytesReceived - mCurrentBytesReceived;
            long uploadSpeed = ipStats.BytesSent - mCurrentBytesSent;

            lblDownloadSpeed.Text = ToDigitalInformationUnits(downloadSpeed, true, rbtnBytes.Checked);
            lblUploadSpeed.Text = ToDigitalInformationUnits(uploadSpeed, true, rbtnBytes.Checked);

            if (progressDownloadSpeed.Visible)
            {
                progressDownloadSpeed.Value = downloadSpeed <= progressDownloadSpeed.Maximum ? (int)downloadSpeed : progressDownloadSpeed.Maximum;
            }
            if (progressUploadSpeed.Visible)
            {
                progressUploadSpeed.Value = uploadSpeed <= progressUploadSpeed.Maximum ? (int)uploadSpeed : progressUploadSpeed.Maximum;
            }

            mCurrentBytesReceived = ipStats.BytesReceived;
            mCurrentBytesSent = ipStats.BytesSent;
            UpdateUploadDownloadTotal();
        }

        private void rbtnBytes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMaxSpeed();
            updownMaxDownloadSpeed_ValueChanged(sender, e);
            updownMaxUploadSpeed_ValueChanged(sender, e);
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkOnTop.Checked;
        }

        private static void AddNode(ref TreeNode parent, object obj, string nodeName)
        {
            TreeNode node = new TreeNode(nodeName);
            foreach (var property in obj.GetType().GetProperties())
            {
                TreeNode child = new TreeNode(property.Name + "=" + property.GetValue(obj));
                node.Nodes.Add(child);
            }
            parent.Nodes.Add(node);
        }

        private static TreeNode GetNode(object obj, string nodeName)
        {
            TreeNode node = new TreeNode(nodeName);
            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (var property in props)
            {
                object propValue = property.GetValue(obj);
                TreeNode child = new TreeNode(property.Name + "=" + propValue);
                node.Nodes.Add(child);
            }
            return node;
        }

        private static void FillTreeView(ref TreeView tree, NetworkInterface ni)
        {
            tree.Nodes.Clear();
            TreeNode nodeNetworkInterface = GetNode(ni, "Network Interface");
            nodeNetworkInterface.Nodes.Add(new TreeNode("PhysicalAddress=" + ni.GetPhysicalAddress().ToString()));
            tree.Nodes.Add(nodeNetworkInterface);

            var ipProperties = ni.GetIPProperties();
            TreeNode nodeIpProperties = new TreeNode("IP Properties");
            nodeIpProperties.Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("DnsSuffix=" + ipProperties.DnsSuffix),
                new TreeNode("IsDnsEnabled=" + ipProperties.IsDnsEnabled),
                new TreeNode("IsDynamicDnsEnabled=" + ipProperties.IsDynamicDnsEnabled),
            });
            nodeIpProperties.Nodes.Add(GetNode(ipProperties.DhcpServerAddresses, "DhcpServerAddresses"));
            nodeIpProperties.Nodes.Add(GetNode(ipProperties.DnsAddresses, "DnsAddresses"));

            AddNode(ref nodeIpProperties, ipProperties.GetIPv4Properties(), "IPv4 Properties");
            AddNode(ref nodeIpProperties, ipProperties.GetIPv6Properties(), "IPv6 Properties");
            tree.Nodes.Add(nodeIpProperties);

            TreeNode nodeIpStats = GetNode(ni.GetIPStatistics(), "IP Statistics");
            AddNode(ref nodeIpStats, ni.GetIPv4Statistics(), "IPv4 Statistics");
            tree.Nodes.Add(nodeIpStats);
        }

        private static TreeNode GetNode(IEnumerable enumerable, string name)
        {
            TreeNode baseNode = new TreeNode(name);
            foreach (var item in enumerable)
            {
                baseNode.Nodes.Add(new TreeNode(item.ToString()));
            }
            return baseNode;
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            FillTreeView(ref treeView1, mCurrentNetworkInterface);
            grpMoreInfo.Visible = true;
            grpMoreInfo.Text = "More Information [" + DateTime.Now.TimeOfDay.ToString() + "]";
        }

        private void updownMaxDownloadSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (updownMaxDownloadSpeed.Value > 0)
            {                
                progressDownloadSpeed.Maximum = (int)(updownMaxDownloadSpeed.Value * GetUnit(dropdownMaxDownloadSpeedUnits.SelectedIndex));
                progressDownloadSpeed.Visible = true;
            }
            else
            {
                progressDownloadSpeed.Visible = false;
            }
        }

        private void updownMaxUploadSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (updownMaxUploadSpeed.Value > 0)
            {
                progressUploadSpeed.Maximum = (int)(updownMaxUploadSpeed.Value * GetUnit(dropdownMaxUploadSpeedUnits.SelectedIndex));
                progressUploadSpeed.Visible = true;
            }
            else
            {
                progressUploadSpeed.Visible = false;
            }
        }

        private decimal GetUnit(int i)
        {
            switch (i)
            {
                default:
                case 0:
                    return (decimal)BYTE;
                case 1:
                    return (decimal)KILOBYTE;
                case 2:
                    return (decimal)MEGABYTE;
                case 3:
                    return (decimal)GIGABYTE;
                case 4:
                    return (decimal)(BYTE/BIT_BYTE_RATIO);
                case 5:
                    return (decimal)(KILOBYTE/BIT_BYTE_RATIO);
                case 6:
                    return (decimal)(MEGABYTE/BIT_BYTE_RATIO);
                case 7:
                    return (decimal)(GIGABYTE/BIT_BYTE_RATIO);
            }
        }

        private void grpMoreInfo_VisibleChanged(object sender, EventArgs e)
        {
            this.Size = grpMoreInfo.Visible ? new System.Drawing.Size(648, 506) : new System.Drawing.Size(648, 239);
        }
    }
}