using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSpacer.Models
{
    public class SpacerCard
    {
        public int ID { get; set; }
        public Int32 HorizontalGearCaseDeviation { get; set; }
        public Int32 HorizontalCarrierDeviation { get; set; }
        public Int32 Bearing { get; set; }
        public Single HMDGear { get; set; }
        public Int32 VerticalGearCaseDeviation { get; set; }
        public Int32 VerticalCarrierDeviation { get; set; }
        public Single GearMount { get; set; }
        public Single VMDGear { get; set; }
        public string DriveNumber { get; set; }
        public Int32 OperatorID { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public Single Backlash { get; set; }
        public Single HorizontalSetting { get; set; } = 0;
        public Single OutputSetting { get; set; } = 0;
        public string HelicalGearNumber { get; set; }
        public string HelicalPinionNumber { get; set; }
        public string HorizontalSpacerLength { get; set; }
        public string VerticalSpacerLength { get; set; }

        public static string GetHorizontalSpacerLength(int Model, int HorizontalGearCaseDeviation, int HorizontalCarrierDeviation, int Bearing, float HMDGear)
        {
            string HorizontalSpacerLength = "";

            return HorizontalSpacerLength;
        }


        public static string GetVerticalSpacerLength(int Model, int VerticalGearCaseDeviation, int VerticalCarrierDeviation, float VMDGear, float GearMount)
        {
            string VerticalSpacerLength = "";

            return VerticalSpacerLength;
        }
        
        public static int ModelToInt(string Model)
        {
            int Convert = 0;

            return Convert;
        }

        //public string Size { get; set; }
        //public string Ratio { get; set; }

        //public string GearNumber { get; set; }
        //public string IntermediateSetting { get; set; }



    }
}
