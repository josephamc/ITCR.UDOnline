<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmErrorFechas.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.frmErrorFechas" %>
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
                    Debe revisar la fecha u hora solicitada debido a que se ha encontrado un error al tratar de realizar la solicitud
                </h3>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_redirect" runat="server" Text="Volver al formulario" />
            </div>
        </td>
    </tr>
</table>s
</asp:Content>
