using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 100)]
public class ObjectsTypeFilterPropertyExtension : IFilterPropertiesExtension
{
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
		if (filterObjectTypeUid.HasValue && Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Where(delegate(IMetadata m)
		{
			if (m is ClassMetadata)
			{
				Guid baseClassUid = ((ClassMetadata)m).BaseClassUid;
				Guid? guid = filterObjectTypeUid;
				return baseClassUid == guid;
			}
			return false;
		})
			.OfType<ClassMetadata>()
			.Any())
		{
			properties.Insert(0, new FilterMetadataProperty
			{
				PropertyName = "ObjectsType",
				PropertyDisplayName = InterfaceActivator.LoadPropertyMetadata((IFilterFolder m) => m.ObjectsType).DisplayName,
				PropertyUid = FilterModel.ObjectsTypePropertyUid,
				ClassUid = filterObjectTypeUid.Value
			});
		}
	}
}
