using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDOnline.Negocios;
using System.Data;

namespace ITCR.UDOnline.Interfaz.Calendario
{
    public partial class frmCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int iID_EVENTO = int.Parse(Request.QueryString["id"].ToString());

            // Carga la informacion
            if (!IsPostBack)
            {
                cUDGDFCURSONegocios cCurso = new cUDGDFCURSONegocios(0, "", 0, "");
                cUDGDFINSTALACIONNegocios cInstalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");

                DataRow drInformacion = cCurso.Seleccionar_Con_ID(iID_EVENTO).Rows[0];
                DataTable _dtInstalaciones = cInstalacion.SeleccionarTodos();

                // Carga las instalaciones
                foreach (DataRow dtLocalRow in _dtInstalaciones.Rows)
                {
                    drp_INSTALACION.Items.Add(dtLocalRow[1].ToString());
                    if (dtLocalRow[1].ToString().CompareTo(drInformacion[16].ToString()) == 0)
                        drp_INSTALACION.SelectedIndex = drp_INSTALACION.Items.Count - 1;
                }

                // Establece los ID de la informacion mostrada para los edit
                lbl_ID_CURSO.Text = drInformacion[0].ToString();
                lbl_ID_INSTALACION.Text = drInformacion[2].ToString();
                lbl_ID_RESERVACION.Text = drInformacion[1].ToString();
                lbl_NOM_CURSO.Text = drInformacion[3].ToString();

                // Establece los campos textbox
                txt_NOMBRE.Text = drInformacion[3].ToString();
                txt_PROFESOR.Text = drInformacion[4].ToString();
                txt_FEC_INICIO.Text = ((DateTime)drInformacion[12]).ToShortDateString();
                txt_FEC_FIN.Text = ((DateTime)drInformacion[13]).ToShortDateString();

                String[] sHRA_INICIO = drInformacion[14].ToString().Split(':');
                String[] sHRA_FIN = drInformacion[15].ToString().Split(':');

                if (int.Parse(sHRA_INICIO[0]) >= 12)
                {
                    txt_HRA_INICIO.Text = (int.Parse(sHRA_INICIO[0]) - 12) + ":00:00";
                    drp_TIME_INIT.SelectedIndex = 1;
                }
                else
                    txt_HRA_INICIO.Text = drInformacion[14].ToString();

                if (int.Parse(sHRA_FIN[0]) >= 12)
                {
                    txt_HRA_FIN.Text = (int.Parse(sHRA_FIN[0]) - 12) + ":00:00";
                    drp_TIME_FIN.SelectedIndex = 1;
                }
                else
                    txt_HRA_FIN.Text = drInformacion[15].ToString();

                // Establece los campos checkbox
                chk_LUNES.Checked = (Boolean)drInformacion[5];
                chk_MARTES.Checked = (Boolean)drInformacion[6];
                chk_MIERCOLES.Checked = (Boolean)drInformacion[7];
                chk_JUEVES.Checked = (Boolean)drInformacion[8];
                chk_VIERNES.Checked = (Boolean)drInformacion[9];
                chk_SABADO.Checked = (Boolean)drInformacion[10];
                chk_DOMINGO.Checked = (Boolean)drInformacion[11];
            }
        }
    }//class
}//namespace