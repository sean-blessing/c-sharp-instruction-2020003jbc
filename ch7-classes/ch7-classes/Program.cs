using System;


namespace ch7_classes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create some Products!");
            Product p1 = new Product("java", "Murach's Java", 57.50);
            Product p2 = new Product(".net", "Murach's .Net", 58.50);
            p2.Price = 49.99;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            LineItem li = new LineItem();
            li.Product = p1;
            li.Quantity = 2;
        }
    }

}
