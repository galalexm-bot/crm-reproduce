using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskViewModel : EntityModel<ITaskBase>
{
	public IUser ExecutorIsEmulation;

	private Lazy<bool> anyAttachment;

	private Lazy<bool> anyAttachmentSpecified;

	private Lazy<bool> anyFile;

	private IApprovalTask _approvalTask;

	public bool IsAvailableCompleted { get; set; }

	public bool IsAvailableInCompleted { get; set; }

	public bool IsAvailableStartWork { get; set; }

	public bool IsAvailableApproval { get; set; }

	public bool IsAvailableCreateSubtask { get; set; }

	public bool IsAvailableCreateApproval { get; set; }

	public bool IsAvailableControlledAction { get; set; }

	public bool IsAvailableEdit { get; set; }

	public bool IsEmulation { get; set; }

	public bool IsAvailableClose { get; set; }

	public bool IsAvailableReAssign { get; set; }

	public bool IsAvailableDateChange { get; set; }

	public bool IsAvailableChangeControl { get; set; }

	public bool IsAvailableCopy { get; set; }

	public bool IsAvailableTakeCurrentControl { get; set; }

	public bool IsAvailableBreakCurrentControl { get; set; }

	public bool IsAvailableDeleteWatches { get; set; }

	public bool IsAvailableWorkLog { get; set; }

	public bool NeedApproval { get; set; }

	public bool NeedCoexecuters { get; set; }

	public bool NeedHistory { get; set; }

	public bool NeedComment { get; set; }

	public bool NeedParentRef { get; set; }

	public bool RedirectHomeIfNullAfterAction { get; set; }

	public bool HasAttachments => anyAttachment.Value;

	public bool HasAttachmentsSpecified => anyAttachmentSpecified.Value;

	public bool AnyFile => anyFile.Value;

	public IApprovalTask ApprovalTask
	{
		get
		{
			if (base.Entity == null || base.Entity.ChildTasks == null || ((ICollection<ITaskBase>)base.Entity.ChildTasks).Count == 0)
			{
				return null;
			}
			return _approvalTask ?? (_approvalTask = ((IEnumerable<ITaskBase>)base.Entity.ChildTasks).LastOrDefault((ITaskBase t) => t is IApprovalTask) as IApprovalTask);
		}
	}

	public TaskViewModel()
	{
		anyFile = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Entity.TypeUid, base.Entity));
		anyAttachment = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyAttachments(base.Entity.TypeUid, base.Entity));
		anyAttachmentSpecified = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyAttachmentsSpecified(base.Entity.TypeUid, base.Entity));
		NeedHistory = true;
		NeedApproval = true;
		NeedCoexecuters = true;
		NeedComment = true;
		RedirectHomeIfNullAfterAction = true;
	}
}
