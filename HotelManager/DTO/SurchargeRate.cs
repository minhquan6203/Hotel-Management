using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManager.DTO
{
    public class SurchargeRate
    {
        private int name;
        private double value;
        public SurchargeRate(int name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
        public SurchargeRate(DataRow row)
        {
            this.Value = (double)row["Value"];
            this.Name = (int)row["Name"];
        }

        public SurchargeRate()
        {
        }

        public bool Equals(SurchargeRate parameterPre)
        {
            if (parameterPre == null)
                return false;
            if (this.value != parameterPre.value) return false;
            return true;
        }

        public int Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
