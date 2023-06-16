using HotelManager.DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using DataTable = System.Data.DataTable;

namespace HotelManager.DAO
{
    public class SurchargeRateDAO
    {
        #region Properties && constructor
        private SurchargeRateDAO() { }

        private static SurchargeRateDAO instance;
        internal static SurchargeRateDAO Instance { get { if (instance == null) instance = new SurchargeRateDAO(); return instance; } }
        #endregion

        #region Method
        internal bool InsertSurchargeRate(SurchargeRate surcharge)
        {
            return InsertSurchargeRate(surcharge.Name, surcharge.Value);
        }
        internal bool InsertSurchargeRate(int name, double value)
        {
            string query = "exec USP_InsertSurchargeRate @name , @value";
            return DataProvider.Instance.ExecuteNoneQuery(query, new Object[] { name, value }) > 0;
        }
        internal bool UpdateSurchargeRate(int name, double value)
        {
            string query = "exec USP_UpdateSurchargeRate @name , @value";
            return DataProvider.Instance.ExecuteNoneQuery(query, new Object[] { name, value}) > 0;
        }
        internal bool UpdateSurchargeRate(SurchargeRate surcharge)
        {
            return UpdateSurchargeRate(surcharge.Name, surcharge.Value);
        }
        internal DataTable LoadFullSurchargeRate()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadFullSurchargeRate");
        }

        internal DataTable Search(int text)
        {
            string query = "USP_SearchSurchargeRate @string";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { text });
        }
        #endregion
        public bool IsIdNameExists(int name)
        {
            string query = "USP_IsNameExists @name";
            int count = DataProvider.Instance.ExecuteQuery(query, new object[] { name }).Rows.Count;
            return count > 0;
        }

    }
}
