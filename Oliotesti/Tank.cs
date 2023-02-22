using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliotesti
{
    internal class Tank : BaseTank, ITank
    {
        public int capasity;
        public int amount;

        public Tank(string name, int capasity) : base(name)
        {
            this.amount = 0;
            this.capasity = capasity;
        }

        public string AddToTank(int amount)
        {
            if (amount < 0)
            {
                return "säiliön " + this.Name + " tilaa ei muutettu";
            }

            if (this.amount + amount > GetAmount())
            {
                int lisäys = this.capasity - this.amount;
                this.amount = GetAmount();
                return "säiliöön " + base.Name + " lisättiin " + lisäys + " yksikköä, säiliö täynnä";
            }
            else
            {
                this.amount += amount;
                return "säiliöön " + base.Name + " lisättiin " + amount + " yksikköä";
            }

        }
        

        // ilmoittaa nesteen määrän säiliössä

        public int GetAmount()
        {
            return capasity;
        }
        // poistaa säiliöstä parametrin ilmoittaman määrän nestettä
        public string RemoveFromTank(int amount)
        {
            if (amount < 0)
            {
                return "säiliön " + this.Name + " tilaa ei muutettu";
            }

            if(this.amount - amount < 0)
            {
                int poisto = this.amount;
                this.amount = 0;
                return "säiliöstä " + base.Name + " poistettiin " + poisto + " yksikköä, säiliö tyhjä";
            }
            else
            {
                this.amount -= amount;
                return "säiliöstä " + base.Name + " poistettiin " + amount + " yksikköä";
            }

            

        }
        // tyhjentää säiliön
        public void ClearTank()
        {
            this.amount = 0;
        }

        public override string ToString()
        {
            
            return base.ToString() + ": kapasiteetti: " + GetAmount() + ", nestettä " + this.amount;
        }
    }
}
