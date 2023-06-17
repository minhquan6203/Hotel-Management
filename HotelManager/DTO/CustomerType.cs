using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DTO
{
    public class CustomerType
    {
        private int id;
        private string name;
        private double rate;
        public CustomerType(int id, string name, double rate)
        {
            Id = id;
            Name = name;
            Rate = rate;
        }
        public CustomerType()
        {
           
        }
        public CustomerType(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }
        public CustomerType(DataRow row)
        {
            Id = (int)row[columnName: "id"];
            Name = row[columnName: "Name"].ToString();
            Rate = (double)row["Rate"];
        }

        public CustomerType(int v1, double v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CustomerType);
        }
        public bool Equals(CustomerType customerTypePre)
        {
            if (customerTypePre == null)
                return false;
            if (this.name != customerTypePre.name) return false;
            if (this.rate != customerTypePre.rate) return false;
            return true;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Rate { get => rate; set => rate = value; }
        public int V1 { get; }
        public double V2 { get; }
    }
}
