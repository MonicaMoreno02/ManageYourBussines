<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Logo</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
     <div id="BlockItemSubMenu">
	<asp:Repeater id="Repeater2" runat="server">
		<ItemTemplate>
			<div class="ItemSubMenu">
				<asp:Literal ID="Imagen" runat="server" /><img src="<%#Eval("imagen") %>" width="200" height="200" /></td></tr><br>
                <asp:Literal ID="nombre" runat="server" /> <%#Eval("nombre") %><br>
                <asp:Literal ID="precio" runat="server" />$ <%#Eval("precio") %><br>
                <asp:Literal ID="material" runat="server" /> <%#Eval("material") %><br>
                <asp:Literal ID="descripcion" runat="server" /> <%#Eval("descripcion") %><br>

			</div>				
		</ItemTemplate>
	</asp:Repeater>


</asp:Content>
