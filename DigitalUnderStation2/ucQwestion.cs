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
    public partial class ucQwestion : UserControl
    {
        public string Qwestion
        {
            get { return labelQ.Text; }
            set { labelQ.Text = value; }
        }
        public string Answer1
        {
            get { return radioButtonA1.Text; }
            set { radioButtonA1.Text = value; }
        }

        public string Answer2
        {
            get { return radioButtonA2.Text; }
            set { radioButtonA2.Text = value; }
        }
        public string Answer3
        {
            get { return radioButtonA3.Text; }
            set { radioButtonA3.Text = value; }
        }
        public string Answer4
        {
            get { return radioButtonA4.Text; }
            set { radioButtonA4.Text = value; }
        }
        public int resultss
        {
            get
            {
                if (radioButtonA1.Checked) return 1;
                if (radioButtonA2.Checked) return 2;
                if (radioButtonA3.Checked) return 3;
                if (radioButtonA4.Checked) return 4;
                return 0;
            }
        }

        public int NumberQwestion { get; set; }

        public ucQwestion()
        {
            InitializeComponent();
        }
    }
}
