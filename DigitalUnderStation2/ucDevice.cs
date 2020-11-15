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

namespace DigitalUnderStation2
{
    public partial class ucDevice : UserControl
    {
        public FormDeviceProperties fdp = new FormDeviceProperties();

        public string NameDev { get; set; }
        public bool SendGOOSE = false;

        public Image picture
        {
            get { return pictureBoxDevice.Image; }
            set { pictureBoxDevice.Image = value; }
        }

        public ucDevice()
        {
            InitializeComponent();
        }

        private void buttonProp_Click(object sender, EventArgs e)
        {
            fdp.NameDevice = NameDev;
            fdp.ShowDialog();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            SendGOOSE = true;
        }
    }
}
