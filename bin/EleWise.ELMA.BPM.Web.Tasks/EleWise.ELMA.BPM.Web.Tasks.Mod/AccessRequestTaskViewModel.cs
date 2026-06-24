using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class AccessRequestTaskViewModel : EntityModel<IAccessRequestTask>
{
	public bool IsAvailableCompleted { get; set; }

	public bool IsAvailableInCompleted { get; set; }

	public bool IsAvailableStartWork { get; set; }

	public bool IsAvailableCreateSubtask { get; set; }

	public bool IsAvailableEdit { get; set; }

	public bool IsAvailableClose { get; set; }

	public bool IsAvailableReAssign { get; set; }

	public bool IsAvailableDateChange { get; set; }

	public bool HasGrantAccessPermission { get; set; }

	public Guid ExecutorFilterProvider { get; set; }

	public string ExecutorFilterData { get; set; }

	internal IEntityPermissionAccessRequestRenderer EntityPermissionAccessRequestRenderer { get; set; }

	public bool AnyAttachment { get; set; }

	public bool AnyAttachmentSpecified { get; set; }

	public bool AnyFile { get; set; }

	public string Permissions { get; set; }

	public void RenderPermissions(HtmlHelper helper)
	{
		if (EntityPermissionAccessRequestRenderer == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"));
		}
		ReferenceOnEntity entityReference = base.Entity.EntityReference;
		EntityPermissionAccessRequestRenderer.Render(entityReference.ObjectTypeUId, entityReference.ObjectId, helper);
	}
}
