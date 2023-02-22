using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliotesti
{
    internal class BaseTank
    {
        private string name;
        public BaseTank(string name)
        {
            this.Name = name;
        }

        protected string Name { get => name; set => name = value; }

        public virtual string ToString()
        {
            return "säiliö " + Name;
        }
    }

}

