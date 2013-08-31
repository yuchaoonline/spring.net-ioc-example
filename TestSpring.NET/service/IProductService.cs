using System;
using System.Collections.Generic;
using model;

namespace service
{
    interface IProductService
    {
       List<Product> FindAll();
    }
}
