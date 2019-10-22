<%@ Page Language="C#" AutoEventWireup="True" ValidateRequest="false" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server" ShowWarningOnAjaxFailure="false" />
    <ext:Viewport ID="Viewport1" runat="server" Layout="Fit" AutoScroll="true">
      <Content>
          <Items>
            <ext:Portal runat="server" Border="false" Layout="Column">
              <Items>
                <ext:PortalColumn
                  runat="server"
                  Cls="x-column-padding"
                  ColumnWidth=".33"
                  Layout="Anchor">
                  <Items>
                    <ext:Portlet ID="Portlet1" runat="server" Title="Another Panel 1" Icon="Accept" />
                    <ext:Portlet ID="Portlet2" runat="server" Title="Panel 2" />
                    <ext:Portlet ID="Portlet3" runat="server" Title="Another Panel 2" />
                  </Items>
                </ext:PortalColumn>
                <ext:PortalColumn
                  runat="server"
                  Cls="x-column-padding"
                  ColumnWidth=".33"
                  Layout="Anchor">
                  <Items>
                    <ext:Portlet ID="Portlet4" runat="server" Title="Panel 3" />
                    <ext:Portlet ID="Portlet5" runat="server" Title="Another Panel 3" />
                    <ext:Portlet ID="Portlet6" runat="server" Title="Another Panel 1" Icon="Accept" />
                  </Items>
                </ext:PortalColumn>
                <ext:PortalColumn
                  runat="server"
                  Cls="x-column-padding1"
                  ColumnWidth=".33"
                  Layout="Anchor">
                  <Items>
                    <ext:Portlet ID="Portlet7" runat="server" Title="Panel 2" />
                    <ext:Portlet ID="Portlet8" runat="server" Title="Another Panel 2" />
                    <ext:Portlet ID="Portlet9" runat="server" Title="Panel 2" />
                    <ext:Portlet ID="Portlet10" runat="server" Title="Another Panel 2" />
                  </Items>
                </ext:PortalColumn>
              </Items>
            </ext:Portal>
          </Items>
      </Content>
    </ext:Viewport>
  </form>
</body>
</html>
