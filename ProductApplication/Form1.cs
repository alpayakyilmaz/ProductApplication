using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int productCount = DAL.ProductDAL.GetProductCount();
                lblProductCount.Text = productCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu sistem yöneticisi felan falan");
                Util.Logger.LogException(ex);

            }
        }

        private void btnProductSummary_Click(object sender, EventArgs e)
        {
            ProductSummary summary = new ProductSummary();
            summary.Show();
        }
    }
}
