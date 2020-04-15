using System;
using System.Collections.Generic;
using System.Text;

namespace ch7_classes {
    class Product {
        public String Code { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }

        public Product() {

        }

        public Product(string code, string desc, double price) {
            Code = code;
            Description = desc;
            Price = price;
        }

        public override string ToString() {
            return $"Product: code={Code}, description={Description}, price={Price}";
        }
    }
}
