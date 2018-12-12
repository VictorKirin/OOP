using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Doctor:Human
    
    {
        public string Specialization;

        public void GetInto() // запрос имени и возраста
        {
            Console.WriteLine("Фамилия: " + Lastname + " Возраст: " + Age + " Специализация: " + Specialization);
        }
        public void debug()
        {
            Lastname = "Aligaev";
            Age = 50;
            Specialization = "Oculist";
    }
  }
}
