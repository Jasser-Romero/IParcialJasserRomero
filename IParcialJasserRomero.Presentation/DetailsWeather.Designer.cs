
namespace IParcialJasserRomero.Presentation
{
    partial class DetailsWeather
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
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblDetailValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(3, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(40, 15);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail:";
            // 
            // lblDetailValue
            // 
            this.lblDetailValue.AutoSize = true;
            this.lblDetailValue.Location = new System.Drawing.Point(22, 37);
            this.lblDetailValue.Name = "lblDetailValue";
            this.lblDetailValue.Size = new System.Drawing.Size(35, 15);
            this.lblDetailValue.TabIndex = 1;
            this.lblDetailValue.Text = "Value";
            // 
            // DetailsWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetailValue);
            this.Controls.Add(this.lblDetail);
            this.Name = "DetailsWeather";
            this.Size = new System.Drawing.Size(70, 72);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.Label lblDetailValue;
    }
}
