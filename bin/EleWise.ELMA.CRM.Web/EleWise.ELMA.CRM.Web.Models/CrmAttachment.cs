using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.CRM.Web.Models;

public class CrmAttachment : FormViewModel
{
	public string PopupId { get; set; }

	public bool UseJson { get; set; }

	public long EntityId { get; set; }

	public Guid EntityTypeUid { get; set; }

	public ICrmAttachmentActionModel ActionModel { get; set; }

	public CrmAttachment()
	{
		base.PostAction = "AddAttachment";
		base.PostController = "Attachment";
		base.PostArea = "EleWise.ELMA.CRM.Web";
		ActionModel = InterfaceActivator.Create<ICrmAttachmentActionModel>();
	}
}
