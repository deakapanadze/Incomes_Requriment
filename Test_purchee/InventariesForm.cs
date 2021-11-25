using Test_purchee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test_purchee
{
    public partial class InventariesForm : Form
    {
        dbmanager db = new dbmanager();

        public InventariesForm()
        {
            InitializeComponent();
        }

        private void save_inventary_Click(object sender, EventArgs e)
        {
            Inventories inventary = new Inventories();
            inventary.Name = txt_inventary.Text;

            db.AddInventary(inventary);
            this.Close();


        }


        private void Getinventary()
        {
            dataGridView1.DataSource = db.Getinventary();
        }

        private void InventariesForm_Load(object sender, EventArgs e)
        {
            Getinventary();
        }

        private void txt_inventary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
