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
            this.speakersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speakersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersDataGridView)).BeginInit();
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
            this.conferenceListBox.Size = new System.Drawing.Size(350, 184);
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
            this.sectionsListBox.Location = new System.Drawing.Point(454, 23);
            this.sectionsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(350, 184);
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
            this.performancesListBox.Location = new System.Drawing.Point(852, 23);
            this.performancesListBox.Name = "performancesListBox";
            this.performancesListBox.Size = new System.Drawing.Size(350, 184);
            this.performancesListBox.TabIndex = 3;
            this.performancesListBox.ValueMember = "idPerf";
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataMember = "Equipments";
            this.equipmentsBindingSource.DataSource = this.performancesBindingSource1;
            // 
            // speakersBindingSource
            // 
            this.speakersBindingSource.DataMember = "Speakers";
            this.speakersBindingSource.DataSource = this.performancesBindingSource1;
            // 
            // equipmentsDataGridView
            // 
            this.equipmentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentsDataGridView.AutoGenerateColumns = false;
            this.equipmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.equipmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.equipmentsDataGridView.DataSource = this.equipmentsBindingSource;
            this.equipmentsDataGridView.Location = new System.Drawing.Point(61, 348);
            this.equipmentsDataGridView.Name = "equipmentsDataGridView";
            this.equipmentsDataGridView.RowHeadersVisible = false;
            this.equipmentsDataGridView.RowHeadersWidth = 62;
            this.equipmentsDataGridView.RowTemplate.Height = 28;
            this.equipmentsDataGridView.Size = new System.Drawing.Size(350, 217);
            this.equipmentsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nameEquip";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва обладнання";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idPerf";
            this.dataGridViewTextBoxColumn3.HeaderText = "idPerf";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Performance";
            this.dataGridViewTextBoxColumn4.HeaderText = "Performance";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // speakersDataGridView
            // 
            this.speakersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speakersDataGridView.AutoGenerateColumns = false;
            this.speakersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.speakersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.speakersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.speakersDataGridView.DataSource = this.speakersBindingSource;
            this.speakersDataGridView.Location = new System.Drawing.Point(454, 348);
            this.speakersDataGridView.Name = "speakersDataGridView";
            this.speakersDataGridView.RowHeadersVisible = false;
            this.speakersDataGridView.RowHeadersWidth = 62;
            this.speakersDataGridView.RowTemplate.Height = 28;
            this.speakersDataGridView.Size = new System.Drawing.Size(748, 217);
            this.speakersDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "degreeSpeaker";
            this.dataGridViewTextBoxColumn6.HeaderText = "Науковий ступінь";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "academStatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Вчене звання";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "placeOfWork";
            this.dataGridViewTextBoxColumn8.HeaderText = "Місце роботи";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "positionSpeaker";
            this.dataGridViewTextBoxColumn9.HeaderText = "Посада";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "profBiogSpeaker";
            this.dataGridViewTextBoxColumn10.HeaderText = "profBiogSpeaker";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idPerf";
            this.dataGridViewTextBoxColumn11.HeaderText = "idPerf";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Performance";
            this.dataGridViewTextBoxColumn12.HeaderText = "Performance";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(61, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Вибрана конференція";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(454, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 28);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Секції які належать до конференції";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(852, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 28);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Виступи у вибраних секціях";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(61, 565);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 28);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Обладнання для виступів";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(454, 565);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(748, 28);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Учасники виступів";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // СonfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 679);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.speakersDataGridView);
            this.Controls.Add(this.equipmentsDataGridView);
            this.Controls.Add(this.performancesListBox);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.conferenceListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "СonfInfo";
            this.Text = "СonfInfo";
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speakersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private System.Windows.Forms.ListBox conferenceListBox;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private System.Windows.Forms.ListBox sectionsListBox;
        private System.Windows.Forms.BindingSource performancesBindingSource1;
        private System.Windows.Forms.ListBox performancesListBox;
        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private System.Windows.Forms.BindingSource speakersBindingSource;
        private System.Windows.Forms.DataGridView equipmentsDataGridView;
        private System.Windows.Forms.DataGridView speakersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}