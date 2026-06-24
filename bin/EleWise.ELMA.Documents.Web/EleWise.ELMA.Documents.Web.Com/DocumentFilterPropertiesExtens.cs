using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal sealed class DocumentFilterPropertiesExtension : IFilterPropertiesExtension
{
	public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		throw new NotImplementedException();
	}

	public bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return false;
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
		if (filterObjectTypeUid.HasValue && !(filterObjectTypeUid != InterfaceActivator.UID<IDocument>()))
		{
			Guid permissionsPropertyUid = InterfaceActivator.PropertyUid((IDocumentFilter f) => f.Permissions, inherit: true);
			properties.Where((FilterMetadataProperty prop) => prop.PropertyUid == permissionsPropertyUid).Each(delegate(FilterMetadataProperty prop)
			{
				prop.Visible = false;
			});
		}
	}
}
