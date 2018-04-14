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
    public partial class txtMascPersonalizada : Telerik.WinControls.UI.RadMaskedEditBox
    {
        public txtMascPersonalizada()
        {
            InitializeComponent();
        }
        public Boolean Limpiar;
        public Boolean Validar;
    }
}
