<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="EditPhone.aspx.cs" Inherits="QLDD_2018.Admin.Phone.EditPhone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <section class="content-header">
        <h1>Thêm mới Điện thoại
        <small>Sửa</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="index.html"><i class="fa fa-dashboard"></i>Trang chủ</a></li>
            <li><a href="news">Điện thoại</a></li>
            <li class="active">Sửa</li>
        </ol>
    </section>

    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <!-- box-header -->
                <div class="box-header">
                    <div class="box-tools" style="margin-bottom: 10px">
                        <div class="input-group">
                            <div class="input-group-btn">
                                <asp:Button Text="Lưu" OnClick="btnAdd_Click" CssClass="btn btn-success" runat="server" ID="btnAdd" />
                                <button class="btn btn-success" id="btnReset">Reset</button>
                                <a href="/Admin/Phone/Phone.aspx" class="btn btn-success"><i class="fa fa-fw fa-times"></i>Hủy</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <% if (!edit_fail.Equals(""))
                    { %>
                <div class="alert alert-success alert-dismissable">
                    <i class="fa fa-check"></i>
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <%=edit_fail %>
                </div>
                <% } %>
                <div class="box box-primary">

                    <div class="box-body lang_tab_content" id="lang_vi">
                        <asp:HiddenField ID="txtPhoneId" runat="server" />
                        <asp:HiddenField ID="txtPhoneDetailId" runat="server" />
                        <div class="form-group">
                            <label>Tên máy : </label>
                            <asp:TextBox runat="server" ID="txtPhoneName" CssClass="form-control" />
                        </div>

                        <div class="form-group">
                            <label>Hãng điện thoại : </label>
                            <asp:DropDownList ID="ddlListCompany" runat="server" ClientIDMode="Static" CssClass="form-control" OnSelectedIndexChanged="ddlListCompany_SelectedIndexChanged">
                                <asp:ListItem Value="">Chọn hãng điện thoại</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <label>Giá : </label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtCost" />
                        </div>

                        <div class="form-group">
                            <label>Mã số thuế : </label>
                            <asp:TextBox runat="server" ID="txtCode" CssClass="form-control" />
                        </div>

                        <div class="form-group">
                            <label>Dòng điện thoại : </label>
                            <asp:DropDownList ClientIDMode="Static" ID="ddlListCategoryPhone" runat="server" CssClass="form-control">
                                <asp:ListItem Value="">Chọn loại điện thoại</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Ram : </label>
                            <asp:TextBox runat="server" ID="txtRam" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Độ rộng mà hình : </label>
                            <asp:TextBox runat="server" ID="txtScreenSize" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Dung lượng bộ nhớ : </label>
                            <asp:TextBox runat="server" ID="txtMemory" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Dung lượng pin : </label>
                            <asp:TextBox runat="server" TextMode="Number" ID="txtPin" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
