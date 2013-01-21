<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaHorario.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Solicitudes.ConsultaHorario" %>

<%@ PreviousPageType VirtualPath="~/Solicitudes/frmSolicitud.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Horario de Instalacion</h1>

    <h3><asp:Label ID="txt_inst" runat="server" Text="_instalacion"></asp:Label></h3>
    <br />
    <br />
    <table>
        <tr>
            <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>

            <td>
            <asp:GridView ID="Grid_Horarios" runat="server" CellPadding="4"                    
                        DataKeyNames="ident"             
                        ForeColor="#333333" GridLines="None" Width="489px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
     
    <br />
    <br />
</asp:Content>
