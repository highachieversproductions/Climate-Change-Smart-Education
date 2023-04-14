using FontAwesome.Sharp;
using RJCodeAdvance.RJControls;
using System.Runtime.InteropServices;

namespace ccse
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public Form1()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelmanu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(238, 204, 68);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Hierarchy());
        }

        private void paneltitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }



        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(iconButton3, iconButton3.Width, 0);
            OpenChildForm(new green());
            ActivateButton(sender, RGBColors.color2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rjDropdownMenu1.IsMainMenu = true;
            rjDropdownMenu2.IsMainMenu = true;
            rjDropdownMenu3.IsMainMenu = true;
            rjDropdownMenu4.IsMainMenu = true;
            rjDropdownMenu5.IsMainMenu = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new climate_1());
            ActivateButton(sender, RGBColors.color3);
        }

        private void burningCoalOilAndGasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new oil());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            rjDropdownMenu2.Show(iconButton4, iconButton4.Width, 0);
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            rjDropdownMenu3.Show(iconButton5, iconButton5.Width, 0);
            ActivateButton(sender, RGBColors.color6);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            rjDropdownMenu4.Show(iconButton6, iconButton6.Width, 0);
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            rjDropdownMenu5.Show(iconButton7, iconButton7.Width, 0);
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new links());
        }

        private void infrastructureDevelopmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new infrasture());
        }

        private void agriculturalExpansionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Agricultural_expansion());
        }

        private void unsustainableCharcoalProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Unsustainable_charcoal_production());
        }

        private void lateFiresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Late_Fires());
        }

        private void increasingLivestockFarmingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Increasing_livestock_farming());
        }

        private void fertilizersContainingNitrogenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Fertilizers_containing_nitrogen());
        }

        private void fluorinatedGasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }


}