using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDSystem.Negocios;
using System.Data;

namespace ITCR.UDOnline.Interfaz.Solicitudes
{
    public partial class frmInstalacion : System.Web.UI.Page
    {
        private int IDinstalacionPrevia = -1;
        private int enEdicion = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                IDinstalacionPrevia = int.Parse(Request.QueryString["id"].ToString());

                if (IDinstalacionPrevia != -1)
                {
                    enEdicion = IDinstalacionPrevia;
                    cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
                    instalacionBase.ID_INSTALACION = IDinstalacionPrevia;
                    DataTable tabla = instalacionBase.SeleccionarUno();

                    txt_id.Text = instalacionBase.ID_INSTALACION.ToString();
                    txt_nombre2.Text = instalacionBase.NOM_INSTALACION.ToString();
                    txt_descripcion22.Text = instalacionBase.DSC_INSTALACION.ToString();
                    txt_medidas2.Text = instalacionBase.DSC_MEDIDAS.ToString();
                    txt_reglamento22.Text = instalacionBase.TXT_REGLAMENTO.ToString();
                    txt_costos2.Text = instalacionBase.TXT_COSTOALQUILER.ToString();
                    string comentarios = instalacionBase.TXT_COMENTARIO.ToString();
                    if (comentarios != null)
                    {
                        txt_comentarios22.Text = comentarios;
                    }
                    else
                    {
                        txt_comentarios22.Text = "";
                    }
                }
                IDinstalacionPrevia = -1;
            }
            catch (Exception) { }
        }

        protected void btn_CrearSolicitud_Click(object sender, EventArgs e)
        {
            enEdicion = Int32.Parse(txt_id.Text.ToString());
            if (enEdicion != -1)
            {

                Response.Redirect("/Solicitudes/frmSolicitud.aspx?id=" + enEdicion, true);
            }
        }
    }
}