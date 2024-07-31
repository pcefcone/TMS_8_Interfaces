using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_8_Interfaces
{
    internal class Cat : Animal, IAnimalVoices
    {
        public override void Eat()
        {
            Console.WriteLine($"Cat {Name} eat");
        }
        public void GetVoice(string name, string voice)
        {
            Console.WriteLine($"Cat {name} say {voice}");
        }
    }
}
