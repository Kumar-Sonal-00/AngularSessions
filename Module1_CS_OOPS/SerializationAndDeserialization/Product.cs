﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    [Serializable]
    public class Product
    {
        public int ProductId {  get; set; }
        public string Description { get; set; }
        public int Quantity {  get; set; }
        public double Price { get; set; }
        int reviews = 5;
    }
}
