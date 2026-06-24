using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.Components;

[Component]
public class MessagesChangesLoader : EntityChangesLoader
{
	public override bool IsTypeSupported(Guid typeUid)
	{
		if (MetadataLoader.LoadMetadata(typeUid) is ClassMetadata classMetadata)
		{
			if (InterfaceActivator.LoadMetadata<IBaseMessage>() != classMetadata)
			{
				return MetadataLoader.IsBaseClass(InterfaceActivator.UID<IBaseMessage>(), classMetadata);
			}
			return true;
		}
		return false;
	}
}
