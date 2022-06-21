<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chat.aspx.cs" Inherits="ManageYourBussines.Presentacion.chat" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>
<div class="container">
    <div class ="row">
        <div class="col-lg-12">
            <imput  type="text" class="form-control"id="message"/>

        </div>
        </div>
      <div class ="row">
    <div class="col-lg-12">

            <imput  type="text" class="btn-btn-sucess"id="sendmessage"value ="Enviar">

        </div>
    
    </div>
    <h3>Mensajes de Clienntes </h3>
    <div class ="row">

        <ul id ="discussion"> </ul>

    </div>
    </div>
            <imput  type="hidden" id="displayname"/>

@section scripts{
<script src="~/Scripts/jquerysignalR-2.2.3.js"></script>
<script src="/signalR/hubs"></script>
<script type="text/javascript">

    $(function(){
        var chat = $.connection.chatHub;
        chat.

    }
</script>

}
 