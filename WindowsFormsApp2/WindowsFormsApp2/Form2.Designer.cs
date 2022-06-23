namespace WindowsFormsApp2
{
    partial class Form2
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
            System.Windows.Forms.Label headSectLabel;
            System.Windows.Forms.Label idConfLabel;
            System.Windows.Forms.Label nameSectLabel;
            System.Windows.Forms.Label roomSectLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sectionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.sectionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.headSectTextBox = new System.Windows.Forms.TextBox();
            this.idConfComboBox = new System.Windows.Forms.ComboBox();
            this.conferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameSectTextBox = new System.Windows.Forms.TextBox();
            this.roomSectComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.conferenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            headSectLabel = new System.Windows.Forms.Label();
            idConfLabel = new System.Windows.Forms.Label();
            nameSectLabel = new System.Windows.Forms.Label();
            roomSectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingNavigator)).BeginInit();
            this.sectionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // headSectLabel
            // 
            headSectLabel.AutoSize = true;
            headSectLabel.Location = new System.Drawing.Point(120, 105);
            headSectLabel.Name = "headSectLabel";
            headSectLabel.Size = new System.Drawing.Size(112, 20);
            headSectLabel.TabIndex = 1;
            headSectLabel.Text = "Голова секції:";
            headSectLabel.Click += new System.EventHandler(this.headSectLabel_Click);
            // 
            // idConfLabel
            // 
            idConfLabel.AutoSize = true;
            idConfLabel.Location = new System.Drawing.Point(121, 156);
            idConfLabel.Name = "idConfLabel";
            idConfLabel.Size = new System.Drawing.Size(165, 20);
            idConfLabel.TabIndex = 3;
            idConfLabel.Text = "Секція належить до:";
            // 
            // nameSectLabel
            // 
            nameSectLabel.AutoSize = true;
            nameSectLabel.Location = new System.Drawing.Point(120, 70);
            nameSectLabel.Name = "nameSectLabel";
            nameSectLabel.Size = new System.Drawing.Size(104, 20);
            nameSectLabel.TabIndex = 7;
            nameSectLabel.Text = "Назва секції:";
            // 
            // roomSectLabel
            // 
            roomSectLabel.AutoSize = true;
            roomSectLabel.Location = new System.Drawing.Point(121, 194);
            roomSectLabel.Name = "roomSectLabel";
            roomSectLabel.Size = new System.Drawing.Size(73, 20);
            roomSectLabel.TabIndex = 9;
            roomSectLabel.Text = "Кімната:";
            // 
            // sectionBindingNavigator
            // 
            this.sectionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sectionBindingNavigator.BindingSource = this.sectionBindingSource;
            this.sectionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sectionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sectionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sectionBindingNavigatorSaveItem});
            this.sectionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sectionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sectionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sectionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sectionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sectionBindingNavigator.Name = "sectionBindingNavigator";
            this.sectionBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.sectionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sectionBindingNavigator.Size = new System.Drawing.Size(633, 33);
            this.sectionBindingNavigator.TabIndex = 0;
            this.sectionBindingNavigator.Text = "bindingNavigator1";
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
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(WindowsFormsApp2.Section);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // sectionBindingNavigatorSaveItem
            // 
            this.sectionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionBindingNavigatorSaveItem.Enabled = false;
            this.sectionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionBindingNavigatorSaveItem.Image")));
            this.sectionBindingNavigatorSaveItem.Name = "sectionBindingNavigatorSaveItem";
            this.sectionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.sectionBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // headSectTextBox
            // 
            this.headSectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource, "headSect", true));
            this.headSectTextBox.Location = new System.Drawing.Point(302, 99);
            this.headSectTextBox.Name = "headSectTextBox";
            this.headSectTextBox.Size = new System.Drawing.Size(221, 26);
            this.headSectTextBox.TabIndex = 2;
            // 
            // idConfComboBox
            // 
            this.idConfComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionBindingSource, "idConf", true));
            this.idConfComboBox.DataSource = this.conferenceBindingSource;
            this.idConfComboBox.DisplayMember = "nameConf";
            this.idConfComboBox.FormattingEnabled = true;
            this.idConfComboBox.Location = new System.Drawing.Point(302, 148);
            this.idConfComboBox.Name = "idConfComboBox";
            this.idConfComboBox.Size = new System.Drawing.Size(221, 28);
            this.idConfComboBox.TabIndex = 4;
            this.idConfComboBox.ValueMember = "idConf";
            // 
            // conferenceBindingSource
            // 
            this.conferenceBindingSource.DataSource = typeof(WindowsFormsApp2.Conference);
            // 
            // nameSectTextBox
            // 
            this.nameSectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource, "nameSect", true));
            this.nameSectTextBox.Location = new System.Drawing.Point(302, 64);
            this.nameSectTextBox.Name = "nameSectTextBox";
            this.nameSectTextBox.Size = new System.Drawing.Size(220, 26);
            this.nameSectTextBox.TabIndex = 8;
            // 
            // roomSectComboBox
            // 
            this.roomSectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sectionBindingSource, "roomSect", true));
            this.roomSectComboBox.DataSource = this.roomBindingSource;
            this.roomSectComboBox.DisplayMember = "name";
            this.roomSectComboBox.FormattingEnabled = true;
            this.roomSectComboBox.Location = new System.Drawing.Point(302, 186);
            this.roomSectComboBox.Name = "roomSectComboBox";
            this.roomSectComboBox.Size = new System.Drawing.Size(220, 28);
            this.roomSectComboBox.TabIndex = 10;
            this.roomSectComboBox.ValueMember = "idRoom";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(WindowsFormsApp2.Room);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(358, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(124, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conferenceBindingSource1
            // 
            this.conferenceBindingSource1.DataSource = typeof(WindowsFormsApp2.Conference);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(headSectLabel);
            this.Controls.Add(this.headSectTextBox);
            this.Controls.Add(idConfLabel);
            this.Controls.Add(this.idConfComboBox);
            this.Controls.Add(nameSectLabel);
            this.Controls.Add(this.nameSectTextBox);
            this.Controls.Add(roomSectLabel);
            this.Controls.Add(this.roomSectComboBox);
            this.Controls.Add(this.sectionBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingNavigator)).EndInit();
            this.sectionBindingNavigator.ResumeLayout(false);
            this.sectionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.BindingNavigator sectionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sectionBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource conferenceBindingSource;
        private System.Windows.Forms.TextBox headSectTextBox;
        private System.Windows.Forms.ComboBox idConfComboBox;
        private System.Windows.Forms.TextBox nameSectTextBox;
        private System.Windows.Forms.ComboBox roomSectComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource conferenceBindingSource1;
        private System.Windows.Forms.BindingSource roomBindingSource;
    }
}