using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class ReferenceController : DmsController<IReference, long>
{
	public ReferenceManager ReferenceManager { get; set; }

	[HttpGet]
	public ActionResult Delete(long[] referencesId, string popupId, long? folderId)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		List<IReference> references = referencesId.Select((long id) => ReferenceManager.Load(id)).ToList();
		IFolder folder;
		if (!folderId.HasValue)
		{
			IFolder myDocumentFolder = base.SystemFoldersService.GetMyDocumentFolder(currentUser);
			folder = myDocumentFolder;
		}
		else
		{
			folder = FolderManager.Instance.Load(folderId.Value);
		}
		IFolder folder2 = folder;
		return (ActionResult)(object)((Controller)this).PartialView("DeleteGroup", (object)new GroupReferenceInfo
		{
			References = references,
			Folder = folder2,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult Delete(GroupReferenceInfo model)
	{
		model.References.ForEach(delegate(IReference m)
		{
			ReferenceManager.Load(m.Id).Delete();
		});
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Folder.Id
		});
	}

	[HttpGet]
	public ActionResult Edit(long? id, string popupId)
	{
		if (id.HasValue)
		{
			IReference entity = ReferenceManager.Load(id.Value);
			return (ActionResult)(object)((Controller)this).PartialView((object)new ReferenceInfo
			{
				Entity = entity,
				PopupId = popupId
			});
		}
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpPost]
	public ActionResult Edit(ReferenceInfo model)
	{
		if (model.Entity.UseSourceName)
		{
			IReference reference = model.Entity.CastAsRealType();
			model.Entity.Name = ((reference is IDocumentReference) ? ((IDocumentReference)reference).Reference.Name : ((IFolderReference)reference).Reference.Name);
		}
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Entity.Folder.Id
		});
	}

	[HttpGet]
	public ActionResult Move(long? id, string popupId)
	{
		IReference reference = ReferenceManager.Load(id.Value);
		return (ActionResult)(object)((Controller)this).PartialView((object)new ReferenceInfo
		{
			Entity = reference,
			PopupId = popupId,
			CurrentFolder = reference.Folder.Id
		});
	}

	[HttpPost]
	public ActionResult Move(ReferenceInfo model)
	{
		if (model.Entity.Folder != null)
		{
			model.Entity.Save();
		}
		else
		{
			base.Notifier.Error(SR.T("Для перемещения ссылки должна быть задана папка"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = ((model.Entity.Folder != null) ? model.Entity.Folder.Id : model.CurrentFolder)
		});
	}

	[HttpGet]
	public ActionResult Copy(long? id, string popupId)
	{
		IReference entity = ReferenceManager.Load(id.Value);
		return (ActionResult)(object)((Controller)this).PartialView((object)new ReferenceInfo
		{
			Entity = entity,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult Copy(ReferenceInfo model)
	{
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Entity.Folder.Id
		});
	}
}
