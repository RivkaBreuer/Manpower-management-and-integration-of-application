using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    internal class Dal_list 
    {

        private static int number_s = 20000000;
        private static int number_c = 10000000;

        #region Specialization Funcion

        public void AddSpecialization(Specialization s)
        {
            Specialization sp = GetSpecialization(s.SpecialNum);
            if (sp != null)
                throw new Exception("Specialization with the same number already exists");
            s.SpecialNum = number_s++;
            DS.DataSource.specialList.Add(s);
        }

        public void RemoveSpecialization(int id)
        {
            Specialization sp = GetSpecialization(id);
            if (sp == null)
                throw new Exception("Specialization with the same num not found");
             DS.DataSource.employeeList.RemoveAll(e => e.Special == id);
            DS.DataSource.specialList.Remove(sp);
          
        }

        public void UpdateSpecialization(Specialization s)
        {
            int index = DS.DataSource.specialList.FindIndex(p => p.SpecialNum == s.SpecialNum);
            if (index == -1)
                throw new Exception("Specialization with the same number not found");
            #region update details
            DS.DataSource.specialList[index].Field = s.Field;
            DS.DataSource.specialList[index].Field = s.Field;
            DS.DataSource.specialList[index].SpecialNum = s.SpecialNum;
            DS.DataSource.specialList[index].TariffMax = s.TariffMax;
            DS.DataSource.specialList[index].TariffMin = s.TariffMin;
            #endregion
        }

        public Specialization GetSpecialization (int num)
        {
            return DS.DataSource.specialList.FirstOrDefault(s => s.SpecialNum == num);
        }

        public IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicate = null)
        {
            if (predicate == null)
                return DS.DataSource.specialList.AsEnumerable();
            var v = from item in DS.DataSource.specialList
                    where predicate != null
                    select item;
                    return v;
           
            //return DS.DataSource.specialList.Where(predicate);
        }

        #endregion


        #region contract Function


        public void AddContract(Contract c)
        {
            Contract con = GetContract(c.ContractNum);
            if (con != null)
                throw new Exception("Contract with the same number already exists");
            c.ContractNum = number_c++;
            DS.DataSource.contractList.Add(c);
        }

        public void RemoveContract(int contractNum)
        {
            Contract con = GetContract(contractNum);
            if (con == null)
                throw new Exception("Contract with the same num not found");
            DS.DataSource.contractList.Remove(con);
        }

        public void UpdateContract(Contract c)
        {
            int index = DS.DataSource.contractList.FindIndex(co => co.ContractNum == c.ContractNum);
            if (index == -1)
                throw new Exception("contract with the same number not found");
            #region updeate detaild
            DS.DataSource.contractList[index].ContractNum = c.ContractNum;
            DS.DataSource.contractList[index].DateBegingEmployin = c.DateBegingEmployin;
            DS.DataSource.contractList[index].DateEndEmploying = c.DateEndEmploying;
            DS.DataSource.contractList[index].EmployeeId = c.EmployeeId;
            DS.DataSource.contractList[index].EmployerId = c.EmployerId;
            DS.DataSource.contractList[index].HourSalaryG = c.HourSalaryG;
            DS.DataSource.contractList[index].HourSalaryN = c.HourSalaryN;
            DS.DataSource.contractList[index].IsInterview = c.IsInterview;
            DS.DataSource.contractList[index].IsSign = c.IsSign;
            DS.DataSource.contractList[index].HoursNum = c.HoursNum;
            #endregion
                        
        }

        public Contract GetContract (int num)
        {
            return DS.DataSource.contractList.FirstOrDefault(c =>c.ContractNum == num);
        }

        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
        {
            if(predicate == null)
                return DS.DataSource.contractList.AsEnumerable();
            var v = from item in DS.DataSource.contractList
                    where predicate != null
                    select item;
            return v;
            //return DS.DataSource.contractList.Where(predicate);
        }

        #endregion


        #region Employee Function

        public void AddEmployee(Employee e)
        {
            Employee emp = GetEmployee(e.Id);
            if (emp != null)
                throw new Exception("Employee with the same Id already exists");
            DS.DataSource.employeeList.Add(e);
        }

        public void RemoveEmployee(string id)
        {
            Employee e = GetEmployee(id);
            if (e == null)
                throw new Exception("Employee with the same Id not found");
            DS.DataSource.contractList.RemoveAll(c => c.EmployeeId == id);
            DS.DataSource.employeeList.Remove(e);
        }

        public void UpdateEmployee(Employee e)
      {
            Employee emp = GetEmployee(e.Id);
            int index = DS.DataSource.employeeList.FindIndex(em=>em.Id==e.Id);
            if (index == -1)
              throw new Exception("Employee with the same Id not found");
              #region updeate details
              DS.DataSource.employeeList[index].Address = e.Address;
              DS.DataSource.employeeList[index].DateBirth = e.DateBirth;
              DS.DataSource.employeeList[index].degreeType = e.degreeType;
              DS.DataSource.employeeList[index].FirstName = e.FirstName;
              DS.DataSource.employeeList[index].GraduateArmy = e.GraduateArmy;
              DS.DataSource.employeeList[index].Id = e.Id;
              DS.DataSource.employeeList[index].LastName = e.LastName;
            //  DS.DataSource.employeeList[index].MyAccount = e.MyAccount;
              DS.DataSource.employeeList[index].PhoneNum = e.PhoneNum;
              DS.DataSource.employeeList[index].Special = e.Special;
              #endregion
            
        }

        public Employee GetEmployee (string id)
        {
            return DS.DataSource.employeeList.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null)
        {
            if (predicate == null)
                return DS.DataSource.employeeList.AsEnumerable();
            var v = from item in DS.DataSource.employeeList
                    where predicate != null
                    select item;
            return v;
            //return DS.DataSource.employeeList.Where(predicate);
        }

        #endregion


        #region Employer Function
        public void AddEmployer(Employer e)
        {
            Employer emp = GetEmployer(e.Id);
            if (emp != null)
                throw new Exception("Employer with the same Id already exists");
            DS.DataSource.employerList.Add(e);
        }

        public void RemoveEmployer(string id)
        {
            Employer e = GetEmployer(id);
            if (e == null)
                throw new Exception("Employer with the same Id not found");
            DS.DataSource.contractList.RemoveAll(c => c.EmployerId == id);
            DS.DataSource.employerList.Remove(e);
        }

        public void UpdateEmployer(Employer e)
        {
            int index = DS.DataSource.employerList.FindIndex(em => em.Id == e.Id);
            if (index == -1)
                throw new Exception("Employer with the same Id not found");
            #region update details
            DS.DataSource.employerList[index].Address = e.Address;
            DS.DataSource.employerList[index].CompanyName = e.CompanyName;
            DS.DataSource.employerList[index].DateEstablishment = e.DateEstablishment;
            DS.DataSource.employerList[index].Field = e.Field;
            DS.DataSource.employerList[index].FirstName = e.FirstName;
            DS.DataSource.employerList[index].Id = e.Id;
            DS.DataSource.employerList[index].IsCompany = e.IsCompany;
            DS.DataSource.employerList[index].LastName = e.LastName;
            DS.DataSource.employerList[index].PhoneNum = e.PhoneNum;
           
            #endregion
        }

        public Employer GetEmployer(string id)
        {
            return DS.DataSource.employerList.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null)
        {
            if(predicate == null)
                return DS.DataSource.employerList.AsEnumerable();
            var v = from item in DS.DataSource.employerList
                    where predicate != null
                    select item;
            return v;
           // return DS.DataSource.employerList.Where(predicate);
        }
        #endregion

       public IEnumerable<BankAccount> GetAllBankAccount(Func<BankAccount, bool> predicate = null)
        {
            if (predicate == null)
                return DS.DataSource.BankList.AsEnumerable();
            var v = from item in DS.DataSource.BankList
                    where predicate != null
                    select item;
            return v;

            //return DS.DataSource.specialList.Where(predicate); 


        }

    }
}
