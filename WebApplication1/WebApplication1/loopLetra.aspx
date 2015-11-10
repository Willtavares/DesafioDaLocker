<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loopLetra.aspx.cs" Inherits="WebApplication1.loopLetra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Digite a sua palavra:"></asp:Label>
        <asp:TextBox runat="server" id="txtpalavra" value=""/>
        <asp:Button Text="Calcular" runat="server" OnClick="Unnamed1_Click"/>

    </div>
    </form>
</body>
</html>
