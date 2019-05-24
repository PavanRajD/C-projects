using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    class Kart
    {
        public List<Product> ProductsInKart = new List<Product>();
        ProductStore productStore = new ProductStore();
        public void AddToKart(int Id,int quantity)
        {
            var item = productStore.ProductList.Find(c => c.ProductId == Id);
            if(item==null)
            {
                throw new Exception("Product doesn't Exist or only"+ item.ProductStock +"quantity is available");
            }
            else
            {
                productStore.ProductList[productStore.ProductList.IndexOf(item)].ProductStock-=quantity;
                item.ProductStock = quantity;
                ProductsInKart.Add(item);
            }
        }

        public int Billing()
        {
            int Bill=0;
            foreach(var product in ProductsInKart)
            {
                Bill = Bill + product.ProductPrice;
            }
            return Bill;
        }

        public void RemoveFromKart(int Id)
        {
            var item = productStore.ProductList.Find(c => c.ProductId == Id);
            if (item == null)
            {
                throw new Exception("Product doesn't Exist or only" + item.ProductStock + "quantity is available");
            }
            else
            {
                productStore.ProductList.Remove(item);
            }
        }

        public List<Product> DisplayKart()
        {
            return ProductsInKart;
        }
    }
}
