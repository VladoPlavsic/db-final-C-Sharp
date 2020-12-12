namespace Shop
{
    partial class Courier
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliverButton = new System.Windows.Forms.Button();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // deliverButton
            // 
            this.deliverButton.Location = new System.Drawing.Point(991, 144);
            this.deliverButton.Name = "deliverButton";
            this.deliverButton.Size = new System.Drawing.Size(107, 106);
            this.deliverButton.TabIndex = 1;
            this.deliverButton.Text = "Delivered";
            this.deliverButton.UseVisualStyleBackColor = true;
            this.deliverButton.Click += new System.EventHandler(this.deliverButton_Click);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(991, 96);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(107, 20);
            this.id_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(991, 513);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(107, 28);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 553);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.deliverButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Courier";
            this.Text = "Courier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deliverButton;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutButton;
    }
}