namespace ProductApplication
{
    partial class ProductSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.lblMinimumPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaximumPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvaragePrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Location = new System.Drawing.Point(114, 9);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(0, 13);
            this.lblNumberOfProducts.TabIndex = 1;
            // 
            // lblMinimumPrice
            // 
            this.lblMinimumPrice.AutoSize = true;
            this.lblMinimumPrice.Location = new System.Drawing.Point(114, 41);
            this.lblMinimumPrice.Name = "lblMinimumPrice";
            this.lblMinimumPrice.Size = new System.Drawing.Size(0, 13);
            this.lblMinimumPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Minimum Price:";
            // 
            // lblMaximumPrice
            // 
            this.lblMaximumPrice.AutoSize = true;
            this.lblMaximumPrice.Location = new System.Drawing.Point(114, 80);
            this.lblMaximumPrice.Name = "lblMaximumPrice";
            this.lblMaximumPrice.Size = new System.Drawing.Size(0, 13);
            this.lblMaximumPrice.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Maximum Price:";
            // 
            // lblAvaragePrice
            // 
            this.lblAvaragePrice.AutoSize = true;
            this.lblAvaragePrice.Location = new System.Drawing.Point(114, 122);
            this.lblAvaragePrice.Name = "lblAvaragePrice";
            this.lblAvaragePrice.Size = new System.Drawing.Size(0, 13);
            this.lblAvaragePrice.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Avarage Price:";
            // 
            // ProductSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 402);
            this.Controls.Add(this.lblAvaragePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMaximumPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinimumPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumberOfProducts);
            this.Controls.Add(this.label1);
            this.Name = "ProductSummary";
            this.Text = "ProductSummary";
            this.Load += new System.EventHandler(this.ProductSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label lblMinimumPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaximumPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvaragePrice;
        private System.Windows.Forms.Label label8;
    }
}