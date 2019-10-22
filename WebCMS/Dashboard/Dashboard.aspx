<%@ Page Title="Dashboard" Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="CoreNET.Web.Dashboard" Async="true" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Dashboard</title>

  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

  <link rel="stylesheet" href="css/shared/style.css" />
  <link rel="stylesheet" href="css/demo_1/style.css" />
</head>
<body>
  <form runat="server">
    <div class="main-panel" style="width:100%">
      <div class="content-wrapper">
        <div id="row_header" runat="server" class="row page-title-header"></div>
        <div id="row1" runat="server" class="row"></div>
        <div id="row2" runat="server" class="row"></div>
        <div id="row3" runat="server" class="row"></div>
        <div id="row4" runat="server" class="row"></div>
        <div id="row5" runat="server" class="row"></div>
      </div>
      <div id="footer" runat="server" ></div>
    </div>
  </form>
</body>
</html>
