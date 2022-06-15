<%@ Page Title="Lista de Hotéis" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hoteis._Default" %>

<%--MasterPageFile="~/Site.Master"--%>
<html>
<head runat="server">
    <title>Projeto Hotel Livro C# 7</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>
                <h2>
                    <asp:Label ID="LabelIntro" runat="server"></asp:Label>
                </h2>
            </b>

            <asp:Label ID="LabelPais" runat="server"></asp:Label>

            <asp:DropDownList ID="ddlPais" runat="server" OnSelectedIndexChanged="Pais" AutoPostBack="true">
                <asp:ListItem Text="TODOS" Value="" />
                <asp:ListItem Text="ANGOLA" Value="AN" />
                <asp:ListItem Text="BRASIL" Value="BR" />
                <asp:ListItem Text="PORTUGAL" Value="PT" />
            </asp:DropDownList>
            <p />
            <p />
            <asp:Label ID="LabelClassific" runat="server"></asp:Label>
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="Class1" />
            <asp:ImageButton ID="ImageButton2" runat="server" OnClick="Class2" />
            <asp:ImageButton ID="ImageButton3" runat="server" OnClick="Class3" />
            <asp:ImageButton ID="ImageButton4" runat="server" OnClick="Class4" />
            <asp:ImageButton ID="ImageButton5" runat="server" OnClick="Class5" />
            <p />
            <p />
            <hr />
            <asp:DataGrid ID="dtResultado" runat="server" PageSize="10" AllowPaging="false" />
        </div>
    </form>
</body>
</html>