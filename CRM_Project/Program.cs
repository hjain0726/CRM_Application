using System;
using System.Collections.Generic;


namespace CRM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>
            {
                new Customer{ customer_id="dgdjhbf",customer_name="harsh",customer_email="123@gmail.com",customer_pwd="123",customer_address="evjvvv",custome_phone="8447307701" }
            };

           
            List<Product> Products = new List<Product>
            {
                new Product{ product_id ="104152ww",product_name="puma",product_category="shoes",product_price=10000d,product_stock=3},
                new Product{ product_id ="5446swe",product_name="reebok",product_category="shoes",product_price=20000d,product_stock=2},
                new Product{ product_id ="sdj#",product_name="addidas",product_category="shoes",product_price=30000d,product_stock=1},
            };

            List<Order> orders = new List<Order> { };

            Console.WriteLine("List of Products");
            foreach (Product product in Products)
            {
                Console.WriteLine("\nProduct id:{0}  Name:{1}  Category:{2}  Price:{3}  Stock:{4}", product.product_id, product.product_name, product.product_category, product.product_price, product.product_stock);
            }

            Console.WriteLine("\n Enter your Email");
            string email = Console.ReadLine();
            Console.WriteLine("\nEnter your password");
            string pwd = Console.ReadLine();
            int fg = 0;
            foreach (Customer c in Customers)
            {
                if (c.customer_email.Equals(email)&&c.customer_pwd.Equals(pwd))
                {
                    Console.WriteLine("SUCCESSFULLY LOGIN as "+c.customer_name);

                    Console.WriteLine("\n Enter Product name you want to buy");
                    string pname = Console.ReadLine();
                    Console.WriteLine("\n Enter quantity");
                    int qty = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(pname+" "+qty);
                    foreach (Product product in Products)
                    {
                        if (product.product_name.Equals(pname)&&(product.product_stock<=qty))
                        {
                            Console.WriteLine("You successfully bought this product");

                            Console.WriteLine("\n Your bill is here");
                            string id = "dhjvbfvb";
                            Console.WriteLine("\nOrder id: {0}  Product id: {1}  Product name:{2}  Quantity:{3}  Product Category:{4}\n  Price:{5}  Net Amount:{6}",id,product.product_id,product.product_name,qty,product.product_category,product.product_price,product.product_price*qty);
                            fg = 1;
                            break;
                        }
                    }
                    if (fg == 0)
                    {
                        Console.WriteLine("Product is out of stock");
                    }
                }
                else
                {
                    Console.WriteLine("NO USER EXISTS");
                }
            }
            Console.ReadLine();
        }
    }
}
