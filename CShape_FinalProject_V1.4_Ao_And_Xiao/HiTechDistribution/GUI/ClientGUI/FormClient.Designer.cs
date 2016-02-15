namespace HiTechDistribution.GUI.ClientGUI
{
    partial class FormClient
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            this.columnHeaderFax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeaderClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreaditLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelc = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCreaditLimit = new System.Windows.Forms.TextBox();
            this.labelCreaditLimit = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.labelFax = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelClientType = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            groupBox1.Location = new System.Drawing.Point(47, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(905, 225);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client\'s Information Managment";
            // 
            // groupBox2
            // 
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            groupBox2.Location = new System.Drawing.Point(47, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(905, 91);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Client\'s Information";
            // 
            // columnHeaderFax
            // 
            this.columnHeaderFax.Text = "Fax";
            this.columnHeaderFax.Width = 96;
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderClientId,
            this.columnHeaderName,
            this.columnHeaderClientType,
            this.columnHeaderCreaditLimit,
            this.columnHeaderStreet,
            this.columnHeaderCity,
            this.columnHeaderProvince,
            this.columnHeaderPostalCode,
            this.columnHeaderPhoneNumber,
            this.columnHeaderFax,
            this.columnHeaderEmail});
            this.listViewClient.FullRowSelect = true;
            this.listViewClient.GridLines = true;
            this.listViewClient.Location = new System.Drawing.Point(47, 394);
            this.listViewClient.MultiSelect = false;
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(1119, 306);
            this.listViewClient.TabIndex = 61;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            // 
            // columnHeaderClientId
            // 
            this.columnHeaderClientId.Text = "ClientId";
            this.columnHeaderClientId.Width = 73;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Client\'s Name";
            this.columnHeaderName.Width = 130;
            // 
            // columnHeaderClientType
            // 
            this.columnHeaderClientType.Text = "ClientType";
            this.columnHeaderClientType.Width = 93;
            // 
            // columnHeaderCreaditLimit
            // 
            this.columnHeaderCreaditLimit.Text = "CreaditLimit";
            this.columnHeaderCreaditLimit.Width = 72;
            // 
            // columnHeaderStreet
            // 
            this.columnHeaderStreet.Text = "Street";
            this.columnHeaderStreet.Width = 189;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            this.columnHeaderCity.Width = 76;
            // 
            // columnHeaderProvince
            // 
            this.columnHeaderProvince.Text = "Province";
            this.columnHeaderProvince.Width = 76;
            // 
            // columnHeaderPostalCode
            // 
            this.columnHeaderPostalCode.Text = "PostalCode";
            this.columnHeaderPostalCode.Width = 77;
            // 
            // columnHeaderPhoneNumber
            // 
            this.columnHeaderPhoneNumber.Text = "PhoneNumber";
            this.columnHeaderPhoneNumber.Width = 107;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 126;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1091, 260);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 69);
            this.buttonExit.TabIndex = 60;
            this.buttonExit.Text = "&EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Location = new System.Drawing.Point(129, 100);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(20, 13);
            this.labelc.TabIndex = 58;
            this.labelc.Text = "C_";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1091, 167);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 69);
            this.buttonReset.TabIndex = 57;
            this.buttonReset.Text = "&RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(996, 260);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 69);
            this.buttonList.TabIndex = 56;
            this.buttonList.Text = "&LIST";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(838, 313);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 55;
            this.buttonSearch.Text = "&SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(996, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 69);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "&DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "$";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1091, 69);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 69);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "&UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(996, 69);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 69);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "&SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(415, 191);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.textBoxPhoneNumber.TabIndex = 50;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(328, 195);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 49;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(824, 143);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(74, 20);
            this.textBoxPostalCode.TabIndex = 48;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(733, 147);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 47;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(451, 143);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(91, 20);
            this.textBoxCity.TabIndex = 46;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(399, 147);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 45;
            this.labelCity.Text = "City:";
            // 
            // textBoxCreaditLimit
            // 
            this.textBoxCreaditLimit.Location = new System.Drawing.Point(824, 96);
            this.textBoxCreaditLimit.Name = "textBoxCreaditLimit";
            this.textBoxCreaditLimit.Size = new System.Drawing.Size(74, 20);
            this.textBoxCreaditLimit.TabIndex = 44;
            // 
            // labelCreaditLimit
            // 
            this.labelCreaditLimit.AutoSize = true;
            this.labelCreaditLimit.Location = new System.Drawing.Point(733, 99);
            this.labelCreaditLimit.Name = "labelCreaditLimit";
            this.labelCreaditLimit.Size = new System.Drawing.Size(67, 13);
            this.labelCreaditLimit.TabIndex = 43;
            this.labelCreaditLimit.Text = "Creadit Limit:";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(335, 96);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(165, 20);
            this.textBoxClientName.TabIndex = 42;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(249, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 41;
            this.labelName.Text = "Client\'s Name:";
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(133, 191);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(157, 20);
            this.textBoxFax.TabIndex = 40;
            // 
            // labelFax
            // 
            this.labelFax.AutoSize = true;
            this.labelFax.Location = new System.Drawing.Point(90, 195);
            this.labelFax.Name = "labelFax";
            this.labelFax.Size = new System.Drawing.Size(27, 13);
            this.labelFax.TabIndex = 39;
            this.labelFax.Text = "Fax:";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(635, 143);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(83, 20);
            this.textBoxProvince.TabIndex = 38;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(567, 147);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 37;
            this.labelProvince.Text = "Province:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(133, 143);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(231, 20);
            this.textBoxStreet.TabIndex = 36;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(79, 146);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(38, 13);
            this.labelStreet.TabIndex = 35;
            this.labelStreet.Text = "Street:";
            // 
            // labelClientType
            // 
            this.labelClientType.AutoSize = true;
            this.labelClientType.Location = new System.Drawing.Point(512, 100);
            this.labelClientType.Name = "labelClientType";
            this.labelClientType.Size = new System.Drawing.Size(63, 13);
            this.labelClientType.TabIndex = 34;
            this.labelClientType.Text = "Client Type:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(161, 96);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(76, 20);
            this.textBoxClientId.TabIndex = 33;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(69, 100);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(48, 13);
            this.labelClientId.TabIndex = 32;
            this.labelClientId.Text = "Client Id:";
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "University",
            "College"});
            this.comboBoxClientType.Location = new System.Drawing.Point(587, 96);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientType.TabIndex = 63;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(589, 195);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 67;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(648, 191);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.textBoxEmail.TabIndex = 68;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(131, 314);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(233, 20);
            this.textBoxSearch.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Client Type: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Search: ";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "University",
            "College"});
            this.comboBoxSearch.Location = new System.Drawing.Point(679, 314);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearch.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "(Search By Id/Name/Phone/Email)";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 724);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.comboBoxClientType);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCreaditLimit);
            this.Controls.Add(this.labelCreaditLimit);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.labelFax);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelClientType);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(groupBox1);
            this.Controls.Add(groupBox2);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderFax;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeaderClientId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderClientType;
        private System.Windows.Forms.ColumnHeader columnHeaderCreaditLimit;
        private System.Windows.Forms.ColumnHeader columnHeaderStreet;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderProvince;
        private System.Windows.Forms.ColumnHeader columnHeaderPostalCode;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCreaditLimit;
        private System.Windows.Forms.Label labelCreaditLimit;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.Label labelFax;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelClientType;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Label label4;
    }
}