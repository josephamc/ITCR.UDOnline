﻿<%@ Page Title="Instalaciones actuales" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMostrarInstalaciones.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Solicitudes.frmMostrarInstalaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 299px;
        }
        .style2
        {
            width: 330px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="style2">
                <div id="imglogo">
                	    <img src="../images/Solicitar01.jpg" height="526px" alt=""/>
                </div>
            </td>
            <td>
            <div style="height: 584px">
                <h2>Instalaciones Deportivas</h2>
           
                Seleccione la instalación deportiva que desea solicitar:
                <br />
                <br />
                <div>

                    <asp:GridView ID="Grid_Instalaciones2" runat="server" CellPadding="4" 
                        ForeColor="#333333" GridLines="None" Width="646px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField EditText="Mostrar" ShowCancelButton="False" 
                                ShowEditButton="True" ButtonType="Image" 
                                EditImageUrl="~/images/see_info.png" >
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:CommandField>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle HorizontalAlign="Center" BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>

                </div>
            </div>
            </td>
        </tr>
    </table>
</asp:Content>
