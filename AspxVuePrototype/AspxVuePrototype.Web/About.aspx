<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AspxVuePrototype.Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    
    
    <div id="app">
    </div>
    
    <script src="vue/dist/js/main.js"></script>
    <script src="vue/dist/js/chunk-vendors.js"></script>
    

</asp:Content>
