<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmpleado.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>


            <%-- gridwied del carrito --%>
  <!-- about section -->
  <section class="about_section layout_padding">
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>
                   <asp:GridView ID="gvCar" runat="server" AutoGenerateColumns="False" class="table table-dark table-striped" OnRowCommand="gvCar_RowCommand" >
                       <Columns>
                           <asp:BoundField DataField="#" HeaderText="#">
                           <ControlStyle Width="10px" />
                           <ItemStyle Width="10px" />
                           </asp:BoundField>
                           <asp:ImageField DataImageUrlField="imagen" HeaderText="imagen">
                               <ControlStyle Height="60px" Width="60px" />
                               <ItemStyle Height="100px" Width="100px" />
                           </asp:ImageField>
                           <asp:BoundField DataField="nombre" HeaderText="nombre" />
                           <asp:BoundField DataField="describcion" HeaderText="describcion" />
                           <asp:BoundField DataField="precio" HeaderText="precio" />
                           <asp:BoundField DataField="cantidad" HeaderText="cantidad" />
                           <asp:ButtonField ButtonType="Button" CommandName="aumentar" Text="+" />
                           <asp:ButtonField ButtonType="Button" CommandName="disminuir" Text="-" />
                           <asp:BoundField DataField="cantidadstock" HeaderText="cantidadstock" />
                           <asp:BoundField DataField="total" HeaderText="total" />
                           <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="eliminar" />
                       </Columns>
                   </asp:GridView>
               </ContentTemplate>
           </asp:UpdatePanel>
   

      </section>

    </h1>
</asp:Content>
