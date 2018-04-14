using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortizacion
{
    class Informacion
    {
        class Prestamos
        {
            private static string capital;
            private static string deudas_con_intereses;
            private static string prestamos_activsos;
            private static string solicitudes;
            private static string prestamos_revision;
            private static string prestamos_atrasados;

            public string Capital { get => capital; set => capital = value; }
            public string Deudas_con_intereses { get => deudas_con_intereses; set => deudas_con_intereses = value; }
            public string Prestamos_activsos { get => prestamos_activsos; set => prestamos_activsos = value; }
            public string Solicitudes { get => solicitudes; set => solicitudes = value; }
            public string Prestamos_revision { get => prestamos_revision; set => prestamos_revision = value; }
            public string Prestamos_atrasados { get => prestamos_atrasados; set => prestamos_atrasados = value; }
        }
    }
}
