namespace QuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classErrLabel = new System.Windows.Forms.Label();
            this.idErrLabel = new System.Windows.Forms.Label();
            this.nameErrLabel = new System.Windows.Forms.Label();
            this.mailErrLabel = new System.Windows.Forms.Label();
            this.phoneErrLabel1 = new System.Windows.Forms.Label();
            this.undoBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.ComboBox();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sinhvienDataGrid = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1162, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.classErrLabel);
            this.panel1.Controls.Add(this.idErrLabel);
            this.panel1.Controls.Add(this.nameErrLabel);
            this.panel1.Controls.Add(this.mailErrLabel);
            this.panel1.Controls.Add(this.phoneErrLabel1);
            this.panel1.Controls.Add(this.undoBtn);
            this.panel1.Controls.Add(this.modifyBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.codeBox);
            this.panel1.Controls.Add(this.otherRadio);
            this.panel1.Controls.Add(this.femaleRadio);
            this.panel1.Controls.Add(this.maleRadio);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.classTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 255);
            this.panel1.TabIndex = 1;
            // 
            // classErrLabel
            // 
            this.classErrLabel.AutoSize = true;
            this.classErrLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classErrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(12)))));
            this.classErrLabel.Location = new System.Drawing.Point(364, 126);
            this.classErrLabel.Name = "classErrLabel";
            this.classErrLabel.Size = new System.Drawing.Size(116, 17);
            this.classErrLabel.TabIndex = 32;
            this.classErrLabel.Text = "Fill students Class!";
            this.classErrLabel.Visible = false;
            // 
            // idErrLabel
            // 
            this.idErrLabel.AutoSize = true;
            this.idErrLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idErrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(12)))));
            this.idErrLabel.Location = new System.Drawing.Point(380, 73);
            this.idErrLabel.Name = "idErrLabel";
            this.idErrLabel.Size = new System.Drawing.Size(100, 17);
            this.idErrLabel.TabIndex = 31;
            this.idErrLabel.Text = "Fill students ID!";
            this.idErrLabel.Visible = false;
            // 
            // nameErrLabel
            // 
            this.nameErrLabel.AutoSize = true;
            this.nameErrLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(12)))));
            this.nameErrLabel.Location = new System.Drawing.Point(359, 18);
            this.nameErrLabel.Name = "nameErrLabel";
            this.nameErrLabel.Size = new System.Drawing.Size(121, 17);
            this.nameErrLabel.TabIndex = 29;
            this.nameErrLabel.Text = "Fill students Name!";
            this.nameErrLabel.Visible = false;
            // 
            // mailErrLabel
            // 
            this.mailErrLabel.AutoSize = true;
            this.mailErrLabel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailErrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(12)))));
            this.mailErrLabel.Location = new System.Drawing.Point(1038, 123);
            this.mailErrLabel.Name = "mailErrLabel";
            this.mailErrLabel.Size = new System.Drawing.Size(82, 17);
            this.mailErrLabel.TabIndex = 28;
            this.mailErrLabel.Text = "Invalid Email";
            this.mailErrLabel.Visible = false;
            // 
            // phoneErrLabel1
            // 
            this.phoneErrLabel1.AutoSize = true;
            this.phoneErrLabel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(12)))));
            this.phoneErrLabel1.Location = new System.Drawing.Point(883, 69);
            this.phoneErrLabel1.Name = "phoneErrLabel1";
            this.phoneErrLabel1.Size = new System.Drawing.Size(237, 17);
            this.phoneErrLabel1.TabIndex = 27;
            this.phoneErrLabel1.Text = "Allow 9 to 10 digits without 0 at begin";
            this.phoneErrLabel1.Visible = false;
            // 
            // undoBtn
            // 
            this.undoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.undoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undoBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoBtn.Location = new System.Drawing.Point(590, 216);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(64, 26);
            this.undoBtn.TabIndex = 26;
            this.undoBtn.Text = "UNDO";
            this.undoBtn.UseVisualStyleBackColor = false;
            this.undoBtn.Visible = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.modifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBtn.Location = new System.Drawing.Point(837, 197);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(125, 45);
            this.modifyBtn.TabIndex = 25;
            this.modifyBtn.Text = "MODIFY";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(995, 197);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(125, 45);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(674, 197);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 45);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(828, 89);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(292, 28);
            this.phoneTextBox.TabIndex = 22;
            this.phoneTextBox.WordWrap = false;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.FormattingEnabled = true;
            this.codeBox.Location = new System.Drawing.Point(730, 91);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(78, 29);
            this.codeBox.TabIndex = 21;
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Location = new System.Drawing.Point(941, 44);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(65, 21);
            this.otherRadio.TabIndex = 18;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(828, 43);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(75, 21);
            this.femaleRadio.TabIndex = 17;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(730, 43);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(59, 21);
            this.maleRadio.TabIndex = 16;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(730, 143);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(390, 28);
            this.mailTextBox.TabIndex = 15;
            this.mailTextBox.WordWrap = false;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // birthDate
            // 
            this.birthDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDate.Location = new System.Drawing.Point(114, 194);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(366, 32);
            this.birthDate.TabIndex = 14;
            this.birthDate.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(611, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mail:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classTextBox
            // 
            this.classTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTextBox.Location = new System.Drawing.Point(114, 146);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(366, 28);
            this.classTextBox.TabIndex = 9;
            this.classTextBox.WordWrap = false;
            this.classTextBox.TextChanged += new System.EventHandler(this.classTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(114, 93);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(366, 28);
            this.idTextBox.TabIndex = 8;
            this.idTextBox.WordWrap = false;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(114, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(366, 28);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birth:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Class:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin Sinh Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sinhvienDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1156, 352);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên";
            // 
            // sinhvienDataGrid
            // 
            this.sinhvienDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhvienDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.idCol,
            this.classCol,
            this.birthCol,
            this.genderCol,
            this.phoneCol,
            this.codeCol,
            this.mailCol});
            this.sinhvienDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvienDataGrid.Location = new System.Drawing.Point(3, 24);
            this.sinhvienDataGrid.Name = "sinhvienDataGrid";
            this.sinhvienDataGrid.RowTemplate.Height = 24;
            this.sinhvienDataGrid.Size = new System.Drawing.Size(1150, 325);
            this.sinhvienDataGrid.TabIndex = 0;
            this.sinhvienDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sinhvienDataGrid_RowHeaderMouseClick);
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Full Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 197;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.Width = 120;
            // 
            // classCol
            // 
            this.classCol.HeaderText = "Class";
            this.classCol.Name = "classCol";
            this.classCol.Width = 150;
            // 
            // birthCol
            // 
            this.birthCol.HeaderText = "Birthday";
            this.birthCol.Name = "birthCol";
            // 
            // genderCol
            // 
            this.genderCol.HeaderText = "Gender";
            this.genderCol.Name = "genderCol";
            // 
            // phoneCol
            // 
            this.phoneCol.HeaderText = "Phone";
            this.phoneCol.Name = "phoneCol";
            this.phoneCol.Width = 120;
            // 
            // codeCol
            // 
            this.codeCol.HeaderText = "Code";
            this.codeCol.Name = "codeCol";
            this.codeCol.Width = 70;
            // 
            // mailCol
            // 
            this.mailCol.HeaderText = "Mail";
            this.mailCol.Name = "mailCol";
            this.mailCol.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Students Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox codeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView sinhvienDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailCol;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Label phoneErrLabel1;
        private System.Windows.Forms.Label mailErrLabel;
        private System.Windows.Forms.Label classErrLabel;
        private System.Windows.Forms.Label idErrLabel;
        private System.Windows.Forms.Label nameErrLabel;
    }
}

