using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    internal class ArmyOfImperia : Imperia
    {
        public int ImpInfantry = 90000; // Піхота
        public static int InfantryBudget = 500;  // Бюджет піхоти
        public const float InfantryBootyCoefImp = 0.06f;
        public const float InfantryCoef = 0.15f;
        public int LossesOfInfantryImp = 0;


        public int ImpAviation = 780;
        public static int AviationBudget = 400;
        public const float AviationBootyCoefImp = 0.032f;
        public const float AviationCoef = 0.27f;
        public int LossesOfAviationImp = 0;

        public int ImpRocket = 9000;
        public static int RocketBudgetImp = 600;
        public const float RocketBootyCoefImp = 0.0245f;
        public const float RocketCoefImp = 0.47f;
        public int LossesOfRocketImp = 0;
        public int RocketImp;

        public int ImpFleet = 1000; //Флот
        public static int FleetBudget = 600;
        public const float FleetBootyCoefImp = 0.057f;
        public const float FleetCoef = 0.3f;
        public float BootyImp;
        public int LossesOfFleetImp = 0;

        public ArmyOfImperia(int BudgetImp, int ImpArmyBudget, int resourseImp, int industryImp, int army, int ImpInfantry, int ImpAviation, int ImpRocket, int ImpFleet) : base(BudgetImp, ImpArmyBudget, resourseImp, industryImp, army)
        {
            this.ImpInfantry = ImpInfantry;
            this.ImpAviation = ImpAviation;
            this.ImpRocket = ImpRocket;
            this.ImpFleet = ImpFleet;
        }
        public int RecruitSoldier(int Infantrybudget, float InfantryCoef)
        {
            int infantry = Infantrybudget * (int)InfantryCoef;
            infantry += infantry;
            return infantry;
        }
        public int MakeAviation(int AviationBudget, int AviationCoef)
        {
            int Aviation = AviationBudget * AviationCoef;
            Aviation += Aviation;
            return Aviation;
        }
        public static int MakeRocketImp(int RocketBudgetImp, float RocketCoefImp)
        {
            int RocketImp = (int)(RocketBudgetImp * RocketCoefImp);
           
            return RocketImp;
        }
        public int MakeFleet(int FleetBudget, int FleetCoef)
        {
            int Fleet = FleetBudget * FleetCoef;
            Fleet += FleetCoef;
            return Fleet;
        }
        public static float MakeBooty(float InfantryBootyCoefImp, float AviationBootyCoefImp, float RocketBootyCoefImp, float FleetBootyCoefImp, int RespArmyBudget) // Трофеї
        {
            float BootyImp = (InfantryBootyCoefImp + AviationBootyCoefImp + RocketBootyCoefImp + FleetBootyCoefImp) * RespArmyBudget;
            return (float)BootyImp;
        }
    }
   
}
