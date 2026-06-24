using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal class ExclusionEntityNullifierDocument : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		List<Guid> list = new List<Guid>();
		foreach (ClassMetadata childClass in MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IReference>())))
		{
			list.Add(childClass.Uid);
		}
		foreach (ClassMetadata childClass2 in MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IDmsObject>())))
		{
			list.Add(childClass2.Uid);
		}
		list.Add(InterfaceActivator.UID<IFolderReference>());
		list.Add(InterfaceActivator.UID<IDocumentReference>());
		list.Add(InterfaceActivator.UID<IDocumentLink>());
		list.Add(InterfaceActivator.UID<IDocumentMetadataProfile>());
		list.Add(InterfaceActivator.UID<ILifeCycleStatus>());
		list.Add(InterfaceActivator.UID<ILifeCycleTransition>());
		list.Add(InterfaceActivator.UID<IDocumentHistoryChapter>());
		list.Add(InterfaceActivator.UID<IDocumentHistoryProfile>());
		list.Add(InterfaceActivator.UID<IDmsObjectDefaultPermissions>());
		list.Add(InterfaceActivator.UID<IDocumentVersion>());
		list.Add(InterfaceActivator.UID<IDocumentAttachment>());
		list.Add(InterfaceActivator.UID<ISendDocumentType>());
		list.Add(InterfaceActivator.UID<IDocumentHistoryAction>());
		return list;
	}
}
