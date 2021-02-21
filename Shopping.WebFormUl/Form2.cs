using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.WebFormUl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSatıcıGırıs_Click(object sender, EventArgs e)
        {

        }

        private void btnSatıcıGırıs_Click_1(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();       
            MessageBox.Show("Giriş Başarılı");
        }


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uyeOlsec = new UyeOl();
            uyeOlsec.Show();
            this.Hide();
            
        }

        private void btnGırısYap_Click(object sender, EventArgs e)
        {
            UyeAlısverıs uyeAlısverıssec = new UyeAlısverıs();
            uyeAlısverıssec.Show();
            this.Hide();
            MessageBox.Show("Giriş Başarılı");
        }

        private void lblUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SıfremıUnuttum sıfremıUnuttumsec = new SıfremıUnuttum();
            sıfremıUnuttumsec.Show();
            this.Hide();
        }

        private void gbxSatıcıGırıs_Enter(object sender, EventArgs e)
        {
            
        }
        

        private void tbxSK_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
