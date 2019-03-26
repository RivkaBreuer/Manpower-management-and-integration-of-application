using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    public class Specialization
    {

        public int SpecialNum { get; set; }
        public FieldName Field { get; set; } 
        public string SpecializationName { get; set; }
        public double TariffMin { get; set; }
        public double TariffMax { get; set; }


        public override string ToString() 
        {
            string str = string.Format("\nSpecial Num: {0} \nField Name: {1} \nSpecialization Name: {2} \nTariffMin: {3}  \nTariffMax: {4}",
                SpecialNum, Field, SpecializationName, TariffMin, TariffMax);
            return str;
        }

    }

}
