using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_14_2020
{
    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            int n;
            Console.WriteLine("My age is: " + age + " years old");
        }
    }
}
