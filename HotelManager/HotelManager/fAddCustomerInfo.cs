using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fAddCustomerInfo : Form
    {
        private static List<int> listIdCustomer;

        public static List<int> ListIdCustomer { get => listIdCustomer; set => listIdCustomer = value; }

        public fAddCustomerInfo()
        {
            InitializeComponent();
            LoadCustomerType();
            ListIdCustomer = new List<int>();
        }
        public void LoadCustomerType()
        {
            cbCustomerType.DataSource = CustomerTypeDAO.Instance.LoadListCustomerType();
            cbCustomerType.DisplayMember = "Name";
        }
        public bool IsIdCardExists(string idCard)
        {
            return CustomerDAO.Instance.IsIdCardExists(idCard);
        }
        public void InsertCustomer(string idCard, string name, int idCustomerType, string sex)
        {
            CustomerDAO.Instance.InsertCustomer(idCard, name, idCustomerType, sex);
        }
        public void GetInfoByIdCard(string idCard)
        {
            Customer customer = CustomerDAO.Instance.GetInfoByIdCard(idCard);
            txbIDCard.Text = customer.IdCard.ToString();
            txbFullName.Text = customer.Name;
            cbSex.Text = customer.Sex;
            cbCustomerType.Text = CustomerTypeDAO.Instance.GetNameByIdCard(idCard);
        }
        public void ClearData()
        {
            txbIDCardSearch.Text = txbIDCard.Text = txbFullName.Text  = String.Empty;
        }
        public void AddIdCustomer(int idCustomer)
        {
            if(ListIdCustomer.Count!=0)
            {
                bool check = false;
                foreach (int item in ListIdCustomer)
                {
                    if (item == idCustomer)
                    {
                        check = true;
                        break;
                    }
                }
                if(!check) ListIdCustomer.Add(idCustomer);
            }
            else
            ListIdCustomer.Add(idCustomer);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txbFullName.Text!=string.Empty&&txbIDCard.Text!=string.Empty)
            {
                if (!IsIdCardExists(txbIDCard.Text))
                {
                    int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
                    InsertCustomer(txbIDCard.Text, txbFullName.Text, idCustomerType, cbSex.Text);
                }
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddIdCustomer(CustomerDAO.Instance.GetInfoByIdCard(txbIDCard.Text).Id);
                ClearData();
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbIDCardSearch.Text != String.Empty)
            {
                if (IsIdCardExists(txbIDCardSearch.Text))
                    GetInfoByIdCard(txbIDCardSearch.Text);
                else
                    MessageBox.Show("Thẻ căn cước/ CMND không tồn tại.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbIDCardSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
