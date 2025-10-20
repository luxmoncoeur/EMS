using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = frmMasterData.EmployeeNumber;
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            cmbSection.Text = frmMasterData.Section;
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "Select * from [tblEmployeeData] where EmployeeNumber = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);


            if (string.IsNullOrEmpty(txtEmpID.Text) || string.IsNullOrEmpty(txtRequestorName.Text) || string.IsNullOrEmpty(txtEmailAddress.Text) || string.IsNullOrEmpty(cmbSection.Text) || string.IsNullOrEmpty(txtLocalNumber.Text))
            {
                MessageBox.Show("Information Incomplete, Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmailAddress.Text.Contains("@firstasia.edu.ph") == false)
            {
                MessageBox.Show("Please enter your first asia email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtg_addrequestor == true)
            {

                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' already exists!, Do you want to update the record?", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    string update_requestor = "Update [tblEmployeeData] set [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' where [EmployeeNumber] = '" + txtEmpID.Text + "'";
                    CRUD.CRUD.CUD(update_requestor);
                    MessageBox.Show("Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtEmailAddress.Clear();
                    txtEmpID.Clear();
                    txtLocalNumber.Clear();
                    txtRequestorName.Clear();
                    this.Close();
                }
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber],[RequestorName],[RequestorEmail],[Section],[LocalNumber]) " +
                    "values ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();

        }


        private void ClearFields()
        {
            txtEmpID.Clear();
            txtRequestorName.Clear();
            txtEmailAddress.Clear();
            txtLocalNumber.Clear();
            cmbSection.SelectedIndex = -1;
        }

        private void NotifyParentToRefresh()
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMasterData masterDataForm)
                {
                    masterDataForm.RefreshData();
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(frmMasterData.selectedTransaction))
            {
                MessageBox.Show("Please select a record to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string deleteRequestor = $"DELETE FROM [tblEmployeeData] WHERE [ID] = {frmMasterData.selectedTransaction}";


                if (CRUD.CRUD.CUD(deleteRequestor))
                {
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NotifyParentToRefresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee Number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchQuery = $"SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '{txtEmpID.Text}'";

            // Use CRUD.RETRIEVESINGLE to check if employee exists
            bool employeeExists = CRUD.CRUD.RETRIEVESINGLE(searchQuery);

            if (employeeExists)
            {
                MessageBox.Show("Employee found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpID.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Optionally clear fields or handle as needed
                txtEmpID.Clear();
            }
        }

        private void cmbSection_DropDown(object sender, EventArgs e)
        {

            try
            {
                cmbSection.DataSource = null;
                cmbSection.Items.Clear();

                bool loaded = CRUD.CRUD.RETRIEVECBO(cmbSection, "SELECT ID, Section FROM tblSections", "Section", "ID");

                if (!loaded)
                {
                    MessageBox.Show("Failed to load sections.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sections: " + ex.Message);
            }
        }
    }
} 
