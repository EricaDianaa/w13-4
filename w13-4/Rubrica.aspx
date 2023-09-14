<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rubrica.aspx.cs" Inherits="w13_4.Rubrica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Contatti</h2>
            <hr />
            <div id="Result" runat="server">
                
            </div>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="w13_4.Persona">
                    <ItemTemplate>
                        <p><strong><%# Item.Nome%></strong></p>
                    </ItemTemplate>
                </asp:Repeater>
            <hr />


        </div>
    </form>
</body>
</html>
