using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelManager.DAO
{
    public class CustomerTypeDAO
    {
        #region Method
        private CustomerTypeDAO() { }

        private static CustomerTypeDAO instance;
        internal static CustomerTypeDAO Instance { get { if (instance == null) instance = new CustomerTypeDAO(); return instance; } }

        public List<CustomerType> LoadListCustomerType()
        {
            string query = "select * from CustomerType";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<CustomerType> listCustomerType = new List<CustomerType>();
            foreach (DataRow item in data.Rows)
            {
                CustomerType CustomerType = new CustomerType(item);
                listCustomerType.Add(CustomerType);
            }
            return listCustomerType;
        }
        public string GetNameByIdCard(string idCard)
        {
            string query = "USP_GetCustomerTypeNameByIdCard @idCard";
            DataRow dataRow = DataProvider.Instance.ExecuteQuery(query, new object[] { idCard }).Rows[0];
            return dataRow["Name"].ToString();
        }
        internal bool UpdateCustomerType(string name, double value)
        {
            string query = "exec USP_UpdateCustomerType @name , @rate";
            return DataProvider.Instance.ExecuteNoneQuery(query, new Object[] { name, value }) > 0;
        }
        internal bool UpdateCustomerType(CustomerType customerTypeNow)
        {
            return UpdateCustomerType(customerTypeNow.Name, customerTypeNow.Rate);
        }
        ///
        internal DataTable LoadFullCustomerType()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadFullCustomerType");
        }
        internal DataTable Search(string text)
        {
            string query = "USP_SearchCustomerType @string";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { text });
        }
        internal bool InsertCustomerType(CustomerType surcharge)
        {
            return InsertCustomerType(surcharge.Name, surcharge.Rate);
        }
        internal bool InsertCustomerType(string name, double rate)
        {
            string query = "exec USP_InsertCustomerType @name , @rate";
            return DataProvider.Instance.ExecuteNoneQuery(query, new Object[] { name, rate }) > 0;
        }
        #endregion


    }
}
