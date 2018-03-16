<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin/Admin.Master" CodeBehind="AddPhone.aspx.cs" Inherits="QLDD_2018.Admin.Phone.AddPhone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="AdminPlaceHolder" runat="server">
    <section class="content-header">
        <h1>Thêm mới Điện thoại
        <small>Thêm mới</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="index.html"><i class="fa fa-dashboard"></i>Trang chủ</a></li>
            <li><a href="news">Điện thoại</a></li>
            <li class="active">Thêm mới</li>
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
                                <a href="javascript:void(0);" onclick="javascript:document.image.reset();" class="btn btn-success"><i class="fa fa-fw fa-random"></i>Reset</a>
                                <a href="#messages" rel="modal" class="btn btn-success"><i class="fa fa-fw fa-times"></i>Trợ giúp </a>
                                <a href="news_category" class="btn btn-success"><i class="fa fa-fw fa-times"></i>Hủy</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.box-header -->
                <% if (!error.Equals(""))
                    { %>
                <div class="alert alert-success alert-dismissable">
                    <i class="fa fa-check"></i>
                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                    <%=error %>
                </div>
                <% } %>
                <div class="box box-primary">

                    <div class="box-body lang_tab_content" id="lang_vi">
                        <div class="form-group">
                            <label>Tên máy : </label>
                            <asp:TextBox runat="server" ID="txtPhoneName" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Hãng điện thoại : </label>
                            <asp:DropDownList ID="ddlListCompany" runat="server" CssClass="form-control" ClientIDMode="Static" onchange="getCategoryPhone();" OnSelectedIndexChanged="ddlListCompany_SelectedIndexChanged">
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
                            <asp:DropDownList ID="ddlListCategoryPhone" runat="server" ClientIDMode="Static" CssClass="form-control">
                                <asp:ListItem Value="">Chọn loại điện thoại</asp:ListItem>
                                <asp:ListItem Value="1">1</asp:ListItem>
                                <asp:ListItem Value="2">2</asp:ListItem>
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
                            <label>Dung lượng pin : </label>
                            <asp:TextBox runat="server" TextMode="Number" ID="txtPin" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Dung lượng bộ nhớ: </label>
                            <asp:TextBox runat="server" ID="txtMemory" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <script type="text/javascript" >
        function getCategoryPhone() {
            jQuery('#ddlListCategoryPhone option').remove();
            var company_id = jQuery('#ddlListCompany option:selected').val();
            jQuery.ajax({
                type: 'POST',
                url: 'AddPhone/GetPhoneCate',//url
                data: { 'companyId': company_id },
                contentType: 'application/json; charset=utf-8',
                //dataType: 'json',
                success: function (data) {
                    //alert(data.d[0].phone_category_id);
                    var listCate = new Object();
                    listCate = JSON.parse(data[0]);
                    if (listCate.size() != 0) {//đây là js t viết
                        //alert(listCate);
                        jQuery('#ddlListCategoryPhone').append("<option value=''>Chọn loại điện thoại</option>");
                        for (var i = 0; i < listCate.size() ; i++) {
                            //jQuery('#ddlListCategoryPhone').append('<option value="' + listCate[i].phone_category_id + '">' + listCate[i].phone_category_name + '</option>');
                        }
                    }
                }
            });
        }
    </script>
</asp:Content>
