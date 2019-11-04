using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Collections.Generic;
using Ext.Net;
using Ext.Net.Utilities;
using CoreNET.Common.Base;
using CoreNET.Common.BO;

namespace CoreNET.Common.BO
{
  #region CoreNET.Common.BO.DwapbdControl, CoreNET.Common.SIPD
  [Serializable]
  public class DwapbdControl : BaseDataControlUIEntry, IDataControlUIEntry, IHasJSScript, IExtLoadCsv
  {
    #region Properties 
    public string Id { get; set; }
    public string Kdbab { get; set; }
    public string Kddata { get; set; }
    public string Kdfung1 { get; set; }
    public string Kdfung2 { get; set; }
    public string Kdfung3 { get; set; }
    public string Kdjns { get; set; }
    public string Kdkeg { get; set; }
    public string Kdkel { get; set; }
    public string Kdobj { get; set; }
    public string Kdor1 { get; set; }
    public string Kdor2 { get; set; }
    public string Kdor3 { get; set; }
    public string Kdor4 { get; set; }
    public string Kdor5 { get; set; }
    public string Kdpemda { get; set; }
    public string Kdpr { get; set; }
    public string Kdrnc { get; set; }
    public decimal Nilai { get; set; }
    public string Nmbab { get; set; }
    public string Nmfung1 { get; set; }
    public string Nmfung2 { get; set; }
    public string Nmfung3 { get; set; }
    public string Nmjns { get; set; }
    public string Nmkeg { get; set; }
    public string Nmkel { get; set; }
    public string Nmobj { get; set; }
    public string Nmor1 { get; set; }
    public string Nmor2 { get; set; }
    public string Nmor3 { get; set; }
    public string Nmor4 { get; set; }
    public string Nmor5 { get; set; }
    public string Nmpr { get; set; }
    public string Nmrnc { get; set; }
    public string Satker { get; set; }
    public string Tahun { get; set; }
    #endregion Properties 

    #region Methods 
    public DwapbdControl()
    {
      XMLName = ConstantTables.XMLDWAPBD;
    }
    ViewListProperties cViewListProperties = null;
    public new IProperties GetProperties()
    {
      if(cViewListProperties == null)
      {
        cViewListProperties = (ViewListProperties)base.GetProperties();
      }
      cViewListProperties.TitleList = ConstantDict.Translate(XMLName);
      cViewListProperties.PrimaryKeys = new String[] { "Id" };
      cViewListProperties.IDKey = "Id";//IDKey for ID Notes
      cViewListProperties.IDProperty = "Id";//UniqueKey in gridview
      cViewListProperties.ReadOnlyFields = new String[] {};//Key in GetFilters should put here
      cViewListProperties.SortFields = new String[] {"Id"};//
      cViewListProperties.ModeEditable = ViewListProperties.MODE_EDITABLE_ADD_DEL;
      cViewListProperties.EntryStyle = ViewListProperties.ENTRY_STYLE_FORM;
      //cViewListProperties.EntryStyle = ViewListProperties.ENTRY_STYLE_LOOKUP;
      //cViewListProperties.LookupDC = "CoreNET.Common.BO.DmstatusLookupControl, CoreNET.Common.Sys";
      //cViewListProperties.LookupLabelQuery = BaseDataControl.LOOKUP;
      return cViewListProperties;
    }
    DataControlFieldCollection columns = null;
    public override DataControlFieldCollection GetColumns()
    {
      if (columns == null)
      {
        columns = new DataControlFieldCollection
        {
          Fields.Create(ConstantDict.GetColumnTitle("Statusicon"), typeof(Icon), 5, HorizontalAlign.Center)
        };
        //columns.Add(ExtFields.GetRatingField());
        //columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Stricon"), typeof(CommandColumn), Cmds, 5, HorizontalAlign.Center));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Id"), typeof(string), 10, HorizontalAlign.Left).SetEditable(true));
        //columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Tahun"), typeof(string), 10, HorizontalAlign.Left).SetEditable(true));
        //columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Satker"), typeof(string), 10, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdpemda"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kddata"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdbab"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmbab"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdkel"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmkel"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdjns"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmjns"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdobj"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmobj"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdrnc"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmrnc"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdor1"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmor1"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdor2"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmor2"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdor3"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmor3"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdor4"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmor4"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdor5"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmor5"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdpr"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmpr"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdkeg"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmkeg"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdfung1"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmfung1"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdfung2"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmfung2"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Kdfung3"), typeof(string), 30, HorizontalAlign.Left).SetEditable(true));
        columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nmfung3"), typeof(string), 50, HorizontalAlign.Left).SetEditable(true));
        //columns.Add(Fields.Create(ConstantDict.GetColumnTitle("Nilai"), typeof(decimal), 15, HorizontalAlign.Right));
      }
      return columns;
    }
    public new void SetPageKey()
    {
    }
    public new void SetFilterKey(BaseBO bo)
    {
      if (typeof(IDataControlMenu).IsInstanceOfType(bo))
      {
        //This Is Sample.For more than 2 filter, must checking if property have had value
        Last_by = !string.IsNullOrEmpty(Last_by) ? Last_by : ((BaseBO)bo).Userid;
      }
    }
    public new void SetPrimaryKey()
    {
      //Id = Guid.NewGuid().ToString();
      //string sql = string.Format("select top 1 NOTR from TR order by NOTR desc");
      //string[] fields = new string[] { "Notr" };
      //int length = 5;
      //string prefix = string.Empty;
      //string sufix = string.Empty;
      //UtilityUI.GetNoUrut(this, sql, fields, length, prefix, sufix);
    }
    public new HashTableofParameterRow GetFilters()
    {
      bool enableFilter = string.IsNullOrEmpty(GlobalAsp.GetRequestIdPrev());
      HashTableofParameterRow hpars = new HashTableofParameterRow();
      //hpars.Add(DmtahunLookupControl.Instance.GetLookupParameterRow(this, false).SetEnable(enableFilter));
      //hpars.Add(new ParameterRowDate(this, ParameterRow.MODE_DATE_RANGE).SetEnable(enableFilter));
      //hpars.Add(new ParameterRowSelect(ConstantDict.GetColumnTitle("Status"),
      //    DmstatusLookupControl.GetListDataSingleton(), "Idstatus=Nmstatus", 30).SetAllowRefresh(false).SetEnable(enableFilter));
      return hpars;
    }
    public new IList View()
    {
      IList list = this.View(BaseDataControl.ALL);
      return list;
    }
    public new IList View(string label)
    {
      IList list = ((BaseDataControl)this).View(label);
      List<DwapbdControl> ListData = new List<DwapbdControl>();
      foreach(DwapbdControl dc in list)
      {
        DmstatusLookupControl.FindAndSetValuesInto(dc);
        ListData.Add(dc);
      }
      //Update(ListData);
      return ListData;
    }
    //Unuk ParameterLookup2, pastikan parameter entry is true
    HashTableofParameterRow hpars = null;
    public override HashTableofParameterRow GetEntries()
    {
      bool enable = true;
      if (hpars == null)
      {
        hpars = new HashTableofParameterRow();
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Id"), false, 30).SetEnable(enable));
        //hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Tahun"), true, 100).SetEnable(enable));
        //hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Satker"), true, 100).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdpemda"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kddata"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdbab"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmbab"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdkel"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmkel"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdjns"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmjns"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdobj"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmobj"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdrnc"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmrnc"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdor1"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmor1"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdor2"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmor2"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdor3"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmor3"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdor4"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmor4"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdor5"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmor5"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdpr"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmpr"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdkeg"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmkeg"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdfung1"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmfung1"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdfung2"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmfung2"), true, 3).SetEnable(enable));
        hpars.Add(new ParameterRowTextBox(this, ConstantDict.GetColumnTitle("Kdfung3"), false, 30).SetEnable(enable));
        hpars.Add(new ParameterRowMemo(this, ConstantDict.GetColumnTitle("Nmfung3"), true, 3).SetEnable(enable));
        //hpars.Add(new ParameterRowNumeric(this, ConstantDict.GetColumnTitle("Nilai"), true, 30).SetEnable(enable));
        //hpars.Add(DmtahunLookupControl.Instance.GetLookupParameterRow(this, true).SetEnable(enable));
        //hpars.Add(new ParameterRowSelect(ConstantDict.GetColumnTitle("Kdlevel"),
        //  DmlevelLookupControl.GetListDataSingleton(), "Kdlevel=Nmlevel", 30).SetAllowRefresh(false).SetEnable(enable));
        //hpars.Add(new ParameterRowType(this, true));
        hpars.Add(new ParameterRowSelect(ConstantDict.GetColumnTitleEntry("Status"),
          DmstatusLookupControl.GetListDataSingleton(), "Idstatus=Nmstatus", 30).SetAllowRefresh(false).SetEnable(enable));
        //hpars.Add(new ParameterRowCek(this, true));
        hpars.Add(new ParameterRowUploadFile(this, true));
        hpars.Add(new ParameterRowHelp(this, true));
        hpars.Add(new ParameterRowForum(this, true));
      }
      return hpars;
    }
    public new string[] GetScript()
    {
      string script = @"
        var ShowHidden = function (type) {
          if (type=='D') {
            return 'visible';/**/
          }else{
            return 'hidden';/**/
          }
        };
        var prepareNchildstrCommand = function(grid, command, record, row, col, value)
        {
          command.command = command.command.replace('Detil', 'Link');
        };
      ";
      return new string[] { script };
    }
    public new string[] GetKeys()
    {
      return new string[]{"Id","Tahun","Satker","Kdpemda","Kddata","Kdbab","Nmbab","Kdkel","Nmkel","Kdjns","Nmjns","Kdobj","Nmobj","Kdrnc","Nmrnc","Kdor1","Nmor1","Kdor2","Nmor2","Kdor3","Nmor3","Kdor4","Nmor4","Kdor5","Nmor5","Kdpr","Nmpr","Kdkeg","Nmkeg","Kdfung1","Nmfung1","Kdfung2","Nmfung2","Kdfung3","Nmfung3","Nilai","Kdlevel","Type"};
    }
    public new string[] GetCsvColumns(int mode)
    {
      return new string[]{"Id","Tahun","Satker","Kdpemda","Kddata","Kdbab","Nmbab","Kdkel","Nmkel","Kdjns","Nmjns","Kdobj","Nmobj","Kdrnc","Nmrnc","Kdor1","Nmor1","Kdor2","Nmor2","Kdor3","Nmor3","Kdor4","Nmor4","Kdor5","Nmor5","Kdpr","Nmpr","Kdkeg","Nmkeg","Kdfung1","Nmfung1","Kdfung2","Nmfung2","Kdfung3","Nmfung3","Nilai","Kdlevel","Type"};
    }
    public new string[] GetLoadCsvColumns()
    {
      return new string[]{"Id","Tahun","Satker","Kdpemda","Kddata","Kdbab","Nmbab","Kdkel","Nmkel","Kdjns","Nmjns","Kdobj","Nmobj","Kdrnc","Nmrnc","Kdor1","Nmor1","Kdor2","Nmor2","Kdor3","Nmor3","Kdor4","Nmor4","Kdor5","Nmor5","Kdpr","Nmpr","Kdkeg","Nmkeg","Kdfung1","Nmfung1","Kdfung2","Nmfung2","Kdfung3","Nmfung3","Nilai","Kdlevel","Type"};
    }
    #endregion Methods 
  }
  #endregion Dwapbd
}

