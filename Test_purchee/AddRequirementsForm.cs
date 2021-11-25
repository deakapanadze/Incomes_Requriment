using System;
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
    public partial class AddRequirementsForm : Form
    {
        dbmanager db = new dbmanager();
       InventoryManagementForm _form;

        public AddRequirementsForm(InventoryManagementForm form1)
        {
            this._form = form1;
            InitializeComponent();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Requirements requirements = new Requirements();
            requirements.InventoryId = Convert.ToInt32(cmb_inventary.SelectedValue);
            requirements.DepartmentID = Convert.ToInt32(cmb_Department.SelectedValue);
            requirements.Quantity = Convert.ToInt32(txt_Quantity.Text);
            requirements.Date = Convert.ToDateTime(dtp_Date.Text);
            requirements.Description = Convert.ToString(txt_Description.Text);

            db.AddRequirements(requirements);
            this.Close();
           

        }


        private void AddRequirementsForm_Load(object sender, EventArgs e)
        {
            // ასარჩევი დეპარტამენტი Combox
            cmb_Department.DataSource = db.GetDepartaments2();
            cmb_Department.DisplayMember = "Name";
            cmb_Department.ValueMember = "Id";

            // ასარჩევი ინვენტარი Combox
            cmb_inventary.DataSource = db.Getinventary();
            cmb_inventary.DisplayMember = "Name";
            cmb_inventary.ValueMember = "Id";
        }
    }
}
