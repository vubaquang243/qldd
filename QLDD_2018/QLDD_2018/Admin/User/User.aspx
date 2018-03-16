<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="User.aspx.cs" Inherits="QLDD_2018.Admin.User.User" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <div>
        <table class="table">
            <tr>
                <td>Tên người dùng : </td><td><asp:TextBox runat="server" CssClass="form-control" ClientIDMode="Static" ID="txtUserName" /></td>
                <td>Hãng điện thoại : </td><td><asp:DropDownList runat="server" ID="ddlCompany" CssClass="form-control">
                                                <asp:ListItem Value="" >Chọn công ty</asp:ListItem>
                                               </asp:DropDownList></td>
            </tr>
            <tr>
                <td></td><td colspan="2" ><asp:Button Text="Tìm kiếm" OnClick="btnTimKiem_Click" ID="btnTimKiem" CssClass="btn btn-default" runat="server" />
                    <asp:Button Text="Thêm mới" OnClick="btnAdd_Click" ID="btnAdd" CssClass="btn btn-default" runat="server" />
                     </td>
                <td></td>
            </tr>
        </table>
    </div>


    <section class="content-header">
    <h1>Danh sách người dùng</h1>
    <ol class="breadcrumb">
        <li><a href="index.html" ><i class="fa fa-dashboard"></i> Trang chủ</a></li>
        <li class="active">Người dùng</li>
    </ol>
    </section>
    <asp:Literal Text="" ID="user" runat="server" />
    <table class="table">
        <tr>
            <th>Id</th>
            <th>Tên người dùng</th>
            <th>Email</th>
            <th>Tên hãng điện thoại</th>            
            <th>Chi tiết</th>
            <th colspan="2">Thao tác</th>
        </tr>
        
    </table>
</asp:Content>
