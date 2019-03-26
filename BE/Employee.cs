using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public Degree degreeType { get; set; }
        public bool GraduateArmy { get; set; }
        public BankAccount MyAccount { get; set; }
        public int Special { get; set; }

        private string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }
        public Employee()
        {
            imageSource = (@"Empty Image");

        }


        public override string ToString()
        {
            string str = string.Format(" \nLast Name: {0} \nFirst Name: {1}  \nId: {2} \nDegree: {3} \nSpecialization number: {4}", LastName, FirstName, Id, degreeType, Special);
            return str;
        }

    }


}
