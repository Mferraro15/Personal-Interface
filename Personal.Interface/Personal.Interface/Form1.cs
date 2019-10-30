using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Personal.Interface
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
               
        private void ButtonCancelAppTab_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
         
        }
         
        private void TabPage1_Click(object sender, EventArgs e)
        {
         
        }

        private void AppComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AppNameSelected = AppComboBox.Text;

            if (AppNameSelected.Length < 2)
            {
                AppVersionComboBox.SelectedIndex = -1;
                if (AppNameSelected.Length == 0)
                    AppVersionComboBox.DataSource = null;
            }
            else
            {
                AppVersionComboBox.DataSource = DatabaseAppQuery.QueryAppVersion(AppNameSelected);
            }
        }
        
        private void AppVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AppVersion = AppVersionComboBox.Text;
            
            if (AppVersion.Length < 1) 
            {
                AppLogoPictureBox.Image = Image.FromFile(@"logo\PLM-Integration.png");
            }
            else
            {
                AppLogoPictureBox.Image = Image.FromFile(DatabaseAppQuery.QueryLogo(AppVersion));
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppComboBox.DataSource = DatabaseAppQuery.QueryAppDistinct();
            AppComboBox.SelectedIndex = -1;
            AppLogoPictureBox.Image = Image.FromFile(@"logo\PLM-Integration.png");
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
                
        }

        private void ButtonAddAppTab_Click_1(object sender, EventArgs e)
        {
            DatabaseAppQuery.SqlAccountInfo();
            if(AppComboBox.Text.Length < 1)
            {
                MessageBox.Show("You have to choose an Application.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(DatabaseAppQuery.QueryAppCommandLine(AppComboBox.Text, AppVersionComboBox.Text));
                if (!AppList.Items.Contains(AppComboBox.Text + " - " + AppVersionComboBox.Text))
                {
                    AppList.Items.Add(AppComboBox.Text + " - " + AppVersionComboBox.Text);
                    AppComboBox.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("The App you are trying to add is already in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void ButtonCleanAppTab_Click_1(object sender, EventArgs e)
        {
            DatabaseAppQuery.QueryAll();
            AppList.Items.Clear();
        }

        private void ButtonRemoveAppTab_Click_2(object sender, EventArgs e)
        {
            if (AppList.SelectedItems.Count != 0)
            {
                while (AppList.SelectedIndex != -1)
                {
                    AppList.Items.RemoveAt(AppList.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please choose an App to be removed from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonOKAppTab_Click(object sender, EventArgs e)
        {

        }

        private void AppComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
