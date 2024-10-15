using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProductCollection
{
    internal class SortByBrandName : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return x.BrandName.CompareTo(y.BrandName);
        }
    }
}
