using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;




namespace DAL
{

    class Dal_XML_imp : Idal
    {
        XElement specializationRoot;
        string specializationPath = @"specializationXml.xml";

        XElement contractRoot;
        string contractPath = @"contractXml.xml";

        XElement employeeRoot;
        string employeePath = @"employeeXml.xml";

        XElement employerRoot;
        string employerPath = @"employerXml.xml";

        XElement staticNumberRoot;
        string staticNumberPath = @"config.xml";
        
        const string xmlLocalPath = @"atm.xml";
        public static bool finish = false;


        public Dal_XML_imp()

        {
            Thread t = new Thread(DownloadAtmXml);
            t.Start();

            if (!File.Exists(specializationPath))
                CreateFiles(specializationRoot, specializationPath);
            else
                LoadDataSpecialization();

            if (!File.Exists(contractPath))
                CreateFiles(contractRoot, contractPath);
            else
                LoadDataContract();

            if (!File.Exists(employeePath))
                CreateFiles(employeeRoot, employeePath);
            else
                LoadDataEmployee();

            if (!File.Exists(employerPath))
                CreateFiles(employerRoot, employerPath);
            else
                LoadDataEmployer();

            if (!File.Exists(staticNumberPath))
                CreateFiles(staticNumberRoot, staticNumberPath);
            else
                LoadDataConfig();


        }

        private void CreateFiles(XElement x, string str)
        {
            x = new XElement(str);
            x.Save(str);

            if (str == staticNumberPath)
            {
                LoadDataConfig();

                XElement number_s = new XElement("specialization", 10000000);
                XElement number_c = new XElement("contract", 20000000);
                XElement staticNumber = new XElement("staticNumber", number_s, number_c);
                staticNumberRoot.Add(staticNumber);
                staticNumberRoot.Save(staticNumberPath);

            }
        }

        private static void DownloadAtmXml()
        {
            const string xmlLocalPath = @"atm.xml";
            WebClient wc = new WebClient();
            try
            {
                string xmlServerPath =
               @"http://www.boi.org.il/he/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/atm.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);
                finish = true;

            }
            catch (Exception)
            {
                string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";
                wc.DownloadFile(xmlServerPath, xmlLocalPath);
                finish = true;

            }
            finally
            {
                wc.Dispose();
            }
        }

        #region LoadData Function
        private void LoadDataSpecialization()
        {
            try
            {
                specializationRoot = XElement.Load(specializationPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        private void LoadDataContract()
        {
            try
            {
                contractRoot = XElement.Load(contractPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        private void LoadDataConfig()
        {
            try
            {
                staticNumberRoot = XElement.Load(staticNumberPath);

            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        private void LoadDataEmployee()
        {
            try
            {
                employeeRoot = XElement.Load(employeePath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        private void LoadDataEmployer()
        {
            try
            {
                employerRoot = XElement.Load(employerPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }

        #endregion

        #region Specialization Function

        public void AddSpecialization(Specialization specialization)
        {

            int num = int.Parse(staticNumberRoot.Element("staticNumber").Element("specialization").Value);
            num++;
            staticNumberRoot.Element("staticNumber").Element("specialization").Value = Convert.ToString(num);
            Specialization sp = GetSpecialization(num);
            if (sp != null)
                throw new Exception("Specialization with the same number already exists");
            staticNumberRoot.Save(staticNumberPath);
            specialization.SpecialNum = num;
            XElement Specialnum = new XElement("SpecialNum", num);
            XElement SpecializationName = new XElement("SpecializationName", specialization.SpecializationName);
            XElement Field = new XElement("Field", specialization.Field);
            XElement TariffMin = new XElement("TariffMin", specialization.TariffMin);
            XElement TariffMax = new XElement("TariffMax", specialization.TariffMax);
            XElement Tarif = new XElement("Tarif", TariffMin, TariffMax);

            specializationRoot.Add(new XElement("specialization", Specialnum, SpecializationName, Field, Tarif));
            specializationRoot.Save(specializationPath);
        }

        public void RemoveSpecialization(int num)
        {
            Specialization sp = GetSpecialization(num);
            if (sp == null)
                throw new Exception("Specialization with the same num not found");

            XElement specializationElement;
            try
            {
                specializationElement = (from p in specializationRoot.Elements()
                                         where Convert.ToInt32(p.Element("SpecialNum").Value) == num
                                         select p).FirstOrDefault();
                specializationElement.Remove();
                specializationRoot.Save(specializationPath);

            }
            catch
            {

            }

        }

        public void UpdateSpecialization(Specialization specialization)
        {

            LoadDataSpecialization();
            XElement specializationElement = (from p in specializationRoot.Elements()
                                              where Convert.ToInt32(p.Element("SpecialNum").Value) == specialization.SpecialNum
                                              select p).FirstOrDefault();
            specializationElement.Element("Field").Value = Convert.ToString(specialization.Field);
            specializationElement.Element("Tarif").Element("TariffMin").Value = Convert.ToString(specialization.TariffMin);
            specializationElement.Element("Tarif").Element("TariffMax").Value = Convert.ToString(specialization.TariffMax);
            specializationRoot.Save(specializationPath);
        }

        public Specialization GetSpecialization(int num)
        {
            LoadDataSpecialization();
            Specialization specialization;
            try
            {
                specialization = (from p in specializationRoot.Elements()
                                  where Convert.ToInt32(p.Element("SpecialNum").Value) == num
                                  select new Specialization()
                                  {
                                      SpecialNum = Convert.ToInt32(p.Element("SpecialNum").Value),
                                      SpecializationName = p.Element("SpecializationName").Value,
                                      Field = (FieldName)Enum.Parse(typeof(FieldName), (p.Element("Field").Value)),
                                      TariffMax = Convert.ToDouble(p.Element("Tarif").Element("TariffMax").Value),
                                      TariffMin = Convert.ToDouble(p.Element("Tarif").Element("TariffMin").Value)
                                  }).FirstOrDefault();
            }
            catch
            {
                specialization = null;
            }
            return specialization;
        }

        public IEnumerable<Specialization> GetAllSpecialization(Func<Specialization, bool> predicate = null)
        {
            {
                LoadDataSpecialization();
                List<Specialization> specializations;
                try
                {
                    specializations = (from p in specializationRoot.Elements()
                                       select new Specialization()
                                       {
                                           SpecialNum = Convert.ToInt32(p.Element("SpecialNum").Value),
                                           SpecializationName = p.Element("SpecializationName").Value,
                                           Field = (FieldName)Enum.Parse(typeof(FieldName), (p.Element("Field").Value)),
                                           TariffMax = Convert.ToDouble(p.Element("Tarif").Element("TariffMax").Value),
                                           TariffMin = Convert.ToDouble(p.Element("Tarif").Element("TariffMin").Value)
                                       }).ToList();
                }
                catch
                {
                    specializations = null;
                }
                return specializations;
            }

        }




        #endregion

        #region employee Function

        public void AddEmployee(Employee e)
        {
            Employee emp = GetEmployee(e.Id);
            if (emp != null)
                throw new Exception("Employee with the same Id already exists");

            XElement Id = new XElement("Id", e.Id);
            XElement FirstName = new XElement("FirstName", e.FirstName);
            XElement LastName = new XElement("LastName", e.LastName);
            XElement ImageSource = new XElement("ImageSource", e.ImageSource);
            XElement GraduateArmy = new XElement("GraduateArmy", e.GraduateArmy);
            XElement BankName = new XElement("BankName", e.MyAccount.BankName);
            XElement AccountNo = new XElement("AccountNo", e.MyAccount.AccountNo);
            XElement BankNo = new XElement("BankNo", e.MyAccount.BankNo);
            XElement BranchAdd = new XElement("BranchAdd", e.MyAccount.BranchAdd);
            XElement BranchCity = new XElement("BranchCity", e.MyAccount.BranchCity);
            XElement BranchNo = new XElement("BranchNo", e.MyAccount.BranchNo);
            XElement bank = new XElement("bank", AccountNo, BankName, BranchNo, BranchCity, BranchAdd, BankNo);
            XElement PhoneNum = new XElement("PhoneNum", e.PhoneNum);
            XElement Special = new XElement("Special", e.Special);
            XElement Address = new XElement("Address", e.Address);
            XElement DateBirth = new XElement("DateBirth", e.DateBirth);
            XElement degreeType = new XElement("degreeType", e.degreeType);


            employeeRoot.Add(new XElement("employee", Id, FirstName, LastName, ImageSource, GraduateArmy, bank, PhoneNum, Special, Address, DateBirth, degreeType));
            employeeRoot.Save(employeePath);
        }

        public void RemoveEmployee(string id)
        {
            XElement employeeElement;
            try
            {
                employeeElement = (from p in employeeRoot.Elements()
                                   where p.Element("Id").Value == id
                                   select p).FirstOrDefault();
                employeeElement.Remove();
                employeeRoot.Save(employeePath);

            }
            catch
            {

            }
        }

        public void UpdateEmployee(Employee e)
        {
            LoadDataEmployee();
            XElement employeeElement = (from p in employeeRoot.Elements()
                                        where p.Element("Id").Value == e.Id
                                        select p).FirstOrDefault();
            employeeElement.Element("Id").Value = (e.Id);
            employeeElement.Element("FirstName").Value = (e.FirstName);
            employeeElement.Element("LastName").Value = (e.LastName);
            employeeElement.Element("bank").Element("AccountNo").Value = Convert.ToString(e.MyAccount.AccountNo);
            employeeElement.Element("bank").Element("BankNo").Value = Convert.ToString(e.MyAccount.BankNo);
            employeeElement.Element("bank").Element("BranchNo").Value = Convert.ToString(e.MyAccount.BranchNo);
            employeeElement.Element("bank").Element("BankName").Value = (e.MyAccount.BankName);
            employeeElement.Element("bank").Element("BranchCity").Value = (e.MyAccount.BranchCity);
            employeeElement.Element("bank").Element("BranchAdd").Value = (e.MyAccount.BranchAdd);
            employeeElement.Element("DateBirth").Value = Convert.ToString(e.DateBirth);
            employeeElement.Element("PhoneNum").Value = (e.PhoneNum);
            employeeElement.Element("Address").Value = (e.Address);
            employeeElement.Element("GraduateArmy").Value = Convert.ToString(e.GraduateArmy);
            employeeElement.Element("ImageSource").Value = Convert.ToString(e.ImageSource);
            employeeElement.Element("degreeType").Value = Convert.ToString(e.degreeType);
            employeeElement.Element("Special").Value = Convert.ToString(e.Special);


            employeeElement.Save(employeePath);
            employeeRoot.Save(employeePath);
        }

        public Employee GetEmployee(string id)
        {
            {
                LoadDataEmployee();
                Employee employee;
                try
                {
                    employee = (from p in employeeRoot.Elements()
                                where p.Element("Id").Value == id
                                select new Employee()
                                {
                                    FirstName = p.Element("FirstName").Value,
                                    LastName = p.Element("LastName").Value,
                                    Address = p.Element("Address").Value,
                                    Special = Convert.ToInt32(p.Element("Special").Value),
                                    DateBirth = Convert.ToDateTime(p.Element("DateBirth").Value),
                                    degreeType = (Degree)Enum.Parse(typeof(Degree), (p.Element("degreeType").Value)),
                                    GraduateArmy = Convert.ToBoolean(p.Element("GraduateArmy").Value),
                                    ImageSource = p.Element("ImageSource").Value,
                                    MyAccount = new BankAccount
                                    {
                                        AccountNo = Convert.ToInt32(p.Element("bank").Element("AccountNo").Value),
                                        BankNo = Convert.ToInt32(p.Element("bank").Element("BankNo").Value),
                                        BranchNo = Convert.ToInt32(p.Element("bank").Element("BranchNo").Value),
                                        BranchAdd = (p.Element("bank").Element("BranchAdd").Value),
                                        BankName = (p.Element("bank").Element("BankName").Value),
                                        BranchCity = (p.Element("bank").Element("BranchCity").Value)

                                    },
                                    PhoneNum = p.Element("PhoneNum").Value,
                                    Id = p.Element("Id").Value

                                }).FirstOrDefault();
                }
                catch
                {
                    employee = null;
                }
                return employee;
            }
        }

        public IEnumerable<Employee> GetAllEmployee(Func<Employee, bool> predicate = null)
        {

            {
                LoadDataEmployee();
                List<Employee> employees;
                try
                {
                    employees = (from p in employeeRoot.Elements()
                                 select new Employee()
                                 {
                                     Id = p.Element("Id").Value,
                                     FirstName = p.Element("FirstName").Value,
                                     LastName = p.Element("LastName").Value,
                                     Address = p.Element("Address").Value,
                                     Special = Convert.ToInt32(p.Element("Special").Value),
                                     DateBirth = Convert.ToDateTime(p.Element("DateBirth").Value),
                                     degreeType = (Degree)Enum.Parse(typeof(Degree), (p.Element("degreeType").Value)),
                                     GraduateArmy = Convert.ToBoolean(p.Element("GraduateArmy").Value),
                                     ImageSource = p.Element("ImageSource").Value,
                                     MyAccount = new BankAccount
                                     {
                                         AccountNo = Convert.ToInt32(p.Element("bank").Element("AccountNo").Value),
                                         BankNo = Convert.ToInt32(p.Element("bank").Element("BankNo").Value),
                                         BranchNo = Convert.ToInt32(p.Element("bank").Element("BranchNo").Value),
                                         BranchAdd = (p.Element("bank").Element("BranchAdd").Value),
                                         BankName = (p.Element("bank").Element("BankName").Value),
                                         BranchCity = (p.Element("bank").Element("BranchCity").Value)

                                     },
                                     PhoneNum = p.Element("PhoneNum").Value
                                     
                                 }).ToList();
                }
                catch
                {
                    employees = null;
                }
                return employees;
            }
        }

        #endregion

        #region employer Function

        public void AddEmployer(Employer e)
        {
            Employer emp = GetEmployer(e.Id);
            if (emp != null)
                throw new Exception("Employer with the same Id already exists");

            XElement Id = new XElement("Id", e.Id);
            XElement FirstName = new XElement("FirstName", e.FirstName);
            XElement LastName = new XElement("LastName", e.LastName);
            XElement CompanyName = new XElement("CompanyName", e.CompanyName);
            XElement DateEstablishment = new XElement("DateEstablishment", e.DateEstablishment);
            XElement IsCompany = new XElement("IsCompany", e.IsCompany);
            XElement Field = new XElement("Field", e.Field);
            XElement Address = new XElement("Address", e.Address);
            XElement PhoneNum = new XElement("PhoneNum", e.PhoneNum);

            employerRoot.Add(new XElement("employer", Id, FirstName, LastName, CompanyName, IsCompany, PhoneNum, Field, Address, DateEstablishment));
            employerRoot.Save(employerPath);
        }

        public void RemoveEmployer(string id)
        {
            XElement employerElement;
            try
            {
                employerElement = (from p in employerRoot.Elements()
                                   where p.Element("Id").Value == id
                                   select p).FirstOrDefault();
                employerElement.Remove();
                employerRoot.Save(employerPath);

            }
            catch
            {

            }
        }

        public void UpdateEmployer(Employer e)
        {
            LoadDataEmployer();
            XElement employerElement = (from p in employerRoot.Elements()
                                        where p.Element("Id").Value == e.Id
                                        select p).FirstOrDefault();
            employerElement.Element("Id").Value = (e.Id);
            employerElement.Element("FirstName").Value = (e.FirstName);
            employerElement.Element("LastName").Value = (e.LastName);
            employerElement.Element("DateEstablishment").Value = Convert.ToString(e.DateEstablishment);
            employerElement.Element("PhoneNum").Value = (e.PhoneNum);
            employerElement.Element("Address").Value = (e.Address);
            employerElement.Element("CompanyName").Value = Convert.ToString(e.CompanyName);
            employerElement.Element("Field").Value = Convert.ToString(e.Field);
            employerElement.Element("IsCompany").Value = Convert.ToString(e.IsCompany);
            



            employerElement.Save(employerPath);
            employerRoot.Save(employerPath);
        }

        public Employer GetEmployer(string id)
        {
            {
                LoadDataEmployer();
                Employer employer;
                try
                {
                    employer = (from p in employerRoot.Elements()
                                where p.Element("Id").Value == id
                                select new Employer()
                                {
                                    FirstName = p.Element("FirstName").Value,
                                    LastName = p.Element("LastName").Value,
                                    Address = p.Element("Address").Value,
                                    CompanyName = p.Element("CompanyName").Value,
                                    DateEstablishment = Convert.ToDateTime(p.Element("DateEstablishment").Value),
                                    IsCompany = Convert.ToBoolean(p.Element("IsCompany").Value),
                                    PhoneNum = p.Element("PhoneNum").Value,
                                    Field = (FieldName)Enum.Parse(typeof(FieldName), (p.Element("Field").Value)),
                                    Id = p.Element("Id").Value

                                }).FirstOrDefault();
                }
                catch
                {
                    employer = null;
                }
                return employer;
            }
        }

        public IEnumerable<Employer> GetAllEmployer(Func<Employer, bool> predicate = null)
        {

            {
                LoadDataEmployer();
                List<Employer> employers;
                try
                {
                    employers = (from p in employerRoot.Elements()
                                 select new Employer()
                                 {
                                     FirstName = p.Element("FirstName").Value,
                                     LastName = p.Element("LastName").Value,
                                     Address = p.Element("Address").Value,
                                     CompanyName = p.Element("CompanyName").Value,
                                     DateEstablishment = Convert.ToDateTime(p.Element("DateEstablishment").Value),
                                     IsCompany = Convert.ToBoolean(p.Element("IsCompany").Value),
                                     PhoneNum = p.Element("PhoneNum").Value,
                                     Field = (FieldName)Enum.Parse(typeof(FieldName), (p.Element("Field").Value)),
                                     Id = p.Element("Id").Value
                                 }).ToList();
                }
                catch
                {
                    employers = null;
                }
                return employers;
            }
        }
        #endregion

        #region contract Function

        public void AddContract(Contract c)
        {
            int num = int.Parse(staticNumberRoot.Element("staticNumber").Element("contract").Value);
            num++;
            staticNumberRoot.Element("staticNumber").Element("contract").Value = Convert.ToString(num);
            Contract con = GetContract(num);
            if (con != null)
                throw new Exception("Contract with the same number already exists");
            staticNumberRoot.Save(staticNumberPath);

            XElement ContractNum = new XElement("ContractNum", num);
            XElement EmployeeId = new XElement("EmployeeId", c.EmployeeId);
            XElement EmployerId = new XElement("EmployerId", c.EmployerId);
            XElement DateBegingEmployin = new XElement("DateBegingEmployin", c.DateBegingEmployin);
            XElement DateEndEmploying = new XElement("DateEndEmploying", c.DateEndEmploying);
            XElement HourSalaryG = new XElement("HourSalaryG", c.HourSalaryG);
            XElement HourSalaryN = new XElement("HourSalaryN", c.HourSalaryN);
            XElement HoursNum = new XElement("HoursNum", c.HoursNum);
            XElement IsInterview = new XElement("IsInterview", c.IsInterview);
            XElement IsSign = new XElement("IsSign", c.IsSign);

            contractRoot.Add(new XElement("contract", ContractNum, EmployeeId, EmployerId, DateBegingEmployin, DateEndEmploying, IsSign, IsInterview, HoursNum, HourSalaryN, HourSalaryG));
            contractRoot.Save(contractPath);
        }

        public void RemoveContract(int contractNum)
        {
            XElement contractElement;
            try
            {
                contractElement = (from p in contractRoot.Elements()
                                   where Convert.ToInt32(p.Element("ContractNum").Value) == contractNum
                                   select p).FirstOrDefault();
                contractElement.Remove();
                contractRoot.Save(contractPath);

            }
            catch
            {

            }
        }

        public void UpdateContract(Contract c)
        {
            LoadDataContract();
            XElement contractElement = (from p in contractRoot.Elements()
                                        where Convert.ToInt32(p.Element("ContractNum").Value) == c.ContractNum
                                        select p).FirstOrDefault();
            contractElement.Element("DateBegingEmployin").Value = Convert.ToString(c.DateBegingEmployin);
            contractElement.Element("DateEndEmploying").Value = Convert.ToString(c.DateEndEmploying);
            contractElement.Element("EmployeeId").Value = c.EmployeeId;
            contractElement.Element("EmployerId").Value = c.EmployerId;
            contractElement.Element("IsInterview").Value = Convert.ToString(c.IsInterview);
            contractElement.Element("IsSign").Value = Convert.ToString(c.IsSign);
            contractElement.Element("HourSalaryG").Value = Convert.ToString(c.HourSalaryG);
            contractElement.Element("HourSalaryN").Value = Convert.ToString(c.HourSalaryN);
            contractElement.Element("HoursNum").Value = Convert.ToString(c.HoursNum);

            contractElement.Save(contractPath);
            contractRoot.Save(contractPath);
        }

        public Contract GetContract(int num)
        {
            {
                LoadDataContract();
                Contract contract;
                try
                {
                    contract = (from p in contractRoot.Elements()
                                where Convert.ToInt32(p.Element("ContractNum").Value) == num
                                select new Contract()
                                {
                                    ContractNum = Convert.ToInt32(p.Element("ContractNum").Value),
                                    IsInterview = Convert.ToBoolean(p.Element("IsInterview").Value),
                                    IsSign = Convert.ToBoolean(p.Element("IsSign").Value),
                                    EmployeeId = p.Element("EmployeeId").Value,
                                    EmployerId = p.Element("EmployerId").Value,
                                    DateBegingEmployin = Convert.ToDateTime(p.Element("DateBegingEmployin").Value),
                                    DateEndEmploying = Convert.ToDateTime(p.Element("DateEndEmploying").Value),
                                    HourSalaryG = Convert.ToDouble(p.Element("HourSalaryG").Value),
                                    HourSalaryN = Convert.ToDouble(p.Element("HourSalaryN").Value),
                                    HoursNum = Convert.ToInt32(p.Element("HoursNum").Value),
                                }).FirstOrDefault();
                }
                catch
                {
                    contract = null;
                }
                return contract;
            }
        }


        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
        {
            {
                LoadDataContract();
                List<Contract> contracts;
                try
                {
                    contracts = (from p in contractRoot.Elements()
                                 select new Contract()
                                 {
                                     ContractNum = Convert.ToInt32(p.Element("ContractNum").Value),
                                     IsInterview = Convert.ToBoolean(p.Element("IsInterview").Value),
                                     IsSign = Convert.ToBoolean(p.Element("IsSign").Value),
                                     EmployeeId = p.Element("EmployeeId").Value,
                                     EmployerId = p.Element("EmployerId").Value,
                                     DateBegingEmployin = Convert.ToDateTime(p.Element("DateBegingEmployin").Value),
                                     DateEndEmploying = Convert.ToDateTime(p.Element("DateEndEmploying").Value),
                                     HourSalaryG = Convert.ToDouble(p.Element("HourSalaryG").Value),
                                     HourSalaryN = Convert.ToDouble(p.Element("HourSalaryN").Value),
                                     HoursNum = Convert.ToInt32(p.Element("HoursNum").Value),
                                 }).ToList();
                }
                catch
                {
                    contracts = null;
                }
                return contracts;
            }
        }
        #endregion

        #region Bank Function 
        public static IEnumerable<BankAccount> GetAllAtm()
        {
            if (finish == false)
                throw new Exception("The download is not finished already");


            XElement xml = XElement.Load(xmlLocalPath);

            var v = from item in xml.Elements()
                    select new BankAccount
                    {
                        BankNo = int.Parse(item.Element("קוד_בנק").Value),
                        BranchNo = int.Parse(item.Element("קוד_סניף").Value),
                        BankName = item.Element("שם_בנק").Value.Replace('\n', ' ').Trim(),
                        BranchAdd = item.Element("כתובת_ה-ATM").Value.Replace('\n', ' ').Trim(),
                        BranchCity = item.Element("ישוב").Value.Replace('\n', ' ').Trim()
                    };
            return v;

        }

        public IEnumerable<IGrouping<string, BankAccount>> GetAllAtmGroupByBank()
        {
            var v = from atm in GetAllAtm()
                    group atm by atm.BankName;
            return v.ToList();
        }

        public string GetBankNames(int num)
        {
            var v= from atm in GetAllAtm()
                    where (atm.BankNo == num)
                    select atm;
            BankAccount b= v.FirstOrDefault();
           return b.BankName;
        }

        public IEnumerable<IGrouping<int, BankAccount>> GetAllBrunchOfBank(int bankNo)
        {
            var v = from atm in GetAllAtm()
                    where atm.BankNo==bankNo
                    group atm by atm.BranchNo;
            return v.ToList();
        }

        public string GetBranchName(int BranchNo, int BankNo)
        {
            var v = from atm in GetAllAtm()
                    where (atm.BranchNo == BranchNo && atm.BankNo == BankNo)
                    select atm;
            BankAccount b = v.FirstOrDefault();
            return b.BranchAdd;
        }

        public string GetBranchCity(int BranchNo, int BankNo)
        {
            var v = from atm in GetAllAtm()
                    where (atm.BranchNo == BranchNo && atm.BankNo==BankNo)
                    select atm;
            BankAccount b = v.FirstOrDefault();
            return b.BranchCity;
        }
   
        public IEnumerable<BankAccount> GetAllBankAccount(Func<BankAccount, bool> predicate = null)
        {
            return GetAllAtm();
        }
        #endregion

        public bool checkfinish()
        {
            return finish;
        }




    }
}




