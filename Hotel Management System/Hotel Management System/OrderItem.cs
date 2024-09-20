using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public  class OrderItem
    {
        public  Menu Menu { get; set; }
        public int Quantity {  get; set; }


        public OrderItem(Menu menu,int quantity) {
             Menu = menu;
            Quantity = quantity;
        }


        public double GetTotalPrice()
        {
            return Menu.Price * Quantity;
        }
        public override string ToString() {
            return $"{Menu}:{Quantity}";
        }


    }
}
