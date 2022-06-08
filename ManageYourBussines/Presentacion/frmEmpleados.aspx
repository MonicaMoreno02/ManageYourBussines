<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
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
                                    <th>Tipo Empleado</th>
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
            <br />
            <br />
            <asp:Button ID="btnListarSeguridad" runat="server" CssClass="btn btn-primary" Text="Button" OnClick="btnListarSeguridad_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <!--PAOLA: tabla de empleados FIN  -->

       <!-- Page Heading -->
      <div class="card card-5">
            <div class="card-heading">
                <h2 class="title">LISTA DE SEGURIDAD SOCIAL</h2>
            </div>
        </div>


        <!--PAOLA: tabla de Seguridad Social -->
        <div class="card shadow mb-4">
            <div class="card-body">
                <div class="table-responsive">
                   
                    <table class="table table-bordered table-dark" id="dtSeguridad" width="100%" cellspacing="0">
                        <thead>
                            <tr>

                                <th>id</th>
                                <th>Porcentaje Pension</th>
                                <th>Porcentaje Salud</th>
                                <th>Salario</th>
                                <th>Año</th>


                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
       
         <!--PAOLA: tabla de Seguridad Social -->

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
                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminar_Click" />
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
                                <div class="form-group">
                                    <label for="txtSeguridadSocial" class="col-form-label">Clave</label>
                                    <asp:TextBox ID="txtSeguridadSocial" class="form-control" runat="server"></asp:TextBox>
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


        <%--PAOLA: Modal para registrar los empleados --%>
        <div class="card card-5">
            <div class="card-heading">
                <h2 class="title">Registrar Empleados</h2>
            </div>
            <div class="card-body">
                <div class="form-row m-b-55">
                    <div class="name">Documento</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5" style="border: thin double #000000; margin: auto; padding: inherit;">
                                <asp:TextBox ID="txtDocumentoRegis" type="text" runat="server" BackColor="#E5E5E5"></asp:TextBox>
                                <br />
                            </div>
                        </div>
                    </div>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDocumentoRegis" ErrorMessage="Documento invalido" ForeColor="Red" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>

                </div>
                <div class="form-row m-b-55">
                    <div class="name">Nombre</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5" style="border: thin double #000000">
                                <asp:TextBox ID="txtNombreRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5"></asp:TextBox>
                                <br />
                            </div>

                        </div>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Solo letras" ForeColor="Red" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
                </div>

                <div class="form-row m-b-55">
                    <div class="name">Apellido</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5" style="border: thin double #000000">
                                <asp:TextBox ID="txtApellidoRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5"></asp:TextBox>
                            </div>

                        </div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Solo letras" ForeColor="Red" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
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
                            <asp:Label ID="LblTipoEmpleado" runat="server" Text=" " ValidateRequestMode="Enabled"></asp:Label>

                            <div class="select-dropdown">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="form-row m-b-55">
                    <div class="name">Email</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5" style="border: thin double #000000">
                                <asp:TextBox ID="txtEmailRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5"></asp:TextBox>
                            </div>

                        </div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtEmailRegis" ErrorMessage="Email Invalido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                </div>


                <div class="form-row m-b-55">
                    <div class="name">Clave</div>
                    <div class="value">
                        <div class="input-group">
                            <div class="input--style-5" style="border: thin double #000000">
                                <asp:TextBox ID="txtClaveRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5"></asp:TextBox>
                            </div>

                        </div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtNombreRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                </div>


                <asp:Button ID="btnRegistrar" class="btn btn-primary" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" Height="73px" Width="271px" />


                <br />
                <br />
                <br />
                &nbsp;<div>
                </div>

            </div>
        </div>
        <%--PAOLA: Modal para registrar los empleados --%>
    </form>


    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>


    <script src="recursos/js/JavaEmpleados.js"></script>
    <script src="recursos/js/JavaSeguridad.js"></script>

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
