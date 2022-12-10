using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;


namespace War.Models
{
    internal class RocketArmyImp : ArmyOfImperia
    {
        public int RocketImp;

        public RocketArmyImp(int budgetImp, int armyBudget, int resourse, int industry, int army, int ImpInfantry, int ImpAviation, int ImpRocket, int ImpFleet) : base(budgetImp, armyBudget, resourse, industry, army, ImpInfantry, ImpAviation, ImpRocket, ImpFleet)
        {
        }

        public static int RocketAttackInfResp(int RespInfantry) //aтака на військові частини
        {
            int MissileSalvoImp = RespInfantry / 80; // ксть ракет для ефективної атаки

            return MissileSalvoImp;
        }
        public static int RocketAttackAviaResp(int RespAviation) // атака на Аваційні частини 
        {
            int MissileSalvoA = RespAviation / 40;
            return MissileSalvoA;
        }
        public static int RocketAttackRockResp(int RespRocket)
        {
            int MissileSalvoRresp = RespRocket / 32;
            return MissileSalvoRresp;
        }
      
        public static int RocketAttackResp(int RespArmyBudget, int RespInfantry, int RespAviation, int RespRocket, int RocketImp, int RocketBudgetImp, float RocketKoefImp)
        {
            if (RespArmyBudget > 100)
            {
                RocketAttackInfResp(RespInfantry);
                RocketAttackAviaResp(RespAviation);
                RocketAttackRockResp(RespRocket);
               // RocketImp = MakeRocketImp(600, (int)0.47f);
                Console.WriteLine("After a rocket salvo of Republic, the rest of the rockets in Imperia = " + RocketImp);
            }
            return RocketImp;
        }
    }
}
