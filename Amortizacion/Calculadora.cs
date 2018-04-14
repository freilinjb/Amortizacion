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

namespace Amortizacion
{
    public partial class Calculadora : FormBase
    {
        private static int frecuentia;
        private static float prestamo;
        private static float total_pagar;
        private static float interes_mensual;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {

            if (radGridView1.Rows.Count == 0)
                radGridView1.Rows.Add(0, null, null, null, float.Parse(txtMonto.Text.Trim().ToString()));

            if (cbbFrecuencia.SelectedIndex == 0)
                frecuentia = 1;

            if (MisHerramientas.Utilidades.Validaciones.Validar(this, groupBox1, errorProvider1) == true)
            {
                interes_mensual = frecuentia / 30;

                for (int i = 1; i < Convert.ToInt32(txtCuotas.Text.Trim().ToString()); i++ )
                {
                    //radGridView1.Rows.Add(i,);
                }
            }
        }

        private void cbbFrecuencia_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
        }
    }
}
