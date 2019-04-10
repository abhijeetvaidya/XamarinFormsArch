using System;
namespace XamarinFormsArch.Classes
{
    public class DoIEx
    {
        public class CustBusinessLogin
        {
            public ICustomerDataAccess dataAccess { get; set; }

            public CustBusinessLogin(ICustomerDataAccess access)
            {
                dataAccess = access;
                //dataAccess = DataAccessFactory.GetDataAccessObj();
            }

            public CustBusinessLogin()
            {
                dataAccess = new DataAccess();
            }

            /*public string GetCustName()
            {
                return dataAccess.GetCustomerName();
            }*/
        }

        /*public class DataAccessFactory
        {
            public static ICustomerDataAccess GetDataAccessObj()
            {
                return new DataAccess();
            }
        }*/

        public class DataAccess : ICustomerDataAccess
        {
            public string GetCustomerName()
            {
                return "Dummy";
            }

            //public string GetData()
            //{
            //}
        }

        public class CustService
        {
            CustBusinessLogin businessLogin;

            public CustService()
            {
                businessLogin = new CustBusinessLogin(new DataAccess());
                businessLogin.dataAccess = new DataAccess();
            }

            public string GetCustomerName()
            {
                return businessLogin.dataAccess.GetCustomerName();
            }

        }

        public interface ICustomerDataAccess
        {
            string  GetCustomerName();
        }
    }
}
