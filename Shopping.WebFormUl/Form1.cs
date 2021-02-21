using Shopping.Business.Abstarct;
using Shopping.Business.Concrete;
using Shopping.DataAccess.Concrete.EntityFramework;
using Shopping.Entities.Concrete;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());

        }



        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            cbxUCategoryId.DataSource = _categoryService.GetAll();
            cbxUCategoryId.DisplayMember = "CategoryName";
            cbxUCategoryId.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                ProductName = tbxProductName.Text,
                QuantityPerUnit = tbxQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxStock.Text)

            });
            MessageBox.Show("Ürün Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId =Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUProductName.Text,
                CategoryId =Convert.ToInt32(cbxUCategoryId.SelectedValue),
                QuantityPerUnit = tbxUQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(tbxUUnitInStock.Text)

            });
            MessageBox.Show("Ürün Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUProductName.Text = row.Cells[1].Value.ToString();
            cbxUCategoryId.SelectedValue = row.Cells[2].Value;
            tbxUUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUUnitInStock.Text = row.Cells[5].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show("Ürün Silindi");
                        LoadProducts();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
 
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }
    }
}
