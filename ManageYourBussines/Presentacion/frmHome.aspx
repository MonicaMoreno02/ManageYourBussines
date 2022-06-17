<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmHome.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>pagina de clientes</h1>
                                        
    <asp:Label ForeColor="White" ID="lblEmpleado" runat="server"></asp:Label>
    
    
<%--                                                <asp:Label ID="lblUsuario1" runat="server" class="nav-link dropdown-toggle fa fa-user me-3" data-bs-toggle="dropdown" Text=""></asp:Label>--%>
    
   <%-- 
  datos personales y editar datos de  clientes --%>
                                                   
 <%-- <div class="user_option">

                <div class="dropdown">
                    <button type="button" class="btn btn-dark  dropdown-toggle" data-bs-toggle="dropdown">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        <i>Mi perfil</i>
                    </button>
                    <ul class="dropdown-menu">
                        <%--<li><a class="dropdown-item" href="#">Datos Personales</a>--%>
                        <!-- Button to Open the Modal -->
                                      <%--<%--  <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" class="dropdown-item" onClick="btnCerrarSesion_Click1" />


                        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#ModalDatos">
                       datos Personales
                        </button>
                </div>--%>

                <!-- The Modal -->
             <%--   <div class="modal fade" id="ModalDatos">
                    <div class="modal-dialog">
                        <div class="modal-content">

                            <!-- Modal Header -->
                            <div class="modal-header">
                                <h4 class="modal-title">editar  mis datos</h4>
                                <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
                            </div>

                            <!-- Modal body -->
                            <div class="modal-body">--%>

<%--                                                           <asp:TextBox ID="txtID" class="form-control" runat="server"></asp:TextBox>

                           <label for="documento" class="form-label">Documento:</label>

                            <asp:TextBox ID="txtDocumento" runat="server" Class="form-control" name="uname" required placeholder="Documento " TextMode="Number"></asp:TextBox>
                          <%--  <div class="valid-feedback">Valid.</div>--%>
<%--                            <div class="invalid-feedback">Complete este campo.</div>--%>







                    <%--        <label for="nombres" class="form-label">Nombres:</label>

                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" name="uname" required placeholder="Nombres" TextMode="MultiLine"></asp:TextBox>
                      --%>     <%-- <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>--%>



<%--                            <label for="apellidos" class="form-label">Apellidos:</label>

                            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" name="uname" required placeholder="Apellidos: " TextMode="MultiLine"></asp:TextBox>
                         --%>  <%-- <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>--%>



                           <%-- <label for="telefono " class="form-label">Telefono:</label>

                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" name="uname" required placeholder="telefono " TextMode="Number" AutoCompleteType="Cellular"></asp:TextBox>
                           --%> <%--<div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>--%>



<%--                            <label for="direccion " class="form-label">Direccion :</label>

                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" name="uname" required placeholder="Direccion " TextMode="MultiLine"></asp:TextBox>
                          --%>  <%--<div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>--%>



<%--                            <label for="email " class="form-label">Email :</label>

                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" name="uname" required placeholder="Email " TextMode="Email" AutoCompleteType="Email"></asp:TextBox>
                         --%>   <%--<div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>

                              <label for="clave " class="form-label">Clave :</label>

                            ><asp:TextBox ID="txtClave" runat="server" CssClass="form-control" name="uname"  placeholder="clave  " TextMode="Password"></asp:TextBox>
                         <%--<div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>
                                  <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                            </div>
                            <asp:Button ID="btnEditar" runat="server" Text="editar"/>



                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
                            </div>

                        </div>
                    </div>
                </div>--%>--%>

<%--      label de sesion para  los clientes --%>
      <%--<asp:Label ForeColor="White" ID="lblnombres" runat="server"></asp:Label>
                            <br />
            <asp:Label ForeColor="White" ID="lblApellidos" runat="server"></asp:Label>
            --%>

                                   


                                </ul>
            </div>
        <script src="recursos/js/Datos.js"></script>
</asp:Content>
