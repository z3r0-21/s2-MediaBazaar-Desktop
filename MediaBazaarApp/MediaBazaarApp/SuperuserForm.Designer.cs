﻿
namespace MediaBazaarApp
{
    partial class SuperuserForm
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
            this.tabControlSuperuser = new System.Windows.Forms.TabControl();
            this.AddEmpTab = new System.Windows.Forms.TabPage();
            this.gbxAddEmployee = new System.Windows.Forms.GroupBox();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.cbEmpHourlyWages = new System.Windows.Forms.ComboBox();
            this.cbEmpPosition = new System.Windows.Forms.ComboBox();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmpAddressStreet = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCity = new System.Windows.Forms.TextBox();
            this.cbEmpGender = new System.Windows.Forms.ComboBox();
            this.lbEmpAddressCity = new System.Windows.Forms.Label();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCountry = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lbEmpAddressPostCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpAddressCountry = new System.Windows.Forms.Label();
            this.dtpEmpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxEmpAddressPostCode = new System.Windows.Forms.TextBox();
            this.btnAddEmpoyee = new System.Windows.Forms.Button();
            this.lbEmpEmployementType = new System.Windows.Forms.Label();
            this.lbEmpPosition = new System.Windows.Forms.Label();
            this.lbEmpDateOfBirth = new System.Windows.Forms.Label();
            this.lbEmpHourlyWages = new System.Windows.Forms.Label();
            this.tbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.tbxEmpLname = new System.Windows.Forms.TextBox();
            this.lbEmpLname = new System.Windows.Forms.Label();
            this.tbxEmpFname = new System.Windows.Forms.TextBox();
            this.lbEmpFname = new System.Windows.Forms.Label();
            this.ManageEmpTab = new System.Windows.Forms.TabPage();
            this.btnEmpManageAttendance = new System.Windows.Forms.Button();
            this.gbxSearchEmp = new System.Windows.Forms.GroupBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.tbxSearchEmp = new System.Windows.Forms.TextBox();
            this.gbxShowAllEmp = new System.Windows.Forms.GroupBox();
            this.cbSelectEmpType = new System.Windows.Forms.ComboBox();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnClearSelectedEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.lbxAllEmployees = new System.Windows.Forms.ListBox();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.tabControlSuperuser.SuspendLayout();
            this.AddEmpTab.SuspendLayout();
            this.gbxAddEmployee.SuspendLayout();
            this.ManageEmpTab.SuspendLayout();
            this.gbxSearchEmp.SuspendLayout();
            this.gbxShowAllEmp.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSuperuser
            // 
            this.tabControlSuperuser.Controls.Add(this.HomeTab);
            this.tabControlSuperuser.Controls.Add(this.AddEmpTab);
            this.tabControlSuperuser.Controls.Add(this.ManageEmpTab);
            this.tabControlSuperuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSuperuser.Location = new System.Drawing.Point(12, 12);
            this.tabControlSuperuser.Name = "tabControlSuperuser";
            this.tabControlSuperuser.SelectedIndex = 0;
            this.tabControlSuperuser.Size = new System.Drawing.Size(948, 644);
            this.tabControlSuperuser.TabIndex = 0;
            // 
            // AddEmpTab
            // 
            this.AddEmpTab.Controls.Add(this.gbxAddEmployee);
            this.AddEmpTab.Location = new System.Drawing.Point(4, 27);
            this.AddEmpTab.Name = "AddEmpTab";
            this.AddEmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmpTab.Size = new System.Drawing.Size(940, 613);
            this.AddEmpTab.TabIndex = 0;
            this.AddEmpTab.Text = "Add employees";
            this.AddEmpTab.UseVisualStyleBackColor = true;
            // 
            // gbxAddEmployee
            // 
            this.gbxAddEmployee.Controls.Add(this.cbEmpDepartment);
            this.gbxAddEmployee.Controls.Add(this.lbEmpDepartment);
            this.gbxAddEmployee.Controls.Add(this.cbEmpHourlyWages);
            this.gbxAddEmployee.Controls.Add(this.cbEmpPosition);
            this.gbxAddEmployee.Controls.Add(this.cbEmpEmploymentType);
            this.gbxAddEmployee.Controls.Add(this.label5);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressStreet);
            this.gbxAddEmployee.Controls.Add(this.label4);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressStreet);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressCity);
            this.gbxAddEmployee.Controls.Add(this.cbEmpGender);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressCity);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpEmail);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressCountry);
            this.gbxAddEmployee.Controls.Add(this.lbEmpEmail);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressPostCode);
            this.gbxAddEmployee.Controls.Add(this.label1);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressCountry);
            this.gbxAddEmployee.Controls.Add(this.dtpEmpDateOfBirth);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressPostCode);
            this.gbxAddEmployee.Controls.Add(this.btnAddEmpoyee);
            this.gbxAddEmployee.Controls.Add(this.lbEmpEmployementType);
            this.gbxAddEmployee.Controls.Add(this.lbEmpPosition);
            this.gbxAddEmployee.Controls.Add(this.lbEmpDateOfBirth);
            this.gbxAddEmployee.Controls.Add(this.lbEmpHourlyWages);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpPhone);
            this.gbxAddEmployee.Controls.Add(this.lbEmpPhone);
            this.gbxAddEmployee.Controls.Add(this.lbEmployeeAddress);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpLname);
            this.gbxAddEmployee.Controls.Add(this.lbEmpLname);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpFname);
            this.gbxAddEmployee.Controls.Add(this.lbEmpFname);
            this.gbxAddEmployee.Location = new System.Drawing.Point(135, 34);
            this.gbxAddEmployee.Name = "gbxAddEmployee";
            this.gbxAddEmployee.Size = new System.Drawing.Size(655, 540);
            this.gbxAddEmployee.TabIndex = 1;
            this.gbxAddEmployee.TabStop = false;
            this.gbxAddEmployee.Text = "Add/Hire employee";
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(143, 400);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(160, 26);
            this.cbEmpDepartment.TabIndex = 38;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Location = new System.Drawing.Point(26, 403);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(89, 18);
            this.lbEmpDepartment.TabIndex = 37;
            this.lbEmpDepartment.Text = "Department:";
            // 
            // cbEmpHourlyWages
            // 
            this.cbEmpHourlyWages.FormattingEnabled = true;
            this.cbEmpHourlyWages.Location = new System.Drawing.Point(142, 356);
            this.cbEmpHourlyWages.Name = "cbEmpHourlyWages";
            this.cbEmpHourlyWages.Size = new System.Drawing.Size(160, 26);
            this.cbEmpHourlyWages.TabIndex = 36;
            // 
            // cbEmpPosition
            // 
            this.cbEmpPosition.FormattingEnabled = true;
            this.cbEmpPosition.Location = new System.Drawing.Point(142, 318);
            this.cbEmpPosition.Name = "cbEmpPosition";
            this.cbEmpPosition.Size = new System.Drawing.Size(160, 26);
            this.cbEmpPosition.TabIndex = 35;
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "Administration",
            "Management",
            "Depot worker",
            "Shop employee"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(143, 279);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 26);
            this.cbEmpEmploymentType.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Job specifications:";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(382, 157);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(51, 18);
            this.lbEmpAddressStreet.TabIndex = 17;
            this.lbEmpAddressStreet.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Personal information:";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(458, 154);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressStreet.TabIndex = 5;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(458, 192);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressCity.TabIndex = 18;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other",
            "Not specified"});
            this.cbEmpGender.Location = new System.Drawing.Point(142, 192);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 26);
            this.cbEmpGender.TabIndex = 30;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Location = new System.Drawing.Point(397, 195);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(37, 18);
            this.lbEmpAddressCity.TabIndex = 19;
            this.lbEmpAddressCity.Text = "City:";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.Location = new System.Drawing.Point(458, 71);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpEmail.TabIndex = 29;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(458, 232);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressCountry.TabIndex = 20;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Location = new System.Drawing.Point(379, 74);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(49, 18);
            this.lbEmpEmail.TabIndex = 28;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(359, 271);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(79, 18);
            this.lbEmpAddressPostCode.TabIndex = 25;
            this.lbEmpAddressPostCode.Text = "PostCode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gender:";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(371, 235);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(64, 18);
            this.lbEmpAddressCountry.TabIndex = 21;
            this.lbEmpAddressCountry.Text = "Country:";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(142, 152);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(161, 24);
            this.dtpEmpDateOfBirth.TabIndex = 1;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(458, 268);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressPostCode.TabIndex = 24;
            // 
            // btnAddEmpoyee
            // 
            this.btnAddEmpoyee.Location = new System.Drawing.Point(236, 480);
            this.btnAddEmpoyee.Name = "btnAddEmpoyee";
            this.btnAddEmpoyee.Size = new System.Drawing.Size(192, 42);
            this.btnAddEmpoyee.TabIndex = 16;
            this.btnAddEmpoyee.Text = "Add employee";
            this.btnAddEmpoyee.UseVisualStyleBackColor = true;
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Location = new System.Drawing.Point(8, 282);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(113, 18);
            this.lbEmpEmployementType.TabIndex = 14;
            this.lbEmpEmployementType.Text = "Eployment type:";
            // 
            // lbEmpPosition
            // 
            this.lbEmpPosition.AutoSize = true;
            this.lbEmpPosition.Location = new System.Drawing.Point(53, 318);
            this.lbEmpPosition.Name = "lbEmpPosition";
            this.lbEmpPosition.Size = new System.Drawing.Size(66, 18);
            this.lbEmpPosition.TabIndex = 12;
            this.lbEmpPosition.Text = "Position:";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(26, 152);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(92, 18);
            this.lbEmpDateOfBirth.TabIndex = 10;
            this.lbEmpDateOfBirth.Text = "Date of birth:";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(18, 356);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(102, 18);
            this.lbEmpHourlyWages.TabIndex = 8;
            this.lbEmpHourlyWages.Text = "Hourly wages:";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.Location = new System.Drawing.Point(458, 109);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpPhone.TabIndex = 7;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Location = new System.Drawing.Point(379, 112);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(55, 18);
            this.lbEmpPhone.TabIndex = 6;
            this.lbEmpPhone.Text = "Phone:";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeAddress.Location = new System.Drawing.Point(432, 30);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(126, 18);
            this.lbEmployeeAddress.TabIndex = 4;
            this.lbEmployeeAddress.Text = "Contact details:";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.Location = new System.Drawing.Point(143, 115);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 24);
            this.tbxEmpLname.TabIndex = 3;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Location = new System.Drawing.Point(39, 115);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(81, 18);
            this.lbEmpLname.TabIndex = 2;
            this.lbEmpLname.Text = "Last name:";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.Location = new System.Drawing.Point(143, 68);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 24);
            this.tbxEmpFname.TabIndex = 1;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Location = new System.Drawing.Point(39, 71);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(82, 18);
            this.lbEmpFname.TabIndex = 0;
            this.lbEmpFname.Text = "First name:";
            // 
            // ManageEmpTab
            // 
            this.ManageEmpTab.Controls.Add(this.btnEmpManageAttendance);
            this.ManageEmpTab.Controls.Add(this.gbxSearchEmp);
            this.ManageEmpTab.Controls.Add(this.gbxShowAllEmp);
            this.ManageEmpTab.Controls.Add(this.btnClearSelectedEmp);
            this.ManageEmpTab.Controls.Add(this.btnEditEmp);
            this.ManageEmpTab.Controls.Add(this.btnRemoveEmp);
            this.ManageEmpTab.Controls.Add(this.lbxAllEmployees);
            this.ManageEmpTab.Location = new System.Drawing.Point(4, 27);
            this.ManageEmpTab.Name = "ManageEmpTab";
            this.ManageEmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManageEmpTab.Size = new System.Drawing.Size(940, 613);
            this.ManageEmpTab.TabIndex = 1;
            this.ManageEmpTab.Text = "Manage employees";
            this.ManageEmpTab.UseVisualStyleBackColor = true;
            // 
            // btnEmpManageAttendance
            // 
            this.btnEmpManageAttendance.Location = new System.Drawing.Point(689, 525);
            this.btnEmpManageAttendance.Name = "btnEmpManageAttendance";
            this.btnEmpManageAttendance.Size = new System.Drawing.Size(195, 49);
            this.btnEmpManageAttendance.TabIndex = 18;
            this.btnEmpManageAttendance.Text = "Manage attendance";
            this.btnEmpManageAttendance.UseVisualStyleBackColor = true;
            // 
            // gbxSearchEmp
            // 
            this.gbxSearchEmp.Controls.Add(this.btnSearchEmp);
            this.gbxSearchEmp.Controls.Add(this.tbxSearchEmp);
            this.gbxSearchEmp.Location = new System.Drawing.Point(478, 25);
            this.gbxSearchEmp.Name = "gbxSearchEmp";
            this.gbxSearchEmp.Size = new System.Drawing.Size(406, 90);
            this.gbxSearchEmp.TabIndex = 17;
            this.gbxSearchEmp.TabStop = false;
            this.gbxSearchEmp.Text = "Search for specific employee";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(226, 32);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(165, 29);
            this.btnSearchEmp.TabIndex = 6;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // tbxSearchEmp
            // 
            this.tbxSearchEmp.Location = new System.Drawing.Point(10, 35);
            this.tbxSearchEmp.Name = "tbxSearchEmp";
            this.tbxSearchEmp.Size = new System.Drawing.Size(186, 24);
            this.tbxSearchEmp.TabIndex = 7;
            this.tbxSearchEmp.Text = "Search...";
            // 
            // gbxShowAllEmp
            // 
            this.gbxShowAllEmp.Controls.Add(this.cbSelectEmpType);
            this.gbxShowAllEmp.Controls.Add(this.btnShowAllEmp);
            this.gbxShowAllEmp.Location = new System.Drawing.Point(39, 25);
            this.gbxShowAllEmp.Name = "gbxShowAllEmp";
            this.gbxShowAllEmp.Size = new System.Drawing.Size(341, 90);
            this.gbxShowAllEmp.TabIndex = 16;
            this.gbxShowAllEmp.TabStop = false;
            this.gbxShowAllEmp.Text = "Select type of employee to show ";
            // 
            // cbSelectEmpType
            // 
            this.cbSelectEmpType.FormattingEnabled = true;
            this.cbSelectEmpType.Items.AddRange(new object[] {
            "All",
            "Administration",
            "Management",
            "Depot workers",
            "Shop employees"});
            this.cbSelectEmpType.Location = new System.Drawing.Point(20, 35);
            this.cbSelectEmpType.Name = "cbSelectEmpType";
            this.cbSelectEmpType.Size = new System.Drawing.Size(121, 26);
            this.cbSelectEmpType.TabIndex = 8;
            this.cbSelectEmpType.Text = "Select type";
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(170, 35);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(165, 26);
            this.btnShowAllEmp.TabIndex = 5;
            this.btnShowAllEmp.Text = "Show";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            // 
            // btnClearSelectedEmp
            // 
            this.btnClearSelectedEmp.Location = new System.Drawing.Point(39, 525);
            this.btnClearSelectedEmp.Name = "btnClearSelectedEmp";
            this.btnClearSelectedEmp.Size = new System.Drawing.Size(195, 49);
            this.btnClearSelectedEmp.TabIndex = 15;
            this.btnClearSelectedEmp.Text = "Unmark selected";
            this.btnClearSelectedEmp.UseVisualStyleBackColor = true;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(261, 525);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(195, 49);
            this.btnEditEmp.TabIndex = 14;
            this.btnEditEmp.Text = "Edit employee";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(478, 525);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(195, 49);
            this.btnRemoveEmp.TabIndex = 13;
            this.btnRemoveEmp.Text = "Remove employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            // 
            // lbxAllEmployees
            // 
            this.lbxAllEmployees.FormattingEnabled = true;
            this.lbxAllEmployees.HorizontalScrollbar = true;
            this.lbxAllEmployees.ItemHeight = 18;
            this.lbxAllEmployees.Location = new System.Drawing.Point(39, 137);
            this.lbxAllEmployees.Name = "lbxAllEmployees";
            this.lbxAllEmployees.Size = new System.Drawing.Size(845, 364);
            this.lbxAllEmployees.TabIndex = 12;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Location = new System.Drawing.Point(4, 27);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Size = new System.Drawing.Size(940, 613);
            this.HomeTab.TabIndex = 2;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(102, 286);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(102, 331);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(125, 18);
            this.lbDateDayOfWeek.TabIndex = 11;
            this.lbDateDayOfWeek.Text = "Date/Day of week";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Location = new System.Drawing.Point(97, 153);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(129, 18);
            this.lbGreetingMsg.TabIndex = 10;
            this.lbGreetingMsg.Text = "Greeting message";
            // 
            // SuperuserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 668);
            this.Controls.Add(this.tabControlSuperuser);
            this.Name = "SuperuserForm";
            this.Text = "SuperuserForm";
            this.tabControlSuperuser.ResumeLayout(false);
            this.AddEmpTab.ResumeLayout(false);
            this.gbxAddEmployee.ResumeLayout(false);
            this.gbxAddEmployee.PerformLayout();
            this.ManageEmpTab.ResumeLayout(false);
            this.gbxSearchEmp.ResumeLayout(false);
            this.gbxSearchEmp.PerformLayout();
            this.gbxShowAllEmp.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSuperuser;
        private System.Windows.Forms.TabPage AddEmpTab;
        private System.Windows.Forms.TabPage ManageEmpTab;
        private System.Windows.Forms.GroupBox gbxAddEmployee;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.ComboBox cbEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpPosition;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmpAddressStreet;
        private System.Windows.Forms.TextBox tbxEmpAddressCity;
        private System.Windows.Forms.ComboBox cbEmpGender;
        private System.Windows.Forms.Label lbEmpAddressCity;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.TextBox tbxEmpAddressCountry;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label lbEmpAddressPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmpAddressCountry;
        private System.Windows.Forms.DateTimePicker dtpEmpDateOfBirth;
        private System.Windows.Forms.TextBox tbxEmpAddressPostCode;
        private System.Windows.Forms.Button btnAddEmpoyee;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpPosition;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.Button btnEmpManageAttendance;
        private System.Windows.Forms.GroupBox gbxSearchEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox tbxSearchEmp;
        private System.Windows.Forms.GroupBox gbxShowAllEmp;
        private System.Windows.Forms.ComboBox cbSelectEmpType;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnClearSelectedEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.ListBox lbxAllEmployees;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
    }
}