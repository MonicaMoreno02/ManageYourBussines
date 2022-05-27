<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmpleadoss.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleadoss" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="about_section layout_padding">
           <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>--%>
                   <asp:GridView ID="gvemple" runat="server" AutoGenerateColumns="False" class="table table-dark table-striped" OnRowCommand="gvemple_RowCommand1" >
                       <Columns>
                           <asp:BoundField DataField="#" HeaderText="#">
                           <ControlStyle Width="10px" />
                           <ItemStyle Width="10px" />
                           </asp:BoundField>
                               
                           <asp:BoundField DataField="Documento" HeaderText="nombre" />
                           <asp:BoundField DataField="Nombres" HeaderText="describcion" />
                           <asp:BoundField DataField="Apellidos" HeaderText="precio" />
                           <asp:BoundField DataField="Tipo empleado" HeaderText="cantidad" />
                            <asp:BoundField DataField="Porcentaje pensión" HeaderText="cantidad" />
                            <asp:BoundField DataField="Porcentaje salud" HeaderText="cantidad" />
                          
                           <asp:BoundField DataField="cantidadstock" HeaderText="cantidadstock" />
                           <asp:BoundField DataField="total" HeaderText="total" />
                           <asp:ButtonField ButtonType="Button" CommandName="eliminar" Text="eliminar" />
                       </Columns>
                   </asp:GridView>
              <%-- </ContentTemplate>
           </asp:UpdatePanel>--%>
   

      </section>

</asp:Content>
