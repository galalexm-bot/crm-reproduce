using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Excel;

[Component]
internal class EnumExportExcelValueProvider : IExportExcelValueProvider
{
	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata != null)
		{
			return propertyMetadata.TypeUid == EnumDescriptor.UID;
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		return ModelHelper.GetEnumDisplayName(entity.GetPropertyValue(propertyUid));
	}
}
