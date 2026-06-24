using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class ContractorHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private ISecurityService securityService;

	private EntityActionHistoryManager entityActionHistoryManager;

	private ContractorManager contractorManager;

	private CategoryManager categoryManager;

	private IEntityManager<IContContractorPermission> contContractorPermissionManager;

	public ContractorHistoryCollector(ISecurityService securityService, EntityActionHistoryManager entityActionHistoryManager, CategoryManager categoryManager, ContractorManager contractorManager)
	{
		this.securityService = securityService;
		this.entityActionHistoryManager = entityActionHistoryManager;
		this.categoryManager = categoryManager;
		this.contractorManager = contractorManager;
		collectorGuid = new Guid("3D31C60B-22EE-40AB-8223-6624A237F866");
		contContractorPermissionManager = EntityManager<IContContractorPermission>.Instance;
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		Guid contractorTypeUid = InterfaceActivator.UID<IContractor>();
		return baseClasses.Any((ClassMetadata c) => c.Uid == contractorTypeUid);
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null || relatedObjectList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		HistoryCollectorRelatedModel historyCollectorRelatedModel = relatedObjectList.FirstOrDefault((HistoryCollectorRelatedModel a) => a.CollectorGuid == collectorGuid);
		if (historyCollectorRelatedModel == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		DateTime? contractorCreationDate = historyCollectorRelatedModel.AdditionalInformation as DateTime?;
		if (!contractorCreationDate.HasValue)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		return relatedEventList.Where((EntityActionEventArgs a) => a.Action != null && a.Metadata != null && a.New != null && a.ActionDate >= contractorCreationDate.Value && a.Action.Uid == ContContractorPermissionActions.ChangeAccessGuid && relatedObjectList.Any((HistoryCollectorRelatedModel obj) => obj.CollectorGuid == collectorGuid && obj.EntityTypeUid == a.Metadata.Uid && a.New != null && (long)a.New.GetId() == obj.EntityId));
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		IEnumerable<HistoryCollectorRelatedModel> contractorCategoryRelatedHistory = categoryManager.GetContractorCategoryRelatedHistory(id);
		Guid entityTypeUid = InterfaceActivator.UID<IContContractorPermission>();
		foreach (HistoryCollectorRelatedModel item in contractorCategoryRelatedHistory)
		{
			item.CollectorGuid = collectorGuid;
			item.EntityTypeUid = entityTypeUid;
		}
		return contractorCategoryRelatedHistory;
	}
}
