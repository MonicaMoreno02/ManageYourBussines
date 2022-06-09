<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmAbout.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmAbout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>pagina de empleados </h1>
                                                <asp:Label ID="lblUsuario" runat="server" class="nav-link dropdown-toggle fa fa-user me-3" data-bs-toggle="dropdown" Text=""></asp:Label>
          <div class="user_option">

                <div class="dropdown">
                    <button type="button" class="btn btn-dark  dropdown-toggle" data-bs-toggle="dropdown">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        <i>Mi perfil</i>
                    </button>
                    <ul class="dropdown-menu">
                        <%--<li><a class="dropdown-item" href="#">Datos Personales</a>--%>
                        <!-- Button to Open the Modal -->
                                        <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesión" class="dropdown-item" onClick="btnCerrarSesion_Click" />


                        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#myModal">
                            Open modal
                        </button>
                </div>

                <!-- The Modal -->
                <div class="modal fade" id="myModal">
                    <div class="modal-dialog">
                        <div class="modal-content">

                            <!-- Modal Header -->
                            <div class="modal-header">
                                <h4 class="modal-title">editar  mis datos</h4>
                                <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
                            </div>

                            <!-- Modal body -->
                            <div class="modal-body">
                           <label for="documento" class="form-label">Documento:</label>

                            <asp:TextBox ID="txtDocumento" runat="server" Class="form-control" name="uname" required placeholder="Documento " TextMode="Number"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este campo.</div>







                            <label for="nombres" class="form-label">Nombres:</label>

                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" name="uname" required placeholder="Nombres" TextMode="MultiLine"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>



                            <label for="apellidos" class="form-label">Apellidos:</label>

                            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" name="uname" required placeholder="Apellidos: " TextMode="MultiLine"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>



                            <label for="telefono " class="form-label">Telefono:</label>

                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" name="uname" required placeholder="telefono " TextMode="Number" AutoCompleteType="Cellular"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>



                            <label for="direccion " class="form-label">Direccion :</label>

                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" name="uname" required placeholder="Direccion " TextMode="MultiLine"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>



                            <label for="email " class="form-label">Email :</label>

                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" name="uname" required placeholder="Email " TextMode="Email" AutoCompleteType="Email"></asp:TextBox>
                            <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>

                              <label for="clave " class="form-label">Clave :</label>

                            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" name="uname"  placeholder="clave  " TextMode="Password"></asp:TextBox>
                         <div class="valid-feedback">Valid.</div>
                            <div class="invalid-feedback">Complete este Campo.</div>
                            </div>
                            <asp:Button ID="btnEditar" runat="server" Text="editar" OnClick="btnEditar_Click"/>



                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
                            </div>

                        </div>
                    </div>
                </div>



            

                                   


                                </ul>
            </div>

</asp:Content>
