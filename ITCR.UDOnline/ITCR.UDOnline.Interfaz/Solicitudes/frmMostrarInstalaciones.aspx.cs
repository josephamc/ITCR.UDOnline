﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ITCR.UDOnline.Negocios;

namespace ITCR.UDOnline.Interfaz.Solicitudes
{
    public partial class frmMostrarInstalaciones : System.Web.UI.Page
    {
        cUDGDFINSTALACIONNegocios instalacion = new cUDGDFINSTALACIONNegocios(0, "", 0, "");

        protected void Page_Load(object sender, EventArgs e)
        {
            String stype = Request.QueryString["from"].ToString();
            Grid_Instalaciones2.RowEditing += GridView1_RowEditing;
            DataTable tablaInstalacionesBase;
            if(stype.Contains("SEARCH"))
            {
                String[] swords = stype.Split('-');
                cInstalacion cInst = new cInstalacion();
                tablaInstalacionesBase = cInst.search(swords[1]);
            }
            else
               tablaInstalacionesBase = instalacion.SeleccionarTodos();
            DataTable tablaInstalaciones = new DataTable();
            tablaInstalaciones.Columns.Add("identificacion");
            tablaInstalaciones.Columns.Add("  Nombre Instalacion          ");
            tablaInstalaciones.Columns.Add("  Descripcion Detallada de la Instalacion          ");


            for (int i = 0; i < tablaInstalacionesBase.Rows.Count; i++)
            {
                DataRow row = tablaInstalaciones.NewRow();
                row["identificacion"] = tablaInstalacionesBase.Rows[i][0];
                row["  Nombre Instalacion          "] = tablaInstalacionesBase.Rows[i][1];
                row["  Descripcion Detallada de la Instalacion          "] = tablaInstalacionesBase.Rows[i][2];

                tablaInstalaciones.Rows.Add(row);
            }
            Grid_Instalaciones2.DataSource = tablaInstalaciones;
            Grid_Instalaciones2.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Grid_Instalaciones2.EditIndex = e.NewEditIndex;
            int id = Convert.ToInt32(Grid_Instalaciones2.Rows[e.NewEditIndex].Cells[1].Text);

            Response.Redirect("/Solicitudes/frmInstalacion.aspx?id="+id, true);
        }
    }
}