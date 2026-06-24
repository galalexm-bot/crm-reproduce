// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleChangeStatusModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class SaleChangeStatusModel : FormViewModel
  {
    public long EntityId { get; set; }

    public string PopupId { get; set; }

    public string Comment { get; set; }

    public SaleStatus Status { get; set; }

    public string ShortStatus { get; set; }

    public bool Break { get; set; }
  }
}
