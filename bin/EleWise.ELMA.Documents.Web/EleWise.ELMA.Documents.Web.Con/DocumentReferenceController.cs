using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class DocumentReferenceController : DmsController<IDocumentReference, long>
{
	public DocumentManager DocumentManager { get; set; }

	public DocumentReferenceManager DocumentReferenceManager { get; set; }

	public ReferenceManager ReferenceManager { get; set; }

	public FavoritesFolderManager FavoritesFolderManager { get; set; }

	public MyDocumentFolderManager MyDocumentFolderManager { get; set; }

	[HttpGet]
	public ActionResult View(long id, long? tabIndex)
	{
		IDocumentReference documentReference = base.Manager.LoadOrNull(id);
		if (documentReference == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = documentReference.Reference.Id
		});
	}

	[HttpGet]
	public ActionResult Create(long id, string popupId, bool inFavorites = false)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		IDocument document = DocumentManager.Load(id);
		if (!DocumentController.CheckDocumentAction(document, DocumentActionProvider.DocumentAddLinkActionUID, DocumentActionProvider.DocumentLinksActionsChapterInfoUID, out var _))
		{
			throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentAddLinkActionUID);
		}
		InstanceOf<IDocumentReference> instanceOf = new InstanceOf<IDocumentReference>();
		instanceOf.New.Reference = document;
		instanceOf.New.Name = document.Name;
		IDocumentReference @new = instanceOf.New;
		if (inFavorites)
		{
			@new.Folder = base.SystemFoldersService.GetFavoritesFolder(currentUser);
		}
		else
		{
			@new.Folder = base.SystemFoldersService.GetMyDocumentFolder(currentUser);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)new DocumentReferenceInfo
		{
			Entity = @new,
			Document = document,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult Create(DocumentReferenceInfo model)
	{
		IDocumentReference documentReference = (IDocumentReference)model.Entity;
		if (model.Entity.UseSourceName)
		{
			documentReference.Name = model.Document.Name;
		}
		documentReference.Reference = model.Document;
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpGet]
	public ActionResult CreateReferences(long[] documentsId, string popupId, long? folderId)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		DocumentController.CheckDocumentAction(DocumentManager.Instance.FindByIdArray(documentsId).ToList(), DocumentActionProvider.DocumentAddLinkActionUID, DocumentActionProvider.DocumentLinksActionsChapterInfoUID, out var checkedDocuments, out var messages);
		WriteErrorMessages(messages);
		return (ActionResult)(object)((Controller)this).PartialView((object)new GroupReferenceInfo
		{
			Documents = checkedDocuments,
			Folder = base.SystemFoldersService.GetMyDocumentFolder(currentUser),
			PopupId = popupId,
			CurrentFolder = ((folderId.HasValue && folderId.Value != 0L) ? FolderManager.Instance.Load(folderId.Value) : null)
		});
	}

	[HttpPost]
	public ActionResult CreateReferences(GroupReferenceInfo model)
	{
		model.Documents.ForEach(delegate(IDocument m)
		{
			InstanceOf<IDocumentReference> instanceOf = new InstanceOf<IDocumentReference>();
			instanceOf.New.Reference = m;
			instanceOf.New.Name = m.Name;
			instanceOf.New.Folder = model.Folder;
			instanceOf.New.Save();
		});
		if (model.Documents.Any())
		{
			IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
			DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null && serviceNotNull2.Settings.Indexing)
			{
				base.Notifier.Information(MvcHtmlString.Create(string.Format("<div>{0}</div> <br/><div style='font-size: 80%; font-style: italic; font-weight: normal !important;'> {1}</div>", (model.Documents.Count == 1) ? SR.T("Ссылка создана").HtmlEncode() : SR.T("Ссылки созданы").HtmlEncode(), SR.T("Для занесения данных в индекс может потребоваться некоторое время").HtmlEncode())));
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = ((model.CurrentFolder == null) ? model.Folder.Id : model.CurrentFolder.Id)
		});
	}

	[HttpPost]
	public ActionResult CreateReferenceInFavorites(long id)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		IDocument document = DocumentManager.Load(id);
		if (FavoritesFolderManager.Instance.IsInFavorites(id))
		{
			foreach (IDocumentReference referencesinFavorite in FavoritesFolderManager.Instance.GetReferencesinFavorites(id))
			{
				referencesinFavorite.Delete();
			}
		}
		else
		{
			InstanceOf<IDocumentReference> instanceOf = new InstanceOf<IDocumentReference>();
			instanceOf.New.Reference = document;
			instanceOf.New.Name = document.Name;
			IDocumentReference @new = instanceOf.New;
			@new.Folder = base.SystemFoldersService.GetFavoritesFolder(currentUser);
			@new.Save();
		}
		return SuccessJson();
	}

	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "refId")]
	public JsonResult DocumentReferenceMenuPermission(long refId)
	{
		IDocumentReference @ref = null;
		long currentVersion = 0L;
		string notVisibleItems = "";
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			@ref = DocumentReferenceManager.Instance.LoadOrNull(refId);
		});
		if (@ref != null)
		{
			notVisibleItems = string.Join(",", HtmlExtensions.NotVisibleItems(@ref));
			IDocumentVersion currentVersion2 = @ref.Reference.GetCurrentVersion();
			if (currentVersion2 != null)
			{
				currentVersion = currentVersion2.Id;
			}
		}
		return ((Controller)this).Json((object)new
		{
			id = refId,
			currentVersion = currentVersion,
			notVisibleItems = notVisibleItems
		}, (JsonRequestBehavior)0);
	}
}
