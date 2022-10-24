using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //宣告一個 List<Product> 變數, 存放多筆購買商品

            List<Product> Product = new List<Product>()
            {
            new Product(){Name="1",Price=1},
            new Product(){Name="2",Price=2},
            new Product(){Name="3",Price=3},

            };

        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
