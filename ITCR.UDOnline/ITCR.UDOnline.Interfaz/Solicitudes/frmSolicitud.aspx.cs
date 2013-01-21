using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDOnline.Negocios;
using System.Data;




using System.Text.RegularExpressions;



namespace ITCR.UDOnline.Interfaz.Solicitudes
{
    public partial class frmSolicitud : System.Web.UI.Page
    {
        private int iIDInstalacion = -1;
        private string nominst = "";
        public int IDInst
        {
            get
            {
                return iIDInstalacion;
            }
        }
        public string NomInst
        {
            get
            {
                return nominst;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                iIDInstalacion = int.Parse(Request.QueryString["id"].ToString());
                cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                instalacionBase.ID_INSTALACION = iIDInstalacion;
                DataTable tabla = instalacionBase.SeleccionarUno();
                txt_nombreInstalacion.Text = instalacionBase.NOM_INSTALACION.ToString();
                nominst = txt_nombreInstalacion.Text.ToString();

                aaa.HRef = "/Solicitudes/ConsultaHorario.aspx?id=" + iIDInstalacion;
            }
            catch (Exception) { }
        }

       


       


        private int validaFechas(DateTime FechaInicio, DateTime FechaFin, DateTime HoraInicio, DateTime HoraFin) {

            DateTime hoy = DateTime.Now;

            if (FechaInicio >= hoy) // aqui valido que no ingresen fechas menores al dia que se hace la solicitud
            {

                if (FechaInicio == FechaFin)
                {
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
            else
                return -1;
        }




        private int ValidarDiaInstalacion(DateTime p_fecinicio, DateTime p_fecfin, int p_idInstalacion, cUDGDFRESERVACIONNegocios Nueva_Consulta)
        {
            int retorno = -1000;
            while (p_fecinicio <= p_fecfin)
            {
                retorno = Nueva_Consulta.ConsultarDisponibilidadDia(p_fecinicio, p_idInstalacion);
                if (retorno == -1)
                    break;
                p_fecinicio=p_fecinicio.AddDays(1);
            }

            return retorno;
        
        }


     



        protected void boton_enviar_solicitud_Click(object sender, EventArgs e)
        {

            try
            {
                if (Page.IsValid == true)
                {

                    int fecha = 0;
                    cUDGDFRESERVACIONNegocios Nueva_Consulta = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
                    int iResultado = -1000;
                    int iResultadoDia = -1000;
                    string tiHRA_HORAINICIO = txt_Inicio.Text + ":00 " + ddlAmPm1.SelectedItem.Value.ToString();
                    string tiHRA_HORAFIN = txt_Fin.Text + ":00 " + ddlAmPm2.SelectedItem.Value.ToString();

                    if (ddlAmPm1.SelectedItem.Value.ToString() == "MD")
                    {
                        tiHRA_HORAINICIO = txt_Inicio.Text + ":00 " + "PM";
                    }

                    if (ddlAmPm2.SelectedItem.Value.ToString() == "MD")
                    {
                        tiHRA_HORAFIN = txt_Fin.Text + ":00 " + "PM";
                    }

                    fecha = validaFechas(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN));
                    iResultado = Nueva_Consulta.ConsultarDisponibilidad(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), DateTime.Parse(tiHRA_HORAINICIO), DateTime.Parse(tiHRA_HORAFIN), iIDInstalacion);

                    iResultadoDia = ValidarDiaInstalacion(Convert.ToDateTime(txt_FechaInicio.Text.ToString()), Convert.ToDateTime(txt_FechaFin.Text.ToString()), iIDInstalacion, Nueva_Consulta);
                    if (iResultado == 1 && iResultadoDia == 1 && fecha == 1)
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
                        Nueva_Solicitud.CAN_USUARIOSH = Int32.Parse(TextBox_cantidadh.Text.ToString());
                        Nueva_Solicitud.CAN_USUARIOSM = Int32.Parse(TextBox_cantidadm.Text.ToString());
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




                    if (iResultadoDia == -1)
                    {
                        Response.Redirect("/frmErrorDia.aspx", true);
                    }

                    if (fecha == -1)
                    {
                        Response.Redirect("/frmErrorFechas.aspx", true);
                    }



                    else

                        Response.Redirect("/frmError.aspx", true);
                }
            }
            catch (Exception)
            {
            } 
            
     

            TimeValidator1.Visible = true;
            TimeValidator2.Visible = true;
            DateValidator1.Visible = true;
            DateValidator2.Visible = true;
            EmailValidator.Visible = true;
            NumberValidatorh.Visible = true;
            NumberValidatorm.Visible = true;
            InvolucradasValidator.Visible = true;
            ValidaSolicitante.Visible = true;
            ValidaResponsable.Visible = true;
            ValidaIdentificacion.Visible = true;
            ValidaRazonUso.Visible = true;
            InvolucradasValidator.Visible = true;
        }


    }
}