<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site1.Master" AutoEventWireup="true" CodeBehind="frmTareas.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Registrar Tareas</h1>
    <form action="/action_page.php">
  <div class="mb-3 mt-3">
    <label for="email" class="form-label">Nombre Tarea:</label>
    <asp:TextBox ID="txtNombreTarea" runat="server" placeholder="Ingrese el nombre de la Tarea" name="tarea" ></asp:TextBox>
  </div>
  <div class="mb-3">
    <label for="pwd" class="form-label">Descripcion Tarea:</label>
      <asp:TextBox ID="txtDescripcionTarea" runat="server" placeholder="Ingrese la descripción de la Tarea" name="decripcion" ></asp:TextBox>
  </div>
        <div class="mb-3">
    <label for="pwd" class="form-label">Tiempo:</label>
      <asp:TextBox ID="txtTiempo" runat="server" placeholder="Tiempo de Duración" name="tiempo" ></asp:TextBox>
  </div>
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Tarea" CssClass="btn btn-dark" OnClick="btnRegistrar_Click" />
</form>


   
        <div class="container-fluid">

            <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">Listado de Tareas</h1>


            <!-- DataTales Example -->
               
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-dark" id="dtDatosPersonal" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>N°Tarea</th>
                                    <th>Nombre Tareas</th>
                                    <th>Descripción Tareas</th>
                                    <th>estado</th>
                                    <th>tiempo</th>
                                    <th>Editar</th>
                                    <th>Eliminar</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/datosDataTable2.js"></script>
</asp:Content>
