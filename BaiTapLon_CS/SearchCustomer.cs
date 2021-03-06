﻿using System;
using System.Windows.Forms;

namespace BaiTapLon_CS
{

    public partial class SearchCustomer : Form
    {
        public delegate void sendData(string a, string b, string c, string d);
        public sendData sender;
        public void DisplayListView(string query)
        {


            dgvSearchCustomer.DataSource = DAO.SearchCustomerDAO.Instance.DisplayListView(query);
            if (dgvSearchCustomer.DataSource != null)
            {
                dgvSearchCustomer.Columns[0].HeaderText = "Mã KH";
                dgvSearchCustomer.Columns[1].HeaderText = "Tên KH";
                dgvSearchCustomer.Columns[2].HeaderText = "Giới tính";
                dgvSearchCustomer.Columns[3].HeaderText = "Địa chỉ";
                dgvSearchCustomer.Columns[4].HeaderText = "Tuổi";
            }

        }
        public SearchCustomer(sendData _sender)
        {


            InitializeComponent();
            this.sender = _sender;
            string query = "SELECT * FROM Customer";
            DisplayListView(query);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            dgvSearchCustomer.DataSource = null;
            if (cbTypeSearch.SelectedIndex == 0) // tìm kiếm theo mã khách hàng
            {
                string query = "SELECT * FROM Customer WHERE ID_Customer= " + txtSearchCustomer.Text;
                DisplayListView(query);


            }
            if (cbTypeSearch.SelectedIndex == 1) // tìm kiếm theo họ tên 
            {
                string query = "SELECT * FROM Customer WHERE  LOWER(Name_Customer) LIKE N'%" + txtSearchCustomer.Text.ToLower() + "%'";
                DisplayListView(query);
            }
            if (cbTypeSearch.SelectedIndex == 2) // tìm kiếm theo sdt
            {
                string query = "SELECT * FROM Customer WHERE  Phone = " + txtSearchCustomer.Text;
                DisplayListView(query);
            }
        }

        private void dgvSearchCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            int row = dgvSearchCustomer.CurrentCell.RowIndex;
            var ID_Customer = dgvSearchCustomer.Rows[row].Cells[0].Value.ToString();
            var Name_Customer = dgvSearchCustomer.Rows[row].Cells[1].Value.ToString();
            var Address_Customer = dgvSearchCustomer.Rows[row].Cells[3].Value.ToString();
            var Phone_Customer = dgvSearchCustomer.Rows[row].Cells[5].Value.ToString();
            this.sender(ID_Customer, Name_Customer, Address_Customer, Phone_Customer);
            this.Hide();
        }
    }
}
