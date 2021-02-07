using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet.Client;
using Newtonsoft.Json;

namespace FormosaRM_ICControl
{
    public partial class Form1 : Form
    {
        private IMqttClient mqttClient = null;
        public bool mqttClientConnected = false;
        static readonly string mqttBroker = "test.mosquitto.org";
        // static readonly string mqttBroker = "10.50.19.11"; // 長庚大學
        static readonly int mqttBrokerPort = 1883;
        static readonly string ClientId = "FormosaVerify-" + Guid.NewGuid().ToString();
        static readonly string username = "justForVerify";
        static readonly string password = "none";
        static readonly string txTopicFmt = "none/FORMOSA00001/{0}/tx";
        static readonly string[] txDevs = {
            "70BED5FFFE040001", "70BED5FFFE040002", "70BED5FFFE040003"
        };
        static readonly string[] compareRxTopic = {
                    "none/FORMOSA00001/70bed5fffe040001/rx",
                    "none/FORMOSA00001/70bed5fffe040002/rx",
                    "none/FORMOSA00001/70bed5fffe040003/rx",
                    "none/FORMOSA00001/70BED5FFFE040001/rx",
                    "none/FORMOSA00001/70BED5FFFE040002/rx",
                    "none/FORMOSA00001/70BED5FFFE040003/rx"
        };

        public class txInfo
        {
            uint frequency;
            int dr;
        }

        public class Irrigation
        {
            public bool channel1;
            public bool channel2;
            public bool channel3;
            public bool channel4;
        }
        public class LoRaObject
        {
            public Irrigation Irrigation;
            public string report;
        }
        public class rxEvent
        {
            public string applicationID;
            public string applicationName;
            public string deviceName;
            public string devEUI;
            public txInfo txInfo;
            public bool adr;
            public uint fCnt;
            public uint fPort;
            public string data;
            public LoRaObject @object;
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () => { await ConnectMqttServerAsync(); });
        }

        private void settingRefObjChannel(ref ICControlObject refObj, int ch)
        {
            if (ch >= 1 && ch <= 4)
            {
                refObj.@object.Irrigation.channel1 = RM1_IC01.On;
                refObj.@object.Irrigation.channel2 = RM1_IC02.On;
                refObj.@object.Irrigation.channel3 = RM1_IC03.On;
                refObj.@object.Irrigation.channel4 = RM1_IC04.On;
                if (ch == 1)
                    refObj.@object.Irrigation.channel1 = !refObj.@object.Irrigation.channel1;
                else if (ch == 2)
                    refObj.@object.Irrigation.channel2 = !refObj.@object.Irrigation.channel2;
                else if (ch == 3)
                    refObj.@object.Irrigation.channel3 = !refObj.@object.Irrigation.channel3;
                else if (ch == 4)
                    refObj.@object.Irrigation.channel4 = !refObj.@object.Irrigation.channel4;
            }
            else if ( ch >= 5 && ch <= 8)
            {
                refObj.@object.Irrigation.channel1 = RM2_IC01.On;
                refObj.@object.Irrigation.channel2 = RM2_IC02.On;
                refObj.@object.Irrigation.channel3 = RM2_IC03.On;
                refObj.@object.Irrigation.channel4 = RM2_IC04.On;
                if (ch == 5)
                    refObj.@object.Irrigation.channel1 = !refObj.@object.Irrigation.channel1;
                else if (ch == 6)
                    refObj.@object.Irrigation.channel2 = !refObj.@object.Irrigation.channel2;
                else if (ch == 7)
                    refObj.@object.Irrigation.channel3 = !refObj.@object.Irrigation.channel3;
                else if (ch == 8)
                    refObj.@object.Irrigation.channel4 = !refObj.@object.Irrigation.channel4;
            }
            else if ( ch >= 9 && ch <= 12)
            {
                refObj.@object.Irrigation.channel1 = RM3_IC01.On;
                refObj.@object.Irrigation.channel2 = RM3_IC02.On;
                refObj.@object.Irrigation.channel3 = RM3_IC03.On;
                refObj.@object.Irrigation.channel4 = RM3_IC04.On;
                if (ch == 9)
                    refObj.@object.Irrigation.channel1 = !refObj.@object.Irrigation.channel1;
                else if (ch == 10)
                    refObj.@object.Irrigation.channel2 = !refObj.@object.Irrigation.channel2;
                else if (ch == 11)
                    refObj.@object.Irrigation.channel3 = !refObj.@object.Irrigation.channel3;
                else if (ch == 12)
                    refObj.@object.Irrigation.channel4 = !refObj.@object.Irrigation.channel4;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((mqttClient != null) && (mqttClientConnected)) {
                Button btn = (Button)sender;
                if (btn.Name.StartsWith("button"))
                {
                    ICControlObject obj = new ICControlObject();
                    int ch = int.Parse(btn.Name.Substring("button".Length));
                    int devInx = (ch - 1) / 4;
                    settingRefObjChannel(ref obj, ch);
                    string topic = String.Format(txTopicFmt, txDevs[devInx]);
                    var msg = new MQTTnet.MqttApplicationMessageBuilder()
                        .WithPayload(JsonConvert.SerializeObject(obj))
                        .WithTopic(topic)
                        .WithAtMostOnceQoS()
                        .Build();
                    mqttClient.PublishAsync(msg);
                    string json = JsonConvert.SerializeObject(obj);
                    debugOutput("topic", topic);
                    debugOutput("json", json);
                }
            }
        }

        private IMqttClientOptions option()
        {
            debugOutput("opt", ClientId);
            var options = new MqttClientOptionsBuilder()
            .WithClientId(ClientId)
            .WithTcpServer(mqttBroker, mqttBrokerPort)
            .WithCredentials(username, password)
                          //.WithTls()//服務器端沒有啓用加密協議，這裏用tls的會提示協議異常
            .WithCleanSession(false)
            .WithKeepAlivePeriod(TimeSpan.FromSeconds(300))
            .Build();
            return options;
        }

        private async Task ConnectMqttServerAsync()
        {
            if (mqttClient == null)
            {
                mqttClient = new MQTTnet.MqttFactory().CreateMqttClient() as MqttClient;
                mqttClient.ApplicationMessageReceived += mqttApplicationMessageReceived;
                mqttClient.Connected += mqttConnected;
                mqttClient.Disconnected += mqttDisconnected;
            }

            try
            {
                await mqttClient.ConnectAsync(option());
            }
            catch (Exception ex)
            {
                Invoke((new Action(() =>
                {
                    Status.Text = "連接到MQTT服務器失敗！";
                })));
                debugOutput("err", ex.Message);
            }
        }

        private void settingBlubLed(int rm, ref rxEvent refRxE)
        {
            if (rm == 0)
            {
                RM1_IC01.On = refRxE.@object.Irrigation.channel1;
                RM1_IC02.On = refRxE.@object.Irrigation.channel2;
                RM1_IC03.On = refRxE.@object.Irrigation.channel3;
                RM1_IC04.On = refRxE.@object.Irrigation.channel4;
            } else if (rm == 1)
            {
                RM2_IC01.On = refRxE.@object.Irrigation.channel1;
                RM2_IC02.On = refRxE.@object.Irrigation.channel2;
                RM2_IC03.On = refRxE.@object.Irrigation.channel3;
                RM2_IC04.On = refRxE.@object.Irrigation.channel4;
            } else if (rm == 2)
            {
                RM3_IC01.On = refRxE.@object.Irrigation.channel1;
                RM3_IC02.On = refRxE.@object.Irrigation.channel2;
                RM3_IC03.On = refRxE.@object.Irrigation.channel3;
                RM3_IC04.On = refRxE.@object.Irrigation.channel4;
            }
        }

        private void mqttApplicationMessageReceived(object sender, MQTTnet.MqttApplicationMessageReceivedEventArgs e)
        {
            try
            {
                /* 
                  for example
                  topic:
                        none/FORMOSA00001/70bed5fffe040001/rx

                  message payload:
                        { "applicationID":"2","applicationName":"Formosa-Farm","deviceName":"RM1-IC01","devEUI":"70bed5fffe040001","txInfo":{ "frequency":903900000,"dr":0},"adr":true,"fCnt":29367,"fPort":6,"data":"AAA=","object":{ "Irrigation":{ "channel1":false,"channel2":false,"channel3":false,"channel4":false},"report":"Data"} }
                */
                string topic = e.ApplicationMessage.Topic;
                string strUtf8Payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                var payload = JsonConvert.DeserializeObject<rxEvent>(strUtf8Payload);
                for (int i = 0; i < 3; i++)
                {
                    if (0 == String.Compare(compareRxTopic[i], topic, true))
                    {
                        Invoke(new Action(() =>
                        {
                            settingBlubLed(i, ref payload);
                        }));
                    }
                }
                debugOutput(e.ApplicationMessage.Topic, strUtf8Payload);
            }
            catch (Exception ex)
            {
                debugOutput("Rx", ex.Message);
            }
        }

        private void mqttConnected(object sender, MqttClientConnectedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Status.Text = "連接到MQTT服務器成功！";
            }));
            mqttClientConnected = true;
            MQTTnet.TopicFilter[] topicFilter;
            topicFilter = new MQTTnet.TopicFilter[compareRxTopic.Length];
            for (int i = 0; i < compareRxTopic.Length; i++)
            {
                topicFilter[i] = new MQTTnet.TopicFilterBuilder()
                .WithTopic(compareRxTopic[i])
                .Build();
                debugOutput("regRxTopic", compareRxTopic[i]);
            }
            mqttClient.SubscribeAsync(topicFilter);
        }

        private void mqttDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                Status.Text = "離/斷線 MQTT服務器！";
            }));
            mqttClientConnected = false;
        }

        private void debugOutput(string tag, string info)
        {
            System.Diagnostics.Debug.WriteLine(String.Format("{0}:{1}", tag, info));
        }
    }
}