using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
public class FullTextSearchCRMAttachmentHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private Guid uid = new Guid("96ACBF64-72D2-4B35-81AF-0DC975509852");

	private List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<ICRMAttachment>() };

	private List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Id)),
		LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Contractor)),
		LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Documents)),
		LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Files))
	};

	public override Guid Uid => uid;

	public override Type SupportedCard => typeof(IContractorFullTextSearchObject);

	public override List<Guid> SupportedUids => supportedUids;

	public override List<string> GetImportantProperties
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor || !serviceNotNull.Settings.IndexingContractorAttachments)
			{
				return new List<string>();
			}
			return importantProperties;
		}
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (mergedIndexQueueItem != null && serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor && serviceNotNull.Settings.IndexingContractorAttachments)
		{
			ICRMAttachment iCRMAttachment = CrmAttachmentManager.Instance.LoadOrNull(id);
			IContractor contractor = null;
			if (iCRMAttachment != null)
			{
				if (iCRMAttachment.Contractor != null)
				{
					contractor = iCRMAttachment.Contractor;
				}
			}
			else
			{
				KeyValuePair<string, object> keyValuePair = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Contractor))));
				if (keyValuePair.Key != null && keyValuePair.Value != null && long.TryParse(keyValuePair.Value.ToString(), out var result))
				{
					contractor = ContractorManager.Instance.LoadOrNull(result);
				}
			}
			if (contractor != null)
			{
				QueueToIndex queueToIndex = new QueueToIndex
				{
					Id = contractor.Id,
					CardType = typeof(IContractorFullTextSearchObject),
					Properties = new List<KeyValuePair<string, object>>()
				};
				ContractorFullTextSearchExtension.GetAttachmentsForContractor(contractor, out var attachmentsName, out var attachmentsText, out var documentsName, out var documentsId);
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsName)), new SerializableList<object>(attachmentsName)));
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsText)), new SerializableList<object>(attachmentsText)));
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsId)), new SerializableList<object>(documentsId.Cast<object>())));
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsName)), new SerializableList<object>(documentsName)));
				if (queueToIndex.Properties.Any())
				{
					list.Add(queueToIndex);
				}
			}
		}
		return list;
	}

	public override void OnInsertProcessing(Guid typeUid, object obj)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor && serviceNotNull.Settings.IndexingContractorAttachments)
		{
			ICRMAttachment attach = obj as ICRMAttachment;
			ProcessingForContractor(attach);
		}
	}

	public override void OnDeleteProcessing(Guid typeUid, object obj)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor && serviceNotNull.Settings.IndexingContractorAttachments)
		{
			ICRMAttachment attach = obj as ICRMAttachment;
			ProcessingForContractor(attach);
		}
	}

	private void ProcessingForContractor(ICRMAttachment attach)
	{
		if (attach != null && attach.Contractor != null)
		{
			Guid objectTypeUid = ((ClassMetadata)MetadataLoader.LoadMetadata(attach.GetType())).Uid;
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<ICRMAttachment, object>>)((ICRMAttachment d) => d.Contractor)), attach.Contractor.Id));
			IndexQueueManager.Instance.AddReindexObjectPartItem(typeof(IContractorFullTextSearchObject), attach.Id, objectTypeUid, list);
		}
	}
}
