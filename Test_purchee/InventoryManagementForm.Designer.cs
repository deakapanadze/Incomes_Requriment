
namespace Test_purchee
{
    partial class InventoryManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementForm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbn_income = new System.Windows.Forms.Button();
            this.requriments = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NameInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_inventaries = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.requriments.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "შესყიდვა";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1103, 524);
            this.dataGridView2.TabIndex = 0;
            // 
            // tbn_income
            // 
            this.tbn_income.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbn_income.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbn_income.Location = new System.Drawing.Point(9, 12);
            this.tbn_income.Name = "tbn_income";
            this.tbn_income.Size = new System.Drawing.Size(102, 36);
            this.tbn_income.TabIndex = 1;
            this.tbn_income.Text = "მოთხოვნა";
            this.tbn_income.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbn_income.UseVisualStyleBackColor = false;
            this.tbn_income.Click += new System.EventHandler(this.tbn_income_Click);
            // 
            // requriments
            // 
            this.requriments.Controls.Add(this.tabPage3);
            this.requriments.Controls.Add(this.tabPage2);
            this.requriments.Location = new System.Drawing.Point(9, 82);
            this.requriments.Name = "requriments";
            this.requriments.SelectedIndex = 0;
            this.requriments.Size = new System.Drawing.Size(1117, 558);
            this.requriments.TabIndex = 0;
            this.requriments.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1109, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "მოთხოვნა";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Quantity,
            this.Col_UserId,
            this.Col_Date,
            this.Col_Description,
            this.Col_Name,
            this.Col_NameInv});
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.ShowRowErrors = false;
            this.dataGridView3.Size = new System.Drawing.Size(1097, 524);
            this.dataGridView3.TabIndex = 0;
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.ReadOnly = true;
            this.Col_Id.Visible = false;
            // 
            // Col_Quantity
            // 
            this.Col_Quantity.DataPropertyName = "Quantity";
            this.Col_Quantity.HeaderText = "რაოდენობა";
            this.Col_Quantity.Name = "Col_Quantity";
            this.Col_Quantity.ReadOnly = true;
            // 
            // Col_UserId
            // 
            this.Col_UserId.DataPropertyName = "UserId";
            this.Col_UserId.HeaderText = "UserId";
            this.Col_UserId.Name = "Col_UserId";
            this.Col_UserId.ReadOnly = true;
            this.Col_UserId.Visible = false;
            // 
            // Col_Date
            // 
            this.Col_Date.DataPropertyName = "Date";
            this.Col_Date.HeaderText = "თარიღი";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.ReadOnly = true;
            // 
            // Col_Description
            // 
            this.Col_Description.DataPropertyName = "Description";
            this.Col_Description.HeaderText = "აღწერა";
            this.Col_Description.Name = "Col_Description";
            this.Col_Description.ReadOnly = true;
            // 
            // Col_Name
            // 
            this.Col_Name.DataPropertyName = "Name";
            this.Col_Name.HeaderText = "განყოფილება";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            // 
            // Col_NameInv
            // 
            this.Col_NameInv.DataPropertyName = "NameInv";
            this.Col_NameInv.HeaderText = "კატეგორია";
            this.Col_NameInv.Name = "Col_NameInv";
            this.Col_NameInv.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_inventaries
            // 
            this.btn_inventaries.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_inventaries.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inventaries.Location = new System.Drawing.Point(120, 12);
            this.btn_inventaries.Name = "btn_inventaries";
            this.btn_inventaries.Size = new System.Drawing.Size(104, 36);
            this.btn_inventaries.TabIndex = 5;
            this.btn_inventaries.Text = "ინვენტარი";
            this.btn_inventaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inventaries.UseVisualStyleBackColor = false;
            this.btn_inventaries.Click += new System.EventHandler(this.btn_inventaries_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(124, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1128, 645);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_inventaries);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbn_income);
            this.Controls.Add(this.requriments);
            this.Name = "InventoryManagementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "შესყიდვის ფორმა";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.requriments.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button tbn_income;
        private System.Windows.Forms.TabControl requriments;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_inventaries;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NameInv;
    }
}

