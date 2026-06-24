using System;
using System.Linq.Expressions;
using Aspose.Cells;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ExportExcelValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	private static readonly string MarketingGroupName = LinqUtils.NameOf((Expression<Func<IMarketingActivityTarget, object>>)((IMarketingActivityTarget l) => l.MarketingGroup));

	private static readonly string MarketingActivityName = LinqUtils.NameOf((Expression<Func<IMarketingActivityTarget, object>>)((IMarketingActivityTarget l) => l.MarketingActivity));

	private static readonly string MarketingEffectName = LinqUtils.NameOf((Expression<Func<IMarketingActivityTarget, object>>)((IMarketingActivityTarget l) => l.MarketingEffect));

	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		object value = GetValue(entity, propertyUid);
		cellStyle.set_IsTextWrapped(true);
		return value;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		string text = "";
		if (entity.GetPropertyValue(MarketingGroupName, null) is IMarketingGroup marketingGroup)
		{
			text = marketingGroup.Name;
		}
		if (entity.GetPropertyValue(MarketingActivityName, null) is IMarketingActivity marketingActivity)
		{
			text = text + Environment.NewLine + marketingActivity.Name;
		}
		if (entity.GetPropertyValue(MarketingEffectName, null) is IMarketingEffect marketingEffect)
		{
			text = text + Environment.NewLine + marketingEffect.Name;
		}
		return text;
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if (entity is IMarketingActivityTarget)
		{
			return propertyUid == GetMarketingEffectPropertyUid(entity);
		}
		return false;
	}

	[ContextCache]
	internal virtual Guid GetMarketingEffectPropertyUid(IEntity entity)
	{
		return InterfaceActivator.LoadPropertyMetadata(entity.GetType(), MarketingEffectName, inherit: true)?.Uid ?? Guid.Empty;
	}
}
