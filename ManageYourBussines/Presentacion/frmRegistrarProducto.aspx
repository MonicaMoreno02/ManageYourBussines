<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site3.Master" AutoEventWireup="true" CodeBehind="frmRegistrarProducto.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmRegistrarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <%--PAOLA: Modal para registrar los empleados --%>
        <div class="page-wrapper bg-gra-03 p-t-45 p-b-50">
            <div class="wrapper wrapper--w790">
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


                                        <br />
                                    </div>
                                </div>
                            </div>

                           
                        </div>
                        <div class="form-row m-b-55">
                            <div class="name">Nombre</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">


                                        <br />
                                    </div>

                                </div>
                            </div>
                          

                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Apellido</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">


                                    </div>

                                </div>
                               

                            </div>
                        </div>

  <h1>Registrar productos</h1>
        <br />
        <div class="container-fluid">
            <center>
            <h1>Productos</h1>
            <div class="card shadow mb-8">
                <div class="card-body">
                    <div class="col-12"
                        <div class="form-group">
                            <label for="txtNombre" class="col-form-label">Nombre</label>
                            <asp:TextBox ID="txtAsignarNombre" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtDescripcion" class="col-form-label">Descripcion</label>
                            <asp:TextBox ID="txtAsignarDescripcion" class="form-control" runat="server" OnTextChanged="txtAsignarDescripcion_TextChanged" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtPrecio" class="col-form-label">Precio</label>
                            <asp:TextBox ID="txtAsignarPrecio" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtCantidadStock" class="col-form-label">Cantidad en Stock</label>
                            <asp:TextBox ID="txtAsignarCantidadStock" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtLargo" class="col-form-label">Largo</label>
                            <asp:TextBox ID="txtAsignarLargo" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtAncho" class="col-form-label">Ancho</label>
                            <asp:TextBox ID="txtAsignarAncho" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtProfundidad" class="col-form-label">Profundidad</label>
                            <asp:TextBox ID="txtAsignarProfundidad" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtMaterial" class="col-form-label">Material</label>
                            <asp:TextBox ID="txtAsignarMaterial" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtCaracteristicas" class="col-form-label">Caracteristicas</label>
                            <asp:TextBox ID="txtAsignarCaracteristicas" class="form-control" runat="server" Width="500px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtImagen" class="col-form-label">Imagen</label>
                            <asp:FileUpload ID="fuImagen" runat="server" />
                        </div>


                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                    </div>
                </div>
            </div>
</center>
        </div>

        <br />
        <br />
        <br />
        <br />

                        





                        <br />
                        <br />
                        <br />
                        &nbsp;<div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <%--PAOLA: Modal para registrar los empleados --%>
    </form>

    <%-- Recursos para registro de empleados --%>
    <link href="recursos/css/main.css" rel="stylesheet" />
    <link href="recursos/css/main.min.css" rel="stylesheet" />

    <!-- Jquery JS-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <!-- Vendor JS-->
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>

    <!-- Main JS-->
    <script src="js/global.js"></script>

</asp:Content>
