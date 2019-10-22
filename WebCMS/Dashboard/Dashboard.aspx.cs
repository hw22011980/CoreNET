using CoreNET.Common.BO;
using CoreNET.Common.Base;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace CoreNET.Web
{
  public partial class Dashboard : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string mode = GlobalAsp.GetRequestMode();
      string val = GlobalAsp.GetRequestVal();
      DashboardUtils utils = new DashboardUtils(mode,val);
      row_header.InnerHtml = utils.HTMLs[DataHelper.ROW_HEADER];
      SetHtml(row1, utils);
      SetHtml(row2, utils);
      SetHtml(row3, utils);
      SetHtml(row4, utils);
      SetHtml(row5, utils);
    }

    public void SetHtml(HtmlGenericControl div, DashboardUtils utils)
    {
      string html = utils.HTMLs[div.ID];
      if (string.IsNullOrEmpty(html))
      {
        div.Visible = false;
      }
      else
      {
        div.InnerHtml = html;
      }
    }
  }

}