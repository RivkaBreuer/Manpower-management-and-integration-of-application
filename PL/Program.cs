using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace PL
{
    class Program
    {
   
      static void Main(string[] args)
        {
            try
            {

                //BE.Contract c = (new BE.Contract { EmployerId = "123", EmployeeId = "203167416", IsInterview = true, IsSign = false, HourSalaryG = 100.0, DateBegingEmployin = new DateTime(2003, 04, 01), DateEndEmploying = new DateTime(2015, 04, 01), HoursNum = 180 });


                //BE.Employee ee = (new BE.Employee { FirstName = "Riki", LastName = "Breuer", Id = "203167416", DateBirth = new DateTime(1992, 06, 02), PhoneNum = "054-8489320", Address = "59 Hakablan", degreeType = Degree.CertificateOnly, GraduateArmy = false, MyAccount = new BankAccount() });

                //BE.Employer er = (new BE.Employer { Address = "9 Hadfus", CompanyName = "", DateEstablishment = new DateTime(2001, 05, 12), Field = "Access", FirstName = "Avi", Id = "123", IsCompany = false, LastName = "Ron", PhoneNum = "052-7145620" });

                //BE.Specialization s = (new BE.Specialization { TariffMax = 100, TariffMin = 50, ExpertiseName = "cpp", Filed = FieldName.programmingLanguages });

                //#region DAL Func.
                 DAL.Idal dal = DAL.FactoryDal.GetDal();
                // dal.AddContract(c);
                // dal.AddEmployee(ee);
                // dal.AddEmployer(er);
                // dal.AddSpecialization(s);

                // //dal.RemoveContract(c.ContractNum);
                // //dal.RemoveEmployee(ee.Id);
                // //dal.RemoveEmployer(er.Id);
                // //dal.RemoveSpecialization(s.SpecialNum);

                // c.HoursNum = 80;
                // dal.UpdateContract(c);
                // ee.LastName = "Waisboam";
                // dal.UpdateEmployee(ee);
                // er.PhoneNum = "054-8496075";
                // dal.UpdateEmployer(er);
                // s.TariffMax = 99;
                // dal.UpdateSpecialization(s);

                // foreach (var v in dal.GetAllContract())
                //     Console.WriteLine(v);
                // foreach (var v in dal.GetAllEmployee())
                //     Console.WriteLine(v);
                // foreach (var v in dal.GetAllEmployer())
                //     Console.WriteLine(v);
                // foreach (var v in dal.GetAllSpecialization())
                //     Console.WriteLine(v);
                // #endregion

                BL.IBL bl = BL.FactoryBL.GetBL();

                //foreach (var v in bl.GetAllContract())
                //{     Console.WriteLine(v.HourSalaryG);
                //Console.WriteLine(v.HourSalaryN);
                //}
                //  bl.present();
                //bl.bonus();
                //foreach (var item in bl.IsArmy())
                //{
                //    Console.WriteLine(item);
                //}
                //bl.invalidContract();
           
                //foreach (var v in bl.GetAllContract())
                //    Console.WriteLine(v);
                //foreach (var v in bl.GetAllEmployee())
                //    Console.WriteLine(v);
                //foreach (var v in bl.GetAllEmployer())
                //    Console.WriteLine(v);
                //foreach (var v in bl.GetAllSpecialization())
                //    Console.WriteLine(v);

                //bl.RemoveContract(10000000);

                //Func<Employee,bool> predicate = item => 
                //{
                //    return item.GraduateArmy == true;
                //}


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
