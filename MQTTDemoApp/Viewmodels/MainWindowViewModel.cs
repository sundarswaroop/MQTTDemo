using MQTTDemoApp.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;
using uPLibrary.Networking.M2Mqtt;

namespace MQTTDemoApp.Viewmodels
{
    public class MainWindowViewModel : NotifyBase
    {
        #region Private Members
        private bool isConnected;
        private MqttClient mqttClient = null;
        private string serverInfo = "localhost";
        private string msgToPublish;
        private string topicToPublish;
        private string topicToSubscribe;
        private string subscribedMsg = "";
        private int publishInterval = 1;
        private string contBtnText = "Start";
        private string connectBtnTxt = "Connect";
        #endregion

        #region Public properties
        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; NotifyPropertyChanged(); }
        }

        public string ServerInfo
        {
            get { return serverInfo; }
            set { serverInfo = value; NotifyPropertyChanged(); }
        }

        public string MsgToPublish
        {
            get { return msgToPublish; }
            set { msgToPublish = value; NotifyPropertyChanged(); }
        }

        public string TopicToPublish
        {
            get { return topicToPublish; }
            set { topicToPublish = value; NotifyPropertyChanged(); }
        }
        private string publisherName = "MQTTDemoApp";

        public string PublisherName
        {
            get { return publisherName; }
            set { publisherName = value; NotifyPropertyChanged(); }
        }

        public string TopicToSubscribe
        {
            get { return topicToSubscribe; }
            set { topicToSubscribe = value; NotifyPropertyChanged(); }
        }

        public string SubscribedMsg
        {
            get { return subscribedMsg; }
            set { subscribedMsg = value; NotifyPropertyChanged(); }
        }

        public int PublishInterval
        {
            get { return publishInterval; }
            set { publishInterval = value; NotifyPropertyChanged(); }
        }

        public string ContBtnText
        {
            get { return contBtnText; }
            set { contBtnText = value; NotifyPropertyChanged(); }
        }

        public string ConnectBtnTxt
        {
            get { return connectBtnTxt; }
            set { connectBtnTxt = value; NotifyPropertyChanged(); }
        }



        public DelegateCommand ConnectionCommand { get; set; }
        public DelegateCommand DisconnectCommand { get; set; }
        public DelegateCommand PublishCommand { get; set; }
        public DelegateCommand SubscribeCommand { get; set; }
        public DelegateCommand ContPublishCommand { get; set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            ConnectionCommand = new DelegateCommand(x => { ConnectToClient(); });
            DisconnectCommand = new DelegateCommand(x => { DisconnectClient(); });
            PublishCommand = new DelegateCommand(x => { PublishContent(); });
            SubscribeCommand = new DelegateCommand(x => { SubcribeContent(); });
            ContPublishCommand = new DelegateCommand(x => { ContPublishContent(); });
        }
        #endregion

        #region Private Methods
        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                WriteToConsole(ASCIIEncoding.UTF8.GetString(e.Message));
            });
        }

        private void PublishContent(bool isContinuous = false)
        {
            if (mqttClient != null)
            {
                string str = isContinuous == false ? MsgToPublish : DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss fff");
                str = $"[{PublisherName}] :{str}";
                mqttClient.Publish(TopicToPublish, ASCIIEncoding.UTF8.GetBytes(str));
            }
        }

        private void SubcribeContent()
        {
            if (mqttClient != null)
            {
                mqttClient.Subscribe(new string[] { TopicToSubscribe }, new byte[] { 2 });
                WriteToConsole($"Subscribed to {TopicToSubscribe}");
            }
        }

        private void DisconnectClient()
        {
            if (mqttClient != null)
            {
                EndTimer();
                PublisherName = "MQTTDemoApp";
                mqttClient.MqttMsgPublishReceived -= MqttClient_MqttMsgPublishReceived;
                mqttClient.Disconnect();
                mqttClient = null;
                ConnectBtnTxt = "Connect";
                WriteToConsole("Disconnected");
                IsConnected = false;
            }
        }

        private void ConnectToClient()
        {
            try
            {
                if (IsConnected)
                {
                    DisconnectClient();
                }
                else
                {
                    mqttClient = new MqttClient(ServerInfo);
                    Guid clientId = Guid.NewGuid();
                    PublisherName = string.IsNullOrWhiteSpace(PublisherName) || PublisherName == "MQTTDemoApp" ? clientId.ToString() : PublisherName;
                    mqttClient.Connect(clientId.ToString());
                    mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                    WriteToConsole("Connected");
                    ConnectBtnTxt = "Disconnect";
                    IsConnected = true;
                }
            }
            catch (Exception ex)
            {
                //lblConnectStatus.Text = ex.Message;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectClient();
        }

        private void WriteToConsole(string log)
        {
            //string str = log + Environment.NewLine + SubscribedMsg;
            SubscribedMsg = SubscribedMsg?.Insert(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff") + " : " + log + Environment.NewLine);
        }

        Timer timer = null;

        private void ContPublishContent()
        {
            if (timer == null)
                StartTimer();
            else
                EndTimer();
        }

        private void StartTimer()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = PublishInterval == 0 ? 100 : PublishInterval * 1000;
                timer.Enabled = true;
                timer.Elapsed += Timer_Elapsed;
                ContBtnText = "Stop";
            }
        }

        private void EndTimer()
        {
            if (timer != null)
            {
                ContBtnText = "Start";
                timer.Enabled = false;
                timer.Elapsed -= Timer_Elapsed;
                timer = null;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PublishContent(true);
        }


        private void OnWindowClosing(object sender, CancelEventArgs e)
        {
            DisconnectClient();
        }

        internal CancelEventHandler OnWindowClosing()
        {
            return new CancelEventHandler(OnWindowClosing);
        }
        #endregion
    }
}
