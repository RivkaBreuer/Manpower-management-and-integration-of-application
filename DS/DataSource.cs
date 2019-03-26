using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Specialization> specialList= new List<Specialization>();
        public static List<Employee> employeeList= new List<Employee>();
        public static List<Employer> employerList= new List<Employer>();
        public static List<Contract> contractList= new List<Contract>();
        public static List<BankAccount> BankList = new List<BankAccount>
        {
            new BankAccount {AccountNo=1, BankName="A", BankNo=1, BranchAdd="A", BranchCity="A", BranchNo=1},
            new BankAccount {AccountNo=2, BankName="B", BankNo=2, BranchAdd="B", BranchCity="B", BranchNo=2},
            new BankAccount {AccountNo=4652357, BankName="Poalim", BankNo=12, BranchAdd="Malachi 7", BranchCity="Jerusalem", BranchNo=639},
            new BankAccount {AccountNo=1645823, BankName="Marcentil", BankNo=18, BranchAdd="Neshrim 22", BranchCity="Jerusalem", BranchNo=553},
            new BankAccount {AccountNo=1645823, BankName="Pagi", BankNo=14, BranchAdd="Shamgar 34", BranchCity="Jerusalem", BranchNo=479}
        };


    }
}
