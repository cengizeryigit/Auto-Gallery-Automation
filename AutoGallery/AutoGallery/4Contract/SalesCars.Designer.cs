namespace AutoGallery
{
    partial class SalesCars
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
            this.SalesCarsButtonListCar = new System.Windows.Forms.Button();
            this.AutoGallerydataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesCarsButtonListCar
            // 
            this.SalesCarsButtonListCar.BackColor = System.Drawing.Color.Black;
            this.SalesCarsButtonListCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesCarsButtonListCar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalesCarsButtonListCar.ForeColor = System.Drawing.Color.White;
            this.SalesCarsButtonListCar.Location = new System.Drawing.Point(311, 53);
            this.SalesCarsButtonListCar.Name = "SalesCarsButtonListCar";
            this.SalesCarsButtonListCar.Size = new System.Drawing.Size(170, 27);
            this.SalesCarsButtonListCar.TabIndex = 68;
            this.SalesCarsButtonListCar.Text = "List Car";
            this.SalesCarsButtonListCar.UseVisualStyleBackColor = false;
            this.SalesCarsButtonListCar.Click += new System.EventHandler(this.SalesCarsButtonListCar_Click);
            // 
            // AutoGallerydataGridView
            // 
            this.AutoGallerydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoGallerydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGallerydataGridView.Location = new System.Drawing.Point(0, 86);
            this.AutoGallerydataGridView.Name = "AutoGallerydataGridView";
            this.AutoGallerydataGridView.Size = new System.Drawing.Size(815, 429);
            this.AutoGallerydataGridView.TabIndex = 67;
            this.AutoGallerydataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoGallerydataGridView_CellClick);
            // 
            // SalesCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.SalesCarsButtonListCar);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesCars";
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SalesCarsButtonListCar;
        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
    }
}