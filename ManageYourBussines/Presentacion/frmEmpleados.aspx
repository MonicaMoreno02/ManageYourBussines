<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">

        <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
            <div class="container-fluid">
                <img src="recursos/images/icono3.png" widt="20" height="20" />
                <a class="navbar-brand" >Muebles San José</a>

                <ul class="navbar-nav me-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="frmAdmin.aspx">INICIO</a>
                    </li>
                </ul>

            </div>
        </nav>

        <div class="container-fluid">
            <!-- Page Heading -->
            <div class="card card-5">
                <div class="card-heading">
                    <h2 class="title">LISTADO EMPLEADOS</h2>
                </div>
            </div>


            <!--PAOLA: tabla de empleados -->
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
                                    <th>Tipo Empleado</th>.
                                    <th>Email</th>
                                    <th>Clave</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>


                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!--PAOLA: tabla de empleados FIN  -->


        <%--PAOLA: modal para eliminar--%>
        <div class="modal fade" id="ModalEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="modal-content">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
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
                                </div>
                            </div>
                            <div class="modal-footer">
                               <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger"  OnClick="btnEliminar_Click"/>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnEliminar" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>

            </div>
        </div>
        <%--PAOLA: modal para eliminar FIN --%>




        <%--PAOLA: Modal para editar empleados--%>

        <div class="modal fade" id="ModalEditarEmpleado" data-backdrop="static" data-keyboard="false" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
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

                            </div>
                            <div class="modal-footer">
                                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" CssClass="btn btn-primary" />

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnEditar" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <%--PAOLA: Modal para editar empleados FIN--%>

        <asp:Button ID="btnRegistrarE" runat="server" cssClass="btn-primary" Text="REGISTRE AQUI UN NUEVO EMPLEADO" OnClick="btnRegistrarE_Click" Font-Names="Britannic Bold" Height="52px"/>
      
    </form>


    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>


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
