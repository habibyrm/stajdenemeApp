namespace stajdenemeApp
{
    partial class Form_Dogum
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
            label1 = new Label();
            txtannetc = new TextBox();
            txtannead = new TextBox();
            label4 = new Label();
            txtbabad = new TextBox();
            label5 = new Label();
            txtbabatc = new TextBox();
            label8 = new Label();
            txtsoyad = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtsaat = new TextBox();
            label11 = new Label();
            txtcocukad = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtgun = new TextBox();
            label14 = new Label();
            btndogur = new Button();
            txtcocuktc = new TextBox();
            label15 = new Label();
            grup_cocuk = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            txtyil = new TextBox();
            txtay = new TextBox();
            txtdakika = new TextBox();
            comboBoxsehir = new ComboBox();
            comboBoxcinsiyet = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtannebsn = new TextBox();
            txtanneasn = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            txtbababsn = new TextBox();
            txtbabasn = new TextBox();
            grupannebilgileri = new GroupBox();
            btnannesorgula = new Button();
            grupbababilgileri = new GroupBox();
            btnbabasorgula = new Button();
            btnes = new Button();
            grupaile = new GroupBox();
            btnclear = new Button();
            grup_cocuk.SuspendLayout();
            grupannebilgileri.SuspendLayout();
            grupbababilgileri.SuspendLayout();
            grupaile.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Anne T.C.:";
            // 
            // txtannetc
            // 
            txtannetc.Location = new Point(19, 40);
            txtannetc.MaxLength = 11;
            txtannetc.Name = "txtannetc";
            txtannetc.Size = new Size(100, 23);
            txtannetc.TabIndex = 1;
            txtannetc.TextChanged += txtTC_TextChanged;
            txtannetc.KeyPress += txtTC_KeyPress;
            // 
            // txtannead
            // 
            txtannead.BackColor = SystemColors.ControlLightLight;
            txtannead.Enabled = false;
            txtannead.ForeColor = SystemColors.ControlText;
            txtannead.Location = new Point(19, 99);
            txtannead.Name = "txtannead";
            txtannead.Size = new Size(100, 23);
            txtannead.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 81);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Anne Adı:";
            // 
            // txtbabad
            // 
            txtbabad.BackColor = SystemColors.ControlLightLight;
            txtbabad.Enabled = false;
            txtbabad.ForeColor = SystemColors.ControlText;
            txtbabad.Location = new Point(6, 97);
            txtbabad.Name = "txtbabad";
            txtbabad.Size = new Size(100, 23);
            txtbabad.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 79);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Baba Adı:";
            // 
            // txtbabatc
            // 
            txtbabatc.Location = new Point(6, 38);
            txtbabatc.MaxLength = 11;
            txtbabatc.Name = "txtbabatc";
            txtbabatc.Size = new Size(100, 23);
            txtbabatc.TabIndex = 16;
            txtbabatc.TextChanged += txtTC_TextChanged;
            txtbabatc.KeyPress += txtTC_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 15;
            label8.Text = "Baba T.C.:";
            // 
            // txtsoyad
            // 
            txtsoyad.BackColor = SystemColors.ControlLightLight;
            txtsoyad.Enabled = false;
            txtsoyad.ForeColor = SystemColors.ControlText;
            txtsoyad.Location = new Point(133, 33);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(100, 23);
            txtsoyad.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 15);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 27;
            label9.Text = "Soyad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(134, 68);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 25;
            label10.Text = "Doğum Yeri:";
            // 
            // txtsaat
            // 
            txtsaat.Location = new Point(9, 187);
            txtsaat.MaxLength = 2;
            txtsaat.Name = "txtsaat";
            txtsaat.Size = new Size(22, 23);
            txtsaat.TabIndex = 24;
            txtsaat.KeyPress += txtTC_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 169);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 23;
            label11.Text = "Doğum Saati:";
            // 
            // txtcocukad
            // 
            txtcocukad.Location = new Point(6, 33);
            txtcocukad.Name = "txtcocukad";
            txtcocukad.Size = new Size(100, 23);
            txtcocukad.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 15);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 21;
            label12.Text = "Ad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 67);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 19;
            label13.Text = "Cinsiyet:";
            // 
            // txtgun
            // 
            txtgun.Location = new Point(6, 141);
            txtgun.MaxLength = 2;
            txtgun.Name = "txtgun";
            txtgun.Size = new Size(25, 23);
            txtgun.TabIndex = 18;
            txtgun.KeyPress += txtTC_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 124);
            label14.Name = "label14";
            label14.Size = new Size(81, 15);
            label14.TabIndex = 17;
            label14.Text = " DoğumTarihi:";
            // 
            // btndogur
            // 
            btndogur.Location = new Point(604, 315);
            btndogur.Name = "btndogur";
            btndogur.Size = new Size(135, 31);
            btndogur.TabIndex = 29;
            btndogur.Text = "Doğum Yap";
            btndogur.UseVisualStyleBackColor = true;
            btndogur.Click += btndogur_Click;
            btndogur.MouseClick += buttonValidate_Click;
            // 
            // txtcocuktc
            // 
            txtcocuktc.BackColor = SystemColors.ControlLightLight;
            txtcocuktc.Enabled = false;
            txtcocuktc.Location = new Point(450, 27);
            txtcocuktc.Name = "txtcocuktc";
            txtcocuktc.Size = new Size(100, 23);
            txtcocuktc.TabIndex = 31;
            txtcocuktc.Text = " ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(450, 9);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 30;
            label15.Text = "Çocuk T.C.";
            // 
            // grup_cocuk
            // 
            grup_cocuk.Controls.Add(label24);
            grup_cocuk.Controls.Add(label23);
            grup_cocuk.Controls.Add(label22);
            grup_cocuk.Controls.Add(txtyil);
            grup_cocuk.Controls.Add(txtay);
            grup_cocuk.Controls.Add(txtdakika);
            grup_cocuk.Controls.Add(comboBoxsehir);
            grup_cocuk.Controls.Add(txtcocukad);
            grup_cocuk.Controls.Add(txtsaat);
            grup_cocuk.Controls.Add(label11);
            grup_cocuk.Controls.Add(label14);
            grup_cocuk.Controls.Add(txtgun);
            grup_cocuk.Controls.Add(label13);
            grup_cocuk.Controls.Add(txtsoyad);
            grup_cocuk.Controls.Add(label9);
            grup_cocuk.Controls.Add(label12);
            grup_cocuk.Controls.Add(label10);
            grup_cocuk.Controls.Add(comboBoxcinsiyet);
            grup_cocuk.Location = new Point(450, 60);
            grup_cocuk.Name = "grup_cocuk";
            grup_cocuk.Size = new Size(289, 231);
            grup_cocuk.TabIndex = 32;
            grup_cocuk.TabStop = false;
            grup_cocuk.Text = "Çocuk Bilgileri";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(37, 190);
            label24.Name = "label24";
            label24.Size = new Size(12, 15);
            label24.TabIndex = 49;
            label24.Text = "/";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(76, 145);
            label23.Name = "label23";
            label23.Size = new Size(12, 15);
            label23.TabIndex = 49;
            label23.Text = "/";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(36, 145);
            label22.Name = "label22";
            label22.Size = new Size(12, 15);
            label22.TabIndex = 48;
            label22.Text = "/";
            // 
            // txtyil
            // 
            txtyil.Location = new Point(94, 141);
            txtyil.MaxLength = 4;
            txtyil.Name = "txtyil";
            txtyil.Size = new Size(41, 23);
            txtyil.TabIndex = 33;
            txtyil.KeyPress += txtTC_KeyPress;
            // 
            // txtay
            // 
            txtay.Location = new Point(54, 142);
            txtay.MaxLength = 2;
            txtay.Name = "txtay";
            txtay.Size = new Size(22, 23);
            txtay.TabIndex = 32;
            txtay.KeyPress += txtTC_KeyPress;
            // 
            // txtdakika
            // 
            txtdakika.Location = new Point(54, 187);
            txtdakika.MaxLength = 2;
            txtdakika.Name = "txtdakika";
            txtdakika.Size = new Size(22, 23);
            txtdakika.TabIndex = 31;
            txtdakika.KeyPress += txtTC_KeyPress;
            // 
            // comboBoxsehir
            // 
            comboBoxsehir.FormattingEnabled = true;
            comboBoxsehir.Items.AddRange(new object[] { "İstanbul", "Ankara", "Tokat", "Sakarya" });
            comboBoxsehir.Location = new Point(133, 85);
            comboBoxsehir.Name = "comboBoxsehir";
            comboBoxsehir.Size = new Size(100, 23);
            comboBoxsehir.TabIndex = 30;
            // 
            // comboBoxcinsiyet
            // 
            comboBoxcinsiyet.FormattingEnabled = true;
            comboBoxcinsiyet.Items.AddRange(new object[] { "1-Erkek", "2-Kadın" });
            comboBoxcinsiyet.Location = new Point(6, 85);
            comboBoxcinsiyet.Name = "comboBoxcinsiyet";
            comboBoxcinsiyet.Size = new Size(100, 23);
            comboBoxcinsiyet.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(55, 156);
            label16.Name = "label16";
            label16.Size = new Size(10, 15);
            label16.TabIndex = 37;
            label16.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(71, 135);
            label17.Name = "label17";
            label17.Size = new Size(55, 15);
            label17.TabIndex = 36;
            label17.Text = "Birey No:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 135);
            label18.Name = "label18";
            label18.Size = new Size(49, 15);
            label18.TabIndex = 35;
            label18.Text = "Aile No:";
            // 
            // txtannebsn
            // 
            txtannebsn.BackColor = SystemColors.ControlLightLight;
            txtannebsn.Enabled = false;
            txtannebsn.ForeColor = SystemColors.ControlText;
            txtannebsn.Location = new Point(71, 153);
            txtannebsn.Name = "txtannebsn";
            txtannebsn.Size = new Size(33, 23);
            txtannebsn.TabIndex = 34;
            // 
            // txtanneasn
            // 
            txtanneasn.BackColor = SystemColors.ControlLightLight;
            txtanneasn.Enabled = false;
            txtanneasn.ForeColor = SystemColors.ControlText;
            txtanneasn.Location = new Point(19, 153);
            txtanneasn.Name = "txtanneasn";
            txtanneasn.Size = new Size(33, 23);
            txtanneasn.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(42, 154);
            label19.Name = "label19";
            label19.Size = new Size(10, 15);
            label19.TabIndex = 42;
            label19.Text = ":";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(58, 133);
            label20.Name = "label20";
            label20.Size = new Size(55, 15);
            label20.TabIndex = 41;
            label20.Text = "Birey No:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 133);
            label21.Name = "label21";
            label21.Size = new Size(49, 15);
            label21.TabIndex = 40;
            label21.Text = "Aile No:";
            // 
            // txtbababsn
            // 
            txtbababsn.BackColor = SystemColors.ControlLightLight;
            txtbababsn.Enabled = false;
            txtbababsn.ForeColor = SystemColors.ControlText;
            txtbababsn.Location = new Point(58, 151);
            txtbababsn.Name = "txtbababsn";
            txtbababsn.Size = new Size(33, 23);
            txtbababsn.TabIndex = 39;
            // 
            // txtbabasn
            // 
            txtbabasn.BackColor = SystemColors.ControlLightLight;
            txtbabasn.Enabled = false;
            txtbabasn.ForeColor = SystemColors.ControlText;
            txtbabasn.Location = new Point(6, 151);
            txtbabasn.Name = "txtbabasn";
            txtbabasn.Size = new Size(33, 23);
            txtbabasn.TabIndex = 38;
            // 
            // grupannebilgileri
            // 
            grupannebilgileri.Controls.Add(btnannesorgula);
            grupannebilgileri.Controls.Add(txtannetc);
            grupannebilgileri.Controls.Add(label1);
            grupannebilgileri.Controls.Add(label4);
            grupannebilgileri.Controls.Add(txtannead);
            grupannebilgileri.Controls.Add(label16);
            grupannebilgileri.Controls.Add(label17);
            grupannebilgileri.Controls.Add(label18);
            grupannebilgileri.Controls.Add(txtanneasn);
            grupannebilgileri.Controls.Add(txtannebsn);
            grupannebilgileri.Location = new Point(14, 27);
            grupannebilgileri.Name = "grupannebilgileri";
            grupannebilgileri.Size = new Size(208, 181);
            grupannebilgileri.TabIndex = 47;
            grupannebilgileri.TabStop = false;
            grupannebilgileri.Text = "Anne Bilgileri";
            // 
            // btnannesorgula
            // 
            btnannesorgula.Location = new Point(129, 40);
            btnannesorgula.Name = "btnannesorgula";
            btnannesorgula.Size = new Size(75, 23);
            btnannesorgula.TabIndex = 48;
            btnannesorgula.Text = "Sorgula";
            btnannesorgula.UseVisualStyleBackColor = true;
            btnannesorgula.Click += btnannesorgula_Click;
            // 
            // grupbababilgileri
            // 
            grupbababilgileri.Controls.Add(btnbabasorgula);
            grupbababilgileri.Controls.Add(txtbabatc);
            grupbababilgileri.Controls.Add(label21);
            grupbababilgileri.Controls.Add(label20);
            grupbababilgileri.Controls.Add(txtbababsn);
            grupbababilgileri.Controls.Add(label5);
            grupbababilgileri.Controls.Add(label19);
            grupbababilgileri.Controls.Add(txtbabasn);
            grupbababilgileri.Controls.Add(txtbabad);
            grupbababilgileri.Controls.Add(label8);
            grupbababilgileri.Location = new Point(14, 215);
            grupbababilgileri.Name = "grupbababilgileri";
            grupbababilgileri.Size = new Size(208, 191);
            grupbababilgileri.TabIndex = 50;
            grupbababilgileri.TabStop = false;
            grupbababilgileri.Text = "Baba Bilgileri";
            // 
            // btnbabasorgula
            // 
            btnbabasorgula.Location = new Point(128, 37);
            btnbabasorgula.Name = "btnbabasorgula";
            btnbabasorgula.Size = new Size(75, 23);
            btnbabasorgula.TabIndex = 51;
            btnbabasorgula.Text = "Sorgula";
            btnbabasorgula.UseVisualStyleBackColor = true;
            btnbabasorgula.Click += btnbabasorgula_Click;
            // 
            // btnes
            // 
            btnes.Location = new Point(245, 12);
            btnes.Name = "btnes";
            btnes.Size = new Size(75, 23);
            btnes.TabIndex = 52;
            btnes.Text = "Eş Sorgula";
            btnes.UseVisualStyleBackColor = true;
            btnes.Click += btnes_Click;
            // 
            // grupaile
            // 
            grupaile.Controls.Add(grupannebilgileri);
            grupaile.Controls.Add(grupbababilgileri);
            grupaile.Location = new Point(0, 3);
            grupaile.Name = "grupaile";
            grupaile.Size = new Size(239, 422);
            grupaile.TabIndex = 53;
            grupaile.TabStop = false;
            grupaile.Text = "Aile Bilgileri";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(245, 48);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 54;
            btnclear.Text = "Temizle";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // Form_Dogum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
            Controls.Add(btnclear);
            Controls.Add(grupaile);
            Controls.Add(btnes);
            Controls.Add(grup_cocuk);
            Controls.Add(txtcocuktc);
            Controls.Add(label15);
            Controls.Add(btndogur);
            Name = "Form_Dogum";
            Text = "Form_Dogum";
            grup_cocuk.ResumeLayout(false);
            grup_cocuk.PerformLayout();
            grupannebilgileri.ResumeLayout(false);
            grupannebilgileri.PerformLayout();
            grupbababilgileri.ResumeLayout(false);
            grupbababilgileri.PerformLayout();
            grupaile.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtannetc;
        private TextBox txtannead;
        private Label label4;
        private TextBox txtbabad;
        private Label label5;
        private TextBox txtbabatc;
        private Label label8;
        private TextBox txtsoyad;
        private Label label9;
        private Label label10;
        private TextBox txtsaat;
        private Label label11;
        private TextBox txtcocukad;
        private Label label12;
        private Label label13;
        private TextBox txtgun;
        private Label label14;
        private Button btndogur;
        private TextBox txtcocuktc;
        private Label label15;
        private GroupBox grup_cocuk;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtannebsn;
        private TextBox txtanneasn;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox txtbababsn;
        private TextBox txtbabasn;
        private GroupBox grupannebilgileri;
        private Button btnannesorgula;
        private TextBox txtyil;
        private TextBox txtay;
        private TextBox txtdakika;
        private ComboBox comboBoxsehir;
        private ComboBox comboBoxcinsiyet;
        private Label label22;
        private Label label24;
        private Label label23;
        private GroupBox grupbababilgileri;
        private Button btnbabasorgula;
        private Button btnes;
        private GroupBox grupaile;
        private Button btnclear;
    }
}