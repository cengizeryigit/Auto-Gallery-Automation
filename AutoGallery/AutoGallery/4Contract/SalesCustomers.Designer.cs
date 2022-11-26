namespace AutoGallery
{
    partial class SalesCustomers
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
            this.SalesCustomersButtonListCustomer = new System.Windows.Forms.Button();
            this.AutoGallerydataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesCustomersButtonListCustomer
            // 
            this.SalesCustomersButtonListCustomer.BackColor = System.Drawing.Color.Black;
            this.SalesCustomersButtonListCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesCustomersButtonListCustomer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesCustomersButtonListCustomer.ForeColor = System.Drawing.Color.White;
            this.SalesCustomersButtonListCustomer.Location = new System.Drawing.Point(311, 53);
            this.SalesCustomersButtonListCustomer.Name = "SalesCustomersButtonListCustomer";
            this.SalesCustomersButtonListCustomer.Size = new System.Drawing.Size(170, 27);
            this.SalesCustomersButtonListCustomer.TabIndex = 69;
            this.SalesCustomersButtonListCustomer.Text = "List Customer";
            this.SalesCustomersButtonListCustomer.UseVisualStyleBackColor = false;
            this.SalesCustomersButtonListCustomer.Click += new System.EventHandler(this.SalesCustomersButtonListCustomer_Click);
            // 
            // AutoGallerydataGridView
            // 
            this.AutoGallerydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoGallerydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGallerydataGridView.Location = new System.Drawing.Point(0, 86);
            this.AutoGallerydataGridView.Name = "AutoGallerydataGridView";
            this.AutoGallerydataGridView.Size = new System.Drawing.Size(815, 429);
            this.AutoGallerydataGridView.TabIndex = 68;
            this.AutoGallerydataGridView.Click += new System.EventHandler(this.AutoGallerydataGridView_Click);
            // 
            // SalesCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.SalesCustomersButtonListCustomer);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SalesCustomersButtonListCustomer;
        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
    }
}