using HotelManager.DAO;
using HotelManager.DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fAddSurchargeRate : Form
    {
        public fAddSurchargeRate()
        {
            InitializeComponent();
            txbPrice.Text = "0";
        }
        private SurchargeRate GetSurchargeRateNow()
        {
            SurchargeRate SurchargeRate = new SurchargeRate();
            SurchargeRate.Name = int.Parse(txbName.Text);
            SurchargeRate.Value = double.Parse(txbPrice.Text);
            return SurchargeRate;
        }

        private int SRName(SurchargeRate surchargeRate)
        {
            int name;
            name = surchargeRate.Name;
            return name;
        }

        private void btnAddSurchargeRate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm loại phụ thu mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                InsertSurchargeRate();
            }
        }
        
        private void InsertSurchargeRate()
        {
            if (!CheckFillInText(new Control[] { txbName, txbPrice }))
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SurchargeRate SurchargeRate = GetSurchargeRateNow();
                int ValueQD1 = ParameterDAO.Instance.ValueQD1();
                int srname = SRName(SurchargeRate);
                if (ValueQD1 >= srname)
                {
                    if (SurchargeRateDAO.Instance.InsertSurchargeRate(SurchargeRate))
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbName.Text = string.Empty;
                        txbPrice.Text = "0";
                    }
                    else
                        MessageBox.Show("Loại phụ thu đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }else
                {
                    MessageBox.Show("Số khách vượt quá số người tối đa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool CheckFillInText(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Text == string.Empty)
                    return false;
            }
            return true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupServiceType_Enter(object sender, EventArgs e)
        {

        }

        private void fAddSurchargeRate_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fAddSurchargeRate_Load_1(object sender, EventArgs e)
        {

        }
    }
}
