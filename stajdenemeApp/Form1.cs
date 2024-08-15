using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using stajdenemeApp.ComplexModels;
using stajdenemeApp.Models;
using System.Diagnostics;

namespace stajdenemeApp
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            this.KeyPreview = true; // KeyPreview özelliðini true olarak ayarla
            this.KeyDown += new KeyEventHandler(Form_login_KeyDown); // KeyDown olayýný iþleyiciye baðla
        }

        private void Form_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // button1'i týklat
            }
        }

        public bool Login(string username, string password)
        {
            using (var context = new StajdenemeContext())
            {
                var kullanici = context.Kullanici
                    .FromSqlRaw("SELECT * FROM kullanici WHERE ad = {0} AND parola = crypt({1}, parola)", username, password)
                    .FirstOrDefault();

                return kullanici != null;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtusername.Text;
            string parola = txtpassword.Text;
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Kullanýcý adý boþ geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Parola boþ geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }
            bool kullaniciVar = Login(ad, parola);

            if (kullaniciVar)
            {
                Form_menu form_menu = new Form_menu();
                form_menu.Show();
                Hide();
                //Process.Start("C:\\Users\\bayra\\source\\repos\\WinFormsApp3\\WinFormsApp3\\bin\\Debug\\net8.0-windows\\WinFormsApp3.exe");
            }
            else
            {
                MessageBox.Show("Kullanýcý bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }

            txtusername.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
