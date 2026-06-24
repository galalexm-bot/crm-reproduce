using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100000)]
public class DocumentFeedMessageObjectsExtension : IFeedMessageObjectsExtension
{
	public bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IDocument>(objectTypeUid);
	}

	public Dictionary<MessageObject, object> GetMessageObjects(List<MessageObject> messageObjects)
	{
		Dictionary<MessageObject, object> dictionary = new Dictionary<MessageObject, object>();
		IEnumerable<DocumentCompactInfoModel> source = DocumentManager.Instance.DocumentCompactInfo(messageObjects.Select((MessageObject a) => Convert.ToInt64(a.Id)).ToList());
		foreach (MessageObject messageObject in messageObjects)
		{
			DocumentCompactInfoModel documentCompactInfoModel = source.FirstOrDefault((DocumentCompactInfoModel a) => Convert.ToInt64(messageObject.Id) == a.DocumentId);
			if (documentCompactInfoModel != null)
			{
				dictionary.Add(messageObject, documentCompactInfoModel);
			}
		}
		return dictionary;
	}
}
