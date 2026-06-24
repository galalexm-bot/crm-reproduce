// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.SaleFunnelReportFilterModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Web.Models
{
  [Component]
  public class SaleFunnelReportFilterModel : EntityModel<ISaleFunnel>
  {
    public FilterModel DataFilter { get; set; }
  }
}
