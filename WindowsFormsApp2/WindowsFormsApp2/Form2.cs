using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2(BindingSource SectbindingSource, BindingSource ConfbindingSource, BindingSource RoombindingSource)
        {
            InitializeComponent();
            sectionBindingSource.DataSource = SectbindingSource.Current;
            conferenceBindingSource.DataSource = ConfbindingSource;
            roomBindingSource.DataSource = RoombindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void headSectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
