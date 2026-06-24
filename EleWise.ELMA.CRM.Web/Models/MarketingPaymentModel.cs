// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.MarketingPaymentModel
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class MarketingPaymentModel
  {
    public IEntity Entity { get; set; }

    public Money Budget { get; set; }

    public DateTime CreationDate { get; set; }
  }
}
