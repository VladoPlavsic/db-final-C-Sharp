namespace Shop
{
    partial class Guest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.dropOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.shopTab = new System.Windows.Forms.TabPage();
            this.logOutButton = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.paintCB = new System.Windows.Forms.ComboBox();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.woodCB = new System.Windows.Forms.ComboBox();
            this.adressCB = new System.Windows.Forms.ComboBox();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.shopTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ordersTab);
            this.tabControl1.Controls.Add(this.shopTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.logOutButton);
            this.ordersTab.Controls.Add(this.dropOrderButton);
            this.ordersTab.Controls.Add(this.label1);
            this.ordersTab.Controls.Add(this.orderIDTextBox);
            this.ordersTab.Controls.Add(this.ordersGrid);
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(1187, 459);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // dropOrderButton
            // 
            this.dropOrderButton.Location = new System.Drawing.Point(1011, 101);
            this.dropOrderButton.Name = "dropOrderButton";
            this.dropOrderButton.Size = new System.Drawing.Size(105, 95);
            this.dropOrderButton.TabIndex = 3;
            this.dropOrderButton.Text = "Drop Order";
            this.dropOrderButton.UseVisualStyleBackColor = true;
            this.dropOrderButton.Click += new System.EventHandler(this.dropOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1038, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OrderID";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(1011, 52);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderIDTextBox.TabIndex = 1;
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(6, 6);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new System.Drawing.Size(988, 426);
            this.ordersGrid.TabIndex = 0;
            // 
            // shopTab
            // 
            this.shopTab.Controls.Add(this.makeOrderButton);
            this.shopTab.Controls.Add(this.adressCB);
            this.shopTab.Controls.Add(this.woodCB);
            this.shopTab.Controls.Add(this.colorCB);
            this.shopTab.Controls.Add(this.paintCB);
            this.shopTab.Controls.Add(this.categoryCB);
            this.shopTab.Location = new System.Drawing.Point(4, 22);
            this.shopTab.Name = "shopTab";
            this.shopTab.Padding = new System.Windows.Forms.Padding(3);
            this.shopTab.Size = new System.Drawing.Size(1187, 459);
            this.shopTab.TabIndex = 1;
            this.shopTab.Text = "Shop";
            this.shopTab.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1059, 376);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(79, 28);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(30, 67);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(121, 21);
            this.categoryCB.TabIndex = 0;
            this.categoryCB.Text = "Category";
            // 
            // paintCB
            // 
            this.paintCB.FormattingEnabled = true;
            this.paintCB.Location = new System.Drawing.Point(205, 67);
            this.paintCB.Name = "paintCB";
            this.paintCB.Size = new System.Drawing.Size(121, 21);
            this.paintCB.TabIndex = 1;
            this.paintCB.Text = "Paint";
            // 
            // colorCB
            // 
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Location = new System.Drawing.Point(369, 67);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(121, 21);
            this.colorCB.TabIndex = 2;
            this.colorCB.Text = "Color";
            // 
            // woodCB
            // 
            this.woodCB.FormattingEnabled = true;
            this.woodCB.Location = new System.Drawing.Point(538, 67);
            this.woodCB.Name = "woodCB";
            this.woodCB.Size = new System.Drawing.Size(121, 21);
            this.woodCB.TabIndex = 3;
            this.woodCB.Text = "Wood";
            // 
            // adressCB
            // 
            this.adressCB.FormattingEnabled = true;
            this.adressCB.Location = new System.Drawing.Point(697, 67);
            this.adressCB.Name = "adressCB";
            this.adressCB.Size = new System.Drawing.Size(121, 21);
            this.adressCB.TabIndex = 4;
            this.adressCB.Text = "Adress";
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(953, 67);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(75, 23);
            this.makeOrderButton.TabIndex = 5;
            this.makeOrderButton.Text = "Order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "Guest";
            this.Text = "Guest";
            this.tabControl1.ResumeLayout(false);
            this.ordersTab.ResumeLayout(false);
            this.ordersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.shopTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.TabPage shopTab;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Button dropOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.ComboBox paintCB;
        private System.Windows.Forms.ComboBox adressCB;
        private System.Windows.Forms.ComboBox woodCB;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.Button makeOrderButton;
    }
}