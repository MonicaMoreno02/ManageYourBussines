<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <div class="container-fluid">
            <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">LISTADO EMPLEADOS</h1>


            <!-- DataTales Example -->
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-dark" id="dtEmpleado" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>id</th>
                                    <th>Documento</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>Tipo Empleado</th>
                                    <th>Email</th>
                                    <th>Clave</th>
                                    <th>Seguridad social</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>


                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>

        </div>

     <%--   modal para eliminar--%>
         <div class="modal fade" id="ModalEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalabel">Eliminar datos del empleado</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <div class="table-responsive">

                                <asp:TextBox ID="txtIDEmpleadoB" runat="server"></asp:TextBox>
                                <h2>¿Borrar datos del empleado seleccionado?</h2>
                                <br />
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminar_Click"/>
                            </div>                           
                        </div>
                    </div>
                </div>
             </div>

        <%--Modal para editar empleados--%>

        <div class="modal fade" id="ModalEditarEmpleado" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Datos a Editar</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <asp:TextBox ID="txtIDEmpleado" class="form-control" runat="server"></asp:TextBox>

                        <div class="form-group">
                            <label for="txtDocumento" class="col-form-label">Documento</label>
                            <asp:TextBox ID="txtDocumento" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtNombreEmpleado" class="col-form-label">Nombres</label>
                            <asp:TextBox ID="txtNombreEmpleado" class="form-control" runat="server"></asp:TextBox>
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
                        <div class="form-group">
                            <label for="txtSeguridadSocial" class="col-form-label">Clave</label>
                            <asp:TextBox ID="txtSeguridadSocial" class="form-control" runat="server"></asp:TextBox>
                        </div>


                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnEditar"  runat="server" Text="Editar" OnClick="btnEditar_Click" CssClass="btn btn-primary" />

                    </div>
                </div>
            </div>
        </div>


        <%--   Modal para registrar los empleados --%>
        <%--        <div class="modal fade" id="ModalRegistro" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">--%>
        <%-- <div class="page-wrapper bg-gra-03 p-t-45 p-b-50">
            <div class="wrapper wrapper--w790">--%>
        <div class="card card-5">
            <div class="card-heading">
                <h2 class="title">Registrar Empleados</h2>
            </div>
            <div class="card-body">
                <div class="form-row m-b-55">
                    <div class="name">Documento</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtDocumentoRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="form-row m-b-55">
                    <div class="name">Nombre</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtNombreRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>

                <div class="form-row m-b-55">
                    <div class="name">Apellido</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtApellidoRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>


                <div class="form-row">
                    <div class="name">Tipo de Empleado</div>
                    <div class="value">
                        <div class="input-group">
                            
                                    <asp:DropDownList ID="ddlTipoEmpleado" runat="server">
                                        <asp:ListItem>Seleccione...</asp:ListItem>
                                        <asp:ListItem>Vendedor</asp:ListItem>
                                        <asp:ListItem>Productor</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Label ID="LblTipoEmpleado" runat="server" Text=" "></asp:Label>
                               
                                <div class="select-dropdown"></div>
                            </div>
                    </div>
                </div>


                <div class="form-row m-b-55">
                    <div class="name">Email</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtEmailRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>


                <div class="form-row m-b-55">
                    <div class="name">Clave</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtClaveRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>

                 <div class="form-row m-b-55">
                    <div class="name">Seguridad Social</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5">
                                <asp:TextBox ID="txtSeguridadSocialRegis" runat="server"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                </div>

                <br />
                <br />
                <br />
                <div>
                    <asp:Button ID="btnRegistrar" class="btn btn-primary" runat="server" Text="Registrar" OnClick="btnRegistrar_Click"/>
                </div>

            </div>
        </div>

        <%--</div>
        </div>
        </div>--%>
    </form>



    <script src="recursos/js/JavaEmpleados.js"></script>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>

    <script src="recursos/vendor/jquery/jquery.min.js"></script>

    <script src="recursos/vendor/jquery/jquery.min.js"></script>
    <script src="recursos/js/datosDataTable.js"></script>
    <script src="recursos/js/sb-admin-2.min.js"></script>

    <!--Boostrap js-->
    <script src="recursos/js/datatables/jquery.dataTables.min.js"></script>
    <script src="recursos/js/datatables/dataTables.bootstrap4.min.js"></script>
    <script src="recursos/js/demo/datatables-demo.js"></script>



</asp:Content>
