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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(СonfInfo));
            System.Windows.Forms.Label academStatusLabel;
            System.Windows.Forms.Label degreeSpeakerLabel;
            System.Windows.Forms.Label idSpeakerLabel;
            System.Windows.Forms.Label placeOfWorkLabel;
            System.Windows.Forms.Label positionSpeakerLabel;
            System.Windows.Forms.Label profBiogSpeakerLabel;
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conferenceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conferenceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.conferenceListBox = new System.Windows.Forms.ListBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionsListBox = new System.Windows.Forms.ListBox();
            this.performancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performancesListBox = new System.Windows.Forms.ListBox();
            this.perfAndSpeakersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfAndSpeakersListBox = new System.Windows.Forms.ListBox();
            this.academStatusTextBox = new System.Windows.Forms.TextBox();
            this.degreeSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.idSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.placeOfWorkTextBox = new System.Windows.Forms.TextBox();
            this.positionSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.profBiogSpeakerTextBox = new System.Windows.Forms.TextBox();
            academStatusLabel = new System.Windows.Forms.Label();
            degreeSpeakerLabel = new System.Windows.Forms.Label();
            idSpeakerLabel = new System.Windows.Forms.Label();
            placeOfWorkLabel = new System.Windows.Forms.Label();
            positionSpeakerLabel = new System.Windows.Forms.Label();
            profBiogSpeakerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingNavigator)).BeginInit();
            this.conferenceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfAndSpeakersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataSource = typeof(WindowsFormsApp2.Conference);
            // 
            // conferenceBindingNavigator
            // 
            this.conferenceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.conferenceBindingNavigator.BindingSource = this.conferenceBindingSource;
            this.conferenceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conferenceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.conferenceBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.conferenceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.conferenceBindingNavigatorSaveItem});
            this.conferenceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.conferenceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.conferenceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.conferenceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.conferenceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.conferenceBindingNavigator.Name = "conferenceBindingNavigator";
            this.conferenceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conferenceBindingNavigator.Size = new System.Drawing.Size(2206, 51);
            this.conferenceBindingNavigator.TabIndex = 0;
            this.conferenceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(107, 44);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(58, 44);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // conferenceBindingNavigatorSaveItem
            // 
            this.conferenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conferenceBindingNavigatorSaveItem.Enabled = false;
            this.conferenceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conferenceBindingNavigatorSaveItem.Image")));
            this.conferenceBindingNavigatorSaveItem.Name = "conferenceBindingNavigatorSaveItem";
            this.conferenceBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 44);
            this.conferenceBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // conferenceListBox
            // 
            this.conferenceListBox.DataSource = this.conferenceBindingSource;
            this.conferenceListBox.DisplayMember = "nameConf";
            this.conferenceListBox.FormattingEnabled = true;
            this.conferenceListBox.ItemHeight = 31;
            this.conferenceListBox.Location = new System.Drawing.Point(105, 147);
            this.conferenceListBox.Name = "conferenceListBox";
            this.conferenceListBox.Size = new System.Drawing.Size(907, 376);
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
            this.sectionsListBox.ItemHeight = 31;
            this.sectionsListBox.Location = new System.Drawing.Point(1208, 147);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(827, 376);
            this.sectionsListBox.TabIndex = 2;
            this.sectionsListBox.ValueMember = "idSect";
            // 
            // performancesBindingSource
            // 
            this.performancesBindingSource.DataMember = "Performances";
            this.performancesBindingSource.DataSource = this.sectionsBindingSource;
            // 
            // performancesListBox
            // 
            this.performancesListBox.DataSource = this.performancesBindingSource;
            this.performancesListBox.DisplayMember = "topicPerf";
            this.performancesListBox.FormattingEnabled = true;
            this.performancesListBox.ItemHeight = 31;
            this.performancesListBox.Location = new System.Drawing.Point(105, 647);
            this.performancesListBox.Name = "performancesListBox";
            this.performancesListBox.Size = new System.Drawing.Size(907, 314);
            this.performancesListBox.TabIndex = 3;
            this.performancesListBox.ValueMember = "idPerf";
            // 
            // perfAndSpeakersBindingSource
            // 
            this.perfAndSpeakersBindingSource.DataMember = "PerfAndSpeakers";
            this.perfAndSpeakersBindingSource.DataSource = this.performancesBindingSource;
            // 
            // perfAndSpeakersListBox
            // 
            this.perfAndSpeakersListBox.DataSource = this.perfAndSpeakersBindingSource;
            this.perfAndSpeakersListBox.DisplayMember = "idSpeaker";
            this.perfAndSpeakersListBox.FormattingEnabled = true;
            this.perfAndSpeakersListBox.ItemHeight = 31;
            this.perfAndSpeakersListBox.Location = new System.Drawing.Point(1242, 680);
            this.perfAndSpeakersListBox.Name = "perfAndSpeakersListBox";
            this.perfAndSpeakersListBox.Size = new System.Drawing.Size(300, 190);
            this.perfAndSpeakersListBox.TabIndex = 4;
            this.perfAndSpeakersListBox.ValueMember = "idSpeaker";
            // 
            // academStatusLabel
            // 
            academStatusLabel.AutoSize = true;
            academStatusLabel.Location = new System.Drawing.Point(1823, 767);
            academStatusLabel.Name = "academStatusLabel";
            academStatusLabel.Size = new System.Drawing.Size(211, 32);
            academStatusLabel.TabIndex = 5;
            academStatusLabel.Text = "academ Status:";
            // 
            // academStatusTextBox
            // 
            this.academStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.academStatus", true));
            this.academStatusTextBox.Location = new System.Drawing.Point(2078, 764);
            this.academStatusTextBox.Name = "academStatusTextBox";
            this.academStatusTextBox.Size = new System.Drawing.Size(100, 38);
            this.academStatusTextBox.TabIndex = 6;
            // 
            // degreeSpeakerLabel
            // 
            degreeSpeakerLabel.AutoSize = true;
            degreeSpeakerLabel.Location = new System.Drawing.Point(1823, 811);
            degreeSpeakerLabel.Name = "degreeSpeakerLabel";
            degreeSpeakerLabel.Size = new System.Drawing.Size(224, 32);
            degreeSpeakerLabel.TabIndex = 7;
            degreeSpeakerLabel.Text = "degree Speaker:";
            // 
            // degreeSpeakerTextBox
            // 
            this.degreeSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.degreeSpeaker", true));
            this.degreeSpeakerTextBox.Location = new System.Drawing.Point(2078, 808);
            this.degreeSpeakerTextBox.Name = "degreeSpeakerTextBox";
            this.degreeSpeakerTextBox.Size = new System.Drawing.Size(100, 38);
            this.degreeSpeakerTextBox.TabIndex = 8;
            // 
            // idSpeakerLabel
            // 
            idSpeakerLabel.AutoSize = true;
            idSpeakerLabel.Location = new System.Drawing.Point(1823, 855);
            idSpeakerLabel.Name = "idSpeakerLabel";
            idSpeakerLabel.Size = new System.Drawing.Size(158, 32);
            idSpeakerLabel.TabIndex = 9;
            idSpeakerLabel.Text = "id Speaker:";
            // 
            // idSpeakerTextBox
            // 
            this.idSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.idSpeaker", true));
            this.idSpeakerTextBox.Location = new System.Drawing.Point(2078, 852);
            this.idSpeakerTextBox.Name = "idSpeakerTextBox";
            this.idSpeakerTextBox.Size = new System.Drawing.Size(100, 38);
            this.idSpeakerTextBox.TabIndex = 10;
            // 
            // placeOfWorkLabel
            // 
            placeOfWorkLabel.AutoSize = true;
            placeOfWorkLabel.Location = new System.Drawing.Point(1823, 899);
            placeOfWorkLabel.Name = "placeOfWorkLabel";
            placeOfWorkLabel.Size = new System.Drawing.Size(200, 32);
            placeOfWorkLabel.TabIndex = 11;
            placeOfWorkLabel.Text = "place Of Work:";
            // 
            // placeOfWorkTextBox
            // 
            this.placeOfWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.placeOfWork", true));
            this.placeOfWorkTextBox.Location = new System.Drawing.Point(2078, 896);
            this.placeOfWorkTextBox.Name = "placeOfWorkTextBox";
            this.placeOfWorkTextBox.Size = new System.Drawing.Size(100, 38);
            this.placeOfWorkTextBox.TabIndex = 12;
            // 
            // positionSpeakerLabel
            // 
            positionSpeakerLabel.AutoSize = true;
            positionSpeakerLabel.Location = new System.Drawing.Point(1823, 943);
            positionSpeakerLabel.Name = "positionSpeakerLabel";
            positionSpeakerLabel.Size = new System.Drawing.Size(235, 32);
            positionSpeakerLabel.TabIndex = 13;
            positionSpeakerLabel.Text = "position Speaker:";
            // 
            // positionSpeakerTextBox
            // 
            this.positionSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.positionSpeaker", true));
            this.positionSpeakerTextBox.Location = new System.Drawing.Point(2078, 940);
            this.positionSpeakerTextBox.Name = "positionSpeakerTextBox";
            this.positionSpeakerTextBox.Size = new System.Drawing.Size(100, 38);
            this.positionSpeakerTextBox.TabIndex = 14;
            // 
            // profBiogSpeakerLabel
            // 
            profBiogSpeakerLabel.AutoSize = true;
            profBiogSpeakerLabel.Location = new System.Drawing.Point(1823, 987);
            profBiogSpeakerLabel.Name = "profBiogSpeakerLabel";
            profBiogSpeakerLabel.Size = new System.Drawing.Size(249, 32);
            profBiogSpeakerLabel.TabIndex = 15;
            profBiogSpeakerLabel.Text = "prof Biog Speaker:";
            // 
            // profBiogSpeakerTextBox
            // 
            this.profBiogSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfAndSpeakersBindingSource, "Speaker.profBiogSpeaker", true));
            this.profBiogSpeakerTextBox.Location = new System.Drawing.Point(2078, 984);
            this.profBiogSpeakerTextBox.Name = "profBiogSpeakerTextBox";
            this.profBiogSpeakerTextBox.Size = new System.Drawing.Size(100, 38);
            this.profBiogSpeakerTextBox.TabIndex = 16;
            // 
            // СonfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2206, 1048);
            this.Controls.Add(academStatusLabel);
            this.Controls.Add(this.academStatusTextBox);
            this.Controls.Add(degreeSpeakerLabel);
            this.Controls.Add(this.degreeSpeakerTextBox);
            this.Controls.Add(idSpeakerLabel);
            this.Controls.Add(this.idSpeakerTextBox);
            this.Controls.Add(placeOfWorkLabel);
            this.Controls.Add(this.placeOfWorkTextBox);
            this.Controls.Add(positionSpeakerLabel);
            this.Controls.Add(this.positionSpeakerTextBox);
            this.Controls.Add(profBiogSpeakerLabel);
            this.Controls.Add(this.profBiogSpeakerTextBox);
            this.Controls.Add(this.perfAndSpeakersListBox);
            this.Controls.Add(this.performancesListBox);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.conferenceListBox);
            this.Controls.Add(this.conferenceBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "СonfInfo";
            this.Text = "СonfInfo";
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingNavigator)).EndInit();
            this.conferenceBindingNavigator.ResumeLayout(false);
            this.conferenceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfAndSpeakersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private System.Windows.Forms.BindingNavigator conferenceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton conferenceBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox conferenceListBox;
        private System.Windows.Forms.BindingSource sectionsBindingSource;
        private System.Windows.Forms.ListBox sectionsListBox;
        private System.Windows.Forms.BindingSource performancesBindingSource;
        private System.Windows.Forms.ListBox performancesListBox;
        private System.Windows.Forms.BindingSource perfAndSpeakersBindingSource;
        private System.Windows.Forms.ListBox perfAndSpeakersListBox;
        private System.Windows.Forms.TextBox academStatusTextBox;
        private System.Windows.Forms.TextBox degreeSpeakerTextBox;
        private System.Windows.Forms.TextBox idSpeakerTextBox;
        private System.Windows.Forms.TextBox placeOfWorkTextBox;
        private System.Windows.Forms.TextBox positionSpeakerTextBox;
        private System.Windows.Forms.TextBox profBiogSpeakerTextBox;
    }
}