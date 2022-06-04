<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
       
        <div class="container-fluid">

            <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">LISTADO PERSONAS</h1>

           
            <!-- DataTales Example -->
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Listado</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered" id="dtEmpleado" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>id</th>
                                    <th>Documento</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>TipoEmpleado</th>
                                    <th>Email</th>
                                    <th>Clave</th>
                                    <th>Acciones</th>
                                   

                                </tr>
                            </thead>

                        </table>
                    </div>
                </div>
            </div>

        </div>

        <%--<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@mdo">Open modal for @mdo</button>
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@fat">Open modal for @fat</button>
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap">Open modal for @getbootstrap</button>--%>

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
                        <div class="form-group">
                            <label for="txtSeguridadSocial" class="col-form-label">Clave</label>
                            <asp:TextBox ID="txtSeguridadSocial" class="form-control" runat="server"></asp:TextBox>
                        </div>


                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Send message</button>
                        <asp:Button ID="btnEditar" class="btn btn-primary" runat="server" Text="Editar" OnClick="btnEditar_Click" />

                    </div>
                </div>
            </div>
        </div>


        <%--   Modal para registrar--%>
        <div class="modal fade" id="ModalRegistro" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="page-wrapper bg-gra-03 p-t-45 p-b-50">
                <div class="wrapper wrapper--w790">
                    <div class="card card-5">
                        <div class="card-heading">
                            <h2 class="title">Event Registration Form</h2>
                        </div>
                        <div class="card-body">

                            <div class="form-row m-b-55">
                                <div class="name">Name</div>
                                <div class="value">
                                    <div class="row row-space">
                                        <div class="col-2">
                                            <div class="input-group-desc">
                                                <input class="input--style-5" type="text" name="first_name">
                                                <label class="label--desc">first name</label>
                                            </div>
                                        </div>
                                        <div class="col-2">
                                            <div class="input-group-desc">
                                                <input class="input--style-5" type="text" name="last_name">
                                                <label class="label--desc">last name</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="name">Company</div>
                                <div class="value">
                                    <div class="input-group">
                                        <input class="input--style-5" type="text" name="company">
                                    </div>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="name">Email</div>
                                <div class="value">
                                    <div class="input-group">
                                        <input class="input--style-5" type="email" name="email">
                                    </div>
                                </div>
                            </div>
                            <div class="form-row m-b-55">
                                <div class="name">Phone</div>
                                <div class="value">
                                    <div class="row row-refine">
                                        <div class="col-3">
                                            <div class="input-group-desc">
                                                <input class="input--style-5" type="text" name="area_code">
                                                <label class="label--desc">Area Code</label>
                                            </div>
                                        </div>
                                        <div class="col-9">
                                            <div class="input-group-desc">
                                                <input class="input--style-5" type="text" name="phone">
                                                <label class="label--desc">Phone Number</label>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="name">Subject</div>
                                <div class="value">
                                    <div class="input-group">
                                        <div class="rs-select2 js-select-simple select--no-search">
                                            <select name="subject">
                                                <option disabled="disabled" selected="selected">Choose option</option>
                                                <option>Subject 1</option>
                                                <option>Subject 2</option>
                                                <option>Subject 3</option>
                                            </select>
                                            <div class="select-dropdown"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="form-row p-t-20">
                                <label class="label label--block">Are you an existing customer?</label>
                                <div class="p-t-15">
                                    <label class="radio-container m-r-55">
                                        Yes
                                   
                                        <input type="radio" checked="checked" name="exist">
                                        <span class="checkmark"></span>
                                    </label>
                                    <label class="radio-container">
                                        No
                                   
                                        <input type="radio" name="exist">
                                        <span class="checkmark"></span>
                                    </label>
                                </div>
                            </div>
                            <div>
                                <button class="btn btn--radius-2 btn--red" type="submit">Register</button>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>



    <script src="recursos/vendor/jquery/jquery.min.js"></script>
    <script src="recursos/js/JavaEmpleados.js"></script>

    <script src="recursos/vendor/jquery/jquery.min.js"></script>
    <script src="recursos/js/datosDataTable.js"></script>
    <script src="recursos/js/sb-admin-2.min.js"></script>

     <!--Boostrap js-->    
    <script src="recursos/js/datatables/jquery.dataTables.min.js"></script>
    <script src="recursos/js/datatables/dataTables.bootstrap4.min.js"></script>
    <script src="recursos/js/demo/datatables-demo.js"></script>
</asp:Content>
