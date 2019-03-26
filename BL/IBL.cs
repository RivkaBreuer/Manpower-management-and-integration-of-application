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
        /// <summary>
        /// Add Specialization
        /// </summary>
        /// <param name="s"></Specialization>
        void AddSpecialization(Specialization s);

        /// <summary>
        /// remove Specialization
        /// </summary>
        /// <param name="id"></id of the Specialization>
        void RemoveSpecialization(int id);

        /// <summary>
        /// update Specialization
        /// </summary>
        /// <param name="s"></Specialization>
        void UpdateSpecialization(Specialization s);

        /// <summary>
        /// return specific Specialization
        /// </summary>
        /// <param name="num"></SpecializationNumber>
        /// <returns></Specialization>
        Specialization GetSpecialization(int num);

        /// <summary>
        /// return All The Specialization
        /// </summary>
        /// <param name="predicate"></func>
        /// <returns></IEnumerable<Specialization>>
        IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicate = null);

        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="e"></Employee>
        void AddEmployee(Employee e);

        /// <summary>
        /// Remove Employee
        /// </summary>
        /// <param name="id"></emplotee id>
        void RemoveEmployee(string id);

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="e"></Employee>
        void UpdateEmployee(Employee e);

        /// <summary>
        /// return specific employee
        /// </summary>
        /// <param name="id"></employeeId>
        /// <returns></employee>
        Employee GetEmployee(string id);

        /// <summary>
        /// return All The Employees
        /// </summary>
        /// <param name="predicate"></func>
        /// <returns></IEnumerable<Employee>>
        IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null);

        /// <summary>
        /// Add Employer
        /// </summary>
        /// <param name="e"></Employer>
        void AddEmployer(Employer e);

        /// <summary>
        /// Remove Employer
        /// </summary>
        /// <param name="id"></employer id>
        void RemoveEmployer(string id);

        /// <summary>
        ///  Update Employer
        /// </summary>
        /// <param name="e"></Employer>
        void UpdateEmployer(Employer e);

        /// <summary>
        /// return specific employer
        /// </summary>
        /// <param name="id"></employerId>
        /// <returns></employer>
        Employer GetEmployer(string id);


        /// <summary>
        /// return All The Employers
        /// </summary>
        /// <param name="predicate"></func>
        /// <returns></IEnumerable<Employer>>
        IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null);

        /// <summary>
        /// Add Contract
        /// </summary>
        /// <param name="c"></Contract>
        void AddContract(Contract c);

        /// <summary>
        /// Remove Contract
        /// </summary>
        /// <param name="contractNum"></num of contract>
        void RemoveContract(int contractNum);

        /// <summary>
        /// update Contract
        /// </summary>
        /// <param name="c"></Contract>
        void UpdateContract(Contract c);

        /// <summary>
        /// return specific contract
        /// </summary>
        /// <param name="num"></numOfContract>
        /// <returns></contract>
        Contract GetContract(int num);
        
        /// <summary>
        /// return All The Contracts
        /// </summary>
        /// <param name="predicate"></func>
        /// <returns></ IEnumerable<Contract>>
        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null);

        /// <summary>
        /// return All The Bank Accounts
        /// </summary>
        /// <param name="predicate"></func>
        /// <returns></ IEnumerable<BankAccount>>
      //  IEnumerable<BankAccount> GetAllBankAccount(Func<BankAccount, bool> predicate = null);

        /// <summary>
        /// return Contracts Grouping By Specialization
        /// </summary>
        /// <param name="b"></if return than by order>
        /// <returns></ IEnumerable<IGrouping<int, Contract>>>
        IEnumerable<IGrouping<int, Contract>> GroupingBySpecial(bool b = false);

        /// <summary>
        /// return Contractes Grouping By Address
        /// </summary>
        /// <param name="b"></if return than by order>
        /// <returns></ IEnumerable<IGrouping<string, Contract>>>
        IEnumerable<IGrouping<string, Contract>> GroupingByAddress(bool b = false);

        /// <summary>
        /// return employees that graduateArmy
        /// </summary>
        /// <returns></IEnumerable<Employee>>
        IEnumerable<IGrouping<bool, Employee>> IsArmy();

        /// <summary>
        /// present for a birthday
        /// </summary>
        /// <returns></ IEnumerable<IGrouping<int, Employee>>>
        IEnumerable<IGrouping<int, Employee>> present();

        /// <summary>
        /// grouping special order by  degree
        /// </summary>
        /// <returns></<IGrouping<string, Employee>>>
        IEnumerable<IGrouping<string, Employee>> groupingSpecailOrderByDegree();

        /// <summary>
        /// if Date End Employing passed
        /// </summary>
        void invalidContract();

        /// <summary>
        /// after Retirement age stop working
        /// </summary>
        void retirement();

        /// <summary>
        /// A bonus to an employee who works more than full time
        /// </summary>
        /// <typeparam name="Contract"></typeparam>
       void  bonus();

        /// <summary>
        /// grouping earn order by  years
        /// </summary>
        /// <returns></<IGrouping<years,salary>>>
        IEnumerable<IGrouping<int, double>> gruopingEarnByYears();

        /// <summary>
        /// check if the char is letter or not
        /// </summary>
        /// <param name="str"></text>
        /// <returns></trueORfalse>
         bool IsLetters(string str);

        /// <summary>
        /// Get All Atm Group By Bank name
        /// </summary>
        /// <returns></IGrouping<bankname, BankAccount>>
        IEnumerable<IGrouping<string, BankAccount>> GetAllAtmGroupByBank();

        /// <summary>
        /// get bank name by bank number
        /// </summary>
        /// <param name="num"></bankNo>
        /// <returns></bankName>
        string GetBankNames(int num);

        /// <summary>
        /// Get All Brunch Of specipic bank
        /// </summary>
        /// <param name="bankNo"></bankNumber>
        /// <returns></IGrouping<branchNumber, BankAccount>>
        IEnumerable<IGrouping<int, BankAccount>> GetAllBrunchOfBank(int bankNo);

        /// <summary>
        /// Get Branch Name
        /// </summary>
        /// <param name="BranchNo"></BranchNunmber>
        /// <param name="BankNo"></BankNumber>
        /// <returns></BranchName>
        string GetBranchName(int BranchNo, int BankNo);

        /// <summary>
        /// Get Branch City
        /// </summary>
        /// <param name="BranchNo"></BranchNunmber>
        /// <param name="BankNo"></BankNumber>
        /// <returns></BranchCity>
        string GetBranchCity(int BranchNo, int BankNo);

        /// <summary>
        /// chech if the thread finished
        /// </summary>
        /// <returns></bool>
        bool checkfinish();


    }
}
