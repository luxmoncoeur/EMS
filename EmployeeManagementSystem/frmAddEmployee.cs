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
            // Validate required fields
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show("Employee Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRequestorName.Text))
            {
                MessageBox.Show("Requestor Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequestorName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                MessageBox.Show("Email Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtLocalNumber.Text))
            {
                MessageBox.Show("Local Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cmbSection.Text))
            {
                MessageBox.Show("Section is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSection.Focus();
                return;
            }

            // Validate Employee Number (no whitespaces, no special characters)
            if (!IsValidEmployeeNumber(txtEmpID.Text))
            {
                MessageBox.Show("Employee Number cannot contain whitespaces or special characters.", "Invalid Employee Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpID.Focus();
                return;
            }

            // Validate Requestor Name (no special characters except spaces)
            if (!IsValidRequestorName(txtRequestorName.Text))
            {
                MessageBox.Show("Requestor Name cannot contain special characters.", "Invalid Requestor Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequestorName.Focus();
                return;
            }

            // Validate local number format (4 digits only)
            if (!IsValidLocalNumber(txtLocalNumber.Text))
            {
                MessageBox.Show("Local Number must be exactly 4 digits.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocalNumber.Focus();
                return;
            }

            // Validate email format
            if (!IsValidEmail(txtEmailAddress.Text))
            {
                MessageBox.Show("Email must be in correct format and contain '@firstasia.edu.ph'", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Focus();
                return;
            }

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [ID] = " + frmMasterData.selectedTransaction + " OR [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (string.IsNullOrEmpty(frmMasterData.selectedTransaction))
            {
                MessageBox.Show("Please select a record to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE [ID] = " + frmMasterData.selectedTransaction;
                
                if (CRUD.CRUD.CUD(delete_requestor))
                {
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear fields after successful deletion
                    ClearFields();
                    
                    // Clear the selected transaction
                    frmMasterData.selectedTransaction = "";
                    
                    NotifyParentToRefresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber],[RequestorName], [RequestorEmail], [Section],[LocalNumber]) VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotifyParentToRefresh();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(frmMasterData.selectedTransaction))
            {
                MessageBox.Show("Please select a record to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE [ID] = " + frmMasterData.selectedTransaction;
                
                if (CRUD.CRUD.CUD(delete_requestor))
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

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Check if email contains the required domain
            if (!email.EndsWith("@firstasia.edu.ph", StringComparison.OrdinalIgnoreCase))
                return false;

            // Basic email format validation using regex
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidLocalNumber(string localNumber)
        {
            if (string.IsNullOrEmpty(localNumber))
                return false;

            // Check if it's exactly 4 digits
            return Regex.IsMatch(localNumber, @"^\d{4}$");
        }

        private bool IsValidEmployeeNumber(string empNumber)
        {
            if (string.IsNullOrEmpty(empNumber))
                return false;

            // Check if it contains only alphanumeric characters (no whitespaces or special characters)
            return Regex.IsMatch(empNumber, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValidRequestorName(string requestorName)
        {
            if (string.IsNullOrEmpty(requestorName))
                return false;

            // Check if it contains only letters, spaces, and common name characters (no special characters)
            return Regex.IsMatch(requestorName, @"^[a-zA-Z\s\.\-']+$");
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
            // Find the parent frmMasterData form and refresh its data
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMasterData masterDataForm)
                {
                    masterDataForm.RefreshData();
                    break;
                }
            }
        }
    }
}
