namespace Курсовая_СмирноваКристина_ИП_20_3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.fitClubDBDataSetHosting = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHosting();
            this.seasonTTFTextBox = new System.Windows.Forms.TextBox();
            this.activityIdTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.CustomersTableTableAdapter();
            this.tableAdapterManager = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.TableAdapterManager();
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
            nameLabel.Location = new System.Drawing.Point(89, 59);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(33, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(59, 94);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(63, 16);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Фамилия:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(54, 125);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(68, 32);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "   Номер \r\nтелефона:";
            // 
            // activityIdLabel
            // 
            activityIdLabel.AutoSize = true;
            activityIdLabel.Location = new System.Drawing.Point(68, 186);
            activityIdLabel.Name = "activityIdLabel";
            activityIdLabel.Size = new System.Drawing.Size(54, 16);
            activityIdLabel.TabIndex = 7;
            activityIdLabel.Text = "Занятие:";
            // 
            // seasonTTFLabel
            // 
            seasonTTFLabel.AutoSize = true;
            seasonTTFLabel.Location = new System.Drawing.Point(45, 221);
            seasonTTFLabel.Name = "seasonTTFLabel";
            seasonTTFLabel.Size = new System.Drawing.Size(82, 32);
            seasonTTFLabel.TabIndex = 9;
            seasonTTFLabel.Text = "   Наличеие\r\nабонемента:";
            // 
            // seasonTicketLabel
            // 
            seasonTicketLabel.AutoSize = true;
            seasonTicketLabel.Location = new System.Drawing.Point(45, 270);
            seasonTicketLabel.Name = "seasonTicketLabel";
            seasonTicketLabel.Size = new System.Drawing.Size(82, 32);
            seasonTicketLabel.TabIndex = 11;
            seasonTicketLabel.Text = "      Срок\r\nабонемента:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(340, 281);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 41);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewCustActivity
            // 
            this.dataGridViewCustActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDataGridViewTextBoxColumn,
            this.SurnameDataGridViewTextBoxColumn,
            this.ActivityNameIDDataGridViewTextBoxColumn,
            this.FitClubDataGridViewTextBoxColumn,
            this.DateDataGridViewTextBoxColumn,
            this.CostDataGridViewTextBoxColumn,
            this.SeasonTTFDataGridViewTextBoxColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustActivity.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCustActivity.Location = new System.Drawing.Point(24, 23);
            this.dataGridViewCustActivity.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCustActivity.Name = "dataGridViewCustActivity";
            this.dataGridViewCustActivity.RowHeadersWidth = 72;
            this.dataGridViewCustActivity.RowTemplate.Height = 31;
            this.dataGridViewCustActivity.Size = new System.Drawing.Size(622, 243);
            this.dataGridViewCustActivity.TabIndex = 14;
            // 
            // NameDataGridViewTextBoxColumn
            // 
            this.NameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.NameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn";
            // 
            // SurnameDataGridViewTextBoxColumn
            // 
            this.SurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.SurnameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn";
            // 
            // ActivityNameIDDataGridViewTextBoxColumn
            // 
            this.ActivityNameIDDataGridViewTextBoxColumn.HeaderText = "Занятие";
            this.ActivityNameIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.ActivityNameIDDataGridViewTextBoxColumn.Name = "ActivityNameIDDataGridViewTextBoxColumn";
            // 
            // FitClubDataGridViewTextBoxColumn
            // 
            this.FitClubDataGridViewTextBoxColumn.HeaderText = "Фитнес клуб";
            this.FitClubDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.FitClubDataGridViewTextBoxColumn.Name = "FitClubDataGridViewTextBoxColumn";
            // 
            // DateDataGridViewTextBoxColumn
            // 
            this.DateDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.DateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn";
            // 
            // CostDataGridViewTextBoxColumn
            // 
            this.CostDataGridViewTextBoxColumn.HeaderText = "Стоимость занятия";
            this.CostDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn";
            // 
            // SeasonTTFDataGridViewTextBoxColumn
            // 
            this.SeasonTTFDataGridViewTextBoxColumn.HeaderText = "Наличие абонемента";
            this.SeasonTTFDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.SeasonTTFDataGridViewTextBoxColumn.Name = "SeasonTTFDataGridViewTextBoxColumn";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExport.Location = new System.Drawing.Point(150, 281);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(161, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(668, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 315);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список клиентов";
            // 
            // seasonTicketTextBox
            // 
            this.seasonTicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "SeasonTicket", true));
            this.seasonTicketTextBox.Location = new System.Drawing.Point(133, 278);
            this.seasonTicketTextBox.Name = "seasonTicketTextBox";
            this.seasonTicketTextBox.Size = new System.Drawing.Size(100, 21);
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
            this.seasonTTFTextBox.Location = new System.Drawing.Point(133, 232);
            this.seasonTTFTextBox.Name = "seasonTTFTextBox";
            this.seasonTTFTextBox.Size = new System.Drawing.Size(100, 21);
            this.seasonTTFTextBox.TabIndex = 10;
            // 
            // activityIdTextBox
            // 
            this.activityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "ActivityId", true));
            this.activityIdTextBox.Location = new System.Drawing.Point(133, 183);
            this.activityIdTextBox.Name = "activityIdTextBox";
            this.activityIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.activityIdTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(133, 136);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(133, 94);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 21);
            this.surnameTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersTableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(133, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.bindingNavigator1.BindingSource = this.customersTableBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(279, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersTableTableAdapter
            // 
            this.customersTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityNameTableTableAdapter = null;
            this.tableAdapterManager.ActivityTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableTableAdapter = this.customersTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableTableAdapter = null;
            // 
            // CustomersDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(964, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridViewCustActivity);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private FitClubDBDataSetHosting fitClubDBDataSetHosting;
        private System.Windows.Forms.BindingSource customersTableBindingSource;
        private FitClubDBDataSetHostingTableAdapters.CustomersTableTableAdapter customersTableTableAdapter;
        private FitClubDBDataSetHostingTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox seasonTicketTextBox;
        private System.Windows.Forms.TextBox seasonTTFTextBox;
        private System.Windows.Forms.TextBox activityIdTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}