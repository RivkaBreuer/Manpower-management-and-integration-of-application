using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public interface IBL 
    {
        void AddSpecialization(Specialization s);
        void RemoveSpecialization(int id);
        void UpdateSpecialization(Specializat
            ion s);
        IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicate = null);

        void AddEmployee(Employee e);
        void RemoveEmployee(string id);
        void UpdateEmployee(Employee e);
        IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null);

        void AddEmployer(Employer e);
        void RemoveEmployer(string id);
        void UpdateEmployer(Employer e);
        IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null);

        void AddContract(Contract c);
        void RemoveContract(int contractNum);
        void UpdateContract(Contract c);
        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null);

        IEnumerable<BankAccount> GetAllBankAccount(Func<BankAccount, bool> predicate = null);
    }
}
