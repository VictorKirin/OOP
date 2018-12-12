using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Patient: Human
    {
        public int Weight; 

        public void GetInto() 
        {
            Console.WriteLine("Имя: " + Lastname + " Возраст: " + Age + " Вес: " + Weight);
        }

        public void debug()
        {
            Lastname = "Pozdnyakov";
            Age = 25;
            Weight = 79;
        }
    }
}
