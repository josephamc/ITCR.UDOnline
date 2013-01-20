using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DayPilot.Web.Ui.Events;
using ITCR.UDOnline.Negocios.ClasesNegocios;

namespace ITCR.UDOnline.Interfaz.Calendario
{
    public partial class frmCalendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cCalendario calendario = new cCalendario();
                cldSeleccion.SelectedDate = DateTime.Today;
                EstablecerSemana();

                dpCalendar.DataSource = calendario.ObtenerReservaciones();
                dpCalendar.DataBind();
            }
        }

        protected void dpCalendar_EventClick(Object sender, EventClickEventArgs e)
        {
            String sID_SELECCION = e.Value.ToString();
            String[] sSPLIT = sID_SELECCION.Split(':');
            switch (sSPLIT[0])
            {
                case "Evento":
                    Response.Redirect("~/Calendario/frmEvento.aspx?id=" + sSPLIT[1], true);
                    break;
                case "Curso":
                    Response.Redirect("~/Calendario/frmCurso.aspx?id=" + sSPLIT[1], true);
                    break;
                case "Reservacion":
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('" + "Reservación hecha por un usuario" + "');", true);
                    break;
            }
        }

        protected void cldSeleccion_SelectionChanged(Object sender, EventArgs e)
        {
            EstablecerSemana();
        }

        /// <summary>
        /// Establece la semana en el Componente DayPilotCalendar
        /// </summary>
        private void EstablecerSemana()
        {
            DateTime dtfirstDay = ObtenerInicioSemana(cldSeleccion.SelectedDate, DayOfWeek.Sunday);
            cldSeleccion.VisibleDate = dtfirstDay;
            for (int i = 0; i < 7; i++)
                cldSeleccion.SelectedDates.Add(dtfirstDay.AddDays(i));

            dpCalendar.StartDate = dtfirstDay;
        }

        /// <summary>
        /// Obtiene el primer de la semana dado los parametros
        /// </summary>
        /// <param name="p_day">Dia actual</param>
        /// <param name="p_weekStarts">Dia seleccionado como inicio de semana. Ejem: Sunday, Monday...</param>
        /// <returns>DateTime Object</returns>
        private DateTime ObtenerInicioSemana(DateTime p_day, DayOfWeek p_weekStarts)
        {
            DateTime dtActual = p_day;
            while (dtActual.DayOfWeek != p_weekStarts)
                dtActual = dtActual.AddDays(-1);
            return dtActual;
        }
    }//class
}//namespace