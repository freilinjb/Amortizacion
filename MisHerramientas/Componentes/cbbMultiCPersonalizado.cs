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
    public partial class cbbMultiCPersonalizado : Telerik.WinControls.UI.RadMultiColumnComboBox
    {
        public cbbMultiCPersonalizado()
        {
            InitializeComponent();
            this.SelectedIndex = -1;
        }
        public Boolean Validar { set; get; }
        public Boolean Limpiar { set; get; }
    }
}
