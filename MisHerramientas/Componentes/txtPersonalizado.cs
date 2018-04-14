using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisHerramientas.Componentes
{
    public partial class txtPersonalizado : Telerik.WinControls.UI.RadTextBox
    {
        public txtPersonalizado()
        {
            InitializeComponent();
        }
        private Estados estados = Estados.Default;
        public enum Estados
        {
            Default,
            Numeros,
            Letras,
            SinEspacios,
            Decimales,
            NumeroSinEspacios,
            Dinero,
        }
        public Estados Uso { get; set; }
        public Boolean Validar { set; get; }
        public Boolean Correo { set; get; }
        public Boolean Limpiar { set; get; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (estados == Estados.Default)
                base.OnKeyPress(e);

            else if (estados == Estados.Letras)
                e.Handled = !Letras(e.KeyChar);

            else if (estados == Estados.Numeros)
                e.Handled = !Numeros(e.KeyChar);

            else if (estados == Estados.SinEspacios)
                e.Handled = !SinEspacios(e.KeyChar);

            else if (estados == Estados.NumeroSinEspacios)
                e.Handled = !NumeroSinEspacios(e.KeyChar);

        }
        private Boolean Letras(char caracter)
        {
            if (char.IsLetter(caracter) || char.IsControl(caracter) || char.IsSeparator(caracter))
                return true;
            else
                return false;
        }

        private Boolean Numeros(char caracter)
        {
            if (char.IsDigit(caracter) || char.IsControl(caracter))
                return true;

            else
                return false;
        }

        private Boolean SinEspacios(char caracter)
        {
            if (char.IsSeparator(caracter) || char.IsControl(caracter))
                return false;
            else
                return true;
        }
        public Boolean NumeroSinEspacios(char caracter)
        {
            if (char.IsDigit(caracter))
                return true;

            else
                return false;
        }
    }
}
