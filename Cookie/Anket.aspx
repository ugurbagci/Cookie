<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anket.aspx.cs" Inherits="Cookie.Anket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Türkçe karşılığı "çerezler" olarak bilinen istemci taraflı bir state Management tekniğidir. Cookies tamamen web sayfasına bağlanan kullanıcının browser yani tarayıcısı tarafında tutulan bir yöntemdir. Cookie dosyaları kullanıcın bilgisayarında onunla ilgili bilgileri  tutmak -->

            Hangi Takımı Tutuyorsunuz ? 
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem runat="server" Text="Fenerbahçe"></asp:ListItem>
                <asp:ListItem runat="server" Text="Galatasaray"></asp:ListItem>
                <asp:ListItem runat="server" Text="Beşiktaş"></asp:ListItem>
                <asp:ListItem runat="server" Text="Karşıyaka"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnOyVer" runat="server" Text="Oy Ver!" OnClick="btnOyVer_Click" />

        </div>
    </form>
</body>
</html>
