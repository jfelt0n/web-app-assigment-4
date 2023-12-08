<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ObservationSubmission.aspx.cs" Inherits="web_app_assigment_4.ObservationSubmission" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Observation Submission</h1>
    <asp:Panel ID="Observations" runat="server" Visible="false">
        <label for="Date">Observed Date:</label>
        <asp:TextBox ID="Date" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
        <br />
        <label for="Notes">Notes:</label>
        <asp:TextBox ID="Notes" runat="server" Text="Create Observation" OnClick="Create_Click" CssClass="btn btn-primary" />


    </asp:Panel>
    </asp:Content>