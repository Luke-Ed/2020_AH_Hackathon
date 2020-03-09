<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_2020_AH_Hackathon._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>MindFull</title>
  <link href="base.css" rel="stylesheet" />
</head>
<body>
  <form id="form1" runat="server">
    <div class="topBar">
    <div class="companyName" >
      <img src="Assets/brain.svg"/><h1>MindFull</h1>
    </div>
      <nav style="float: right">
        <asp:HyperLink runat="server" NavigateUrl="AboutUs.aspx">About Us</asp:HyperLink>
      </nav>
      <div style="clear: both"></div>
    </div>
    
    <div class="getStartedBtn">
      <asp:Button runat="server" Text="Get Started" ID="btnGetStarted" OnClick="btnGetStarted_Click" CssClass="bigButton"/>
    </div>
  </form>
</body>
</html>