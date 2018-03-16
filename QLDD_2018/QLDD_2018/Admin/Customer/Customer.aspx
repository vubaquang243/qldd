<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="Customer.aspx.cs" Inherits="QLDD_2018.Admin.Customer.Customer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <section class="content-header">
        <h1>Danh sách điện thoại</h1>
        <ol class="breadcrumb">
            <li><a href="index.html"><i class="fa fa-dashboard"></i>Trang chủ</a></li>
            <li class="active">Điện thoại</li>
        </ol>
    </section>
    <% if (alert != null && !alert.Equals(""))
        { %>
    <div class="alert alert-success alert-dismissable">
        <i class="fa fa-check"></i>
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
        <%=alert %>
    </div>
    <% } %>
    <asp:Literal Text="" ID="lstPhone" runat="server" />
    <% int i = 0; %>
    <table class="table table-bordered">
        <tr>
            <th style="width="7%">STT</th>
            <th>Tên khách hàng</th>
            <th>Email</th>
            <th>Số CMND</th>
            <th>Ngày sinh</th>
            <th>Địa chỉ</th>
            <th>Công ty</th>
            <th>Thao tác</th>
        </tr>
        <% foreach (var item in lstCus)
            { %>
        <tr>
            <td><%=i+1 %></td>
            <td><%=item.name %></td>
            <td><%=item.email %></td>
            <td><%=item.identity_no %></td>
            <td><%=item.date_of_birth %></td>
            <td><%=item.address %></td>
            <td><%=item.company %></td>
            <td><a href="Customer.aspx?id=<%=item.customer_id %>">Xóa</a></td>
        </tr>
        <% } %>
    </table>
</asp:Content>
