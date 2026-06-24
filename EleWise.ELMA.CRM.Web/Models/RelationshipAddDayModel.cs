// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.RelationshipAddDayModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Web.Mvc.Models.Forms;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class RelationshipAddDayModel : FormViewModel
  {
    public long EntityId { get; set; }

    public Guid EntityTypeUid { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Comment { get; set; }

    public string PopupId { get; set; }

    public bool UseDates { get; set; }
  }
}
