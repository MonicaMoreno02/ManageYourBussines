<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmTareasEmple.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTareasEmple" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <img src="recursos/images/icono3.png" widt="20" height="20"/>
    <a class="navbar-brand" href="#">Muebles san José</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="../index.aspx">Inicio</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <br />
    <br />
  
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="btnpendiente" runat="server" OnClick="btnpendiente_Click" Text="pendiente" cssclass="btn btn-danger"/>
            <asp:Button ID="btnprogreso" runat="server" OnClick="btnprogreso_Click" Text="progreso" cssclass="btn btn-warning"/>
            <asp:Button ID="btnterminado" runat="server" OnClick="btnterminado_Click" Text="terminado" cssclass="btn btn-success" />
            <asp:GridView ID="gvtareas" runat="server" OnRowCommand="gvtareas_RowCommand" class="table table-bordered">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="aceptar" Text="aceptar tareas" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="gvprogreso" runat="server" AutoGenerateColumns="False" OnRowCommand="gvprogreso_RowCommand" class="table table-bordered">
                <Columns>
                    <asp:BoundField DataField="idEmpleado" HeaderText="idEmpleado" />
                    <asp:BoundField DataField="idTareas" HeaderText="idTareas" />
                    <asp:BoundField DataField="nombreTarea" HeaderText="nombreTarea" />
                    <asp:BoundField DataField="descripcionTarea" HeaderText="descripcionTarea" />
                    <asp:BoundField DataField="estado" HeaderText="estado" />
                    <asp:BoundField DataField="fechaInicio" HeaderText="fechaInicio" />
                    <asp:BoundField DataField="fechaTerminacion" HeaderText="fechaTerminacion" />
                    <asp:ButtonField ButtonType="Button" CommandName="terminar" Text="tarea terminada" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="gvmateriales" runat="server" AutoGenerateColumns="False" OnRowCommand="gvmateriales_RowCommand" Width="429px" class="table table-bordered" >
                <Columns>
                    <asp:BoundField DataField="#" HeaderText="#" />
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" />
                    <asp:BoundField DataField="precio" HeaderText="precio" />
                    <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
                    <asp:ButtonField ButtonType="Button" CommandName="sumar" Text="+" />
                    <asp:ButtonField ButtonType="Button" CommandName="restar" Text="-" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="gvterminar" runat="server" class="table table-bordered">
                <Columns>
                    <asp:BoundField DataField="idEmpleado" HeaderText="idEmpleado" />
                    <asp:BoundField DataField="idTareas" HeaderText="idTareas" />
                    <asp:BoundField DataField="nombreTarea" HeaderText="nombreTarea" />
                    <asp:BoundField DataField="descripcionTarea" HeaderText="descripcionTarea" />
                    <asp:BoundField DataField="estado" HeaderText="estado" />
                    <asp:BoundField DataField="fechaInicio" HeaderText="fechaInicio" />
                    <asp:BoundField DataField="fechaTerminacion" HeaderText="fechaTerminacion" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="lbidtarea" runat="server" Text="Label" Visible="false"></asp:Label>
            <asp:Label ID="lbpocicion" runat="server" Text="Label" Visible="false"></asp:Label>
            <br /> 
            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="aceptar" CssClass="btn btn-dark" />
     
        </ContentTemplate>
    </asp:UpdatePanel>
    </asp:Content>
