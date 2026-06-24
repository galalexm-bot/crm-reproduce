using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 90)]
internal class TaskControlFilterPropertyExtension : IFilterPropertiesExtension
{
	private static HashedSet<string> hiddenProperties;

	public TaskControlFilterPropertyExtension()
	{
		HashedSet<string> val = new HashedSet<string>();
		((Set<string>)(object)val).Add(LinqUtils.NameOf((Expression<Func<ITaskControlFilter, object>>)((ITaskControlFilter p) => p.ControlType)));
		((Set<string>)(object)val).Add(LinqUtils.NameOf((Expression<Func<ITaskControlFilter, object>>)((ITaskControlFilter p) => p.UnderControl)));
		((Set<string>)(object)val).Add(LinqUtils.NameOf((Expression<Func<ITaskControlFilter, object>>)((ITaskControlFilter p) => p.ControlUser)));
		hiddenProperties = val;
	}

	public virtual bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return false;
	}

	public virtual IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		throw new NotImplementedException();
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
		if (!filterObjectTypeUid.HasValue || filterObjectTypeUid.Value != TaskControlUniqueFilterExtension.Guid)
		{
			return;
		}
		AddObjectTypeProperty(filterObjectTypeUid.Value, properties);
		foreach (FilterMetadataProperty property in properties)
		{
			property.Hidden |= ((Set<string>)(object)hiddenProperties).Contains(property.PropertyName);
		}
	}

	private void AddObjectTypeProperty(Guid filterObjectTypeUid, List<FilterMetadataProperty> properties)
	{
		string propertyName = "ObjectsType";
		if (!properties.Any((FilterMetadataProperty p) => p.PropertyName == propertyName))
		{
			properties.Insert(0, new FilterMetadataProperty
			{
				PropertyName = propertyName,
				PropertyDisplayName = InterfaceActivator.LoadPropertyMetadata((IFilterFolder m) => m.ObjectsType).DisplayName,
				PropertyUid = FilterModel.ObjectsTypePropertyUid,
				ClassUid = filterObjectTypeUid
			});
		}
	}
}
