using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace ProcInfo
{
    public partial class Form1 : Form
    {
        bool start;
        int start_stop;
        int interval_msec;
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new Size(500, 300);
            varSetup();
        }

        private void varSetup() 
        {
            start = true;
            start_stop = 0;
            textBoxProcess.Text = "notepad.exe";
            interval_msec = (int)numericUpDownSeconds.Value * 1000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (start_stop % 2 == 0)
            {
                start = true;
                ProcStart();
                buttonStart.Text = "Stop";
            }
            else 
            {
                start = false;
                buttonStart.Text = "Start";
            }
            start_stop++;
 
        }

        private void numericUpDownSeconds_ValueChanged(object sender, EventArgs e)
        {
            interval_msec = (int)numericUpDownSeconds.Value * 1000;
        }

        private  void ProcStart() 
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();                
                Process process = Process.Start(textBoxProcess.Text);
                int id = process.Id;
                interval_msec = (int)numericUpDownSeconds.Value * 1000;
                textBoxID.Text = id.ToString();
                 
                new Task(() =>
                {
                   List<Sample> samples = new List<Sample>(); 
                    
                    while (start)
                    {
                        if (process.HasExited) start=false;
                        Sample sample = new Sample();
                        long ws = process.WorkingSet64;
                        long ms = process.PrivateMemorySize64;
                        int hc = process.HandleCount;
                        double cpu_use = GetCpuUsageForProcess(process);        
                        this.Invoke(new Action(() =>
                        {
                            textBoxID.Text = cpu_use.ToString("F");
                            textBoxWset.Text = ws.ToString();
                            textBoxPrivateBytes.Text = ms.ToString();
                            textBoxHandles.Text = hc.ToString();
                            toolStripStatusLabel1.Text = "Monitor";
                         }));                                  
                         sample.procId = id;
                         sample.cpuUse = cpu_use;        
                         sample.workingSet = ws;
                         sample.privateBytes = ms;
                         sample.handleCount = hc;
                         sample.dateTime = DateTime.UtcNow;
                         samples.Add(sample);                        
                         if(checkBoxBeep.Checked) Console.Beep();
                         Thread.Sleep(interval_msec);
                         this.Invoke(new Action(()=> 
                         {
                             toolStripStatusLabel1.Text = "";
                         }));
                    }
        
                    using (StreamWriter sw = new StreamWriter("log.json"))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, samples);
                    }
                    if (!process.HasExited) process.Kill();

                }).Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private double GetCpuUsageForProcess(Process process) 
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan startCpuUsage = process.TotalProcessorTime;
            Thread.Sleep(250);
            DateTime endTime = DateTime.UtcNow;
            TimeSpan endCpuUsage = process.TotalProcessorTime;
            Double cpuUsedMs = (endCpuUsage - startCpuUsage).TotalMilliseconds;
            Double totalMsPassed = (endTime - startTime).TotalMilliseconds;
            Double cpuUsageTotal = cpuUsedMs / (Environment.ProcessorCount * totalMsPassed);
            return cpuUsageTotal * 100;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
             try
            {
            if(openFileDialog1.ShowDialog()==DialogResult.Cancel) return;
            textBoxProcess.Text = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error"); ;
            }
        }

        private void viewLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string text = File.ReadAllText("log.json");               
                ViewLog view = new ViewLog(text);                
                view.Show();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
