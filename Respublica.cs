using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    internal class Respublica : IAllies
    {
        private int BudgetOfResp;
        public int RespArmyBudget = 101;
        public int Resource = 50;
        public int Industry = 25; // = + 100 budget in year and - 50 resourse
        public int Army = 50000;
        public int AidInfantry;
        public int FinancialAid;
        public float MedicalCoef; // if > 1 need help
        public int NumberOfBeds = 1500;
        public int NumberOfWounded;

        public Respublica(int resparmybudget, int resource, int industry, int army)
        {
            RespArmyBudget = resparmybudget;
            Resource = resource;
            Industry = industry;
            Army = army;
        }

        public static int MakeBudget(int Industry, int Resourse)
        {
            int BudgetOfResp = Industry * Resourse;
            return BudgetOfResp; // If (Respublica.BudgetImp > Imperia.BudgetImp) { AttacRespublica();}
        }
        public static int MakeArmyBudget(int InfantryBudget, int AviationBudget, int RokcetBudget, float Booty)
        {
            Booty = ArmyResp.MakeBooty(0.05f, 0.021f, 0.014f, 1000);
            int ArmyBudget = (int)(InfantryBudget + AviationBudget + RokcetBudget + Booty);
            return ArmyBudget;
        }

        public void MilitaryAid(int LossesOfInfantry, int RespInfantry, int LossesOfAviation, int RespAviation, int LossesOfRocket, int RespRocket)
        {
            if (LossesOfInfantry > 0.2 * RespInfantry & LossesOfAviation > 0.25 * RespAviation & LossesOfRocket > 0.3 * RespRocket)
            {
                EnterInfantry();
            }
        }
        public void EnterInfantry()
        {
            int AidInfantry = 1000;
            Console.WriteLine("Allies entered to Respublica " + AidInfantry + "soldiers.");
        }
        void IAllies.FinancialAssistance(int RespArmyBudget, int BudgetOfResp, int FinancialAid)
        {
            if(RespArmyBudget > 0.2 * BudgetOfResp)
            {
                FinancialAid = (int)(RespArmyBudget * 1.5);
                Console.WriteLine("the financial aid of the Allies is " + FinancialAid);
            }
        }
        void IAllies.MedicalAid(int NumberOfBeds, int LossesOfInfantry, int LossesOfAviation, int LossesOfRocket, int NumberOfWounded)
        {
            if  (NumberOfWounded > NumberOfBeds)
            {
                NumberOfWounded = LossesOfInfantry + (LossesOfAviation * 5) + (LossesOfRocket * 3);
                Console.WriteLine("To receive such a number of wounded " + (NumberOfWounded - NumberOfBeds));
            }
        }

    }
}
