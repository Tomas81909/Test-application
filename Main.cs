using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        { 
            panel1ToolsSubmenu.Visible = false;
            panelOtherSubMenu.Visible = false;
            // Other ways to customize the design
        }
        private void hideSubMenu()
        {
            if(panel1ToolsSubmenu.Visible == true)
                panel1ToolsSubmenu.Visible = false;
            if(panelOtherSubMenu.Visible == true)
                panelOtherSubMenu.Visible=false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) 
            { 
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new SQL_Crud_app().Show();
            this.Hide();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1ToolsSubmenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOtherSubMenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a project for C# Windows Form application. ");
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
