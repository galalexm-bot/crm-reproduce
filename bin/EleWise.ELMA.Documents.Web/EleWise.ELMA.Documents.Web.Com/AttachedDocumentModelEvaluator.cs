using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.PropertyHandlers;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class AttachedDocumentModelEvaluator : IHistoryModelEvaluator
{
	public void Evaluate(IHistoryBaseModel historyModel)
	{
		if (!(historyModel is IAttachedHistoryModel))
		{
			return;
		}
		if (historyModel is IDocumentAttachedHistoryModel documentAttachedHistoryModel)
		{
			historyModel.EventData.DocumentAttachments = documentAttachedHistoryModel.DocumentAttachments;
			return;
		}
		List<IDocumentAttachment> propertyAttachmentsValue = new List<IDocumentAttachment>();
		IEntity entity;
		if (!(historyModel is ReplacementTaskHistoryModel replacementTaskHistoryModel))
		{
			entity = historyModel.OriginalEvent.New;
		}
		else
		{
			IEntity replacementTask = replacementTaskHistoryModel.ReplacementTask;
			entity = replacementTask;
		}
		IEntity entity2 = entity;
		if (entity2 != null)
		{
			foreach (PropertyMetadata item in ((EntityMetadata)MetadataLoader.LoadMetadata(entity2.CastAsRealType().GetType())).Properties.Where((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == DocumentAttachmentsPropertyHandler.UID)).ToList())
			{
				List<IDocumentAttachment> collection = ((IEnumerable)entity2.GetPropertyValue(item.Uid)).Cast<IDocumentAttachment>().ToList();
				propertyAttachmentsValue.AddRange(collection);
			}
		}
		if (!historyModel.OriginalEvent.ExtendedProperties.ContainsKey(TaskActionEventArgs.HideAttachAndComments) || !Convert.ToBoolean(historyModel.OriginalEvent.ExtendedProperties[TaskActionEventArgs.HideAttachAndComments]))
		{
			List<IDocumentAttachment> list = (from IDocumentAttachment a in from e in Locator.GetServiceNotNull<IEntityActionHistoryLoader>().LoadHistory(historyModel.OriginalEvent.UnitOfWorkUid, InterfaceActivator.UID<IDocumentAttachment>(), DefaultEntityActions.CreateGuid)
					select e.New
				where propertyAttachmentsValue.Contains(a)
				select a).ToList();
			historyModel.EventData.DocumentAttachments = list;
		}
		else
		{
			historyModel.EventData.DocumentAttachments = new List<IDocumentAttachment>();
		}
	}
}
