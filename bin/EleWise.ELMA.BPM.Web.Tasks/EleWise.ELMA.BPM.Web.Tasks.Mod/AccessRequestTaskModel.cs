using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Tasks.Models;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class AccessRequestTaskModel : EntityModel<IAccessRequestTask>
{
	public Guid TypeUid { get; set; }

	public long EntityId { get; set; }

	public bool HasPastPermission { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime StartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime EndDate { get; set; }

	public string Subject { get; set; }

	public string Header { get; set; }

	public string Permissions { get; set; }

	public Guid ExecutorFilterProvider { get; set; }

	public string ExecutorFilterData { get; set; }

	public bool CanEditPermissions { get; set; }

	internal IEntityPermissionAccessRequestRenderer EntityPermissionAccessRequestRenderer { get; set; }

	public ICommentActionModel CommentActionModel { get; set; }

	public AccessRequestTaskModel(IAccessRequestTask task)
		: this()
	{
		base.Entity = task;
		Permissions = JsonConvert.SerializeObject((object)task.AccessRequestPermissionGuids);
		Subject = task.Subject;
		ReferenceOnEntity entityReference = task.EntityReference;
		TypeUid = entityReference.ObjectTypeUId;
		EntityId = entityReference.ObjectId;
		NormalizeDates();
	}

	public AccessRequestTaskModel()
	{
		SetDefaultValues();
	}

	public void RenderPermissions(HtmlHelper helper)
	{
		if (EntityPermissionAccessRequestRenderer == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"));
		}
		EntityPermissionAccessRequestRenderer.Render(TypeUid, EntityId, helper);
	}

	private void SetDefaultValues()
	{
		base.Entity = AbstractNHEntityManager<IAccessRequestTask, long>.Instance.Create();
		base.Entity.StartDate = null;
		NormalizeDates();
		CommentActionModel = InterfaceActivator.Create<ICommentActionModel>();
	}

	private void NormalizeDates()
	{
		StartDate = base.Entity.StartDate ?? DateTime.Now;
		EndDate = base.Entity.EndDate ?? DateTime.Now.AddMinutes(15.0);
	}
}
