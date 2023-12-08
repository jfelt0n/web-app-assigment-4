<%@ Page Title="ResearchArea" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetRAByInstitution.aspx.cs" Inherits="web_app_assigment_4.GetRAByInstitution" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <asp:Repeater ID="ResearchAreasTable" runat="server">
    <ItemTemplate>
        
        <a href="GetProjectsByRA.aspx?Researchid=<%# Eval("Researchid")%> ">
            <%# Eval("ResearchName") %>
        </a>
        <br />
    </ItemTemplate>
</asp:Repeater>

    </main>
        
</asp:Content>
