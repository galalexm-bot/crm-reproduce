using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 100000)]
public class DocumentChannelMessageDiscussionExtension : IChannelMessageObjectsExtension
{
	public bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IDocument>(objectTypeUid);
	}

	public List<MessageObject> UpdateMessageObjectsNames(List<MessageObject> messageObjects)
	{
		IDocumentFilter documentFilter = InterfaceActivator.Create<IDocumentFilter>();
		documentFilter.DisableSecurity = true;
		documentFilter.DisableSoftDeletable = true;
		documentFilter.TypeUids = messageObjects.Select((MessageObject o) => o.TypeUid).ToList();
		documentFilter.Ids = messageObjects.Select((MessageObject o) => Convert.ToInt64(o.Id)).ToList();
		DocumentManager.Instance.Find(documentFilter, FetchOptions.All).ForEach(delegate(IDocument document)
		{
			int num = messageObjects.FindIndex((MessageObject o) => document.TypeUid == o.TypeUid && document.Id == Convert.ToInt64(o.Id));
			if (num != -1)
			{
				MessageObject value = messageObjects[num];
				value.Name = document.Name;
				messageObjects[num] = value;
			}
		});
		return messageObjects;
	}
}
