using System;
using System.IO.Ports;
using System.Windows.Forms;

using AForge.Video.DirectShow;

namespace ServoCam
{
    public partial class MainForm : Form
    {
        SerialPort port;
        VideoCaptureDevice camera;

        int x = 90, y = 90;

        public MainForm()
        {
            InitializeComponent();

            port = new SerialPort();
            port.BaudRate = 9600;
        }

        private void SerialConnect_Click(object sender, EventArgs e)
        {
            if (SerialConnect.Text == "Connect")
            {
                try
                {
                    port.PortName = (string)SerialList.SelectedItem;
                    if (!port.IsOpen) port.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SerialConnect.Text = "DisCon";
            }
            else if (SerialConnect.Text == "DisCon")
            {
                if (port.IsOpen) port.Close();
                SerialConnect.Text = "Connect";
            }
        }

        private void CamConnect_Click(object sender, EventArgs e)
        {
            if (CamConnect.Text == "Connect")
            {
                try
                {
                    camera = new VideoCaptureDevice((string)CameraList.SelectedItem);
                    VideoPlayer.VideoSource = camera;
                    VideoPlayer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CamConnect.Text = "DisCon";
            }
            else if (CamConnect.Text == "DisCon")
            {
                VideoPlayer.SignalToStop();
                VideoPlayer.WaitForStop();
                CamConnect.Text = "Connect";
            }
        }

        private void SerialList_Click(object sender, EventArgs e)
        {
            SerialList.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                SerialList.Items.Add(s);
        }

        private void CameraList_Click(object sender, EventArgs e)
        {
            CameraList.Items.Clear();
            foreach (FilterInfo info in new FilterInfoCollection(FilterCategory.VideoInputDevice))
                CameraList.Items.Add(info.MonikerString);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen) port.Close();
            VideoPlayer.SignalToStop();
            VideoPlayer.WaitForStop();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            x = x > 180 ? 180 : x + 1;
            if (port.IsOpen) port.Write("A" + x);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            x = x < 0 ? 0 : x - 1;
            if (port.IsOpen) port.Write("A" + x);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            y = y > 180 ? 180 : y + 1;
            if (port.IsOpen) port.Write("B" + y);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            y = y < 0 ? 0 : y - 1;
            if (port.IsOpen) port.Write("B" + y);
        }

        private void BtnCenter_Click(object sender, EventArgs e)
        {
            x = y = 90;
            if (port.IsOpen) port.Write("R");
        }

        private void BtnCenter_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    BtnUp_Click(null, null);
                    break;
                case Keys.S:
                    BtnDown_Click(null, null);
                    break;
                case Keys.A:
                    BtnLeft_Click(null, null);
                    break;
                case Keys.D:
                    BtnRight_Click(null, null);
                    break;
                case Keys.R:
                    BtnCenter_Click(null, null);
                    break;
            }
        }
    }
}
