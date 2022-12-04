using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    internal class Imperia : IAllies
    {
        private int Budget;
        public int ImpArmyBudget = 1000;
        private int Resource = 100;
        private int Industry = 75; // = + 100 budget in year and - 50 resourse
        private int Army = 100000;

        public Imperia(int Budget, int ImpArmyBudget, int Resourse, int Industry, int Army) 
        {
            this.Budget = Budget;
            this.Army = Army;
            this.Resource = Resourse;
            this.Industry = Industry;
            this.ImpArmyBudget = ImpArmyBudget;
            
        }

        public static int MakeBudget(int Industry, int Resourse)
        {
            int Budget = Industry * Resourse;
            return Budget; // If (Respublica.Budget > Imperia.Budget) { AttacRespublica();}
        }

        public static int MakeArmyBudget(int InfantryBudget, int AviationBudget, int RokcetBudget, int FleetBudget, float Booty)
        {
            int ArmyBudget = (int)(InfantryBudget + AviationBudget + RokcetBudget + FleetBudget + Booty);
            return ArmyBudget;
        }

        void IAllies.MilitaryAid(int LossesOfInfantry, int RespInfantry, int LossesOfAviation, int RespAviation, int LossesOfRocket, int RespRocket)  // Військова допомога
        {
            
        }
            
        void IAllies.FinancialAssistance(int RespArmyBudget, int BudgetOfResp, int FinancialAid)
        {

        }
        void IAllies.MedicalAid(int NumberOfBeds, int LossesOfInfantry, int LossesOfAviation, int LossesOfRocket, int NumberOfWounded)  // Медична допомога
        {
            
        }
             
        void IAllies.EnterInfantry()
        {

        }

    }
}
