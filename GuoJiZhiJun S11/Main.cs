using System;
using System.Windows.Forms;
using canTransport;
using canDriver;
using SecurityAccess;
using Dongzr.MidiLite;
using System.Text.RegularExpressions;
using System.Threading;

namespace GuoJiZhiJun_S11
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            BusParamsInit();
            MmTime_init();
            //Trans_init();
        }

        canDriverKvaser driver = new canDriverKvaser();
        canTrans driverTrans = new canTrans();
        SecurityKey securityDriver = new SecurityKey();
        DateTime time = new DateTime();

        #region BusSetting
        private void BusParamsInit()
        {
            string[] channel = new string[0];
            channel = driver.GetChannel();
            comboBoxChannel.Items.Clear();
            comboBoxChannel.Items.AddRange(channel);//add items for comboBox
            comboBoxChannel.SelectedIndex = 0;//default select the first , physical driver always come first
            comboBoxBaudrate.SelectedIndex = 4;//default select 500K   

        }

        private void BusOffOn_Click(object sender, EventArgs e)
        {
            if (BusOffOn.Text == "Bus On")
            {
                if (driver.OpenChannel(comboBoxChannel.SelectedIndex, comboBoxBaudrate.Text) == true)
                {
                    BusOffOn.Text = "Bus Off";
                    driverTrans.Start();
                    mmTimer.Start();
                    labelBusLoad.Text = "Bus Load:" + driver.BusLoad().ToString() + "%";
                    comboBoxBaudrate.Enabled = false;
                    comboBoxChannel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("打开" + comboBoxChannel.Text + "通道失败!"); //最好能把原因定位出来 给故障编码写入帮助文件
                }
            }
            else
            {
                BusOffOn.Text = "Bus On";
                driverTrans.Stop();
                mmTimer.Stop();
                driver.CloseChannel();
                labelBusLoad.Text = "Bus Load:0%";
                comboBoxBaudrate.Enabled = true;
                comboBoxChannel.Enabled = true;
            }
        }
        #endregion

        /*将十六进制字符串转换成十六进制数组（不足末尾补0），失败返回空数组*/
        byte[] StringToHex(string strings)
        {
            byte[] hex = new byte[0];
            try
            {
                strings = strings.Replace("0x", "");
                strings = strings.Replace("0X", "");
                strings = strings.Replace(" ", "");
                strings = Regex.Replace(strings, @"(?i)[^a-f\d\s]+", "");//表示不可变正则表达式
                if (strings.Length % 2 != 0)
                {
                    strings += "0";
                }
                hex = new byte[strings.Length / 2];
                for (int i = 0; i < hex.Length; i++)
                {
                    hex[i] = Convert.ToByte(strings.Substring(i * 2, 2), 16);
                }
                return hex;
            }
            catch
            {
                return hex;
            }
        }

        /*将十六进制数组转换成十六进制字符串，并以space隔开*/
        string HexToStrings(byte[] hex)
        {
            string strings = "";
            for (int i = 0; i < hex.Length; i++)//逐字节变为16进制字符，并以space隔开
            {
                strings += hex[i].ToString("X2") + " ";
            }
            return strings;
        }

        /*定时器*/
        #region Timer
        public delegate void Tick_10ms();
        public delegate void Tick_20ms();
        public delegate void Tick_50ms();
        public delegate void Tick_100ms();
        public delegate void Tick_200ms();
        public delegate void Tick_1s();
        public delegate void Tick_2s();
        public delegate void Tick_5s();
        public delegate void Tick_60s();
        public Tick_10ms mmtimer_tick_10ms;
        public Tick_10ms mmtimer_tick_20ms;
        public Tick_10ms mmtimer_tick_50ms;
        public Tick_100ms mmtimer_tick_100ms;
        public Tick_200ms mmtimer_tick_200ms;
        public Tick_1s mmtimer_tick_1s;
        public Tick_2s mmtimer_tick_2s;
        public Tick_5s mmtimer_tick_5s;
        public Tick_60s mmtimer_tick_60s;
        public MmTimer mmTimer;
        const int timer_interval = 10;
        int timer_10ms_counter = 0;
        int timer_20ms_counter = 0;
        int timer_50ms_counter = 0;
        int timer_100ms_counter = 0;
        int timer_200ms_counter = 0;
        int timer_1s_counter = 0;
        int timer_2s_counter = 0;
        int timer_5s_counter = 0;
        int timer_60s_counter = 0;

        private void MmTime_init()
        {
            mmTimer = new MmTimer
            {
                Mode = MmTimerMode.Periodic,
                Interval = timer_interval
            };
            mmTimer.Tick += mmTimer_tick;

            mmtimer_tick_10ms += delegate
            {

            };

            mmtimer_tick_20ms += delegate
            {

            };

            mmtimer_tick_50ms += delegate
            {

            };

            mmtimer_tick_100ms += delegate
            {
                
            };

            mmtimer_tick_200ms += delegate
            {

            };

            mmtimer_tick_1s += delegate
            {
                EventHandler BusLoadUpdate = delegate
                {
                    labelBusLoad.Text = "Bus Load:" + driver.BusLoad().ToString() + "% ";//更新BusLoad
                };
                try { Invoke(BusLoadUpdate); } catch { };
            };

            mmtimer_tick_2s += delegate
            {

            };

            mmtimer_tick_5s += delegate
            {

            };

            mmtimer_tick_60s += delegate
            {

            };
        }

        private void buttonSimulation_Click(object sender, EventArgs e)
        {
            Simulation form_Simulation = new Simulation();
            form_Simulation.Show();
        }

        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            Monitor form_Monitor = new Monitor();
            form_Monitor.Show();
        }

        void mmTimer_tick(object sender, EventArgs e)
        {
            timer_10ms_counter += timer_interval;
            if (timer_10ms_counter >= 10)
            {
                timer_10ms_counter = 0;
                mmtimer_tick_10ms?.Invoke();
            }

            timer_20ms_counter += timer_interval;
            if (timer_20ms_counter >= 10)
            {
                timer_20ms_counter = 0;
                mmtimer_tick_20ms?.Invoke();
            }

            timer_50ms_counter += timer_interval;
            if (timer_50ms_counter >= 50)
            {
                timer_50ms_counter = 0;
                mmtimer_tick_50ms?.Invoke();
            }

            timer_100ms_counter += timer_interval;
            if (timer_100ms_counter >= 100)
            {
                timer_100ms_counter = 0;
                mmtimer_tick_100ms?.Invoke();
            }

            timer_200ms_counter += timer_interval;
            if (timer_200ms_counter >= 200)
            {
                timer_200ms_counter = 0;
                mmtimer_tick_200ms?.Invoke();
            }

            timer_1s_counter += timer_interval;
            if (timer_1s_counter >= 1000)
            {
                timer_1s_counter = 0;
                mmtimer_tick_1s?.Invoke();
            }

            timer_2s_counter += timer_interval;
            if (timer_2s_counter >= 2000)
            {
                timer_2s_counter = 0;
                mmtimer_tick_2s?.Invoke();
            }

            timer_5s_counter += timer_interval;
            if (timer_5s_counter >= 5000)
            {
                timer_5s_counter = 0;
                mmtimer_tick_5s?.Invoke();
            }

            timer_60s_counter += timer_interval;
            if (timer_60s_counter >= 60000)
            {
                timer_60s_counter = 0;
                mmtimer_tick_60s?.Invoke();
            }
        }
        #endregion

    }
}
