using Shopping.Business.Abstarct;
using Shopping.Business.Concrete;
using Shopping.DataAccess.Abstarct;
using Shopping.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping.WebFormUl
{
    public partial class UyeAlısverıs : Form
    {
        public ProductManager IProductService { get; private set; }

        public UyeAlısverıs()
        {
            InitializeComponent();
            

        }
       

        private void btnMusterıCıkıs_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();

        }

        private void gbxKargoTakıp_Enter(object sender, EventArgs e)
        {

        }
       

        private void UyeAlısverıs_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gbxCategoryAra_Enter(object sender, EventArgs e)
        {

        }
    }

 
}
