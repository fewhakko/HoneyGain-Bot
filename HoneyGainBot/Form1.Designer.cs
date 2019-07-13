namespace HoneyGainBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(129, 443);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 43);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "START";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(55, 5);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(269, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "you@gmail.com";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "EMAIL";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "PASS";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(55, 44);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '*';
            this.metroTextBox2.Size = new System.Drawing.Size(269, 23);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.Text = "PasswordEIEIza";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 140);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(324, 73);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(20, 68);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(324, 59);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "PATCH";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.numericUpDown2);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.numericUpDown1);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(16, 304);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(324, 79);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(293, 45);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(26, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "GB";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown2.Location = new System.Drawing.Point(105, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown2.Size = new System.Drawing.Size(184, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 45);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "TRAFIC-LIMIT : ";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(71, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(253, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "THREAD : ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "0.00 GB";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroToggle1);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroTextBox3);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(16, 222);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(324, 73);
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(179, 45);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 7;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(181, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "ออโต้หยุดตอนครบ Limit-Trafic : ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(93, 5);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(231, 23);
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.Text = resources.GetString("metroTextBox3.Text");
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 5);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Authorization";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(391, 386);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "TRAFIC-LIMIT : ";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(129, 443);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(108, 43);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "STOP";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 180000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(381, 426);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(0, 0);
            this.metroLabel9.TabIndex = 15;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 498);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "HonnyGain-Bot";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

