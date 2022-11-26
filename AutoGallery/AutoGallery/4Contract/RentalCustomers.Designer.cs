namespace AutoGallery
{
    partial class RentalCustomers
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
            this.AutoGallerydataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseCustomersButtonListCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoGallerydataGridView
            // 
            this.AutoGallerydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoGallerydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGallerydataGridView.Location = new System.Drawing.Point(0, 86);
            this.AutoGallerydataGridView.Name = "AutoGallerydataGridView";
            this.AutoGallerydataGridView.Size = new System.Drawing.Size(815, 429);
            this.AutoGallerydataGridView.TabIndex = 46;
            this.AutoGallerydataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoGallerydataGridView_CellClick);
            // 
            // ChooseCustomersButtonListCustomer
            // 
            this.ChooseCustomersButtonListCustomer.BackColor = System.Drawing.Color.Black;
            this.ChooseCustomersButtonListCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseCustomersButtonListCustomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChooseCustomersButtonListCustomer.ForeColor = System.Drawing.Color.White;
            this.ChooseCustomersButtonListCustomer.Location = new System.Drawing.Point(311, 53);
            this.ChooseCustomersButtonListCustomer.Name = "ChooseCustomersButtonListCustomer";
            this.ChooseCustomersButtonListCustomer.Size = new System.Drawing.Size(170, 27);
            this.ChooseCustomersButtonListCustomer.TabIndex = 67;
            this.ChooseCustomersButtonListCustomer.Text = "List Customer";
            this.ChooseCustomersButtonListCustomer.UseVisualStyleBackColor = false;
            this.ChooseCustomersButtonListCustomer.Click += new System.EventHandler(this.ChooseCustomersButtonListCustomer_Click);
            // 
            // ChooseCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.ChooseCustomersButtonListCustomer);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCustomers";
            this.Load += new System.EventHandler(this.ChooseCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
        public System.Windows.Forms.Button ChooseCustomersButtonListCustomer;
    }
}