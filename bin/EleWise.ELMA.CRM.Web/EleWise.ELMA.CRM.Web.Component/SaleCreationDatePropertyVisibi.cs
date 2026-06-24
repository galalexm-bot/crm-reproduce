using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleCreationDatePropertyVisibility : IFilterPropertiesExtension
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
		if (!(filterObjectTypeUid != InterfaceActivator.UID<ISale>()))
		{
			Guid creationDatePropertyUid = InterfaceActivator.PropertyUid((ISaleFilter f) => f.CreationDate);
			properties.Where((FilterMetadataProperty prop) => prop.PropertyUid == creationDatePropertyUid).Each(delegate(FilterMetadataProperty prop)
			{
				prop.Visible = true;
			});
		}
	}
}
