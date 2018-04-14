using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using Telerik.WinControls;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MisHerramientas
{
    public class Utilidades
    {
        public class Conexiones
        {
            private static readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TBC13SC\\SQLEXPRESS;Initial Catalog=Amortizador;Integrated Security=True");
            private static SqlDataAdapter adapter;

            public static DataSet Ejecutar(string cmd)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                DataSet data = new DataSet();
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(cmd, connection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("Ha ocurrido un error", "Información del Sistema", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, ex.Message);
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                }
                return data;
            }

            public static DataTable EjecutarGrid(string cmd)
            {
                RadMessageBox.SetThemeName("TelerikMetroBlue");
                DataTable data = new DataTable();
                try
                {
                    adapter = new SqlDataAdapter(cmd, connection);
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    connection.Close();
                    RadMessageBox.Show("Ha ocurrido un error..", "Error del Sistema", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return data;
            }
        }

        public class Validaciones
        {
            public static bool VerificarEmail(string seMailAComprobar)
            {
                if (seMailAComprobar.Length == 0)
                {
                    return true;
                }
                else
                {
                    String sFormato;
                    sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                    if (Regex.IsMatch(seMailAComprobar, sFormato))
                    {
                        if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            public static bool Validar(Control control, ErrorProvider error)
            {
                bool validado = true;

                foreach (Control item in control.Controls)
                {
                    //Valida Texto Personalizado
                    if (item is Componentes.txtPersonalizado txt)
                    {
                        if (txt.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(txt.Text.Trim())) && (string.IsNullOrWhiteSpace(txt.Text.Trim())))
                            {
                                error.SetError(txt, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                        if (txt.Correo == true)
                        {
                            if (VerificarEmail(txt.Text.Trim()) == false)
                            {
                                error.SetError(txt, "Correo Invalido");
                                validado = false;
                            }
                        }
                        if (validado == true)
                            error.Clear();
                    }
                    //Valida ComboBox Personalizado
                    if (item is Componentes.cbbItemsPersonalizado cbb)
                    {
                        if (cbb.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(cbb.Text.Trim())) && (string.IsNullOrWhiteSpace(cbb.Text.Trim())))
                            {
                                error.SetError(cbb, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }

                }
                return validado;
            }
            public static bool Validar(Control control, GroupBox rad, ErrorProvider error)
            {
                bool validado = true;

                foreach (Control item in control.Controls)
                {
                    if (item is Componentes.txtPersonalizado txt)
                    {
                        if (txt.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(txt.Text.Trim())) && (string.IsNullOrWhiteSpace(txt.Text.Trim())))
                            {
                                error.SetError(txt, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }
                    if (item is Componentes.cbbItemsPersonalizado cbb)
                    {
                        if (cbb.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(cbb.Text.Trim()) && (string.IsNullOrWhiteSpace(cbb.Text.Trim()))))
                            {
                                error.SetError(cbb, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }
                }

                foreach (Control item in rad.Controls)
                {
                    //Valida Texto Personalizado
                    if (item is Componentes.txtPersonalizado txt)
                    {
                        if (txt.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(txt.Text.Trim())) && (string.IsNullOrWhiteSpace(txt.Text.Trim())))
                            {
                                error.SetError(txt, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                        if (txt.Correo == true)
                        {
                            if (VerificarEmail(txt.Text.Trim()) == false)
                            {
                                error.SetError(txt, "Correo Invalido");
                                validado = false;
                            }
                        }
                    }
                    //Valida ComboBox Personalizado
                    if (item is Componentes.cbbItemsPersonalizado cbb)
                    {
                        if (cbb.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(cbb.Text.Trim())) && (string.IsNullOrWhiteSpace(cbb.Text.Trim())))
                            {
                                error.SetError(cbb, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }
                    //Valida Multicombobox Personalizado
                    if (item is Componentes.cbbMultiCPersonalizado cbbm)
                    {
                        if (cbbm.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(cbbm.Text.Trim())) && (string.IsNullOrWhiteSpace(cbbm.Text.Trim())))
                            {
                                error.SetError(cbbm, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }
                    //Valida Mascara Personalizado
                    if (item is Componentes.txtMascPersonalizada masc)
                    {
                        if (masc.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(masc.Text.Trim())) && (string.IsNullOrWhiteSpace(masc.Text.Trim())))
                            {
                                error.SetError(masc, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }
                }

                foreach (Control item in rad.Controls)
                {
                    //Valida Texto Personalizado
                    if (item is Componentes.txtPersonalizado txt)
                    {
                        if (txt.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(txt.Text.Trim())) && (string.IsNullOrWhiteSpace(txt.Text.Trim())))
                            {
                                error.SetError(txt, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                        if (txt.Correo == true)
                        {
                            if (VerificarEmail(txt.Text.Trim()) == false)
                            {
                                error.SetError(txt, "Correo Invalido");
                                validado = false;
                            }
                        }
                        if (validado == true)
                            error.Clear();
                    }
                    //Valida ComboBox Personalizado
                    if (item is Componentes.cbbItemsPersonalizado cbb)
                    {
                        if (cbb.Validar == true)
                        {
                            if ((string.IsNullOrEmpty(cbb.Text.Trim())) && (string.IsNullOrWhiteSpace(cbb.Text.Trim())))
                            {
                                error.SetError(cbb, "No puede estar vacio ni tener espacios en blanco");
                                validado = false;
                            }
                        }
                    }

                }
                return validado;
            }
            public static void Limpiar(Control control, ErrorProvider error)
            {
                foreach (Control item in control.Controls.OfType<RadGroupBox>())
                {
                    foreach (Componentes.txtPersonalizado txt in control.Controls.OfType<Componentes.txtPersonalizado>())
                    {
                        txt.Clear();
                    }
                }
                foreach (var txt in control.Controls)
                {
                    if (txt is Componentes.txtPersonalizado)
                    {
                        ((Componentes.txtPersonalizado)txt).Clear();
                    }
                    if (txt is Componentes.cbbItemsPersonalizado)
                    {
                        if (((Componentes.cbbItemsPersonalizado)txt).Validar == true)
                        {
                            ((Componentes.cbbItemsPersonalizado)txt).SelectedIndex = -1;
                        }
                    }
                    if (txt is Componentes.cbbMultiCPersonalizado)
                    {
                        if (((Componentes.cbbMultiCPersonalizado)txt).Limpiar == true)
                            ((Componentes.cbbMultiCPersonalizado)txt).SelectedIndex = -1;
                    }
                    if (txt is Componentes.txtMascPersonalizada)
                    {

                        if (((Componentes.txtMascPersonalizada)txt).Limpiar == true)
                            ((Componentes.txtMascPersonalizada)txt).Clear();
                    }
                }
                error.Clear();
            }
            public static void Limpiar(Control item, GroupBox radgroup, ErrorProvider error)
            {
                foreach (var txt in item.Controls)
                {
                    if (txt is Componentes.cbbItemsPersonalizado)
                    {
                        if (((Componentes.cbbItemsPersonalizado)txt).Limpiar == true)
                            ((Componentes.cbbItemsPersonalizado)txt).Text = "";
                    }
                    if (txt is Componentes.txtPersonalizado)
                    {
                        if (((Componentes.txtPersonalizado)txt).Limpiar == true)
                            ((Componentes.txtPersonalizado)txt).Clear();
                    }
                    if (txt is Componentes.cbbMultiCPersonalizado)
                    {
                        if (((Componentes.cbbMultiCPersonalizado)txt).Limpiar == true)
                            ((Componentes.cbbMultiCPersonalizado)txt).SelectedIndex = -1;
                    }
                    if (txt is Componentes.txtMascPersonalizada)
                    {

                        if (((Componentes.txtMascPersonalizada)txt).Limpiar == true)
                            ((Componentes.txtMascPersonalizada)txt).Clear();
                    }
                }
                foreach (var txt in radgroup.Controls)
                {
                    if (txt is Componentes.txtPersonalizado)
                    {
                        ((Componentes.txtPersonalizado)txt).Clear();
                    }
                    if (txt is Componentes.cbbItemsPersonalizado)
                    {
                        if (((Componentes.cbbItemsPersonalizado)txt).Validar == true)
                        {
                            ((Componentes.cbbItemsPersonalizado)txt).SelectedIndex = -1;
                        }
                    }
                    if (txt is Componentes.cbbMultiCPersonalizado)
                    {
                        if (((Componentes.cbbMultiCPersonalizado)txt).Limpiar == true)
                            ((Componentes.cbbMultiCPersonalizado)txt).SelectedIndex = -1;
                    }
                    if (txt is Componentes.txtMascPersonalizada)
                    {

                        if (((Componentes.txtMascPersonalizada)txt).Limpiar == true)
                            ((Componentes.txtMascPersonalizada)txt).Clear();
                    }
                }
                error.Clear();
            }
        }
        public class Usuario
        {
            private static string user;
            private  static string id;

            public static string User { get => user; set => user = value; }
            public static string Id { get => id; set => id = value; }
        }
    }
}