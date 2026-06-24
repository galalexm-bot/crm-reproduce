using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Components;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentInfo : DynamicEntityViewModel<IDocument>
{
	private Lazy<bool> anyFiles;

	private Lazy<DocumentMetadata> _metadata;

	private Lazy<bool> _editPerm;

	private Lazy<bool> _editFolderPerm;

	private Lazy<bool> _createFolderPerm;

	private Lazy<bool> loadPerm;

	private Lazy<bool> _fullPerm;

	private Lazy<bool> _deletePerm;

	private Lazy<List<IDocumentViewProvider>> viewProviders;

	public bool AnyFiles => anyFiles.Value;

	public IDocument ClonnableDocument { get; set; }

	public bool MakeVersionCurrent { get; set; }

	public string PopupId { get; set; }

	public string Callback { get; set; }

	public bool IsCopied { get; set; }

	public bool AllowRename { get; set; }

	public bool RestrictChangeFolder { get; set; }

	public long? LinkedDocument { get; set; }

	public long? ParentDocument { get; set; }

	public bool CopyPermissionFromParent { get; set; }

	public string Parameters { get; set; }

	public bool IsWebDocument => WebDocumentManager.Instance.IsWebDocument(base.Entity);

	public bool HasUserAttributes => WebDocumentManager.Instance.HasUserAttributes(base.Entity);

	public IDocumentVersion Version { get; set; }

	public new DocumentMetadata Metadata
	{
		get
		{
			if ((_metadata == null || !_metadata.IsValueCreated) && base.Entity != null)
			{
				_metadata = new Lazy<DocumentMetadata>(() => (DocumentMetadata)MetadataLoader.LoadMetadata(base.Entity.CastAsRealType().GetType()));
			}
			return _metadata.Value;
		}
	}

	public bool EditPermission
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (_editPerm == null)
			{
				_editPerm = new Lazy<bool>(() => Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, base.Entity));
			}
			if (!FullPermission)
			{
				return _editPerm.Value;
			}
			return true;
		}
	}

	public bool EditFolderPermission
	{
		get
		{
			if (base.Entity == null || base.Entity.Folder == null)
			{
				return false;
			}
			if (_editFolderPerm == null)
			{
				_editFolderPerm = new Lazy<bool>(() => Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, base.Entity.Folder) || Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentEditPermission, base.Entity.Folder));
			}
			return _editFolderPerm.Value;
		}
	}

	public bool CreateDocumentsInFolderPermission
	{
		get
		{
			if (base.Entity == null || base.Entity.Folder == null)
			{
				return false;
			}
			if (_createFolderPerm == null)
			{
				_createFolderPerm = new Lazy<bool>(() => Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, base.Entity.Folder) || Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentCreatePermission, base.Entity.Folder));
			}
			return _createFolderPerm.Value;
		}
	}

	public bool InFavorites { get; set; }

	public bool LoadPermission
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (loadPerm == null)
			{
				loadPerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentLoadPermission, base.Entity));
			}
			return loadPerm.Value;
		}
	}

	public bool FullPermission
	{
		get
		{
			if (base.Entity == null)
			{
				return false;
			}
			if (_fullPerm == null)
			{
				_fullPerm = new Lazy<bool>(() => Locator.GetService<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, base.Entity));
			}
			return _fullPerm.Value;
		}
	}

	public bool IsCustomChangeStatus
	{
		get
		{
			if (base.Entity != null)
			{
				return new LifeCycleStatusChangerModel
				{
					Document = base.Entity
				}.IsCustomChangeStatus;
			}
			return false;
		}
	}

	public bool DocumentsDeletePermission
	{
		get
		{
			if (_deletePerm == null)
			{
				_deletePerm = new Lazy<bool>(() => Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentDeletePermission));
			}
			return _deletePerm.Value;
		}
	}

	public IDocumentMetadataProfile Profile { get; set; }

	public bool UseFile { get; set; }

	public string DecryptPassword { get; set; }

	public long? InitFolderId { get; set; }

	public override DynamicFormSettings DynamicFormSettings
	{
		get
		{
			if (dynamicFormSettings != null)
			{
				return dynamicFormSettings;
			}
			ViewItemId = ((base.FormUid == Guid.Empty) ? EntityObjectViewItemProvider.CreateViewItemId(base.Entity, base.ViewType, ItemType.Default) : DocumentObjectViewItemProvider.CreateViewItemId(base.Entity, base.ViewType, base.FormUid, ItemType.Default));
			DynamicFormSettings = new DynamicFormSettings
			{
				DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
				DynamicFormsProviderData = EntityDynamicFormProvider.CreateData(base.Entity, base.ViewType, ItemType),
				ViewProviderUid = DocumentObjectViewItemProvider.UID,
				ViewItemId = ViewItemId
			};
			if (!string.IsNullOrEmpty(base.FormId))
			{
				dynamicFormSettings.FormId = base.FormId;
			}
			Type type = base.Entity.CastAsRealType().GetType();
			_ = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
			if (View == null)
			{
				View = ((base.FormUid == Guid.Empty) ? DocumentObjectViewItemProvider.GetViewItem(type, base.ViewType) : DocumentObjectViewItemProvider.GetViewItem(type, base.ViewType, base.FormUid));
			}
			GetViewItem();
			return dynamicFormSettings;
		}
		set
		{
			dynamicFormSettings = value;
		}
	}

	public override FormViewItem View
	{
		get
		{
			return GetViewItem();
		}
		set
		{
			view = value;
		}
	}

	public List<IDocumentViewProvider> ViewProviders
	{
		get
		{
			if (base.Entity == null)
			{
				return new List<IDocumentViewProvider>();
			}
			if (viewProviders == null)
			{
				viewProviders = new Lazy<List<IDocumentViewProvider>>(() => (from p in ComponentManager.Current.GetExtensionPoints<IDocumentViewProvider>()
					where p.CheckType(base.Entity)
					select p).ToList());
			}
			return viewProviders.Value;
		}
	}

	public Guid CurrentViewProvider { get; set; }

	public bool SaveToCurrentVersion { get; set; }

	public DocumentInfo()
		: this(null, ViewType.Create)
	{
	}

	public DocumentInfo(IDocument entity, ViewType viewType)
		: this(entity, viewType, null)
	{
	}

	public DocumentInfo(IDocument entity, ViewType viewType, string formId)
		: this(entity, Guid.Empty, formId, viewType)
	{
	}

	public DocumentInfo(IDocument entity, Guid fomGuid, string formId, ViewType viewType = ViewType.Custom)
		: base(entity, viewType)
	{
		base.FormUid = fomGuid;
		base.FormId = formId;
		MakeVersionCurrent = true;
		CopyPermissionFromParent = true;
		ApplyFormTransformations();
		UseFile = !WebDocumentManager.Instance.IsWebDocument(entity);
		anyFiles = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Entity.TypeUid, base.Entity));
	}

	private void ApplyFormTransformations()
	{
		if (base.Entity == null)
		{
			return;
		}
		Type type = base.Entity.CastAsRealType().GetType();
		EntityMetadata metadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		if (metadata != null)
		{
			ComponentManager.Current.GetExtensionPoints<IMetadataFormsTransformations>().ForEach(delegate(IMetadataFormsTransformations p)
			{
				p.Transformate(metadata);
			});
		}
	}

	public bool IsConvertible()
	{
		List<Guid> list = ComponentManager.Current.GetExtensionPoints<IConvertDocumentUnconvertibleTypes>().SelectMany((IConvertDocumentUnconvertibleTypes m) => m.GetUnconvertibleTypesUids()).ToList();
		if (Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentsConvertPermission) && !base.Entity.Encrypt)
		{
			return !list.Contains(Metadata.Uid);
		}
		return false;
	}

	public IDocumentViewProvider GetCurrentViewProvider()
	{
		return ViewProviders.FirstOrDefault((IDocumentViewProvider p) => p.Uid == CurrentViewProvider) ?? ViewProviders.First();
	}

	public bool CheckActionVisibility(Guid actionUid, Guid chapterUid)
	{
		return DocumentActionsProfileManager.Instance.ActionIsVisible(actionUid, chapterUid, base.Entity.TypeUid);
	}

	private FormViewItem GetViewItem()
	{
		if (view != null)
		{
			return view;
		}
		Type type = base.Entity.CastAsRealType().GetType();
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(type);
		if (base.FormUid.HasValue && base.FormUid.Value != Guid.Empty)
		{
			view = documentMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == base.FormUid.Value);
		}
		else
		{
			view = DocumentObjectViewItemProvider.GetViewItem(type, base.ViewType);
		}
		if (view != null && view.RuntimeVersion == RuntimeVersion.Version1)
		{
			view = DynamicFormHelper.FormWithExecutedLoadScripts(view, base.Entity, documentMetadata, DynamicFormSettings);
		}
		if (view == null)
		{
			return null;
		}
		if (base.ViewType == ViewType.Display)
		{
			base.FormReadOnly = true;
		}
		if (base.FormReadOnly)
		{
			view = (FormViewItem)view.CloneAsReadOnly();
			base.ViewType = ViewType.Display;
		}
		return view;
	}
}
