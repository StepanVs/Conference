namespace WindowsFormsApp2
{
    partial class EquipmentInfo
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
            System.Windows.Forms.Label idPerfLabel;
            System.Windows.Forms.Label nameEquipLabel;
            System.Windows.Forms.Label datetimePerfLabel;
            System.Windows.Forms.Label durationPerfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentInfo));
            this.equipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.equipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameEquipTextBox = new System.Windows.Forms.TextBox();
            this.datetimePerfDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.durationPerfTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idPerfLabel = new System.Windows.Forms.Label();
            nameEquipLabel = new System.Windows.Forms.Label();
            datetimePerfLabel = new System.Windows.Forms.Label();
            durationPerfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingNavigator)).BeginInit();
            this.equipmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idPerfLabel
            // 
            idPerfLabel.AutoSize = true;
            idPerfLabel.Location = new System.Drawing.Point(111, 189);
            idPerfLabel.Name = "idPerfLabel";
            idPerfLabel.Size = new System.Drawing.Size(106, 20);
            idPerfLabel.TabIndex = 3;
            idPerfLabel.Text = "Для виступу:";
            // 
            // nameEquipLabel
            // 
            nameEquipLabel.AutoSize = true;
            nameEquipLabel.Location = new System.Drawing.Point(111, 142);
            nameEquipLabel.Name = "nameEquipLabel";
            nameEquipLabel.Size = new System.Drawing.Size(157, 20);
            nameEquipLabel.TabIndex = 5;
            nameEquipLabel.Text = "Назва обладнання:";
            // 
            // datetimePerfLabel
            // 
            datetimePerfLabel.AutoSize = true;
            datetimePerfLabel.Location = new System.Drawing.Point(111, 221);
            datetimePerfLabel.Name = "datetimePerfLabel";
            datetimePerfLabel.Size = new System.Drawing.Size(104, 20);
            datetimePerfLabel.TabIndex = 7;
            datetimePerfLabel.Text = "Час виступу:";
            // 
            // durationPerfLabel
            // 
            durationPerfLabel.AutoSize = true;
            durationPerfLabel.Location = new System.Drawing.Point(111, 253);
            durationPerfLabel.Name = "durationPerfLabel";
            durationPerfLabel.Size = new System.Drawing.Size(159, 20);
            durationPerfLabel.TabIndex = 9;
            durationPerfLabel.Text = "Тривалість виступу:";
            // 
            // equipmentBindingNavigator
            // 
            this.equipmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipmentBindingNavigator.BindingSource = this.equipmentBindingSource;
            this.equipmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.equipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.equipmentBindingNavigatorSaveItem});
            this.equipmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipmentBindingNavigator.Name = "equipmentBindingNavigator";
            this.equipmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipmentBindingNavigator.Size = new System.Drawing.Size(608, 33);
            this.equipmentBindingNavigator.TabIndex = 0;
            this.equipmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(WindowsFormsApp2.Equipment);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // equipmentBindingNavigatorSaveItem
            // 
            this.equipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equipmentBindingNavigatorSaveItem.Enabled = false;
            this.equipmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipmentBindingNavigatorSaveItem.Image")));
            this.equipmentBindingNavigatorSaveItem.Name = "equipmentBindingNavigatorSaveItem";
            this.equipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.equipmentBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // nameEquipTextBox
            // 
            this.nameEquipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "nameEquip", true));
            this.nameEquipTextBox.Location = new System.Drawing.Point(278, 136);
            this.nameEquipTextBox.Name = "nameEquipTextBox";
            this.nameEquipTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameEquipTextBox.TabIndex = 6;
            // 
            // datetimePerfDateTimePicker
            // 
            this.datetimePerfDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentBindingSource, "Performance.datetimePerf", true));
            this.datetimePerfDateTimePicker.Enabled = false;
            this.datetimePerfDateTimePicker.Location = new System.Drawing.Point(278, 215);
            this.datetimePerfDateTimePicker.Name = "datetimePerfDateTimePicker";
            this.datetimePerfDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.datetimePerfDateTimePicker.TabIndex = 8;
            // 
            // durationPerfTextBox
            // 
            this.durationPerfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Performance.durationPerf", true));
            this.durationPerfTextBox.Enabled = false;
            this.durationPerfTextBox.Location = new System.Drawing.Point(278, 247);
            this.durationPerfTextBox.Name = "durationPerfTextBox";
            this.durationPerfTextBox.Size = new System.Drawing.Size(200, 26);
            this.durationPerfTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(115, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(362, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentBindingSource, "idPerf", true));
            this.comboBox1.DataSource = this.performanceBindingSource;
            this.comboBox1.DisplayMember = "topicrf";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "idPerf";
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataSource = typeof(WindowsFormsApp2.Performance);
            // 
            // EquipmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 474);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(datetimePerfLabel);
            this.Controls.Add(this.datetimePerfDateTimePicker);
            this.Controls.Add(durationPerfLabel);
            this.Controls.Add(this.durationPerfTextBox);
            this.Controls.Add(idPerfLabel);
            this.Controls.Add(nameEquipLabel);
            this.Controls.Add(this.nameEquipTextBox);
            this.Controls.Add(this.equipmentBindingNavigator);
            this.Name = "EquipmentInfo";
            this.Text = "EquipmentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingNavigator)).EndInit();
            this.equipmentBindingNavigator.ResumeLayout(false);
            this.equipmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.BindingNavigator equipmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton equipmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameEquipTextBox;
        private System.Windows.Forms.DateTimePicker datetimePerfDateTimePicker;
        private System.Windows.Forms.TextBox durationPerfTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource performanceBindingSource;
    }
}