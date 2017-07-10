using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShopingCart
    {
        private IValueCalculator _calc;

        public ShopingCart(IValueCalculator calcParam)
        {
            _calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return _calc.ValueProducts(Products);
        }
    }
}