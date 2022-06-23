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
            conferenceBindingSource.DataSource = DB_context.Conferences.Local.ToBindingList();
            equipmentBindingSource.DataSource = DB_context.Equipments.Local.ToBindingList();
            performanceBindingSource.DataSource = DB_context.Performances.Local.ToBindingList();
            speakerBindingSource.DataSource = DB_context.Speakers.Local.ToBindingList();
            roomBindingSource.DataSource = DB_context.Rooms.Local.ToBindingList();
            sectionBindingSource.DataSource = DB_context.Sections.Local.ToBindingList();
            this.equipmentDataGridView.Columns[0].Visible = false;
            this.conferenceDataGridView.Columns[0].Visible = false;
            this.sectionDataGridView.Columns[0].Visible = false;
            this.roomDataGridView.Columns[0].Visible = false;
            this.speakerDataGridView.Columns[0].Visible = false;
            this.performanceDataGridView.Columns[0].Visible = false;
            //conferenceBindingSource1.DataSource = DB_context.Conferences.Local.ToBindingList();
            //sectionsBindingSource.DataSource = DB_context.Sections.Local.ToBindingList();
            //roomBindingSource1.DataSource = DB_context.Rooms.Local.ToBindingList();
            //sectionsBindingSource.DataSource = DB_context.Sections.Local.ToBindingList();
        }

        private void conferenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            conferenceDataGridView.EndEdit();
            DB_context.SaveChanges();
            conferenceDataGridView.Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void SectiontoolStripButton1_Click(object sender, EventArgs e)
        {
            sectionDataGridView.EndEdit();
            DB_context.SaveChanges();
            sectionDataGridView.Refresh();
        }

        private void EquipmenttoolStripButton2_Click(object sender, EventArgs e)
        {
            equipmentDataGridView.EndEdit();
            DB_context.SaveChanges();
            equipmentDataGridView.Refresh();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            roomDataGridView.EndEdit();
            DB_context.SaveChanges();
            roomDataGridView.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            performanceDataGridView.EndEdit();
            DB_context.SaveChanges();
            performanceDataGridView.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            speakerDataGridView.EndEdit();
            DB_context.SaveChanges();
            speakerDataGridView.Refresh();
        }

        private void sectionDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 form2 = new Form2(sectionBindingSource, conferenceBindingSource, roomBindingSource);
            form2.Owner = this;

            if (form2.ShowDialog() == DialogResult.Cancel)
                DB_context.Entry(sectionBindingSource.Current).State = EntityState.Unchanged;
            else
                DB_context.Entry(sectionBindingSource.Current).State = EntityState.Modified;

            DB_context.SaveChanges();
        }

        private void conferenceDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            СonfInfo сonfInfo = new СonfInfo(conferenceBindingSource, sectionBindingSource, roomBindingSource);
            сonfInfo.Owner = this;

            DB_context.SaveChanges();
            сonfInfo.ShowDialog();
        }
    }
}
