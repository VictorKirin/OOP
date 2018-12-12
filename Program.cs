using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Doctor doctor = new Doctor();

            Patient patient1 = new Patient();
            patient1.Lastname = "Petrov";
            patient1.Age = 30;
            patient1.Weight = 80;

            patient.debug();
            doctor.debug();


            patient.GetInto();
            Console.WriteLine("Фамилия: " + patient.Lastname + " Возраст: " + patient1.Age + " Вес: " + patient.Weight);

            doctor.GetInto();
            Console.ReadKey();

        }
    }
}
