using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceExercise
{
    

    internal class InsuranceManager
    {

        private List<Insurance> insurancelist = new List<Insurance>();
        
        public void AddInsurance(string animal, string name, bool isNeutered)
        {
           
            this.insurancelist.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
            
        }
        
        public double GetFee(string species, bool isNeutererd)
        {
            /* Leikattu koira maksaa 50 €
            • Leikkaamaton koira maksaa 80 €
            • Leikattu kissa maksaa 40 €
            • Leikkaamaton kissa maksaa 60 €
            • Lintu tai matelija ei maksa mitään*/

            if(species == "koira")
            {
                if(species == "koira" && isNeutererd == true)
                {
                    return 50;
                }
                else
                {
                    return 80;
                }
            }

            if (species == "kissa")
            {
                if (species == "kissa" && isNeutererd == true)
                {
                    return 40;
                }
                else
                {
                    return 60;
                }
            }

            if (species == "lintu")
            {
                return 0;
            }
            
            if (species == "matelija")
            {
                return 0;
            }

            return 0;

        }

        public void PrintInsurances()
        {
            Console.WriteLine("vakuutuksia yhteensä " + insurancelist.Count);
            Console.WriteLine("vakuutukset:\n");

            foreach ( Insurance insurance in insurancelist)
            {
                
                Console.WriteLine(insurance);
            }
        }

        public void FindInsurances(string species, bool isNeutered)
        {
            Console.WriteLine("löytyi:\n");
            foreach(Insurance insurance in this.insurancelist)
            {
                if(insurance.Species == species && insurance.Neutered == isNeutered)
                {
                    Console.WriteLine(species + ": " + insurance.Name + ", Vakuutusmaksu: " + insurance.Fee + "€");
                }  
            }
        }
    }
}
