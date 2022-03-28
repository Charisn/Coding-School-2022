using DevExpress.XtraEditors;
using EF_Library.Repositories;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class CustomerListForm : XtraForm
    {
        private const string FILE_NAME = "PetShop.json";

        private readonly IEntityRepo<Customer> _customerRepo;

        private List<Customer> _customers = new List<Customer>();

        public CustomerListForm(IEntityRepo<Customer> customerRepo)
        {
            InitializeComponent();
            _customerRepo = customerRepo;
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            RefreshCustomers();
        }
        private void RefreshCustomers()
        {
            //_customers = _customerRepo.GetAll();
            //gridCustomers.DataSource = null;
            //gridCustomers.DataSource = _customers;
            //gridCustomers.Refresh();
            //gridCustomers.Update();
            grvCustomers.RefreshData();
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            RefreshCustomers();
        }
        private void PopulateCustomers()
        {
            var _petshop = new PetShop();
            _petshop.Customers = _customerRepo.GetAll();

            bsPetShop.DataSource = _petshop;
            bsCustomers.DataSource = bsPetShop;
            bsCustomers.DataMember = "Customers";
            gridCustomers.DataSource = bsCustomers;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var petShop = bsPetShop.Current as PetShop;
            CustomerForm customerForm = new CustomerForm(petShop, _customerRepo);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var petShop= bsPetShop.Current as PetShop; 
            var customer = bsCustomers.Current as Customer;
            CustomerForm customForm = new CustomerForm(petShop, _customerRepo, customer);
            customForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete this customer?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;
            var customer = bsCustomers.Current as Customer;
            bsCustomers.Remove(customer);
            _customerRepo.Delete(customer.ID);
            RefreshCustomers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}