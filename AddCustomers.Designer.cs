namespace Курсовая_СмирноваКристина_ИП_20_3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label fitClubLabel;
            System.Windows.Forms.Label seasonTTFLabel;
            System.Windows.Forms.Label seasonTicketLabel;
            System.Windows.Forms.Label activityidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitClubDBDataSetHosting = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHosting();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.seasonTTFComboBox = new System.Windows.Forms.ComboBox();
            this.seasonTicketComboBox = new System.Windows.Forms.ComboBox();
            this.activityidComboBox = new System.Windows.Forms.ComboBox();
            this.activityNameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.activityTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.ActivityTableTableAdapter();
            this.activityNameTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.ActivityNameTableTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            fitClubLabel = new System.Windows.Forms.Label();
            seasonTTFLabel = new System.Windows.Forms.Label();
            seasonTicketLabel = new System.Windows.Forms.Label();
            activityidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityNameTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(117, 82);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(33, 16);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(90, 120);
            surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(63, 16);
            surnameLabel.TabIndex = 20;
            surnameLabel.Text = "Фамилия:";
            // 
            // fitClubLabel
            // 
            fitClubLabel.AutoSize = true;
            fitClubLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fitClubLabel.Location = new System.Drawing.Point(90, 158);
            fitClubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fitClubLabel.Name = "fitClubLabel";
            fitClubLabel.Size = new System.Drawing.Size(61, 16);
            fitClubLabel.TabIndex = 21;
            fitClubLabel.Text = "Телефон:";
            // 
            // seasonTTFLabel
            // 
            seasonTTFLabel.AutoSize = true;
            seasonTTFLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seasonTTFLabel.Location = new System.Drawing.Point(22, 200);
            seasonTTFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            seasonTTFLabel.Name = "seasonTTFLabel";
            seasonTTFLabel.Size = new System.Drawing.Size(133, 16);
            seasonTTFLabel.TabIndex = 22;
            seasonTTFLabel.Text = "Наличие абонемента:";
            // 
            // seasonTicketLabel
            // 
            seasonTicketLabel.AutoSize = true;
            seasonTicketLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seasonTicketLabel.Location = new System.Drawing.Point(37, 243);
            seasonTicketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            seasonTicketLabel.Name = "seasonTicketLabel";
            seasonTicketLabel.Size = new System.Drawing.Size(115, 16);
            seasonTicketLabel.TabIndex = 23;
            seasonTicketLabel.Text = "Срок абонемента:";
            // 
            // activityidLabel
            // 
            activityidLabel.AutoSize = true;
            activityidLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activityidLabel.Location = new System.Drawing.Point(97, 285);
            activityidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activityidLabel.Name = "activityidLabel";
            activityidLabel.Size = new System.Drawing.Size(54, 16);
            activityidLabel.TabIndex = 24;
            activityidLabel.Text = "Занятие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(136, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Клиенты";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "CustomersTable";
            this.customersBindingSource.DataSource = this.fitClubDBDataSetHosting;
            // 
            // fitClubDBDataSetHosting
            // 
            this.fitClubDBDataSetHosting.DataSetName = "FitClubDBDataSetHosting";
            this.fitClubDBDataSetHosting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 78);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 20;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(154, 117);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(141, 20);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 61);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_добавить_пользователя_1001;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(178, 318);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 35);
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
            this.buttonAdd.Location = new System.Drawing.Point(49, 318);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 35);
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
            this.seasonTTFComboBox.Location = new System.Drawing.Point(154, 198);
            this.seasonTTFComboBox.Name = "seasonTTFComboBox";
            this.seasonTTFComboBox.Size = new System.Drawing.Size(141, 21);
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
            this.seasonTicketComboBox.Location = new System.Drawing.Point(154, 241);
            this.seasonTicketComboBox.Name = "seasonTicketComboBox";
            this.seasonTicketComboBox.Size = new System.Drawing.Size(141, 21);
            this.seasonTicketComboBox.TabIndex = 52;
            // 
            // activityidComboBox
            // 
            this.activityidComboBox.DataSource = this.activityNameTableBindingSource;
            this.activityidComboBox.DisplayMember = "ActivityName";
            this.activityidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityidComboBox.FormattingEnabled = true;
            this.activityidComboBox.Location = new System.Drawing.Point(154, 283);
            this.activityidComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activityidComboBox.Name = "activityidComboBox";
            this.activityidComboBox.Size = new System.Drawing.Size(141, 21);
            this.activityidComboBox.TabIndex = 53;
            this.activityidComboBox.ValueMember = "ID";
            // 
            // activityNameTableBindingSource
            // 
            this.activityNameTableBindingSource.DataMember = "ActivityNameTable";
            this.activityNameTableBindingSource.DataSource = this.fitClubDBDataSetHosting;
            // 
            // activityTableBindingSource
            // 
            this.activityTableBindingSource.DataMember = "ActivityTable";
            this.activityTableBindingSource.DataSource = this.fitClubDBDataSetHosting;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(154, 156);
            this.phoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(141, 20);
            this.phoneMaskedTextBox.TabIndex = 54;
            // 
            // activityTableTableAdapter
            // 
            this.activityTableTableAdapter.ClearBeforeFill = true;
            // 
            // activityNameTableTableAdapter
            // 
            this.activityNameTableTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(333, 370);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomers";
            this.Text = "Добавить клиента";
            this.Load += new System.EventHandler(this.AddCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityNameTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTableBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.ComboBox seasonTTFComboBox;
        private System.Windows.Forms.ComboBox seasonTicketComboBox;
        private System.Windows.Forms.ComboBox activityidComboBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.BindingSource activityTableBindingSource;
        private FitClubDBDataSetHosting fitClubDBDataSetHosting;
        private FitClubDBDataSetHostingTableAdapters.ActivityTableTableAdapter activityTableTableAdapter;
        private System.Windows.Forms.BindingSource activityNameTableBindingSource;
        private FitClubDBDataSetHostingTableAdapters.ActivityNameTableTableAdapter activityNameTableTableAdapter;
    }
}