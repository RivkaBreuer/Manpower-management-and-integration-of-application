using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        public string Id { get; set; }
        public bool IsCompany { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string CompanyName { get; set; } 
        public string PhoneNum { get; set; }      
        public string Address { get; set; } 
        public DateTime DateEstablishment { get; set; } 
        public FieldName Field { get; set; } 

        public override string ToString() 
        {
            string str = string.Format(" \nLast Name: {0} \nFirst Name: {1} \nId: {2} \nIs Company: {3} \nCompany Name: {4} \nPhoneNum: {5} \nAddress: {6} \nDate Establishment: {7}"
                , LastName, FirstName, Id, IsCompany, CompanyName, PhoneNum, Address, DateEstablishment);
            return str;
        }
    }
}
