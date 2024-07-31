using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_8_Interfaces
{
    public abstract class Animal 
    {
        public string Name { get; set; }

        public abstract void Eat();

        public void SetAnimalName(string name)
        {
            this.Name = name;
        }

        public void SetAnimalVoice()
        {
        }

        public string GetAnimalName()
        {
            return this.Name;
        }

       
    }
}

