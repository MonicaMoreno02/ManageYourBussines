<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site3.Master" AutoEventWireup="true" CodeBehind="frmRegistrarProducto.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmRegistrarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <div class="card card-5">
            <div class="card-heading">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" Width="39px" ImageUrl="~/Presentacion/recursos/images/atrasblanco.png" OnClick="ImageButton1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text="AGREGAR NUEVOS PRODUCTOS" Font-Bold="True" Font-Italic="True" Font-Size="20pt" ForeColor="White"></asp:Label>
            </div>
        </div>
        <br />
        <%--PAOLA: Modal para registrar los empleados --%>
<%--        <div class="page-wrapper bg-gra-03 p-t-45 p-b-50">--%>
            <div class="wrapper wrapper--w790">
                <div class="card card-5">
                    <div class="card-body">
                        <div class="form-row m-b-55">
                            <div class="name">Nombre</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="border: thin double #000000; margin: auto; padding: inherit;">

                                        <asp:TextBox ID="txtAsignarNombre" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>


                        </div>
                        <div class="form-row m-b-55">
                            <div class="name">Asignar Descripción</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarDescripcion" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Precio</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarPrecio" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="form-row m-b-55">
                            <div class="name">Cantidad Stock</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarCantidadStock" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="form-row m-b-55">
                            <div class="name">Largo</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarLargo" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Ancho</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarAncho" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Profundidad</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarProfundidad" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Material</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarMaterial" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Caracteristicas</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:TextBox ID="txtAsignarCaracteristicas" class="form-control" runat="server" Width="500px"></asp:TextBox>

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="form-row m-b-55">
                            <div class="name">Imagen</div>
                            <div class="value">
                                <div class="input-group">
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">

                                        <asp:FileUpload ID="fuImagen" runat="server" />

                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-primary" Text="Agregar" OnClick="btnAgregar_Click" />
                        <br />
                        <br />
                        <br />
                        &nbsp;<div>
                        </div>

                    </div>
                </div>
            </div>
<%--        </div>--%>
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
