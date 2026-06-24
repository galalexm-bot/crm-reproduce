using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Common.ExtensionPoints;

[Component]
internal class ExclusionEntityNullifierCommon : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		List<Guid> list = new List<Guid>();
		foreach (ClassMetadata childClass in MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IFilter>())))
		{
			list.Add(childClass.Uid);
		}
		list.Add(InterfaceActivator.UID<IFilter>());
		list.Add(InterfaceActivator.UID<IFilterPermission>());
		list.Add(InterfaceActivator.UID<IWpiSelectListItem>());
		list.Add(InterfaceActivator.UID<IUnitMeasure>());
		list.Add(InterfaceActivator.UID<IWatch>());
		list.Add(InterfaceActivator.UID<ILastObjectInfo>());
		list.Add(InterfaceActivator.UID<IColor>());
		list.Add(InterfaceActivator.UID<ICatalogAccess>());
		list.Add(InterfaceActivator.UID<IAttachment>());
		list.Add(InterfaceActivator.UID<IEntityActionHistory>());
		list.Add(InterfaceActivator.UID<IUnitMeasureProperties>());
		list.Add(InterfaceActivator.UID<ITag>());
		list.Add(InterfaceActivator.UID<IPaperPin>());
		return list;
	}
}
