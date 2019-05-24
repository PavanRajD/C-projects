using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    class ProductStore
    {
        public int Id { get; set; }
       
        public List<Product> ProductList;

        public ProductStore()
        {
            ProductList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Id = ProductList.Count + 1;
            product.ProductId = Id;
            ProductList.Add(product);
        }

        public void RemoveProduct(int Id)
        {
            var exist = ProductList.Find(c=>c.ProductId==Id);
            if (exist==null)
            {
                throw new Exception("Product doesn't Exist");
            }
            else
            {
                ProductList.Remove(exist);
            }
        }

        public void AddStock(int Id,int Stock)
        {
            var exist = ProductList.Find(c => c.ProductId == Id);
            if (exist == null)
            {
                throw new Exception("Product doesn't Exist");
            }
            else
            {
                ProductList[ProductList.IndexOf(exist)].ProductStock+= Stock;
            }
        }

        public List<Product> DisplayList()
        {
            return ProductList;
        }

    }
}