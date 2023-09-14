<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="w13_4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <hr />
            <h2>Inserisci nuovo contatto</h2>
            <h3>Nome</h3>  
             <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
             <h3>Cognome</h3>  
             <asp:TextBox ID="Cognome" runat="server"></asp:TextBox>
             <h3>Indirizzo</h3>  
             <asp:TextBox ID="Indirizzo" runat="server"></asp:TextBox>
             <h3>Numero di telefono</h3>  
             <asp:TextBox ID="NumeroTelefono" runat="server"></asp:TextBox>
             <h3>Email</h3>  
             <asp:TextBox ID="Email" runat="server"></asp:TextBox> <br />
             <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
            <asp:Button ID="Button1" runat="server" Text="Invia" Onclick="Button1_Click" />
           
            <hr />

          <asp:Button ID="Rubrica" runat="server" Text="Rubrica" Onclick="Dettagli_Click" />
            <div>

            </div>


        </div>
    </form>
</body>
</html>
