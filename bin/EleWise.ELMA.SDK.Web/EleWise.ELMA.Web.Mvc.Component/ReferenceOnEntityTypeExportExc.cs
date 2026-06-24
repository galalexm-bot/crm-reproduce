using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class ReferenceOnEntityTypeExportExcelValueProvider : IExportExcelValueProvider
{
	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata != null)
		{
			return propertyMetadata.TypeUid == ReferenceOnEntityTypeDecription.UID;
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		if (!(entity.GetPropertyValue(propertyUid) is ReferenceOnEntityType referenceOnEntityType))
		{
			return null;
		}
		return referenceOnEntityType.DisplayName;
	}
}
