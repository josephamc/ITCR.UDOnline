using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITCR.UDOnline.Negocios;
using System.Data;

namespace ITCR.UDOnline.Interfaz.Solicitudes
{
    public partial class ConsultaHorario : System.Web.UI.Page
    {
        private int idInstalacion = -1;
        cUDGDFHORARIONegocios Horario = new cUDGDFHORARIONegocios(0, "", 0, "");
        DataTable tablaHorarios;
        DataTable tablaHorariosFinal;

        protected void Page_Load(object sender, EventArgs e)
        {
            idInstalacion = int.Parse(Request.QueryString["id"].ToString());
            cUDGDFINSTALACIONNegocios instalacionBase = new cUDGDFINSTALACIONNegocios(0, "", 0, "");
            instalacionBase.ID_INSTALACION = idInstalacion;
            DataTable tabla = instalacionBase.SeleccionarUno();
            txt_inst.Text = instalacionBase.NOM_INSTALACION.ToString();

            ActualiceGrid();
        }

        private void ActualiceGrid()
        {
            //TimeValidator2.Visible = false;
            Horario.FKY_INSTALACION = idInstalacion;
            Horario.FKY_INSTALACIONOld = idInstalacion;
            tablaHorarios = Horario.SeleccionarTodos_Con_FKY_INSTALACION_FK();

            tablaHorariosFinal = new DataTable();
            tablaHorariosFinal.Columns.Add("ident");
            tablaHorariosFinal.Columns.Add("Dia de la Semana");
            tablaHorariosFinal.Columns.Add("Hora Inicio");
            tablaHorariosFinal.Columns.Add("Hora Fin");

            for (int i = 0; i < tablaHorarios.Rows.Count; i++)
            {
                string dia;
                switch (Int32.Parse(tablaHorarios.Rows[i][4].ToString()))
                {
                    case 1:
                        dia = "Lunes";
                        break;
                    case 2:
                        dia = "Martes";
                        break;
                    case 3:
                        dia = "Miércoles";
                        break;
                    case 4:
                        dia = "Jueves";
                        break;
                    case 5:
                        dia = "Viernes";
                        break;
                    case 6:
                        dia = "Sabado";
                        break;
                    case 7:
                        dia = "Domingo";
                        break;
                    default:
                        dia = "";
                        break;
                }

                DataRow row = tablaHorariosFinal.NewRow();
                row["ident"] = tablaHorarios.Rows[i][0];
                row["Dia de la Semana"] = dia;
                row["Hora Inicio"] = tablaHorarios.Rows[i][1];
                row["Hora Fin"] = tablaHorarios.Rows[i][2];

                tablaHorariosFinal.Rows.Add(row);
            }

            Grid_Horarios.DataSource = tablaHorariosFinal;
            Grid_Horarios.DataBind();
        }
    }
}