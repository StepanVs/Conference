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
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idPerfLabel
            // 
            idPerfLabel.AutoSize = true;
            idPerfLabel.Location = new System.Drawing.Point(68, 120);
            idPerfLabel.Name = "idPerfLabel";
            idPerfLabel.Size = new System.Drawing.Size(106, 20);
            idPerfLabel.TabIndex = 3;
            idPerfLabel.Text = "Для виступу:";
            // 
            // nameEquipLabel
            // 
            nameEquipLabel.AutoSize = true;
            nameEquipLabel.Location = new System.Drawing.Point(68, 73);
            nameEquipLabel.Name = "nameEquipLabel";
            nameEquipLabel.Size = new System.Drawing.Size(157, 20);
            nameEquipLabel.TabIndex = 5;
            nameEquipLabel.Text = "Назва обладнання:";
            // 
            // datetimePerfLabel
            // 
            datetimePerfLabel.AutoSize = true;
            datetimePerfLabel.Location = new System.Drawing.Point(68, 152);
            datetimePerfLabel.Name = "datetimePerfLabel";
            datetimePerfLabel.Size = new System.Drawing.Size(104, 20);
            datetimePerfLabel.TabIndex = 7;
            datetimePerfLabel.Text = "Час виступу:";
            // 
            // durationPerfLabel
            // 
            durationPerfLabel.AutoSize = true;
            durationPerfLabel.Location = new System.Drawing.Point(68, 184);
            durationPerfLabel.Name = "durationPerfLabel";
            durationPerfLabel.Size = new System.Drawing.Size(159, 20);
            durationPerfLabel.TabIndex = 9;
            durationPerfLabel.Text = "Тривалість виступу:";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(WindowsFormsApp2.Equipment);
            // 
            // nameEquipTextBox
            // 
            this.nameEquipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "nameEquip", true));
            this.nameEquipTextBox.Location = new System.Drawing.Point(235, 67);
            this.nameEquipTextBox.Name = "nameEquipTextBox";
            this.nameEquipTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameEquipTextBox.TabIndex = 6;
            // 
            // datetimePerfDateTimePicker
            // 
            this.datetimePerfDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.equipmentBindingSource, "Performance.datetimePerf", true));
            this.datetimePerfDateTimePicker.Enabled = false;
            this.datetimePerfDateTimePicker.Location = new System.Drawing.Point(235, 146);
            this.datetimePerfDateTimePicker.Name = "datetimePerfDateTimePicker";
            this.datetimePerfDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.datetimePerfDateTimePicker.TabIndex = 8;
            // 
            // durationPerfTextBox
            // 
            this.durationPerfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Performance.durationPerf", true));
            this.durationPerfTextBox.Enabled = false;
            this.durationPerfTextBox.Location = new System.Drawing.Point(235, 178);
            this.durationPerfTextBox.Name = "durationPerfTextBox";
            this.durationPerfTextBox.Size = new System.Drawing.Size(200, 26);
            this.durationPerfTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(72, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(319, 284);
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
            this.comboBox1.Location = new System.Drawing.Point(235, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 28);
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
            this.ClientSize = new System.Drawing.Size(608, 385);
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
            this.Name = "EquipmentInfo";
            this.Text = "EquipmentInfo";
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.TextBox nameEquipTextBox;
        private System.Windows.Forms.DateTimePicker datetimePerfDateTimePicker;
        private System.Windows.Forms.TextBox durationPerfTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource performanceBindingSource;
    }
}