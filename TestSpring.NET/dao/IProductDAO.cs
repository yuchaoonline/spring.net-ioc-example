using System.Collections.Generic;
using model;

namespace dao
{
    public interface IProductDAO
    {
        List<Product> ListAll();
    }
}
