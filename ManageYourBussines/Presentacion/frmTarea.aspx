<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Site2.Master" AutoEventWireup="true" CodeBehind="frmTarea.aspx.cs" Inherits="ManageYourBussines.Presentacion.frmTarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
          <form runat="server">
        
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
    
  
    <h1>Registrar Tareas:</h1>
        <br />
        <div class="col">
            <div class="form-group">
                <label for="txtNombre" class="col-form-label">Nombre de la Tarea:</label>
                <asp:TextBox ID="txtNombreTarea" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDescripcion" class="col-form-label">Descripción de la Tarea:</label>
                <asp:TextBox ID="txtDescripcionTarea" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPrecio" class="col-form-label">Tiempo</label>
                <asp:TextBox ID="txtTiempo" class="form-control" runat="server"></asp:TextBox>
            </div>
             <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Tarea" CssClass="btn btn-dark" OnClick="btnRegistrar_Click" />
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
                         <asp:TextBox ID="txtIdTarea" Visible="false" runat="server"></asp:TextBox>
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
