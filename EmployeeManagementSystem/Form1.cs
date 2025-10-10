namespace EmployeeManagementSystem
{
    public partial class frmMotherForm : Form
    {
        public frmMotherForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMotherForm_Load(object sender, EventArgs e) // form load
        {
            this.Text = string.Empty; // para mawala ang title sa form
            this.ControlBox = false; // para mawala ang minimize, maximize, close button
            this.DoubleBuffered = true; // para mawala ang flicker sa form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // para ma maximize ang form sa working area lang


        }
        private Button btn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childForm);
            pnlStage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //para ma drag ang form sa screen
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            clearDetails();
            OpenChildForm(new frmAddEmployee());
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            clearDetails();
            OpenChildForm(new frmMasterData());
        }
        private void clearDetails()
        {
            frmMasterData.selectedTransaction = "";
            frmMasterData.EmployeeNumber = "";
            frmMasterData.RequestorName = "";
            frmMasterData.Section = "";
            frmMasterData.LocalNumber = "";
            frmMasterData.EmailAddress = "";
        }



    }
}
