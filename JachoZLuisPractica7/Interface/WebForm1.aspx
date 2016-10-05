<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Interface.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        IdTaxa<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="SeleccionarTaxaPublicacion" TypeName="Interface.pub.WebService1">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="taxaid" PropertyName="Text" 
                    Type="Int64" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1" 
            OnItemCommand="Repeater1_ItemCommand">
        <headertemplate>
          <table border="1">
            <tr>
              <td><b>IdTaxa</b></td>
              <td><b>IdPublicacion</b></td>
              <td><b>Principal</b></td>
              <td><b>Nombre</b></td>
              <td><b>NombreCorto</b></td>
              <td><b>Titulo</b></td>
              <td><b>Editor</b></td>
              <td><b>NombreArchivo</b></td>
              <td><b>EnlaceArchivo</b></td>
              <td><b>Descarga</b></td>
            </tr>
        </headertemplate>
            <ItemTemplate>
          <tr>
              <td>
                <asp:Label runat="server" ID="Label1" 
                    text='<%# Eval("IdTaxa") %>' />
              </td>         
              <td>
                <asp:Label runat="server" ID="Label2" 
                    text='<%# Eval("IdPublicacion") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label3" 
                    text='<%# Eval("Principal") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label4" 
                    text='<%# Eval("Nombre") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label5" 
                    text='<%# Eval("NombreCorto") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label6" 
                    text='<%# Eval("Titulo") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label8" 
                    text='<%# Eval("Editor") %>' />
              </td>
              
              <td>
                <asp:Label runat="server" ID="Label11" 
                    text='<%# Eval("NombreArchivo") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label12" 
                    text='<%# Eval("EnlaceArchivo") %>' />
              </td>
              <td>
                <asp:Label runat="server" ID="Label13" 
                    text='<%# Eval("Descarga") %>' />
              </td>
          </tr>
          </ItemTemplate>
        
      </asp:Repeater>
        
            
               
    </form>      
  </body>
</html>
