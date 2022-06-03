<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Begin Page Content -->
    <form runat="server">
        <div class="container-fluid">

            <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">LISTADO PERSONAS</h1>
            <div id="sidebar">
                <div class="toggle-btn">
                    <span>&#9776</span>
                    <ul>
                        <%--<li>
                    <img src="recursos/images/logo.png" alt="Logotipo" />" 
                </li>--%>
                        <li>Clientes</li>
                        <li>Productos</li>
                        <li>Ventas</li>
                        <li>Balance</li>
                    </ul>
                </div>
            </div>

            <!-- DataTales Example -->
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Listado</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered" id="dtDatosPersonal" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>id</th>
                                    <th>Documento</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>Email</th>
                                    <th>Celular</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>

                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th>id</th>
                                    <th>Documento</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>Email</th>
                                    <th>Celular</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>
                                </tr>
                            </tfoot>
                            <tbody>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </div>

        <%--<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@mdo">Open modal for @mdo</button>
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@fat">Open modal for @fat</button>
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap">Open modal for @getbootstrap</button>--%>

        <div class="modal fade" id="ModalDatos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Datos a Editar</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <asp:TextBox ID="txtID" class="form-control" runat="server"></asp:TextBox>

                        <div class="form-group">
                            <label for="txtDocumento" class="col-form-label">Documento</label>
                            <asp:TextBox ID="txtDocumento" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtNombres" class="col-form-label">Nombres</label>
                            <asp:TextBox ID="txtNombres" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtApellidos" class="col-form-label">Apellidos</label>
                            <asp:TextBox ID="txtApellidos" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtTipoEmpleado" class="col-form-label">Tipo Empleado</label>
                            <asp:TextBox ID="txtTipoEmpleado" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail" class="col-form-label">Email</label>
                            <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtClave" class="col-form-label">Clave</label>
                            <asp:TextBox ID="txtClave" class="form-control" runat="server"></asp:TextBox>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Send message</button>
                        <asp:Button ID="btnEditar" class="btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
                       
                    </div>
                </div>
            </div>
        </div>


    </form>
    <script src="recursos/vendor/jquery/jquery.min.js"></script>
    <script src="recursos/js/datosDataTable.js"></script>
</asp:Content>
