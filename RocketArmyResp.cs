using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;


namespace War.Models
{
    internal class RocketArmyResp : ArmyResp
    {
        public RocketArmyResp(int armybudget, int resource, int industry, int army, int respinfantry, int respaviation, int resprocket) : base(armybudget, resource, industry, army, respinfantry, respaviation, resprocket)
        {
        }
        private static int RocketAttackInf(int ImpInfantry) //aтака на військові частини
        {
            int MissileSalvo = ImpInfantry / 100; // ксть ракет для ефективної атаки

            return MissileSalvo;
        }
        private static int RocketAttackAvia(int ImpAviation) // атака на Аваційні частини 
        {
            int MissileSalvoA = ImpAviation / 50; // MissileSalvoA - кількість випущених ракет
            return MissileSalvoA;
        }
        private static int RocketAttackRock(int ImpRocket)
        {
            int MissileSalvoR = ImpRocket / 35;
            return MissileSalvoR;
        }
        private static int RocketAttackFl(int ImpFleet)
        {
            int MissileSalvoF = ImpFleet / 70;
            return MissileSalvoF;
        }
        public static int RocketAttack(int ImpArmyBudget, int ImpInfantry, int ImpAviation, int ImpRocket, int ImpFleet, int Rocket)
        {
            if (ImpArmyBudget >= 1000)
            {
                RocketAttackInf(ImpInfantry);
                RocketAttackAvia(ImpAviation);
                RocketAttackRock(ImpRocket);
                RocketAttackFl(ImpFleet);
                Rocket = MakeRocket(40, (int)0.4f, Rocket);
                Console.WriteLine("After a rocket salvo, the rest of the rockets in Respublic = " + Rocket);
            }
            return Rocket;
            
        }
    }
}
