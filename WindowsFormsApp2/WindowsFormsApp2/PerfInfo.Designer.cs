namespace WindowsFormsApp2
{
    partial class PerfInfo
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
            System.Windows.Forms.Label durationPerfLabel;
            System.Windows.Forms.Label idSectLabel;
            System.Windows.Forms.Label topicrfLabel;
            System.Windows.Forms.Label headSectLabel;
            this.datetimePerfDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.performanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durationPerfTextBox = new System.Windows.Forms.TextBox();
            this.topicrfTextBox = new System.Windows.Forms.TextBox();
            this.headSectTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            datetimePerfLabel = new System.Windows.Forms.Label();
            durationPerfLabel = new System.Windows.Forms.Label();
            idSectLabel = new System.Windows.Forms.Label();
            topicrfLabel = new System.Windows.Forms.Label();
            headSectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datetimePerfLabel
            // 
            datetimePerfLabel.AutoSize = true;
            datetimePerfLabel.Location = new System.Drawing.Point(77, 85);
            datetimePerfLabel.Name = "datetimePerfLabel";
            datetimePerfLabel.Size = new System.Drawing.Size(104, 20);
            datetimePerfLabel.TabIndex = 1;
            datetimePerfLabel.Text = "Час виступу:";
            // 
            // durationPerfLabel
            // 
            durationPerfLabel.AutoSize = true;
            durationPerfLabel.Location = new System.Drawing.Point(77, 117);
            durationPerfLabel.Name = "durationPerfLabel";
            durationPerfLabel.Size = new System.Drawing.Size(159, 20);
            durationPerfLabel.TabIndex = 3;
            durationPerfLabel.Text = "Тривалість виступу:";
            // 
            // idSectLabel
            // 
            idSectLabel.AutoSize = true;
            idSectLabel.Location = new System.Drawing.Point(77, 151);
            idSectLabel.Name = "idSectLabel";
            idSectLabel.Size = new System.Drawing.Size(159, 20);
            idSectLabel.TabIndex = 7;
            idSectLabel.Text = "Належить до секції:";
            // 
            // topicrfLabel
            // 
            topicrfLabel.AutoSize = true;
            topicrfLabel.Location = new System.Drawing.Point(77, 53);
            topicrfLabel.Name = "topicrfLabel";
            topicrfLabel.Size = new System.Drawing.Size(113, 20);
            topicrfLabel.TabIndex = 9;
            topicrfLabel.Text = "Тема виступу:";
            // 
            // headSectLabel
            // 
            headSectLabel.AutoSize = true;
            headSectLabel.Enabled = false;
            headSectLabel.Location = new System.Drawing.Point(77, 181);
            headSectLabel.Name = "headSectLabel";
            headSectLabel.Size = new System.Drawing.Size(112, 20);
            headSectLabel.TabIndex = 11;
            headSectLabel.Text = "Голова секції:";
            // 
            // datetimePerfDateTimePicker
            // 
            this.datetimePerfDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.performanceBindingSource, "datetimePerf", true));
            this.datetimePerfDateTimePicker.Location = new System.Drawing.Point(269, 79);
            this.datetimePerfDateTimePicker.Name = "datetimePerfDateTimePicker";
            this.datetimePerfDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.datetimePerfDateTimePicker.TabIndex = 2;
            // 
            // performanceBindingSource
            // 
            this.performanceBindingSource.DataSource = typeof(WindowsFormsApp2.Performance);
            // 
            // durationPerfTextBox
            // 
            this.durationPerfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "durationPerf", true));
            this.durationPerfTextBox.Location = new System.Drawing.Point(269, 111);
            this.durationPerfTextBox.Name = "durationPerfTextBox";
            this.durationPerfTextBox.Size = new System.Drawing.Size(200, 26);
            this.durationPerfTextBox.TabIndex = 4;
            // 
            // topicrfTextBox
            // 
            this.topicrfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "topicrf", true));
            this.topicrfTextBox.Location = new System.Drawing.Point(269, 47);
            this.topicrfTextBox.Name = "topicrfTextBox";
            this.topicrfTextBox.Size = new System.Drawing.Size(442, 26);
            this.topicrfTextBox.TabIndex = 10;
            // 
            // headSectTextBox
            // 
            this.headSectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performanceBindingSource, "Section.headSect", true));
            this.headSectTextBox.Enabled = false;
            this.headSectTextBox.Location = new System.Drawing.Point(269, 175);
            this.headSectTextBox.Name = "headSectTextBox";
            this.headSectTextBox.Size = new System.Drawing.Size(200, 26);
            this.headSectTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.performanceBindingSource, "idSect", true));
            this.comboBox1.DataSource = this.sectionBindingSource;
            this.comboBox1.DisplayMember = "nameSect";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "idSect";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(WindowsFormsApp2.Section);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(81, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(595, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PerfInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(headSectLabel);
            this.Controls.Add(this.headSectTextBox);
            this.Controls.Add(datetimePerfLabel);
            this.Controls.Add(this.datetimePerfDateTimePicker);
            this.Controls.Add(durationPerfLabel);
            this.Controls.Add(this.durationPerfTextBox);
            this.Controls.Add(idSectLabel);
            this.Controls.Add(topicrfLabel);
            this.Controls.Add(this.topicrfTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PerfInfo";
            this.Text = "PerfInfo";
            ((System.ComponentModel.ISupportInitialize)(this.performanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource performanceBindingSource;
        private System.Windows.Forms.DateTimePicker datetimePerfDateTimePicker;
        private System.Windows.Forms.TextBox durationPerfTextBox;
        private System.Windows.Forms.TextBox topicrfTextBox;
        private System.Windows.Forms.TextBox headSectTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}