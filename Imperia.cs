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
        public int BudgetImp;
        public int ImpArmyBudget = 1001;
        public int ResourceImp = 700;
        public int IndustryImp = 560; // = + 100 budget in year and - 50 resourse
        public int Army = 100000;

        public Imperia(int BudgetImp, int ImpArmyBudget, int ResourseImp, int IndustryImp, int Army) 
        {
            this.BudgetImp = BudgetImp;
            this.Army = Army;
            this.ResourceImp = ResourseImp;
            this.IndustryImp = IndustryImp;
            this.ImpArmyBudget = ImpArmyBudget;
            
        }

        public static int MakeBudget(int IndustryImp, int ResourseImp)
        {
            int BudgetImp = IndustryImp * ResourseImp;
            return BudgetImp; // If (Respublica.BudgetImp > Imperia.BudgetImp) { AttacRespublica();}
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
