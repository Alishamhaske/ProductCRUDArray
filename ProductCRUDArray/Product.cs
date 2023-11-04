using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUDArray
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string Company { get; set; }

    }

    public class ProductCRUD
    {
         Product[] products=new Product[8];
         int productCount = 0;
        // = new Product[3];

      int nextId = 1;

        public ProductCRUD()
        {
            products = new Product[]
            {
                new Product{Id=1,Name="pen",Price=33,Company="belly" },
                new Product{Id=1,Name="pencil",Price=33,Company="belly" },
                new Product{Id=1,Name="pen",Price=33,Company="belly" }
            };

        }

        public Product[] DisplayProduct()
        {
            return products;
        }
        public void Addproduct(Product p)
        {
            if(productCount<products.Length)
            {
                p.Id = nextId++;
                products[productCount++] = p;
            }
            else
            {
                Console.WriteLine("product inventory is full:");
            }
        }

        public Product GetProduct(int id)
        {
            foreach (Product item in products)
            {
                if (products != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;

        }
      

        public void UpdateProduct(Product p)
        {
            foreach (Product item in products)
            {
                if (item.Id == p.Id)
                {
                    item.Price = p.Price;
                    item.Company = p.Company;
                    item.Name = p.Name;
                }
            }
        }


        public void DeleteProduct(int id)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Id == id)
                {
                    products[i] = null;
                    Array.Copy(products, i + 1, products, i, productCount - i + 1);
                    productCount--;
                    break;
                }
            }
        }




    }
}
