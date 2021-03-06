﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCurso.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Calendario.frmCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 868px;
        }
        #btnAceptar
        {
            height: 24px;
            width: 76px;
        }
        #btnRechazar
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<!-- Administrador -->
<ajaxToolkit:ToolkitScriptManager ID="tksManager" runat="server"></ajaxToolkit:ToolkitScriptManager>

<!-- Informacion del evento -->
<br />
<br />
<table>
    <tr>
        <td valign="top" class="style2">
        <!-- Main Container -->
            <!-- Encabezado -->
            <div style="background-color: #336699; height: 55px;">
                <br />
            </div>
            <!-- Ficha de informacion -->
            <fieldset>
                <h1>Información del Curso</h1>
                <div>
                    <asp:Label ID="lbl_ID_RESERVACION" runat="server" Text="ID_RESERVACION" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lbl_ID_CURSO" runat="server" Text="ID_EVENTO" Visible="False"></asp:Label>
                    <asp:Label ID="lbl_ID_INSTALACION" runat="server" Text="ID_INSTALACION" 
                        Visible="False"></asp:Label>
                    <asp:Label ID="lbl_NOM_CURSO" runat="server" Text="NOM_CURSO" Visible="False"></asp:Label>
                    <br />
                    <br />
                    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_NOMBRE" runat="server" Width="371px" Enabled="False"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    Instalacion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:DropDownList ID="drp_INSTALACION" runat="server" 
                        Width="368px" Enabled="False">
                    </asp:DropDownList>
                    <br />
                    <br />
                    Nombre del profesor:
                    <asp:TextBox ID="txt_PROFESOR" runat="server" Enabled="False" Width="357px"></asp:TextBox>
                    <br />
                    <br />
                    <h3>Calendario</h3>
                    <br />
                    <br />
                    Fecha inicio:
                    <asp:TextBox ID="txt_FEC_INICIO" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;<asp:Image ID="img_CALENDAR_INIT" ImageUrl="~/images/date.png" 
                        runat="server" Width="26px" Visible="False" />
                    <ajaxToolkit:CalendarExtender ID="cldExtender_INIT" TargetControlID="txt_FEC_INICIO" 
                            PopupButtonID="img_CALENDAR_INIT" Enabled="false" runat="server" Format="dd/MM/yyyy">
                    </ajaxToolkit:CalendarExtender>
                    <br />
                    Fecha fin:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_FEC_FIN" runat="server" Enabled="False"></asp:TextBox>
                    &nbsp;<asp:Image ID="img_CALENDAR_FIN" ImageUrl="~/images/date.png" 
                        runat="server" Width="26px" Visible="False" />
                    <ajaxToolkit:CalendarExtender ID="cldExtender_FIN" TargetControlID="txt_FEC_FIN" 
                            PopupButtonID="img_CALENDAR_FIN" Enabled="false" runat="server" Format="dd/MM/yyyy">
                    </ajaxToolkit:CalendarExtender>
                    <br />
                    Formato de la fecha dd/MM/yyyy. Ejem: 12/01/2013
                    <br />
                    <br />
                    Hora inicio:
                    <asp:TextBox ID="txt_HRA_INICIO" runat="server" Enabled="False"></asp:TextBox>
                    <asp:DropDownList ID="drp_TIME_INIT" runat="server" Enabled="False">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    Hora fin:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txt_HRA_FIN" runat="server" Enabled="False"></asp:TextBox>
                    <asp:DropDownList ID="drp_TIME_FIN" runat="server" Enabled="False">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    Formato de la hora HH:mm. Ejem: 10:23
                    <br />
                    <br />
                    <br />
                    Días:
                    <br />
                    <asp:CheckBox ID="chk_LUNES" Text="Lunes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_MARTES" Text="Martes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_MIERCOLES" Text="Miércoles" runat="server" 
                        Enabled="False" />
                    <asp:CheckBox ID="chk_JUEVES" Text="Jueves" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_VIERNES" Text="Viernes" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_SABADO" Text="Sábado" runat="server" Enabled="False" />
                    <asp:CheckBox ID="chk_DOMINGO" Text="Domingo" runat="server" Enabled="False" />
                    <br />
                    <br />
                </div>
            </fieldset>
            <!-- Fin de ficha de información -->
            <br />
            <br />
        <!-- Main Container end -->
        </td>
        <td>
            &nbsp;&nbsp;&nbsp;
            <asp:Image ID="img_BANNER" runat="server" ImageUrl="~/images/GestionarSolicitudes.jpg" width="297px" height="526px" />
            &nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
</asp:Content>
