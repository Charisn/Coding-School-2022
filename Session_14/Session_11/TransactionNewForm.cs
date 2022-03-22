﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PetShopLib.Impl;
using System.Text.Json;

namespace Session_11
{
    public partial class TransactionNewForm : Form
    {
        private const string FILE_NAME = "PetShop.json";
        private Transaction _thisTransaction;
        private PetShop _petShop;
        private Customer _currentCustomer;
        private Employee _currentEmployee;

        public TransactionNewForm()
        {
            LoadPetsShopJson();
            InitializeComponent();
            _thisTransaction = new Transaction();            
            _petShop.Transactions.Add(_thisTransaction);
            
        }

        private void TransactionNewForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
            ctrlPetPrice.ReadOnly = true;
            ctrlPetFoodPrice.ReadOnly = true;
            ctrlTotalPrice.ReadOnly = true;

            bsTransactions.DataSource = _petShop.Transactions;

            SetDataBindings();
        }
        private void PopulateControls()
        {
            var helper = new ControlsHelper();
            
            helper.PopulatePetType(ctrlPet.Properties, _petShop);
            helper.PopulateCustomer(ctrlCustomer.Properties, _petShop);
            helper.PopulateEmployee(ctrlEmployee.Properties, _petShop);
        }

        private void AddNewCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerListForm linkLabel = new CustomerListForm();
            linkLabel.Show();
        }

        private void SetDataBindings()
        {
            //BindingSource bsTransactions = new BindingSource();
            ctrlPetFoodPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodPrice", true));
            ctrlPetPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetPrice", true));
            ctrlPetFoodQty.DataBindings.Add(new Binding("EditValue", bsTransactions, "PetFoodQty", true));
            ctrlTotalPrice.DataBindings.Add(new Binding("EditValue", bsTransactions, "TotalPrice", true));
        }

        public void Calculations()
        {
            if (ctrlPetFoodQty.Value == null || ctrlPetFoodQty.Value <1 ) 
            { ctrlPetFoodQty.Value = 1; }

            bsPetShop.DataSource = _petShop;
            bsPetShop.DataMember = "Pets";
            ctrlPet.Properties.DataSource = bsPetShop;
            var ctrlpet = ctrlPet.EditValue;
            var pet = _petShop.Pets.Find(x => x.ID.Equals(ctrlpet));
            var animalType = pet.AnimalType;
            var petFood = _petShop.PetFoods.Find(x => x.AnimalType.Equals(animalType));
            decimal _currentFoodPrice = Convert.ToDecimal(petFood.Price);
            decimal _totalPet = Convert.ToDecimal(pet.Price);
            int _qty = Convert.ToInt16(ctrlPetFoodQty.Value);
            var _grandTotal = (_currentFoodPrice * (_qty - 1) + _totalPet);
            var _currentFood = _petShop.PetFoods.Find(x => x.ID.Equals(_currentFoodPrice));
            var _petPrice = ctrlPetPrice.Value;
            
            if (pet != null)
            {
                ctrlTotalPrice.EditValue = _grandTotal;
                ctrlPetPrice.EditValue=pet.Price;
                ctrlPetFoodPrice.EditValue = petFood.Price;
            }

            if (pet.PetStatus == PetShopLib.Enums.PetStatusEnum.Unhealthy)
            {
                MessageBox.Show("Pet selected is unavailable", "Warning");
            }

            _currentCustomer = _petShop.Customers.FirstOrDefault(x => x.TIN.Equals(ctrlCustomer.EditValue));
            _currentEmployee = _petShop.Employees.FirstOrDefault(x => x.Name.Equals(ctrlEmployee.EditValue));
            _thisTransaction.PetFoodQty = _qty;
            _thisTransaction.PetFoodPrice = _currentFoodPrice;
            _thisTransaction.TotalPrice = _grandTotal;
            _thisTransaction.PetPrice = _petPrice;
            _thisTransaction.CustomerID = _currentCustomer.ID;
            _thisTransaction.EmployeeID = _currentEmployee.ID;
            _thisTransaction.PetID = pet.ID;
            //_thisTransaction.PetFoodID = _petFoodID.ToString();
        }
        private void Save()
        {
            string json = JsonSerializer.Serialize(_petShop);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;

        }
        private void btnSaveNewTrans_Click(object sender, EventArgs e)
        {
            _petShop.Transactions.Add(_thisTransaction);
            //Save();
        }
        private void ctrlPet_EditValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }
        private void btnCancelNewTrans_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Not closing window.
            }
        }

        private void ctrlPetFoodQty_EditValueChanged(object sender, EventArgs e)
        {
            Calculations();
        }        
        private void LoadPetsShopJson()
        {
            string s = File.ReadAllText(FILE_NAME);
            _petShop = (PetShop)JsonSerializer.Deserialize(s, typeof(PetShop));
        }
        private void ctrlCustomer_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.ctrlCustomer.Refresh();
        }
    }
}