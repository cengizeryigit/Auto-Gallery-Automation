namespace AutoGallery
{
    partial class ListEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEmployee));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListAllEmployeeButtonListAllEmployee = new System.Windows.Forms.Button();
            this.ListEmployeeButtonListEmployee = new System.Windows.Forms.Button();
            this.AutoGallerydataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // ListEmployeeComboBox
            // 
            this.ListEmployeeComboBox.BackColor = System.Drawing.Color.White;
            this.ListEmployeeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListEmployeeComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListEmployeeComboBox.FormattingEnabled = true;
            this.ListEmployeeComboBox.Location = new System.Drawing.Point(294, 12);
            this.ListEmployeeComboBox.Name = "ListEmployeeComboBox";
            this.ListEmployeeComboBox.Size = new System.Drawing.Size(265, 31);
            this.ListEmployeeComboBox.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(259, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 1);
            this.panel1.TabIndex = 33;
            // 
            // ListAllEmployeeButtonListAllEmployee
            // 
            this.ListAllEmployeeButtonListAllEmployee.BackColor = System.Drawing.Color.Black;
            this.ListAllEmployeeButtonListAllEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAllEmployeeButtonListAllEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListAllEmployeeButtonListAllEmployee.ForeColor = System.Drawing.Color.White;
            this.ListAllEmployeeButtonListAllEmployee.Location = new System.Drawing.Point(429, 56);
            this.ListAllEmployeeButtonListAllEmployee.Name = "ListAllEmployeeButtonListAllEmployee";
            this.ListAllEmployeeButtonListAllEmployee.Size = new System.Drawing.Size(200, 34);
            this.ListAllEmployeeButtonListAllEmployee.TabIndex = 31;
            this.ListAllEmployeeButtonListAllEmployee.Text = "LIST ALL EMPLOYEE";
            this.ListAllEmployeeButtonListAllEmployee.UseVisualStyleBackColor = false;
            this.ListAllEmployeeButtonListAllEmployee.Click += new System.EventHandler(this.ListAllEmployeeButtonListAllEmployee_Click);
            // 
            // ListEmployeeButtonListEmployee
            // 
            this.ListEmployeeButtonListEmployee.BackColor = System.Drawing.Color.Black;
            this.ListEmployeeButtonListEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListEmployeeButtonListEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListEmployeeButtonListEmployee.ForeColor = System.Drawing.Color.White;
            this.ListEmployeeButtonListEmployee.Location = new System.Drawing.Point(188, 56);
            this.ListEmployeeButtonListEmployee.Name = "ListEmployeeButtonListEmployee";
            this.ListEmployeeButtonListEmployee.Size = new System.Drawing.Size(200, 34);
            this.ListEmployeeButtonListEmployee.TabIndex = 32;
            this.ListEmployeeButtonListEmployee.Text = "LIST EMPLOYEE";
            this.ListEmployeeButtonListEmployee.UseVisualStyleBackColor = false;
            this.ListEmployeeButtonListEmployee.Click += new System.EventHandler(this.ListEmployeeButtonListEmployee_Click);
            // 
            // AutoGallerydataGridView
            // 
            this.AutoGallerydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoGallerydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGallerydataGridView.Location = new System.Drawing.Point(0, 96);
            this.AutoGallerydataGridView.Name = "AutoGallerydataGridView";
            this.AutoGallerydataGridView.Size = new System.Drawing.Size(815, 419);
            this.AutoGallerydataGridView.TabIndex = 30;
            // 
            // ListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ListEmployeeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListAllEmployeeButtonListAllEmployee);
            this.Controls.Add(this.ListEmployeeButtonListEmployee);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListEmployee";
            this.Load += new System.EventHandler(this.ListEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ComboBox ListEmployeeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
        public System.Windows.Forms.Button ListAllEmployeeButtonListAllEmployee;
        public System.Windows.Forms.Button ListEmployeeButtonListEmployee;
    }
}