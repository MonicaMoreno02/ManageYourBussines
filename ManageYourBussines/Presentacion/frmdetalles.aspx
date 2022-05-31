<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmdetalles.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmdetalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
  <div class="container-fluid">
  <img src="recursos/images/icono3.png" widt="20" height="20" />
       <a class="navbar-brand" href="#">Muebles San José</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="mynavbar">
      <ul class="navbar-nav me-auto">
        <li class="nav-item">
          <a class="nav-link" href="frmHome.aspx">Home</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
<br />
   

  <div id="BlockItemSubMenu2">
	
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
			<div class="ItemSubMenu2">
                
               <%-- <asp:Label ID="lblidproducto" runat="server" Text="<%#Eval("idProducto") %>"></asp:Label>--%>

            
         
                 <asp:Label ID="LabelDato" runat="server" Visible="false" Text='<%#Eval("idProducto")%>'> </asp:Label>

				<asp:Literal ID="Imagen" runat="server" /><img src="<%#Eval("imagen") %>" width="190" height="190" /></td></tr><br>
                <asp:Literal ID="nombre" runat="server" /> <%#Eval("nombre") %><br>
                <asp:Literal ID="precio" runat="server" />$ <%#Eval("precio") %><br>
                <asp:Button ID="btnDetalles" runat="server" Text="Detalles:" CssClass="btn btn-success" OnClick="btnDetalles_Click"/>
              <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" ImageUrl="~/Presentacion/recursos/images/anadir-al-carrito (1).png" Width="30px" />
			</div>				
		</ItemTemplate>
        </asp:Repeater>
      </div>



</asp:Content>
