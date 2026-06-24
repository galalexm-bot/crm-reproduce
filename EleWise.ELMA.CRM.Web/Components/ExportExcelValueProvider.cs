// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ExportExcelValueProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using Aspose.Cells;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class ExportExcelValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
  {
    private static readonly string MarketingGroupName = LinqUtils.NameOf<IMarketingActivityTarget>((Expression<Func<IMarketingActivityTarget, object>>) (l => l.MarketingGroup));
    private static readonly string MarketingActivityName = LinqUtils.NameOf<IMarketingActivityTarget>((Expression<Func<IMarketingActivityTarget, object>>) (l => l.MarketingActivity));
    private static readonly string MarketingEffectName = LinqUtils.NameOf<IMarketingActivityTarget>((Expression<Func<IMarketingActivityTarget, object>>) (l => l.MarketingEffect));

    public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
    {
      object styledValue = this.GetValue(entity, propertyUid);
      cellStyle.IsTextWrapped = true;
      return styledValue;
    }

    public object GetValue(IEntity entity, Guid propertyUid)
    {
      string str = "";
      if (entity.GetPropertyValue(ExportExcelValueProvider.MarketingGroupName, (object) null) is IMarketingGroup propertyValue1)
        str = propertyValue1.Name;
      if (entity.GetPropertyValue(ExportExcelValueProvider.MarketingActivityName, (object) null) is IMarketingActivity propertyValue2)
        str = str + Environment.NewLine + propertyValue2.Name;
      if (entity.GetPropertyValue(ExportExcelValueProvider.MarketingEffectName, (object) null) is IMarketingEffect propertyValue3)
        str = str + Environment.NewLine + propertyValue3.Name;
      return (object) str;
    }

    public bool Resolve(IEntity entity, Guid propertyUid) => entity is IMarketingActivityTarget && propertyUid == this.GetMarketingEffectPropertyUid(entity);

    [ContextCache]
    internal virtual Guid GetMarketingEffectPropertyUid(IEntity entity)
    {
      PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(entity.GetType(), ExportExcelValueProvider.MarketingEffectName, true);
      return propertyMetadata == null ? Guid.Empty : propertyMetadata.Uid;
    }
  }
}
