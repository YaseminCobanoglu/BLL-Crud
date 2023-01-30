using NetECommerce.BLL.Abstract;
using NetECommerce.BLL.Concrete;
using System;

namespace NetEcommerce.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRepository productRepository=new ProductRepository();

            foreach (var item in productRepository.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
           
        }
    }
}
