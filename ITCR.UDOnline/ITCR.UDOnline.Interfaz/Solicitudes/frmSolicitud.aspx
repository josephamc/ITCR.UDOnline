<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmSolicitud.aspx.cs" Inherits="ITCR.UDOnline.Interfaz.Solicitudes.frmSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #txt_descripcionevento
        {
            width: 559px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Formulario de Solicitud de Instalación Deportiva</h2>
    <br />    
    <br />
    <div>
        <table>
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_nombre" runat="server" Text="Nombre de la Instalación:" 
                        style="font-weight: 700"></asp:Label></td>
                         <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txt_nombreInstalacion" runat="server"  readonly="true" Width="227px"></asp:TextBox> </td>
                        
            </tr>

         
        </table>
        <br />
        <table>
            <tr>
              

                <td><table>
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="lb_Fecha1" runat="server" Text="Fecha Inicio:" 
                                style="font-weight: 700"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        <td><asp:TextBox ID="txt_FechaInicio" runat="server"  Width="227px"></asp:TextBox> </td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_FechaInicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>                                                                         
                        
                        <td>
                        
                        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                           </ajaxToolkit:ToolkitScriptManager>
                            <ajaxToolkit:CalendarExtender 
                          ID="caldExtender" TargetControlID="txt_FechaInicio" PopupButtonID="imgCalendar" 
                                    runat="server" Format="yyyy-MM-dd">
                           </ajaxToolkit:CalendarExtender>
                                <img id="imgCalendar" alt="" src="../images/date.png" />
                                 <asp:RegularExpressionValidator ID="DateValidator1" runat="server" ControlToValidate="txt_FechaInicio"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 2012-12-31" ValidationExpression="((19|20)\d\d)[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
            
                    <tr>
                        <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td><asp:Label ID="Label1" runat="server" Text="Fecha Fin:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:TextBox ID="txt_FechaFin" runat="server" Width="227px"></asp:TextBox> </td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_FechaFin" ErrorMessage="*"></asp:RequiredFieldValidator></td>                                                                         
                         
                            <td>

                             <ajaxToolkit:CalendarExtender ID="CalendarExtender1" TargetControlID="txt_FechaFin" PopupButtonID="imgCalendar2" 
                                    runat="server" Format="yyyy-MM-dd">
                             </ajaxToolkit:CalendarExtender>
                              <img id="imgCalendar2"  alt="" src="../images/date.png" />
                              <asp:RegularExpressionValidator ID="DateValidator2" runat="server" ControlToValidate="txt_FechaFin"  ErrorMessage="Fecha inválida. Ingrese la fecha en un formato adecuado, ejemplo: 2012-12-31" ValidationExpression="((19|20)\d\d)[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>

                        </td>
                    </tr>
                </table>

                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" 
                        Text="Formato de Fecha yyyy-MM-dd , ejemplo: 2012-12-31" 
                        style="font-style: italic"></asp:Label>
                    
                    </div>

                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;

                <table>
               
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:Label ID="hra_inicio" runat="server" Text="Hora Inicio:" 
                            style="font-weight: 700"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Inicio" runat="server" Width="90px"></asp:TextBox></td>
                    <td><asp:DropDownList ID="ddlAmPm1" runat="server">
                       <asp:ListItem Selected="True">AM</asp:ListItem>
                       <asp:ListItem Selected="False">PM</asp:ListItem>
                       <asp:ListItem Selected="False">MD</asp:ListItem>
                    </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_Inicio" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="TimeValidator1" runat="server" ControlToValidate="txt_Inicio"  ErrorMessage="Hora inválida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(1[0-2]|[1-9]):[0-5][0-9]$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                    <td>&nbsp;</td>
                </tr>

                <tr>            
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td><asp:Label ID="hra_fin" runat="server" Text="Hora Fin:" 
                            style="font-weight: 700"></asp:Label></td>
                    <td><asp:TextBox ID="txt_Fin" runat="server" Width="90px"></asp:TextBox></td>
                    <td><asp:DropDownList ID="ddlAmPm2" runat="server">
                       <asp:ListItem Selected="True">AM</asp:ListItem>
                       <asp:ListItem Selected="False">PM</asp:ListItem>
                       <asp:ListItem Selected="False">MD</asp:ListItem>
                    </asp:DropDownList></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Fin" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="TimeValidator2" runat="server" ControlToValidate="txt_Fin"  ErrorMessage="Hora inválida. Ingrese la hora en un formato adecuado, ejemplo: 12:30 o 5:00" ValidationExpression="^(1[0-2]|[1-9]):[0-5][0-9]$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                </tr>  
                </table>

                <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label 
                    ID="nota" runat="server" Text="Formato de Hora= hh:mm, ejemplo: 6:45" 
                    style="font-style: italic"></asp:Label>
                    <br />
                 </div>
                
                </td>
            </tr>        
        </table>
    </div>
    <br />
    <table>
            <tr>
                
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_solicitante" runat="server" Text="Institución o grupo Solicitante*:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_Solicitante" runat="server" Width="227px"></asp:TextBox> </td>
                   <td><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox_Solicitante" ErrorMessage="Esta campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="ValidaSolicitante" runat="server" ControlToValidate="TextBox_Solicitante"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>

                <td><asp:Label ID="lb_responsable" runat="server" Text="Persona Responsable:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_responsable" runat="server" Width="227px"></asp:TextBox> </td>
                  <td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox_responsable" ErrorMessage="Esta campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="ValidaResponsable" runat="server" ControlToValidate="TextBox_responsable"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>

            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_identificacion" runat="server" Text="Carné o Cédula:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_identificacion" runat="server" Width="227px"></asp:TextBox> </td>
                   <td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox_identificacion" ErrorMessage="Esta campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="ValidaIdentificacion" runat="server" ControlToValidate="TextBox_identificacion"  ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
            </tr>

            <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="lb_tipoUsuario" runat="server" Text="Tipo Usuario:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:DropDownList ID="DropDownList1" runat="server">
                           <asp:ListItem Selected="True">Estudiante</asp:ListItem>
                           <asp:ListItem Selected="False">Egresado</asp:ListItem>
                           <asp:ListItem Selected="False">Funcionario</asp:ListItem>
                           <asp:ListItem Selected="False">Particular</asp:ListItem>
                        </asp:DropDownList></td>
                       
           </tr>
            
            <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_cantidadh" runat="server" Text="Cantidad de Usuarios Masculinos:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_cantidadh" runat="server" Width="227px"></asp:TextBox> </td>
               <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox_cantidadh" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="NumberValidatorh" runat="server" ControlToValidate="TextBox_cantidadh" ErrorMessage="Número inválido. Ingrese un número válido, ejemplo: 7" ValidationExpression="^\d+$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                        
            </tr>

             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_cantidadm" runat="server" Text="Cantidad de Usuarios Femeninos:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_cantidadm" runat="server" Width="227px"></asp:TextBox> </td>
               <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox_cantidadm" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="NumberValidatorm" runat="server" ControlToValidate="TextBox_cantidadm" ErrorMessage="Número inválido. Ingrese un número válido, ejemplo: 7" ValidationExpression="^\d+$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                        
            </tr>


             


    </table>
    <br />
    <table>
             <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_uso" runat="server" Text="Razón de uso:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="txt_razonUso" cols= "75" rows="7" runat="server"></textarea></td>
                 <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_razonUso" ErrorMessage="Esta campo no puede ser vacio" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="ValidaRazonUso" runat="server" ControlToValidate="txt_razonUso" Display="Dynamic" ErrorMessage="*" ValidationExpression="^[A-Z0-9 a-z]*" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
            </tr>

              <tr>
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_involucradas" runat="server" Text="Personas Involucradas:" 
                        style="font-weight: 700"></asp:Label></td>
                <td><textarea id="Textarea_involucradas" cols= "75" rows="7" runat="server"></textarea></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Textarea_involucradas" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="InvolucradasValidator" runat="server" ControlToValidate="Textarea_involucradas" Display="Dynamic" ErrorMessage="Error en el formato, debe ingresar los involucrados de la siguiente forma: persona1, persona2, persona3, ...." ValidationExpression="^[A-Z a-z]*[, A-Z a-z]*[A-Z a-z]$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
            </tr>
            </table>

            <br />
            <br />
            <table>
            <tr>
                
                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label ID="lb_correo" runat="server" Text="Correo Electrónico:" 
                        style="font-weight: 700"></asp:Label></td>
                  <td><asp:TextBox ID="TextBox_correo" runat="server" Width="227px"></asp:TextBox> </td>
                   <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox_correo" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="TextBox_correo" Display="Dynamic" ErrorMessage="Correo electrónico inválido. Ingrese el correo en un formato adecuado, ejemplo: estudiantec@itcr.com" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$" EnableClientScript="False" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
            </tr>

             <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                        <td><asp:Label ID="lb_tipoSolicitud" runat="server" Text="Tipo Solicitud:" 
                                style="font-weight: 700"></asp:Label></td>
                        <td><asp:DropDownList ID="DropDownList2" runat="server">
                           <asp:ListItem Selected="True">Prestamo</asp:ListItem>
                           <asp:ListItem Selected="False">Alquiler</asp:ListItem>
                        </asp:DropDownList></td>
                       
             </tr>

    </table>
        <p>Nota: Los campos con * son opcionales <br />
        Las personas involucradas deben ser ingresadas de la forma Nombre completo persona1, nombre completo persona2, ......
        </p>

    <div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        
    </div>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="boton_enviar_solicitud" runat="server" Text="Enviar Solicitud" 
            onclick="boton_enviar_solicitud_Click" Height="38px" Width="215px" />
    <br />
    <br />
</asp:Content>
