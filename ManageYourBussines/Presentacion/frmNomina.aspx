<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmNomina.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmNomina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="about_section layout_padding">
          
         <h1>Nómina empleados</h1>
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
              
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
       <%-- </ContentTemplate>
           </asp:UpdatePanel>--%>
   

      </section>

</asp:Content>
