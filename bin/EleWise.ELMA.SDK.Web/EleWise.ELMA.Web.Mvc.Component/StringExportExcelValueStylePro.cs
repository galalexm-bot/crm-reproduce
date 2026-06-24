using System;
using System.Linq;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Excel;

[Component]
internal class StringExportExcelValueStyleProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		object propertyValue = entity.GetPropertyValue(propertyUid);
		if (propertyValue == null)
		{
			return propertyValue;
		}
		string text = propertyValue.ToString();
		if (text != null && text.Contains(Environment.NewLine))
		{
			cellStyle.set_IsTextWrapped(true);
		}
		return text;
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata != null)
		{
			if (!(propertyMetadata.TypeUid == StringDescriptor.UID) && !(propertyMetadata.TypeUid == TextDescriptor.UID))
			{
				return propertyMetadata.TypeUid == HtmlStringDescriptor.UID;
			}
			return true;
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		return entity.GetPropertyValue(propertyUid);
	}
}
