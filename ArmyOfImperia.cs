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
        public const float InfantryBootyCoef = 0.06f;
        public const float InfantryCoef = 0.15f;
        public int LossesOfInfantryImp = 0;


        public int ImpAviation = 780;
        public static int AviationBudget = 400;
        public const float AviationBootyCoef = 0.032f;
        public const float AviationCoef = 0.27f;
        public int LossesOfAviationImp = 0;

        public int ImpRocket = 9000;
        private static int RocketBudget = 600;
        public const float RocketBootyCoef = 0.0245f;
        private const float RocketCoef = 0.47f;
        public int LossesOfRocketImp = 0;

        public int ImpFleet = 1000; //Флот
        private static int FleetBudget = 600;
        public const float FleetBootyCoef = 0.057f;
        public const float FleetCoef = 0.3f;
        public float BootyImp;
        public int LossesOfFleetImp = 0;

        public ArmyOfImperia(int budget, int armyBudget, int resourse, int industry, int army, int ImpInfantry, int ImpAviation, int ImpRocket, int ImpFleet) : base(budget, armyBudget, resourse, industry, army)
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
        public int MakeRocket(int RocketBudget, int RocketCoef)
        {
            int Rocket = RocketBudget * RocketCoef;
            Rocket += Rocket;
            return Rocket;
        }
        public int MakeFleet(int FleetBudget, int FleetCoef)
        {
            int Fleet = FleetBudget * FleetCoef;
            Fleet += FleetCoef;
            return Fleet;
        }
        public static float MakeBooty(float InfantryBootyCoef, float AviationBootyCoef, float RocketBootyCoef, float FleetBootyCoef, int RespArmyBudget) // Трофеї
        {
            float BootyImp = (InfantryBootyCoef + AviationBootyCoef + RocketBootyCoef + FleetBootyCoef) * RespArmyBudget;
            return (float)BootyImp;
        }
    }
   
}
