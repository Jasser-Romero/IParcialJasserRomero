
namespace IParcialJasserRomero.Presentation
{
    partial class WeatherPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTimezone = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(118, 27);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 30);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.Location = new System.Drawing.Point(103, 57);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(102, 45);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temp";
            // 
            // lblTimezone
            // 
            this.lblTimezone.AutoSize = true;
            this.lblTimezone.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimezone.Location = new System.Drawing.Point(103, 118);
            this.lblTimezone.Name = "lblTimezone";
            this.lblTimezone.Size = new System.Drawing.Size(95, 25);
            this.lblTimezone.TabIndex = 2;
            this.lblTimezone.Text = "Timezone";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 402);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(36, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "fecha";
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTimezone);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCity);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(326, 561);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblTimezone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblFecha;
    }
}
