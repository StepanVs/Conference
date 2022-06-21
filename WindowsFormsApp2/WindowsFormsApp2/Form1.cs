using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        СonferenceEntities3 DB_context;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB_context.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB_context = new СonferenceEntities3();
            DB_context.Equipments.Load();
            DB_context.Conferences.Load();
            DB_context.Performances.Load();
            DB_context.Speakers.Load();
            DB_context.Rooms.Load();
            DB_context.Sections.Load();
            conferenceDataGridView.DataSource = DB_context.Conferences.Local.ToBindingList();
            equipmentDataGridView.DataSource = DB_context.Equipments.Local.ToBindingList();
            performanceDataGridView.DataSource = DB_context.Performances.Local.ToBindingList();
            speakerDataGridView.DataSource = DB_context.Speakers.Local.ToBindingList();
            roomDataGridView.DataSource = DB_context.Rooms.Local.ToBindingList();
            sectionDataGridView.DataSource = DB_context.Sections.Local.ToBindingList();
        }

        private void conferenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            equipmentDataGridView.EndEdit();
            conferenceDataGridView.EndEdit();
            performanceDataGridView.EndEdit();
            speakerDataGridView.EndEdit();
            roomDataGridView.EndEdit();
            sectionDataGridView.EndEdit();
            DB_context.SaveChanges();
            equipmentDataGridView.Refresh();
            conferenceDataGridView.Refresh();
            performanceDataGridView.Refresh();
            speakerDataGridView.Refresh();
            roomDataGridView.Refresh();
            sectionDataGridView.Refresh();


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           
        }

        private void equipmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void conferenceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
