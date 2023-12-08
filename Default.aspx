<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web_app_assigment_4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Repeater ID="InstitutionTable" runat="server">
            <ItemTemplate>
                <p>
                <a href="GetRAByInstitution.aspx?id=<%# Eval("Institutionid")%> ">
                    <%# Eval("InstitutionName") %>
                </a>
                </p>
            </ItemTemplate>
        </asp:Repeater>


    </main>

</asp:Content>
