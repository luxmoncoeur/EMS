using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private TabControl tabControl1;
        private TabPage tpageUserRegistration;
        private Panel pnlSideBar;
        private DataGridView dgvUsers;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblFullName;
        private Label lblPassword;
        private TextBox txtAge;
        private Label label2;
        private ComboBox cbSection;
        private Label label1;
        private TextBox txtFullName;
        private Label lblNumber;
        private Label lblMatch;
        private TextBox txtConfirmPassword;
        private Label lblConPass;
        private TextBox txtPassword;
        private Button btnExecute;
        private TabPage tpageSectionRegistration;

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpageUserRegistration = new TabPage();
            dgvUsers = new DataGridView();
            pnlSideBar = new Panel();
            btnExecute = new Button();
            lblNumber = new Label();
            lblMatch = new Label();
            txtConfirmPassword = new TextBox();
            lblConPass = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtAge = new TextBox();
            label2 = new Label();
            cbSection = new ComboBox();
            label1 = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            tpageSectionRegistration = new TabPage();
            tabControl1.SuspendLayout();
            tpageUserRegistration.SuspendLayout();
            ((ISupportInitialize)dgvUsers).BeginInit();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpageUserRegistration);
            tabControl1.Controls.Add(tpageSectionRegistration);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1064, 585);
            tabControl1.TabIndex = 0;
            // 
            // tpageUserRegistration
            // 
            tpageUserRegistration.Controls.Add(dgvUsers);
            tpageUserRegistration.Controls.Add(pnlSideBar);
            tpageUserRegistration.ForeColor = Color.FromArgb(33, 52, 72);
            tpageUserRegistration.Location = new Point(4, 24);
            tpageUserRegistration.Name = "tpageUserRegistration";
            tpageUserRegistration.Padding = new Padding(3);
            tpageUserRegistration.Size = new Size(1056, 557);
            tpageUserRegistration.TabIndex = 0;
            tpageUserRegistration.Text = "User Registration";
            tpageUserRegistration.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(234, 239, 239);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(203, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(850, 551);
            dgvUsers.TabIndex = 1;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(164, 204, 217);
            pnlSideBar.Controls.Add(btnExecute);
            pnlSideBar.Controls.Add(lblNumber);
            pnlSideBar.Controls.Add(lblMatch);
            pnlSideBar.Controls.Add(txtConfirmPassword);
            pnlSideBar.Controls.Add(lblConPass);
            pnlSideBar.Controls.Add(txtPassword);
            pnlSideBar.Controls.Add(lblPassword);
            pnlSideBar.Controls.Add(txtAge);
            pnlSideBar.Controls.Add(label2);
            pnlSideBar.Controls.Add(cbSection);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(txtFullName);
            pnlSideBar.Controls.Add(lblFullName);
            pnlSideBar.Controls.Add(txtUserName);
            pnlSideBar.Controls.Add(lblUserName);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(3, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(0, 30, 0, 0);
            pnlSideBar.Size = new Size(200, 551);
            pnlSideBar.TabIndex = 0;
            // 
            // btnExecute
            // 
            btnExecute.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExecute.Location = new Point(97, 388);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(78, 27);
            btnExecute.TabIndex = 14;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(24, 368);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(67, 20);
            lblNumber.TabIndex = 13;
            lblNumber.Text = "Number";
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatch.Location = new Point(24, 348);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(53, 20);
            lblMatch.TabIndex = 12;
            lblMatch.Text = "Match";
            lblMatch.Click += lblMatch_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(14, 308);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(161, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // lblConPass
            // 
            lblConPass.AutoSize = true;
            lblConPass.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConPass.Location = new Point(14, 285);
            lblConPass.Name = "lblConPass";
            lblConPass.Size = new Size(173, 20);
            lblConPass.TabIndex = 10;
            lblConPass.Text = "Password Confirmation";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(14, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.Location = new Point(24, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(14, 201);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(161, 27);
            txtAge.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 177);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 6;
            label2.Text = "Age";
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 11F);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(14, 146);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(154, 28);
            cbSection.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 122);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 4;
            label1.Text = "Section";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(14, 92);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(161, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFullName.Location = new Point(24, 68);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(88, 21);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(14, 38);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(161, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserName.Location = new Point(24, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            // 
            // tpageSectionRegistration
            // 
            tpageSectionRegistration.ForeColor = Color.FromArgb(33, 52, 72);
            tpageSectionRegistration.Location = new Point(4, 24);
            tpageSectionRegistration.Name = "tpageSectionRegistration";
            tpageSectionRegistration.Padding = new Padding(3);
            tpageSectionRegistration.Size = new Size(1056, 557);
            tpageSectionRegistration.TabIndex = 1;
            tpageSectionRegistration.Text = "Section Registration";
            tpageSectionRegistration.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            ClientSize = new Size(1064, 585);
            Controls.Add(tabControl1);
            Name = "frmSettings";
            Load += frmSettings_Load;
            tabControl1.ResumeLayout(false);
            tpageUserRegistration.ResumeLayout(false);
            ((ISupportInitialize)dgvUsers).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
        }

        private void lblMatch_Click(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"\d"))
            {
                lblNumber.Text = "✔ Number";
                lblNumber.ForeColor = Color.Green;
            }
            else
            {
                lblNumber.Text = "✘ Number";
                lblNumber.ForeColor = Color.Red;
            }
            Match();
        }

        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✔ Match";
                lblMatch.ForeColor = Color.Green;
            }
            else
            {
                lblMatch.Text = "✘ Match";
                lblMatch.ForeColor = Color.Red;
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Match();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "Insert into [Users] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                CRUD.CRUD.CUD(query);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CRUD.CRUD.RETRIEVEDTG(dgvUsers, "SELECT * FROM [tblUsers]");
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
