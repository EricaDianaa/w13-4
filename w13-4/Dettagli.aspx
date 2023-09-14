<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="w13_4.Dettagli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
  <h2>Contatti</h2>
     <hr />
 Nome: <asp:TextBox ID="Nome" runat="server"></asp:TextBox> <br />
 Cognome: <asp:TextBox ID="Cognome" runat="server"></asp:TextBox><br />
 Indirizzo: <asp:TextBox ID="Indirizzo" runat="server"></asp:TextBox><br />
  Numero di telefono:<asp:TextBox ID="NumeroTelefono" runat="server"></asp:TextBox><br />
  Email:<asp:TextBox ID="Email" runat="server"></asp:TextBox> <br />
 Foto: <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
            <asp:Button ID="Button1" runat="server" Text="Modifica" OnClick="Button1_Click" />
            <asp:Button ID="Elimina" runat="server" Text="Elimina" OnClick="Elimina_Click" />

 <hr />
        </div>
    </form>
</body>
</html>
