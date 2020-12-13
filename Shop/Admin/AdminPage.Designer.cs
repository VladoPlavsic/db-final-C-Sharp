namespace Shop
{
    partial class AdminPage
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
            this.categoryTab = new System.Windows.Forms.TabPage();
            this.removeCategoryButton = new System.Windows.Forms.Button();
            this.removeCategoryTB = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryTB = new System.Windows.Forms.TextBox();
            this.categoryGrid = new System.Windows.Forms.DataGridView();
            this.colorsTab = new System.Windows.Forms.TabPage();
            this.removeColorButton = new System.Windows.Forms.Button();
            this.addColorButton = new System.Windows.Forms.Button();
            this.colorGrid = new System.Windows.Forms.DataGridView();
            this.paintTab = new System.Windows.Forms.TabPage();
            this.removePaintButton = new System.Windows.Forms.Button();
            this.addPaintButton = new System.Windows.Forms.Button();
            this.paintGrid = new System.Windows.Forms.DataGridView();
            this.woodTab = new System.Windows.Forms.TabPage();
            this.removeWoodButton = new System.Windows.Forms.Button();
            this.addWoodButton = new System.Windows.Forms.Button();
            this.woodGrid = new System.Windows.Forms.DataGridView();
            this.courierTab = new System.Windows.Forms.TabPage();
            this.removeCourierButton = new System.Windows.Forms.Button();
            this.addCourierButton = new System.Windows.Forms.Button();
            this.couriersGrid = new System.Windows.Forms.DataGridView();
            this.addressTabl = new System.Windows.Forms.TabPage();
            this.removeDeliveryButton = new System.Windows.Forms.Button();
            this.addDeliveryButton = new System.Windows.Forms.Button();
            this.addressesGrid = new System.Windows.Forms.DataGridView();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.addColorTB = new System.Windows.Forms.TextBox();
            this.removeColorTB = new System.Windows.Forms.TextBox();
            this.addPaintTB = new System.Windows.Forms.TextBox();
            this.removePaintTB = new System.Windows.Forms.TextBox();
            this.addWoodTB = new System.Windows.Forms.TextBox();
            this.removeWoodTB = new System.Windows.Forms.TextBox();
            this.addCourierTB = new System.Windows.Forms.TextBox();
            this.removeCourierTB = new System.Windows.Forms.TextBox();
            this.addDeliveryTB = new System.Windows.Forms.TextBox();
            this.removeDeliveryTB = new System.Windows.Forms.TextBox();
            this.courierCB = new System.Windows.Forms.ComboBox();
            this.removeClientTB = new System.Windows.Forms.TextBox();
            this.removeClientButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.categoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).BeginInit();
            this.colorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorGrid)).BeginInit();
            this.paintTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintGrid)).BeginInit();
            this.woodTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woodGrid)).BeginInit();
            this.courierTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couriersGrid)).BeginInit();
            this.addressTabl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGrid)).BeginInit();
            this.clientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.categoryTab);
            this.tabControl1.Controls.Add(this.colorsTab);
            this.tabControl1.Controls.Add(this.paintTab);
            this.tabControl1.Controls.Add(this.woodTab);
            this.tabControl1.Controls.Add(this.courierTab);
            this.tabControl1.Controls.Add(this.addressTabl);
            this.tabControl1.Controls.Add(this.clientTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // categoryTab
            // 
            this.categoryTab.Controls.Add(this.removeCategoryButton);
            this.categoryTab.Controls.Add(this.removeCategoryTB);
            this.categoryTab.Controls.Add(this.addCategoryButton);
            this.categoryTab.Controls.Add(this.addCategoryTB);
            this.categoryTab.Controls.Add(this.categoryGrid);
            this.categoryTab.Location = new System.Drawing.Point(4, 22);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Size = new System.Drawing.Size(768, 366);
            this.categoryTab.TabIndex = 3;
            this.categoryTab.Text = "Categories";
            this.categoryTab.UseVisualStyleBackColor = true;
            // 
            // removeCategoryButton
            // 
            this.removeCategoryButton.Location = new System.Drawing.Point(270, 256);
            this.removeCategoryButton.Name = "removeCategoryButton";
            this.removeCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.removeCategoryButton.TabIndex = 4;
            this.removeCategoryButton.Text = "Remove";
            this.removeCategoryButton.UseVisualStyleBackColor = true;
            this.removeCategoryButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeCategoryTB
            // 
            this.removeCategoryTB.Location = new System.Drawing.Point(258, 208);
            this.removeCategoryTB.Name = "removeCategoryTB";
            this.removeCategoryTB.Size = new System.Drawing.Size(100, 20);
            this.removeCategoryTB.TabIndex = 3;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(270, 105);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryTB
            // 
            this.addCategoryTB.Location = new System.Drawing.Point(258, 62);
            this.addCategoryTB.Name = "addCategoryTB";
            this.addCategoryTB.Size = new System.Drawing.Size(100, 20);
            this.addCategoryTB.TabIndex = 1;
            // 
            // categoryGrid
            // 
            this.categoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGrid.Location = new System.Drawing.Point(17, 18);
            this.categoryGrid.Name = "categoryGrid";
            this.categoryGrid.Size = new System.Drawing.Size(216, 334);
            this.categoryGrid.TabIndex = 0;
            // 
            // colorsTab
            // 
            this.colorsTab.Controls.Add(this.removeColorTB);
            this.colorsTab.Controls.Add(this.addColorTB);
            this.colorsTab.Controls.Add(this.removeColorButton);
            this.colorsTab.Controls.Add(this.addColorButton);
            this.colorsTab.Controls.Add(this.colorGrid);
            this.colorsTab.Location = new System.Drawing.Point(4, 22);
            this.colorsTab.Name = "colorsTab";
            this.colorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorsTab.Size = new System.Drawing.Size(768, 366);
            this.colorsTab.TabIndex = 0;
            this.colorsTab.Text = "Colors";
            this.colorsTab.UseVisualStyleBackColor = true;
            // 
            // removeColorButton
            // 
            this.removeColorButton.Location = new System.Drawing.Point(319, 218);
            this.removeColorButton.Name = "removeColorButton";
            this.removeColorButton.Size = new System.Drawing.Size(75, 23);
            this.removeColorButton.TabIndex = 2;
            this.removeColorButton.Text = "Remove";
            this.removeColorButton.UseVisualStyleBackColor = true;
            this.removeColorButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addColorButton
            // 
            this.addColorButton.Location = new System.Drawing.Point(319, 80);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.Size = new System.Drawing.Size(75, 23);
            this.addColorButton.TabIndex = 1;
            this.addColorButton.Text = "Add";
            this.addColorButton.UseVisualStyleBackColor = true;
            this.addColorButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // colorGrid
            // 
            this.colorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorGrid.Location = new System.Drawing.Point(22, 23);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Size = new System.Drawing.Size(240, 315);
            this.colorGrid.TabIndex = 0;
            // 
            // paintTab
            // 
            this.paintTab.Controls.Add(this.removePaintTB);
            this.paintTab.Controls.Add(this.addPaintTB);
            this.paintTab.Controls.Add(this.removePaintButton);
            this.paintTab.Controls.Add(this.addPaintButton);
            this.paintTab.Controls.Add(this.paintGrid);
            this.paintTab.Location = new System.Drawing.Point(4, 22);
            this.paintTab.Name = "paintTab";
            this.paintTab.Padding = new System.Windows.Forms.Padding(3);
            this.paintTab.Size = new System.Drawing.Size(768, 366);
            this.paintTab.TabIndex = 1;
            this.paintTab.Text = "Paints";
            this.paintTab.UseVisualStyleBackColor = true;
            // 
            // removePaintButton
            // 
            this.removePaintButton.Location = new System.Drawing.Point(313, 201);
            this.removePaintButton.Name = "removePaintButton";
            this.removePaintButton.Size = new System.Drawing.Size(75, 23);
            this.removePaintButton.TabIndex = 2;
            this.removePaintButton.Text = "Remove";
            this.removePaintButton.UseVisualStyleBackColor = true;
            this.removePaintButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addPaintButton
            // 
            this.addPaintButton.Location = new System.Drawing.Point(313, 66);
            this.addPaintButton.Name = "addPaintButton";
            this.addPaintButton.Size = new System.Drawing.Size(75, 23);
            this.addPaintButton.TabIndex = 1;
            this.addPaintButton.Text = "Add";
            this.addPaintButton.UseVisualStyleBackColor = true;
            this.addPaintButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // paintGrid
            // 
            this.paintGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paintGrid.Location = new System.Drawing.Point(22, 16);
            this.paintGrid.Name = "paintGrid";
            this.paintGrid.Size = new System.Drawing.Size(240, 331);
            this.paintGrid.TabIndex = 0;
            // 
            // woodTab
            // 
            this.woodTab.Controls.Add(this.removeWoodTB);
            this.woodTab.Controls.Add(this.addWoodTB);
            this.woodTab.Controls.Add(this.removeWoodButton);
            this.woodTab.Controls.Add(this.addWoodButton);
            this.woodTab.Controls.Add(this.woodGrid);
            this.woodTab.Location = new System.Drawing.Point(4, 22);
            this.woodTab.Name = "woodTab";
            this.woodTab.Size = new System.Drawing.Size(768, 366);
            this.woodTab.TabIndex = 2;
            this.woodTab.Text = "Woods";
            this.woodTab.UseVisualStyleBackColor = true;
            // 
            // removeWoodButton
            // 
            this.removeWoodButton.Location = new System.Drawing.Point(306, 201);
            this.removeWoodButton.Name = "removeWoodButton";
            this.removeWoodButton.Size = new System.Drawing.Size(75, 23);
            this.removeWoodButton.TabIndex = 2;
            this.removeWoodButton.Text = "Remove";
            this.removeWoodButton.UseVisualStyleBackColor = true;
            this.removeWoodButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addWoodButton
            // 
            this.addWoodButton.Location = new System.Drawing.Point(306, 60);
            this.addWoodButton.Name = "addWoodButton";
            this.addWoodButton.Size = new System.Drawing.Size(75, 23);
            this.addWoodButton.TabIndex = 1;
            this.addWoodButton.Text = "Add";
            this.addWoodButton.UseVisualStyleBackColor = true;
            this.addWoodButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // woodGrid
            // 
            this.woodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.woodGrid.Location = new System.Drawing.Point(15, 14);
            this.woodGrid.Name = "woodGrid";
            this.woodGrid.Size = new System.Drawing.Size(254, 332);
            this.woodGrid.TabIndex = 0;
            // 
            // courierTab
            // 
            this.courierTab.Controls.Add(this.courierCB);
            this.courierTab.Controls.Add(this.removeCourierTB);
            this.courierTab.Controls.Add(this.addCourierTB);
            this.courierTab.Controls.Add(this.removeCourierButton);
            this.courierTab.Controls.Add(this.addCourierButton);
            this.courierTab.Controls.Add(this.couriersGrid);
            this.courierTab.Location = new System.Drawing.Point(4, 22);
            this.courierTab.Name = "courierTab";
            this.courierTab.Size = new System.Drawing.Size(768, 366);
            this.courierTab.TabIndex = 4;
            this.courierTab.Text = "Couriers";
            this.courierTab.UseVisualStyleBackColor = true;
            // 
            // removeCourierButton
            // 
            this.removeCourierButton.Location = new System.Drawing.Point(330, 191);
            this.removeCourierButton.Name = "removeCourierButton";
            this.removeCourierButton.Size = new System.Drawing.Size(75, 23);
            this.removeCourierButton.TabIndex = 2;
            this.removeCourierButton.Text = "Remove";
            this.removeCourierButton.UseVisualStyleBackColor = true;
            this.removeCourierButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addCourierButton
            // 
            this.addCourierButton.Location = new System.Drawing.Point(330, 58);
            this.addCourierButton.Name = "addCourierButton";
            this.addCourierButton.Size = new System.Drawing.Size(75, 23);
            this.addCourierButton.TabIndex = 1;
            this.addCourierButton.Text = "Add";
            this.addCourierButton.UseVisualStyleBackColor = true;
            this.addCourierButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // couriersGrid
            // 
            this.couriersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couriersGrid.Location = new System.Drawing.Point(15, 18);
            this.couriersGrid.Name = "couriersGrid";
            this.couriersGrid.Size = new System.Drawing.Size(267, 327);
            this.couriersGrid.TabIndex = 0;
            // 
            // addressTabl
            // 
            this.addressTabl.Controls.Add(this.removeDeliveryTB);
            this.addressTabl.Controls.Add(this.addDeliveryTB);
            this.addressTabl.Controls.Add(this.removeDeliveryButton);
            this.addressTabl.Controls.Add(this.addDeliveryButton);
            this.addressTabl.Controls.Add(this.addressesGrid);
            this.addressTabl.Location = new System.Drawing.Point(4, 22);
            this.addressTabl.Name = "addressTabl";
            this.addressTabl.Size = new System.Drawing.Size(768, 366);
            this.addressTabl.TabIndex = 5;
            this.addressTabl.Text = "Addresses";
            this.addressTabl.UseVisualStyleBackColor = true;
            // 
            // removeDeliveryButton
            // 
            this.removeDeliveryButton.Location = new System.Drawing.Point(337, 201);
            this.removeDeliveryButton.Name = "removeDeliveryButton";
            this.removeDeliveryButton.Size = new System.Drawing.Size(75, 23);
            this.removeDeliveryButton.TabIndex = 2;
            this.removeDeliveryButton.Text = "Remove";
            this.removeDeliveryButton.UseVisualStyleBackColor = true;
            this.removeDeliveryButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Location = new System.Drawing.Point(337, 81);
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(75, 23);
            this.addDeliveryButton.TabIndex = 1;
            this.addDeliveryButton.Text = "Add";
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            this.addDeliveryButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addressesGrid
            // 
            this.addressesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressesGrid.Location = new System.Drawing.Point(14, 14);
            this.addressesGrid.Name = "addressesGrid";
            this.addressesGrid.Size = new System.Drawing.Size(281, 338);
            this.addressesGrid.TabIndex = 0;
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.removeClientButton);
            this.clientTab.Controls.Add(this.removeClientTB);
            this.clientTab.Controls.Add(this.clientsGrid);
            this.clientTab.Location = new System.Drawing.Point(4, 22);
            this.clientTab.Name = "clientTab";
            this.clientTab.Size = new System.Drawing.Size(768, 366);
            this.clientTab.TabIndex = 6;
            this.clientTab.Text = "Clients";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // clientsGrid
            // 
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Location = new System.Drawing.Point(14, 15);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.Size = new System.Drawing.Size(620, 334);
            this.clientsGrid.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(690, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addColorTB
            // 
            this.addColorTB.Location = new System.Drawing.Point(309, 54);
            this.addColorTB.Name = "addColorTB";
            this.addColorTB.Size = new System.Drawing.Size(100, 20);
            this.addColorTB.TabIndex = 3;
            // 
            // removeColorTB
            // 
            this.removeColorTB.Location = new System.Drawing.Point(309, 192);
            this.removeColorTB.Name = "removeColorTB";
            this.removeColorTB.Size = new System.Drawing.Size(100, 20);
            this.removeColorTB.TabIndex = 4;
            // 
            // addPaintTB
            // 
            this.addPaintTB.Location = new System.Drawing.Point(302, 40);
            this.addPaintTB.Name = "addPaintTB";
            this.addPaintTB.Size = new System.Drawing.Size(100, 20);
            this.addPaintTB.TabIndex = 3;
            // 
            // removePaintTB
            // 
            this.removePaintTB.Location = new System.Drawing.Point(302, 175);
            this.removePaintTB.Name = "removePaintTB";
            this.removePaintTB.Size = new System.Drawing.Size(100, 20);
            this.removePaintTB.TabIndex = 4;
            // 
            // addWoodTB
            // 
            this.addWoodTB.Location = new System.Drawing.Point(295, 34);
            this.addWoodTB.Name = "addWoodTB";
            this.addWoodTB.Size = new System.Drawing.Size(100, 20);
            this.addWoodTB.TabIndex = 3;
            // 
            // removeWoodTB
            // 
            this.removeWoodTB.Location = new System.Drawing.Point(295, 175);
            this.removeWoodTB.Name = "removeWoodTB";
            this.removeWoodTB.Size = new System.Drawing.Size(100, 20);
            this.removeWoodTB.TabIndex = 4;
            // 
            // addCourierTB
            // 
            this.addCourierTB.Location = new System.Drawing.Point(319, 32);
            this.addCourierTB.Name = "addCourierTB";
            this.addCourierTB.Size = new System.Drawing.Size(100, 20);
            this.addCourierTB.TabIndex = 3;
            // 
            // removeCourierTB
            // 
            this.removeCourierTB.Location = new System.Drawing.Point(319, 165);
            this.removeCourierTB.Name = "removeCourierTB";
            this.removeCourierTB.Size = new System.Drawing.Size(100, 20);
            this.removeCourierTB.TabIndex = 4;
            // 
            // addDeliveryTB
            // 
            this.addDeliveryTB.Location = new System.Drawing.Point(322, 42);
            this.addDeliveryTB.Name = "addDeliveryTB";
            this.addDeliveryTB.Size = new System.Drawing.Size(100, 20);
            this.addDeliveryTB.TabIndex = 3;
            // 
            // removeDeliveryTB
            // 
            this.removeDeliveryTB.Location = new System.Drawing.Point(322, 175);
            this.removeDeliveryTB.Name = "removeDeliveryTB";
            this.removeDeliveryTB.Size = new System.Drawing.Size(100, 20);
            this.removeDeliveryTB.TabIndex = 4;
            // 
            // courierCB
            // 
            this.courierCB.FormattingEnabled = true;
            this.courierCB.Location = new System.Drawing.Point(461, 31);
            this.courierCB.Name = "courierCB";
            this.courierCB.Size = new System.Drawing.Size(121, 21);
            this.courierCB.TabIndex = 5;
            // 
            // removeClientTB
            // 
            this.removeClientTB.Location = new System.Drawing.Point(649, 40);
            this.removeClientTB.Name = "removeClientTB";
            this.removeClientTB.Size = new System.Drawing.Size(100, 20);
            this.removeClientTB.TabIndex = 1;
            // 
            // removeClientButton
            // 
            this.removeClientButton.Location = new System.Drawing.Point(663, 100);
            this.removeClientButton.Name = "removeClientButton";
            this.removeClientButton.Size = new System.Drawing.Size(75, 23);
            this.removeClientButton.TabIndex = 2;
            this.removeClientButton.Text = "Remove";
            this.removeClientButton.UseVisualStyleBackColor = true;
            this.removeClientButton.Click += new System.EventHandler(this.removeButton_Click);


            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.tabControl1.ResumeLayout(false);
            this.categoryTab.ResumeLayout(false);
            this.categoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).EndInit();
            this.colorsTab.ResumeLayout(false);
            this.colorsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorGrid)).EndInit();
            this.paintTab.ResumeLayout(false);
            this.paintTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintGrid)).EndInit();
            this.woodTab.ResumeLayout(false);
            this.woodTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.woodGrid)).EndInit();
            this.courierTab.ResumeLayout(false);
            this.courierTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.couriersGrid)).EndInit();
            this.addressTabl.ResumeLayout(false);
            this.addressTabl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressesGrid)).EndInit();
            this.clientTab.ResumeLayout(false);
            this.clientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage colorsTab;
        private System.Windows.Forms.TabPage paintTab;
        private System.Windows.Forms.TabPage categoryTab;
        private System.Windows.Forms.TabPage woodTab;
        private System.Windows.Forms.TabPage courierTab;
        private System.Windows.Forms.TabPage addressTabl;
        private System.Windows.Forms.TabPage clientTab;
        private System.Windows.Forms.DataGridView categoryGrid;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox addCategoryTB;
        private System.Windows.Forms.Button removeCategoryButton;
        private System.Windows.Forms.TextBox removeCategoryTB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView colorGrid;
        private System.Windows.Forms.DataGridView paintGrid;
        private System.Windows.Forms.DataGridView woodGrid;
        private System.Windows.Forms.DataGridView couriersGrid;
        private System.Windows.Forms.DataGridView addressesGrid;
        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Button addColorButton;
        private System.Windows.Forms.Button addPaintButton;
        private System.Windows.Forms.Button addWoodButton;
        private System.Windows.Forms.Button addCourierButton;
        private System.Windows.Forms.Button addDeliveryButton;
        private System.Windows.Forms.Button removeColorButton;
        private System.Windows.Forms.Button removePaintButton;
        private System.Windows.Forms.Button removeWoodButton;
        private System.Windows.Forms.Button removeCourierButton;
        private System.Windows.Forms.Button removeDeliveryButton;
        private System.Windows.Forms.TextBox removeColorTB;
        private System.Windows.Forms.TextBox addColorTB;
        private System.Windows.Forms.TextBox removePaintTB;
        private System.Windows.Forms.TextBox addPaintTB;
        private System.Windows.Forms.TextBox addWoodTB;
        private System.Windows.Forms.TextBox removeWoodTB;
        private System.Windows.Forms.TextBox removeCourierTB;
        private System.Windows.Forms.TextBox addCourierTB;
        private System.Windows.Forms.TextBox addDeliveryTB;
        private System.Windows.Forms.TextBox removeDeliveryTB;
        private System.Windows.Forms.ComboBox courierCB;
        private System.Windows.Forms.Button removeClientButton;
        private System.Windows.Forms.TextBox removeClientTB;
    }
}