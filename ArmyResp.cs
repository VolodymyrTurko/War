using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using War.Models;

namespace War.Models
{
    internal class ArmyResp : Respublica
    {
        public static int RespInfantry = 25000; // Піхота
        public static int InfantryBudget = 50;  // Бюджет піхоти
        public const float InfantryBootyCoef = 0.05f; // Коефіцієнт трофеїв
        public const float InfantryCoef = 0.1f;
        public int LossesOfInfantry = 0;


        public static int RespAviation = 120;
        public static int AviationBudget = 50;
        public const float AviationBootyCoef = 0.021f;
        public const float AviationCoef = 0.3f;
        public int LossesOfAviation = 0; // втрати піхоти
        
        public static int RespRocket = 1000;
        private static int RocketBudget = 40;
        public const float RocketBootyCoef = 0.014f;
        private const float RocketCoef = 0.4f;
        public int LossesOfRocket = 0; // до втрат ракет входить число запущених ракет по ворогу і знищені під час ворожої атаки ракетні сис 
       
        public static int MissileSalvo;
        public static int MissileSalvoA;
        public  static int MissileSalvoR;
        public static int MissileSalvoF;
        public float Booty;
        public int Rocket;
        public ArmyResp(int armybudget, int resource, int industry, int army, int respinfantry, int respaviation, int resprocket) : base(armybudget, resource, industry, army)
        {
            RespInfantry = respinfantry;
            RespAviation = respaviation;
            RespRocket = resprocket;
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
        public static int MakeRocket(int RocketBudget, int RocketCoef)
        {          
            int Rocket = RocketBudget * RocketCoef;
            Rocket += Rocket - MissileSalvo - MissileSalvoA - MissileSalvoR - MissileSalvoF;
            return Rocket;
        }
       
        public static float MakeBooty(float InfantryBootyCoef, float AviationBootyCoef, float RocketBootyCoef, int ImpArmyBudget) // Трофеї
        {
            float Booty = (InfantryBootyCoef + AviationBootyCoef + RocketBootyCoef) * (float)ImpArmyBudget;
            return (float)Booty;
        }
        
    }
}
