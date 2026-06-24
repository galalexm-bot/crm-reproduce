using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class DmsObjectController : DmsController<IDmsObject, long>
{
	public PermissionsModelService PermissionsModelService { get; set; }

	public IPermissionManagmentService PermissionManagmentService { get; set; }

	public IEnumerable<IModuleSettingsDmsPageProvider> ModuleSettingsDmsPageProvider { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	[HttpGet]
	public ActionResult PermissionSettings(long id, bool? forPopup = false)
	{
		IDmsObject instance = DmsObjectManager.Load(id);
		return PermissionSettings(instance, forPopup);
	}

	public ActionResult GetPermissionSettings(long id, bool? forPopup = false)
	{
		return PermissionSettings(id, forPopup);
	}

	[HttpGet]
	public ActionResult PermissionFolderSettings(long id, bool? forPopup = false)
	{
		IFolder folder = FolderManager.Instance.Load(id);
		if (folder.Virtual)
		{
			return PermissionSettings(folder, forPopup);
		}
		return PermissionSettings(folder, forPopup, InterfaceActivator.TypeOf<IFolder>());
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel access)
	{
		IDmsObject instance = DmsObjectManager.Load(id);
		PermissionsModelService.BindPermissionsFromModel(instance, access, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
		{
			List<IInstanceSettingsPermissionHolder> list = new List<IInstanceSettingsPermissionHolder>();
			if (instance.InheritPermissions)
			{
				list.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IDmsObjectPermission)h).InheritedFromFolder != null));
				foreach (IInstanceSettingsPermissionHolder item in list)
				{
					holders.Remove(item);
				}
			}
			holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
			{
				if (v is IEntity)
				{
					((IEntity)v).Delete();
				}
			});
			if (instance.InheritPermissions)
			{
				foreach (IInstanceSettingsPermissionHolder item2 in list)
				{
					holders.Add(item2);
				}
			}
		});
		DmsObjectManager.Save(instance);
		string text = ((Controller)this).get_Url().ReturnUrl();
		if (instance.CastAsRealType() is IDocument)
		{
			text = ((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: false, "Access");
		}
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	private ActionResult PermissionSettings(IDmsObject instance, bool? forPopup = false)
	{
		return PermissionSettings(instance, forPopup, InterfaceActivator.TypeOf<IDmsObject>());
	}

	private ActionResult PermissionSettings(IDmsObject instance, bool? forPopup, Type entityType)
	{
		DmsObjectPermissionModel dmsObjectPermissionModel = new DmsObjectPermissionModel
		{
			InheritPermissions = instance.InheritPermissions,
			Id = instance.Id,
			ForPopup = (forPopup.HasValue && forPopup.Value)
		};
		Action<EntityPermissionRoleTypeSelectorModel> action = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "DmsObject",
				area = "EleWise.ELMA.Documents.Web"
			});
		};
		dmsObjectPermissionModel.InheritAvailable = instance.Folder != null;
		if (instance.InheritPermissions)
		{
			dmsObjectPermissionModel.InheritedPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, entityType, ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IDmsObjectPermission)h).InheritedFromFolder != null);
			action(dmsObjectPermissionModel.InheritedPermissionsModel);
			dmsObjectPermissionModel.InheritedPermissionsModel.Edit = false;
			dmsObjectPermissionModel.InheritedPermissionsModel.ShowSaveButton = !dmsObjectPermissionModel.ForPopup;
		}
		dmsObjectPermissionModel.AdditionalPermissionsModel = PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, entityType, ((Controller)this).get_Url(), (IInstanceSettingsPermissionHolder h) => ((IDmsObjectPermission)h).InheritedFromFolder == null);
		action(dmsObjectPermissionModel.AdditionalPermissionsModel);
		dmsObjectPermissionModel.Edit = dmsObjectPermissionModel.AdditionalPermissionsModel.Edit;
		dmsObjectPermissionModel.AdditionalPermissionsModel.ShowSaveButton = !dmsObjectPermissionModel.ForPopup;
		dmsObjectPermissionModel.ChangeInherite = base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, instance);
		if (instance.CastAsRealType() is IDocument)
		{
			IDocument document = (IDocument)instance;
			DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
			dmsObjectPermissionModel.HasCrypto = documentMetadata.EnableCrypto || document.Encrypt;
			dmsObjectPermissionModel.Object = document;
		}
		return (ActionResult)(object)((Controller)this).PartialView("DmsObject/PermissionSettings", (object)dmsObjectPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(long id, bool enable)
	{
		IDmsObject dmsObject = DmsObjectManager.Load(id);
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentsAdminAccessPermission) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, dmsObject))
		{
			throw new SecurityException();
		}
		DmsObjectManager.EnableInheritPermissions(dmsObject, enable);
		bool flag = FolderManager.Instance.IsFolder(dmsObject.TypeUid);
		return PermissionSettings(dmsObject, false, flag ? InterfaceActivator.TypeOf<IFolder>() : InterfaceActivator.TypeOf<IDmsObject>());
	}

	[HttpGet]
	public ActionResult Rename(long dmsObjectsId, string popupId, string redirectUrl)
	{
		IDmsObject dmsObject = DmsObjectManager.Load(dmsObjectsId).CastAsRealType();
		bool num = dmsObject is IDocument;
		bool encrypted = false;
		if (num)
		{
			IDocument document = (IDocument)dmsObject;
			if (!DocumentController.CheckDocumentAction(document, DocumentActionProvider.DocumentRenameActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var _))
			{
				throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentRenameActionUID);
			}
			if (document.Encrypt)
			{
				encrypted = true;
				dmsObject = DocumentController.CheckIsCrypt((IDocument)dmsObject);
			}
		}
		DmsObjectRenameViewInfo dmsObjectRenameViewInfo = new DmsObjectRenameViewInfo
		{
			DmsObjectId = dmsObjectsId,
			PopupId = popupId,
			OldName = dmsObject.Name,
			NewName = dmsObject.Name,
			RedirectUrl = redirectUrl,
			Encrypted = encrypted
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)dmsObjectRenameViewInfo);
	}

	[HttpPost]
	public ActionResult Rename(DmsObjectRenameViewInfo model)
	{
		long dmsObjectId = model.DmsObjectId;
		bool flag = true;
		IDmsObject dmsObject = DmsObjectManager.Load(dmsObjectId).CastAsRealType();
		bool flag2 = dmsObject is IDocument && ((IDocument)dmsObject).Encrypt;
		if (dmsObject.TypeUid == InterfaceActivator.UID<IFavoritesFolder>() || dmsObject.TypeUid == InterfaceActivator.UID<IMyDocumentFolder>())
		{
			base.Notifier.Error(SR.T("Папка \"{0}\" не может быть переименована.", dmsObject.Name));
			flag = false;
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, dmsObject) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, dmsObject))
		{
			base.Notifier.Error(SR.T("Нет прав для переименования объекта: {0}", dmsObject.Name));
			flag = false;
		}
		if (dmsObject.IsArchived == true)
		{
			base.Notifier.Error(SR.T("Документ \"{0}\" находится в архиве и не может быть переименован", dmsObject.Name));
			flag = false;
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(dmsObject.GetType());
		if (documentMetadata != null && !documentMetadata.IsAllowRename)
		{
			base.Notifier.Error(SR.T("Настройки метаданных документа \"{0}\" запрещают переименование", dmsObject.Name));
			flag = false;
		}
		if (flag)
		{
			if (model.NewName == null)
			{
				base.Notifier.Error(SR.T("Необходимо указать новое имя"));
			}
			else if (flag2)
			{
				if (!DocumentManager.Instance.CheckPassword((IDocument)dmsObject, model.Password, writeHistory: true))
				{
					base.Notifier.Error(SR.T("Неверный пароль для шифрования"));
					return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
				}
				DocumentManager.Instance.Rename((IDocument)dmsObject, model.NewName, model.Password);
			}
			else
			{
				DmsObjectManager.Instance.Rename(dmsObject, model.NewName);
			}
		}
		if (string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = dmsObject.Folder.Id
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
	}

	[HttpGet]
	public ActionResult Move(long[] dmsObjectsIds, string popupId, string redirectUrl)
	{
		IDmsObject dmsObject = DmsObjectManager.Load(dmsObjectsIds[0]);
		List<bool> list = (from t in DmsObjectManager.Instance.GetTypeUids(dmsObjectsIds.ToList())
			select FolderManager.Instance.IsFolder(t)).ToList();
		string text = "isedit";
		text = ((!list.Contains(item: false)) ? "isedit" : (list.Contains(item: true) ? "isedit;iscreatedocument" : "iscreatedocument"));
		DmsObjectMoveViewInfo dmsObjectMoveViewInfo = new DmsObjectMoveViewInfo
		{
			JsonDmsObjectIds = ClassSerializationHelper.SerializeObjectByJson(dmsObjectsIds),
			PopupId = popupId,
			OldFolder = dmsObject.Folder,
			NewFolder = dmsObject.Folder,
			RedirectUrl = redirectUrl,
			Count = dmsObjectsIds.Count(),
			EditMode = text
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)dmsObjectMoveViewInfo);
	}

	[HttpPost]
	public ActionResult Move(DmsObjectMoveViewInfo model)
	{
		long[] idArray = (long[])ClassSerializationHelper.DeserializeObjectByJson(typeof(long[]), model.JsonDmsObjectIds);
		bool canMove = true;
		List<IDmsObject> list = DmsObjectManager.FindByIdArray(idArray).ToList();
		List<IDocument> list2 = list.Where((IDmsObject o) => o.CastAsRealType() is IDocument).Cast<IDocument>().ToList();
		if (!DocumentController.CheckDocumentAction(list2, DocumentActionProvider.DocumentMoveActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var checkedDocuments, out var messages))
		{
			WriteErrorMessages(messages);
			foreach (IDocument item in list2)
			{
				if (!checkedDocuments.Contains(item))
				{
					list.Remove(item);
				}
			}
		}
		List<IDmsObject> list3 = list.Where(delegate(IDmsObject o)
		{
			if (o.TypeUid == InterfaceActivator.UID<IFavoritesFolder>() || o.TypeUid == InterfaceActivator.UID<IMyDocumentFolder>())
			{
				base.Notifier.Error(SR.T("Папка \"{0}\" не может быть перемещена.", o.Name));
				canMove = false;
			}
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, o) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, o))
			{
				base.Notifier.Error(SR.T("Нет прав для переноса объекта: {0}", o.Name));
				canMove = false;
			}
			if (o.IsArchived == true)
			{
				base.Notifier.Error(SR.T("Документ \"{0}\" находится в архиве и не может быть перемещен", o.Name));
				canMove = false;
			}
			if (o.TypeUid == InterfaceActivator.UID(typeof(IFolder)) && FolderManager.Instance.IsParentFolder(o as IFolder, model.NewFolder))
			{
				canMove = false;
				base.Notifier.Error(SR.T($"Папка \"{o.Name}\" не может быть перемещена в дочернюю папку \"{model.NewFolder.Name}\""));
			}
			if (model.NewFolder != null)
			{
				if (o.Uid == model.NewFolder.Uid)
				{
					base.Notifier.Error(SR.T("Перенос папки \"{0}\" в \"{1}\" недопустим", model.NewFolder.Name, model.NewFolder.Name));
					canMove = false;
				}
				if (FolderManager.Instance.IsFolder(o.TypeUid))
				{
					if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, model.NewFolder) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, model.NewFolder))
					{
						base.Notifier.Error(SR.T(string.Format("Для перемещения папки \"{0}\" в папку \"{1}\" нужны права на редактирования на папку \"{1}\"", o.Name, model.NewFolder.Name)));
						canMove = false;
					}
					if (FolderManager.Instance.CheckFolderWithSameName(model.NewFolder, o.Name))
					{
						canMove = false;
						base.Notifier.Error(SR.T(string.Format("Папка \"{0}\" не может быть перемещена в дочернюю папку \"{1}\", так как в папке \"{1}\" существует папка с именем \"{0}\"", o.Name, model.NewFolder.Name)));
					}
				}
				else if (!base.SecurityService.HasPermission(PermissionProvider.DocumentCreatePermission, model.NewFolder))
				{
					base.Notifier.Error(SR.T(string.Format("Для перемещения объкта \"{0}\" в папку \"{1}\" нужна привилегия на Создание документов в папке \"{1}\"", o.Name, model.NewFolder.Name)));
					canMove = false;
				}
			}
			return true;
		}).ToList();
		if (canMove)
		{
			if (model.NewFolder == null)
			{
				base.Notifier.Error(SR.T("Для переноса необходимо указать папку"));
			}
			else
			{
				DmsObjectManager.MoveTo(model.NewFolder, list3.Select((IDmsObject m) => m.Id).ToList(), list3);
			}
		}
		if (string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = ((model.OldFolder != null) ? model.OldFolder.Id : model.NewFolder.Id)
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
	}

	[HttpGet]
	public ActionResult Delete(long[] dmsObjectIds, string popupId, string redirectUrl)
	{
		ICollection<IDmsObject> collection = DmsObjectManager.FindByIdArray(dmsObjectIds);
		List<IDocument> list = collection.Where((IDmsObject o) => o.CastAsRealType() is IDocument).Cast<IDocument>().ToList();
		if (!DocumentController.CheckDocumentAction(list, DocumentActionProvider.DocumentDeleteActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var checkedDocuments, out var messages))
		{
			WriteErrorMessages(messages);
			foreach (IDocument item in list)
			{
				if (!checkedDocuments.Contains(item))
				{
					collection.Remove(item);
				}
			}
		}
		List<IDmsObject> list2 = collection.ToList();
		DmsObjectDeleteViewInfo dmsObjectDeleteViewInfo = new DmsObjectDeleteViewInfo
		{
			DmsObjects = list2,
			JsonDmsObjectIds = ClassSerializationHelper.SerializeObjectByJson(list2.Select((IDmsObject m) => m.Id).ToArray()),
			PopupId = popupId,
			Folder = (list2.Any() ? list2[0].Folder : null),
			RedirectUrl = redirectUrl,
			Count = list2.Count
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)dmsObjectDeleteViewInfo);
	}

	[HttpPost]
	public ActionResult Delete(DmsObjectDeleteViewInfo model)
	{
		long[] idArray = (long[])ClassSerializationHelper.DeserializeObjectByJson(typeof(long[]), model.JsonDmsObjectIds);
		bool canDelete = true;
		ICollection<IDmsObject> collection = DmsObjectManager.FindByIdArray(idArray);
		List<IDocument> list = collection.Where((IDmsObject o) => o.CastAsRealType() is IDocument).Cast<IDocument>().ToList();
		if (!DocumentController.CheckDocumentAction(list, DocumentActionProvider.DocumentDeleteActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var checkedDocuments, out var messages))
		{
			WriteErrorMessages(messages);
			foreach (IDocument item in list)
			{
				if (!checkedDocuments.Contains(item))
				{
					collection.Remove(item);
				}
			}
		}
		List<IDmsObject> list2 = collection.Where(delegate(IDmsObject o)
		{
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentDeletePermission) || !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, o))
			{
				base.Notifier.Error(SR.T("Нет прав для удаления объекта: {0}", o.Name));
				canDelete = false;
			}
			if (!o.IsArchived.HasValue || !o.IsArchived.Value)
			{
				SR.T("Документ: {0} не может быть удален. Сначала документ необходимо поместить в архив", o.Name);
				canDelete = false;
			}
			return true;
		}).ToList();
		if (canDelete)
		{
			foreach (IDmsObject item2 in list2)
			{
				DmsObjectManager.Delete(item2);
				DmsObjectManager.Save(item2);
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Folder.Id
		});
	}
}
