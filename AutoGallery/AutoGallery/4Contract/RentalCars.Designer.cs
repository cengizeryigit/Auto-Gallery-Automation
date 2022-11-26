namespace AutoGallery
{
    partial class RentalCars
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
            this.RentalCarsButtonListCar = new System.Windows.Forms.Button();
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
            this.AutoGallerydataGridView.TabIndex = 45;
            this.AutoGallerydataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AutoGallerydataGridView_CellClick);
            // 
            // RentalCarsButtonListCar
            // 
            this.RentalCarsButtonListCar.BackColor = System.Drawing.Color.Black;
            this.RentalCarsButtonListCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentalCarsButtonListCar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RentalCarsButtonListCar.ForeColor = System.Drawing.Color.White;
            this.RentalCarsButtonListCar.Location = new System.Drawing.Point(311, 53);
            this.RentalCarsButtonListCar.Name = "RentalCarsButtonListCar";
            this.RentalCarsButtonListCar.Size = new System.Drawing.Size(170, 27);
            this.RentalCarsButtonListCar.TabIndex = 66;
            this.RentalCarsButtonListCar.Text = "List Car";
            this.RentalCarsButtonListCar.UseVisualStyleBackColor = false;
            this.RentalCarsButtonListCar.Click += new System.EventHandler(this.ChooseCarsButtonListCar_Click);
            // 
            // RentalCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.RentalCarsButtonListCar);
            this.Controls.Add(this.AutoGallerydataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCars";
            this.Load += new System.EventHandler(this.ChooseCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AutoGallerydataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AutoGallerydataGridView;
        public System.Windows.Forms.Button RentalCarsButtonListCar;
    }
}