using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDOnline.Interfaz
{
    public partial class frmNotificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sOperacion = Request.QueryString["op"]; // Obtiene la accion por la que se realiza la notificacion

            switch (sOperacion)
            {
                case "notCor":
                    lblMessage.Text = "La operación ha sido realizada con éxito";
                    break;
                case "notInc":
                    lblMessage.Text = "La operacion no ha podido ser realizada con éxito, por favor vuelva a intentarlo mas tarde";
                    break;
            }//switch sOperacion
        }
    }
}