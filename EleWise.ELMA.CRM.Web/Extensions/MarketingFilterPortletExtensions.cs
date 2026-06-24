// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.MarketingFilterPortletExtensions
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using System;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [Component(Order = 1200)]
  public class MarketingFilterPortletExtensions : FilterPortletExtensions
  {
    protected virtual bool AddColumnTypeIcon => true;

    public virtual bool AvailableFilterType(Guid filterTypeUid) => filterTypeUid == InterfaceActivator.UID<IMarketingBase>();
  }
}
