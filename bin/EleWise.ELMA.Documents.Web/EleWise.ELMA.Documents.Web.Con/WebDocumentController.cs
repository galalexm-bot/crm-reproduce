using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Aspose.Words;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class WebDocumentController : DmsController<IWebDocument, long>
{
	public CommonSettings CommonSettings
	{
		get
		{
			if (Locator.Initialized)
			{
				CommonSettingsModule service = Locator.GetService<CommonSettingsModule>();
				if (service != null)
				{
					return service.Settings;
				}
			}
			return null;
		}
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, CustomGridCommand customCommand, DocumentVersionGrid info, [Bind(Prefix = "DocumentVersionFilter")] IDocumentVersionFilter filter)
	{
		if (customCommand != null)
		{
			if (customCommand.Ids == null)
			{
				customCommand.Ids = new long[0];
			}
			string commandName = customCommand.CommandName;
			if (commandName == "ChangeStatus")
			{
				customCommand.Ids.ToList().ForEach(delegate(long a)
				{
					IDocumentVersion version = DocumentVersionManager.Instance.Load(a);
					DocumentVersionManager.Instance.ChangeStatus(version, (DocumentVersionStatus)Convert.ToInt32(customCommand.GetParameter(((Controller)this).get_HttpContext(), "status")));
				});
			}
		}
		if (info == null)
		{
			info = new DocumentVersionGrid();
		}
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IDocumentVersionFilter>();
		}
		filter.Document = base.Manager.Load(info.DocumentId);
		GridData<IDocumentVersion, IDocumentVersionFilter> gridData2 = (info.Data = DocumentVersionManager.Instance.CreateGridData(command, filter));
		bool flag = !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionCreateActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, filter.Document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionEditActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, filter.Document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionChangeStatusActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, filter.Document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionLockActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, filter.Document.TypeUid);
		info.AllowEdit = !flag && base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, filter.Document);
		info.FullAccess = base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, filter.Document) || base.SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		return (ActionResult)(object)((Controller)this).PartialView((object)info);
	}

	public ActionResult List(long documentId, string SaveCallback, string GridId)
	{
		DocumentVersionGrid documentVersionGrid = new DocumentVersionGrid
		{
			DocumentId = documentId,
			SaveCallback = SaveCallback,
			GridId = GridId
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)documentVersionGrid);
	}

	[HttpGet]
	public ActionResult VersionInfo(long id, string popupId, string callback, bool? @readonly = false)
	{
		IDocumentVersion version = DocumentVersionManager.Instance.Load(id);
		version = DocumentVersionController.CheckIsCrypt(version);
		DocumentVersionModel documentVersionModel = new DocumentVersionModel
		{
			FormId = "DocVerForm" + UIExtensions.PrepareId(Guid.NewGuid().ToString()),
			Document = version.Document,
			Version = version,
			PopupId = popupId,
			Callback = callback,
			ReadOnly = (@readonly.HasValue && @readonly.Value)
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)documentVersionModel);
	}

	[HttpPost]
	public ActionResult SetCurrent(DocumentVersionModel model)
	{
		model.Version.Status = DocumentVersionStatus.Current;
		model.Version.Save();
		return SuccessJson();
	}

	[WithoutSpa]
	[HttpGet]
	public ActionResult DownloadCurrentVersion(long documentId, long? versionId = null)
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		IDocument document = DocumentManager.Instance.Load(documentId);
		if (!WebDocumentManager.Instance.IsWebDocument(document.TypeUid))
		{
			throw new Exception(SR.T("Документ не является веб-документом"));
		}
		if (!versionId.HasValue && document.CurrentVersion == null)
		{
			throw new Exception(SR.T("У документа нет текущей версии"));
		}
		if (!DocumentController.CheckDocumentAction(document, DocumentActionProvider.DocumentDownloadWebVersionActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, out var _))
		{
			throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentDownloadWebVersionActionUID);
		}
		string text = DocumentVersionController.CheckIsCrypt(DocumentVersionManager.Instance.Load(versionId.HasValue ? versionId.Value : document.CurrentVersion.Id), DocumentVersionActions.DownloadGuid).Content.ToString();
		if (!string.IsNullOrEmpty(text) && CommonSettings != null && !string.IsNullOrEmpty(CommonSettings.ApplicationBaseUrl))
		{
			text = text.SetFullPathForImg(CommonSettings.ApplicationBaseUrl);
		}
		string tempFileName = IOExtensions.GetTempFileName();
		string text2 = $"{tempFileName}.html";
		System.IO.File.WriteAllText(text2, text, Encoding.UTF8);
		string text3 = $"{tempFileName}.docx";
		LoadOptions val = new LoadOptions();
		val.set_LoadFormat((LoadFormat)50);
		new Document(text2, val).Save(text3, (SaveFormat)20);
		IMimeMappingService serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
		return (ActionResult)(object)new FilePathResult(text3, serviceNotNull.GetTypeByExtension(".docx"))
		{
			FileDownloadName = $"{document.Name}.docx"
		};
	}

	public ActionResult FrameContent(long id)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		IDocumentVersion documentVersion = DocumentVersionManager.Instance.Load(id);
		ContentResult val = new ContentResult();
		val.set_Content(string.Format("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <link type=\"text/css\" rel=\"stylesheet\" href=\"{0}\">\r\n</head>\r\n<body>\r\n    {1}\r\n</body>\r\n</html>", ((Controller)this).get_Url().Content("~/Modules/EleWise.ELMA.BPM.Web.Content/Scripts/skins/lightgray/content.min.css"), documentVersion.Content.ToString()));
		return (ActionResult)val;
	}
}
