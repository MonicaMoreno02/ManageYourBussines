<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmTareasEmple.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTareasEmple" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:GridView ID="gvtareas" runat="server" OnRowCommand="gvtareas_RowCommand">
         <Columns>
             <asp:ButtonField ButtonType="Button" CommandName="aceptar" Text="aceptar tareas" />
         </Columns>
     </asp:GridView>

    <asp:GridView ID="gvmateriales" runat="server" AutoGenerateColumns="False" OnRowCommand="gvmateriales_RowCommand">
         <Columns>
               <asp:BoundField DataField="#" HeaderText="#" />
                           <asp:BoundField DataField="id" HeaderText="id" />
                           <asp:BoundField DataField="nombre" HeaderText="nombre" />
                           <asp:BoundField DataField="precio" HeaderText="precio" />
                           <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
            <asp:ButtonField ButtonType="Button" CommandName="sumar" Text="+" />
            <asp:ButtonField ButtonType="Button" Text="-" CommandName="restar" />
              </Columns>
    </asp:GridView>

   
         
       
      <asp:Label ID="lbidtarea" runat="server" Text="Label"></asp:Label>
     <asp:Label ID="lbpocicion" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btnAceptar" runat="server" Text="aceptar" OnClick="btnAceptar_Click" />
</asp:Content>
