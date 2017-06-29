using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.BL
{
    internal sealed class ProductSummaryStatistic
    {

        private readonly string _description;

        public string Description
        {
            get { return _description; }
        }


        private readonly int _productCount;

        public int ProductCount
        {
            get { return _productCount; }
        }


        private readonly decimal _minimumPrice;

        public decimal MinimumPrice
        {
            get { return _minimumPrice; }
        }


        private readonly decimal _maximumPrice;

        public decimal MaximumPrice
        {
            get { return _maximumPrice; }
        }


        private readonly decimal _avaragePrice;

        public decimal AvaragePrice
        {
            get { return _avaragePrice; }
        }

        public ProductSummaryStatistic(string description, int productCount, decimal minimumPrice, decimal maximumPrice, decimal avaragePrice)
        {
            this._description = description;
            this._productCount = productCount;
            this._minimumPrice = minimumPrice;
            this._maximumPrice = maximumPrice;
            this._avaragePrice = avaragePrice;
        }
    }
}
