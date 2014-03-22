using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InfoProxy;
using InfoProxy.Charts;
using System.Diagnostics;
using System.IO;
using NLog;

namespace BtcTick
{
    public partial class TickForm : Form
    {
        private object locker = new object();
        private bool _loading = false;
        private System.Windows.Forms.Timer _timerTicker = new System.Windows.Forms.Timer();

        public TickForm()
        {
            InitializeComponent();
            _timerTicker.Tick += new EventHandler(_timerTicker_Tick);
            _timerTicker.Interval = 15000;
        }


        private void TickForm_Load(object sender, EventArgs e)
        {
             _timerTicker.Start();

             GetDataAsync();
        }

        private void _timerTicker_Tick(object sender, EventArgs e)
        {
            GetDataAsync();
        }

        private void GetDataAsync()
        {
            var thread = new Thread(() =>
            {
                GetData();
            });

            thread.Start();
        }

        private void GetData()
        {
            try
            {
                if (_loading)
                {
                    return;
                }

                lock (locker)
                {
                    _loading = true;
                    this.labelStatus.Visible = false;

                    var gaugechart = "";
                    var market = SingleInstance.The.Market;
                    var tick = market.GetTick();


                    if (tick != null && tick.last != null)
                    {

                        gaugechart = ChartUtils.GetGaugeChart(tick);
                        this.Invoke(new Action(() =>
                        {
                            try
                            {
                                SuspendLayout();

                                webBrowserGauge.DocumentText = gaugechart;

                                ResumeLayout();
                            }
                            catch (Exception exception)
                            {
                                this.labelStatus.Text = "Connection error";
                                this.labelStatus.Visible = true;
                                SingleInstance.Log.Debug(exception.Message);
                                this.ResumeLayout();
                            }
                        }));
                    }
                    else
                    {
                       this.Invoke(new Action(() =>
                       {
                           this.labelStatus.Text = "Connection error";
                           this.labelStatus.Visible = true;
                       }));
                    }
                }

                _loading = false;
            }
            catch (Exception exception)
            {
                //this.Invoke(new Action(() =>
                //{
                //    this.labelStatus.Text = "Connection error";
                //    this.labelStatus.Visible = true;
                //}));
                SingleInstance.Log.Debug(exception.Message);
            }
        }

        private void LogMessage(string message)
        {
            var logfile = Application.StartupPath + @"\ticker.log";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(logfile, true))
            {
                file.WriteLine(message);
            }
        }
    }
}
