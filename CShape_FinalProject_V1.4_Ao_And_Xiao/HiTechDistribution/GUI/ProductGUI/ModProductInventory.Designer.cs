namespace HiTechDistribution.GUI.ProductGUI
{
    partial class ModProductInventory
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelInfor = new System.Windows.Forms.Label();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQoh = new System.Windows.Forms.TextBox();
            this.radioButtonCheckout = new System.Windows.Forms.RadioButton();
            this.radioButtonCheckin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(305, 326);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInfor);
            this.groupBox2.Controls.Add(this.textBoxCheck);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxQoh);
            this.groupBox2.Controls.Add(this.radioButtonCheckout);
            this.groupBox2.Controls.Add(this.radioButtonCheckin);
            this.groupBox2.Location = new System.Drawing.Point(18, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 154);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Inventory Information";
            // 
            // labelInfor
            // 
            this.labelInfor.AutoSize = true;
            this.labelInfor.Location = new System.Drawing.Point(44, 73);
            this.labelInfor.Name = "labelInfor";
            this.labelInfor.Size = new System.Drawing.Size(65, 12);
            this.labelInfor.TabIndex = 18;
            this.labelInfor.Text = "Checkin : ";
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(169, 70);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(182, 21);
            this.textBoxCheck.TabIndex = 19;
            this.textBoxCheck.Tag = "Check quantity box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantity On Hand : ";
            // 
            // textBoxQoh
            // 
            this.textBoxQoh.Location = new System.Drawing.Point(169, 107);
            this.textBoxQoh.Name = "textBoxQoh";
            this.textBoxQoh.ReadOnly = true;
            this.textBoxQoh.Size = new System.Drawing.Size(182, 21);
            this.textBoxQoh.TabIndex = 17;
            // 
            // radioButtonCheckout
            // 
            this.radioButtonCheckout.AutoSize = true;
            this.radioButtonCheckout.Location = new System.Drawing.Point(235, 33);
            this.radioButtonCheckout.Name = "radioButtonCheckout";
            this.radioButtonCheckout.Size = new System.Drawing.Size(71, 16);
            this.radioButtonCheckout.TabIndex = 16;
            this.radioButtonCheckout.Text = "Checkout";
            this.radioButtonCheckout.UseVisualStyleBackColor = true;
            this.radioButtonCheckout.CheckedChanged += new System.EventHandler(this.radioButtonCheckout_CheckedChanged);
            // 
            // radioButtonCheckin
            // 
            this.radioButtonCheckin.AutoSize = true;
            this.radioButtonCheckin.Checked = true;
            this.radioButtonCheckin.Location = new System.Drawing.Point(38, 33);
            this.radioButtonCheckin.Name = "radioButtonCheckin";
            this.radioButtonCheckin.Size = new System.Drawing.Size(65, 16);
            this.radioButtonCheckin.TabIndex = 15;
            this.radioButtonCheckin.TabStop = true;
            this.radioButtonCheckin.Text = "Checkin";
            this.radioButtonCheckin.UseVisualStyleBackColor = true;
            this.radioButtonCheckin.CheckedChanged += new System.EventHandler(this.radioButtonCheckin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxName);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 123);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Product Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Type :";
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(154, 70);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(198, 20);
            this.comboBoxName.TabIndex = 13;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Book",
            "Software"});
            this.comboBoxType.Location = new System.Drawing.Point(154, 33);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(198, 20);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(187, 326);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 18;
            this.buttonConfirm.Text = "Comfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 366);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "ModProductInventory";
            this.Text = "Product Checkin/Checkout form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelInfor;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQoh;
        private System.Windows.Forms.RadioButton radioButtonCheckout;
        private System.Windows.Forms.RadioButton radioButtonCheckin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonConfirm;
    }
}