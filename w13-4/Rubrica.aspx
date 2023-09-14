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
            
            <asp:Repeater ID="Repeater1" runat="server" ItemType="w13_4.Persona">
                    <ItemTemplate>
                        <div >
                        <p><strong><%#Item.Nome + Item.Cognome %></strong></p>
                        <p><%#Item.Indirizzo %></p>
                         <p><%#Item.NumeroTelefono %></p>
                         <p><%#Item.Email %></p>
                        <a href="Dettagli.aspx?IdPersona=<%# Item.IdPersona %>">Dettagli</a>
                    <img style="width:10%" src="Content/img/<%# Item.Foto %>"/>
                              <hr />
                      </div>
                    </ItemTemplate>
                </asp:Repeater>
            <hr />


        </div>
    </form>
</body>
</html>
