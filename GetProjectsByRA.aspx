<%@ Page Title="Projects" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetProjectsByRA.aspx.cs" Inherits="web_app_assigment_4.GetProjectsByRA" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <main>
        <asp:Repeater ID="ProjectsTable" runat="server">
    <ItemTemplate>
        
        <a href="GetProjectsByDetails.aspx?id=<%# Eval("Projectid")%> ">
            <%# Eval("ProjectName") %>
        </a>
        <br />
    </ItemTemplate>
</asp:Repeater>

    </main>


</asp:Content>
