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
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    public class AttachmentController : BPMController<ICRMAttachment, long>
    {
        public ActionResult Create(CrmAttachment attachment) => View((object)attachment);

        [HttpGet]
        public ActionResult AddAttachmentPopup(CrmAttachment model) => PartialView(nameof(AddAttachmentPopup), (object)model);

        [HttpPost]
        [TransactionAction]
        public ActionResult AddAttachment(CrmAttachment attachmentModel)
        {
            // ISSUE: explicit non-virtual call
            EleWise.ELMA.Security.Models.IUser currentUser = ((BaseController)this).AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            if (attachmentModel != null)
            {
                this.AddAttachmentToEntity(attachmentModel, currentUser);
                if (attachmentModel.UseJson)
                    return Json((object)"ok", "text/html");
                if (!string.IsNullOrEmpty(attachmentModel.RedirectUrl))
                    return Redirect(attachmentModel.RedirectUrl);
            }
            return Redirect(((Controller)this).Url.ReturnUrl(true));
        }

        private void AddAttachmentToEntity(CrmAttachment attachmentModel, EleWise.ELMA.Security.Models.IUser user)
        {
            if (attachmentModel == null || attachmentModel.ActionModel == null || attachmentModel.ActionModel.Files == null && attachmentModel.ActionModel.Documents == null)
                return;
            IEntityManager manager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(attachmentModel.EntityTypeUid));
            object entity = (object)null;
            Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies((Action)(() => entity = manager.Load((object)attachmentModel.EntityId)));
            ICRMAttachment crmAttachment = InterfaceActivator.Create<ICRMAttachment>();
            if (entity is IContractor)
                crmAttachment.Contractor = (IContractor)entity;
            else if (entity is IContact)
                crmAttachment.Contact = (IContact)entity;
            else if (entity is ILead)
                crmAttachment.Lead = (ILead)entity;
            else if (entity is ISale)
                crmAttachment.Sale = (ISale)entity;
            // ISSUE: explicit non-virtual call
            crmAttachment.CreationAuthor = ((BaseController)this).AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            crmAttachment.CreationDate = DateTime.Now;
            crmAttachment.Comment = attachmentModel.ActionModel.Comment;
            if (attachmentModel.ActionModel.Files != null)
                crmAttachment.Files.AddAll((ICollection<IAttachment>)attachmentModel.ActionModel.Files);
            if (attachmentModel.ActionModel.Documents != null)
                crmAttachment.Documents.AddAll((ICollection<IDocument>)attachmentModel.ActionModel.Documents);
            crmAttachment.Save();
        }

        private static CrmAttachmentDeletePermission CheckAttachmentDeletePermissions(ICRMAttachment att)
        {
            int num1 = CRMPermissionProvider.CheckAny((IEnumerable<Permission>)new Permission[2]
            {
        CRMPermissionProvider.CRMFullAccessPermission,
        CRMPermissionProvider.CRMDeletePermission
            }) ? 1 : 0;
            bool flag = false;
            if (att.Contractor != null)
                flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditContractorPermission, (object)att.Contractor);
            if (att.Contact != null)
                flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditContactPermission, (object)att.Contact);
            if (att.Lead != null && att.Contractor == null)
                flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditLeadPermission, (object)att.Lead);
            if (att.Sale != null)
                flag = Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.EditSalePermission, (object)att.Sale);
            int num2 = flag ? 1 : 0;
            return (num1 & num2) == 0 ? CrmAttachmentDeletePermission.NoPermissions : CrmAttachmentDeletePermission.AllowDelete;
        }

        [HttpPost]
        public ActionResult RemoveAttachmentSubItem(long attachmentId, long? docId, long? fileId)
        {
            ICRMAttachment att = CrmAttachmentManager.Instance.Load(attachmentId);
            if (AttachmentController.CheckAttachmentDeletePermissions(att) == CrmAttachmentDeletePermission.AllowDelete)
            {
                bool flag = false;
                if (docId.HasValue)
                {
                    IDocument document = att.Documents.FirstOrDefault<IDocument>((Func<IDocument, bool>)(d =>
                   {
                       long id = d.Id;
                       long? nullable = docId;
                       long valueOrDefault = nullable.GetValueOrDefault();
                       return id == valueOrDefault & nullable.HasValue;
                   }));
                    if (document != null)
                    {
                        att.Documents.Remove(document);
                        flag = true;
                    }
                }
                if (fileId.HasValue)
                {
                    IAttachment attachment = att.Files.FirstOrDefault<IAttachment>((Func<IAttachment, bool>)(d =>
                   {
                       long id = d.Id;
                       long? nullable = fileId;
                       long valueOrDefault = nullable.GetValueOrDefault();
                       return id == valueOrDefault & nullable.HasValue;
                   }));
                    if (attachment != null)
                    {
                        att.Files.Remove(attachment);
                        flag = true;
                    }
                }
                if (flag)
                {
                    if (!att.Documents.Any<IDocument>() && !att.Files.Any<IAttachment>())
                        CrmAttachmentManager.Instance.Delete(att);
                    else
                        att.Save();
                }
            }
            return (ActionResult)new EmptyResult();
        }
    }
}
