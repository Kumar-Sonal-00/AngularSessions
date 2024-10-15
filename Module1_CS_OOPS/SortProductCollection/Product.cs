using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProductCollection
{
    internal class Product : IComparable<Product>
    {
        public int ProductId {  get; set; }
        public string Description  { get; set; }
        public string BrandName { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product? other)
        {
            return this.ProductId.CompareTo(other.ProductId);
        }
        public override string ToString()
        {
            return $"{this.ProductId}\t{this.Description}\t{this.BrandName}\t{this.Price}";
        }
    }
}
