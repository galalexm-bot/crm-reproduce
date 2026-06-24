// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Extensions.FilterPortletShowOnlyMyExtensions
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using System;

namespace EleWise.ELMA.CRM.Web.Extensions
{
  [Component]
  public class FilterPortletShowOnlyMyExtensions : IFilterPortletShowOnlyMy
  {
    public bool SetShowOnlyMy(FilterModel filterModel, bool showOnlyMy)
    {
      if (filterModel.FilterTypeUid == InterfaceActivator.UID<IContractor>())
      {
        ((IContractorFilter) filterModel.Filter).ShowOnlyMy = showOnlyMy;
        return true;
      }
      if (filterModel.FilterTypeUid == InterfaceActivator.UID<IContact>())
      {
        ((IContactFilter) filterModel.Filter).ShowOnlyMy = showOnlyMy;
        return true;
      }
      if (filterModel.FilterTypeUid == InterfaceActivator.UID<ILead>())
      {
        ((ILeadFilter) filterModel.Filter).ShowOnlyMy = showOnlyMy;
        return true;
      }
      if (!(filterModel.FilterTypeUid == InterfaceActivator.UID<ISale>()))
        return false;
      ((ISaleFilter) filterModel.Filter).ShowOnlyMy = showOnlyMy;
      return true;
    }

    public bool CheckShowOnlyMy(Guid TypeUid) => TypeUid == InterfaceActivator.UID<IContractor>() || TypeUid == InterfaceActivator.UID<IContact>() || TypeUid == InterfaceActivator.UID<ILead>() || TypeUid == InterfaceActivator.UID<ISale>();
  }
}
