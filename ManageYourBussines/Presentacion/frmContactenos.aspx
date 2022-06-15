<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmContactenos.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmContactenos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>DATOS DE CONTACTO:</h1>
    <p>Duitama: Cra 40 # 24-63 - barrio Camilo Torres </p>
    <p>Números de contacto: 3133658254 </p>
    <p>Email de contacto: muebles.sanjose@gmail.com</p>
   <h2>PREGUNTAS FRECUENTES:</h2> 
    <p>Por favor lea las preguntas antes de escribirnos:</p>
    <div class="accordion">
        <div class="accordion-item">
            <a href="#" class="accordation-title plain-active " aria-expanded="false">
                <button class="toggle">
                    <i class="icon-angle-down">^</i>
                    </button>
                <span>¿Cuales son los gastos de los envios de la tienda online?</span>
                <div class="accordion-inner" style="display:block;">
                <p>
                    Dependiendo del lugar que usted se encuentre se calcula el envío según lo que cobra la empresa de DOMICILIOS, usualmente el costo no supera los $10.000 Pesos y no es inferior a los $3.000.
                </p>
                </div>
            </a>
        </div>
    </div>

</asp:Content>
