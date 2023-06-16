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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fAddRoomType : Form
    {
        public fAddRoomType()
        {
            InitializeComponent();
            txbPrice.Text = IntToString("100000");
            txbLimitPerson.Text = "3";
        }
        private RoomType GetRoomTypeNow()
        {
            RoomType roomType = new RoomType();
            roomType.Name = txbName.Text;
            roomType.LimitPerson = int.Parse(StringToInt(txbLimitPerson.Text));
            roomType.Price = int.Parse(StringToInt(txbPrice.Text));
            return roomType;
        }

        private void TxbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void TxbPrice_Leave(object sender, EventArgs e)
        {
            if (txbPrice.Text == string.Empty)
                txbPrice.Text = txbPrice.Tag as string;
            else
                txbPrice.Text = IntToString(txbPrice.Text);
        }
        private void TxbPrice_Enter(object sender, EventArgs e)
        {
            txbPrice.Tag = txbPrice.Text;
            txbPrice.Text = StringToInt(txbPrice.Text);
        }
        //string to int
        private string StringToInt(string text)
        {
            if (text.Contains(".") || text.Contains(" "))
            {
                string[] vs = text.Split(new char[] { '.', ' ' });
                StringBuilder textNow = new StringBuilder();
                for (int i = 0; i < vs.Length - 1; i++)
                {
                    textNow.Append(vs[i]);
                }
                return textNow.ToString();
            }
            else return text;
        }

        //int to string
        private string IntToString(string text)
        {
            if (text == string.Empty)
                return 0.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            if (text.Contains(".") || text.Contains(" "))
                return text;
            else
                return (int.Parse(text).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN")));
        }


        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm loại phòng mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                InsertRoomType();
            }
        }
        
        private void InsertRoomType()
        {
            if (!CheckFillInText(new Control[] { txbName, txbLimitPerson, txbPrice }))
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                RoomType roomType = GetRoomTypeNow();
                if (RoomTypeDAO.Instance.InsertRoomType(roomType))
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbName.Text = string.Empty;
                    txbPrice.Text = IntToString("100000");
                    txbLimitPerson.Text = "3";
                }
                else
                    MessageBox.Show("Loại phòng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void fAddRoomType_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbLimitPerson_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
