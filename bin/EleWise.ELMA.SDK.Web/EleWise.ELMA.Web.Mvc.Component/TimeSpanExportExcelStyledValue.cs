using System;
using System.Linq;
using System.Text;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Excel;

[Component]
internal class TimeSpanExportExcelStyledValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		return GetValue(entity, propertyUid);
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
		if (propertyMetadata != null)
		{
			return propertyMetadata.TypeUid == TimeSpanDescriptor.UID;
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		StringBuilder stringBuilder = new StringBuilder();
		TimeSpan timeSpan = (TimeSpan)entity.GetPropertyValue(propertyUid);
		if (timeSpan.Days > 0)
		{
			stringBuilder.Append(timeSpan.Days).Append(" ").Append(SR.T("дн"))
				.Append(" ");
		}
		if (timeSpan.Hours > 0)
		{
			stringBuilder.Append(timeSpan.Hours).Append(" ").Append(SR.T("ч"))
				.Append(" ");
		}
		if (timeSpan.Minutes > 0)
		{
			stringBuilder.Append(timeSpan.Minutes).Append(" ").Append(SR.T("мин"))
				.Append(" ");
		}
		if (timeSpan.Seconds > 0)
		{
			stringBuilder.Append(timeSpan.Seconds).Append(" ").Append(SR.T("сек"))
				.Append(" ");
		}
		if (timeSpan.Milliseconds > 0)
		{
			stringBuilder.Append(timeSpan.Milliseconds).Append(" ").Append(SR.T("мсек"));
		}
		return stringBuilder.ToString().Trim();
	}
}
