﻿namespace Курсовая_СмирноваКристина_ИП_20_3
{
    partial class ActivityTable
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityTable));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассписаниеЗанятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewActivity = new System.Windows.Forms.DataGridView();
            this.bindingSourceActivity = new System.Windows.Forms.BindingSource(this.components);
            this.fitClubDBDataSetHosting = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHosting();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.listBoxSort = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAccount = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxCriteria = new System.Windows.Forms.TextBox();
            this.comboBoxActivityName = new System.Windows.Forms.ComboBox();
            this.activityNameTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.activityTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.ActivityTableTableAdapter();
            this.activityNameTableTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetHostingTableAdapters.ActivityNameTableTableAdapter();
            this.IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FitClubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityNameTableBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(826, 34);
            this.menuStrip1.TabIndex = 0;
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
            // dataGridViewActivity
            // 
            this.dataGridViewActivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDataGridViewTextBoxColumn,
            this.NameTDataGridViewTextBoxColumn,
            this.SurnameTDataGridViewTextBoxColumn,
            this.FitClubDataGridViewTextBoxColumn,
            this.ActivityNameIDDataGridViewTextBoxColumn,
            this.DateDataGridViewTextBoxColumn,
            this.StartTimeDataGridViewTextBoxColumn,
            this.TimeDataGridViewTextBoxColumn,
            this.CostDataGridViewTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActivity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewActivity.Location = new System.Drawing.Point(20, 62);
            this.dataGridViewActivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.RowHeadersWidth = 72;
            this.dataGridViewActivity.RowTemplate.Height = 31;
            this.dataGridViewActivity.Size = new System.Drawing.Size(548, 243);
            this.dataGridViewActivity.TabIndex = 1;
            // 
            // bindingSourceActivity
            // 
            this.bindingSourceActivity.DataSource = this.fitClubDBDataSetHosting;
            this.bindingSourceActivity.Position = 0;
            // 
            // fitClubDBDataSetHosting
            // 
            this.fitClubDBDataSetHosting.DataSetName = "FitClubDBDataSetHosting";
            this.fitClubDBDataSetHosting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(143, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица Расписание занятий \"FITHIT\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Критерий";
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
            this.buttonSort.Location = new System.Drawing.Point(17, 177);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(175, 24);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // listBoxSort
            // 
            this.listBoxSort.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 16;
            this.listBoxSort.Items.AddRange(new object[] {
            "Имя тренера",
            "Фамилия тренера",
            "Занятие",
            "Дата проведения",
            "Длительность занятия",
            "Стоимость"});
            this.listBoxSort.Location = new System.Drawing.Point(17, 42);
            this.listBoxSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(177, 84);
            this.listBoxSort.TabIndex = 8;
            this.listBoxSort.SelectedIndexChanged += new System.EventHandler(this.listBoxSort_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDown);
            this.groupBox1.Controls.Add(this.radioButtonUp);
            this.groupBox1.Controls.Add(this.listBoxSort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSort);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(593, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(207, 215);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(17, 157);
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
            this.radioButtonUp.Location = new System.Drawing.Point(17, 139);
            this.radioButtonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(189, 20);
            this.radioButtonUp.TabIndex = 9;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Сортировка по возрастанию";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(593, 285);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(88, 41);
            this.buttonFilter.TabIndex = 10;
            this.buttonFilter.Text = "Фильтровать";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewAll.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewAll.Location = new System.Drawing.Point(712, 285);
            this.buttonViewAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(88, 41);
            this.buttonViewAll.TabIndex = 11;
            this.buttonViewAll.Text = "Показать всё";
            this.buttonViewAll.UseVisualStyleBackColor = false;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(593, 330);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 41);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint,
            this.toolStripStatusLabelAccount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 14;
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
            // textBoxCriteria
            // 
            this.textBoxCriteria.Location = new System.Drawing.Point(130, 351);
            this.textBoxCriteria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCriteria.Name = "textBoxCriteria";
            this.textBoxCriteria.Size = new System.Drawing.Size(439, 20);
            this.textBoxCriteria.TabIndex = 15;
            this.textBoxCriteria.MouseEnter += new System.EventHandler(this.textBoxCriteria_MouseEnter);
            this.textBoxCriteria.MouseLeave += new System.EventHandler(this.textBoxCriteria_MouseLeave);
            // 
            // comboBoxActivityName
            // 
            this.comboBoxActivityName.DataSource = this.activityNameTableBindingSource;
            this.comboBoxActivityName.DisplayMember = "ActivityName";
            this.comboBoxActivityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivityName.FormattingEnabled = true;
            this.comboBoxActivityName.Location = new System.Drawing.Point(130, 318);
            this.comboBoxActivityName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxActivityName.Name = "comboBoxActivityName";
            this.comboBoxActivityName.Size = new System.Drawing.Size(439, 21);
            this.comboBoxActivityName.TabIndex = 16;
            this.comboBoxActivityName.ValueMember = "ID";
            this.comboBoxActivityName.MouseEnter += new System.EventHandler(this.comboBoxActivityName_MouseEnter);
            this.comboBoxActivityName.MouseLeave += new System.EventHandler(this.comboBoxActivityName_MouseLeave);
            // 
            // activityNameTableBindingSource
            // 
            this.activityNameTableBindingSource.DataMember = "ActivityNameTable";
            this.activityNameTableBindingSource.DataSource = this.bindingSourceActivity;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(712, 331);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 41);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // activityTableTableAdapter
            // 
            this.activityTableTableAdapter.ClearBeforeFill = true;
            // 
            // activityNameTableTableAdapter
            // 
            this.activityNameTableTableAdapter.ClearBeforeFill = true;
            // 
            // IDDataGridViewTextBoxColumn
            // 
            this.IDDataGridViewTextBoxColumn.HeaderText = "Код занятия";
            this.IDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
            this.IDDataGridViewTextBoxColumn.Visible = false;
            this.IDDataGridViewTextBoxColumn.Width = 175;
            // 
            // NameTDataGridViewTextBoxColumn
            // 
            this.NameTDataGridViewTextBoxColumn.HeaderText = "Имя тренера";
            this.NameTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.NameTDataGridViewTextBoxColumn.Name = "NameTDataGridViewTextBoxColumn";
            this.NameTDataGridViewTextBoxColumn.Width = 175;
            // 
            // SurnameTDataGridViewTextBoxColumn
            // 
            this.SurnameTDataGridViewTextBoxColumn.HeaderText = "Фамилия тренера";
            this.SurnameTDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.SurnameTDataGridViewTextBoxColumn.Name = "SurnameTDataGridViewTextBoxColumn";
            this.SurnameTDataGridViewTextBoxColumn.Width = 175;
            // 
            // FitClubDataGridViewTextBoxColumn
            // 
            this.FitClubDataGridViewTextBoxColumn.HeaderText = "Фитнес клуб";
            this.FitClubDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.FitClubDataGridViewTextBoxColumn.Name = "FitClubDataGridViewTextBoxColumn";
            this.FitClubDataGridViewTextBoxColumn.Width = 175;
            // 
            // ActivityNameIDDataGridViewTextBoxColumn
            // 
            this.ActivityNameIDDataGridViewTextBoxColumn.HeaderText = "Занятие";
            this.ActivityNameIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.ActivityNameIDDataGridViewTextBoxColumn.Name = "ActivityNameIDDataGridViewTextBoxColumn";
            this.ActivityNameIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // DateDataGridViewTextBoxColumn
            // 
            this.DateDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.DateDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn";
            this.DateDataGridViewTextBoxColumn.Width = 175;
            // 
            // StartTimeDataGridViewTextBoxColumn
            // 
            this.StartTimeDataGridViewTextBoxColumn.HeaderText = "Время проведения";
            this.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn";
            // 
            // TimeDataGridViewTextBoxColumn
            // 
            this.TimeDataGridViewTextBoxColumn.HeaderText = "Длительность занятия";
            this.TimeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn";
            this.TimeDataGridViewTextBoxColumn.Width = 175;
            // 
            // CostDataGridViewTextBoxColumn
            // 
            this.CostDataGridViewTextBoxColumn.HeaderText = "Стоимость занятия";
            this.CostDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn";
            this.CostDataGridViewTextBoxColumn.Width = 175;
            // 
            // ActivityTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(826, 410);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxActivityName);
            this.Controls.Add(this.textBoxCriteria);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewActivity);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "ActivityTable";
            this.Text = "FITHIT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActivityTable_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSetHosting)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityNameTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассписаниеЗанятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewActivity;
        private System.Windows.Forms.BindingSource bindingSourceActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.TextBox textBoxCriteria;
        private System.Windows.Forms.ComboBox comboBoxActivityName;
        private System.Windows.Forms.ToolStripMenuItem экспортДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAccount;
        private System.Windows.Forms.Button buttonDelete;
        private FitClubDBDataSetHosting fitClubDBDataSetHosting;
        private FitClubDBDataSetHostingTableAdapters.ActivityTableTableAdapter activityTableTableAdapter;
        private System.Windows.Forms.BindingSource activityNameTableBindingSource;
        private FitClubDBDataSetHostingTableAdapters.ActivityNameTableTableAdapter activityNameTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDataGridViewTextBoxColumn;
    }
}

