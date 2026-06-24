// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.AddMarketingTagPopupViewModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class AddMarketingTagPopupViewModel
  {
    public string Id { get; set; }

    public IMarketingTag Entity { get; set; }

    public string PopupId { get; set; }

    public string DicesId { get; set; }

    public string Prefix { get; set; }

    public string JsonDataId { get; set; }

    public string IdAttributeName { get; set; }
  }
}
