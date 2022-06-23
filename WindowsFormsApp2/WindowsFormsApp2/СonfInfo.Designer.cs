﻿namespace WindowsFormsApp2
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
            System.Windows.Forms.Label equipmentLabel;
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
            this.performancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.performancesListBox = new System.Windows.Forms.ListBox();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            equipmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingNavigator)).BeginInit();
            this.conferenceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).BeginInit();
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
            this.conferenceBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.conferenceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conferenceBindingNavigator.Size = new System.Drawing.Size(1241, 49);
            this.conferenceBindingNavigator.TabIndex = 0;
            this.conferenceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 44);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 49);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(30, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // conferenceBindingNavigatorSaveItem
            // 
            this.conferenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conferenceBindingNavigatorSaveItem.Enabled = false;
            this.conferenceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conferenceBindingNavigatorSaveItem.Image")));
            this.conferenceBindingNavigatorSaveItem.Name = "conferenceBindingNavigatorSaveItem";
            this.conferenceBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.conferenceBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // conferenceListBox
            // 
            this.conferenceListBox.DataSource = this.conferenceBindingSource;
            this.conferenceListBox.DisplayMember = "nameConf";
            this.conferenceListBox.FormattingEnabled = true;
            this.conferenceListBox.ItemHeight = 20;
            this.conferenceListBox.Location = new System.Drawing.Point(59, 95);
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
            this.sectionsListBox.Location = new System.Drawing.Point(680, 95);
            this.sectionsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(467, 244);
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
            this.performancesListBox.Location = new System.Drawing.Point(59, 438);
            this.performancesListBox.Name = "performancesListBox";
            this.performancesListBox.Size = new System.Drawing.Size(300, 204);
            this.performancesListBox.TabIndex = 3;
            this.performancesListBox.ValueMember = "idPerf";
            // 
            // equipmentLabel
            // 
            equipmentLabel.AutoSize = true;
            equipmentLabel.Location = new System.Drawing.Point(744, 526);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new System.Drawing.Size(90, 20);
            equipmentLabel.TabIndex = 4;
            equipmentLabel.Text = "Equipment:";
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performancesBindingSource1, "Equipment", true));
            this.equipmentListBox.FormattingEnabled = true;
            this.equipmentListBox.ItemHeight = 20;
            this.equipmentListBox.Location = new System.Drawing.Point(840, 526);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(120, 84);
            this.equipmentListBox.TabIndex = 5;
            // 
            // СonfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 740);
            this.Controls.Add(equipmentLabel);
            this.Controls.Add(this.equipmentListBox);
            this.Controls.Add(this.performancesListBox);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.conferenceListBox);
            this.Controls.Add(this.conferenceBindingNavigator);
            this.Name = "СonfInfo";
            this.Text = "СonfInfo";
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingNavigator)).EndInit();
            this.conferenceBindingNavigator.ResumeLayout(false);
            this.conferenceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource performancesBindingSource1;
        private System.Windows.Forms.ListBox performancesListBox;
        private System.Windows.Forms.ListBox equipmentListBox;
    }
}