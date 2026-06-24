using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class TaskFilterPropertiesExtension : IFilterPropertiesExtension
{
	private Guid? periodicalPropertyUid;

	private Guid? underControlPropertyUid;

	public bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return false;
	}

	public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		throw new NotImplementedException();
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
		if (!type.IsInheritOrSame<ITaskFilter>())
		{
			return;
		}
		underControlPropertyUid = underControlPropertyUid ?? InterfaceActivator.PropertyUid((ITaskFilter p) => p.UnderControl);
		int num = properties.FindIndex((FilterMetadataProperty p) => p.PropertyUid == underControlPropertyUid.Value);
		if (num >= 0)
		{
			periodicalPropertyUid = periodicalPropertyUid ?? InterfaceActivator.PropertyUid((ITaskFilter p) => p.Periodical);
			int num2 = properties.FindIndex((FilterMetadataProperty p) => p.PropertyUid == periodicalPropertyUid.Value);
			if (num2 >= 0)
			{
				FilterMetadataProperty item = properties[num];
				properties.RemoveAt(num);
				properties.Insert((num < num2) ? num2 : (num2 + 1), item);
			}
		}
	}
}
