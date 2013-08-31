using System.Collections.Generic;
using dao;
using model;

namespace service
{
    public class ProductService : IProductService
    {
        IProductDAO productDAO;

        public IProductDAO IProductDAO
        {
            get;
            set;
        }

        public ProductService()
        {
        }

        public List<Product> FindAll()
        {
            return this.productDAO.ListAll();
        }
    }
}
