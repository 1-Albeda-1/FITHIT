namespace FITHIT
{
    partial class AddCustomers
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label fitClubLabel;
            System.Windows.Forms.Label seasonTTFLabel;
            System.Windows.Forms.Label seasonTicketLabel;
            System.Windows.Forms.Label activityidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.seasonTTFComboBox = new System.Windows.Forms.ComboBox();
            this.seasonTicketComboBox = new System.Windows.Forms.ComboBox();
            this.activityidComboBox = new System.Windows.Forms.ComboBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.activityTableTableAdapter = new FITHIT.FitClubDBDataSetTableAdapters.ActivityTableTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            fitClubLabel = new System.Windows.Forms.Label();
            seasonTTFLabel = new System.Windows.Forms.Label();
            seasonTicketLabel = new System.Windows.Forms.Label();
            activityidLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(214, 151);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 23);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(165, 222);
            surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(108, 23);
            surnameLabel.TabIndex = 20;
            surnameLabel.Text = "Фамилия:";
            // 
            // fitClubLabel
            // 
            fitClubLabel.AutoSize = true;
            fitClubLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fitClubLabel.Location = new System.Drawing.Point(165, 292);
            fitClubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fitClubLabel.Name = "fitClubLabel";
            fitClubLabel.Size = new System.Drawing.Size(107, 23);
            fitClubLabel.TabIndex = 21;
            fitClubLabel.Text = "Телефон:";
            // 
            // seasonTTFLabel
            // 
            seasonTTFLabel.AutoSize = true;
            seasonTTFLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seasonTTFLabel.Location = new System.Drawing.Point(40, 369);
            seasonTTFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seasonTTFLabel.Name = "seasonTTFLabel";
            seasonTTFLabel.Size = new System.Drawing.Size(236, 23);
            seasonTTFLabel.TabIndex = 22;
            seasonTTFLabel.Text = "Наличие абонемента:";
            // 
            // seasonTicketLabel
            // 
            seasonTicketLabel.AutoSize = true;
            seasonTicketLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seasonTicketLabel.Location = new System.Drawing.Point(68, 449);
            seasonTicketLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            seasonTicketLabel.Name = "seasonTicketLabel";
            seasonTicketLabel.Size = new System.Drawing.Size(204, 23);
            seasonTicketLabel.TabIndex = 23;
            seasonTicketLabel.Text = "Срок абонемента:";
            // 
            // activityidLabel
            // 
            activityidLabel.AutoSize = true;
            activityidLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activityidLabel.Location = new System.Drawing.Point(178, 526);
            activityidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activityidLabel.Name = "activityidLabel";
            activityidLabel.Size = new System.Drawing.Size(95, 23);
            activityidLabel.TabIndex = 24;
            activityidLabel.Text = "Занятие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "Клиенты";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(282, 144);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 29);
            this.nameTextBox.TabIndex = 20;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(282, 216);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(255, 29);
            this.surnameTextBox.TabIndex = 21;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
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
            this.panel1.Size = new System.Drawing.Size(610, 113);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FITHIT.Properties.Resources.icons8_добавить_пользователя_1001;
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(326, 587);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(211, 65);
            this.buttonClose.TabIndex = 50;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(90, 587);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(211, 65);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // seasonTTFComboBox
            // 
            this.seasonTTFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonTTFComboBox.FormattingEnabled = true;
            this.seasonTTFComboBox.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.seasonTTFComboBox.Location = new System.Drawing.Point(282, 366);
            this.seasonTTFComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.seasonTTFComboBox.Name = "seasonTTFComboBox";
            this.seasonTTFComboBox.Size = new System.Drawing.Size(255, 32);
            this.seasonTTFComboBox.TabIndex = 51;
            this.seasonTTFComboBox.SelectedIndexChanged += new System.EventHandler(this.seasonTTFComboBox_SelectedIndexChanged);
            // 
            // seasonTicketComboBox
            // 
            this.seasonTicketComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonTicketComboBox.FormattingEnabled = true;
            this.seasonTicketComboBox.Items.AddRange(new object[] {
            "Год",
            "Месяц",
            "Неделя"});
            this.seasonTicketComboBox.Location = new System.Drawing.Point(282, 445);
            this.seasonTicketComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.seasonTicketComboBox.Name = "seasonTicketComboBox";
            this.seasonTicketComboBox.Size = new System.Drawing.Size(255, 32);
            this.seasonTicketComboBox.TabIndex = 52;
            // 
            // activityidComboBox
            // 
            this.activityidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityidComboBox.FormattingEnabled = true;
            this.activityidComboBox.Location = new System.Drawing.Point(282, 522);
            this.activityidComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.activityidComboBox.Name = "activityidComboBox";
            this.activityidComboBox.Size = new System.Drawing.Size(255, 32);
            this.activityidComboBox.TabIndex = 53;
            this.activityidComboBox.ValueMember = "ID";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(282, 288);
            this.phoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(255, 29);
            this.phoneMaskedTextBox.TabIndex = 54;
            // 
            // activityTableTableAdapter
            // 
            this.activityTableTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(610, 683);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.activityidComboBox);
            this.Controls.Add(this.seasonTicketComboBox);
            this.Controls.Add(this.seasonTTFComboBox);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(activityidLabel);
            this.Controls.Add(seasonTicketLabel);
            this.Controls.Add(seasonTTFLabel);
            this.Controls.Add(fitClubLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomers";
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox seasonTTFComboBox;
        private System.Windows.Forms.ComboBox seasonTicketComboBox;
        private System.Windows.Forms.ComboBox activityidComboBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private FitClubDBDataSetTableAdapters.ActivityTableTableAdapter activityTableTableAdapter;
    }
}