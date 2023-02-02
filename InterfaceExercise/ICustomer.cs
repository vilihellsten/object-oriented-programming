using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICustomer
    {
        Customer GetCustomer(string name);

        void GetBonus();
    }
}
