using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisHerramientas;
using System.Data;

namespace Amortizacion
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text)) || (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text)))
            {
                Utilidades.Usuario.User = txtUsuario.Text;
                string cmd = string.Format("SELECT * FROM Usuario WHERE Usuario='{0}' AND Clave='{1}'", txtUsuario.Text.ToString(),txtClave.Text.ToString());
                DataSet data = Utilidades.Conexiones.Ejecutar(cmd);



            }
        }
    }
}
