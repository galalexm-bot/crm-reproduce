using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Managers.Filters;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class DocumentLinkController : DmsController<IDocumentLink, long>
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public DocumentsSettingsModule SettingsModule { get; set; }

	[CustomGridAction]
	[InNewNHSession(SessionName = "DocumentLinksGrid")]
	public ActionResult Grid(GridCommand command, long documentId)
	{
		IDocument document = DocumentManager.Instance.Load(documentId);
		DocumentLinkFilter filter = new DocumentLinkFilter
		{
			LinkType = DocumentLinkTypes.All,
			Document = document
		};
		GridData<IDocumentLink, DocumentLinkFilter> gridData = base.Manager.CreateGridData(command, filter);
		((ControllerBase)this).get_ViewData().set_Item("documentId", (object)documentId);
		((ControllerBase)this).get_ViewData().set_Item("documentTypeUid", (object)document.TypeUid);
		return GridView(gridData);
	}

	[HttpGet]
	public ActionResult Add(long documentId, long[] selectedDocument)
	{
		IDocument document = DocumentManager.Instance.Load(documentId);
		DocumentLinkModel documentLinkModel = new DocumentLinkModel
		{
			Link = InterfaceActivator.Create<IDocumentLink>(),
			Document = document,
			CheckPermissionForLinks = (SettingsModule.Settings != null && SettingsModule.Settings.CheckPermissionForLinks)
		};
		if (selectedDocument != null)
		{
			documentLinkModel.LinkedDocuments = DocumentManager.Instance.FindByIdArray(selectedDocument).ToList();
		}
		return (ActionResult)(object)((Controller)this).PartialView("Add", (object)documentLinkModel);
	}

	[HttpGet]
	public ActionResult Delete(IDocumentLink model)
	{
		base.Manager.Delete(model);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			delete = true
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult Edit(long id)
	{
		IDocumentLink documentLink = DocumentLinkManager.Instance.Load(id);
		DocumentLinkModel documentLinkModel = new DocumentLinkModel
		{
			Link = documentLink,
			Document = documentLink.Document
		};
		return (ActionResult)(object)((Controller)this).PartialView("Edit", (object)documentLinkModel);
	}

	[HttpPost]
	public ActionResult Save(DocumentLinkModel model)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		DocumentLinkManager.Instance.EditSave(model.Link);
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult Add(DocumentLinkModel model)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		foreach (IDocument linkedDocument in model.LinkedDocuments)
		{
			if (linkedDocument != model.Document)
			{
				InstanceOf<IDocumentLink> instanceOf = new InstanceOf<IDocumentLink>();
				instanceOf.New.Document = model.Document;
				instanceOf.New.Name = model.Link.Name;
				instanceOf.New.LinkedDocument = linkedDocument;
				instanceOf.New.Save();
			}
		}
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public ActionResult DragDropCreate(XhrPostedFile file)
	{
		string value = ((Controller)this).get_Request().Headers["documentId"];
		IDocument document = ((!string.IsNullOrEmpty(value)) ? DocumentManager.Instance.Load(Convert.ToInt64(value)) : null);
		if (document == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не задан документ для связи")
			}, (JsonRequestBehavior)0);
		}
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
		IDocument document2 = CreateDocumentFromFile(document, binaryFile);
		var anon = new
		{
			createdDocument = document2.Id,
			name = document2.Name
		};
		return (ActionResult)(object)((Controller)this).Json((object)anon, (JsonRequestBehavior)0);
	}

	private IDocument CreateDocumentFromFile(IDocument document, BinaryFile binaryFile, IFolder folder = null, bool copyPermission = true)
	{
		IFile file = InterfaceActivator.Create<IFile>();
		file.Name = binaryFile.Name;
		IDocumentVersion documentVersion = InterfaceActivator.Create<IDocumentVersion>();
		file.Versions.Add(documentVersion);
		documentVersion.Document = file;
		documentVersion.Status = DocumentVersionStatus.Current;
		documentVersion.File = binaryFile;
		IFolder folder2 = folder ?? document.Folder;
		folder2 = (file.Folder = DocumentController.ValidateFolder(folder2));
		if (copyPermission)
		{
			DocumentManager.Instance.CopyPermission(document, file);
		}
		file.Save();
		return file;
	}

	public ActionResult FromFileSelectorForm(long documentId)
	{
		IDocument document = DocumentManager.Instance.Load(documentId);
		IFolder folder = DocumentController.ValidateFolder(document.Folder);
		DocumentLinkFromFileModel documentLinkFromFileModel = new DocumentLinkFromFileModel
		{
			Document = document,
			Folder = folder
		};
		return (ActionResult)(object)((Controller)this).PartialView("FromFileSelector", (object)documentLinkFromFileModel);
	}

	[HttpPost]
	public ActionResult CreateFromFile(DocumentLinkFromFileModel model)
	{
		if (model.File == null || model.Document == null)
		{
			return SuccessJson();
		}
		IDocument document = CreateDocumentFromFile(model.Document, model.File, model.Folder, model.CopyPermissions);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			document = document.Id,
			name = document.Name
		}, "text/html", (JsonRequestBehavior)0);
	}

	public ActionResult NeedPermissionAdd(long document, long linkedDocument)
	{
		List<ObjectExtendedPermission> permissionToAdd = DmsObjectManager.Instance.GetPermissionToAdd(linkedDocument, document);
		List<ObjectExtendedPermission> permissionToAdd2 = DmsObjectManager.Instance.GetPermissionToAdd(document, linkedDocument);
		if (permissionToAdd.Count == 0 && permissionToAdd2.Count == 0)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				result = false
			}, (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = true
		}, (JsonRequestBehavior)0);
	}

	public ActionResult PermissionAddForm(long document, long linkedDocument, string submitScript)
	{
		Func<ObjectExtendedPermission, List<IEntity>, bool> fillEntity = delegate(ObjectExtendedPermission o, List<IEntity> entities)
		{
			if (o.UserId > 0)
			{
				entities.Add(UserManager.Instance.Load(o.UserId));
			}
			else if (o.GroupId > 0)
			{
				entities.Add(UserGroupManager.Instance.Load(o.GroupId));
			}
			else if (o.OrganizationItemPositionId > 0)
			{
				entities.Add(OrganizationItemManager.Instance.Load(o.OrganizationItemPositionId));
			}
			else
			{
				entities.Add(OrganizationItemManager.Instance.Load(o.OrganizationItemEmployeeId));
			}
			return true;
		};
		List<ObjectExtendedPermission> permissionToAdd = DmsObjectManager.Instance.GetPermissionToAdd(linkedDocument, document);
		List<IEntity> entitiesDocument = new List<IEntity>();
		permissionToAdd.ForEach(delegate(ObjectExtendedPermission o)
		{
			fillEntity(o, entitiesDocument);
		});
		List<ObjectExtendedPermission> permissionToAdd2 = DmsObjectManager.Instance.GetPermissionToAdd(document, linkedDocument);
		List<IEntity> entitiesLinkDocument = new List<IEntity>();
		permissionToAdd2.ForEach(delegate(ObjectExtendedPermission o)
		{
			fillEntity(o, entitiesLinkDocument);
		});
		Dictionary<object, List<IEntity>> dict = new Dictionary<object, List<IEntity>>();
		Type type = InterfaceActivator.TypeOf<IDmsObject>();
		Permission documentViewPermission = PermissionProvider.DocumentViewPermission;
		bool hasGrantPermission = true;
		Dictionary<long, IEnumerable<Permission>> grandPermissions = new Dictionary<long, IEnumerable<Permission>>();
		Dictionary<IDocument, List<IEntity>> dictionary = new Dictionary<IDocument, List<IEntity>>
		{
			{
				DocumentManager.Instance.Load(document).CastAsRealType(),
				entitiesDocument
			},
			{
				DocumentManager.Instance.Load(linkedDocument).CastAsRealType(),
				entitiesLinkDocument
			}
		};
		dictionary.ForEach(delegate(KeyValuePair<IDocument, List<IEntity>> o)
		{
			IInstanceSettingsPermission settingsPermission = PermissionsModelService.GetSettingsPermission(o.Key);
			dict.Add(o.Key, o.Value);
			if (!settingsPermission.CanGrandPermissions(base.AuthenticationService.GetCurrentUser(), o.Key))
			{
				hasGrantPermission = false;
			}
			ICollection<Permission> value = settingsPermission.CanGrandLevel(base.AuthenticationService.GetCurrentUser(), o.Key);
			if (!grandPermissions.ContainsKey(o.Key.Id))
			{
				grandPermissions.Add(o.Key.Id, value);
			}
		});
		EntityAddPermissionModel entityAddPermissionModel = PermissionsModelService.GetEntityAddPermissionModel(dict, type, ((Controller)this).get_Url(), new Guid[1] { documentViewPermission.Id });
		entityAddPermissionModel.PopupId = "AddDocumentPermission";
		entityAddPermissionModel.LabelText = ((dictionary.Count((KeyValuePair<IDocument, List<IEntity>> o) => o.Value.Count > 0) == 1) ? dictionary.First((KeyValuePair<IDocument, List<IEntity>> o) => o.Value.Count > 0).Key.Name : SR.T("Синхронизация прав доступа"));
		entityAddPermissionModel.ButtonText = SR.T("Сохранить");
		entityAddPermissionModel.SubmitScript = submitScript;
		entityAddPermissionModel.Edit = hasGrantPermission;
		entityAddPermissionModel.GrandPermission = grandPermissions;
		return (ActionResult)(object)((Controller)this).PartialView("PermissionManagment/EntityAddPermission", (object)entityAddPermissionModel);
	}
}
