using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MQTTDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MqttClient mqttClient = null;

        Action<Control, string> UpdateSubscribedContent = (CtrlName, text) => CtrlName.Text = text + Environment.NewLine + CtrlName.Text;

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {

            if (this.rtbSubscribe.InvokeRequired)
                rtbSubscribe.Invoke(new MethodInvoker(() =>
                {
                    rtbSubscribe.Text = ASCIIEncoding.UTF8.GetString(e.Message) + Environment.NewLine + rtbSubscribe.Text;
                }));

            //if (this.InvokeRequired)
            //{
            //    this.Invoke(UpdateSubscribedContent, rtbSubscribe, ASCIIEncoding.UTF8.GetString(e.Message));
            //}
            //else
            //{
            //    UpdateSubscribedContent(rtbSubscribe, ASCIIEncoding.UTF8.GetString(e.Message));
            //}
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            PublishContent(txtPublish.Text);
        }

        private void PublishContent(string str)
        {
            if (mqttClient != null)
            {
                str = $"[{txtUser.Text}] : {str}";
                mqttClient.Publish(txtPubTopic.Text, ASCIIEncoding.UTF8.GetBytes(str));
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (mqttClient != null)
            {
                mqttClient.Subscribe(new string[] { txtSubTopic.Text }, new byte[] { 2 });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectClient();
        }

        private void DisconnectClient()
        {
            if (mqttClient != null)
            {
                mqttClient.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
                mqttClient.Disconnect();
                mqttClient = null;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                DisconnectClient();
                mqttClient = new MqttClient(txtServer.Text);
                Guid clientId = Guid.NewGuid();
                txtUser.Text = clientId.ToString();
                mqttClient.Connect(clientId.ToString());
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                lblConnectStatus.Text = "Connected";
            }
            catch (Exception ex)
            {
                lblConnectStatus.Text = ex.Message;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectClient();
            lblConnectStatus.Text = "Disconnected";
        }

        Timer timer = null;

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = int.Parse(txtInterval.Text) * 1000;
                timer.Enabled = true;
                timer.Tick += Timer_Tick;
                btnStart.Text = "Stop";
            }
            else
            {
                btnStart.Text = "Start";
                timer.Enabled = false;
                timer.Tick -= Timer_Tick;
                timer = null;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PublishContent(DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss fff"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = txtUser.Text;
            this.BackColor = ColorTranslator.FromHtml( ConfigurationManager.AppSettings["bgcolor"]);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            this.Text = txtUser.Text;
        }

        private void tsiBgColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dr = cd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackColor = cd.Color;
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings.Remove("bgcolor");
                config.AppSettings.Settings.Add("bgcolor", ColorTranslator.ToHtml(Color.FromArgb(cd.Color.ToArgb())).ToString());
                config.Save(ConfigurationSaveMode.Modified);
            }
        }
    }
}
