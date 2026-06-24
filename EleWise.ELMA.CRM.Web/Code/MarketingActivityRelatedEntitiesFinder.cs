// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Code.MarketingActivityRelatedEntitiesFinder
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Code
{
  public static class MarketingActivityRelatedEntitiesFinder
  {
    public static GridData<T> Find<T>(GridCommand command, IMarketingBase marketingBase) where T : class, IEntity<long>
    {
      if (marketingBase == null)
        return MarketingActivityRelatedEntitiesFinder.CreateEmptyResult<T>(command);
      object filter = InterfaceActivator.Create(ModelHelper.GetEntityFilterType(typeof (T)));
      if (!(filter is IMarketingActivityTargetFilter activityTargetFilter))
        return MarketingActivityRelatedEntitiesFinder.CreateEmptyResult<T>(command);
      activityTargetFilter.MarketingObjects.Add(marketingBase);
      return (GridData<T>) AbstractNHEntityManager<T, long>.Instance.CreateGridData<T, IEntityFilter>(command, filter as IEntityFilter);
    }

    private static GridData<T> CreateEmptyResult<T>(GridCommand command) where T : class, IEntity<long> => AbstractNHEntityManager<T, long>.Instance.CreateGridData<T>(command);
  }
}
