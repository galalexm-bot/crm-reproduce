// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.FilterPortletExcludedTypesExtension
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using System;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [Component]
  internal class FilterPortletExcludedTypesExtension : IFilterPortletExcludedTypes
  {
    public Guid GetExcludedTypeUid() => SaleFunnelManager.SaleFunnelReportUid;
  }
}
