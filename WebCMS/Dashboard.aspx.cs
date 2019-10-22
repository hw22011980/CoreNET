using System;
using CoreNET.Common.Base;
using Ext.Net;
using Ext.Net.Utilities;

public partial class Dashboard : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!X.IsAjaxRequest)
    {
      string text = @"Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>";
      text += @"Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>Data 1=1<br/>";

      this.ResourceManager1.RegisterClientScriptBlock("text", string.Format("var text=\"{0}\";", text));

      foreach (Portlet portlet in ControlUtils.FindControls<Portlet>(this.Page))
      {
        portlet.LoadContent("http://localhost");
        portlet.Collapsible = true;
        //portlet.Html = "={text}";
        //portlet.Padding = 5;
        //portlet.Tools.Add(new Tool(ToolType.Close, string.Concat(portlet.ClientID, ".hide();"), "Close Portlet"));
      }
    }

    foreach (Portlet portlet in ControlUtils.FindControls<Portlet>(this.Page))
    {
      portlet.DirectEvents.Hide.Event += Portlet_Hide;
      portlet.DirectEvents.Hide.EventMask.ShowMask = true;
      portlet.DirectEvents.Hide.EventMask.Msg = "Saving...";
      portlet.DirectEvents.Hide.EventMask.MinDelay = 500;

      portlet.DirectEvents.Hide.ExtraParams.Add(new Ext.Net.Parameter("ID", portlet.ClientID));
    }
  }

  protected void Portlet_Hide(object sender, DirectEventArgs e)
  {
    X.Msg.Alert("Status", e.ExtraParams["ID"] + " Hidden").Show();
  }
}