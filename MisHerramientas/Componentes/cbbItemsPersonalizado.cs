﻿using System;
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
    public partial class cbbItemsPersonalizado : Telerik.WinControls.UI.RadDropDownList
    {
        public cbbItemsPersonalizado()
        {
            InitializeComponent();
        }
        public Boolean Validar { set; get; }    
        public Boolean Limpiar { set; get; }
    }
}
