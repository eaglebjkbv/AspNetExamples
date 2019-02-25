<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AnaMenuControl.ascx.cs" Inherits="MasterPageUygulama20181231.AnaMenuControl" %>
<table>
    <tr>
        <td><asp:HyperLink ID="HyperLink1" NavigateUrl="default.aspx" runat="server">Ana Sayfa</asp:HyperLink></td>
        <td><asp:HyperLink ID="HyperLink2" NavigateUrl="iletisim.aspx" runat="server">İletişim</asp:HyperLink></td>
        <td><asp:HyperLink ID="HyperLink3" NavigateUrl="none.aspx" runat="server">Fotograflar</asp:HyperLink></td>
    </tr>
</table>
