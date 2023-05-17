namespace Курсовая_СмирноваКристина_ИП_20_3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameTLabel;
            System.Windows.Forms.Label surnameTLabel;
            System.Windows.Forms.Label fitClubLabel;
            System.Windows.Forms.Label activityLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActivity));
            this.activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.nameTTextBox = new System.Windows.Forms.TextBox();
            this.surnameTTextBox = new System.Windows.Forms.TextBox();
            this.activityTableAdapter = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetTableAdapters.ActivityTableTableAdapter();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.fitclubComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            nameTLabel = new System.Windows.Forms.Label();
            surnameTLabel = new System.Windows.Forms.Label();
            fitClubLabel = new System.Windows.Forms.Label();
            activityLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).BeginInit();
            this.activityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTLabel
            // 
            nameTLabel.AutoSize = true;
            nameTLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameTLabel.Location = new System.Drawing.Point(71, 153);
            nameTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameTLabel.Name = "nameTLabel";
            nameTLabel.Size = new System.Drawing.Size(85, 16);
            nameTLabel.TabIndex = 29;
            nameTLabel.Text = "Имя тренера:";
            // 
            // surnameTLabel
            // 
            surnameTLabel.AutoSize = true;
            surnameTLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameTLabel.Location = new System.Drawing.Point(43, 196);
            surnameTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            surnameTLabel.Name = "surnameTLabel";
            surnameTLabel.Size = new System.Drawing.Size(115, 16);
            surnameTLabel.TabIndex = 30;
            surnameTLabel.Text = "Фамилия тренера:";
            // 
            // fitClubLabel
            // 
            fitClubLabel.AutoSize = true;
            fitClubLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fitClubLabel.Location = new System.Drawing.Point(76, 239);
            fitClubLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fitClubLabel.Name = "fitClubLabel";
            fitClubLabel.Size = new System.Drawing.Size(80, 16);
            fitClubLabel.TabIndex = 31;
            fitClubLabel.Text = "Фитнес клуб:";
            // 
            // activityLabel
            // 
            activityLabel.AutoSize = true;
            activityLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activityLabel.Location = new System.Drawing.Point(101, 278);
            activityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activityLabel.Name = "activityLabel";
            activityLabel.Size = new System.Drawing.Size(54, 16);
            activityLabel.TabIndex = 32;
            activityLabel.Text = "Занятие:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.Location = new System.Drawing.Point(49, 321);
            dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(108, 16);
            dateLabel.TabIndex = 33;
            dateLabel.Text = "Дата проведения:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeLabel.Location = new System.Drawing.Point(29, 358);
            timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(127, 16);
            timeLabel.TabIndex = 34;
            timeLabel.Text = "Длительность занятия:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(85, 399);
            costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(70, 16);
            costLabel.TabIndex = 35;
            costLabel.Text = "Стоимость:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(125, 113);
            iDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(31, 16);
            iDLabel.TabIndex = 28;
            iDLabel.Text = "Код:";
            // 
            // activityBindingNavigator
            // 
            this.activityBindingNavigator.AddNewItem = null;
            this.activityBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.activityBindingNavigator.BindingSource = this.activityBindingSource;
            this.activityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityBindingNavigator.DeleteItem = null;
            this.activityBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.activityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityBindingNavigator.Name = "activityBindingNavigator";
            this.activityBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.activityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityBindingNavigator.Size = new System.Drawing.Size(343, 35);
            this.activityBindingNavigator.TabIndex = 28;
            this.activityBindingNavigator.Text = "bindingNavigator1";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "ActivityTable";
            this.activityBindingSource.DataSource = this.fitClubDBDataSet;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 61);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Курсовая_СмирноваКристина_ИП_20_3.Properties.Resources.icons8_календарь_с_плюсом_1001;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Занятия";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(32, 433);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 35);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(32, 488);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 35);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Сохранить запись";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(183, 433);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(136, 35);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(157, 318);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(142, 21);
            this.dateDateTimePicker.TabIndex = 50;
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(157, 396);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(142, 20);
            this.costTextBox.TabIndex = 52;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // nameTTextBox
            // 
            this.nameTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "NameT", true));
            this.nameTTextBox.Location = new System.Drawing.Point(157, 153);
            this.nameTTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTTextBox.Name = "nameTTextBox";
            this.nameTTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameTTextBox.TabIndex = 57;
            this.nameTTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTTextBox_KeyPress);
            // 
            // surnameTTextBox
            // 
            this.surnameTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "SurnameT", true));
            this.surnameTTextBox.Location = new System.Drawing.Point(157, 194);
            this.surnameTTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTTextBox.Name = "surnameTTextBox";
            this.surnameTTextBox.Size = new System.Drawing.Size(142, 20);
            this.surnameTTextBox.TabIndex = 58;
            this.surnameTTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTTextBox_KeyPress);
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // activityComboBox
            // 
            this.activityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Activity", true));
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Items.AddRange(new object[] {
            "Пилатес",
            "Бокс",
            "Гимнастика на полотнах",
            "Stretching",
            "Единоборства",
            "Йога"});
            this.activityComboBox.Location = new System.Drawing.Point(157, 276);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(142, 21);
            this.activityComboBox.TabIndex = 59;
            // 
            // fitclubComboBox
            // 
            this.fitclubComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "FitClub", true));
            this.fitclubComboBox.FormattingEnabled = true;
            this.fitclubComboBox.Items.AddRange(new object[] {
            "FITHIT(м. Автово)",
            "FITHIT(м. Пионерская)",
            "FITHIT(м. Беговая)"});
            this.fitclubComboBox.Location = new System.Drawing.Point(157, 237);
            this.fitclubComboBox.Name = "fitclubComboBox";
            this.fitclubComboBox.Size = new System.Drawing.Size(142, 21);
            this.fitclubComboBox.TabIndex = 60;
            // 
            // timeComboBox
            // 
            this.timeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "Time", true));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "1,5 часа",
            "2 часа"});
            this.timeComboBox.Location = new System.Drawing.Point(157, 356);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(142, 21);
            this.timeComboBox.TabIndex = 61;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая_СмирноваКристина_ИП_20_3.FitClubDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableTableAdapter = null;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(157, 111);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(142, 20);
            this.iDTextBox.TabIndex = 56;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(183, 488);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 35);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(343, 531);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.fitclubComboBox);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.surnameTTextBox);
            this.Controls.Add(this.nameTTextBox);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(costLabel);
            this.Controls.Add(timeLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(activityLabel);
            this.Controls.Add(fitClubLabel);
            this.Controls.Add(surnameTLabel);
            this.Controls.Add(nameTLabel);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.activityBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddActivity";
            this.Text = "Добавить занятие";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingNavigator)).EndInit();
            this.activityBindingNavigator.ResumeLayout(false);
            this.activityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitClubDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator activityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox nameTTextBox;
        private System.Windows.Forms.TextBox surnameTTextBox;
        private FitClubDBDataSet fitClubDBDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private FitClubDBDataSetTableAdapters.ActivityTableTableAdapter activityTableAdapter;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.ComboBox fitclubComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private FitClubDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}