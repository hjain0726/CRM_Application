using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    class Product
    {
        public string product_id { set; get; }
        public string product_name { set; get; }
        public string product_category { set; get; }
        public double product_price { set; get; }
        public int product_stock { set; get; }

       /* public string get_product_id()
        {
            return this.product_id;
        }
        public int get_price()
        {
            return this.product_price;
        }

        public void setProduct(string id,string name,string category,int price,int stock)
        {
            this.product_id = id;
            this.product_name = name;
            this.product_category = category;
            this.product_price = price;
            this.product_stock = stock;
        }*/
    }
}
