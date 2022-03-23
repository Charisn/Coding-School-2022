using DevExpress.XtraEditors;
using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        private PetShop _petShop;
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _petShop.Transactions;
        }
    }
}