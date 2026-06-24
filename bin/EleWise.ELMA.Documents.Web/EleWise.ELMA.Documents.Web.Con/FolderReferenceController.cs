using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class FolderReferenceController : DmsController<IFolderReference, long>
{
	public FolderManager FolderManager { get; set; }

	[HttpGet]
	public ActionResult Create(long? id, string popupId, bool inFavorites = false)
	{
		if (id.HasValue)
		{
			IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
			IFolder folder = (IFolder)FolderManager.Load(id.Value).Implementation();
			IFolderReference folderReference = InterfaceActivator.Create<IFolderReference>();
			folderReference.Reference = folder;
			folderReference.Name = folder.Name;
			if (inFavorites)
			{
				folderReference.Folder = base.SystemFoldersService.GetFavoritesFolder(currentUser).CastAsRealType();
			}
			else
			{
				folderReference.Folder = base.SystemFoldersService.GetMyDocumentFolder(currentUser).CastAsRealType();
			}
			return (ActionResult)(object)((Controller)this).PartialView((object)new FolderReferenceInfo
			{
				Entity = folderReference,
				Folder = folder,
				PopupId = popupId
			});
		}
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpPost]
	public ActionResult Create(FolderReferenceInfo model)
	{
		IFolderReference folderReference = (IFolderReference)model.Entity;
		if (model.Entity.UseSourceName)
		{
			folderReference.Name = model.Folder.Name;
		}
		folderReference.Reference = model.Folder;
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpGet]
	public ActionResult View(long id, long? tabIndex)
	{
		IFolderReference folderReference = base.Manager.LoadOrNull(id);
		if (folderReference == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		string text = ((Controller)this).get_Url().Entity(folderReference.Reference.CastAsRealType());
		if (!string.IsNullOrEmpty(text))
		{
			return (ActionResult)(object)((Controller)this).Redirect(text);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = folderReference.Reference.Id
		});
	}
}
