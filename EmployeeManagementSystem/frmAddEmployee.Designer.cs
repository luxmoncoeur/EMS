namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnInsertUpdate = new Button();
            cmbSection = new ComboBox();
            button1 = new Button();
            txtLocalNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            txtEmpID = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.Location = new Point(11, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 19);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Font = new Font("SansSerif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            groupBox1.Location = new Point(1, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual Insert and Update";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.ForeColor = Color.MintCream;
            btnDelete.Location = new Point(387, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 183);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 11;
            label6.Text = "Section:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 151);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 10;
            label5.Text = "Local Number:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 112);
            label4.Name = "label4";
            label4.Size = new Size(125, 19);
            label4.TabIndex = 9;
            label4.Text = "Email Address:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 74);
            label3.Name = "label3";
            label3.Size = new Size(142, 19);
            label3.TabIndex = 8;
            label3.Text = "Requestor Name:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 35);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 7;
            label2.Text = "Employee Number:";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = Color.Teal;
            btnInsertUpdate.ForeColor = Color.MintCream;
            btnInsertUpdate.Location = new Point(202, 228);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(179, 33);
            btnInsertUpdate.TabIndex = 6;
            btnInsertUpdate.Text = "INSERT / UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // cmbSection
            // 
            cmbSection.BackColor = Color.AliceBlue;
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(202, 183);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(289, 27);
            cmbSection.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(476, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.BackColor = Color.AliceBlue;
            txtLocalNumber.Location = new Point(202, 148);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(289, 26);
            txtLocalNumber.TabIndex = 3;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.AliceBlue;
            txtEmailAddress.Location = new Point(202, 109);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(356, 26);
            txtEmailAddress.TabIndex = 2;
            // 
            // txtRequestorName
            // 
            txtRequestorName.BackColor = Color.AliceBlue;
            txtRequestorName.Location = new Point(202, 74);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(356, 26);
            txtRequestorName.TabIndex = 1;
            // 
            // txtEmpID
            // 
            txtEmpID.BackColor = Color.AliceBlue;
            txtEmpID.Location = new Point(202, 31);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(238, 26);
            txtEmpID.TabIndex = 0;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private TextBox txtEmpID;
        private Button btnInsertUpdate;
        private ComboBox cmbSection;
        private Button button1;
        private TextBox txtLocalNumber;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelete;
    }
}