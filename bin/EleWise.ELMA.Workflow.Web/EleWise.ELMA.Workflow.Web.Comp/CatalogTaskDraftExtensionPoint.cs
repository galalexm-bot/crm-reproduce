using System;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
internal class CatalogTaskDraftExtensionPoint : IEntityTaskModelDraftExtensionPoint
{
	private ISecurityService securityService;

	private const string UidString = "3ED56DE1-07EF-406F-A8AC-E512DE4908C5";

	private Guid uid = new Guid("3ED56DE1-07EF-406F-A8AC-E512DE4908C5");

	private string blobCatalogKey = "WorkflowTaskCatalogInfoExt";

	public CatalogTaskDraftExtensionPoint(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanSave(Type type)
	{
		return typeof(CatalogInfo) == type;
	}

	public void Save(object state, long taskId)
	{
		CatalogInfo catalogInfo = state as CatalogInfo;
		if (catalogInfo.Entity != null && catalogInfo.Entity.IsNew())
		{
			string value = new EntityJsonSerializer().Serialize(catalogInfo.Entity);
			DataAccessManager.BLOBManager.SetBLOB(uid, blobCatalogKey + taskId, value);
		}
	}

	public object GetState(long taskId)
	{
		return DataAccessManager.BLOBManager.GetBLOB<string>(uid, blobCatalogKey + taskId);
	}

	public void ApplyState(long taskId, object state)
	{
		ApplyState(GetState(taskId), state);
	}

	public void ApplyState(object draftState, object state)
	{
		string draftInfo = draftState as string;
		if (string.IsNullOrEmpty(draftInfo))
		{
			return;
		}
		CatalogInfo info = state as CatalogInfo;
		if (info != null && info.Entity != null)
		{
			securityService.RunWithElevatedPrivilegies(delegate
			{
				new EntityJsonSerializer().Deserialize(draftInfo, info.Entity);
			});
		}
	}

	public void RemoveState(long taskId)
	{
		DataAccessManager.BLOBManager.RemoveBLOB<string>(uid, blobCatalogKey + taskId);
	}
}
