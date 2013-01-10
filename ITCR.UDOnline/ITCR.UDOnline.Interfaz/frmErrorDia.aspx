<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmErrorDia.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.frmErrorDia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <div id="imglogo">
                	<img src="../../images/denegado.png" alt=""/>
            </div>
        </td>
        <td>
            <div>
                <h1> ¡ Su solicitud no puede ser procesada ! </h1>
                <h3>
                    El rango de fechas introducido no concuerda con el horario de la instalación solicitada
                </h3>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_redirect" runat="server" Text="Volver al formulario" />
            </div>
        </td>
    </tr>
</table>s
</asp:Content>
