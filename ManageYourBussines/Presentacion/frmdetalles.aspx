<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmdetalles.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmdetalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
