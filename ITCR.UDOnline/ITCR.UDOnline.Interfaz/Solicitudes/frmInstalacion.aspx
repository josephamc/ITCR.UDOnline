<%@ Page Title="Instalación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmInstalacion.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Solicitudes.frmInstalacion" %>

<%@ PreviousPageType VirtualPath="~/Solicitudes/frmMostrarInstalaciones.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Información Instalación Deportiva</h2>
    <br />
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../images/ImgND2.png" alt=""/>
    </div>
    <br />
    <div>
        <table>
            <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Identificacion:   "></asp:Label></td>
            <td><asp:label ID="txt_id" runat="server" Width="300px" ></asp:label></td>
            </tr>

            <tr>
            <td><asp:Label ID="nombre2" runat="server" Text="Nombre de la Instalacion:   "></asp:Label></td>
            <td><asp:label ID="txt_nombre2" runat="server" Width="300px" ></asp:label></td>
            </tr>

            <tr>
            <td><asp:Label ID="descripcion2" runat="server" Text="Descripcion:   "></asp:Label></td>
            <td><textarea id="txt_descripcion2" cols="75" rows="5" runat="server" readonly="readonly"></textarea></td>
            </tr>

            <tr>
            <td><asp:Label ID="medidas2" runat="server" Text="Medidas de la Instalacion:   "></asp:Label></td>
            <td><asp:label ID="txt_medidas2" runat="server" Width="300px" ></asp:label></td>
          
            </tr>
            
            <tr>
            <td><asp:Label ID="reglamento2" runat="server" Text="Reglamento de Uso:   "></asp:Label></td>
            <td><textarea id="txt_reglamento2" cols="75" rows="8" runat="server" readonly="readonly" ></textarea></td>
            </tr>
            
            <tr>
            <td><asp:Label ID="costos2" runat="server" Text="Costos (por hora o por actividad):"></asp:Label></td>
             <td><asp:label ID="txt_costos2" runat="server" Width="300px" ></asp:label></td>
            </tr>
            
            <tr>
            <td><asp:Label ID="comentarios2" runat="server" Text="Comentarios Adicionales:   "></asp:Label></td>
            <td><textarea id="txt_comentarios2" cols="75" rows="2" runat="server" 
                    readonly="readonly"></textarea></td>
            </tr>
        </table>
        </div>
        <br />
        <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_CrearSolicitud" runat="server" 
    Text="Crear Solicitud" CssClass="btn" onclick="btn_CrearSolicitud_Click" />
        &nbsp;
</asp:Content>
