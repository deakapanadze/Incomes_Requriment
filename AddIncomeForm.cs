using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_purchee;
using Test_purchee.Models;

namespace InventoryManagement
{
    public partial class AddIncomeForm : Form

    {
        //public int Id;
        //InventoryManagementForm forms = new InventoryManagementForm();
        dbmanager db = new dbmanager();
        public AddIncomeForm(/*int Id, InventoryManagementForm form*/)
        {
            //this.Id = Id;
            //this.forms = form;
            InitializeComponent();


        }

        private void AddIcomeForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.GetRequests();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "Id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.DateCreated = dateTimePicker1.Value;
            income.RequestId = Convert.ToInt32(comboBox1.SelectedValue);

            db.AddIcome(income);
        }
    }
}
