using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_8_Interfaces
{
    interface IAnimalsVoices
    {
        string AnimalVoice();
    }

    interface IAnimalsSays
    {
        void AnimalVoice1(IAnimalsSays animalVoice);
    }
}
