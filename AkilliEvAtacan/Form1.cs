using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace AkilliEvAtacan
{
    public partial class Form1 : Form
    {
        string[] ports = { };

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataRecieved);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbPort.Items.Add(port);
            }
        }

        public int yagmurbilgi = 0;
        public int alarmbilgi = 0;
        public int ldrbilgi = 0;
        public int sicaklikbilgi = 0;

        private void SerialPort1_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(30);

                string data = serialPort1.ReadLine();       // bufferdan verileri oku

                if (data.Contains("ldr"))
                {
                    var kelimeler = data.Split('-');
                    if (kelimeler[1].ToString().Contains("1"))
                    {
                        if (lblLDR.InvokeRequired)
                        {
                            lblLDR.Invoke(new MethodInvoker(delegate { lblLDR.Text = "Aydınlık"; }));
                        }
                        else
                        {
                            lblLDR.Text = "Aydınlık";
                        }
                        ldrbilgi = 0;
                    }
                    else if (kelimeler[1].ToString().Contains("0"))
                    {
                        if (lblLDR.InvokeRequired)
                        {
                            lblLDR.Invoke(new MethodInvoker(delegate { lblLDR.Text = "Karanlık"; }));
                        }
                        else
                        {
                            lblLDR.Text = "Karanlık";
                        }

                        if (lblAmpul.Text == "0" && ldrbilgi == 0)
                        {
                            ldrbilgi = 1;
                            DialogResult dialogResult = MessageBox.Show("Hava karanlık!!!\nAydınlatma orta şiddette açılsın mı???", "Hava Karardı!!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                serialPort1.Write("ampul66");
                                if (lblAmpul.InvokeRequired)
                                {
                                    lblAmpul.Invoke(new MethodInvoker(delegate { lblAmpul.Text = "66"; }));
                                }
                                else
                                {
                                    lblAmpul.Text = "66";
                                }
                            }
                        }

                    }
                }

                if (data.Contains("yagmur"))
                {
                    var kelimeler = data.Split('-');
                    if (kelimeler[1].ToString().Contains("1"))
                    {
                        if (lblYagmur.InvokeRequired)
                        {
                            lblYagmur.Invoke(new MethodInvoker(delegate { lblYagmur.Text = "Yağış var"; }));
                        }
                        else
                        {
                            lblYagmur.Text = "Yağış var";
                        }
                        if (lblKapi.Text == "Açık" && yagmurbilgi == 0)
                        {
                            yagmurbilgi = 1;
                            DialogResult dialogResult = MessageBox.Show("Yağmur yağıyor!!!\nPencere kapatılsın mı?????", "Yağış Başladı!!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                serialPort1.Write("kapi0");
                                if (lblKapi.InvokeRequired)
                                {
                                    lblKapi.Invoke(new MethodInvoker(delegate { lblKapi.Text = "Kapalı"; }));
                                }
                                else
                                {
                                    lblKapi.Text = "Kapalı";
                                }
                            }
                        }
                    }
                    else if (kelimeler[1].ToString().Contains("0"))
                    {
                        yagmurbilgi = 0;
                        if (lblYagmur.InvokeRequired)
                        {
                            lblYagmur.Invoke(new MethodInvoker(delegate { lblYagmur.Text = "Yağış yok"; }));
                        }
                        else
                        {
                            lblYagmur.Text = "Yağış yok";
                        }
                    }
                }

                if (data.Contains("sicaklik"))
                {
                    var kelimeler = data.Split('-');
                    string sicakstr = kelimeler[1].ToString();
                    string sicakstr2 = sicakstr.Substring(0,sicakstr.Length - 3);
                    int sicaklik = int.Parse(sicakstr2);
                    if (sicaklik > 20)
                    {
                        if (sicaklikbilgi == 0)
                        {
                            sicaklikbilgi = 1;
                            DialogResult dialogResult = MessageBox.Show("Sıcaklık oldukça arttı!!!\nFan açılsın mı??????", "Sıcaklık arttı!!!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                serialPort1.Write("fan1");
                                if (lblFan.InvokeRequired)
                                {
                                    lblFan.Invoke(new MethodInvoker(delegate { lblFan.Text = "Açık"; }));
                                }
                                else
                                {
                                    lblFan.Text = "Açık";
                                }
                            }
                        }
                    }
                    else
                    {
                        sicaklikbilgi = 0;
                    }

                    if (lblSicaklik.InvokeRequired)
                    {
                        lblSicaklik.Invoke(new MethodInvoker(delegate { lblSicaklik.Text = kelimeler[1].ToString(); }));
                    }
                    else
                    {
                        lblSicaklik.Text = kelimeler[1].ToString();
                    }
                }



                if (data.Contains("pir"))
                {
                    var kelimeler = data.Split('-');
                    if (kelimeler[1].ToString().Contains("1") && lblAlarm.Text == "Açık")
                    {
                        if (alarmbilgi == 0)
                        {
                            serialPort1.Write("buzzer1");
                            alarmbilgi = 1;
                            DialogResult dialogResult = MessageBox.Show("Eve izinsiz giren bir mahlukat tespit edildi!!!\nAlarm Susturulsun mu????????", "İzinsiz Giriş!!!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                serialPort1.Write("buzzer0");
                                alarmbilgi = 1;
                            }
                        }
                    }
                    else if (kelimeler[1].ToString().Contains("0"))
                    {
                        alarmbilgi = 0;
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Seri porttan veri okunurken hata oluştu!!","HATA");
            }
        }


        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBaglan.Text == "Bağlan")
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.BaudRate = 9600;
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                    }
                    serialPort1.Write("reset");
                    btnBaglan.Text = "Bağlantıyı Kes";
                    lblAlarm.Text = "Kapalı";
                    lblSicaklik.Text = "0";
                    lblPencere.Text = "Kapalı";
                    lblAmpul.Text = "0";
                    lblLDR.Text = "Karanlık";
                    lblFan.Text = "Kapalı";
                    lblKapi.Text = "Kapalı";
                    lblYagmur.Text = "Yağış yok";
                }
                else
                {
                    btnBaglan.Text = "Bağlan";
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı Hatası");
            }
        }

        private void btnServo_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    if (lblKapi.Text == "Açık")
                    {
                        serialPort1.Write("kapi0");
                        lblKapi.Text = "Kapalı";
                    }
                    else
                    {
                        serialPort1.Write("kapi90");
                        lblKapi.Text = "Açık";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu!!", "HATA");
            }
}
        private void btnAlarmSustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    if (lblAlarm.Text == "Açık")
                    {
                        serialPort1.Write("buzzer0");
                        lblAlarm.Text = "Kapalı";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu!!", "HATA");
            }
        }
        private void btnFan_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    if (lblFan.Text == "Açık")
                    {
                        serialPort1.Write("fan0");
                        lblFan.Text = "Kapalı";
                    }
                    else
                    {
                        serialPort1.Write("fan1");
                        lblFan.Text = "Açık";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu!!", "HATA");
            }
        }

        private void btnAydinlatma_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    if (lblAmpul.Text == "0")
                    {
                        serialPort1.Write("ampul33");
                        lblAmpul.Text = "33";
                    }
                    else if (lblAmpul.Text == "33")
                    {
                        serialPort1.Write("ampul66");
                        lblAmpul.Text = "66";
                    }
                    else if (lblAmpul.Text == "66")
                    {
                        serialPort1.Write("ampul100");
                        lblAmpul.Text = "100";
                    }
                    else
                    {
                        serialPort1.Write("ampul0");
                        lblAmpul.Text = "0";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu!!", "HATA");
            }
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAlarm.Text == "Açık")
                {
                    serialPort1.Write("buzzer0");
                    lblAlarm.Text = "Kapalı";
                }
                else
                {
                    lblAlarm.Text = "Açık";
                }
            }
            catch
            {
                MessageBox.Show("Seri porttan veri okunurken hata oluştu!!", "HATA");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu!!","HATA");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
