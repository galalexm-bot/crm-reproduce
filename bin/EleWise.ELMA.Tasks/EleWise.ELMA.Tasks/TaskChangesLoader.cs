using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

[Component]
public class TaskChangesLoader : EntityChangesLoader
{
	public override bool IsTypeSupported(Guid typeUid)
	{
		if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
		{
			if (InterfaceActivator.LoadMetadata<ITaskBase>() != classMetadata)
			{
				return MetadataLoader.IsBaseClass(InterfaceActivator.UID<ITaskBase>(), classMetadata);
			}
			return true;
		}
		return false;
	}
}
