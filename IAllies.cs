using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    interface IAllies
    {
        void MilitaryAid(int LossesOfInfantry, int RespInfantry, int LossesOfAviation, int RespAviation, int LossesOfRocket, int RespRocket); // Військова допомога
        void FinancialAssistance(int RespArmyBudget, int BudgetOfResp, int FinancialAid);
        void MedicalAid(int NumberOfBeds, int LossesOfInfantry, int LossesOfAviation, int LossesOfRocket, int NumberOfWounded); // Медична допомога
        void EnterInfantry();
        
    }
}
