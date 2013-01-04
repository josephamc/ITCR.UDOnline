<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmError.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.frmError" %>
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
                    Ya existe alguna reservación previamente aprobada para la instalacion que desea utilizar, en el dia y la hora que indicó
                </h3>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Default.aspx">Volver al inicio</asp:HyperLink>
                
            </div>
        </td>
    </tr>
</table>s
</asp:Content>
