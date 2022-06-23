namespace WindowsFormsApp2
{
    partial class SpeakerInfo
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
            System.Windows.Forms.Label datetimePerfLabel;
            System.Windows.Forms.Label profBiogSpeakerLabel;
            System.Windows.Forms.Label positionSpeakerLabel;
            System.Windows.Forms.Label placeOfWorkLabel;
            System.Windows.Forms.Label idPerfLabel;
            System.Windows.Forms.Label degreeSpeakerLabel;
            System.Windows.Forms.Label academStatusLabel;
            System.Windows.Forms.Label durationPerfLabel;
            this.speakerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.placeOfWorkTextBox = new System.Windows.Forms.TextBox();
            this.profBiogSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.degreeSpeakerTextBox = new System.Windows.Forms.TextBox();
            this.academStatusTextBox = new System.Windows.Forms.TextBox();
            this.durationPerfTextBox = new System.Windows.Forms.TextBox();
            this.datetimePerfDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            datetimePerfLabel = new System.Windows.Forms.Label();
            profBiogSpeakerLabel = new System.Windows.Forms.Label();
            positionSpeakerLabel = new System.Windows.Forms.Label();
            placeOfWorkLabel = new System.Windows.Forms.Label();
            idPerfLabel = new System.Windows.Forms.Label();
            degreeSpeakerLabel = new System.Windows.Forms.Label();
            academStatusLabel = new System.Windows.Forms.Label();
            durationPerfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speakerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimePerfLabel
            // 
            datetimePerfLabel.AutoSize = true;
            datetimePerfLabel.Location = new System.Drawing.Point(85, 332);
            datetimePerfLabel.Name = "datetimePerfLabel";
            datetimePerfLabel.Size = new System.Drawing.Size(114, 20);
            datetimePerfLabel.TabIndex = 15;
            datetimePerfLabel.Text = "Дата виступу:";
            // 
            // profBiogSpeakerLabel
            // 
            profBiogSpeakerLabel.AutoSize = true;
            profBiogSpeakerLabel.Location = new System.Drawing.Point(85, 205);
            profBiogSpeakerLabel.Name = "profBiogSpeakerLabel";
            profBiogSpeakerLabel.Size = new System.Drawing.Size(188, 20);
            profBiogSpeakerLabel.TabIndex = 13;
            profBiogSpeakerLabel.Text = "Додаткова інформація:";
            // 
            // positionSpeakerLabel
            // 
            positionSpeakerLabel.AutoSize = true;
            positionSpeakerLabel.Location = new System.Drawing.Point(85, 173);
            positionSpeakerLabel.Name = "positionSpeakerLabel";
            positionSpeakerLabel.Size = new System.Drawing.Size(71, 20);
            positionSpeakerLabel.TabIndex = 11;
            positionSpeakerLabel.Text = "Посада:";
            // 
            // placeOfWorkLabel
            // 
            placeOfWorkLabel.AutoSize = true;
            placeOfWorkLabel.Location = new System.Drawing.Point(85, 141);
            placeOfWorkLabel.Name = "placeOfWorkLabel";
            placeOfWorkLabel.Size = new System.Drawing.Size(113, 20);
            placeOfWorkLabel.TabIndex = 9;
            placeOfWorkLabel.Text = "Місце роботи:";
            // 
            // idPerfLabel
            // 
            idPerfLabel.AutoSize = true;
            idPerfLabel.Location = new System.Drawing.Point(85, 300);
            idPerfLabel.Name = "idPerfLabel";
            idPerfLabel.Size = new System.Drawing.Size(150, 20);
            idPerfLabel.TabIndex = 5;
            idPerfLabel.Text = "Виступає з темою:";
            // 
            // degreeSpeakerLabel
            // 
            degreeSpeakerLabel.AutoSize = true;
            degreeSpeakerLabel.Location = new System.Drawing.Point(85, 74);
            degreeSpeakerLabel.Name = "degreeSpeakerLabel";
            degreeSpeakerLabel.Size = new System.Drawing.Size(133, 20);
            degreeSpeakerLabel.TabIndex = 3;
            degreeSpeakerLabel.Text = "Наукове звання:";
            // 
            // academStatusLabel
            // 
            academStatusLabel.AutoSize = true;
            academStatusLabel.Location = new System.Drawing.Point(85, 106);
            academStatusLabel.Name = "academStatusLabel";
            academStatusLabel.Size = new System.Drawing.Size(117, 20);
            academStatusLabel.TabIndex = 1;
            academStatusLabel.Text = "Вчене звання:";
            // 
            // durationPerfLabel
            // 
            durationPerfLabel.AutoSize = true;
            durationPerfLabel.Location = new System.Drawing.Point(85, 364);
            durationPerfLabel.Name = "durationPerfLabel";
            durationPerfLabel.Size = new System.Drawing.Size(159, 20);
            durationPerfLabel.TabIndex = 17;
            durationPerfLabel.Text = "Тривалість виступу:";
            // 
            // speakerBindingSource
            // 
            this.speakerBindingSource.DataSource = typeof(WindowsFormsApp2.Speaker);
            // 
            // positionSpeakerTextBox
            // 
            this.positionSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "positionSpeaker", true));
            this.positionSpeakerTextBox.Location = new System.Drawing.Point(283, 167);
            this.positionSpeakerTextBox.Name = "positionSpeakerTextBox";
            this.positionSpeakerTextBox.Size = new System.Drawing.Size(167, 26);
            this.positionSpeakerTextBox.TabIndex = 12;
            // 
            // placeOfWorkTextBox
            // 
            this.placeOfWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "placeOfWork", true));
            this.placeOfWorkTextBox.Location = new System.Drawing.Point(283, 135);
            this.placeOfWorkTextBox.Name = "placeOfWorkTextBox";
            this.placeOfWorkTextBox.Size = new System.Drawing.Size(167, 26);
            this.placeOfWorkTextBox.TabIndex = 10;
            // 
            // profBiogSpeakerTextBox
            // 
            this.profBiogSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "profBiogSpeaker", true));
            this.profBiogSpeakerTextBox.Location = new System.Drawing.Point(283, 199);
            this.profBiogSpeakerTextBox.Name = "profBiogSpeakerTextBox";
            this.profBiogSpeakerTextBox.Size = new System.Drawing.Size(167, 26);
            this.profBiogSpeakerTextBox.TabIndex = 14;
            // 
            // degreeSpeakerTextBox
            // 
            this.degreeSpeakerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "degreeSpeaker", true));
            this.degreeSpeakerTextBox.Location = new System.Drawing.Point(283, 68);
            this.degreeSpeakerTextBox.Name = "degreeSpeakerTextBox";
            this.degreeSpeakerTextBox.Size = new System.Drawing.Size(167, 26);
            this.degreeSpeakerTextBox.TabIndex = 4;
            // 
            // academStatusTextBox
            // 
            this.academStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "academStatus", true));
            this.academStatusTextBox.Location = new System.Drawing.Point(283, 100);
            this.academStatusTextBox.Name = "academStatusTextBox";
            this.academStatusTextBox.Size = new System.Drawing.Size(167, 26);
            this.academStatusTextBox.TabIndex = 2;
            // 
            // durationPerfTextBox
            // 
            this.durationPerfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.speakerBindingSource, "Performance.durationPerf", true));
            this.durationPerfTextBox.Enabled = false;
            this.durationPerfTextBox.Location = new System.Drawing.Point(250, 358);
            this.durationPerfTextBox.Name = "durationPerfTextBox";
            this.durationPerfTextBox.Size = new System.Drawing.Size(200, 26);
            this.durationPerfTextBox.TabIndex = 18;
            // 
            // datetimePerfDateTimePicker
            // 
            this.datetimePerfDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.speakerBindingSource, "Performance.datetimePerf", true));
            this.datetimePerfDateTimePicker.Enabled = false;
            this.datetimePerfDateTimePicker.Location = new System.Drawing.Point(250, 326);
            this.datetimePerfDateTimePicker.Name = "datetimePerfDateTimePicker";
            this.datetimePerfDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.datetimePerfDateTimePicker.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.speakerBindingSource, "idPerf", true));
            this.comboBox1.DataSource = this.performanceBindingSource;
            this.comboBox1.DisplayMember = "topicrf";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "idPerf";
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataSource = typeof(WindowsFormsApp2.Performance);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(89, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(332, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 27;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SpeakerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(datetimePerfLabel);
            this.Controls.Add(this.datetimePerfDateTimePicker);
            this.Controls.Add(durationPerfLabel);
            this.Controls.Add(this.durationPerfTextBox);
            this.Controls.Add(academStatusLabel);
            this.Controls.Add(this.academStatusTextBox);
            this.Controls.Add(degreeSpeakerLabel);
            this.Controls.Add(this.degreeSpeakerTextBox);
            this.Controls.Add(idPerfLabel);
            this.Controls.Add(placeOfWorkLabel);
            this.Controls.Add(this.placeOfWorkTextBox);
            this.Controls.Add(positionSpeakerLabel);
            this.Controls.Add(this.positionSpeakerTextBox);
            this.Controls.Add(profBiogSpeakerLabel);
            this.Controls.Add(this.profBiogSpeakerTextBox);
            this.Name = "SpeakerInfo";
            this.Text = "SpeakerInfo";
            ((System.ComponentModel.ISupportInitialize)(this.speakerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource speakerBindingSource;
        private System.Windows.Forms.TextBox positionSpeakerTextBox;
        private System.Windows.Forms.TextBox placeOfWorkTextBox;
        private System.Windows.Forms.TextBox profBiogSpeakerTextBox;
        private System.Windows.Forms.TextBox degreeSpeakerTextBox;
        private System.Windows.Forms.TextBox academStatusTextBox;
        private System.Windows.Forms.TextBox durationPerfTextBox;
        private System.Windows.Forms.DateTimePicker datetimePerfDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource performanceBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}