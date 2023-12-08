namespace FITHIT
{
    partial class CustomersDetailed
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
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label activityIdLabel;
            System.Windows.Forms.Label seasonTTFLabel;
            System.Windows.Forms.Label seasonTicketLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersDetailed));
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewCustActivity = new System.Windows.Forms.DataGridView();
            this.NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitClubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeasonTTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seasonTicketTextBox = new System.Windows.Forms.TextBox();
            this.customersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitClubDBDataSetHosting = new FITHIT.FitClubDBDataSet();
            this.seasonTTFTextBox = new System.Windows.Forms.TextBox();
            this.activityIdTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableAdapterManager = new FITHIT.FitClubDBDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            activityIdLabel = new System.Windows.Forms.Label();
            seasonTTFLabel = new System.Windows.Forms.Label();
            seasonTicketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustActivity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(163, 109);
            nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 23);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(108, 174);
            surnameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(108, 23);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Фамилия:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(99, 231);
            phoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(121, 46);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "   Номер \r\nтелефона:";
            // 
            // activityIdLabel
            // 
            activityIdLabel.AutoSize = true;
            activityIdLabel.Location = new System.Drawing.Point(125, 343);
            activityIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            activityIdLabel.Name = "activityIdLabel";
            activityIdLabel.Size = new System.Drawing.Size(95, 23);
            activityIdLabel.TabIndex = 7;
            activityIdLabel.Text = "Занятие:";
            // 
            // seasonTTFLabel
            // 
            seasonTTFLabel.AutoSize = true;
            seasonTTFLabel.Location = new System.Drawing.Point(82, 408);
            seasonTTFLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            seasonTTFLabel.Name = "seasonTTFLabel";
            seasonTTFLabel.Size = new System.Drawing.Size(145, 46);
            seasonTTFLabel.TabIndex = 9;
            seasonTTFLabel.Text = "   Наличеие\r\nабонемента:";
            // 
            // seasonTicketLabel
            // 
            seasonTicketLabel.AutoSize = true;
            seasonTicketLabel.Location = new System.Drawing.Point(82, 498);
            seasonTicketLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            seasonTicketLabel.Name = "seasonTicketLabel";
            seasonTicketLabel.Size = new System.Drawing.Size(145, 46);
            seasonTicketLabel.TabIndex = 11;
            seasonTicketLabel.Text = "      Срок\r\nабонемента:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(623, 519);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 76);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewCustActivity
            // 
            this.dataGridViewCustActivity.AllowUserToAddRows = false;
            this.dataGridViewCustActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDataGridViewTextBoxColumn,
            this.SurnameDataGridViewTextBoxColumn,
            this.ActivityNameIDDataGridViewTextBoxColumn,
            this.FitClubDataGridViewTextBoxColumn,
            this.DateDataGridViewTextBoxColumn,
            this.CostDataGridViewTextBoxColumn,
            this.SeasonTTFDataGridViewTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustActivity.Location = new System.Drawing.Point(44, 42);
            this.dataGridViewCustActivity.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCustActivity.Name = "dataGridViewCustActivity";
            this.dataGridViewCustActivity.RowHeadersWidth = 72;
            this.dataGridViewCustActivity.RowTemplate.Height = 31;
            this.dataGridViewCustActivity.Size = new System.Drawing.Size(1140, 449);
            this.dataGridViewCustActivity.TabIndex = 14;
            // 
            // NameDataGridViewTextBoxColumn
            // 
            this.NameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.NameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn";
            this.NameDataGridViewTextBoxColumn.Width = 175;
            // 
            // SurnameDataGridViewTextBoxColumn
            // 
            this.SurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.SurnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn";
            this.SurnameDataGridViewTextBoxColumn.Width = 175;
            // 
            // ActivityNameIDDataGridViewTextBoxColumn
            // 
            this.ActivityNameIDDataGridViewTextBoxColumn.HeaderText = "Занятие";
            this.ActivityNameIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.ActivityNameIDDataGridViewTextBoxColumn.Name = "ActivityNameIDDataGridViewTextBoxColumn";
            this.ActivityNameIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // FitClubDataGridViewTextBoxColumn
            // 
            this.FitClubDataGridViewTextBoxColumn.HeaderText = "Фитнес клуб";
            this.FitClubDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.FitClubDataGridViewTextBoxColumn.Name = "FitClubDataGridViewTextBoxColumn";
            this.FitClubDataGridViewTextBoxColumn.Width = 175;
            // 
            // DateDataGridViewTextBoxColumn
            // 
            this.DateDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.DateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn";
            this.DateDataGridViewTextBoxColumn.Width = 175;
            // 
            // CostDataGridViewTextBoxColumn
            // 
            this.CostDataGridViewTextBoxColumn.HeaderText = "Стоимость занятия";
            this.CostDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn";
            this.CostDataGridViewTextBoxColumn.Width = 175;
            // 
            // SeasonTTFDataGridViewTextBoxColumn
            // 
            this.SeasonTTFDataGridViewTextBoxColumn.HeaderText = "Наличие абонемента";
            this.SeasonTTFDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.SeasonTTFDataGridViewTextBoxColumn.Name = "SeasonTTFDataGridViewTextBoxColumn";
            this.SeasonTTFDataGridViewTextBoxColumn.Width = 175;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExport.Location = new System.Drawing.Point(275, 519);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(295, 76);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(seasonTicketLabel);
            this.groupBox1.Controls.Add(this.seasonTicketTextBox);
            this.groupBox1.Controls.Add(seasonTTFLabel);
            this.groupBox1.Controls.Add(this.seasonTTFTextBox);
            this.groupBox1.Controls.Add(activityIdLabel);
            this.groupBox1.Controls.Add(this.activityIdTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(surnameLabel);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1216, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(522, 582);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список клиентов";
            // 
            // seasonTicketTextBox
            // 
            this.seasonTicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "SeasonTicket", true));
            this.seasonTicketTextBox.Location = new System.Drawing.Point(244, 513);
            this.seasonTicketTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.seasonTicketTextBox.Name = "seasonTicketTextBox";
            this.seasonTicketTextBox.Size = new System.Drawing.Size(180, 31);
            this.seasonTicketTextBox.TabIndex = 12;
            // 
            // customersTableBindingSource
            // 
            this.customersTableBindingSource.DataMember = "CustomersTable";
            this.customersTableBindingSource.DataSource = this.fitClubDBDataSetHosting;
            // 
            // fitClubDBDataSetHosting
            // 
            this.fitClubDBDataSetHosting.DataSetName = "FitClubDBDataSetHosting";
            this.fitClubDBDataSetHosting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seasonTTFTextBox
            // 
            this.seasonTTFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "SeasonTTF", true));
            this.seasonTTFTextBox.Location = new System.Drawing.Point(244, 428);
            this.seasonTTFTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.seasonTTFTextBox.Name = "seasonTTFTextBox";
            this.seasonTTFTextBox.Size = new System.Drawing.Size(180, 31);
            this.seasonTTFTextBox.TabIndex = 10;
            // 
            // activityIdTextBox
            // 
            this.activityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "ActivityId", true));
            this.activityIdTextBox.Location = new System.Drawing.Point(244, 338);
            this.activityIdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.activityIdTextBox.Name = "activityIdTextBox";
            this.activityIdTextBox.Size = new System.Drawing.Size(180, 31);
            this.activityIdTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(244, 251);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(180, 31);
            this.phoneTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(244, 174);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(180, 31);
            this.surnameTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(244, 103);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 31);
            this.nameTextBox.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.bindingNavigator1.BindingSource = this.customersTableBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 30);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(510, 44);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 38);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 38);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 38);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 38);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);

            // 
            // tableAdapterManager
            // 

            this.tableAdapterManager.ActivityTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;

            this.tableAdapterManager.UpdateOrder = FITHIT.FitClubDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableTableAdapter = null;
            // 
            // CustomersDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1767, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridViewCustActivity);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CustomersDetailed";
            this.Text = "Подробная информация о записи";
            this.Load += new System.EventHandler(this.CustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustActivity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dataGridViewCustActivity;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeasonTTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private FitClubDBDataSet fitClubDBDataSetHosting;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private FitClubDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox seasonTicketTextBox;
        private System.Windows.Forms.TextBox seasonTTFTextBox;
        private System.Windows.Forms.TextBox activityIdTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}