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
    public partial class СonfInfo : Form
    {
        public СonfInfo(BindingSource ConfbindingSource, BindingSource SectbindingSource, BindingSource RoombindingSource)
        {
            InitializeComponent();
            conferenceBindingSource.DataSource = ConfbindingSource;
            sectionsBindingSource.DataSource = SectbindingSource;
        }

    }
}
