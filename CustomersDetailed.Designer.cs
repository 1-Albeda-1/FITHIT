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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(383, 279);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dataGridViewCustActivity.Location = new System.Drawing.Point(24, 23);
            this.dataGridViewCustActivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCustActivity.Name = "dataGridViewCustActivity";
            this.dataGridViewCustActivity.RowHeadersWidth = 72;
            this.dataGridViewCustActivity.RowTemplate.Height = 31;
            this.dataGridViewCustActivity.Size = new System.Drawing.Size(710, 243);
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
            this.btnExport.Location = new System.Drawing.Point(193, 279);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(161, 41);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Экспорт в Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // CustomersDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(770, 333);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridViewCustActivity);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CustomersDetailed";
            this.Text = "Подробная информация о записи";
            this.Load += new System.EventHandler(this.CustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dataGridViewCustActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FitClubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeasonTTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExport;
    }
}