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
    public partial class EquipmentInfo : Form
    {
        public EquipmentInfo(BindingSource EquipbindingSource, BindingSource PerfbindingSource)
        {
            InitializeComponent();
            equipmentBindingSource.DataSource = EquipbindingSource.Current;
            performanceBindingSource.DataSource = PerfbindingSource;
        }
    }
}
