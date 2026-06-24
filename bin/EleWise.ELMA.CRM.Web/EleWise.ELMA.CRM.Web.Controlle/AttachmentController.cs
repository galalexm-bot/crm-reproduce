using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class AttachmentController : BPMController<ICRMAttachment, long>
{
	public ActionResult Create(CrmAttachment attachment)
	{
		return (ActionResult)(object)((Controller)this).View((object)attachment);
	}

	[HttpGet]
	public ActionResult AddAttachmentPopup(CrmAttachment model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("AddAttachmentPopup", (object)model);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult AddAttachment(CrmAttachment attachmentModel)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (attachmentModel != null)
		{
			AddAttachmentToEntity(attachmentModel, currentUser);
			if (attachmentModel.UseJson)
			{
				return (ActionResult)(object)((Controller)this).Json((object)"ok", "text/html");
			}
			if (!string.IsNullOrEmpty(attachmentModel.RedirectUrl))
			{
				return (ActionResult)(object)((Controller)this).Redirect(attachmentModel.RedirectUrl);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	private void AddAttachmentToEntity(CrmAttachment attachmentModel, EleWise.ELMA.Security.Models.IUser user)
	{
		if (attachmentModel != null && attachmentModel.ActionModel != null && (attachmentModel.ActionModel.Files != null || attachmentModel.ActionModel.Documents != null))
		{
			Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(attachmentModel.EntityTypeUid);
			IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
			object entity = null;
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				entity = manager.Load(attachmentModel.EntityId);
			});
			ICRMAttachment iCRMAttachment = InterfaceActivator.Create<ICRMAttachment>();
			if (entity is IContractor)
			{
				iCRMAttachment.Contractor = (IContractor)entity;
			}
			else if (entity is IContact)
			{
				iCRMAttachment.Contact = (IContact)entity;
			}
			else if (entity is ILead)
			{
				iCRMAttachment.Lead = (ILead)entity;
			}
			else if (entity is ISale)
			{
				iCRMAttachment.Sale = (ISale)entity;
			}
			iCRMAttachment.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			iCRMAttachment.CreationDate = DateTime.Now;
			iCRMAttachment.Comment = attachmentModel.ActionModel.Comment;
			if (attachmentModel.ActionModel.Files != null)
			{
				iCRMAttachment.Files.AddAll((ICollection<IAttachment>)attachmentModel.ActionModel.Files);
			}
			if (attachmentModel.ActionModel.Documents != null)
			{
				iCRMAttachment.Documents.AddAll((ICollection<IDocument>)attachmentModel.ActionModel.Documents);
			}
			iCRMAttachment.Save();
		}
	}

	private static CrmAttachmentDeletePermission CheckAttachmentDeletePermissions(ICRMAttachment att)
	{
		bool num = CRMPermissionProvider.CheckAny(new Permission[2]
		{
			CRMPermissionProvider.CRMFullAccessPermission,
			CRMPermissionProvider.CRMDeletePermission
		});
		bool flag = false;
		if (att.Contractor != null)
		{
			flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditContractorPermission, att.Contractor);
		}
		if (att.Contact != null)
		{
			flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditContactPermission, att.Contact);
		}
		if (att.Lead != null && att.Contractor == null)
		{
			flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditLeadPermission, att.Lead);
		}
		if (att.Sale != null)
		{
			flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditSalePermission, att.Sale);
		}
		if (!(num && flag))
		{
			return CrmAttachmentDeletePermission.NoPermissions;
		}
		return CrmAttachmentDeletePermission.AllowDelete;
	}

	[HttpPost]
	public ActionResult RemoveAttachmentSubItem(long attachmentId, long? docId, long? fileId)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		ICRMAttachment iCRMAttachment = CrmAttachmentManager.Instance.Load(attachmentId);
		if (CheckAttachmentDeletePermissions(iCRMAttachment) == CrmAttachmentDeletePermission.AllowDelete)
		{
			bool flag = false;
			if (docId.HasValue)
			{
				IDocument document = ((IEnumerable<IDocument>)iCRMAttachment.Documents).FirstOrDefault((IDocument d) => d.Id == docId);
				if (document != null)
				{
					((ICollection<IDocument>)iCRMAttachment.Documents).Remove(document);
					flag = true;
				}
			}
			if (fileId.HasValue)
			{
				IAttachment attachment = ((IEnumerable<IAttachment>)iCRMAttachment.Files).FirstOrDefault((IAttachment d) => d.Id == fileId);
				if (attachment != null)
				{
					((ICollection<IAttachment>)iCRMAttachment.Files).Remove(attachment);
					flag = true;
				}
			}
			if (flag)
			{
				if (!((IEnumerable<IDocument>)iCRMAttachment.Documents).Any() && !((IEnumerable<IAttachment>)iCRMAttachment.Files).Any())
				{
					CrmAttachmentManager.Instance.Delete(iCRMAttachment);
				}
				else
				{
					iCRMAttachment.Save();
				}
			}
		}
		return (ActionResult)new EmptyResult();
	}
}
