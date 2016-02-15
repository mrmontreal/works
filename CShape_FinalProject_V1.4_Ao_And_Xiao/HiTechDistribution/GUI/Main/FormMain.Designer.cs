namespace HiTechDistribution.GUI.Main
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.maintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManageProducttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProductInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintainToolStripMenuItem
            // 
            this.maintainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.maintainToolStripMenuItem.Name = "maintainToolStripMenuItem";
            this.maintainToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.maintainToolStripMenuItem.Text = "Manage Employee";
            //this.maintainToolStripMenuItem.Click += new System.EventHandler(this.maintainToolStripMenuItem_Click);
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.Enabled = false;
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Enabled = false;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageProducttoolStripMenuItem,
            this.clientToolStripMenuItem,
            this.manageOrderToolStripMenuItem,
            this.maintainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // ManageProducttoolStripMenuItem
            // 
            this.ManageProducttoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductInformationToolStripMenuItem1,
            this.modifyProductInventoryToolStripMenuItem});
            this.ManageProducttoolStripMenuItem.Name = "ManageProducttoolStripMenuItem";
            this.ManageProducttoolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.ManageProducttoolStripMenuItem.Text = "Manage Product";
            // 
            // manageProductInformationToolStripMenuItem1
            // 
            this.manageProductInformationToolStripMenuItem1.Enabled = false;
            this.manageProductInformationToolStripMenuItem1.Name = "manageProductInformationToolStripMenuItem1";
            this.manageProductInformationToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.manageProductInformationToolStripMenuItem1.Text = "Manage Product Information";
            this.manageProductInformationToolStripMenuItem1.Click += new System.EventHandler(this.manageProductInformationToolStripMenuItem1_Click);
            // 
            // modifyProductInventoryToolStripMenuItem
            // 
            this.modifyProductInventoryToolStripMenuItem.Enabled = false;
            this.modifyProductInventoryToolStripMenuItem.Name = "modifyProductInventoryToolStripMenuItem";
            this.modifyProductInventoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.modifyProductInventoryToolStripMenuItem.Text = "Modify Product Inventory";
            this.modifyProductInventoryToolStripMenuItem.Click += new System.EventHandler(this.modifyProductInventoryToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientInformationToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.clientToolStripMenuItem.Text = "Manage Client";
            // 
            // manageClientInformationToolStripMenuItem
            // 
            this.manageClientInformationToolStripMenuItem.Enabled = false;
            this.manageClientInformationToolStripMenuItem.Name = "manageClientInformationToolStripMenuItem";
            this.manageClientInformationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.manageClientInformationToolStripMenuItem.Text = "Manage Client Information";
            this.manageClientInformationToolStripMenuItem.Click += new System.EventHandler(this.manageClientInformationToolStripMenuItem_Click);
            // 
            // manageOrderToolStripMenuItem
            // 
            this.manageOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageOrderInformationToolStripMenuItem,
            this.addNewOrderToolStripMenuItem});
            this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.manageOrderToolStripMenuItem.Text = "Manage Order";
            // 
            // manageOrderInformationToolStripMenuItem
            // 
            this.manageOrderInformationToolStripMenuItem.Enabled = false;
            this.manageOrderInformationToolStripMenuItem.Name = "manageOrderInformationToolStripMenuItem";
            this.manageOrderInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.manageOrderInformationToolStripMenuItem.Text = "Manage Order Information";
            this.manageOrderInformationToolStripMenuItem.Click += new System.EventHandler(this.manageOrderInformationToolStripMenuItem_Click);
            // 
            // addNewOrderToolStripMenuItem
            // 
            this.addNewOrderToolStripMenuItem.Enabled = false;
            this.addNewOrderToolStripMenuItem.Name = "addNewOrderToolStripMenuItem";
            this.addNewOrderToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addNewOrderToolStripMenuItem.Text = "Add New Order";
            this.addNewOrderToolStripMenuItem.Click += new System.EventHandler(this.addNewOrderToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(949, 681);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Tech Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageProducttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyProductInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrderToolStripMenuItem;

    }
}