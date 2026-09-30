namespace ddlExplore
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
            this.txtdllFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.txtProperties = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMethod = new System.Windows.Forms.DataGridView();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvParemters = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPropertiesDecleringType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPropertiesIsStatic = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCanWrite = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCanRead = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAccessProperties = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPropertiesName = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDecleringType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblParemters = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIsStatic = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblReturnType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAccessModifiers = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMethodName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParemters)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dll File:";
            // 
            // txtdllFile
            // 
            this.txtdllFile.Location = new System.Drawing.Point(100, 16);
            this.txtdllFile.Name = "txtdllFile";
            this.txtdllFile.Size = new System.Drawing.Size(888, 24);
            this.txtdllFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Location = new System.Drawing.Point(1010, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 36);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProperties);
            this.groupBox1.Controls.Add(this.txtProperties);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvMethod);
            this.groupBox1.Controls.Add(this.txtMethod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvClass);
            this.groupBox1.Controls.Add(this.txtSearchClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.White;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(733, 66);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.RowHeadersWidth = 51;
            this.dgvProperties.RowTemplate.Height = 26;
            this.dgvProperties.Size = new System.Drawing.Size(344, 245);
            this.dgvProperties.TabIndex = 9;
            this.dgvProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperties_CellClick);
            // 
            // txtProperties
            // 
            this.txtProperties.Location = new System.Drawing.Point(811, 20);
            this.txtProperties.Name = "txtProperties";
            this.txtProperties.Size = new System.Drawing.Size(266, 24);
            this.txtProperties.TabIndex = 8;
            this.txtProperties.TextChanged += new System.EventHandler(this.txtProperties_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(729, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search : ";
            // 
            // dgvMethod
            // 
            this.dgvMethod.AllowUserToAddRows = false;
            this.dgvMethod.AllowUserToDeleteRows = false;
            this.dgvMethod.BackgroundColor = System.Drawing.Color.White;
            this.dgvMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMethod.Location = new System.Drawing.Point(379, 66);
            this.dgvMethod.Name = "dgvMethod";
            this.dgvMethod.ReadOnly = true;
            this.dgvMethod.RowHeadersWidth = 51;
            this.dgvMethod.RowTemplate.Height = 26;
            this.dgvMethod.Size = new System.Drawing.Size(344, 245);
            this.dgvMethod.TabIndex = 6;
            this.dgvMethod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMethod_CellClick);
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(457, 20);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(266, 24);
            this.txtMethod.TabIndex = 5;
            this.txtMethod.TextChanged += new System.EventHandler(this.txtMethod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(375, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search : ";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(10, 66);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 26;
            this.dgvClass.Size = new System.Drawing.Size(344, 245);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(88, 20);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(266, 24);
            this.txtSearchClass.TabIndex = 2;
            this.txtSearchClass.TextChanged += new System.EventHandler(this.txtSearchClass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvParemters);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 336);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dgvParemters
            // 
            this.dgvParemters.AllowUserToAddRows = false;
            this.dgvParemters.AllowUserToDeleteRows = false;
            this.dgvParemters.BackgroundColor = System.Drawing.Color.White;
            this.dgvParemters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParemters.Location = new System.Drawing.Point(715, 64);
            this.dgvParemters.Name = "dgvParemters";
            this.dgvParemters.ReadOnly = true;
            this.dgvParemters.RowHeadersWidth = 51;
            this.dgvParemters.RowTemplate.Height = 26;
            this.dgvParemters.Size = new System.Drawing.Size(365, 266);
            this.dgvParemters.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(762, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Paremeters";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPropertiesDecleringType);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblPropertiesIsStatic);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblCanWrite);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblCanRead);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblAccessProperties);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.lblPropertiesName);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Location = new System.Drawing.Point(383, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 274);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // lblPropertiesDecleringType
            // 
            this.lblPropertiesDecleringType.AutoSize = true;
            this.lblPropertiesDecleringType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPropertiesDecleringType.Location = new System.Drawing.Point(148, 225);
            this.lblPropertiesDecleringType.Name = "lblPropertiesDecleringType";
            this.lblPropertiesDecleringType.Size = new System.Drawing.Size(48, 21);
            this.lblPropertiesDecleringType.TabIndex = 11;
            this.lblPropertiesDecleringType.Text = "[???]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.Location = new System.Drawing.Point(14, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Declering Type:";
            // 
            // lblPropertiesIsStatic
            // 
            this.lblPropertiesIsStatic.AutoSize = true;
            this.lblPropertiesIsStatic.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPropertiesIsStatic.Location = new System.Drawing.Point(148, 185);
            this.lblPropertiesIsStatic.Name = "lblPropertiesIsStatic";
            this.lblPropertiesIsStatic.Size = new System.Drawing.Size(48, 21);
            this.lblPropertiesIsStatic.TabIndex = 9;
            this.lblPropertiesIsStatic.Text = "[???]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(14, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "Is Static:";
            // 
            // lblCanWrite
            // 
            this.lblCanWrite.AutoSize = true;
            this.lblCanWrite.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCanWrite.Location = new System.Drawing.Point(148, 149);
            this.lblCanWrite.Name = "lblCanWrite";
            this.lblCanWrite.Size = new System.Drawing.Size(48, 21);
            this.lblCanWrite.TabIndex = 7;
            this.lblCanWrite.Text = "[???]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label17.Location = new System.Drawing.Point(14, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 21);
            this.label17.TabIndex = 6;
            this.label17.Text = "Can Write:";
            // 
            // lblCanRead
            // 
            this.lblCanRead.AutoSize = true;
            this.lblCanRead.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCanRead.Location = new System.Drawing.Point(148, 106);
            this.lblCanRead.Name = "lblCanRead";
            this.lblCanRead.Size = new System.Drawing.Size(48, 21);
            this.lblCanRead.TabIndex = 5;
            this.lblCanRead.Text = "[???]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label19.Location = new System.Drawing.Point(14, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 21);
            this.label19.TabIndex = 4;
            this.label19.Text = "can Read:";
            // 
            // lblAccessProperties
            // 
            this.lblAccessProperties.AutoSize = true;
            this.lblAccessProperties.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblAccessProperties.Location = new System.Drawing.Point(148, 64);
            this.lblAccessProperties.Name = "lblAccessProperties";
            this.lblAccessProperties.Size = new System.Drawing.Size(48, 21);
            this.lblAccessProperties.TabIndex = 3;
            this.lblAccessProperties.Text = "[???]";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label21.Location = new System.Drawing.Point(14, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 21);
            this.label21.TabIndex = 2;
            this.label21.Text = "Access Modifiers:";
            // 
            // lblPropertiesName
            // 
            this.lblPropertiesName.AutoSize = true;
            this.lblPropertiesName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPropertiesName.Location = new System.Drawing.Point(148, 24);
            this.lblPropertiesName.Name = "lblPropertiesName";
            this.lblPropertiesName.Size = new System.Drawing.Size(48, 21);
            this.lblPropertiesName.TabIndex = 1;
            this.lblPropertiesName.Text = "[???]";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label23.Location = new System.Drawing.Point(14, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "Properties Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(389, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(174, 24);
            this.label24.TabIndex = 12;
            this.label24.Text = "Properties  Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDecleringType);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblParemters);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblIsStatic);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblReturnType);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblAccessModifiers);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblMethodName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(5, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 274);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // lblDecleringType
            // 
            this.lblDecleringType.AutoSize = true;
            this.lblDecleringType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDecleringType.Location = new System.Drawing.Point(148, 225);
            this.lblDecleringType.Name = "lblDecleringType";
            this.lblDecleringType.Size = new System.Drawing.Size(48, 21);
            this.lblDecleringType.TabIndex = 11;
            this.lblDecleringType.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(14, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Declering Type:";
            // 
            // lblParemters
            // 
            this.lblParemters.AutoSize = true;
            this.lblParemters.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblParemters.Location = new System.Drawing.Point(148, 185);
            this.lblParemters.Name = "lblParemters";
            this.lblParemters.Size = new System.Drawing.Size(48, 21);
            this.lblParemters.TabIndex = 9;
            this.lblParemters.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(14, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Paremters:";
            // 
            // lblIsStatic
            // 
            this.lblIsStatic.AutoSize = true;
            this.lblIsStatic.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblIsStatic.Location = new System.Drawing.Point(148, 149);
            this.lblIsStatic.Name = "lblIsStatic";
            this.lblIsStatic.Size = new System.Drawing.Size(48, 21);
            this.lblIsStatic.TabIndex = 7;
            this.lblIsStatic.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(14, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Is Static:";
            // 
            // lblReturnType
            // 
            this.lblReturnType.AutoSize = true;
            this.lblReturnType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblReturnType.Location = new System.Drawing.Point(148, 106);
            this.lblReturnType.Name = "lblReturnType";
            this.lblReturnType.Size = new System.Drawing.Size(48, 21);
            this.lblReturnType.TabIndex = 5;
            this.lblReturnType.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(14, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Return Type:";
            // 
            // lblAccessModifiers
            // 
            this.lblAccessModifiers.AutoSize = true;
            this.lblAccessModifiers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblAccessModifiers.Location = new System.Drawing.Point(148, 64);
            this.lblAccessModifiers.Name = "lblAccessModifiers";
            this.lblAccessModifiers.Size = new System.Drawing.Size(48, 21);
            this.lblAccessModifiers.TabIndex = 3;
            this.lblAccessModifiers.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(14, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Access Modifiers:";
            // 
            // lblMethodName
            // 
            this.lblMethodName.AutoSize = true;
            this.lblMethodName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMethodName.Location = new System.Drawing.Point(148, 24);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(48, 21);
            this.lblMethodName.TabIndex = 1;
            this.lblMethodName.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Method Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Method Details";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 765);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtdllFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParemters)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdllFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.TextBox txtProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMethod;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblParemters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIsStatic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReturnType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAccessModifiers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPropertiesDecleringType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPropertiesIsStatic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCanWrite;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCanRead;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblAccessProperties;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPropertiesName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblDecleringType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvParemters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

