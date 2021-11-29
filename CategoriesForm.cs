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
    public partial class CategoriesForm : Form
    {
        dbmanager db = new dbmanager();

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void save_inventary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_inventary.Text))
            {

                Category inventary = new Category();
                inventary.Name = txt_inventary.Text;

                db.AddCategory(inventary);
                txt_inventary.Text = "";
                Getinventary();

            }
            else
            {
                MessageBox.Show("ტექსტური ველი ცარიელია!!!");
            }



        }


        private void Getinventary()
        {
            dataGridView1.DataSource = db.GetCategories();
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
