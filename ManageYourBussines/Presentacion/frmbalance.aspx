<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmbalance.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmbalance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <title>Registro programadores</title>
  <meta name="viewport" content="width=device-width, initial-scale=1" />

  <!-- Latest compiled and minified CSS -->
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />

  <!-- jQuery library -->
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

  <!-- Latest compiled JavaScript -->
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

  <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

  <link rel="stylesheet" type="text/css" media="screen" href="vista/css/main.css" />
  <script src="vista/js/main.js"></script>


  <div class="container">
    <div class="jumbotron">
      <h1 style="text-align:center">Balance de ventas</h1>
    </div>
  </div>

  <div class="container">
    <div class="col-md-6">

        <asp:Label ID="Label1" runat="server" Text="desde" ></asp:Label>
        <asp:TextBox ID="txtDesde" runat="server"  type="date"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="hasta"></asp:Label>
        <asp:TextBox ID="txthasta" runat="server" type="date"></asp:TextBox>
          <asp:Button ID="btnfiltro" runat="server" Text="buscar" OnClick="btnfiltro_Click" />
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>
      <asp:GridView ID="gvBalance" runat="server" AutoGenerateColumns="False"  class="table-primary" Width="608px" OnRowCommand="gvBalance_RowCommand" >

      <Columns>
                           <asp:BoundField DataField="#" HeaderText="#">
                           <ControlStyle Width="10px" />
                           <ItemStyle Width="10px" />
                           </asp:BoundField>
                           <asp:BoundField DataField="idVenta" HeaderText="idVenta" />
                           <asp:BoundField DataField="fechaVenta" HeaderText="fechaVenta" />
                           <asp:BoundField DataField="codigoVenta" HeaderText="codigoVenta" />
                           <asp:BoundField DataField="totalVenta" HeaderText="totalVenta" />
                           <asp:ButtonField ButtonType="Button" CommandName="detalles" Text="detalles" />
                       
                       </Columns>
    </asp:GridView>
                     </ContentTemplate>
           </asp:UpdatePanel>
   
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="excel" cssclass="btn btn-success" />

    </div>
        <div class="col-md-1">
   
  
</div>
    
          
           <asp:UpdatePanel ID="UpdatePanel2" runat="server">
               <ContentTemplate>
    <div class="col-md-5">
        <br />
         <br />
     <asp:GridView ID="gvDetalles"  class="table-info"  runat="server"></asp:GridView>
      </ContentTemplate>
           </asp:UpdatePanel>
</div>

     </div>

   
          
</asp:Content>
