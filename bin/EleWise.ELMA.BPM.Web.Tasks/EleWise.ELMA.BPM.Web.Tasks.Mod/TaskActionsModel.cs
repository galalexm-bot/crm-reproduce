using System;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.ExtensionPoints.HeaderButtonsServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskActionsModel : EntityModel<ITaskBase>
{
	private Lazy<bool> anyAttachment;

	private Lazy<bool> anyFile;

	public bool DenyReAssign { get; set; }

	public string ReAssignRedirectUrl { get; set; }

	public string ReAssignClick { get; set; }

	public bool NeedCheckOrganizationItemOnReAssign { get; set; }

	public string QuestionRedirectUrl { get; set; }

	public string CommentRedirectUrl { get; set; }

	public string WorkLogRedirectUrl { get; set; }

	public string ChangeTaskEndDateRedirectUrl { get; set; }

	public bool IsAjax { get; set; }

	public bool ShowWorkLogButton { get; set; }

	public bool? ShowStartWorkButton { get; set; }

	public string StartWorkAction { get; set; }

	public string StartWorkController { get; set; }

	public string StartWorkArea { get; set; }

	public string StartWorkRedirectUrl { get; set; }

	public bool EnableMarkRead { get; set; }

	public bool EnableChangeTaskEndDate { get; set; }

	public bool EnableCreateSubTask { get; set; }

	public string CreateSubTaskRedirectUrl { get; set; }

	public bool ChangeDateRequiredStartDate { get; set; }

	public bool ChangeDateRequiredEndDate { get; set; }

	public bool ChangeDateHideStartDate { get; set; }

	public bool ChangeDateHideEndDate { get; set; }

	public bool CanCloseTask { get; set; }

	public string DoCloseAction { get; set; }

	public string DoCloseController { get; set; }

	public string DoCloseArea { get; set; }

	public bool EnableWatches { get; set; }

	public bool HasAttachments => anyAttachment.Value;

	public bool AnyFile => anyFile.Value;

	public bool IsAvaliableWatches()
	{
		if (EnableWatches)
		{
			IHeaderButtonsWatchIsAvailableService service = Locator.GetService<IHeaderButtonsWatchIsAvailableService>();
			if (service != null && ((base.Entity != null && service.IsAvailable(base.Entity)) || service.IsAvailable(base.Entity.TypeUid, base.Entity)))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public TaskActionsModel()
	{
		anyFile = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Entity.TypeUid, base.Entity));
		anyAttachment = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyAttachments(base.Entity.TypeUid, base.Entity));
		ChangeDateRequiredStartDate = true;
		ChangeDateRequiredEndDate = true;
		EnableWatches = true;
	}
}
