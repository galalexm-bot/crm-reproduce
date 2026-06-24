using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Controllers;

[Permission("2818B96D-D686-418C-8CCB-6D37815F1497")]
public class DocumentMetadataController : DmsController
{
	private DocumentHistoryProfileManager documentHistoryProfileManager;

	public MetadataItemHeaderManager MetadataItemHeaderManager { get; set; }

	public PermissionsModelService PermissionsModelService { get; set; }

	public WatchListService WatchListService { get; set; }

	public DocumentMetadataController(DocumentHistoryProfileManager documentHistoryProfileManager)
	{
		this.documentHistoryProfileManager = documentHistoryProfileManager;
	}

	[HttpGet]
	public ActionResult List()
	{
		IEnumerable<IDocumentMetadataHead> enumerable = DocumentMetadataHeadManager.Instance.PublishedHeads();
		IEnumerable<IMetadataItemHeader> metadataInfos = MetadataItemHeaderManager.Load(enumerable.Select((IDocumentMetadataHead d) => d.DocumentTypeUid));
		DocumentMetadataGrid model = new DocumentMetadataGrid();
		enumerable.ForEach(delegate(IDocumentMetadataHead d)
		{
			IMetadataItemHeader metadataItemHeader = metadataInfos.FirstOrDefault((IMetadataItemHeader m) => m.Uid == d.DocumentTypeUid);
			DocumentMetadata entity = (DocumentMetadata)MetadataLoader.LoadMetadata(d.DocumentTypeUid, inherit: true, loadImplementation: false);
			DocumentMetadataInfo documentMetadataInfo = new DocumentMetadataInfo
			{
				Entity = entity
			};
			if (metadataItemHeader != null)
			{
				documentMetadataInfo.CreationAuthor = (metadataItemHeader.CreationAuthorId.HasValue ? UserManager.Instance.Load(metadataItemHeader.CreationAuthorId.Value) : null);
				documentMetadataInfo.CreationDate = metadataItemHeader.CreationDate;
				documentMetadataInfo.DateModified = ((metadataItemHeader.Current != null) ? new DateTime?(metadataItemHeader.Current.CreationDate) : null);
				documentMetadataInfo.PublishedCreationDate = ((metadataItemHeader.Published != null) ? new DateTime?(metadataItemHeader.Published.CreationDate) : null);
			}
			model.Data.Add(documentMetadataInfo);
		});
		((Controller)(object)this).SetCurrentMenuItem("document_module_settings");
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[HttpGet]
	public ActionResult Settings(Guid uid)
	{
		IDocumentMetadataProfile profile = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			profile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(uid);
		});
		if (profile == null)
		{
			profile = InterfaceActivator.Create<IDocumentMetadataProfile>();
			profile.DocumentType = new ReferenceOnEntityType
			{
				TypeUid = uid
			};
			(from p in ComponentManager.Current.GetExtensionPoints<IDocumentMetadataProfileInitProvider>()
				where p.CheckType(uid)
				select p).ToList().ForEach(delegate(IDocumentMetadataProfileInitProvider p)
			{
				p.Init(profile);
			});
			profile.Save();
		}
		if (!profile.AuthorDefaultPermissionId.HasValue)
		{
			profile.AuthorDefaultPermissionId = PermissionProvider.DocumentFullAccessPermission.Id;
		}
		DocumentMetadataProfileInfo model = new DocumentMetadataProfileInfo
		{
			Entity = profile
		};
		model.CreateDocumentRoleTypeSelectorModel = MembersPopupModel();
		IEnumerable<AssignedRoleTypeModel> createDocumentRoleTypeModels = PermissionsModelService.CreateAssignedRoleTypeModel(from p in (IEnumerable<IDmsObjectDefaultPermissions>)profile.Permissions
			where p.PermissionId == PermissionProvider.DocumentMetadataCreateInstance.Id
			select p.Assigned);
		model.CreateDocumentRoleTypeModels = createDocumentRoleTypeModels;
		model.WatchListRoleTypeSelectorModel = WatchListService.CreateNew("membersWatchListPopup", "watchListMembers", ((Controller)this).get_Url());
		IMetadata metadata = MetadataLoader.LoadMetadata(uid);
		model.WatchListRoleTypeModels = WatchListService.CreateAssignedRoleTypeModel(metadata.Uid);
		model.DocumentHistory = new DocumentHistoryProfileView
		{
			Entity = ((IEnumerable<IDocumentHistoryProfile>)profile.HistoryViewSettings).FirstOrDefault()
		};
		if (model.DocumentHistory.Entity == null)
		{
			model.DocumentHistory.Entity = DocumentHistoryProfileManager.Instance.CreateNew(uid);
		}
		else
		{
			DocumentHistoryProfileManager.Instance.RefreshProfile(model.DocumentHistory.Entity);
		}
		model.ActionsProfile = new DocumentActionsProfileView
		{
			Entity = DocumentActionSettingsHolderView.Create(profile.ActionVisibility as DocumentActionSettingsHolder)
		};
		if (model.ActionsProfile.Entity == null)
		{
			model.ActionsProfile.Entity = DocumentActionSettingsHolderView.Create(DocumentActionsProfileManager.Instance.CreateNew(uid));
		}
		else
		{
			DocumentActionSettingsHolder holder = model.ActionsProfile.Entity.GetHolder();
			DocumentActionsProfileManager.Instance.RefreshProfile(holder);
			model.ActionsProfile.Entity = DocumentActionSettingsHolderView.Create(holder);
		}
		ComponentManager.Current.GetExtensionPoints<IDocumentMetadataSaveHandler>().ToList().ForEach(delegate(IDocumentMetadataSaveHandler h)
		{
			h.Init(model, ((Controller)this).get_Url());
		});
		((Controller)(object)this).SetCurrentMenuItem("document_module_settings");
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[HttpGet]
	public ActionResult TemplateAddFilePopup()
	{
		return (ActionResult)(object)((Controller)this).PartialView();
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Settings(DocumentMetadataProfileInfo info, EditableListModel defaultPermissions, [Bind(Prefix = "createDocumentMembers")] EditableListModel createDocumentMembers, [Bind(Prefix = "watchListMembers")] EditableListModel watchListMembers, [Bind(Prefix = "signListMembers")] EditableListModel signListMembers, [JsonBinder] TemplatiesFullModel templateList)
	{
		try
		{
			if (templateList != null)
			{
				IEnumerable<IDocumentGeneratorProvider> docProviders = ComponentManager.Current.GetExtensionPoints<IDocumentGeneratorProvider>();
				info.Entity.Templates.RemoveAll((ICollection<IDocumentTemplate>)((IEnumerable<IDocumentTemplate>)info.Entity.Templates).Where((IDocumentTemplate t) => !t.IsNew()).ToList());
				templateList.Templates.ForEach(delegate(SimpleTemplateModel t)
				{
					string ext = Path.GetExtension(t.Name).ToUpper();
					if (docProviders.FirstOrDefault((IDocumentGeneratorProvider p) => p.SupportedExtensions != null && p.SupportedExtensions.Select((string e) => e.ToUpper()).Contains(ext)) == null)
					{
						throw new InvalidOperationException(SR.T("Не удалось найти провайдер для генерации файла с расширением {0}", ext));
					}
					if (t.TemplateId > 0)
					{
						info.Entity.Templates.Add(DocumentTemplateManager.Instance.Load(t.TemplateId));
					}
					else if (t.TemplateType == DocumentTemplateType.Document)
					{
						InstanceOf<IDocumentTemplate> instanceOf2 = new InstanceOf<IDocumentTemplate>();
						instanceOf2.New.Document = DocumentManager.Instance.Load(t.DocumentId);
						instanceOf2.New.Profile = info.Entity;
						instanceOf2.New.TemplateType = DocumentTemplateType.Document;
						IDocumentTemplate @new = instanceOf2.New;
						info.Entity.Templates.Add(@new);
					}
				});
			}
			if (defaultPermissions != null && defaultPermissions.Items != null)
			{
				PermissionsModelService.BindPermissionsFromModel(info.Entity, defaultPermissions, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
				{
					holders.SyncFrom(newHolders, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), (IInstanceSettingsPermissionHolder v) => v.PermissionId != PermissionProvider.DocumentViewPermission.Id && v.PermissionId != PermissionProvider.DocumentLoadPermission.Id && v.PermissionId != PermissionProvider.DocumentEditPermission.Id && v.PermissionId != PermissionProvider.DocumentFullAccessPermission.Id && v.PermissionId != PermissionProvider.DocumentManagerAccessPermission.Id, delegate(IInstanceSettingsPermissionHolder v)
					{
						if (v is IEntity)
						{
							((IEntity)v).Delete();
						}
					});
				});
			}
			if (createDocumentMembers != null && createDocumentMembers.Items != null)
			{
				UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
				List<EditableListItem> list = createDocumentMembers.Items.ToList();
				List<IDmsObjectDefaultPermissions> newPermissions = new List<IDmsObjectDefaultPermissions>();
				list.ForEach(delegate(EditableListItem e)
				{
					Tuple<IEntity, PermissionRoleType> assignedEntity = PermissionsModelService.GetAssignedEntity(e, info.Entity);
					List<IDmsObjectDefaultPermissions> list2 = newPermissions;
					InstanceOf<IDmsObjectDefaultPermissions> instanceOf = new InstanceOf<IDmsObjectDefaultPermissions>();
					instanceOf.New.DocumentMetadataProfile = info.Entity;
					instanceOf.New.PermissionId = PermissionProvider.DocumentMetadataCreateInstance.Id;
					instanceOf.New.TypeRoleId = assignedEntity.Item2.Id;
					instanceOf.New.Assigned = assignedEntity.Item1;
					list2.Add(instanceOf.New);
				});
				((ICollection<IDmsObjectDefaultPermissions>)info.Entity.Permissions).SyncFrom(newPermissions, (IDmsObjectDefaultPermissions v1, IDmsObjectDefaultPermissions v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), (IDmsObjectDefaultPermissions v1) => v1.PermissionId != PermissionProvider.DocumentMetadataCreateInstance.Id, delegate(IDmsObjectDefaultPermissions v)
				{
					v.Delete();
				});
			}
			ComponentManager.Current.GetExtensionPoints<IDocumentMetadataSaveHandler>().ToList().ForEach(delegate(IDocumentMetadataSaveHandler h)
			{
				h.Save(signListMembers, info);
			});
			if (watchListMembers != null && watchListMembers.Items != null)
			{
				IMetadata metadata = MetadataLoader.LoadMetadata(info.Entity.DocumentType.TypeUid);
				WatchListService.SaveFromModel(metadata.Uid, watchListMembers);
			}
			if (info.DocumentHistory != null && info.DocumentHistory.Entity != null)
			{
				((ICollection<IDocumentHistoryProfile>)info.Entity.HistoryViewSettings).Clear();
				info.Entity.HistoryViewSettings.Add(info.DocumentHistory.Entity);
			}
			if (info.ActionsProfile != null && info.ActionsProfile.Entity != null)
			{
				info.Entity.ActionVisibility = info.ActionsProfile.Entity.GetHolder();
				DocumentActionsProfileManager.Instance.ClearCache();
				documentHistoryProfileManager.RefreshSupportedDocumentCacheRecord(info.Entity);
			}
			info.Entity.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction("List", "DocumentMetadata", (object)new
			{
				area = "EleWise.ELMA.Documents.Web"
			});
		}
		catch (InvalidOperationException ex)
		{
			base.Notifier.Error(ex.Message);
			return (ActionResult)(object)((Controller)this).RedirectToAction("Settings", "DocumentMetadata", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				uid = info.Entity.DocumentType
			});
		}
	}

	private PermissionRoleTypeSelectorModel MembersPopupModel()
	{
		PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel = new PermissionRoleTypeSelectorModel();
		permissionRoleTypeSelectorModel.PopupId = "membersCreateDocumentInstancePopup";
		permissionRoleTypeSelectorModel.Title = SR.T("Выбор участника");
		permissionRoleTypeSelectorModel.TypeRoles = new PermissionRoleType[3]
		{
			CommonRoleTypes.User,
			CommonRoleTypes.Group,
			CommonRoleTypes.OrganizationItem
		};
		permissionRoleTypeSelectorModel.SelectedTypeRole = CommonRoleTypes.User;
		permissionRoleTypeSelectorModel.ObjectId = "theGriupId";
		permissionRoleTypeSelectorModel.SubmitScript = "elma.appendFromPermissionPopup('createDocumentMembers')";
		permissionRoleTypeSelectorModel.CreatePopup = true;
		permissionRoleTypeSelectorModel.OrganizationTreeModel = PermissionsModelService.CreateOrganizationTreeModel("membersCreateDocumentInstancePopup");
		permissionRoleTypeSelectorModel.GroupsTreeModel = PermissionsModelService.CreateGroupsModel("membersCreateDocumentInstancePopup");
		permissionRoleTypeSelectorModel.ExtGroupsTreeModel = PermissionsModelService.CreateExtGroupsModel("membersCreateDocumentInstancePopup");
		permissionRoleTypeSelectorModel.UserModel = PermissionsModelService.CreateUserModel("membersCreateDocumentInstancePopup", ((Controller)this).get_Url());
		return permissionRoleTypeSelectorModel;
	}
}
