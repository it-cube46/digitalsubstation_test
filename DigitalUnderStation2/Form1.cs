using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalUnderStation2
{


    public partial class MainForm : Form
    {
      FormLogin fl = new FormLogin();
      FormSelectDevice fsd = new FormSelectDevice();

        public MainForm()
        {
            InitializeComponent();
            
            
            panelTest.Dock = DockStyle.Fill;
            panelBeginShow.Dock = DockStyle.Fill;
            panelSelectTest.Dock = DockStyle.Fill;
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if (fl.ShowDialog() == DialogResult.OK)
            {
                //Подключились
                panelSelectTest.Visible = true;
                panelBeginShow.Visible = false;
                //Подгрузка задания
                //panelTest.Visible = true;
                //

            }
            else
            {
                //ждемс и перелистываем названия
            }
        }

        private void ButtonDeviceList1_Click(object sender, EventArgs e)
        {
            fsd.Show();
        }

        private void ButtonStartTest_Click(object sender, EventArgs e)
        {
            panelSelectTest.Visible = false;
            panelTest.Visible = true;
        }

        private void ButtonBackToMainScreen_Click(object sender, EventArgs e)
        {
            panelSelectTest.Visible = false;
            panelBeginShow.Visible = true;
        }

        private void ListViewTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTests.SelectedItems != null)
            {
                if (listViewTests.SelectedItems[0].Index == 0)
                {
                    buttonStartTest.Enabled = true;
                }
                else
                {
                    buttonStartTest.Enabled = false;
                }
            }

        }

        private void treeViewSelectDevice_DragDrop(object sender, DragEventArgs e)
        {
           if( sender.GetType() == typeof(TreeNode))
            {

            }
        }
    }
}
