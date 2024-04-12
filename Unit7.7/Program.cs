using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Unit_7._7;

namespace Unit_7._7
{
    class Payment
    {
        private string NumberCard;
        public Payment(string NumberCard)
        {
            this.NumberCard = NumberCard;
        }

        public void NumberCardInfo()
        {
            Console.WriteLine("Номер карты {0}", this.NumberCard);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer();
            buyer.ButerInfo();

            Payment payment = new Payment("123456789");
            payment.NumberCardInfo();

            var array = new Product[]
            {
                new Product { Name = "Позиция 1", Quantity = 1 },
                new Product { Name = "Позиция 2", Quantity =  1 },
                new Product { Name = "Позиция 3", Quantity =  3 },
                new Product { Name = "Позиция 4", Quantity =  2 },
            };
            ProductList list = new ProductList(array);

            Product product = list["Позиция 1"];
            Console.WriteLine(list);

            Console.ReadKey();
        }
    }

    class Product
    {
        public string Name;
        public int Quantity;
    }
    class ProductList
    {
        private Product[] list;
        public ProductList(Product[] list)
        {
            this.list = list;
        }

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                {
                    return list[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < list.Length)
                {
                    list[index] = value;
                }
            }
        }
        public Product this[string name]
        {
            get
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Name == name)
                    {
                        return list[i];
                    }
                }
                return null;
            }
        }
    }

    abstract class Delivery
    {
        public string Address;

    }

    class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : Delivery
    {

    }

    class ShopDelivery : Delivery
    {
        public void ShopDeliveryInfo()
        {
            string[] ArrayAddressStore = new string[10];

        }
    }

    class Buyer
    {
        public string Name = "Men";
        public string Address;
        public int Telephone = 78965439;

        public void ButerInfo()
        {
            Console.WriteLine($"Имя: {Name}. Телефон: {Telephone}");

        }
    }
}
