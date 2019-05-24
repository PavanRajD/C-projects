using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            Program program=new Program();
            string username;
            string password;
            Console.WriteLine("<---    WelCome To Product Store   --->");
            ProductStore store = new ProductStore();
            Kart user = new Kart();
        X:
            Console.WriteLine("To Close Application Click 1 or To Continue click anything");
            int close = int.Parse(Console.ReadLine());
            if(close==1)
            {
                goto C;
            }
            Console.WriteLine("Enter UserName : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            password = Console.ReadLine();

            
           

            if(username=="admin" && password=="admin")
            {
                while (true)
                {
                    Console.WriteLine("1.AddProduct \n2.AddStock \n3.RemoveProduct \n4.Display \n5.logout\n");
                    int option = int.Parse(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            Product product = new Product();
                            Console.WriteLine("Enter Product Name : ");
                            product.ProductName = Console.ReadLine();
                            Console.WriteLine("Enter Product Price : ");
                            product.ProductPrice = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Product Stock : ");
                            product.ProductStock = int.Parse(Console.ReadLine());
                            store.AddProduct(product);
                            break;
                        case 2:
                            Console.WriteLine("Enter Product Id To Add Stock : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Quantity To Add : ");
                            int quantity = int.Parse(Console.ReadLine());
                            store.AddStock(id,quantity);
                            break;
                        case 3:
                            Console.WriteLine("Enter Product Id To Remove : ");
                            id = int.Parse(Console.ReadLine());
                            store.RemoveProduct(id);
                            break;
                        case 4:
                            List<Product> items = new List<Product>();
                            items = store.DisplayList();
                            for(int i=0;i<items.Count;i++)
                            {
                                Console.WriteLine("ProductId    = " + items[i].ProductId);
                                Console.WriteLine("ProductName  = " + items[i].ProductName);
                                Console.WriteLine("ProductPrice = " + items[i].ProductPrice);
                                Console.WriteLine("ProductStock = " + items[i].ProductStock+"\n");
                            }
                            break;
                        case 5:
                            goto X;
                    }
                }
            }
            else if(username == "user" && password == "user")
            {
                while (true)
                {
                    Console.WriteLine("1.AddToKart \n2.RemoveFromKart \n3.DisplayProductStore \n4.ViewKart \n5.Billing \n6.logout\n");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Product Id : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Quantity of Product : ");
                            int quantity = int.Parse(Console.ReadLine());
                            user.AddToKart(id,quantity);
                            break;
                        case 2:
                            Console.WriteLine("Enter Product Id To Remove Product : ");
                            id = int.Parse(Console.ReadLine());
                            user.RemoveFromKart(id);
                            break;
                        case 3:
                          List<Product> items = new List<Product>();
                            items = store.DisplayList();
                            for(int i=0;i<items.Count;i++)
                            {
                                Console.WriteLine("ProductId    = " + items[i].ProductId);
                                Console.WriteLine("ProductName  = " + items[i].ProductName);
                                Console.WriteLine("ProductPrice = " + items[i].ProductPrice);
                                Console.WriteLine("ProductStock = " + items[i].ProductStock+"\n");
                            }
                            break;
                        case 4:
                            List<Product> kartItems = new List<Product>();
                            kartItems = user.DisplayKart();
                            foreach (var item in kartItems)
                            {
                                Console.WriteLine("ProductId    = " + item.ProductId);
                                Console.WriteLine("ProductName  = " + item.ProductName);
                                Console.WriteLine("ProductPrice = " + item.ProductPrice);
                                Console.WriteLine("ProductQuantity = " + item.ProductStock + "\n");
                            }
                            break;
                        case 5:
                            Console.WriteLine(user.Billing());
                            break;
                        case 6:
                            goto X;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Credentials!!!");
                goto X;
            }
        C:
            Console.WriteLine("Thank You!!!");
        }
       }
}
