namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            btnEditData = new Button();
            lblTransactionNo = new Label();
            pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = Color.LightCyan;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 48);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblMasterData.ForeColor = SystemColors.InfoText;
            lblMasterData.Location = new Point(12, 9);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(151, 22);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "MASTER DATA";
            lblMasterData.Click += lblMasterData_Click;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = Color.Ivory;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgMasterData.GridColor = SystemColors.ActiveCaptionText;
            dtgMasterData.Location = new Point(0, 48);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 275);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnEditData.Location = new Point(585, 329);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(149, 39);
            btnEditData.TabIndex = 2;
            btnEditData.Text = "EDIT DATA";
            btnEditData.UseVisualStyleBackColor = true;
            btnEditData.Click += btnEditData_Click;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("SansSerif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 2);
            lblTransactionNo.Location = new Point(16, 343);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(160, 15);
            lblTransactionNo.TabIndex = 3;
            lblTransactionNo.Text = "TRANSACTION NUMBER";
            // 
            // frmMasterData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 373);
            Controls.Add(lblTransactionNo);
            Controls.Add(btnEditData);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            Padding = new Padding(0, 0, 0, 50);
            Text = "frmMasterData";
            Load += frmMasterData_Load_1;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChildTitle;
        private Label lblMasterData;
        private DataGridView dtgMasterData;
        private Button btnEditData;
        private Label lblTransactionNo;
    }
}