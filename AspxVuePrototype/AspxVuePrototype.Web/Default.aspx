<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspxVuePrototype.Web._Default" %>




<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <%--<link href="vue/dist/css/default.css" rel="stylesheet" />--%>
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="DefaultPage">
    </div>


    <script src="vue/dist/js/default.js"></script>
    <script src="vue/dist/js/chunk-vendors.js"></script>


</asp:Content>
