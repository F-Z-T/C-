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
    public partial class SıfremıUnuttum : Form
    {
        public SıfremıUnuttum()
        {
            InitializeComponent();
        }

        private void SıfremıUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
            MessageBox.Show("Şifre Güncellendi.");
        }
    }
}
