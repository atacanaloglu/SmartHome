
namespace AkilliEvAtacan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnServo = new System.Windows.Forms.Button();
            this.btnFan = new System.Windows.Forms.Button();
            this.btnAydinlatma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblYagmur = new System.Windows.Forms.Label();
            this.lblLDR = new System.Windows.Forms.Label();
            this.lblSicaklik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKapi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.lblPencere = new System.Windows.Forms.Label();
            this.lblAmpul = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnAlarm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yağmur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pencere: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ampul:";
            // 
            // btnServo
            // 
            this.btnServo.BackColor = System.Drawing.Color.Thistle;
            this.btnServo.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServo.Location = new System.Drawing.Point(222, 29);
            this.btnServo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServo.Name = "btnServo";
            this.btnServo.Size = new System.Drawing.Size(265, 29);
            this.btnServo.TabIndex = 6;
            this.btnServo.Text = "PENCERE AÇ / KAPA";
            this.btnServo.UseVisualStyleBackColor = false;
            this.btnServo.Click += new System.EventHandler(this.btnServo_Click);
            // 
            // btnFan
            // 
            this.btnFan.BackColor = System.Drawing.Color.Thistle;
            this.btnFan.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFan.Location = new System.Drawing.Point(222, 97);
            this.btnFan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(265, 29);
            this.btnFan.TabIndex = 8;
            this.btnFan.Text = "PERVANE HIZI DEĞİŞTİR";
            this.btnFan.UseVisualStyleBackColor = false;
            this.btnFan.Click += new System.EventHandler(this.btnFan_Click);
            // 
            // btnAydinlatma
            // 
            this.btnAydinlatma.BackColor = System.Drawing.Color.Thistle;
            this.btnAydinlatma.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAydinlatma.Location = new System.Drawing.Point(222, 131);
            this.btnAydinlatma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAydinlatma.Name = "btnAydinlatma";
            this.btnAydinlatma.Size = new System.Drawing.Size(265, 29);
            this.btnAydinlatma.TabIndex = 9;
            this.btnAydinlatma.Text = "AYDINLATMA ŞİDDETİNİ DEĞİŞTİR";
            this.btnAydinlatma.UseVisualStyleBackColor = false;
            this.btnAydinlatma.Click += new System.EventHandler(this.btnAydinlatma_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblYagmur);
            this.groupBox1.Controls.Add(this.lblLDR);
            this.groupBox1.Controls.Add(this.lblSicaklik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(204, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hava Durumu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblYagmur
            // 
            this.lblYagmur.AutoSize = true;
            this.lblYagmur.Location = new System.Drawing.Point(71, 74);
            this.lblYagmur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYagmur.Name = "lblYagmur";
            this.lblYagmur.Size = new System.Drawing.Size(15, 17);
            this.lblYagmur.TabIndex = 6;
            this.lblYagmur.Text = "0";
            // 
            // lblLDR
            // 
            this.lblLDR.AutoSize = true;
            this.lblLDR.Location = new System.Drawing.Point(71, 48);
            this.lblLDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLDR.Name = "lblLDR";
            this.lblLDR.Size = new System.Drawing.Size(15, 17);
            this.lblLDR.TabIndex = 5;
            this.lblLDR.Text = "0";
            // 
            // lblSicaklik
            // 
            this.lblSicaklik.AutoSize = true;
            this.lblSicaklik.Location = new System.Drawing.Point(71, 22);
            this.lblSicaklik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSicaklik.Name = "lblSicaklik";
            this.lblSicaklik.Size = new System.Drawing.Size(15, 17);
            this.lblSicaklik.TabIndex = 4;
            this.lblSicaklik.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıcaklık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Işık";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblKapi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAlarm);
            this.groupBox2.Controls.Add(this.lblFan);
            this.groupBox2.Controls.Add(this.lblPencere);
            this.groupBox2.Controls.Add(this.lblAmpul);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Location = new System.Drawing.Point(13, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(204, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ev Durumu:";
            // 
            // lblKapi
            // 
            this.lblKapi.AutoSize = true;
            this.lblKapi.Location = new System.Drawing.Point(71, 127);
            this.lblKapi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKapi.Name = "lblKapi";
            this.lblKapi.Size = new System.Drawing.Size(15, 17);
            this.lblKapi.TabIndex = 12;
            this.lblKapi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pencere:";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(71, 102);
            this.lblAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(15, 17);
            this.lblAlarm.TabIndex = 10;
            this.lblAlarm.Text = "0";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Location = new System.Drawing.Point(71, 76);
            this.lblFan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(15, 17);
            this.lblFan.TabIndex = 9;
            this.lblFan.Text = "0";
            // 
            // lblPencere
            // 
            this.lblPencere.AutoSize = true;
            this.lblPencere.Location = new System.Drawing.Point(71, 50);
            this.lblPencere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPencere.Name = "lblPencere";
            this.lblPencere.Size = new System.Drawing.Size(15, 17);
            this.lblPencere.TabIndex = 8;
            this.lblPencere.Text = "0";
            // 
            // lblAmpul
            // 
            this.lblAmpul.AutoSize = true;
            this.lblAmpul.Location = new System.Drawing.Point(71, 24);
            this.lblAmpul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmpul.Name = "lblAmpul";
            this.lblAmpul.Size = new System.Drawing.Size(15, 17);
            this.lblAmpul.TabIndex = 7;
            this.lblAmpul.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Alarm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Fan:";
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaglan.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(323, 164);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(102, 29);
            this.btnBaglan.TabIndex = 12;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(221, 167);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(98, 25);
            this.cmbPort.TabIndex = 13;
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.Thistle;
            this.btnAlarm.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarm.Location = new System.Drawing.Point(222, 63);
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(265, 29);
            this.btnAlarm.TabIndex = 14;
            this.btnAlarm.Text = "ALARM SİSTEMİ AÇ/KAPA";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AkilliEvAtacan.Properties.Resources.arkaplan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAlarm);
            this.panel1.Controls.Add(this.btnServo);
            this.panel1.Controls.Add(this.cmbPort);
            this.panel1.Controls.Add(this.btnFan);
            this.panel1.Controls.Add(this.btnBaglan);
            this.panel1.Controls.Add(this.btnAydinlatma);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 307);
            this.panel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnServo;
        private System.Windows.Forms.Button btnFan;
        private System.Windows.Forms.Button btnAydinlatma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblYagmur;
        private System.Windows.Forms.Label lblLDR;
        private System.Windows.Forms.Label lblSicaklik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.Label lblPencere;
        private System.Windows.Forms.Label lblAmpul;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKapi;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Panel panel1;
    }
}

