using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.PropertyHandlers;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 20)]
public class CreateSubtaskDocumentsActionHandler : ICreateSubtaskActionHandler, IEventHandler
{
	public void ProcessBeforeCreate(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel)
	{
		if (source == null || !(subtaskModel is ICreateSubtaskWithDocumentsActionModel) || !((ICreateSubtaskWithDocumentsActionModel)subtaskModel).CopyDocuments)
		{
			return;
		}
		((ClassMetadata)MetadataLoader.LoadMetadata(target.GetType())).Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList().ForEach(delegate(PropertyMetadata p)
		{
			PropertyInfo reflectionProperty = target.GetType().GetReflectionProperty(p.Name);
			if (reflectionProperty != null)
			{
				UntypedISetProxy untypedISetProxy = reflectionProperty.GetValue(source, null).AsUntypedISet();
				UntypedISetProxy untypedISetProxy2 = reflectionProperty.GetValue(target, null).AsUntypedISet();
				if (untypedISetProxy != null && untypedISetProxy2 != null)
				{
					foreach (IDocumentAttachment item in untypedISetProxy)
					{
						if (item.Document != null)
						{
							long documentId = item.Document.Id;
							if (untypedISetProxy2.OfType<IDocumentAttachment>().All((IDocumentAttachment a) => a.Document == null || a.Document.Id != documentId))
							{
								untypedISetProxy2.Add(CloneHelperBuilder.Create(item).Clone());
							}
						}
					}
				}
			}
		});
		if (target is IAttachmentsTaskBase attachmentsTaskBase && source is IAttachmentsTaskBase attachmentsTaskBase2)
		{
			attachmentsTaskBase.DocumentAttachmentsSpecified.AddAll((ICollection<IDocumentAttachment>)attachmentsTaskBase2.DocumentAttachmentsSpecified);
		}
	}

	public void ProcessBeforeSave(ITaskBase source, ITaskBase target, ICreateSubtaskActionModel subtaskModel)
	{
	}

	public static bool IsDefaultValueDocument(ITaskBase source)
	{
		if (source != null)
		{
			if (source is IAttachmentsTaskBase attachmentsTaskBase && attachmentsTaskBase.DocumentAttachmentsSpecified != null && ((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified).Count > 0)
			{
				return false;
			}
			foreach (PropertyMetadata item in ((ClassMetadata)MetadataLoader.LoadMetadata(source.GetType())).Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList())
			{
				PropertyInfo reflectionProperty = source.GetType().GetReflectionProperty(item.Name);
				if (reflectionProperty != null)
				{
					UntypedISetProxy untypedISetProxy = reflectionProperty.GetValue(source, null).AsUntypedISet();
					if (untypedISetProxy != null && untypedISetProxy.Count > 0)
					{
						return false;
					}
				}
			}
		}
		return true;
	}
}
