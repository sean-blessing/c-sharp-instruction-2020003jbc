using System;
using System.Collections.Generic;
using System.Text;

namespace ch7_classes {
    class LineItem {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public LineItem() {

        }

        public LineItem(Product prod, int qty) {
            Product = prod;
            Quantity = qty;
        }

        public override string ToString() {
            return "LineItem: Product=" + Product + ", Quantity=" + Quantity;
        }
    }


}
