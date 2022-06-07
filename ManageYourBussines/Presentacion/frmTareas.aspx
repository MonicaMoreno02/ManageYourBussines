<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmTareas.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="about_section layout_padding">
           <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>--%>
         <h1>Tareas</h1>
                 <asp:GridView ID="gv" runat="server" class="table table-dark table-striped" OnRowCommand="gv_RowCommand" Width="1784px" >
                   </asp:GridView>
              <%-- </ContentTemplate>
           </asp:UpdatePanel>--%>
   

      </section>
</asp:Content>
