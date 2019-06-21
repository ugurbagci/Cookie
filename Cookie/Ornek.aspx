<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ornek.aspx.cs" Inherits="Cookie.Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı Adi:
            <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
            Şifre:
            <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
            <asp:Button ID="btnOlustur" runat="server" Text="Olustur" OnClick="btnOlustur_Click" />
            <asp:Label ID="lblAd" runat="server"></asp:Label>
            <asp:Label ID="lblSifre" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
