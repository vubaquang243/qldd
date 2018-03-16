<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="Menu.aspx.cs" Inherits="QLDD_2018.Admin.Menu.Menu" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <section class="content-header">
        <h1>Danh sách menu</h1>
        <ol class="breadcrumb">
            <li><a href="index.html"><i class="fa fa-dashboard"></i>Trang chủ</a></li>
            <li class="active">Menu</li>
        </ol>
    </section>

    <div class="alert alert-success alert-dismissable">
        <i class="fa fa-check"></i>
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
        <!-- noi dung thong bao -->
    </div>

    <asp:Literal Text="" ID="lstPhone" runat="server" />
    <table class="table">
        <tr>
            <th>Tên menu</th>
            <th>Link</th>
            <th>alias</th>
            <th>Id Menu cha</th>
            <th>Trạng thái</th>
            <th colspan="2">Thao tác</th>
        </tr>
    </table>
</asp:Content>
