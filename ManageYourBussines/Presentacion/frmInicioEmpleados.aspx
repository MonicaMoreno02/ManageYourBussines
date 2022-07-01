<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site3.Master" AutoEventWireup="true" CodeBehind="frmInicioEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmInicioEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <%--<asp:Button CssClass="" ID="BtnInicio" runat="server" Text="INICIO" Height="75px" OnClick="BtnInicio_Click" Width="150px" BackColor="White" BorderColor="#FFFFCC" BorderStyle="None" BorderWidth="3px" Font-Names="Century Gothic" Font-Size="20px" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" />--%>


        <asp:ImageButton ID="ImageButton1" runat="server" Height="56px" ImageAlign="Top" Width="83px" ImageUrl="recursos/images/atrasE.png" OnClick="ImageButton1_Click" />


        <h1 class="title" style="padding: 25px 17px 25px 17px; margin: 15px; font-family: 'Calisto MT'; font-size: 54px; font-style: oblique; border-style: inherit; color: #000000; background-repeat: no-repeat; background-attachment: fixed; background-image: none; text-transform: capitalize;" aria-checked="undefined">&nbsp;&nbsp;BIENVENIDO VENDEDOR</h1>
        <br />


        <br />


        <br />
        <br />
        <br />

        <ul>
            <li>
                <a class="btn link" href="frmClientesVendedor.aspx">
                    <div class="btn from-top">
                        Clientes
                   
                    </div>
                </a>
            </li>
            <li>
                <a class="btn link" href="frmProductosVendedor.aspx">
                    <div class="btn from-left">
                        Productos    
                   
                    </div>
                </a>
            </li>

        </ul>

    </form>

    <%-- Recursos para btn en Admin --%>

    <link href="recursos/css/stylebuttonsE.css" rel="stylesheet" />
</asp:Content>
