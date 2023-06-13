using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        private CustomerDAO() { }
        #region Method
        public bool IsIdCardExists(string idCard)
        {
            string query = "USP_IsIdCardExists @idCard";
            int count = DataProvider.Instance.ExecuteQuery(query, new object[] { idCard }).Rows.Count;
            return count > 0;
        }
        public bool InsertCustomer(string idCard, string name,int idCustomerType, string sex)
        {
            string query = "USP_InsertCustomer_ @idCard , @name , @idCustomerType  , @sex ";
            return DataProvider.Instance.ExecuteNoneQuery(query,new object[] { idCard, name, idCustomerType, sex })>0;
        }
        public Customer GetInfoByIdCard(string idCard)
        {
            string query = "USP_IsIdCardExists @idCard";
            Customer customer =new Customer(DataProvider.Instance.ExecuteQuery(query, new object[] { idCard }).Rows[0]);
            return customer;

        }

        internal bool InsertCustomers(string customerName, int idCustomerType, string idCard, string sex)
        {
            string query = "exec USP_InsertCustomer @customerName , @idCustomerType , @idCard  , @sex ";
            int count = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { customerName, idCustomerType, idCard, sex });
            return count > 0;
        }
        internal bool InsertCustomer(Customer customer)
        {
            return InsertCustomers(customer.Name, customer.IdCustomerType, customer.IdCard, customer.Sex);
        }


        internal bool UpdateCustomer(Customer customerNow, Customer customerPre)
        {
            string query = "USP_UpdateCustomer @id , @customerName , @idCustomerType , @idCardNow , @sex , @idCardPre";
            object[] parameter = new object[] {customerNow.Id, customerNow.Name, customerNow.IdCustomerType, customerNow.IdCard,
                                    customerNow.Sex, customerPre.IdCard};
            return DataProvider.Instance.ExecuteNoneQuery(query, parameter) > 0;
        }
        public bool UpdateCustomer(int id,string name,string idCard,int idCustomerType,string sex)
        {
            string query = "USP_UpdateCustomer_ @id , @name , @idCard , @idCustomerType , @sex ";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id,name,idCard,idCustomerType,sex})>0;
        }

        internal DataTable LoadFullCustomer()
        {
            string query = "USP_LoadFullCustomer";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        internal DataTable Search(string text, int phoneNumber)
        {
            string query = "USP_SearchCustomer @string , @int";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { text, phoneNumber });
        }
        public int GetIDCustomerFromBookRoom(int idReceiveRoom)
        {
            string query = "USP_GetIDCustomerFromBookRoom @idReceiveRoom";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idReceiveRoom });
        }
        #endregion
        public static CustomerDAO Instance { get { if (instance == null) instance = new CustomerDAO();return instance; }
            private set => instance = value; }
        
    }
}
