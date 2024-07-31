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
        string Voice = "meow";
        public void GetVoice(string name)
        {
            Console.WriteLine($"Dog {name} say {Voice}");
        }
    }
}
