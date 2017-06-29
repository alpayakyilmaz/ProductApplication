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
    public partial class ProductSummary : Form
    {
        public ProductSummary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductSummary_Load(object sender, EventArgs e)
        {
            try
            {
                BL.ProductSummaryStatistic summaryStats = DAL.ProductDAL.GetProductSummary();
                lblNumberOfProducts.Text = summaryStats.ProductCount.ToString();
                lblMinimumPrice.Text = summaryStats.MinimumPrice.ToString();
                lblMaximumPrice.Text = summaryStats.MaximumPrice.ToString();
                lblAvaragePrice.Text = summaryStats.AvaragePrice.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Beklenmeyen Hata");
                Util.Logger.LogException(ex);
            }
        }
    }
}
