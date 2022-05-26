<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmdetalles.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmdetalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Muebles San José</a>
  </div>
</nav>
<br />
  <div id="BlockItemSubMenu">
	
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
			<div class="ItemSubMenu">

               <%-- <asp:Label ID="lblidproducto" runat="server" Text="<%#Eval("idProducto") %>"></asp:Label>--%>

            
         
                 <asp:Label ID="LabelDato" runat="server" Visible="false" Text='<%#Eval("idProducto")%>'> </asp:Label>

				<asp:Literal ID="Imagen" runat="server" /><img src="<%#Eval("imagen") %>" width="200" height="200" /></td></tr><br>
                <asp:Literal ID="nombre" runat="server" /> <%#Eval("nombre") %><br>
                <asp:Literal ID="precio" runat="server" />$ <%#Eval("precio") %><br>
                <asp:Button ID="btnDetalles" runat="server" Text="Detalles:" CssClass="btn btn-success" OnClick="btnDetalles_Click"/>
              
			</div>				
		</ItemTemplate>
        </asp:Repeater>
      </div>



</asp:Content>
