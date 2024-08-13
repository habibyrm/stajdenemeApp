namespace stajdenemeApp
{
    partial class Form_menu
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
            btn_kisi_sorgulama = new Button();
            btndogum = new Button();
            btnolum = new Button();
            btnevlenme = new Button();
            SuspendLayout();
            // 
            // btn_kisi_sorgulama
            // 
            btn_kisi_sorgulama.Location = new Point(26, 27);
            btn_kisi_sorgulama.Name = "btn_kisi_sorgulama";
            btn_kisi_sorgulama.Size = new Size(250, 65);
            btn_kisi_sorgulama.TabIndex = 0;
            btn_kisi_sorgulama.Text = "Kişi Sorgulama";
            btn_kisi_sorgulama.UseVisualStyleBackColor = true;
            btn_kisi_sorgulama.Click += button1_Click;
            // 
            // btndogum
            // 
            btndogum.Location = new Point(342, 27);
            btndogum.Name = "btndogum";
            btndogum.Size = new Size(250, 65);
            btndogum.TabIndex = 1;
            btndogum.Text = "Doğum";
            btndogum.UseVisualStyleBackColor = true;
            btndogum.Click += btndogum_Click;
            // 
            // btnolum
            // 
            btnolum.Location = new Point(26, 165);
            btnolum.Name = "btnolum";
            btnolum.Size = new Size(250, 65);
            btnolum.TabIndex = 2;
            btnolum.Text = "Ölüm";
            btnolum.UseVisualStyleBackColor = true;
            btnolum.Click += btnolum_Click;
            // 
            // btnevlenme
            // 
            btnevlenme.Location = new Point(342, 165);
            btnevlenme.Name = "btnevlenme";
            btnevlenme.Size = new Size(250, 65);
            btnevlenme.TabIndex = 3;
            btnevlenme.Text = "Evlenme";
            btnevlenme.UseVisualStyleBackColor = true;
            btnevlenme.Click += btnevlenme_Click;
            // 
            // Form_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnevlenme);
            Controls.Add(btnolum);
            Controls.Add(btndogum);
            Controls.Add(btn_kisi_sorgulama);
            Name = "Form_menu";
            Text = "MENU";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_kisi_sorgulama;
        private Button btndogum;
        private Button btnolum;
        private Button btnevlenme;
    }
}