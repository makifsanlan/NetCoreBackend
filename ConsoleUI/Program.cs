using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //productTest();
            CategoryManager categoryManager= new CategoryManager(new EfCategoryDal);
            foreach(var category in categoryManager.GetAll())
            { 
            console.WriteLine(category.CategoryName);
            }
        }






        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName +"/"+ product.CategoryName);
           }
        }
    }
}
