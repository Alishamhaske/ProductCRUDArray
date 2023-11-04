using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCRUD productCRUD = new ProductCRUD();

            do
            {
                Console.WriteLine("------------************---------------");
                Console.WriteLine("1. Display Products: details ");
                Console.WriteLine("2. Add product ");
                Console.WriteLine("3. search product : ");
                Console.WriteLine("4. update product: ");
                Console.WriteLine("5: Deleted sucessfully: ");
                Console.WriteLine("Enter your choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    //display product
                    case 1:
                        Product[] result = productCRUD.DisplayProduct();
                        Console.WriteLine("Id\t  Name\t Price\t Company\t");
                        
                            foreach (Product item in result)
                            {
                                Console.WriteLine($"{item.Id},  {item.Name}, {item.Price}, {item.Company}");
                            
                            }
                 
                       

                        break;

                    case 2:
                        //add product
                        Product p1 = new Product();
                        Console.WriteLine("Enter Id: ");
                        p1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name: ");
                        p1.Name = (Console.ReadLine());
                        Console.WriteLine("Enter Price: ");
                        p1.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company: ");
                        p1.Company = (Console.ReadLine());
                        productCRUD.Addproduct(p1);
                        Console.WriteLine("Product save sucessfully.....................");
                        break;



                    case 3:
                        //search product
                        Console.WriteLine("Enter id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = productCRUD.GetProduct(id);
                        Console.WriteLine("Id\t  Name\t Price\t Company\t");
                        Console.WriteLine($"{p.Id},     {p.Name},    {p.Price},    {p.Company}");

                        break;

                  
                    case 4:
                        //upadate product
                        Product p2 = new Product();
                        Console.WriteLine("Enter Id: ");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name: ");
                        p2.Name = (Console.ReadLine());
                        Console.WriteLine("Enter Price: ");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company: ");
                        p2.Company = (Console.ReadLine());
                        productCRUD.UpdateProduct(p2);
                        Console.WriteLine("Updated sucessfully.....................");
                        break;

                        



                    case 5:
                        //delete product
                        Console.WriteLine("Enter id: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        productCRUD.DeleteProduct(id2);
                        Console.WriteLine($"{id2} - Deleted sucessfully.............");
                        break;


                }

                Console.WriteLine("press 1 if continue...................");
                no = Convert.ToInt32(Console.ReadLine());

            } while (no == 1);


        }
    }
}
