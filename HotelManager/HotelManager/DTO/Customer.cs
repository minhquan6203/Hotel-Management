using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class Customer
    {
        private int id;
        private string idCard;
        private string name;
        private int idCustomerType;
        private string sex;
        public Customer()
        {

        }
        public Customer(int id,string idCard, string name, int idcustomerType, string sex)
        {
            this.Id = id;
            this.IdCard = idCard;
            this.Name = name;
            this.IdCustomerType = idcustomerType;
            this.Sex = sex;
        }
        public Customer(DataRow row)
        {
            this.Id= (int)row["id"];
            this.IdCard = row["idcard"].ToString();
            this.Name = row["Name"].ToString();
            this.IdCustomerType =(int)row["idcustomerType"];
            this.Sex = row["sex"].ToString();
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Customer);
        }
        public bool Equals(Customer customerPre)
        {
            if (customerPre == null)
                return false;
            if (this.idCard != customerPre.idCard) return false;
            if (this.idCustomerType != customerPre.idCustomerType) return false;
            if (this.Name != customerPre.Name) return false;
            if (this.sex != customerPre.sex) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string Sex { get => sex; set => sex = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string Name { get => name; set => name = value; }
        public int IdCustomerType { get => idCustomerType; set => idCustomerType = value; }
        public int Id { get => id; set => id = value; }
    }
}
