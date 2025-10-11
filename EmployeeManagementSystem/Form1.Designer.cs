namespace EmployeeManagementSystem
{
    partial class frmMotherForm
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
            pnlSideMenu = new Panel();
            btnAddEmployee = new Button();
            btnMasterData = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.PowderBlue;
            pnlSideMenu.Controls.Add(btnAddEmployee);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.ForeColor = SystemColors.ActiveCaptionText;
            pnlSideMenu.Location = new Point(0, 48);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(229, 449);
            pnlSideMenu.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.DarkSlateGray;
            btnAddEmployee.Dock = DockStyle.Top;
            btnAddEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(0, 54);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(229, 54);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = " ADD EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = Color.DarkSlateGray;
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasterData.ForeColor = Color.White;
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(229, 54);
            btnMasterData.TabIndex = 0;
            btnMasterData.Text = "MASTER DATA";
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.AccessibleName = "";
            pnlTitleBar.BackColor = Color.PowderBlue;
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 48);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(255, 96, 92);
            btnClose.Location = new Point(780, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(0, 202, 78);
            btnMaximize.Location = new Point(738, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(36, 29);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(255, 189, 68);
            btnMinimize.ForeColor = SystemColors.ControlText;
            btnMinimize.Location = new Point(696, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 29);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "━\r\n";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = Color.Ivory;
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(229, 48);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(599, 449);
            pnlStage.TabIndex = 2;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Name = "frmMotherForm";
            Text = "Form1";
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnAddEmployee;
        private Button btnMasterData;
        private Panel pnlStage;
    }
}
