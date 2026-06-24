using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.PropertyHandlers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
public class CommentController : BPMController<IComment, long>
{
	public IEntityActionHandler ActionHandler { get; set; }

	public ICommentActionHandler CommentActionHandler { get; set; }

	public IEnumerable<ICommentLoadedAttachment> CommentLoadedAttachments { get; set; }

	public ActionResult AddCommentPopup(CommentWithAttachments model)
	{
		if (model.ShowLastComments)
		{
			Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(model.ObjectTypeUid);
			IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
			if (classMetadata != null)
			{
				PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == CommentsPropertyHandler.UID));
				if (propertyMetadata != null)
				{
					object obj = entityManager.Load(model.ObjectId);
					if (obj != null)
					{
						UntypedISetProxy untypedISetProxy = obj.GetType().GetReflectionProperty(propertyMetadata.Name).GetValue(obj, null)
							.AsUntypedISet();
						if (untypedISetProxy != null)
						{
							int count = untypedISetProxy.Count;
							int num = 0;
							if (count > 3)
							{
								num = count - 3;
							}
							int num2 = 0;
							foreach (IComment item in untypedISetProxy)
							{
								if (num2 < num)
								{
									num2++;
									continue;
								}
								model.LastComments.Add(item);
								num2++;
							}
						}
					}
				}
				PropertyMetadata propertyMetadata2 = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Handlers.Any((PropertyHandlerInfo h) => h.HandlerUid == CreationDatePropertyHandler.UID));
				if (propertyMetadata2 != null)
				{
					model.LastComments.AddRange(entityManager.Find(new FetchOptions(0, 3, ListSortDirection.Descending, propertyMetadata2.Name)).OfType<IComment>());
				}
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("PopupCommentContent", (object)model);
	}

	[HttpGet]
	public ActionResult PopupCommentContent(CommentWithAttachments model, string prefix)
	{
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		((ControllerBase)this).get_ViewData().set_Item("CreatorRequest", (object)true.ToString());
		((ControllerBase)this).get_ViewData().set_Item("CreatorPrefix", (object)prefix);
		return (ActionResult)(object)((Controller)this).PartialView("PopupCommentContent", (object)model);
	}

	public ActionResult LoadAttachments(CommentAttachmentLoader model)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		List<ActionResult> list = new List<ActionResult>();
		List<LoadedAttachmentModel> baseAttachments = new List<LoadedAttachmentModel>();
		List<LoadedAttachmentModel> list2 = CommentLoadedAttachments.Where((ICommentLoadedAttachment p) => p.ZoneId == model.ZoneId).SelectMany((ICommentLoadedAttachment p) => p.GetLoadedAttachments(model.ActionModel)).ToList();
		if (list2 != null && list2.Count > 0)
		{
			baseAttachments.AddRange(list2);
			((ControllerBase)this).get_ViewData().set_Item("IsAttachmentSet", (object)true);
			foreach (LoadedAttachmentModel item2 in baseAttachments)
			{
				ViewDataDictionary val = new ViewDataDictionary(((ControllerBase)this).get_ViewData());
				val.set_Model((object)item2);
				ViewDataDictionary val2 = val;
				val2.set_Item("UseShortView", (object)true);
				HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
				((ViewResultBase)htmlCatchViewResult).set_ViewName("BaseAttachment");
				((ViewResultBase)htmlCatchViewResult).set_ViewData(val2);
				((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
				HtmlCatchViewResult item = htmlCatchViewResult;
				list.Add((ActionResult)(object)item);
			}
		}
		return (ActionResult)(object)new CompositeActionResult(list, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			foreach (LoadedAttachmentModel baseAttachment in baseAttachments)
			{
				HtmlCatchViewResult htmlCatchViewResult2 = (HtmlCatchViewResult)(object)results.FirstOrDefault((ActionResult r) => r is HtmlCatchViewResult && ((ViewResultBase)(r as HtmlCatchViewResult)).get_Model() == baseAttachment && ((ViewResultBase)(r as HtmlCatchViewResult)).get_ViewName() == "BaseAttachment");
				if (htmlCatchViewResult2 != null && !string.IsNullOrWhiteSpace(htmlCatchViewResult2.HtmlResult))
				{
					baseAttachment.Content = htmlCatchViewResult2.HtmlResult;
				}
			}
			MvcHtmlString value = new
			{
				status = "Ok",
				items = baseAttachments
			}.ToJson();
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(value);
		});
	}

	public ActionResult GetCommentAttachmentButtonMenu(string containerId, string zoneId, string htmlPrefix = "")
	{
		CommentAttachmentButtonModel commentAttachmentButtonModel = new CommentAttachmentButtonModel
		{
			HtmlPrefix = htmlPrefix,
			ContainerId = containerId,
			MenuIsOpened = true,
			ZoneId = zoneId,
			CommentLoadedAttachmentPoints = CommentLoadedAttachments.Where((ICommentLoadedAttachment p) => p.ZoneId == zoneId).ToList()
		};
		return (ActionResult)(object)((Controller)this).PartialView("Attachment/AttachmentButton", (object)commentAttachmentButtonModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult AddComment(CommentWithAttachments model)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (model != null)
		{
			if (model.ActionModel != null)
			{
				PropertyInfo reflectionProperty = model.ActionModel.GetType().GetReflectionProperty("DocumentAttachments");
				if ((model.ActionModel.Comment != null && !string.IsNullOrWhiteSpace(model.ActionModel.Comment.Text)) || (model.ActionModel.Attachments != null && model.ActionModel.Attachments.Count > 0) || (reflectionProperty != null && reflectionProperty.GetValue(model.ActionModel, null) != null))
				{
					if (model.ActionModel.Comment != null && !string.IsNullOrEmpty(model.ActionModel.Comment.Text))
					{
						model.ActionModel.Comment.Text = model.ActionModel.Comment.Text.Trim();
					}
					AddCommentToObject(model, currentUser);
					if (model.IsAjax)
					{
						return (ActionResult)(object)((Controller)this).Json((object)new
						{
							success = true
						});
					}
					if (model.UseJson)
					{
						return (ActionResult)(object)((Controller)this).Json((object)"ok", "text/html");
					}
				}
			}
			if (model.IsAjax)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = true
				});
			}
			if (!string.IsNullOrEmpty(model.RedirectUrl))
			{
				return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	public static void AddCommentToObject(CommentWithAttachments commentModel, EleWise.ELMA.Security.Models.IUser user)
	{
		if (commentModel == null)
		{
			return;
		}
		ICommentActionHandler service = Locator.GetService<ICommentActionHandler>();
		IEntityActionHandler service2 = Locator.GetService<IEntityActionHandler>();
		if (commentModel.ActionModel.Comment != null)
		{
			commentModel.ActionModel.Comment.CreationAuthor = user;
		}
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(commentModel.ObjectTypeUid);
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		object target = null;
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		serviceNotNull.RunWithElevatedPrivilegies(delegate
		{
			target = manager.Load(commentModel.ObjectId);
		});
		service.Process(target, commentModel.ActionModel);
		serviceNotNull.RunWithElevatedPrivilegies(delegate
		{
			manager.Save(target);
		});
		if (commentModel.AddCommentActionUid != Guid.Empty && target is IEntity)
		{
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, (IEntity)target, commentModel.AddCommentActionUid);
			if (entityActionEventArgs != null)
			{
				service.ProcessEventArgs(entityActionEventArgs, commentModel.ActionModel);
				service2.ActionExecuted(entityActionEventArgs);
			}
		}
	}

	public ActionResult LoadFile(XhrPostedFile file)
	{
		CachFileUploadInfo cachFileUploadInfo = BinaryFilesController.UploadAjax(file, ((ControllerBase)this).get_ControllerContext());
		if (!cachFileUploadInfo.UploadComplete)
		{
			return (ActionResult)(object)((Controller)this).Content(cachFileUploadInfo.JsonData);
		}
		BinaryFile binaryFile = base.CacheFilesService.GetBinaryFile(cachFileUploadInfo.FileGuid);
		if (binaryFile == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Файл не найден")
			}, (JsonRequestBehavior)0);
		}
		if (string.IsNullOrEmpty(binaryFile.Id))
		{
			binaryFile.Id = binaryFile.Uid.ToString();
		}
		IAttachment attachment = AttachmentManager.Instance.Create();
		attachment.File = binaryFile;
		attachment.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		attachment.CreationDate = DateTime.Now;
		((ControllerBase)this).get_ViewData().set_Model((object)attachment);
		((ControllerBase)this).get_ViewData().set_Item("UseShortView", (object)true);
		((ControllerBase)this).get_ViewData().set_Item("IsAttachmentSet", (object)true);
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("DisplayTemplates/Entities/Attachment");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
		HtmlCatchViewResult htmlCatchViewResult2 = htmlCatchViewResult;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new HtmlCatchViewResult[1] { htmlCatchViewResult2 }, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			MvcHtmlString value = new
			{
				attachmentContent = ((HtmlCatchViewResult)(object)results.First()).HtmlResult,
				fileId = binaryFile.Id,
				success = true,
				fileName = file.FileName,
				typeUid = "692f9f96-dd18-4477-a632-e145c53291e5"
			}.ToJson();
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(value);
		});
	}
}
