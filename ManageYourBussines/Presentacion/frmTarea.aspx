<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmTarea.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <div class="container-fluid">
    <img src="recursos/images/icono3.png" widt="20" height="20"/>
    <a class="navbar-brand" href="#">Muebles san José</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="collapsibleNavbar">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link" href="frmAdmin.aspx">Página del administrador</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
     <div class="container-fluid">
          <form runat="server">
        
            <h1 class="h3 mb-2 text-gray-800">LISTADO DE TAREAS</h1>


            <!-- DataTales Example -->
               
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table table-bordered table-dark" id="dtDatosPersonal" width="100%" cellspacing="0">
                            <thead>
                                <tr>
                                    <th>N°TAREA</th>
                                    <th>NOMBRE DE LA TAREA</th>
                                    <th>DESCRIPCIÓN DE LA TAREA</th>
                                    <th>ESTADO</th>
                                    <th>TIEMPO</th>
                                    <th>EDITAR</th>
                                    <th>ELIMINAR</th>
                                   
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    
  
    <h1>REGISTRO DE TAREAS</h1>
        <br />
        <div class="col">
            <div class="form-group">
                <label for="txtNombre" class="col-form-label">NOMBRE DE LA TAREA</label>
                <asp:TextBox ID="txtNombreTarea" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDescripcion" class="col-form-label">DESCRIPCIÓN DE LA TAREA</label>
                <asp:TextBox ID="txtDescripcionTarea" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPrecio" class="col-form-label">TIEMPO</label>
                <asp:TextBox ID="txtTiempo" class="form-control" runat="server"></asp:TextBox>
            </div>
             <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR TAREA" CssClass="btn btn-dark" OnClick="btnRegistrar_Click" />
        </div>
     
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
                         <div class="form-group">
                       
                        <asp:TextBox ID="txtIdTareaEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtNombreEditar" class="col-form-label">Nombre de la Tarea</label>
                            <asp:TextBox ID="txtNombreEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtDescripcionEditar" class="col-form-label">Descripción de la Tarea</label>
                            <asp:TextBox ID="txtDescripcionEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtEstadoEditar" class="col-form-label">Estado</label>
                            <asp:TextBox ID="txtEstadoEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="txtTiempoEditar" class="col-form-label">Tiempo</label>
                            <asp:TextBox ID="txtTiempoEditar" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>

          <%--Modal Eliminarr--%>

     <div class="modal fade" id="ModalDatosEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabelE">Advertencia</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                         <asp:TextBox ID="txtIdTarea" runat="server"></asp:TextBox>
                        <p align="center"><img src="recursos/images/advertencia.png" width="40" height="40" /></p><br />
                        <center><asp:Label ID="Label1" runat="server" Text="¿Estas seguro de eliminar este registro?"></asp:Label></center>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="txtEliminar" runat="server" class="btn btn-danger" Text="Eliminar" OnClick="txtEliminar_Click" />
                    </div>
                </div>
            </div>
        </div>
    
</form>

    <script src="recursos/js/jquery-3.4.1.min.js"></script>
    <script src="recursos/js/JavaTarea.js"></script>
</asp:Content>
