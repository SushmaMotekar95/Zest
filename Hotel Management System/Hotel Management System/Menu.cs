using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class Menu
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Price {  get; set; }


        public Menu(int id,string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }       
        public override string ToString() {

            return $"{Id}:${Name}:${Price}";
        }
    }
}
