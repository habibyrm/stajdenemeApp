namespace stajdenemeApp
{
    partial class Form_kisisorgulama
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
            dataGridView1 = new DataGridView();
            txtTC = new TextBox();
            label1 = new Label();
            button2 = new Button();
            txtad = new TextBox();
            txtmedenihalkodu = new TextBox();
            txtsoyad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btntemizle = new Button();
            btnonceki = new Button();
            btnsonraki = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtbsn = new TextBox();
            txtdurum = new TextBox();
            txtasn = new TextBox();
            label11 = new Label();
            label15 = new Label();
            txtannetc = new TextBox();
            label14 = new Label();
            txtbabaad = new TextBox();
            label7 = new Label();
            label12 = new Label();
            txtbabatc = new TextBox();
            txtannead = new TextBox();
            txtmedenihal = new TextBox();
            txtdurumkodu = new TextBox();
            label6 = new Label();
            label13 = new Label();
            grupailebilgileri = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grupailebilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(326, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(431, 395);
            dataGridView1.TabIndex = 0;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(22, 24);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(150, 23);
            txtTC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 6);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "TC Kimlik No:";
            // 
            // button2
            // 
            button2.Location = new Point(199, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Sorgula";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtad
            // 
            txtad.Enabled = false;
            txtad.Location = new Point(19, 67);
            txtad.Name = "txtad";
            txtad.Size = new Size(100, 23);
            txtad.TabIndex = 5;
            // 
            // txtmedenihalkodu
            // 
            txtmedenihalkodu.Enabled = false;
            txtmedenihalkodu.Location = new Point(19, 159);
            txtmedenihalkodu.Name = "txtmedenihalkodu";
            txtmedenihalkodu.Size = new Size(24, 23);
            txtmedenihalkodu.TabIndex = 6;
            // 
            // txtsoyad
            // 
            txtsoyad.Enabled = false;
            txtsoyad.Location = new Point(125, 67);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(100, 23);
            txtsoyad.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 8;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 49);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 10;
            label4.Text = "Medeni Hali:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 8);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Olaylar";
            // 
            // btntemizle
            // 
            btntemizle.Location = new Point(326, 427);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(84, 30);
            btntemizle.TabIndex = 12;
            btntemizle.Text = "Yeni Sorgu";
            btntemizle.UseVisualStyleBackColor = true;
            //btntemizle.Click += btn;
            // 
            // btnonceki
            // 
            btnonceki.FlatStyle = FlatStyle.Popup;
            btnonceki.Image = Properties.Resources._9110920_circle_arrow_left_icon;
            btnonceki.Location = new Point(26, 399);
            btnonceki.Name = "btnonceki";
            btnonceki.Size = new Size(54, 48);
            btnonceki.TabIndex = 13;
            btnonceki.UseVisualStyleBackColor = true;
            btnonceki.Click += btnonceki_Click;
            // 
            // btnsonraki
            // 
            btnsonraki.FlatStyle = FlatStyle.Popup;
            btnsonraki.ForeColor = SystemColors.ControlText;
            btnsonraki.Image = Properties.Resources._9111056_circle_arrow_right_icon;
            btnsonraki.ImageAlign = ContentAlignment.MiddleLeft;
            btnsonraki.Location = new Point(86, 399);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(62, 48);
            btnsonraki.TabIndex = 14;
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 197);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 22;
            label8.Text = "Durumu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 93);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 21;
            label9.Text = "Birey No:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 93);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 20;
            label10.Text = "Aile No:";
            // 
            // txtbsn
            // 
            txtbsn.Enabled = false;
            txtbsn.Location = new Point(74, 111);
            txtbsn.Name = "txtbsn";
            txtbsn.Size = new Size(33, 23);
            txtbsn.TabIndex = 19;
            // 
            // txtdurum
            // 
            txtdurum.Enabled = false;
            txtdurum.Location = new Point(47, 215);
            txtdurum.Name = "txtdurum";
            txtdurum.Size = new Size(100, 23);
            txtdurum.TabIndex = 18;
            // 
            // txtasn
            // 
            txtasn.Enabled = false;
            txtasn.Location = new Point(22, 111);
            txtasn.Name = "txtasn";
            txtasn.Size = new Size(33, 23);
            txtasn.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 114);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 25;
            label11.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 99);
            label15.Name = "label15";
            label15.Size = new Size(25, 15);
            label15.TabIndex = 42;
            label15.Text = "Ad:";
            // 
            // txtannetc
            // 
            txtannetc.Enabled = false;
            txtannetc.Location = new Point(69, 51);
            txtannetc.Name = "txtannetc";
            txtannetc.Size = new Size(100, 23);
            txtannetc.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1, 51);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 41;
            label14.Text = "Kimlik No:";
            // 
            // txtbabaad
            // 
            txtbabaad.Enabled = false;
            txtbabaad.Location = new Point(172, 99);
            txtbabaad.Name = "txtbabaad";
            txtbabaad.Size = new Size(100, 23);
            txtbabaad.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 33);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 37;
            label7.Text = "Anne";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(175, 33);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 40;
            label12.Text = "Baba";
            // 
            // txtbabatc
            // 
            txtbabatc.Enabled = false;
            txtbabatc.Location = new Point(175, 51);
            txtbabatc.Name = "txtbabatc";
            txtbabatc.Size = new Size(100, 23);
            txtbabatc.TabIndex = 39;
            // 
            // txtannead
            // 
            txtannead.Enabled = false;
            txtannead.Location = new Point(66, 99);
            txtannead.Name = "txtannead";
            txtannead.Size = new Size(100, 23);
            txtannead.TabIndex = 35;
            // 
            // txtmedenihal
            // 
            txtmedenihal.Enabled = false;
            txtmedenihal.Location = new Point(47, 159);
            txtmedenihal.Name = "txtmedenihal";
            txtmedenihal.Size = new Size(100, 23);
            txtmedenihal.TabIndex = 31;
            // 
            // txtdurumkodu
            // 
            txtdurumkodu.Enabled = false;
            txtdurumkodu.Location = new Point(19, 215);
            txtdurumkodu.Name = "txtdurumkodu";
            txtdurumkodu.Size = new Size(24, 23);
            txtdurumkodu.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 450);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 33;
            label6.Text = "Önceki";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(86, 450);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 34;
            label13.Text = "Sonraki";
            // 
            // grupailebilgileri
            // 
            grupailebilgileri.Controls.Add(txtannetc);
            grupailebilgileri.Controls.Add(txtannead);
            grupailebilgileri.Controls.Add(label15);
            grupailebilgileri.Controls.Add(txtbabatc);
            grupailebilgileri.Controls.Add(label12);
            grupailebilgileri.Controls.Add(label7);
            grupailebilgileri.Controls.Add(txtbabaad);
            grupailebilgileri.Controls.Add(label14);
            grupailebilgileri.Location = new Point(12, 244);
            grupailebilgileri.Name = "grupailebilgileri";
            grupailebilgileri.Size = new Size(308, 133);
            grupailebilgileri.TabIndex = 44;
            grupailebilgileri.TabStop = false;
            grupailebilgileri.Text = "Aile Bilgileri";
            // 
            // Form_kisisorgulama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 469);
            Controls.Add(grupailebilgileri);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(txtdurumkodu);
            Controls.Add(txtmedenihal);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtbsn);
            Controls.Add(txtdurum);
            Controls.Add(txtasn);
            Controls.Add(btnsonraki);
            Controls.Add(btnonceki);
            Controls.Add(btntemizle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtsoyad);
            Controls.Add(txtmedenihalkodu);
            Controls.Add(txtad);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtTC);
            Controls.Add(dataGridView1);
            Name = "Form_kisisorgulama";
            Text = "Kişi Sorgulama";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grupailebilgileri.ResumeLayout(false);
            grupailebilgileri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTC;
        private Label label1;
        private Button button2;
        private TextBox txtad;
        private TextBox txtmedenihalkodu;
        private TextBox txtsoyad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btntemizle;
        private Button btnonceki;
        private Button btnsonraki;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtbsn;
        private TextBox txtdurum;
        private TextBox txtasn;
        private Label label11;
        private TextBox txtmedenihal;
        private TextBox txtdurumkodu;
        private Label label6;
        private Label label13;
        private Label label15;
        private TextBox txtannetc;
        private Label label14;
        private TextBox txtbabaad;
        private Label label7;
        private Label label12;
        private TextBox txtbabatc;
        private TextBox txtannead;
        private GroupBox grupailebilgileri;
    }
}