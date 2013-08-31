using System.Collections.Generic;
using model;

namespace dao
{
    public class ProductDAO : IProductDAO
    {
        public List<Product> ListAll()
        {
            List<Product> products = new List<Product>();
            
            products.Add(new Product(1,
                                     "Pinarello Dogma road bike carbon frame and forks", 
                                     6300.00));

            products.Add(new Product(2,
                                     "Caloi Sprint road bike alloy frame carbon forks",
                                     1161.41));

            products.Add(new Product(3,
                                     "Colnago Move road bike alloy frame carbon forks",
                                     1283.14));

            return products;
        }
    }
}
