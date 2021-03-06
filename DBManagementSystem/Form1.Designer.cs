﻿namespace DBManagementSystem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.filterDataBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataSetDJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDJ = new DBManagementSystem.DataSetDJ();
            this.crystalReport31 = new DBManagementSystem.CrystalReport3();
            this.cachedCrystalReport31 = new DBManagementSystem.CachedCrystalReport3();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnPropsCombo = new System.Windows.Forms.ComboBox();
            this.autoIncrementCheckBox = new System.Windows.Forms.CheckBox();
            this.columnTypeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.objectTypeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backUpTableBtn = new System.Windows.Forms.Button();
            this.deleteTableBtn = new System.Windows.Forms.Button();
            this.deleteDatabaseBtn = new System.Windows.Forms.Button();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.tablesCombo = new System.Windows.Forms.ComboBox();
            this.databaseCombo = new System.Windows.Forms.ComboBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.importExportCombo = new System.Windows.Forms.ComboBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDJ)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(527, 355);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "WHERE [column] < [operand]";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // filterDataBtn
            // 
            this.filterDataBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterDataBtn.Location = new System.Drawing.Point(365, 30);
            this.filterDataBtn.Margin = new System.Windows.Forms.Padding(1);
            this.filterDataBtn.Name = "filterDataBtn";
            this.filterDataBtn.Size = new System.Drawing.Size(164, 27);
            this.filterDataBtn.TabIndex = 10;
            this.filterDataBtn.Text = "Filter Data";
            this.filterDataBtn.UseVisualStyleBackColor = false;
            this.filterDataBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Condition";
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateDataBtn.Location = new System.Drawing.Point(365, 74);
            this.updateDataBtn.Margin = new System.Windows.Forms.Padding(1);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(164, 27);
            this.updateDataBtn.TabIndex = 14;
            this.updateDataBtn.Text = "Update Data";
            this.updateDataBtn.UseVisualStyleBackColor = false;
            this.updateDataBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 80);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(345, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "SET column=value where column = x";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.filterDataBtn);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.updateDataBtn);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(390, 407);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox5.Size = new System.Drawing.Size(543, 110);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Control";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dataSetDJBindingSource
            // 
            this.dataSetDJBindingSource.DataSource = this.dataSetDJ;
            this.dataSetDJBindingSource.Position = 0;
            // 
            // dataSetDJ
            // 
            this.dataSetDJ.DataSetName = "DataSetDJ";
            this.dataSetDJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(199, 491);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 110);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danger Zone";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(12, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rollback";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(390, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 387);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crystalReportViewer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(6, 6);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(523, 352);
            this.crystalReportViewer1.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.columnPropsCombo);
            this.groupBox3.Controls.Add(this.autoIncrementCheckBox);
            this.groupBox3.Controls.Add(this.columnTypeCombo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.createBtn);
            this.groupBox3.Controls.Add(this.objectTypeCombo);
            this.groupBox3.Location = new System.Drawing.Point(10, 332);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(177, 269);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Object";
            // 
            // columnPropsCombo
            // 
            this.columnPropsCombo.FormattingEnabled = true;
            this.columnPropsCombo.Items.AddRange(new object[] {
            "Primary Key",
            "Unique",
            "Index"});
            this.columnPropsCombo.Location = new System.Drawing.Point(14, 161);
            this.columnPropsCombo.Margin = new System.Windows.Forms.Padding(1);
            this.columnPropsCombo.Name = "columnPropsCombo";
            this.columnPropsCombo.Size = new System.Drawing.Size(148, 21);
            this.columnPropsCombo.TabIndex = 9;
            this.columnPropsCombo.Text = "Column Props";
            // 
            // autoIncrementCheckBox
            // 
            this.autoIncrementCheckBox.AutoSize = true;
            this.autoIncrementCheckBox.Location = new System.Drawing.Point(14, 187);
            this.autoIncrementCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.autoIncrementCheckBox.Name = "autoIncrementCheckBox";
            this.autoIncrementCheckBox.Size = new System.Drawing.Size(98, 17);
            this.autoIncrementCheckBox.TabIndex = 8;
            this.autoIncrementCheckBox.Text = "Auto Increment";
            this.autoIncrementCheckBox.UseVisualStyleBackColor = true;
            // 
            // columnTypeCombo
            // 
            this.columnTypeCombo.FormattingEnabled = true;
            this.columnTypeCombo.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Real",
            "Decimal",
            "Numeric",
            "Char",
            "Varchar",
            "Text",
            "Date",
            "DateTime",
            "Time"});
            this.columnTypeCombo.Location = new System.Drawing.Point(14, 137);
            this.columnTypeCombo.Margin = new System.Windows.Forms.Padding(1);
            this.columnTypeCombo.Name = "columnTypeCombo";
            this.columnTypeCombo.Size = new System.Drawing.Size(148, 21);
            this.columnTypeCombo.TabIndex = 7;
            this.columnTypeCombo.Text = "Column Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(14, 99);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createBtn.Location = new System.Drawing.Point(14, 215);
            this.createBtn.Margin = new System.Windows.Forms.Padding(1);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(146, 27);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // objectTypeCombo
            // 
            this.objectTypeCombo.FormattingEnabled = true;
            this.objectTypeCombo.Items.AddRange(new object[] {
            "Database",
            "User",
            "Table",
            "Column"});
            this.objectTypeCombo.Location = new System.Drawing.Point(14, 46);
            this.objectTypeCombo.Margin = new System.Windows.Forms.Padding(1);
            this.objectTypeCombo.Name = "objectTypeCombo";
            this.objectTypeCombo.Size = new System.Drawing.Size(148, 21);
            this.objectTypeCombo.TabIndex = 5;
            this.objectTypeCombo.Text = "Object Type";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.selectBtn);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(199, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(187, 307);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(12, 262);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(164, 27);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectBtn.Location = new System.Drawing.Point(12, 226);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(1);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(164, 27);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 24);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.backUpTableBtn);
            this.groupBox1.Controls.Add(this.deleteTableBtn);
            this.groupBox1.Controls.Add(this.deleteDatabaseBtn);
            this.groupBox1.Controls.Add(this.databaseLabel);
            this.groupBox1.Controls.Add(this.tablesCombo);
            this.groupBox1.Controls.Add(this.databaseCombo);
            this.groupBox1.Controls.Add(this.tableLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(177, 307);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // backUpTableBtn
            // 
            this.backUpTableBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backUpTableBtn.Location = new System.Drawing.Point(14, 262);
            this.backUpTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.backUpTableBtn.Name = "backUpTableBtn";
            this.backUpTableBtn.Size = new System.Drawing.Size(146, 27);
            this.backUpTableBtn.TabIndex = 7;
            this.backUpTableBtn.Text = "Backup Database";
            this.backUpTableBtn.UseVisualStyleBackColor = false;
            // 
            // deleteTableBtn
            // 
            this.deleteTableBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteTableBtn.Location = new System.Drawing.Point(14, 172);
            this.deleteTableBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteTableBtn.Name = "deleteTableBtn";
            this.deleteTableBtn.Size = new System.Drawing.Size(146, 27);
            this.deleteTableBtn.TabIndex = 6;
            this.deleteTableBtn.Text = "Delete Table";
            this.deleteTableBtn.UseVisualStyleBackColor = false;
            this.deleteTableBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // deleteDatabaseBtn
            // 
            this.deleteDatabaseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteDatabaseBtn.Location = new System.Drawing.Point(14, 96);
            this.deleteDatabaseBtn.Margin = new System.Windows.Forms.Padding(1);
            this.deleteDatabaseBtn.Name = "deleteDatabaseBtn";
            this.deleteDatabaseBtn.Size = new System.Drawing.Size(146, 27);
            this.deleteDatabaseBtn.TabIndex = 5;
            this.deleteDatabaseBtn.Text = "Delete Database";
            this.deleteDatabaseBtn.UseVisualStyleBackColor = false;
            this.deleteDatabaseBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(59, 59);
            this.databaseLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(53, 13);
            this.databaseLabel.TabIndex = 1;
            this.databaseLabel.Text = "Database";
            // 
            // tablesCombo
            // 
            this.tablesCombo.FormattingEnabled = true;
            this.tablesCombo.Location = new System.Drawing.Point(14, 149);
            this.tablesCombo.Margin = new System.Windows.Forms.Padding(1);
            this.tablesCombo.Name = "tablesCombo";
            this.tablesCombo.Size = new System.Drawing.Size(148, 21);
            this.tablesCombo.TabIndex = 4;
            this.tablesCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // databaseCombo
            // 
            this.databaseCombo.FormattingEnabled = true;
            this.databaseCombo.Location = new System.Drawing.Point(14, 73);
            this.databaseCombo.Margin = new System.Windows.Forms.Padding(1);
            this.databaseCombo.Name = "databaseCombo";
            this.databaseCombo.Size = new System.Drawing.Size(148, 21);
            this.databaseCombo.TabIndex = 3;
            this.databaseCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(66, 135);
            this.tableLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(34, 13);
            this.tableLabel.TabIndex = 2;
            this.tableLabel.Text = "Table";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.importExportCombo);
            this.groupBox4.Controls.Add(this.exportBtn);
            this.groupBox4.Controls.Add(this.importBtn);
            this.groupBox4.Location = new System.Drawing.Point(199, 332);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.Size = new System.Drawing.Size(187, 155);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Import/ ExportCSV";
            // 
            // importExportCombo
            // 
            this.importExportCombo.FormattingEnabled = true;
            this.importExportCombo.Items.AddRange(new object[] {
            "CSV",
            "XML",
            "SQL",
            "Grid2PDF"});
            this.importExportCombo.Location = new System.Drawing.Point(12, 26);
            this.importExportCombo.Margin = new System.Windows.Forms.Padding(1);
            this.importExportCombo.Name = "importExportCombo";
            this.importExportCombo.Size = new System.Drawing.Size(166, 21);
            this.importExportCombo.TabIndex = 12;
            this.importExportCombo.Text = "Import/ExportCSV Type";
            this.importExportCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportBtn.Location = new System.Drawing.Point(12, 61);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(1);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(164, 27);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Export Data";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importBtn.Location = new System.Drawing.Point(12, 103);
            this.importBtn.Margin = new System.Windows.Forms.Padding(1);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(164, 27);
            this.importBtn.TabIndex = 8;
            this.importBtn.Text = "Import Data";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "SQL Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDJ)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetDJBindingSource;
        private DataSetDJ dataSetDJ;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button filterDataBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CrystalReport3 crystalReport31;
        private CachedCrystalReport3 cachedCrystalReport31;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox columnPropsCombo;
        private System.Windows.Forms.CheckBox autoIncrementCheckBox;
        private System.Windows.Forms.ComboBox columnTypeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ComboBox objectTypeCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backUpTableBtn;
        private System.Windows.Forms.Button deleteTableBtn;
        private System.Windows.Forms.Button deleteDatabaseBtn;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.ComboBox tablesCombo;
        private System.Windows.Forms.ComboBox databaseCombo;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox importExportCombo;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        //  private CachedCrystalReport2 cachedCrystalReport21;
        //   private CrystalReport2 crystalReport21;
        //  private CachedCrystalReport2 cachedCrystalReport21;
    }
}

