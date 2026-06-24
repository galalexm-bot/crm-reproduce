// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.FullTextSearch.Models.CRMFullTextSearchSettingsModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.FullTextSearch;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Web.FullTextSearch.Models
{
  public class CRMFullTextSearchSettingsModel
  {
    public CRMFullTextSearchSettings Settings { get; set; }

    public FullTextSearchState IndexState { get; set; }

    public bool ReIndexState { get; set; }

    [DisplayName("SR.M('Индексировать приложения контрагентов')")]
    public bool IndexingContractorAttachments { get; set; }
  }
}
