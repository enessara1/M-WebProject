<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fileUpload.aspx.cs" Inherits="fileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="fontawesome-free-5.15.4-web/css/all.css">
    <link rel="stylesheet" href="css/main/index.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12">
            <div class="col-md-4">
                <p>Dil Seçiniz</p>
                <br />
                <asp:DropDownList runat="server" ID="ddlLanguage">
                    <asp:ListItem runat="server" Value="ENG">ENG</asp:ListItem>
                    <asp:ListItem runat="server" Value="HR">HR</asp:ListItem>
                    <asp:ListItem runat="server" Value="GR">GR</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-2">
                <p>Tarih Giriniz</p>
                <asp:TextBox runat="server" ID="txtDate"></asp:TextBox>
                <br />
                <p>Yıl Giriniz</p>
                <asp:TextBox runat="server" ID="txtYear"></asp:TextBox>
                <br />
            </div>
            <div class="col-md-6">
                <p>Dosya Adı</p>
                <asp:TextBox runat="server" ID="txtName" Style="width:100%;"></asp:TextBox>
                <br />
            </div>
        </div>
        <br />
        <br />
        <br />
        <div class="col-md-12">
            <div class="col-md-6">
                <p>Dosya Linki</p>
                <asp:TextBox runat="server" ID="txtLink" style="width:100%;"></asp:TextBox>
                <br />
            </div>
            <div class="col-md-2">
                <p>Sayfa Seçiniz</p>
                <asp:DropDownList runat="server" ID="ddlPage" OnSelectedIndexChanged="ddlPage_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem runat="server" Value="Presentation">Presentation</asp:ListItem>
                    <asp:ListItem runat="server" Value="Notifications">Notifications</asp:ListItem>
                    <asp:ListItem runat="server" Value="Financial Reports">Financial Reports</asp:ListItem>
                    <asp:ListItem runat="server" Value="General Assembly">General Assembly</asp:ListItem>
                    <asp:ListItem runat="server" Value="Documents">Documents</asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
            <div class="col-md-4">
                <p>Başlık Seçiniz</p>
                <asp:DropDownList runat="server" ID="ddlHeaderFinancial" Style="display: none;">
                    <asp:ListItem runat="server" Value="Annual reports">Annual reports</asp:ListItem>
                    <asp:ListItem runat="server" Value="Interim reports">Interim reports</asp:ListItem>
                    <asp:ListItem runat="server" Value="TFI POD; GFI POD">TFI POD; GFI POD</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList runat="server" ID="ddlHeaderDocuments" Style="display: none;">
                    <asp:ListItem runat="server" Value="The Articles of Association">The Articles of Association</asp:ListItem>
                    <asp:ListItem runat="server" Value="Boards policies">Boards policies</asp:ListItem>
                    <asp:ListItem runat="server" Value="Other acts">Other acts</asp:ListItem>
                    <asp:ListItem runat="server" Value="Code of Corporate Governance">Code of Corporate Governance</asp:ListItem>
                    <asp:ListItem runat="server" Value="Prospectus">Prospectus</asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
        </div>
        <div class="col-12">
            <asp:Button runat="server" ID="btnSave" OnClick="btnSave_Click" Text="Kaydet" />
        </div>
        <!-- Bootstrap -->
        <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
        <script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
        <link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
            media="screen" />
        <!-- Bootstrap -->
        <!-- Bootstrap DatePicker -->
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css" type="text/css" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js" type="text/javascript"></script>
        <!-- Bootstrap DatePicker -->
    </form>
</body>
</html>
