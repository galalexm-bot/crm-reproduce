using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentSystemFieldsProvider : IConvertDocumentSystemFields
{
	public List<Guid> GetSytemFieldsUids(Guid docTypeUid)
	{
		List<Guid> list = new List<Guid>();
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.Uid));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.Permissions));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.Versions));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.SortTypeId));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.InheritPermissions));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.Virtual));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.IsArchived));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.IsDeleted));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.HardDelete));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.OldFolder));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.Comments));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.Template));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.Attachments));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.DocumentAttachments));
		list.Add(InterfaceActivator.PropertyUid((IDocument m) => m.CurrentVersion));
		list.Add(InterfaceActivator.PropertyUid((IDmsObject m) => m.Name));
		return list;
	}
}
