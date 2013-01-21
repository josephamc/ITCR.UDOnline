<%@ Page Title="Instalación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmInstalacion.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Solicitudes.frmInstalacion" %>

<%@ PreviousPageType VirtualPath="~/Solicitudes/frmMostrarInstalaciones.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
    <style type="text/css">
        .style1
        {
            width: 749px;
        }
        .style2
        {
            width: 300px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Información Instalación Deportiva</h2>
    <br />
    <div id="imglogo">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <img src="../images/InsIMG.jpg" alt="" id="img_VISUALIZACION" runat="server" width="894" height="234"/>
    </div>
    <br />
    <div>
        <table>
        <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; </td>
                <td class="style1">
                   <fieldset style="width: 700px">
                    <table>
                    <tr>
                    <td class="style2"><h4><asp:Label ID="Label1" runat="server" Text="Identificacion:   "></asp:Label></h4></td>
                    <td><p><asp:label ID="txt_id" runat="server" Width="300px" ></asp:label></p></td>
                    </tr>

                    <tr><td class="style2"><br /></td></tr>

                    <tr>
                    <td class="style2"><h4><asp:Label ID="nombre2" runat="server" Text="Nombre de la Instalacion:   "></asp:Label></h4></td>
                    <td><asp:label ID="txt_nombre2" runat="server" Width="300px" ></asp:label></td>
                    </tr>

                    <tr><td class="style2"><br /></td></tr>

                    <tr>
                    <td class="style2"><h4><asp:Label ID="descripcion2" runat="server" Text="Descripcion:   "></asp:Label></h4></td>
                    <td>
                        <asp:Label ID="txt_descripcion22" runat="server" Text=""></asp:Label></td>
                    </tr>

                    <tr><td class="style2"><br /></td></tr>

                    <tr>
                    <td class="style2"><h4><asp:Label ID="medidas2" runat="server" Text="Medidas de la Instalacion:   "></asp:Label></h4></td>
                    <td><asp:label ID="txt_medidas2" runat="server" Width="300px" ></asp:label></td>          
                    </tr>

                    <tr><td class="style2"><br /></td></tr>
            
                    <tr>
                    <td class="style2"><h4><asp:Label ID="reglamento2" runat="server" Text="Reglamento de Uso:   "></asp:Label></h4></td>
                    <td>
                        <asp:Label ID="txt_reglamento22" runat="server" Text="Label"></asp:Label></td>
                    </tr>

                    <tr><td class="style2"><br /></td></tr>
            
                    <tr>
                    <td class="style2"><h4><asp:Label ID="costos2" runat="server" Text="Costos (por hora o por actividad):"></asp:Label></h4></td>
                     <td><asp:label ID="txt_costos2" runat="server" Width="300px" ></asp:label></td>
                    </tr>

                    <tr><td class="style2"><br /></td></tr>
            
                    <tr>
                    <td class="style2"><h4><asp:Label ID="comentarios2" runat="server" Text="Comentarios Adicionales:   "></asp:Label></h4></td>
                    <td>
                        <asp:Label ID="txt_comentarios22" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                </table>
                </fieldset></td>
        </tr>
        </table>
    </div>
    <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="btn_CrearSolicitud" runat="server" 
    Text="Crear Solicitud" CssClass="btn" onclick="btn_CrearSolicitud_Click" 
        Height="45px" Width="162px" />
        &nbsp;
    <br />
    <br />
</asp:Content>
