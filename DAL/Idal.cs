using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface Idal

    {
        void AddSpecialization(Specialization s);
        void RemoveSpecialization(int id);
        void UpdateSpecialization(Specialization s);
        Specialization GetSpecialization(int num);
        IEnumerable<Specialization> GetAllSpecialization (Func<Specialization, bool> predicate = null);

        void AddEmployee(Employee e);
        void RemoveEmployee(string id);
        void UpdateEmployee(Employee e);
        Employee GetEmployee(string id);
        IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null);

        void AddEmployer(Employer e);
        void RemoveEmployer(string id);
        void UpdateEmployer(Employer e);
        Employer GetEmployer(string id);
        IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null);

        void AddContract(Contract c);
        void RemoveContract(int contractNum);
        void UpdateContract(Contract c);
        Contract GetContract(int num);
        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null);

        IEnumerable<BankAccount> GetAllBankAccount(Func<BankAccount, bool> predicate = null);
        IEnumerable<IGrouping<string, BankAccount>> GetAllAtmGroupByBank();
        string GetBankNames(int num);
        IEnumerable<IGrouping<int, BankAccount>> GetAllBrunchOfBank(int bankNo);
        string GetBranchName(int BranchNo, int BankNo);
        string GetBranchCity(int BranchNo, int BankNo);

        bool checkfinish();
       







    }
}
