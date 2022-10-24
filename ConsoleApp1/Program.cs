using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //宣告一個 List<Product> 變數, 存放多筆購買商品

            List<Product> Product01 = new List<Product>();
            List<Product> Product02 = new List<Product>();
            List<Product> Product03 = new List<Product>();

        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
