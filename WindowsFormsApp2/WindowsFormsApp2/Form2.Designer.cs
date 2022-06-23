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
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // headSectLabel
            // 
            headSectLabel.AutoSize = true;
            headSectLabel.Location = new System.Drawing.Point(109, 75);
            headSectLabel.Name = "headSectLabel";
            headSectLabel.Size = new System.Drawing.Size(112, 20);
            headSectLabel.TabIndex = 1;
            headSectLabel.Text = "Голова секції:";
            headSectLabel.Click += new System.EventHandler(this.headSectLabel_Click);
            // 
            // idConfLabel
            // 
            idConfLabel.AutoSize = true;
            idConfLabel.Location = new System.Drawing.Point(110, 126);
            idConfLabel.Name = "idConfLabel";
            idConfLabel.Size = new System.Drawing.Size(165, 20);
            idConfLabel.TabIndex = 3;
            idConfLabel.Text = "Секція належить до:";
            // 
            // nameSectLabel
            // 
            nameSectLabel.AutoSize = true;
            nameSectLabel.Location = new System.Drawing.Point(109, 40);
            nameSectLabel.Name = "nameSectLabel";
            nameSectLabel.Size = new System.Drawing.Size(104, 20);
            nameSectLabel.TabIndex = 7;
            nameSectLabel.Text = "Назва секції:";
            // 
            // roomSectLabel
            // 
            roomSectLabel.AutoSize = true;
            roomSectLabel.Location = new System.Drawing.Point(110, 164);
            roomSectLabel.Name = "roomSectLabel";
            roomSectLabel.Size = new System.Drawing.Size(73, 20);
            roomSectLabel.TabIndex = 9;
            roomSectLabel.Text = "Кімната:";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(WindowsFormsApp2.Section);
            // 
            // headSectTextBox
            // 
            this.headSectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource, "headSect", true));
            this.headSectTextBox.Location = new System.Drawing.Point(291, 69);
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
            this.idConfComboBox.Location = new System.Drawing.Point(291, 118);
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
            this.nameSectTextBox.Location = new System.Drawing.Point(291, 34);
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
            this.roomSectComboBox.Location = new System.Drawing.Point(291, 156);
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
            this.button2.Location = new System.Drawing.Point(347, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(113, 223);
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
            this.ClientSize = new System.Drawing.Size(633, 303);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sectionBindingSource;
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