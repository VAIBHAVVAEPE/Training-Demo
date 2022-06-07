using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Demo
{
    class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Price { get; set; }

    }
    class AAA1
    {
        static void Main(string[] args)
        {


            Product[] productList = new Product[]
            {
                
            new Product{Id=123,name="Parle biscuit",Price=5},
            new Product{Id=685,name="Tigher biscuit",Price=6},
            new Product{Id=858,name="Oreo biscuit",Price=10},
            };

            foreach(Product pp in productList)
            {
                Console.WriteLine($"{pp.Id} {pp.name}  {pp.Price} ");
            }
        }
    }
}
