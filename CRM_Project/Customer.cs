using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Project
{
    class Customer
    {
        public string customer_id { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_pwd { get; set; }
        public string customer_address { get; set; }
        public string custome_phone { get; set; }

        /*public string get_customer_id()
        {
            return this.customer_id;
        }*/

       /* public void setCustomer(string _id,string name, string email,string pwd,string address, string phone)
        {
            this.customer_id = _id;
            this.customer_name = name;
            this.customer_email = email;
            this.customer_pwd = pwd;
            this.customer_address = address;
            this.custome_phone = phone;
        }*/
    }
}
