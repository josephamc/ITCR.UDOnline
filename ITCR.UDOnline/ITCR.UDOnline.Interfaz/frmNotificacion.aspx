<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNotificacion.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.frmNotificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td>
            <div id="imglogo">
                	<img src="images/check.jpg" alt=""/>
            </div>
        </td>
        <td>
            <div>
                <h1> ¡ Realizacion Exitosa ! </h1>
                <h3>
                    <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
                </h3>
                <br />
                <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Default.aspx">Volver al inicio</asp:HyperLink>
            </div>
        </td>
    </tr>
</table>s
</asp:Content>
