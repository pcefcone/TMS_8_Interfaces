using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_8_Interfaces
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"Dog {Name} eat");
        }
    }
}
