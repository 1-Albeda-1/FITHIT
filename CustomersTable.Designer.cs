namespace Курсовая_СмирноваКристина_ИП_20_3
{
    partial class CustomersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассписаниеЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorCustomers = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSourceCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.fitClubDBDataSet = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonTTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAccount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.listBoxSort = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxCustomersActivity = new System.Windows.Forms.ComboBox();
            this.activityTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCriteria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customersTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetTableAdapters.CustomersTableTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.activityTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetTableAdapters.ActivityTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCustomers)).BeginInit();
            this.bindingNavigatorCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.добавитьЗаписьToolStripMenuItem,
            this.экспортДанныхToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(814, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассписаниеЗанятийToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_база_данных_100;
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // рассписаниеЗанятийToolStripMenuItem
            // 
            this.рассписаниеЗанятийToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_посмотреть_расписание_100;
            this.рассписаниеЗанятийToolStripMenuItem.Name = "рассписаниеЗанятийToolStripMenuItem";
            this.рассписаниеЗанятийToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.рассписаниеЗанятийToolStripMenuItem.Text = "Рассписание занятий";
            this.рассписаниеЗанятийToolStripMenuItem.Click += new System.EventHandler(this.рассписаниеЗанятийToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_пользователь_100__1_;
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_добавить_100;
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // экспортДанныхToolStripMenuItem
            // 
            this.экспортДанныхToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_export_excel_100;
            this.экспортДанныхToolStripMenuItem.Name = "экспортДанныхToolStripMenuItem";
            this.экспортДанныхToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
            this.экспортДанныхToolStripMenuItem.Text = "Экспорт данных";
            this.экспортДанныхToolStripMenuItem.Click += new System.EventHandler(this.экспортДанныхToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрСправкиToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_документ_100;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотрСправкиToolStripMenuItem
            // 
            this.просмотрСправкиToolStripMenuItem.Name = "просмотрСправкиToolStripMenuItem";
            this.просмотрСправкиToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.просмотрСправкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотрСправкиToolStripMenuItem.Click += new System.EventHandler(this.просмотрСправкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_выход_100;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // bindingNavigatorCustomers
            // 
            this.bindingNavigatorCustomers.AddNewItem = null;
            this.bindingNavigatorCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.bindingNavigatorCustomers.BindingSource = this.bindingSourceCustomers;
            this.bindingNavigatorCustomers.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCustomers.DeleteItem = null;
            this.bindingNavigatorCustomers.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.bindingNavigatorCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorCustomers.Location = new System.Drawing.Point(0, 34);
            this.bindingNavigatorCustomers.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCustomers.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCustomers.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCustomers.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCustomers.Name = "bindingNavigatorCustomers";
            this.bindingNavigatorCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigatorCustomers.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCustomers.Size = new System.Drawing.Size(814, 35);
            this.bindingNavigatorCustomers.TabIndex = 2;
            this.bindingNavigatorCustomers.Text = "bindingNavigator1";
            // 
            // bindingSourceCustomers
            // 
            this.bindingSourceCustomers.DataMember = "CustomersTable";
            this.bindingSourceCustomers.DataSource = this.fitClubDBDataSet;
            // 
            // fitClubDBDataSet
            // 
            this.fitClubDBDataSet.DataSetName = "FitClubDBDataSet";
            this.fitClubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(29, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.surname,
            this.phoneDataGridViewTextBoxColumn,
            this.activityid,
            this.seasonTTFDataGridViewTextBoxColumn,
            this.seasonTicketDataGridViewTextBoxColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(18, 102);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewCustomers.RowHeadersWidth = 72;
            this.dataGridViewCustomers.RowTemplate.Height = 31;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(554, 251);
            this.dataGridViewCustomers.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код клиента";
            this.ID.MinimumWidth = 9;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 175;
            // 
            // name
            // 
            this.name.HeaderText = "Имя клиента";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.Width = 175;
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия клиента";
            this.surname.MinimumWidth = 9;
            this.surname.Name = "surname";
            this.surname.Width = 175;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 175;
            // 
            // activityid
            // 
            this.activityid.HeaderText = "Занятие";
            this.activityid.MinimumWidth = 9;
            this.activityid.Name = "activityid";
            this.activityid.Width = 175;
            // 
            // seasonTTFDataGridViewTextBoxColumn
            // 
            this.seasonTTFDataGridViewTextBoxColumn.HeaderText = "Наличие абонемента";
            this.seasonTTFDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.seasonTTFDataGridViewTextBoxColumn.Name = "seasonTTFDataGridViewTextBoxColumn";
            this.seasonTTFDataGridViewTextBoxColumn.Width = 175;
            // 
            // seasonTicketDataGridViewTextBoxColumn
            // 
            this.seasonTicketDataGridViewTextBoxColumn.HeaderText = "Срок абонемента";
            this.seasonTicketDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.seasonTicketDataGridViewTextBoxColumn.Name = "seasonTicketDataGridViewTextBoxColumn";
            this.seasonTicketDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint,
            this.toolStripStatusLabelAccount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabelHint.Text = " ";
            // 
            // toolStripStatusLabelAccount
            // 
            this.toolStripStatusLabelAccount.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelAccount.Margin = new System.Windows.Forms.Padding(600, 3, 0, 2);
            this.toolStripStatusLabelAccount.Name = "toolStripStatusLabelAccount";
            this.toolStripStatusLabelAccount.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabelAccount.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(196, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Таблица Клиенты \"FITHIT\"";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(593, 367);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 41);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewAll.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewAll.Location = new System.Drawing.Point(713, 323);
            this.buttonViewAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(88, 41);
            this.buttonViewAll.TabIndex = 19;
            this.buttonViewAll.Text = "Показать всё";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(593, 323);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(88, 41);
            this.buttonFilter.TabIndex = 18;
            this.buttonFilter.Text = "Фильтровать";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDown);
            this.groupBox1.Controls.Add(this.radioButtonUp);
            this.groupBox1.Controls.Add(this.listBoxSort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(593, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(207, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(17, 141);
            this.radioButtonDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(170, 20);
            this.radioButtonDown.TabIndex = 10;
            this.radioButtonDown.Text = "Сортировка по убыванию";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Checked = true;
            this.radioButtonUp.Location = new System.Drawing.Point(17, 123);
            this.radioButtonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(189, 20);
            this.radioButtonUp.TabIndex = 9;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Сортировка по возрастанию";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // listBoxSort
            // 
            this.listBoxSort.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 16;
            this.listBoxSort.Items.AddRange(new object[] {
            "Имя клиента",
            "Фамилия клиента",
            "Занятие"});
            this.listBoxSort.Location = new System.Drawing.Point(17, 42);
            this.listBoxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(177, 52);
            this.listBoxSort.TabIndex = 8;
            this.listBoxSort.SelectedIndexChanged += new System.EventHandler(this.listBoxSort_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поле для сортировки";
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonSort.Enabled = false;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSort.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(17, 161);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(175, 24);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxCustomersActivity
            // 
            this.comboBoxCustomersActivity.DataSource = this.activityTableBindingSource;
            this.comboBoxCustomersActivity.DisplayMember = "Activity";
            this.comboBoxCustomersActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomersActivity.FormattingEnabled = true;
            this.comboBoxCustomersActivity.Location = new System.Drawing.Point(133, 378);
            this.comboBoxCustomersActivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCustomersActivity.Name = "comboBoxCustomersActivity";
            this.comboBoxCustomersActivity.Size = new System.Drawing.Size(439, 21);
            this.comboBoxCustomersActivity.TabIndex = 25;
            this.comboBoxCustomersActivity.ValueMember = "ID";
            this.comboBoxCustomersActivity.MouseEnter += new System.EventHandler(this.comboBoxCustomersName_MouseEnter);
            this.comboBoxCustomersActivity.MouseLeave += new System.EventHandler(this.comboBoxCustomersActivity_MouseLeave);
            // 
            // activityTableBindingSource
            // 
            this.activityTableBindingSource.DataMember = "ActivityTable";
            this.activityTableBindingSource.DataSource = this.fitClubDBDataSet;
            // 
            // textBoxCriteria
            // 
            this.textBoxCriteria.Location = new System.Drawing.Point(133, 410);
            this.textBoxCriteria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCriteria.Name = "textBoxCriteria";
            this.textBoxCriteria.Size = new System.Drawing.Size(439, 20);
            this.textBoxCriteria.TabIndex = 24;
            this.textBoxCriteria.MouseEnter += new System.EventHandler(this.textBoxCriteria_MouseEnter);
            this.textBoxCriteria.MouseLeave += new System.EventHandler(this.textBoxCriteria_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Критерий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Наименование";
            // 
            // customersTableTableAdapter
            // 
            this.customersTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(713, 367);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 41);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Удалить запись";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // activityTableTableAdapter
            // 
            this.activityTableTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(814, 472);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxCustomersActivity);
            this.Controls.Add(this.textBoxCriteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.bindingNavigatorCustomers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersTable";
            this.Text = "FITHIT";
            this.Load += new System.EventHandler(this.CustomersTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCustomers)).EndInit();
            this.bindingNavigatorCustomers.ResumeLayout(false);
            this.bindingNavigatorCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассписаниеЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCustomers;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSourceCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxCustomersActivity;
        private System.Windows.Forms.TextBox textBoxCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private FitClubDBDataSet fitClubDBDataSet;
        private FitClubDBDataSetTableAdapters.CustomersTableTableAdapter customersTableTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityid;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonTTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource activityTableBindingSource;
        private FitClubDBDataSetTableAdapters.ActivityTableTableAdapter activityTableTableAdapter;
    }
}