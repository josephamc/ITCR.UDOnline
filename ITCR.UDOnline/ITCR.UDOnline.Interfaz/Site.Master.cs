using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITCR.UDOnline.Interfaz
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Solicitudes/frmMostrarInstalaciones.aspx?from=SEARCH-" + txt_search.Text, true);
        }

    }
}
