<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmRegisEmpleados.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmRegisEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
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
                                        <asp:TextBox ID="txtDocumentoRegis" type="text" runat="server" BackColor="#E5E5E5" Height="22px" Width="494px"></asp:TextBox>
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
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">
                                        <asp:TextBox ID="txtNombreRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5" Width="494px" Height="22px"></asp:TextBox>
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
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">
                                        <asp:TextBox ID="txtApellidoRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5" Width="494px" Height="22px"></asp:TextBox>
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

                                    <asp:DropDownList ID="ddlTipoEmpleado" runat="server" Height="37px" Width="126px">
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
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">
                                        <asp:TextBox ID="txtEmailRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5" Width="494px" Height="22px"></asp:TextBox>
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
                                    <div class="input--style-5" style="margin: auto; padding: inherit; border: thin double #000000;">
                                        <asp:TextBox ID="txtClaveRegis" runat="server" ValidateRequestMode="Enabled" BackColor="#E5E5E5" Width="494px" Height="22px"></asp:TextBox>
                                    </div>

                                </div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtClaveRegis" ErrorMessage="Campo Obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>


                        <asp:Button ID="btnRegistrar" class="btn btn-primary" runat="server" Text="Registrar" Height="73px" Width="271px" OnClick="btnRegistrar_Click" />

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
