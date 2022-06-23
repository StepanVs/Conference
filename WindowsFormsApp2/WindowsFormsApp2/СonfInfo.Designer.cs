namespace WindowsFormsApp2
{
    partial class СonfInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceListBox = new System.Windows.Forms.ListBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsListBox = new System.Windows.Forms.ListBox();
            this.performancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.performancesListBox = new System.Windows.Forms.ListBox();
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentsListBox = new System.Windows.Forms.ListBox();
            this.speakersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.speakersListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataSource = typeof(WindowsFormsApp2.Conference);
            // 
            // conferenceListBox
            // 
            this.conferenceListBox.DataSource = this.conferenceBindingSource;
            this.conferenceListBox.DisplayMember = "nameConf";
            this.conferenceListBox.FormattingEnabled = true;
            this.conferenceListBox.ItemHeight = 20;
            this.conferenceListBox.Location = new System.Drawing.Point(61, 23);
            this.conferenceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.conferenceListBox.Name = "conferenceListBox";
            this.conferenceListBox.Size = new System.Drawing.Size(512, 244);
            this.conferenceListBox.TabIndex = 1;
            this.conferenceListBox.ValueMember = "idConf";
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.conferenceBindingSource;
            // 
            // sectionsListBox
            // 
            this.sectionsListBox.DataSource = this.sectionsBindingSource;
            this.sectionsListBox.DisplayMember = "nameSect";
            this.sectionsListBox.FormattingEnabled = true;
            this.sectionsListBox.ItemHeight = 20;
            this.sectionsListBox.Location = new System.Drawing.Point(663, 23);
            this.sectionsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(515, 244);
            this.sectionsListBox.TabIndex = 2;
            this.sectionsListBox.ValueMember = "idSect";
            // 
            // performancesBindingSource1
            // 
            this.performancesBindingSource1.DataMember = "Performances";
            this.performancesBindingSource1.DataSource = this.sectionsBindingSource;
            // 
            // performancesListBox
            // 
            this.performancesListBox.DataSource = this.performancesBindingSource1;
            this.performancesListBox.DisplayMember = "topicrf";
            this.performancesListBox.FormattingEnabled = true;
            this.performancesListBox.ItemHeight = 20;
            this.performancesListBox.Location = new System.Drawing.Point(61, 438);
            this.performancesListBox.Name = "performancesListBox";
            this.performancesListBox.Size = new System.Drawing.Size(300, 204);
            this.performancesListBox.TabIndex = 3;
            this.performancesListBox.ValueMember = "idPerf";
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataMember = "Equipments";
            this.equipmentsBindingSource.DataSource = this.performancesBindingSource1;
            // 
            // equipmentsListBox
            // 
            this.equipmentsListBox.DataSource = this.equipmentsBindingSource;
            this.equipmentsListBox.DisplayMember = "nameEquip";
            this.equipmentsListBox.FormattingEnabled = true;
            this.equipmentsListBox.ItemHeight = 20;
            this.equipmentsListBox.Location = new System.Drawing.Point(463, 438);
            this.equipmentsListBox.Name = "equipmentsListBox";
            this.equipmentsListBox.Size = new System.Drawing.Size(323, 204);
            this.equipmentsListBox.TabIndex = 4;
            this.equipmentsListBox.ValueMember = "idEquip";
            // 
            // speakersBindingSource
            // 
            this.speakersBindingSource.DataMember = "Speakers";
            this.speakersBindingSource.DataSource = this.performancesBindingSource1;
            // 
            // speakersListBox
            // 
            this.speakersListBox.DataSource = this.speakersBindingSource;
            this.speakersListBox.DisplayMember = "degreeSpeaker";
            this.speakersListBox.FormattingEnabled = true;
            this.speakersListBox.ItemHeight = 20;
            this.speakersListBox.Location = new System.Drawing.Point(878, 438);
            this.speakersListBox.Name = "speakersListBox";
            this.speakersListBox.Size = new System.Drawing.Size(300, 204);
            this.speakersListBox.TabIndex = 4;
            this.speakersListBox.ValueMember = "idSpeaker";
            // 
            // СonfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 778);
            this.Controls.Add(this.speakersListBox);
            this.Controls.Add(this.equipmentsListBox);
            this.Controls.Add(this.performancesListBox);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.conferenceListBox);
            this.Name = "СonfInfo";
            this.Text = "СonfInfo";
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private System.Windows.Forms.ListBox conferenceListBox;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private System.Windows.Forms.ListBox sectionsListBox;
        private System.Windows.Forms.BindingSource performancesBindingSource1;
        private System.Windows.Forms.ListBox performancesListBox;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private System.Windows.Forms.ListBox equipmentsListBox;
        private System.Windows.Forms.BindingSource speakersBindingSource;
        private System.Windows.Forms.ListBox speakersListBox;
    }
}