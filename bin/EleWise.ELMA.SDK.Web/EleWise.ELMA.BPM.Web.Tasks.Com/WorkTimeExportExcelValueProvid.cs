using System;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal sealed class WorkTimeExportExcelValueProvider : IExportExcelValueProvider
{
	private static readonly long MaxTotalMinutes = (long)TimeSpan.MaxValue.TotalMinutes;

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		if (entity.GetPropertyValue(propertyUid) is WorkTime workTime)
		{
			long totalMinutes = workTime.TotalMinutes;
			if (totalMinutes <= MaxTotalMinutes)
			{
				return TimeSpan.FromMinutes(totalMinutes);
			}
			return workTime.TotalHours + ":" + workTime.Minutes;
		}
		return TimeSpan.Zero;
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if (MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) is ClassMetadata classMetadata)
		{
			return classMetadata.Properties.Any((PropertyMetadata prop) => prop.Uid == propertyUid && prop.TypeUid == WorkTimeDescriptor.UID);
		}
		return false;
	}
}
