using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;




using System.Text.RegularExpressions;



namespace ITCR.UDOnline.Interfaz.Solicitudes
{
    public partial class frmSolicitud : System.Web.UI.Page
    {
        private int iIDInstalacion = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                iIDInstalacion = int.Parse(Request.QueryString["id"].ToString());
                cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                instalacionBase.ID_INSTALACION = iIDInstalacion;
                DataTable tabla = instalacionBase.SeleccionarUno();
                txt_nombreInstalacion.Text = instalacionBase.NOM_INSTALACION.ToString();


            }
            catch (Exception) { }
        }

        private void validaFormulario(string responsable, string solicitante, string identificacion, int cantidad, string razonUso, string correo)
        {

            string prueba = responsable + solicitante + identificacion + razonUso + correo;
            int can = cantidad + 0;

        }


        private int validaFechas(DateTime FechaInicio, DateTime FechaFin, DateTime HoraInicio, DateTime HoraFin) {

            if (FechaInicio == FechaFin) {
                if (HoraInicio >= HoraFin)
                    return -1;
                else
                    return 1;
            }

            if (FechaInicio > FechaFin)
            
                return -1;

            else
                return 1;
        }



        private bool EvaluateIsValid(string val)
        {
         
            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            Match match = Regex.Match(val.Trim(), pattern, RegexOptions.IgnoreCase);

            if (match.Success)
                return true;
            else
                return false;
        }




        protected void boton_enviar_solicitud_Click(object sender, EventArgs e)
        {
            TimeValidator1.Visible = false;
            TimeValidator2.Visible = false;
            DateValidator1.Visible = false;
            DateValidator2.Visible = false;
            EmailValidator.Visible = false;
            NumberValidator.Visible = false;
            InvolucradasValidator.Visible = false;
            ValidaSolicitante.Visible = false;
            ValidaResponsable.Visible = false;
            ValidaIdentificacion.Visible = false;
            ValidaRazonUso.Visible = false;
            InvolucradasValidator.Visible = false;

            try
            {
                
                int fecha = 0;
                bool email = false;
                cUDGDFRESERVACIONNegocios Nueva_Consulta = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
                int iResultado = -1000;
                string tiHRA_HORAINICIO = txt_Inicio.Text + ":00 " + ddlAmPm1.SelectedItem.Value.ToString();
                string tiHRA_HORAFIN = txt_Fin.Text + ":00 " + ddlAmPm2.SelectedItem.Value.ToString();
                validaFormulario(TextBox_responsable.Text.ToString(), TextBox_Solicitante.Text.ToString(), TextBox_identificacion.Text.ToString(), Int32.Parse(TextBox_cantidad.Text.ToString()), txt_razonUso.Value.ToString(), TextBox_correo.Text.ToString());
                fecha = validaFechas(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN));
                iResultado = Nueva_Consulta.ConsultarDisponibilidad(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN), iIDInstalacion);
                email = EvaluateIsValid(TextBox_correo.Text.ToString());
                if (iResultado == 1 && fecha==1 && email==true)
                {
                    cUDGDFSOLICITUDNegocios Nueva_Solicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
                    Nueva_Solicitud.FKY_INSTALACION = iIDInstalacion;
                    Nueva_Solicitud.FEC_INICIO = Convert.ToDateTime(txt_FechaInicio.Text.ToString());
                    Nueva_Solicitud.FEC_FIN = Convert.ToDateTime(txt_FechaFin.Text.ToString());
                    Nueva_Solicitud.FEC_SOLICITUD = DateTime.Now;
                    Nueva_Solicitud.HRA_INICIO = DateTime.Parse(tiHRA_HORAINICIO);
                    Nueva_Solicitud.HRA_FIN = DateTime.Parse(tiHRA_HORAFIN);
                    Nueva_Solicitud.NOM_ENCARGADO = TextBox_responsable.Text.ToString();
                    Nueva_Solicitud.NOM_INSTITUCION = TextBox_Solicitante.Text.ToString();
                    Nueva_Solicitud.COD_IDENTIFICACION = TextBox_identificacion.Text.ToString();
                    Nueva_Solicitud.CAN_USUARIOS = Int32.Parse(TextBox_cantidad.Text.ToString());
                    cUDGDFTPSOLTNTENegocios Solicitante = new cUDGDFTPSOLTNTENegocios(0, "", 0, "");
                    Nueva_Solicitud.FKY_TIPOSOLICITANTE = Solicitante.BuscarID(DropDownList1.Text.ToString());
                    Nueva_Solicitud.TXT_OBSERVACIONES = null;
                    Nueva_Solicitud.DSC_RAZONUSO = txt_razonUso.Value.ToString();
                    Nueva_Solicitud.COD_TIPOSOLICITUD = DropDownList2.Text.ToString();
                    Nueva_Solicitud.TXT_CORREO = TextBox_correo.Text.ToString();
                    Nueva_Solicitud.COD_ATENDIDO = false;
                    Nueva_Solicitud.TXT_USUARIOS = Textarea_involucradas.Value.ToString();
                    Nueva_Solicitud.Insertar();

                    Response.Redirect("/frmNotificacion.aspx?op=notCor", true);

                }

                    if (fecha == -1)
                    {
                        Response.Redirect("/frmErrorFechas.aspx", true);
                    }

                    if (email == false) {
                        Response.Redirect("/frmErrorEmail.aspx", true);
                    }

                    else

                        Response.Redirect("/frmError.aspx", true);
            }

            catch (Exception)
            {
                  
            }

            TimeValidator1.Visible = true;
            TimeValidator2.Visible = true;
            DateValidator1.Visible = true;
            DateValidator2.Visible = true;
            EmailValidator.Visible = true;
            NumberValidator.Visible = true;
            InvolucradasValidator.Visible = true;
            ValidaSolicitante.Visible = true;
            ValidaResponsable.Visible = true;
            ValidaIdentificacion.Visible = true;
            ValidaRazonUso.Visible = true;
            InvolucradasValidator.Visible = true;
        }

    }
}