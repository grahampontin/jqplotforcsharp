<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TestWebApp._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   Test Chart
   <asp:Literal id="Chart1" runat=server></asp:Literal>
   
   <asp:Literal id="Chart2" runat=server></asp:Literal>
   
   
   
   <div id="Div1" style="height:400px;width:900px; "></div>
   <script language='javascript'>       $.jqplot('Div1', [[1, 2, 3], [4, 5, 6]], { "stackSeries": true, "legend": { "show": true, "location": "se" }, "title": "HELLO!", "axes": { "xaxis": { "show": true, "label": "The mighty x-axis", "showLabel": true, "ticks": ["1", "2", "3"], renderer: $.jqplot.CategoryAxisRenderer }, "yaxis": { "show": true, "label": "I\u0027m very exciting", "showLabel": true, "ticks": ["0", "10"]} }, "grid": {}, "drawIfHidden": false, "series": [{ "renderer": $.jqplot.BarRenderer, "rendererOptions": {}, "label": "The first ever series there was" }, { "renderer": $.jqplot.BarRenderer, "rendererOptions": {}, "label": "The first ever series there was"}] });</script>
   
</asp:Content>
