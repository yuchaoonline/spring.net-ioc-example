using model;
using service;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpring.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IProductService productService = (IProductService)ctx.GetObject("ProductService");

            foreach (Product p in productService.FindAll())
            {
                Console.WriteLine("Id: " + p.Id +
                                  " Desc.: " + p.Description +
                                  " Price: $" + p.Price);
            }

            Console.ReadKey();
        }
    }
}
