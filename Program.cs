using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Respublica(100, 50, 25, 50000);
          
            int v = Respublica.MakeBudget(25, 50);
            Console.WriteLine("Budget of Respublik = " + v);

            new Imperia(7500, 12000, 100, 75, 100000);
            Console.WriteLine("Budget of Imperia = " + Imperia.MakeBudget(75, 100));

            new ArmyResp(100, 50, 25, 50000, 25000, 120, 1000);
            
            float Booty = ArmyResp.MakeBooty(0.05f, 0.021f, 0.014f, 1000);          
            Console.WriteLine("Budget of Respublic Army = " + Respublica.MakeArmyBudget(50, 50, 40, Booty));

            float BootyImp = ArmyOfImperia.MakeBooty(0.06f, 0.032f, 0.0245f, 0.057f, 100);
            Console.WriteLine("Budget of Imperia Army = " + Imperia.MakeArmyBudget(500, 400, 600, 600, BootyImp));

            RocketArmyResp.RocketAttack(65000, 90000, 780, 9000, 1000, 200); // Ксть ракет  після атаки
            Console.ReadKey();
            
        }
    }
}
