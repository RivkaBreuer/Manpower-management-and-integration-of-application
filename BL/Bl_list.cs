using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    class Bl_list : IBL
    {
        DAL.Idal dal;
        

        public Bl_list()
        {
            dal = DAL.FactoryDal.GetDal();
        }

        #region Contract Function

        public void AddContract(Contract c)
        {
            
           bool erId = GetAllEmployer().Any(er => er.Id == c.EmployerId);
           if (erId == false)
                throw new Exception("The employer is not in the list");
             bool eeId = GetAllEmployee().Any(ee => ee.Id == c.EmployeeId);
           if (eeId == false)
                throw new Exception("The employee is not in the list");

            foreach (var item in GetAllEmployer())
                if (item.Id == c.EmployerId)
                    if (item.DateEstablishment > DateTime.Now.AddYears(-1))
                        throw new Exception("Unable to sign a contract with a new friend who is less than a year");

           

            int countEe = 1;
            foreach ( var item in GetAllContract())
                if (c.EmployeeId == item.EmployeeId)
                    countEe++;
            int countEr = 1;
            foreach (var item in GetAllContract())
                if (c.EmployerId == item.EmployerId)
                    countEr++;

            c.HourSalaryN = (c.HourSalaryG) * (100-amla(countEe, countEr))/100;

            if (c.DateBegingEmployin >= c.DateEndEmploying)
                throw new Exception("Date Beging must be before Date End");
            if (c.HoursNum > 240)
                throw new Exception("You can work over 240 monthly hours");
            dal.AddContract(c);
        }

        private double amla(int ee, int er)
        {
            if (10.0/ee + 8/er > 16)
                return 2.0;
            return (10.0/ee + 8/er);
        }

        public void RemoveContract(int contractNum)
        {
           
            dal.RemoveContract(contractNum);
        }

        public void UpdateContract(Contract c)
        {
            bool erId = GetAllEmployer().Any(er => er.Id == c.EmployerId);
            if (erId == false)
                throw new Exception("The employer is not in the list");
            bool eeId = GetAllEmployee().Any(ee => ee.Id == c.EmployeeId);
            if (eeId == false)
                throw new Exception("The employee is not in the list");

            foreach (var item in GetAllEmployer())
                if (item.Id == c.EmployerId)
                    if (item.DateEstablishment > DateTime.Now.AddYears(-1))
                        throw new Exception("Unable to sign a contract with a new friend who is less than a year");


            int countEe = 0;
            foreach (var item in GetAllContract())
                if (c.EmployeeId == item.EmployeeId)
                    countEe++;
            int countEr = 0;
            foreach (var item in GetAllContract())
                if (c.EmployerId == item.EmployerId)
                    countEr++;
            c.HourSalaryN = (c.HourSalaryG) * (100 - amla(countEe, countEr)) / 100;
            if (c.HoursNum > 240)
                throw new Exception("You can work over 240 monthly hours");
            dal.UpdateContract(c);
        }

        public Contract GetContract(int num)
        {
            return dal.GetContract(num);
        }

        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
       {
            return dal.GetAllContract();
        }

        public int GetNumContract(Func<Contract, bool> predicate = null)
        {
            int count = 0;
            var v = from item in dal.GetAllContract()
                    where predicate != null
                    select item;
            foreach (var item1 in v)
                count++;
            return count;
                
                    
        }

        #endregion

        #region Employee Function

        public void AddEmployee(Employee e)
        {
            DateTime d = DateTime.Now.AddYears(-18);
            if (d <= e.DateBirth.Date)
                throw new Exception("A professional must be over the age of 18");

            dal.AddEmployee(e);
        }

        public void RemoveEmployee(string id)
        {
            dal.RemoveEmployee(id);
        }

        public void UpdateEmployee(Employee e)
        {
            DateTime d = DateTime.Now.AddYears(-18);
            if (d <= e.DateBirth.Date)
                throw new Exception("A professional must be over the age of 18");

            
            dal.UpdateEmployee(e);
        }

        public Employee GetEmployee(string id)
        {
            return dal.GetEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null)
        {
            return dal.GetAllEmployee();
        }

        #endregion

        #region Employer Function

        public void AddEmployer(Employer e)
        {
            if (DateTime.Now < e.DateEstablishment)
                throw new Exception("The date specified is invalid!");
            dal.AddEmployer(e);
        }

        public void RemoveEmployer(string id)
        {
            dal.RemoveEmployer(id);
        }

        public void UpdateEmployer(Employer e)
        {
            if (DateTime.Now < e.DateEstablishment)
                throw new Exception("The date specified is invalid!");
            dal.UpdateEmployer(e);
        }

        public Employer GetEmployer(string id)
        {
            return dal.GetEmployer(id);
        }

        public IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null)
        {
            return dal.GetAllEmployer();
        }

        #endregion

        #region Specialization Function

        public void AddSpecialization(Specialization s)
        {
            if (s.TariffMin < 26.88 || s.TariffMax < 26.88)
                throw new Exception("Min / Max rate cannot be less than minimum wage");
            if (s.TariffMin > s.TariffMax)
                throw new Exception("Minimum rate cannot be less maximum rate");
            dal.AddSpecialization(s);
        }

        public void RemoveSpecialization(int id)
        {
            //var v = from item in GetAllEmployee()
            //        where item.Special == id
            //        select item;
            //if (v.Count() != 0)
            //    throw new Exception("You cannot delete long existing expertise works specializes in it");
            
            dal.RemoveSpecialization(id);
        }

        public void UpdateSpecialization(Specialization s )
        {
            if (s.TariffMin < 26.88 || s.TariffMax < 26.88)
                throw new Exception("Min / Max rate cannot be less than minimum wage");
            if (s.TariffMin > s.TariffMax)
                throw new Exception("Minimum rate cannot be less maximum rate");
            dal.UpdateSpecialization(s);
        }

        public Specialization GetSpecialization(int num)
        {
            return dal.GetSpecialization(num);
        }

        public IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicate = null)
        {
            return dal.GetAllSpecialization();
        }
        #endregion

        #region another function
        public IEnumerable<IGrouping<int, Contract>> GroupingBySpecial(bool b = false)
        {
           
            var v = from item in dal.GetAllContract()
                    from item1 in dal.GetAllEmployee()
                    where item1.Id == item.EmployeeId
                    group item by item1.Special;

                    if(b==true)
                        {
                            v.OrderBy(c => c.Key);
                        }
            return v;    
                 
        }

        public IEnumerable<IGrouping<string, Contract>> GroupingByAddress(bool b = false)
        {

            var v = from item in GetAllContract()
                    from item1 in GetAllEmployee()
                    where item1.Id == item.EmployeeId
                    group item by item1.Address;

            if (b == true)
            {
                v.OrderBy(c => c.Key);
            }
            return v;

        }

        public IEnumerable<IGrouping<bool, Employee>> IsArmy()

        {

            var v = from item in GetAllEmployee()
                    where item.GraduateArmy == true
                    group item by item.GraduateArmy;

            return v;
        }

        public IEnumerable<IGrouping<int, Employee>> present() 
        {
            var v = from item in GetAllEmployee()
                    group item by item.DateBirth.Month;

            return v;
        }

        public IEnumerable<IGrouping<string,Employee>> groupingSpecailOrderByDegree()   
        {
            var v = from item in GetAllSpecialization()
                    from item1 in GetAllEmployee()
                    where item.SpecialNum == item1.Special
                    orderby  item1.degreeType
                    group item1 by item.SpecializationName;
            
            return v;
            

        }

        public void invalidContract() 
        {
            DateTime d = DateTime.Now;


                foreach (var item in GetAllContract())
                if (item.DateEndEmploying < d)
                  RemoveContract(item.ContractNum);
           

        }

        public void retirement()
        {
            var v = from item in GetAllEmployee()
                    where (DateTime.Now.AddYears(-65) >= item.DateBirth)
                    select new { Id = item.Id };
            int i;
            for (i = 0; i < v.Count(); i++)
                RemoveEmployee(v.First().Id);


         
        }

        public void bonus()  
        {
            foreach (var item in GetAllContract())
            {
                if (item.HoursNum > 180)
                {
                    item.HourSalaryG = item.HourSalaryG * 1.06;
                    item.HourSalaryN = item.HourSalaryN * 1.06;
                }
                UpdateContract(item);
            }


        }
        
        public IEnumerable<IGrouping<int,double>> gruopingEarnByYears()
        {
            var v = from item in GetAllContract()
                    let earn = ((item.HourSalaryG - item.HourSalaryN) * item.HoursNum) * 12
                    group earn by item.DateBegingEmployin.Year;
            return v;
        }

        public bool IsLetters(string str)
        {
            foreach (char c in str)
            {
                if ((c <= 'z' && c >= 'a') || (c <= 'Z' && c >= 'A'))
                    return true;
            }

            return false;
        }
        #endregion

        #region banks function
        public IEnumerable<IGrouping<string, BankAccount>> GetAllAtmGroupByBank()
        {
            return dal.GetAllAtmGroupByBank();
        }

        public string GetBankNames(int num)
        {
            return dal.GetBankNames(num);
        }

        public IEnumerable<IGrouping<int, BankAccount>> GetAllBrunchOfBank(int bankNo)
        {
            return dal.GetAllBrunchOfBank(bankNo);
        }

        public string GetBranchName(int BranchNo, int BankNo)
        {
            return dal.GetBranchName(BranchNo, BankNo);
        }

        public string GetBranchCity(int BranchNo, int BankNo)
        {
            return dal.GetBranchCity(BranchNo, BankNo);
        }

        public bool checkfinish()
        {
            return dal.checkfinish();
        }
        #endregion
    }
}



  
