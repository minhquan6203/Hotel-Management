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
    public partial class fAddCustomerType : Form
    {
        public fAddCustomerType()
        {
            InitializeComponent();
            txbPrice.Text = "0";
        }
        private CustomerType GetCustomerTypeNow()
        {
            CustomerType CustomerType = new CustomerType();
            CustomerType.Name = txbName.Text;
            CustomerType.Rate = double.Parse(txbPrice.Text);
            return CustomerType;
        }

        private string SRName(CustomerType CustomerType)
        {
            string name = CustomerType.Name;
            return name;
        }

        private void btnAddCustomerType_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm loại khách hàng mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                InsertCustomerType();
            }
        }
        
        private void InsertCustomerType()
        {
            if (!CheckFillInText(new Control[] { txbName, txbPrice }))
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                CustomerType CustomerType = GetCustomerTypeNow();
                    if (CustomerTypeDAO.Instance.InsertCustomerType(CustomerType))
                    {
                        MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbName.Text = string.Empty;
                        txbPrice.Text = "0";
                    }
                    else
                        MessageBox.Show("Loại phụ thu đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              
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

        private void fAddCustomerType_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fAddCustomerType_Load_1(object sender, EventArgs e)
        {

        }
    }
}
