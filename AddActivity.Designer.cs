namespace FITHIT
{
    partial class AddActivity
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
            System.Windows.Forms.Label nameTLabel;
            System.Windows.Forms.Label surnameTLabel;
            System.Windows.Forms.Label fitClubLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivity));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTTextBox = new System.Windows.Forms.TextBox();
            this.surnameTTextBox = new System.Windows.Forms.TextBox();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.fitclubComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.startTimecomboBox = new System.Windows.Forms.ComboBox();
            nameTLabel = new System.Windows.Forms.Label();
            surnameTLabel = new System.Windows.Forms.Label();
            fitClubLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTLabel
            // 
            nameTLabel.AutoSize = true;
            nameTLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameTLabel.Location = new System.Drawing.Point(130, 146);
            nameTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameTLabel.Name = "nameTLabel";
            nameTLabel.Size = new System.Drawing.Size(151, 23);
            nameTLabel.TabIndex = 29;
            nameTLabel.Text = "Имя тренера:";
            // 
            // surnameTLabel
            // 
            surnameTLabel.AutoSize = true;
            surnameTLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameTLabel.Location = new System.Drawing.Point(79, 225);
            surnameTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameTLabel.Name = "surnameTLabel";
            surnameTLabel.Size = new System.Drawing.Size(202, 23);
            surnameTLabel.TabIndex = 30;
            surnameTLabel.Text = "Фамилия тренера:";
            // 
            // fitClubLabel
            // 
            fitClubLabel.AutoSize = true;
            fitClubLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fitClubLabel.Location = new System.Drawing.Point(139, 305);
            fitClubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fitClubLabel.Name = "fitClubLabel";
            fitClubLabel.Size = new System.Drawing.Size(141, 23);
            fitClubLabel.TabIndex = 31;
            fitClubLabel.Text = "Фитнес клуб:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activityLabel.Location = new System.Drawing.Point(185, 377);
            activityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(95, 23);
            activityLabel.TabIndex = 32;
            activityLabel.Text = "Занятие:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.Location = new System.Drawing.Point(90, 456);
            dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(191, 23);
            dateLabel.TabIndex = 33;
            dateLabel.Text = "Дата проведения:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeLabel.Location = new System.Drawing.Point(55, 593);
            timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(227, 23);
            timeLabel.TabIndex = 34;
            timeLabel.Text = "Длительность занятия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(73, 523);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 23);
            label2.TabIndex = 64;
            label2.Text = "Время проведения:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 113);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FITHIT.Properties.Resources.icons8_календарь_с_плюсом_1001;
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(257, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "Занятия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(59, 663);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(249, 65);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "";
            this.dateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(288, 450);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(257, 31);
            this.dateDateTimePicker.TabIndex = 50;
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // nameTTextBox
            // 
            this.nameTTextBox.Location = new System.Drawing.Point(288, 146);
            this.nameTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTTextBox.Name = "nameTTextBox";
            this.nameTTextBox.Size = new System.Drawing.Size(257, 29);
            this.nameTTextBox.TabIndex = 57;
            this.nameTTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTTextBox_KeyPress);
            // 
            // surnameTTextBox
            // 
            this.surnameTTextBox.Location = new System.Drawing.Point(288, 222);
            this.surnameTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTTextBox.Name = "surnameTTextBox";
            this.surnameTTextBox.Size = new System.Drawing.Size(257, 29);
            this.surnameTTextBox.TabIndex = 58;
            this.surnameTTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTTextBox_KeyPress);
            // 
            // activityComboBox
            // 
            this.activityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Location = new System.Drawing.Point(288, 373);
            this.activityComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(257, 32);
            this.activityComboBox.TabIndex = 59;
            this.activityComboBox.ValueMember = "ID";
            // 
            // fitclubComboBox
            // 
            this.fitclubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fitclubComboBox.FormattingEnabled = true;
            this.fitclubComboBox.Items.AddRange(new object[] {
            "FITHIT(м. Автово)",
            "FITHIT(м. Пионерская)",
            "FITHIT(м. Беговая)"});
            this.fitclubComboBox.Location = new System.Drawing.Point(288, 301);
            this.fitclubComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.fitclubComboBox.Name = "fitclubComboBox";
            this.fitclubComboBox.Size = new System.Drawing.Size(257, 32);
            this.fitclubComboBox.TabIndex = 60;
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "1,5 часа",
            "2 часа"});
            this.timeComboBox.Location = new System.Drawing.Point(290, 589);
            this.timeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(257, 32);
            this.timeComboBox.TabIndex = 61;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(337, 663);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(249, 65);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // startTimecomboBox
            // 
            this.startTimecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimecomboBox.FormattingEnabled = true;
            this.startTimecomboBox.Items.AddRange(new object[] {
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.startTimecomboBox.Location = new System.Drawing.Point(288, 519);
            this.startTimecomboBox.Margin = new System.Windows.Forms.Padding(6);
            this.startTimecomboBox.Name = "startTimecomboBox";
            this.startTimecomboBox.Size = new System.Drawing.Size(257, 32);
            this.startTimecomboBox.TabIndex = 63;
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(629, 764);
            this.Controls.Add(label2);
            this.Controls.Add(this.startTimecomboBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.fitclubComboBox);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.surnameTTextBox);
            this.Controls.Add(this.nameTTextBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(timeLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(activityLabel);
            this.Controls.Add(fitClubLabel);
            this.Controls.Add(surnameTLabel);
            this.Controls.Add(nameTLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddActivity";
            this.Text = "Добавить занятие";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox nameTTextBox;
        private System.Windows.Forms.TextBox surnameTTextBox;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.ComboBox fitclubComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox startTimecomboBox;
    }
}