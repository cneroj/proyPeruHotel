﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WebConsultarReservas.aspx.cs" Inherits="Web_WebConsultarReservas" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <h2 class="mt-4 mb-2">Reservas por Cliente
      </h2>
   <p>
   <div class="form-group row" id="Div1" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Fecha de Inicio</label>
        <asp:ImageButton ID="btnFecIni" runat="server" ImageUrl="~/Web/imagenes/calendar.png" Height="40" Width="40" />
    <div class="col-sm-3">
         <asp:TextBox ID="txtFecIni" CssClass="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecFin" ErrorMessage="Obligatorio" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFecIni" PopupButtonID="btnFecIni"/>

    </div>
    </div>
        <div class="form-group row" id="Div2" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Fecha de Fin</label>
        <asp:ImageButton ID="btnFecFin" runat="server" ImageUrl="~/Web/imagenes/calendar.png" Height="40" Width="40" />
    <div class="col-sm-3">
         <asp:TextBox ID="txtFecFin" CssClass="form-control" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFecFin" ErrorMessage="Obligatorio" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <cc1:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="txtFecFin" PopupButtonID="btnFecFin"/>
        
    </div>
    </div>
   </p>
    <p>
   <div class="form-group row" id="formPrincipal" runat="server">
        <label for="IdTipo" class="col-sm-3 col-form-label ml-3">Numero Dni</label>
    <div class="col-sm-3">
        <asp:TextBox ID="txtDni" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDni" ErrorMessage="Obligatorio" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="col-sm-2">
        <asp:Button ID="btnConsultar" CssClass="btn btn-warning" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
    </div>
    </div>
        <div class="alert alert-warning" role="alert" id="divRespuesta" runat="server">
               <asp:Label ID="txtResultado" runat="server"></asp:Label>
        </div>
     
   </p>
    <div class="row">
        <div class="col">
            <asp:GridView ID="grvDatos" CssClass="table-sm table-hover" runat="server" AutoGenerateColumns="False" OnRowCommand="grvDatos_RowCommand" >
                <Columns>
                    <asp:BoundField DataField="IdReserva" HeaderText="ID" />
                    <asp:BoundField DataField="ReserFechaReser" DataFormatString="{0:d}" HeaderText="Fec. Reserva" />
                    <asp:BoundField DataField="ReserFechaIngreso" DataFormatString="{0:d}" HeaderText="Fec. Ingreso" />
                    <asp:BoundField DataField="ReserFechaSalida" DataFormatString="{0:d}" HeaderText="Fec. Salida" />
                    <asp:BoundField DataField="CantHab" HeaderText="Cant. Hab. " />
                    <asp:BoundField DataField="CantDias" HeaderText="Cant. Dias" />
                    <asp:BoundField DataField="MonHab" HeaderText="Monto Habi." />
                    <asp:BoundField DataField="MonServicio" HeaderText="Monto Servi." />
                    <asp:BoundField DataField="Total" DataFormatString="{0:n}" HeaderText="Total (S./ )" />
                    <asp:ButtonField Text="Detalle" CommandName="Detalles" HeaderText="Opciones"></asp:ButtonField>
                </Columns>
                <HeaderStyle CssClass="thead-dark" />
            </asp:GridView>
        </div>

    </div>
    <asp:LinkButton ID="btnPopup" runat="server"></asp:LinkButton>
    <cc1:ModalPopupExtender ID="mdDetalle" runat="server" TargetControlID="btnPopup" PopupControlID="Panel1"></cc1:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server" CssClass="Modal d-none">
        <!-- Modal -->
        
            <div class ="CajaModal">
                <div class="row">
                    <div class="col m-auto">
                            <asp:HiddenField ID="hdfAccion" runat="server" />
                            <h1 class="ml-4 mt-4">Detalles</h1>   
                        <hr />                            
                    </div>
                </div>
                <div class="row">
                    <div class="col m-auto">
                        <h4 class="ml-5 mt-3 ml">Habitaciones</h4>
                        <asp:GridView ID="grvHabitaciones" runat="server" AutoGenerateColumns="False" CssClass="ml-5 mt-2 table-sm table-hover table-dark">
                            <Columns>
                                <asp:BoundField DataField="IdHabitacion" HeaderText="ID" />
                                <asp:BoundField DataField="HabiNum" HeaderText="Numero" />
                                <asp:BoundField DataField="TipoNombre" HeaderText="Tipo Habitacion" />
                                <asp:BoundField DataField="TipoPrecio" DataFormatString="{0:n}" HeaderText="Precio (S./ )" />
                            </Columns>
                            <HeaderStyle CssClass="text-warning" />
                        </asp:GridView>
                    </div>
                </div>
                 <div class="row">
                    <div class="col m-auto">
                        <h4 class="ml-5 mt-3">Servicios</h4>
                        
                        <asp:GridView ID="grvServicios" runat="server" AutoGenerateColumns="False" CssClass ="ml-5 table-sm table-hover table-dark">
                            <Columns>
                                <asp:BoundField DataField="IdServicio" HeaderText="ID" />
                                <asp:BoundField DataField="ServiNom" HeaderText="Nombre" />
                                <asp:BoundField DataField="ServiPrecio" DataFormatString="{0:n}" HeaderText="Precio (S/.)" />
                                <asp:BoundField DataField="CantidadServicio" HeaderText="Cantidad" />
                            </Columns>
                            <HeaderStyle CssClass="text-warning" />
                        </asp:GridView>
                        <asp:Label ID="txtResultadoServi" runat="server" Text="" CssClass="ml-5"></asp:Label>
                         <hr />
                    </div>
                </div>
                <div class="row mb-5">
                    
                    <div class="col-10">
                        
                    </div>
               
                    <div class="col-2">
                       
                        <asp:Button ID="btnCerrarModal" runat="server" Text="Cerrar" CssClass="btn btn-dark"/>
                    </div>

                </div>
            </div>
                   
    </asp:Panel>

    <style type="text/css">
    .Modal{
        background-color : #171616ab;
        color : black;
        height : 100%;
        width : 100%;
    }
    .CajaModal{
           position: fixed;
            right: 0;
            left: 0;
            margin: 150px;
            width:800px;
            margin-left : 400px;
            border-radius: 18px;
            background-color : white;
    }
    </style>

</asp:Content>



