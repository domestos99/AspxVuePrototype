<%@ Page Title="" Language="C#" MasterPageFile="~/lte.master" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
    <link href="Scripts/vue/css/chunk-common.css" rel="stylesheet" /> <%-- Spolecny CSS pro vsechny stranky --%>
    <link href="Scripts/vue/css/partnersPage.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="Server">
  
    <section class="content container-fluid">
        
        <div id="PartnersPage"></div>
        

        <script src="Scripts/vue/js/chunk-vendors.js"></script> <%-- Spolecny JS pro vsechny stranky --%>
        <script src="Scripts/vue/js/chunk-common.js"></script> <%-- Spolecny JS pro vsechny stranky --%>
        <script src="Scripts/vue/js/partnersPage.js"></script>

    </section>
</asp:Content>