namespace AutoGallery
{
    partial class ListCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCars));
            this.AutoGallerydataGridView = new System.Windows.Forms.DataGridView();
            this.ListCarsButtonListCars = new System.Windows.Forms.Button();
            this.ListCarsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListAllCarsButtonListAllCars = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoGallerydataGridView
            // 
            this.AutoGallerydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoGallerydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGallerydataGridView.Location = new System.Drawing.Point(0, 96);
            this.AutoGallerydataGridView.Name = "AutoGallerydataGridView";
            this.AutoGallerydataGridView.Size = new System.Drawing.Size(815, 419);
            this.AutoGallerydataGridView.TabIndex = 1;
            // 
            // ListCarsButtonListCars
            // 
            this.ListCarsButtonListCars.BackColor = System.Drawing.Color.Black;
            this.ListCarsButtonListCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListCarsButtonListCars.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListCarsButtonListCars.ForeColor = System.Drawing.Color.White;
            this.ListCarsButtonListCars.Location = new System.Drawing.Point(188, 56);
            this.ListCarsButtonListCars.Name = "ListCarsButtonListCars";
            this.ListCarsButtonListCars.Size = new System.Drawing.Size(200, 34);
            this.ListCarsButtonListCars.TabIndex = 16;
            this.ListCarsButtonListCars.Text = "LIST CARS";
            this.ListCarsButtonListCars.UseVisualStyleBackColor = false;
            this.ListCarsButtonListCars.Click += new System.EventHandler(this.ListCarsButtonListCars_Click);
            // 
            // ListCarsComboBox
            // 
            this.ListCarsComboBox.BackColor = System.Drawing.Color.White;
            this.ListCarsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListCarsComboBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListCarsComboBox.FormattingEnabled = true;
            this.ListCarsComboBox.Location = new System.Drawing.Point(294, 12);
            this.ListCarsComboBox.Name = "ListCarsComboBox";
            this.ListCarsComboBox.Size = new System.Drawing.Size(265, 31);
            this.ListCarsComboBox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(259, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 1);
            this.panel1.TabIndex = 27;
            // 
            // ListAllCarsButtonListAllCars
            // 
            this.ListAllCarsButtonListAllCars.BackColor = System.Drawing.Color.Black;
            this.ListAllCarsButtonListAllCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAllCarsButtonListAllCars.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListAllCarsButtonListAllCars.ForeColor = System.Drawing.Color.White;
            this.ListAllCarsButtonListAllCars.Location = new System.Drawing.Point(429, 56);
            this.ListAllCarsButtonListAllCars.Name = "ListAllCarsButtonListAllCars";
            this.ListAllCarsButtonListAllCars.Size = new System.Drawing.Size(200, 34);
            this.ListAllCarsButtonListAllCars.TabIndex = 16;
            this.ListAllCarsButtonListAllCars.Text = "LIST ALL CARS";
            this.ListAllCarsButtonListAllCars.UseVisualStyleBackColor = false;
            this.ListAllCarsButtonListAllCars.Click += new System.EventHandler(this.ListAllCarsButtonListAllCars_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // ListCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ListCarsComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListAllCarsButtonListAllCars);
            this.Controls.Add(this.ListCarsButtonListCars);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListCars";
            this.Load += new System.EventHandler(this.ListCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
        public System.Windows.Forms.ComboBox ListCarsComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button ListCarsButtonListCars;
        public System.Windows.Forms.Button ListAllCarsButtonListAllCars;
    }
}