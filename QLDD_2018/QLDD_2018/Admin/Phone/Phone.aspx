<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="Phone.aspx.cs" Inherits="QLDD_2018.Admin.Phone.Phone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <section class="content-header">
        <h1>Danh sách điện thoại</h1>
        <ol class="breadcrumb">
            <li><a href="index.html"><i class="fa fa-dashboard"></i>Trang chủ</a></li>
            <li class="active">Điện thoại</li>
        </ol>
    </section>
    <div>
        <table class="table">
            <tr>
                <td>Mã điện thoại : </td>
                <td>
                    <asp:TextBox runat="server" CssClass="form-control" ClientIDMode="Static" ID="txtPhoneId" /></td>
                <td>Hãng điện thoại : </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlCompany" onchange="" CssClass="form-control" OnSelectedIndexChanged="ddlCompany_SelectedIndexChanged" OnTextChanged="ddlCompany_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>Ngày phát hành từ :</td>
                <td>
                    <asp:TextBox TextMode="Date" CssClass="form-control" runat="server" ID="txtDateIssueFrom"  /></td>
                <td>đến :</td>
                <td>
                    <asp:TextBox TextMode="Date" runat="server" ID="txtDateIssueTo" CssClass="form-control" /></td>
            </tr>
            <tr>
                <td>Loại điện thoại : </td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlPhoneCategory" CssClass="form-control">
                        <asp:ListItem Value="">Chọn loại điện thoại</asp:ListItem>
                    </asp:DropDownList></td>
                <td>Giá</td>
                <td>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCost" /></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <asp:HiddenField runat="server" ID="txtAction" ClientIDMode="Static" />
                    <asp:Button Text="Tìm kiếm" OnClick="Page_Load" ClientIDMode="Static" ID="btnTimKiem" CssClass="btn btn-default" runat="server" />
                    <asp:Button Text="Thêm mới" OnClick="btnAdd_Click" ID="btnAdd" CssClass="btn btn-default" runat="server" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
    <% if (!alert.Equals(""))
        { %>
    <div class="alert alert-success alert-dismissable">
        <i class="fa fa-check"></i>
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
        <%=alert %>
    </div>
    <% } %>
    <div class="box-header">
        <div class="box-tools" style="margin-bottom: 10px">
            <div class="input-group">
                <div class="input-group-btn">
                    <a href="/Admin/Phone/AddPhone.aspx" class="btn btn-success"><i class="fa fa-fw fa-plus-circle"></i> Thêm</a>
                </div>
            </div>
        </div>
    </div>
    <asp:Literal Text="" ID="lstPhone" runat="server" />
    <table class="table table-bordered">
        <tr>
            <th>Mã Điện thoại</th>
            <th>Tên máy</th>
            <th>Ngày phát hành</th>
            <th>Giá</th>
            <th>Tên Hãng</th>
            <th>Chi tiết</th>
            <th colspan="2">Thao tác</th>
        </tr>
        <% foreach (var item in lst)
            {%>
        <tr>
            <td><%=item.phone_id %></td>
            <td><%=item.phone_name %></td>
            <td><%=item.date_issue %></td>
            <td><%=item.cost %></td>
            <td><%=item.p_company.name %></td>
            <td><a href="/Admin/Phone/DetailPhone.aspx?id=<%=item.phone_detail_id %>">Chi tiết</a></td>
            <td><a href="/Admin/Phone/EditPhone.aspx?id=<%=item.phone_id %>">Sửa</a> <a href="Phone.aspx?id=<%=item.phone_id %>">Xóa</a></td>
        </tr>
        <%} %>
    </table>
    <script type="text/javascript">
        jQuery(document).ready(function () {
            jQuery('#btnTimKiem').click(function () {
                jQuery('#txtAction').val("Search");
            });
        });
    </script>
</asp:Content>

