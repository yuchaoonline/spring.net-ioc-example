using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class Product
    {
        public int Id
        {
            set;
            get;
        }

        public String Description
        {
            set;
            get;
        }

        public double Price
        {
            set;
            get;
        }

        public Product(int id, String description, double price)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
        }
    }
}
