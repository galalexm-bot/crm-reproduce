using System;
using System.Linq;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Excel;

[Component]
internal class DateTimeExportExcelStyledValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	private const int DateTimeFormat = 22;

	private const int DateFormat = 14;

	private const int TimeFormat = 20;

	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		DateTimeSettings dateTimeSettings = entity.GetPropertySettings(propertyUid) as DateTimeSettings;
		bool flag = dateTimeSettings?.ShowDate ?? true;
		bool flag2 = dateTimeSettings?.ShowTime ?? true;
		if (flag || flag2)
		{
			cellStyle.set_Number((flag && flag2) ? 22 : (flag ? 14 : 20));
		}
		return entity.GetPropertyValue(propertyUid);
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata != null)
		{
			return propertyMetadata.TypeUid == DateTimeDescriptor.UID;
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		return entity.GetPropertyValue(propertyUid);
	}
}
