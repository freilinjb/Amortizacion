namespace Amortizacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btLogin = new Telerik.WinControls.UI.RadButton();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.txtClave = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUsuario = new MisHerramientas.Componentes.txtPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.btLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btLogin.Location = new System.Drawing.Point(246, 334);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(310, 36);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Iniciar Sesion";
            this.btLogin.ThemeName = "Fluent";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(246, 183);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(310, 24);
            this.txtClave.TabIndex = 0;
            this.txtClave.Text = "Nombre de Usuario";
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.ThemeName = "Fluent";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radButton1.Location = new System.Drawing.Point(246, 376);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(310, 36);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Aceptar";
            this.radButton1.ThemeName = "Fluent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Correo = false;
            this.txtUsuario.Limpiar = false;
            this.txtUsuario.Location = new System.Drawing.Point(246, 153);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NullText = "Nombre de Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(310, 24);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.ThemeName = "Fluent";
            this.txtUsuario.Uso = MisHerramientas.Componentes.txtPersonalizado.Estados.Default;
            this.txtUsuario.Validar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 448);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtClave);
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btLogin;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadTextBox txtClave;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MisHerramientas.Componentes.txtPersonalizado txtUsuario;
    }
}