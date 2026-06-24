using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
public class FullTextSearchPermissionHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private Guid uid = new Guid("86BDA5FC-1A92-4BFF-90C7-9C716D5F58CE");

	private List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IContractorPersonPermission>() };

	private List<string> importantProperties = new List<string>();

	public IContextBoundVariableService ContextCacheService { get; set; }

	public IndexQueueManager IndexManager { get; set; }

	public override Guid Uid => uid;

	public override Type SupportedCard => typeof(IContractorFullTextSearchObject);

	public override List<Guid> SupportedUids => supportedUids;

	public override List<string> GetImportantProperties
	{
		get
		{
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
			{
				return new List<string>();
			}
			return importantProperties;
		}
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Insert021AF042C3F4450EBE4D49B1A53FF502")).Key != null)
		{
			IContractorPersonPermission contractorPersonPermission = EntityManager<IContractorPersonPermission>.Instance.LoadOrNull(id);
			if (contractorPersonPermission != null && contractorPersonPermission.Contractor != null)
			{
				IContractor contractor = contractorPersonPermission.Contractor;
				if (((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any())
				{
					QueueToIndex queueToIndex = new QueueToIndex
					{
						Id = contractor.Id,
						CardType = typeof(IContractorFullTextSearchObject),
						Properties = new List<KeyValuePair<string, object>>()
					};
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Id)), id));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.UserSecuritySetCacheId)), ((IEnumerable<IContractorPersonPermission>)contractor.Permission).Select((IContractorPersonPermission p) => p.UserSecuritySetCacheId.ToString()).ToArray()));
					if (queueToIndex.Properties.Any())
					{
						list.Add(queueToIndex);
					}
				}
			}
		}
		return list;
	}

	private void ProcessingForContractor(IContractorPersonPermission perm)
	{
		if (perm == null || perm.Contractor == null)
		{
			return;
		}
		IContractor contractor = perm.Contractor;
		if (contractor.Permission != null)
		{
			Guid objectTypeUid = ((ClassMetadata)MetadataLoader.LoadMetadata(contractor.GetType())).Uid;
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			List<object> listObj = new List<object>();
			((IEnumerable<IContractorPersonPermission>)contractor.Permission).ForEach(delegate(IContractorPersonPermission d)
			{
				listObj.Add(d.GetId());
			});
			KeyValuePair<string, object> item = new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractor, object>>)((IContractor d) => d.Permission)), listObj);
			list.Add(item);
			IIndexQueue item2 = IndexManager.CreateReindexObjectPartItem(typeof(IContractorFullTextSearchObject), contractor.Id, objectTypeUid, list);
			ContextCacheService.GetOrAdd(IndexQueueManager.IndexQueueListContextKeyConst, () => new List<IIndexQueue>()).Add(item2);
		}
	}

	public override void OnInsertProcessing(Guid typeUid, object obj)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor)
		{
			IContractorPersonPermission perm = obj as IContractorPersonPermission;
			ProcessingForContractor(perm);
		}
	}

	public override void OnDeleteProcessing(Guid typeUid, object obj)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.IndexingContractor)
		{
			IContractorPersonPermission perm = obj as IContractorPersonPermission;
			ProcessingForContractor(perm);
		}
	}
}
