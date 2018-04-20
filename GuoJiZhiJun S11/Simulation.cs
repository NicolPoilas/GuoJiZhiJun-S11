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
    public partial class Simulation : Form
    {
        canDriverKvaser driver = new canDriverKvaser();
        int i = 0;
        byte[] TXMsgs = new byte[0];

        public Simulation()
        {
            InitializeComponent();
            MmTime_init();
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
                if (radioButton1.Checked)
                {

                }
                else if (radioButton2.Checked)
                {

                }
            };

            mmtimer_tick_200ms += delegate
            {

            };

            mmtimer_tick_1s += delegate
            {
               
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
