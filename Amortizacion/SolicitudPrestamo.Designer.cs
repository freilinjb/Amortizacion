namespace Amortizacion
{
    partial class SolicitudPrestamo
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
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel13
            // 
            this.radLabel13.AutoSize = false;
            this.radLabel13.BackColor = System.Drawing.Color.PowderBlue;
            this.radLabel13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch);
            this.radLabel13.ForeColor = System.Drawing.Color.Black;
            this.radLabel13.Location = new System.Drawing.Point(12, 12);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(776, 24);
            this.radLabel13.TabIndex = 43;
            this.radLabel13.Text = "Solicitud de Prestamos";
            this.radLabel13.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radLabel13.ThemeName = "Fluent";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 396);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes";
            // 
            // SolicitudPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radLabel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudPrestamo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SolicitudPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel13;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}