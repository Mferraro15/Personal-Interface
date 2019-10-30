namespace Personal.Interface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonCleanAppTab = new System.Windows.Forms.Button();
            this.AppList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AppVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonRemoveAppTab = new System.Windows.Forms.Button();
            this.ButtonOKAppTab = new System.Windows.Forms.Button();
            this.ButtonAddAppTab = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(307, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.ButtonCleanAppTab);
            this.tabPage1.Controls.Add(this.AppList);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ButtonRemoveAppTab);
            this.tabPage1.Controls.Add(this.ButtonOKAppTab);
            this.tabPage1.Controls.Add(this.ButtonAddAppTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Applications";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // ButtonCleanAppTab
            // 
            this.ButtonCleanAppTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonCleanAppTab.Location = new System.Drawing.Point(271, 280);
            this.ButtonCleanAppTab.Name = "ButtonCleanAppTab";
            this.ButtonCleanAppTab.Size = new System.Drawing.Size(88, 31);
            this.ButtonCleanAppTab.TabIndex = 7;
            this.ButtonCleanAppTab.Text = "Clean";
            this.ButtonCleanAppTab.UseVisualStyleBackColor = false;
            this.ButtonCleanAppTab.Click += new System.EventHandler(this.ButtonCleanAppTab_Click_1);
            // 
            // AppList
            // 
            this.AppList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AppList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppList.FormattingEnabled = true;
            this.AppList.ItemHeight = 15;
            this.AppList.Location = new System.Drawing.Point(25, 325);
            this.AppList.Name = "AppList";
            this.AppList.Size = new System.Drawing.Size(334, 169);
            this.AppList.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AppVersionComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AppLogoPictureBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AppComboBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applications";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // AppVersionComboBox
            // 
            this.AppVersionComboBox.FormattingEnabled = true;
            this.AppVersionComboBox.Location = new System.Drawing.Point(103, 68);
            this.AppVersionComboBox.Name = "AppVersionComboBox";
            this.AppVersionComboBox.Size = new System.Drawing.Size(212, 26);
            this.AppVersionComboBox.TabIndex = 0;
            this.AppVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.AppVersionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AppLogoPictureBox
            // 
            this.AppLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AppLogoPictureBox.Location = new System.Drawing.Point(80, 115);
            this.AppLogoPictureBox.Name = "AppLogoPictureBox";
            this.AppLogoPictureBox.Size = new System.Drawing.Size(235, 115);
            this.AppLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppLogoPictureBox.TabIndex = 2;
            this.AppLogoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AppComboBox
            // 
            this.AppComboBox.FormattingEnabled = true;
            this.AppComboBox.Location = new System.Drawing.Point(103, 31);
            this.AppComboBox.Name = "AppComboBox";
            this.AppComboBox.Size = new System.Drawing.Size(212, 26);
            this.AppComboBox.TabIndex = 0;
            this.AppComboBox.SelectedIndexChanged += new System.EventHandler(this.AppComboBox_SelectedIndexChanged);
            this.AppComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppComboBox_MouseClick);
            // 
            // ButtonRemoveAppTab
            // 
            this.ButtonRemoveAppTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonRemoveAppTab.Location = new System.Drawing.Point(151, 282);
            this.ButtonRemoveAppTab.Name = "ButtonRemoveAppTab";
            this.ButtonRemoveAppTab.Size = new System.Drawing.Size(88, 31);
            this.ButtonRemoveAppTab.TabIndex = 6;
            this.ButtonRemoveAppTab.Text = "Remove";
            this.ButtonRemoveAppTab.UseVisualStyleBackColor = false;
            this.ButtonRemoveAppTab.Click += new System.EventHandler(this.ButtonRemoveAppTab_Click_2);
            // 
            // ButtonOKAppTab
            // 
            this.ButtonOKAppTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonOKAppTab.Location = new System.Drawing.Point(148, 501);
            this.ButtonOKAppTab.Name = "ButtonOKAppTab";
            this.ButtonOKAppTab.Size = new System.Drawing.Size(91, 34);
            this.ButtonOKAppTab.TabIndex = 1;
            this.ButtonOKAppTab.Text = "Run";
            this.ButtonOKAppTab.UseVisualStyleBackColor = false;
            this.ButtonOKAppTab.Click += new System.EventHandler(this.ButtonOKAppTab_Click);
            // 
            // ButtonAddAppTab
            // 
            this.ButtonAddAppTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAddAppTab.Location = new System.Drawing.Point(25, 282);
            this.ButtonAddAppTab.Name = "ButtonAddAppTab";
            this.ButtonAddAppTab.Size = new System.Drawing.Size(88, 31);
            this.ButtonAddAppTab.TabIndex = 3;
            this.ButtonAddAppTab.Text = "Add";
            this.ButtonAddAppTab.UseVisualStyleBackColor = false;
            this.ButtonAddAppTab.Click += new System.EventHandler(this.ButtonAddAppTab_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Support";
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 34);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(275, 124);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(269, 590);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(91, 34);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancelAppTab_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 604);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(722, 636);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personal Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonOKAppTab;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddAppTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AppComboBox;
        private System.Windows.Forms.ComboBox AppVersionComboBox;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AppLogoPictureBox;
        private System.Windows.Forms.ListBox AppList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCleanAppTab;
        private System.Windows.Forms.Button ButtonRemoveAppTab;
    }
}

