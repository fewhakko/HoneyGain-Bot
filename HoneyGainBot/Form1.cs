using HoneyGainBot.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoneyGainBot
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int moxz;

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroButton2.Visible = false;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                this.metroLabel9.Text = openFileDialog.FileName;
                MessageBox.Show("ท่านได้ทำการเลิอกที่อยู่ไฟล์แล้ว", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                metroButton1.Enabled = false;
                if (metroLabel9.Text == "")
                {
                    MessageBox.Show("คุณยังไม่ได้กรอกที่อยู่ไฟล์ patch", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);  //metroTextBox2
                }
                else
                {
                    if (metroTextBox1.Text == "" || metroTextBox2.Text == "")
                    {
                        metroButton1.Enabled = true;
                        MessageBox.Show("คุณยังไม่ได้กรอกอีเมลหรือรหัสผ่าน", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);  //metroTextBox2
                    }
                    else
                    {
                        WebClient wc = new WebClient();

                        metroTextBox1.Enabled = false;
                        metroTextBox2.Enabled = false;
                        metroTextBox3.Enabled = false;
                        numericUpDown1.Enabled = false;
                        numericUpDown2.Enabled = false;

                        File.Delete($@"HoneygainLogin.ini");
                        using (StreamWriter streamWriter = File.AppendText($@"HoneygainLogin.ini"))
                        {
                            streamWriter.WriteLine("[EMAIL]");
                            streamWriter.WriteLine(metroTextBox1.Text);
                            streamWriter.WriteLine("[PASSWORD]");
                            streamWriter.WriteLine(metroTextBox2.Text);
                        }
                        int i = 0;
                        int za = Convert.ToInt32(numericUpDown1.Value);
                        timer1.Start();
                        timer2.Start();

                        File.WriteAllBytes($@"{this.metroLabel9.Text}", Resources.Honeygain);
          
                        while (i < za)
                        {
                            System.Diagnostics.Process.Start($@"{this.metroLabel9.Text}");
                            i++;
                            System.Threading.Thread.Sleep(60);
                        }
                        backgroundWorker2.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                metroButton1.Enabled = true;
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();

                if (metroTextBox3.Text == "")
                {
                    timer1.Stop();
                    MessageBox.Show("คุณยังไม่ได้กรอก Authorization", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);  //metroTextBox2
                }
                else
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            metroButton2.Enabled = false;
            timer1.Stop();
            foreach (var process in Process.GetProcessesByName("Honeygain"))
            {
                process.Kill();
            }

            metroTextBox1.Enabled = true;
            metroTextBox2.Enabled = true;
            metroTextBox3.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;

            metroButton2.Visible = false;
            metroButton2.Enabled = true;
            metroButton1.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc = new WebClient();

            wc.Headers.Add("Authorization", "Bearer " + metroTextBox3.Text);

            var val = wc.DownloadString("https://dashboard.honeygain.com/api/v1/users/balances");

            string test;

            RootObject w = JsonConvert.DeserializeObject<RootObject>(val);
            int totaldate = Convert.ToInt32(w.data.realtime.credits);

            moxz = totaldate;

            if (totaldate.ToString().Length == 1)
            {
                string trafic = "0.0" + totaldate.ToString().Substring(0) + " GB";
                test = trafic;
            }
            else if (totaldate.ToString().Length == 2)
            {
                string trafic = "0." + totaldate.ToString().Substring(0) + " GB";
                test = trafic;
            }
            else if (totaldate.ToString().Length == 3)
            {
                string trafic = totaldate.ToString().Substring(0, 1) + "." + totaldate.ToString().Substring(1, 2) + " GB";
                test = trafic;
            }
            else if (totaldate.ToString().Length == 4)
            {
                string trafic = totaldate.ToString().Substring(0, 2) + "." + totaldate.ToString().Substring(2, 2) + " GB";
                test = trafic;
            }
            else if (totaldate.ToString().Length == 5)
            {
                string trafic = totaldate.ToString().Substring(0, 3) + "." + totaldate.ToString().Substring(3, 2) + " GB";
                test = trafic;
            }
            else if (totaldate.ToString().Length == 6)
            {
                string trafic = totaldate.ToString().Substring(0, 4) + "." + totaldate.ToString().Substring(4, 2) + " GB";
                test = trafic;
            }
            else
            {
                string trafic = "0.00 GB";
                test = trafic;
            }

            int za = Convert.ToInt32(numericUpDown2.Value);
            int kun = za * 100;

            if (totaldate > kun)
            {
                if (metroToggle1.Text == "On")
                {
                    foreach (var process in Process.GetProcessesByName("Honeygain"))
                    {
                        process.Kill();
                    }
                    timer1.Stop();
                    metroButton2.Visible = false;
                    metroButton2.Enabled = true;
                    metroButton1.Visible = true;
                }
                else if (metroToggle1.Text == "Off")
                {
                    foreach (var process in Process.GetProcessesByName("Honeygain"))
                    {
                        process.Kill();
                    }
                }
            }
            else if (totaldate < kun)
            {

            }
            label1.Text = test;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (moxz.ToString() == "0")
            {
                backgroundWorker3.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
            File.Delete($@"HoneygainLogin.ini");
            metroButton1.Enabled = true;
            metroButton1.Visible = false;
            metroButton2.Visible = true;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            int xxxxzz = Convert.ToInt32(numericUpDown1.Value);
            using (StreamWriter streamWriter = File.AppendText($@"HoneygainLogin.ini"))
            {
                streamWriter.WriteLine("[EMAIL]");
                streamWriter.WriteLine(metroTextBox1.Text);
                streamWriter.WriteLine("[PASSWORD]");
                streamWriter.WriteLine(metroTextBox2.Text);
            }
            while (i < xxxxzz)
            {
                System.Diagnostics.Process.Start($@"{this.metroLabel9.Text}");
                i++;
                System.Threading.Thread.Sleep(60);
            }
            System.Threading.Thread.Sleep(20000);
            File.Delete($@"HoneygainLogin.ini");
        }
    }
}
