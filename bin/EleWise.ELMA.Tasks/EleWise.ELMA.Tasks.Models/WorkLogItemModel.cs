using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Tasks.Models;

public class WorkLogItemModel
{
	private IMetadataRuntimeService metadataRuntimeService;

	private ISecurityService securityService;

	private IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	private ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<SecurityService>());

	public IEntity WorkLogObject { get; set; }

	public IWorkLogItem WorkLogItem { get; set; }

	public WorkLogItemModel()
	{
	}

	public WorkLogItemModel(IWorkLogItem workLogItem)
	{
		WorkLogItem = workLogItem;
		WorkLogObject = GetWorkLogObject(workLogItem);
	}

	private IEntity GetWorkLogObject(IWorkLogItem workLogItem)
	{
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(workLogItem.ObjectUID);
		IEntity entity = null;
		if (typeByUidOrNull != null)
		{
			IEntityManager manager = ModelHelper.GetEntityManager(typeByUidOrNull);
			SecurityService.RunBySystemUser(delegate
			{
				entity = manager.LoadOrNull(workLogItem.ObjectId) as IEntity;
			});
		}
		return entity;
	}
}
