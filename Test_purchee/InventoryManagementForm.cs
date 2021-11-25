﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_purchee.Models;

namespace Test_purchee
{
    public partial class InventoryManagementForm : Form
    {
        dbmanager db = new dbmanager();

        public InventoryManagementForm()
        {
            InitializeComponent();
            dataGridView3.AutoGenerateColumns = false;
        }


        private void Purchase_Load(object sender, EventArgs e)
        {
            Refresh();

        }


        //private void GetInComes()
        // {
        //dataGridView1.DataSource = db.GetInComes();

        // }

        private void Refresh()
        {
            dataGridView2.DataSource = db.GetIncomes();
            dataGridView3.DataSource = db.GetRequests();
        }



      

       



        private void tbn_income_Click(object sender, EventArgs e)
        {
            AddRequirementsForm addReq = new AddRequirementsForm(this);
            addReq.StartPosition = FormStartPosition.CenterScreen;
            addReq.ShowDialog();
            Refresh();

        }

        private void btn_inventaries_Click(object sender, EventArgs e)
        {
            CategoriesForm addInventories = new CategoriesForm();
            //ფანჯარა რომ ცენტრში გამოიტანოს
            addInventories.StartPosition = FormStartPosition.CenterScreen;
            addInventories.Show();
        }

    }
}
