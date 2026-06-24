using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.Components;
using EleWise.ELMA.Documents.Web.ExtensionPoints;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Documents.Web.Portlets;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Convertors;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Settings;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Mvc.UI;
using Orchard.Themes;

namespace EleWise.ELMA.Documents.Web.Controllers;

[RouteArea("EleWise.ELMA.Documents.Web")]
public class DocumentController : DmsController<IDocument, long>
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IConvertProcessService convertProcessService;

	private readonly IEntityActionHandler entityActionHandler;

	private readonly DragAndDropSettingsBlock dragAndDropSettingsBlock;

	private readonly IConvertConflictFindingService convertConflictFindingService;

	private readonly ITemporaryAuthenticationService temporaryAuthenticationService;

	private readonly IEnumerable<ICreatePopupDocumentExtension> createPopupDocumentExtensions;

	private readonly IEnumerable<IDocumentCreateNotifierExtension> documentCreateNotifierExtensions;

	private readonly IEnumerable<IConvertDocumentUnconvertibleTypes> convertDocumentUnconvertibleTypes;

	public const string Area = "EleWise.ELMA.Documents.Web";

	public ReplacementTaskManager ReplacementTaskManager { get; set; }

	public DocumentVersionManager DocumentVersionManager { get; set; }

	public ICreateHistoryService CreateHistoryService { get; set; }

	public ICryptoContextAuthService CryptoDocumentService { get; set; }

	private static IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

	public DocumentManager DocumentManager { get; set; }

	public IEnumerable<IDocumentStorageSettingsBlockController> DocumentStorageSettingsBlocks { get; set; }

	public DocumentController(IMetadataRuntimeService metadataRuntimeService, IConvertProcessService convertProcessService, IEntityActionHandler entityActionHandler, DragAndDropSettingsBlock dragAndDropSettingsBlock, IConvertConflictFindingService convertConflictFindingService, ITemporaryAuthenticationService temporaryAuthenticationService, IEnumerable<ICreatePopupDocumentExtension> createPopupDocumentExtensions, IEnumerable<IDocumentCreateNotifierExtension> documentCreateNotifierExtensions, IEnumerable<IConvertDocumentUnconvertibleTypes> convertDocumentUnconvertibleTypes)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.convertProcessService = convertProcessService;
		this.entityActionHandler = entityActionHandler;
		this.dragAndDropSettingsBlock = dragAndDropSettingsBlock;
		this.convertConflictFindingService = convertConflictFindingService;
		this.createPopupDocumentExtensions = createPopupDocumentExtensions;
		this.temporaryAuthenticationService = temporaryAuthenticationService;
		this.documentCreateNotifierExtensions = documentCreateNotifierExtensions;
		this.convertDocumentUnconvertibleTypes = convertDocumentUnconvertibleTypes;
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, INotifier notifier)
	{
		return CreateDocumentInfo(uid, folderId, viewType, null, notifier);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess)
	{
		return CreateDocumentInfo(uid, folderId, viewType, null, notifier, disableProfileFolder, disableCreateAccess);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, INotifier notifier, bool disableProfileFolder)
	{
		return CreateDocumentInfo(uid, folderId, viewType, null, notifier, disableProfileFolder);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, string formId, INotifier notifier)
	{
		return CreateDocumentInfo(uid, folderId, viewType, formId, notifier, disableProfileFolder: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder)
	{
		return CreateDocumentInfo(uid, folderId, viewType, formId, notifier, disableProfileFolder, disableCreateAccess: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess)
	{
		return CreateDocumentInfo(uid, folderId, viewType, formId, notifier, disableProfileFolder, disableCreateAccess, disableDefaultFolder: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool disableDefaultFolder)
	{
		if (!uid.HasValue)
		{
			uid = InterfaceActivator.UID<IFile>();
		}
		return CreateDocumentInfo((IDocument)InterfaceActivator.Create(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid.Value)), folderId, viewType, formId, notifier, disableProfileFolder, disableCreateAccess, disableDefaultFolder);
	}

	[NotNull]
	private DocumentInfo CreateDocumentInfo(Guid? uid, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool popup, IDocument document = null)
	{
		if (document == null)
		{
			if (!uid.HasValue)
			{
				uid = InterfaceActivator.UID<IFile>();
			}
			document = (IDocument)InterfaceActivator.Create(metadataRuntimeService.GetTypeByUid(uid.Value));
			if (!((Controller)this).TryUpdateModel<IDocument>(document, "Entity"))
			{
				((Controller)this).get_ModelState().Clear();
			}
			if (popup)
			{
				foreach (ICreatePopupDocumentExtension createPopupDocumentExtension in createPopupDocumentExtensions)
				{
					createPopupDocumentExtension.Fill(document, ((Controller)this).get_Request(), ((Controller)this).get_Url());
				}
			}
		}
		return CreateDocumentInfo(document, folderId, viewType, formId, notifier);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, INotifier notifier)
	{
		return CreateDocumentInfo(model, folderId, viewType, null, notifier);
	}

	public static void InitDocumentInfo([NotNull] DocumentInfo info, long? folderId, INotifier notifier, bool disableProfileFolder)
	{
		InitDocumentInfo(info, folderId, notifier, disableProfileFolder, disableCreateAccess: false);
	}

	public static void InitDocumentInfo([NotNull] DocumentInfo info, long? folderId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess)
	{
		InitDocumentInfo(info, folderId, notifier, disableProfileFolder, disableCreateAccess, documentWasNull: true, disableDefaultFolder: false);
	}

	public static void InitDocumentInfo([NotNull] DocumentInfo info, long? folderId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool disableDefaultFolder)
	{
		InitDocumentInfo(info, folderId, notifier, disableProfileFolder, disableCreateAccess, documentWasNull: true, disableDefaultFolder);
	}

	private static void InitDocumentInfo([NotNull] DocumentInfo info, long? folderId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool documentWasNull, bool disableDefaultFolder)
	{
		Contract.CheckArgument(info != null && info.Entity != null, "info != null && info.Entity != null");
		InitDocumentResult initDocumentResult = info.Entity.InitDocument(info.ViewType, folderId, disableProfileFolder, disableCreateAccess, documentWasNull, disableDefaultFolder);
		info.Profile = initDocumentResult.Profile;
		info.RestrictChangeFolder = initDocumentResult.Profile != null && initDocumentResult.Profile.RestrictChangeFolder;
		info.AllowRename = initDocumentResult.Metadata != null && initDocumentResult.Metadata.IsAllowRename;
		info.Version = initDocumentResult.Version;
		info.MakeVersionCurrent = Locator.GetServiceNotNull<ICreateHistoryService>().GetStatus() == DocumentVersionStatus.Current;
		if (notifier != null)
		{
			initDocumentResult.Messages.ForEach(notifier.Warning);
		}
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, string formId, INotifier notifier)
	{
		return CreateDocumentInfo(model, folderId, viewType, formId, notifier, disableProfileFolder: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder)
	{
		return CreateDocumentInfo(model, folderId, viewType, formId, notifier, disableProfileFolder, disableCreateAccess: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess)
	{
		return CreateDocumentInfo(model, folderId, viewType, Guid.Empty, formId, notifier, disableProfileFolder, disableCreateAccess, documentWasNull: true, disableDefaultFolder: false);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool disableDefaultFolder)
	{
		return CreateDocumentInfo(model, folderId, viewType, Guid.Empty, formId, notifier, disableProfileFolder, disableCreateAccess, documentWasNull: true, disableDefaultFolder);
	}

	[NotNull]
	public static DocumentInfo CreateDocumentInfo(IDocument model, long? folderId, ViewType viewType, Guid formGuid, string formId, INotifier notifier, bool disableProfileFolder, bool disableCreateAccess, bool documentWasNull, bool disableDefaultFolder)
	{
		DocumentInfo documentInfo = new DocumentInfo(model, formGuid, formId, viewType);
		InitDocumentInfo(documentInfo, folderId, notifier, disableProfileFolder, disableCreateAccess, documentWasNull, disableDefaultFolder);
		return documentInfo;
	}

	public static IFolder ValidateFolder(IFolder folder, INotifier notifier = null)
	{
		Contract.ArgumentNotNull(folder, "folder");
		ValidateFolderResult validateFolderResult = folder.ValidateFolder();
		if (notifier != null)
		{
			validateFolderResult.Messages.ForEach(notifier.Warning);
		}
		return validateFolderResult.Folder;
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult StartConflictFindingProcess(ConvertDocModel model)
	{
		model = PrepareModelForMapping(model);
		string returnUrl = ((Controller)this).get_Url().ReturnUrl();
		if (model.SourceDocuments.Length == 0)
		{
			base.Notifier.Information(SR.T("Среди выбранных документов нет конвертируемых"));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Среди выбранных документов нет конвертируемых"),
				ReturnUrl = returnUrl
			});
		}
		Guid workId = convertConflictFindingService.StartConflictFindingProcess(model.SourceDocuments, model.DocTypeMappingInfos, model.TargetType.Uid);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			WorkId = workId,
			ReturnUrl = returnUrl
		});
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public JsonResult GetConvertionConflictProgressByUid(Guid convertionConflictPropgressUid)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ConflictFindingProgress conflictFindingProcessStatus = convertConflictFindingService.GetConflictFindingProcessStatus(convertionConflictPropgressUid);
		JsonResult val = new JsonResult();
		val.set_Data((object)new { conflictFindingProcessStatus.ConflictFindingState, conflictFindingProcessStatus.CurrentWorkDescription, conflictFindingProcessStatus.TotalPercentComplete, conflictFindingProcessStatus.TargetTypeUid });
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult ConvertDoc(Guid convertionConflictPropgressUid, string retUrl, string ids, Guid targetTypeUid)
	{
		ConflictFindingProgress conflictFindingProcessStatus = convertConflictFindingService.GetConflictFindingProcessStatus(convertionConflictPropgressUid);
		ConvertDocModel convertDocModel = new ConvertDocModel();
		convertDocModel.DocsStr = ids;
		convertDocModel.TargetType.Uid = targetTypeUid;
		convertDocModel.ReturnUrl = retUrl;
		convertDocModel = PrepareModelForMapping(convertDocModel);
		if (conflictFindingProcessStatus != null && conflictFindingProcessStatus.ConflictFindingState == ConflictFindingState.Finished)
		{
			List<ConflictConvertReferencesObject> retList = conflictFindingProcessStatus.RetList;
			ConvertDocConflictModel convertDocConflictModel = new ConvertDocConflictModel(retList);
			convertConflictFindingService.RemoveFindingConflictProgressFromDictionary(convertionConflictPropgressUid);
			if (retList.Count <= 0)
			{
				return (ActionResult)(object)((Controller)this).View((object)convertDocModel);
			}
			return (ActionResult)(object)((Controller)this).View("ConvertDocConflict", (object)convertDocConflictModel);
		}
		return (ActionResult)(object)((Controller)this).Redirect(retUrl);
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult GetConvertPopupContent(long[] documentIds, string returnUrl)
	{
		CheckDocumentAction(DocumentManager.Instance.FindByIdArray(documentIds).ToList(), DocumentActionProvider.DocumentConvertActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var checkedDocuments, out var messages);
		WriteErrorMessages(messages);
		ConvertDocModel convertDocModel = new ConvertDocModel(checkedDocuments.Select((IDocument d) => d.Id).ToArray());
		convertDocModel.ReturnUrl = returnUrl;
		return (ActionResult)(object)((Controller)this).PartialView("ConvertDocPopup", (object)convertDocModel);
	}

	private ConvertDocModel PrepareModelForMapping(ConvertDocModel model)
	{
		TypeInfo targetType = model.TargetType;
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(targetType.Uid);
		targetType.ImplementationUid = entityMetadata.ImplementationUid;
		targetType.Name = entityMetadata.Name;
		targetType.DisplayName = entityMetadata.DisplayName;
		model.TargetPropertiesInfos = PropertyInfo.GetPropertiesInfosForType(entityMetadata);
		List<DocTypeMappingInfo> list = new List<DocTypeMappingInfo>();
		List<DocumentInfo> source = model.SourceDocuments.Select((IDocument m) => new DocumentInfo(m, ViewType.Display)).ToList();
		List<Guid> newUids = (from w in source
			where w.IsConvertible()
			select w into m
			select m.Metadata.Uid).ToList();
		IDocument[] array2 = (model.SourceDocuments = model.SourceDocuments.Where((IDocument w) => newUids.Contains(w.TypeUid)).ToArray());
		IDocument[] sourceDocuments = model.SourceDocuments;
		for (int i = 0; i < sourceDocuments.Length; i++)
		{
			EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(sourceDocuments[i].TypeUid);
			new TypeInfo
			{
				Uid = entityMetadata2.Uid,
				ImplementationUid = entityMetadata2.ImplementationUid,
				DisplayName = entityMetadata2.DisplayName,
				Name = entityMetadata2.Name
			};
			DocTypeMappingInfo defaultMapping = DocTypeMappingInfo.GetDefaultMapping(entityMetadata2, entityMetadata);
			list.Add(defaultMapping);
		}
		model.DocTypeMappingInfos = list.ToArray();
		return model;
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult ShowPreConvertSummary(ConvertDocModel model)
	{
		try
		{
			DocTypeMappingInfo[] docTypeMappingInfos = model.DocTypeMappingInfos;
			foreach (DocTypeMappingInfo docTypeMappingInfo in docTypeMappingInfos)
			{
				DocTypeMappingInfo info = docTypeMappingInfo;
				docTypeMappingInfo.PropertyMappings.ForEach(delegate(PropertyMappingInfo a)
				{
					a.NewPropertyInfo.TargetTypeUid = model.TargetType.Uid;
					a.NewPropertyInfo.SetPropertyDisplayName();
					a.OldPropertyInfo.TargetTypeUid = info.SourceTypeInfo.Uid;
					a.OldPropertyInfo.SetPropertyDisplayName();
				});
			}
			return (ActionResult)(object)((Controller)this).PartialView("ConvertDocWizardStep3", (object)model);
		}
		catch (NullReferenceException)
		{
			throw new Exception(SR.T("При обработке документов возникла ошибка, попробуйте указать меньшее количество документов для конвертации."));
		}
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public JsonResult GetConvertionProgressByUid(Guid convertionPropgressUid)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ConvertionProgress convertionStatus = convertProcessService.GetConvertionStatus(convertionPropgressUid);
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			Progress = convertionStatus
		});
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return val;
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult StartConvertProcess(ConvertDocModel model)
	{
		DocTypeMappingInfo[] mappings = model.SourceDocuments.Select((IDocument a) => model.DocTypeMappingInfos.FirstOrDefault((DocTypeMappingInfo m) => m.SourceTypeInfo.Uid == a.TypeUid)).ToArray();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (IConvertDocumentWebExtension extensionPoint in ComponentManager.Current.GetExtensionPoints<IConvertDocumentWebExtension>())
		{
			object obj = extensionPoint.CreateModel();
			((Controller)this).TryUpdateModel<object>(obj);
			extensionPoint.SetValue(dictionary, obj);
		}
		Guid workId = Locator.GetServiceNotNull<IConvertProcessService>().StartConvertProcess(model.SourceDocuments, mappings, model.TargetType.Uid, dictionary);
		string returnUrl = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			WorkId = workId,
			ReturnUrl = returnUrl
		}, "text/plain");
	}

	[Permission("E34A2AAF-084D-4517-A95E-169B7C80D34D")]
	public ActionResult GetFieldsForMapping(Guid oldTypeUid, Guid newTypeUid, Guid newPropUid, Guid oldParentBlockUid, bool isBlock)
	{
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		EntityMetadata obj = (EntityMetadata)MetadataLoader.LoadMetadata(oldTypeUid);
		EntityMetadata obj2 = (EntityMetadata)MetadataLoader.LoadMetadata(newTypeUid);
		PropertyInfo[] childPropsAndBlocks = PropertyInfo.GetChildPropsAndBlocks(obj2, obj2.Uid, 0, new Guid[0], string.Empty);
		PropertyInfo[] childPropsAndBlocks2 = PropertyInfo.GetChildPropsAndBlocks(obj, obj.Uid, 0, new Guid[0], string.Empty);
		List<PropertyInfo> list = new List<PropertyInfo>();
		if (isBlock)
		{
			list.AddRange(childPropsAndBlocks2.Where((PropertyInfo p) => p.IsBlock && p.ParentBlockUid == oldParentBlockUid));
		}
		else
		{
			PropertyInfo targetPropInfo = childPropsAndBlocks.FirstOrDefault((PropertyInfo p) => !p.IsBlock && p.Uid == newPropUid);
			if (targetPropInfo.SubTypeUid == Guid.Empty)
			{
				IEnumerable<ITypeConvertor> extensionPoints = ComponentManager.Current.GetExtensionPoints<ITypeConvertor>();
				ITypeConvertor allowedConvertor = extensionPoints.FirstOrDefault((ITypeConvertor c) => c.TargetTypeUids.Contains(targetPropInfo.TypeUid));
				if (allowedConvertor != null)
				{
					list.AddRange(childPropsAndBlocks2.Where((PropertyInfo p) => allowedConvertor.SourceTypeUids.Contains(p.TypeUid) && p.ParentBlockUid == oldParentBlockUid));
				}
			}
			else
			{
				IMetadata metadata = MetadataLoader.LoadMetadata(targetPropInfo.SubTypeUid);
				List<Guid> childSubTypes = new List<Guid>();
				if (metadata is EntityMetadata)
				{
					EntityMetadata entityMetadata = (EntityMetadata)metadata;
					childSubTypes = MetadataLoader.GetChildClasses(entityMetadata).OfType<EntityMetadata>().SelectMany((EntityMetadata p) => new List<Guid> { p.Uid, p.ImplementationUid })
						.ToList();
					childSubTypes.Add(entityMetadata.Uid);
					childSubTypes.Add(entityMetadata.ImplementationUid);
				}
				else if (metadata is EnumMetadata)
				{
					EnumMetadata enumMetadata = (EnumMetadata)metadata;
					childSubTypes.Add(enumMetadata.Uid);
				}
				list.AddRange(childPropsAndBlocks2.Where((PropertyInfo p) => p.ParentBlockUid == oldParentBlockUid && childSubTypes.Contains(p.SubTypeUid) && IsPropertiesConvertible(p, targetPropInfo)));
			}
		}
		JsonResult val = new JsonResult();
		val.set_Data((object)list.Select((PropertyInfo u) => new
		{
			Value = u.Uid,
			Text = u.DisplayName,
			DropDownText = u.DisplayName,
			ViewText = u.DisplayName,
			Html = u.DisplayName + "<span style=\"padding-left:10px;\" class=\"comment3\">" + u.TypeDisplayName + "</span>"
		}).ToList());
		return (ActionResult)val;
	}

	private bool IsPropertiesConvertible(PropertyInfo sourceProp, PropertyInfo targetProp)
	{
		List<RelationType> list = new List<RelationType>
		{
			RelationType.ManyToMany,
			RelationType.ManyToManyInverse,
			RelationType.OneToMany
		};
		if (sourceProp.RelationType != targetProp.RelationType)
		{
			if (list.Contains(sourceProp.RelationType))
			{
				return list.Contains(targetProp.RelationType);
			}
			return false;
		}
		return true;
	}

	public ActionResult Create(Guid? uid, long? folderId, long? linkedDocument, string parameters, Dictionary<string, string> entity = null)
	{
		DocumentInfo documentInfo = CreateDocumentInfo(uid, folderId, ViewType.Create, null, base.Notifier, disableProfileFolder: false, disableCreateAccess: false, disableDefaultFolder: false);
		documentInfo.InitFolderId = folderId;
		if (entity != null)
		{
			new EntityJsonSerializer().ConvertFromSerializable(documentInfo.Entity, entity);
		}
		documentInfo.LinkedDocument = linkedDocument;
		documentInfo.Parameters = parameters;
		TemporaryAuthenticationInfo fromContext = temporaryAuthenticationService.GetFromContext(((Controller)this).get_HttpContext());
		if (fromContext != null)
		{
			fromContext.ApplyTemplate(documentInfo.Entity);
			if (((IEnumerable<IDocumentVersion>)documentInfo.Entity.Versions).Any())
			{
				documentInfo.Version = ((IEnumerable<IDocumentVersion>)documentInfo.Entity.Versions).FirstOrDefault();
			}
		}
		documentInfo.DynamicFormSettings.ModelJsonState = DynamicFormHelper.ModelJsonState(documentInfo.Entity);
		return (ActionResult)(object)((Controller)this).View((object)documentInfo);
	}

	[HttpGet]
	public ActionResult EditForm(Guid? uid, long? folderId)
	{
		DocumentInfo documentInfo = CreateDocumentInfo(uid, folderId, ViewType.Edit, base.Notifier);
		return (ActionResult)(object)((Controller)this).PartialView((object)documentInfo);
	}

	public static void InitVersion(DocumentInfo doc)
	{
		if (doc.Version != null)
		{
			bool flag = WebDocumentManager.Instance.IsWebDocument(doc.Entity);
			bool num = UseTemplate(doc);
			if (!num && !flag)
			{
				doc.Version.Content = null;
			}
			if (num)
			{
				CreateDocumentByTemplate(doc);
			}
			else
				_ = 0;
			if ((!flag && doc.Version.File != null && doc.Version.Content == null) || (flag && doc.Version.Content != null))
			{
				DocumentManager.Instance.InitNew(doc.Entity, doc.Version, doc.MakeVersionCurrent);
			}
		}
	}

	public static void SaveDocumentFromView(DocumentInfo doc, bool generateName = true, bool initVersion = true)
	{
		IEntityManager entityManager = ModelHelper.GetEntityManager(doc.Entity.GetType());
		if (doc.CopyPermissionFromParent && doc.ParentDocument.HasValue)
		{
			IDocument source = DocumentManager.Instance.Load(doc.ParentDocument.Value);
			DocumentManager.Instance.CopyPermission(source, doc.Entity);
		}
		if (generateName)
		{
			doc.Entity.Name = DocumentManager.Instance.GenerateName(doc.Entity, (doc.Version != null && doc.Version.File != null) ? doc.Version.File.Name : ((UseTemplate(doc) && doc.Entity.Template != null) ? doc.Entity.Template.GetName() : ""));
		}
		if (initVersion)
		{
			InitVersion(doc);
		}
		entityManager.Save(doc.Entity);
		if (doc.LinkedDocument.HasValue && doc.LinkedDocument.Value > 0)
		{
			IDocument document = DocumentManager.Instance.Load(doc.LinkedDocument.Value);
			InstanceOf<IDocumentLink> instanceOf = new InstanceOf<IDocumentLink>();
			instanceOf.New.Document = document;
			instanceOf.New.LinkedDocument = doc.Entity;
			instanceOf.New.Save();
		}
		ICreateHistoryService service = Locator.GetService<ICreateHistoryService>();
		if (service != null)
		{
			service.Add(doc.Metadata);
			service.SetStatus(doc.MakeVersionCurrent ? DocumentVersionStatus.Current : DocumentVersionStatus.Draft);
		}
		LastObjectInfoManager.Instance.AddInfo(new ReferenceOnEntity
		{
			ObjectTypeUId = InterfaceActivator.UID<IDocument>(),
			ObjectId = doc.Entity.Id
		});
	}

	public static bool UseTemplate(DocumentInfo doc)
	{
		if (doc.Profile != null)
		{
			return !doc.UseFile;
		}
		return false;
	}

	public static bool CreateDocumentByTemplate(DocumentInfo doc)
	{
		int num;
		if (doc.Profile != null && !doc.UseFile)
		{
			num = ((doc.Entity.Template != null) ? 1 : 0);
			if (num != 0)
			{
				if (!WebDocumentManager.Instance.IsWebDocument(doc.Entity))
				{
					doc.Version.File = ExecuteTemplate(doc.Entity, doc.Entity.Template);
					return (byte)num != 0;
				}
				doc.Version.Content = new HtmlString(ExecuteTemplateToString(doc.Entity, doc.Entity.Template));
			}
		}
		else
		{
			num = 0;
		}
		return (byte)num != 0;
	}

	public static BinaryFile ExecuteTemplate(IDocument doc, IDocumentTemplate template)
	{
		BinaryFile file = GetFile(template);
		BinaryFile binaryFile = Locator.GetServiceNotNull<DocumentGeneratorManager>().GenerateToBinaryFile(file, doc);
		Locator.GetServiceNotNull<IFileManager>().SaveFile(binaryFile);
		return binaryFile;
	}

	public static string ExecuteTemplateToString(IDocument doc, IDocumentTemplate template)
	{
		if (template.Document != null)
		{
			if (template.Document.CurrentVersion == null)
			{
				return string.Empty;
			}
			if (WebDocumentManager.Instance.IsWebDocument(template.Document.TypeUid))
			{
				if (template.Document.CurrentVersion.Content != null)
				{
					string text = template.Document.CurrentVersion.Content.ToString();
					if (string.IsNullOrEmpty(text))
					{
						return string.Empty;
					}
					return new TextTemplateGenerator(text).Generate(doc);
				}
			}
			else if (template.Document.CurrentVersion.File != null)
			{
				return GenerateContentFromFile(template.Document.CurrentVersion.File, doc);
			}
		}
		else if (template.File != null)
		{
			try
			{
				return GenerateContentFromFile(template.File, doc);
			}
			catch (Exception ex)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
				return string.Empty;
			}
		}
		return string.Empty;
	}

	private static string GenerateContentFromFile(BinaryFile templateFile, IDocument doc)
	{
		BinaryFile file = Locator.GetServiceNotNull<DocumentGeneratorManager>().GenerateToBinaryFile(templateFile, doc);
		return WebDocumentManager.Instance.GetContentFromFile(file);
	}

	private static BinaryFile GetFile(IDocumentTemplate template)
	{
		if (template.Document != null)
		{
			BinaryFile fileByDocumentId = Locator.GetServiceNotNull<IDocumentFileManager>().GetFileByDocumentId(template.Document.Id);
			if (fileByDocumentId == null)
			{
				throw new ObjectNotFoundException(SR.T("Текущая версия"), SR.T("Не найдена текущая версия в документе \"{0}\"(id={1})", template.Document.Name, template.Document.Id));
			}
			return fileByDocumentId;
		}
		return Locator.GetServiceNotNull<ITemplateFileManager>().CreateFromTemplate(template.File.Id);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult DragDropCreate(XhrPostedFile file)
	{
		string value = ((Controller)this).get_Request().Headers["folderId"];
		IFolder folder;
		if (string.IsNullOrEmpty(value))
		{
			IFolder myDocumentFolderForCurrentUser = base.SystemFoldersService.GetMyDocumentFolderForCurrentUser();
			folder = myDocumentFolderForCurrentUser;
		}
		else
		{
			folder = FolderManager.Instance.Load(Convert.ToInt64(value));
		}
		IFolder folder2 = folder;
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentCreatePermission, folder2) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, folder2))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Недостаточно прав для создания документа в данной папке")
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
		DragAndDropSettingsBlock dragAndDropSettingsBlock = this.dragAndDropSettingsBlock;
		Type typeByUid = metadataRuntimeService.GetTypeByUid(dragAndDropSettingsBlock.Settings.DocumentType);
		object obj = null;
		if (dragAndDropSettingsBlock.Settings.DoubleNameAction == DoubleNameActionType.ExistDocument || dragAndDropSettingsBlock.Settings.DoubleNameAction == DoubleNameActionType.AnotherName)
		{
			string arg = Path.GetFileNameWithoutExtension(binaryFile.Name.ReplaceInvalidFileNameChars());
			if (dragAndDropSettingsBlock.Settings.UseCustomTemplate)
			{
				IDocument document = (IDocument)InterfaceActivator.Create(metadataRuntimeService.GetTypeByUid(dragAndDropSettingsBlock.Settings.DocumentType));
				TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator(dragAndDropSettingsBlock.Settings.TemplateName);
				DocumentGenerateNameModel dataSourceObject = new DocumentGenerateNameModel(document)
				{
					FileName = binaryFile.Name
				};
				arg = textTemplateGenerator.Generate(dataSourceObject);
			}
			DocumentManager instance = DocumentManager.Instance;
			InstanceOf<IDocumentFilter> instanceOf = new InstanceOf<IDocumentFilter>();
			instanceOf.New.Query = $"Folder={folder2.Id} and (Name='{arg}' or Name='{binaryFile.Name}')";
			IDocument document2 = instance.Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault();
			if (document2 != null)
			{
				if (dragAndDropSettingsBlock.Settings.DoubleNameAction == DoubleNameActionType.ExistDocument)
				{
					AddDocumentVersionResult addDocumentVersionResult;
					try
					{
						addDocumentVersionResult = DocumentVersionManager.AddVersionAndFlush(document2, binaryFile);
					}
					catch (EncryptDocumentException)
					{
						return (ActionResult)(object)((Controller)this).Json((object)new
						{
							error = SR.T("Не задан пароль для шифрования документа. Вы можете зайти в документ и создать версию обычным способом или путем перетаскивания файла на карточку документа.")
						}, (JsonRequestBehavior)0);
					}
					if (!addDocumentVersionResult.IsWebDocument)
					{
						obj = new
						{
							filename = binaryFile.Name,
							versionId = addDocumentVersionResult.NewDocumentVersion.Id
						};
					}
				}
				else
				{
					DocumentManager.Instance.CreateDocument(typeByUid, binaryFile, folder2, dragAndDropSettingsBlock.Settings.UseCustomTemplate ? dragAndDropSettingsBlock.Settings.TemplateName : null, out var document3);
					obj = new
					{
						createdDocument = document3.Id
					};
				}
			}
			else
			{
				DocumentManager.Instance.CreateDocument(typeByUid, binaryFile, folder2, dragAndDropSettingsBlock.Settings.UseCustomTemplate ? dragAndDropSettingsBlock.Settings.TemplateName : null);
			}
		}
		else
		{
			DocumentManager.Instance.CreateDocument(typeByUid, binaryFile, folder2, dragAndDropSettingsBlock.Settings.UseCustomTemplate ? dragAndDropSettingsBlock.Settings.TemplateName : null);
		}
		if (obj != null)
		{
			return (ActionResult)(object)((Controller)this).Json(obj, (JsonRequestBehavior)0);
		}
		return SuccessJson();
	}

	public ActionResult UploadFinishedVersions(long[] versions, string popupId, bool? hideDocuments = false, bool? selectOne = false)
	{
		UploadFinishedInfo uploadFinishedInfo = new UploadFinishedInfo
		{
			AddedVersions = DocumentVersionManager.FindByIdArray(versions).ToList(),
			HideDocuments = (hideDocuments.HasValue && hideDocuments.Value),
			PopupId = popupId,
			SelectOne = (selectOne.HasValue && selectOne.Value)
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)uploadFinishedInfo);
	}

	public ActionResult UploadFinishedDocuments(long[] documents, string popupId)
	{
		((Controller)this).get_ModelState().Clear();
		UploadFinishedInfo uploadFinishedInfo = new UploadFinishedInfo
		{
			Documents = documents.Select(delegate(long v)
			{
				IDocument document = DocumentManager.Instance.Load(v);
				return new RenameDocumentnfo
				{
					Document = document,
					Name = document.Name,
					Version = ((IEnumerable<IDocumentVersion>)document.Versions).FirstOrDefault(),
					Index = Array.IndexOf(documents, v)
				};
			}).ToList(),
			PopupId = popupId
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)uploadFinishedInfo);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult RenameDocuments(UploadFinishedInfo info)
	{
		if (info.Documents != null)
		{
			info.Documents.ForEach(delegate(RenameDocumentnfo d)
			{
				d.Document.Name = d.Name;
				d.Document.Save();
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult CreatePopupSimple(Guid? uid, string popupId, string callback, long? folderId = null, bool? restrictChangeFolder = null, bool needButtons = true, string prefix = null, long? parentDocument = null)
	{
		return CreatePopup(null, uid, popupId, callback, folderId, restrictChangeFolder, needButtons, prefix, parentDocument);
	}

	[EntityForm("Create", "EleWise.ELMA.Documents.Web")]
	public ActionResult CreatePopup([ParameterContainer] IDocument document, Guid? uid, string popupId, string callback, long? folderId = null, bool? restrictChangeFolder = null, bool needButtons = true, string prefix = null, long? parentDocument = null, Guid? formUid = null, ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
	{
		if (document != null && document.Encrypt)
		{
			throw new NotSupportedException(SR.T("Открытие зашифрованного документа в всплывающем окне временно недоступно"));
		}
		if (string.IsNullOrEmpty(formId))
		{
			formId = $"Form{prefix}";
		}
		ViewType viewType2 = (ViewType)(((int?)viewType) ?? (formReadOnly ? 4 : ((document == null) ? 1 : 2)));
		DocumentInfo documentInfo = CreateDocumentInfo(uid, folderId, viewType2, formId, base.Notifier, folderId.HasValue && restrictChangeFolder.HasValue, disableCreateAccess: false, popup: true, document);
		documentInfo.FormReadOnly = formReadOnly;
		documentInfo.FormUid = formUid;
		documentInfo.InitFolderId = folderId;
		if (folderId.HasValue && restrictChangeFolder.HasValue)
		{
			documentInfo.RestrictChangeFolder = restrictChangeFolder.Value;
		}
		documentInfo.PopupId = popupId;
		documentInfo.Callback = callback;
		documentInfo.ParentDocument = parentDocument;
		documentInfo.DynamicFormSettings.ParentFormId = parentFormId;
		DynamicFormSettings dynamicFormSettings = documentInfo.DynamicFormSettings;
		dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + documentInfo.View.Uid;
		return (ActionResult)(object)((Controller)this).PartialView(needButtons ? "Document/DocumentPopup" : "Document/EditForm", (object)documentInfo);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Create(DocumentInfo doc)
	{
		bool flag = !string.IsNullOrEmpty(doc.PopupId) || IsCreatorRequest();
		InitParentFolder(doc, base.Notifier, flag);
		try
		{
			if (!doc.Entity.IsNew())
			{
				EntityActionEventArgs e = new EntityActionEventArgs(null, doc.Entity, DmsObjectActions.EditGuid);
				entityActionHandler.ActionExecuted(e);
			}
			((ICollection<IDocumentVersion>)doc.Entity.Versions).Clear();
			SaveDocumentFromView(doc);
			if (IsCustomViewRequest())
			{
				return HandleCustomViewJsonCallback(doc.Entity);
			}
			if (flag)
			{
				return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).Json((object)true, "text/plain")) : ((object)CreatorJson(doc.Entity)));
			}
			foreach (IDocumentCreateNotifierExtension documentCreateNotifierExtension in documentCreateNotifierExtensions)
			{
				documentCreateNotifierExtension.Notifier(this, doc);
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = doc.Entity.Id
			});
		}
		catch (Exception ex)
		{
			base.UnitOfWorkManager.RollbackCurrent("");
			if (flag)
			{
				return (ActionResult)((!IsCreatorRequest()) ? ((object)((Controller)this).Json((object)false, "text/plain")) : ((object)CreatorJson(null, ex.Message)));
			}
			FormNotifierExtensions.Error(base.Notifier, ex);
			doc.ViewType = ViewType.Create;
			FormViewItem originalItem = ClassSerializationHelper.CloneObjectByXml(doc.View);
			string text = ((Controller)this).get_Request().Form["__DynamicFormSettings.ViewTransformationJson"];
			ViewItemTransformation viewItemTransformation = ((!string.IsNullOrEmpty(text)) ? ViewItemTransformation.DeserializeFromJson(text) : null);
			viewItemTransformation?.Apply(doc.View);
			if (((Controller)this).get_Request().Form.GetValues("__DynamicFormSettings.ViewTransformationAdditionalJson").Count() == 1)
			{
				text = ((Controller)this).get_Request().Form["__DynamicFormSettings.ViewTransformationAdditionalJson"];
				viewItemTransformation = ((!string.IsNullOrEmpty(text)) ? ViewItemTransformation.DeserializeFromJson(text) : null);
			}
			viewItemTransformation?.Apply(doc.View);
			doc.DynamicFormSettings.ViewTransformation = doc.View.CreateTransformation(originalItem);
			doc.DynamicFormSettings.ModelJsonState = DynamicFormHelper.ModelJsonState(doc.Entity);
			return (ActionResult)(object)((Controller)this).View((object)doc);
		}
	}

	public static void InitParentFolder(DocumentInfo doc, INotifier notifier, bool isAjax)
	{
		if (doc.Entity.Folder == null)
		{
			IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(doc.Metadata.ImplementationUid);
			if (documentMetadataProfile != null && documentMetadataProfile.Folder != null)
			{
				doc.Entity.Folder = documentMetadataProfile.Folder;
			}
			else
			{
				doc.Entity.Folder = Locator.GetServiceNotNull<SystemFoldersService>().GetMyDocumentFolderForCurrentUser();
				if (!isAjax)
				{
					notifier.Warning(SR.T("Родительская папка не была выбрана, для документа установлена папка - {0}", doc.Entity.Folder.Name.HtmlEncode()));
				}
			}
		}
		doc.Entity.Folder = ValidateFolder(doc.Entity.Folder, notifier);
	}

	[HttpGet]
	public ActionResult Copy(long id, string popupId)
	{
		IDocument document = base.Manager.Load(id).CastAsRealType();
		if (!CheckDocumentAction(document, DocumentActionProvider.DocumentCopyActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var _))
		{
			throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentCopyActionUID);
		}
		document = CheckIsCrypt(document);
		DocumentInfo documentInfo = CreateDocumentInfo(DocumentManager.Instance.Copy(document, inheritPermissionsParentFolder: false), null, ViewType.Create, base.Notifier);
		return (ActionResult)(object)((Controller)this).View("Create", (object)documentInfo);
	}

	[HttpPost]
	public ActionResult Copy(DocumentInfo doc)
	{
		((ICollection<IDocumentVersion>)doc.Entity.Versions).Clear();
		SaveDocumentFromView(doc);
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = doc.Entity.Id
		});
	}

	public ActionResult DownloadCurrentVersion(IDocument document)
	{
		if (document == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, document))
		{
			throw new SecurityException(SR.T("Нет прав на чтение документа"));
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentLoadPermission, document))
		{
			throw new SecurityException(SR.T("Нет прав на загрузку документа"));
		}
		List<IDocumentVersion> list = DocumentVersionManager.Find((IDocumentVersion v) => v.Document == document && (int)v.Status == 2).ToList();
		if (list.Count == 1)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Download", "BinaryFiles", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = list.First().File.Uid
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = document.Id,
			selectedTab = "Versions"
		});
	}

	public ActionResult List(long? folderId)
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpGet]
	public ActionResult TypeSelector(long? folderId, long? linkedDocument, string PopupId, string parameters)
	{
		TypeSelectorModel typeSelectorModel = new TypeSelectorModel
		{
			FolderId = folderId,
			LinkedDocument = linkedDocument,
			PopupId = PopupId,
			Parameters = parameters
		};
		return (ActionResult)(object)((Controller)this).PartialView("TypeSelector", (object)typeSelectorModel);
	}

	[HttpPost]
	public ActionResult TypeSelector(TypeSelectorModel model)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "uid", model.Uid },
			{ "folderId", model.FolderId },
			{ "linkedDocument", model.LinkedDocument },
			{ "parameters", model.Parameters }
		};
		if ((((Controller)this).get_Request().QueryString["interface"] ?? string.Empty).Contains("lite"))
		{
			((Controller)this).get_HttpContext().Response.AppendHeader("CloseAfterPost", "false");
			routeValueDictionary.Add("interface", "lite");
			if ("portal".Equals(((Controller)this).get_Request().QueryString["litemode"] ?? string.Empty))
			{
				routeValueDictionary.Add("litemode", "portal");
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "Document", routeValueDictionary);
	}

	public ActionResult TypeSelectorWindow(long? folderId, long? linkedDocument, string PopupId, string parameters)
	{
		TypeSelectorModel typeSelectorModel = new TypeSelectorModel
		{
			FolderId = folderId,
			LinkedDocument = linkedDocument,
			PopupId = PopupId,
			Parameters = parameters
		};
		return (ActionResult)(object)((Controller)this).PartialView("TypeSelectorWindow", (object)typeSelectorModel);
	}

	public ActionResult GetDocumentTypes(string text = "", bool forCreate = true, bool forConvert = false, bool loadImplementation = true, Guid? parentTypeUid = null)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		List<DocumentMetadata> list = new List<DocumentMetadata>();
		SelectList val = null;
		if (forConvert)
		{
			List<Guid> unconvertibleTypesUids = convertDocumentUnconvertibleTypes.SelectMany((IConvertDocumentUnconvertibleTypes m) => m.GetUnconvertibleTypesUids()).ToList();
			list = (from w in DocumentMetadataProfileManager.Instance.CreateableDocumentTypes(text, null, disabledInWeb: false)
				where !unconvertibleTypesUids.Contains(w.Uid)
				select w).ToList();
			val = new SelectList((IEnumerable)(from u in list
				select new
				{
					id = (loadImplementation ? u.Uid : u.ImplementationUid),
					text = u.DisplayName
				} into t
				orderby t.text
				select t).ToList(), "id", "text");
		}
		else if (forCreate)
		{
			list = DocumentMetadataProfileManager.Instance.CreateableDocumentTypes(text, null, disabledInWeb: false).ToList();
			val = new SelectList((IEnumerable)(from u in list
				select new
				{
					id = (loadImplementation ? u.Uid : u.ImplementationUid),
					text = u.DisplayName
				} into t
				orderby t.text
				select t).ToList(), "id", "text");
		}
		else
		{
			list = (from m in DocumentMetadataHeadManager.Instance.PublishedHeads()
				select (DocumentMetadata)MetadataLoader.LoadMetadata(m.DocumentTypeUid, inherit: true, loadImplementation) into dm
				where string.IsNullOrEmpty(text) || dm.DisplayName.ToUpper().Contains(text.ToUpper())
				select dm).ToList();
			if (parentTypeUid.HasValue)
			{
				EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(parentTypeUid.Value) as EntityMetadata;
				List<ClassMetadata> childs = MetadataLoader.GetChildClasses(entityMetadata);
				childs.Add(entityMetadata);
				list = list.Where((DocumentMetadata dm) => childs.Any((ClassMetadata c) => c.Uid == (loadImplementation ? dm.Uid : dm.ImplementationUid))).ToList();
			}
			val = new SelectList((IEnumerable)(from u in list
				select new
				{
					id = (loadImplementation ? u.Uid : u.ImplementationUid),
					text = u.DisplayName
				} into t
				orderby t.text
				select t).ToList(), "id", "text");
		}
		JsonResult val2 = new JsonResult();
		val2.set_Data((object)val);
		return (ActionResult)val2;
	}

	public ActionResult GetCycleStatus(string text = "", List<Guid> typesUid = null)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Expected O, but got Unknown
		List<ReferenceOnEntityType> documentsTypes = null;
		if (typesUid != null)
		{
			List<Guid> list = typesUid.Where((Guid t) => t != Guid.Empty).ToList();
			if (list.Count > 0)
			{
				documentsTypes = list.Select(delegate(Guid t)
				{
					EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(t);
					return new ReferenceOnEntityType
					{
						TypeUid = entityMetadata.ImplementationUid
					};
				}).ToList();
			}
		}
		List<ILifeCycleStatus> statusesByTypes = LifeCycleStatusManager.Instance.GetStatusesByTypes(text, documentsTypes);
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)statusesByTypes.Select((ILifeCycleStatus u) => new
		{
			id = u.Id,
			text = u.Name
		}).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	public static DocumentInfo CreateDocumentInfo(long id, ViewType viewType, bool audit = false)
	{
		IDocument document = DocumentManager.Instance.Load(id).CastAsRealType();
		if (audit)
		{
			DocumentManager.Instance.AuditBrowse(document);
		}
		DocumentInfo documentInfo = new DocumentInfo(document, viewType);
		if (WebDocumentManager.Instance.IsWebDocument(document))
		{
			documentInfo.Version = document.CurrentVersion;
		}
		documentInfo.InFavorites = FavoritesFolderManager.Instance.IsInFavorites(id);
		documentInfo.Entity = CheckIsCrypt(document);
		return documentInfo;
	}

	[EntityLink]
	public ActionResult View(long id, string selectedTab, string seletedTab, Guid? viewMode = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)(selectedTab ?? seletedTab));
		DocumentInfo documentInfo = CreateDocumentInfo(id, ViewType.Display, audit: true);
		if (viewMode.HasValue)
		{
			documentInfo.CurrentViewProvider = viewMode.Value;
		}
		return (ActionResult)(object)((Controller)this).View((object)documentInfo);
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, Guid? viewMode = null, Guid? formUid = null)
	{
		DocumentInfo documentInfo = CreateDocumentInfo(id, ViewType.Display);
		documentInfo.FormUid = formUid;
		if (viewMode.HasValue)
		{
			documentInfo.CurrentViewProvider = viewMode.Value;
		}
		return AsyncViewItemView(documentInfo.View, ViewType.Display, viewItemUid, documentInfo, documentInfo.Entity, $"Entity_{documentInfo.Entity.Id}", ItemType.Default, DocumentObjectViewItemProvider.UID, EntityObjectViewItemProvider.CreateViewItemId(documentInfo.Entity, documentInfo.ViewType, ItemType.Default));
	}

	[HttpGet]
	[InNewNHSession]
	public ActionResult TabView(long id, string selectedTab, string seletedTab, bool? withDocumentHeader = false)
	{
		((ControllerBase)this).get_ViewData().set_Item("SelectedTab", (object)(selectedTab ?? seletedTab));
		((ControllerBase)this).get_ViewData().set_Item("WithDocumentHeader", (object)withDocumentHeader);
		((ControllerBase)this).get_ViewData().set_Item("WithDocumentHeader", (object)withDocumentHeader);
		IDocument document = base.Manager.Load(id);
		document = CheckIsCrypt(document);
		return (ActionResult)(object)((Controller)this).PartialView("Document/TabView", (object)document);
	}

	public ActionResult Edit(long id, long? versionId = null, Guid? viewMode = null)
	{
		IDocument document = base.Manager.Load(id).CastAsRealType();
		CheckPermission(PermissionProvider.DocumentEditPermission, document);
		if (!CheckDocumentAction(document, DocumentActionProvider.DocumentEditActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var _))
		{
			throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentEditActionUID);
		}
		document = CheckIsCrypt(document);
		DocumentMetadata metadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.GetType());
		DocumentInfo documentInfo = new DocumentInfo(document, ViewType.Edit);
		if (WebDocumentManager.Instance.IsWebDocument(document))
		{
			DocumentInfo documentInfo2 = documentInfo;
			InstanceOf<IDocumentVersion> instanceOf = new InstanceOf<IDocumentVersion>();
			instanceOf.New.Content = ((document.CurrentVersion != null) ? document.CurrentVersion.Content : null);
			instanceOf.New.Document = document;
			documentInfo2.Version = instanceOf.New;
			documentInfo.AllowRename = metadata.IsAllowRename;
		}
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			documentInfo.Profile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(metadata.ImplementationUid);
		});
		documentInfo.CurrentViewProvider = (viewMode.HasValue ? viewMode.Value : Guid.Empty);
		return (ActionResult)(object)((Controller)this).View((object)documentInfo);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Edit(DocumentInfo model)
	{
		bool encrypt = model.Entity.Encrypt;
		CheckPermission(PermissionProvider.DocumentEditPermission, model.Entity);
		if (model.Entity.IsArchived.HasValue && model.Entity.IsArchived.Value)
		{
			base.Notifier.Error(SR.T("Документ \"{0}\" находится в архиве и не может быть изменен.", model.Entity.Name));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = model.Entity.Id
			});
		}
		if (model.Version != null && model.Version.IsNew())
		{
			bool flag = true;
			if (model.IsWebDocument)
			{
				IDocumentVersion currentVersion = model.Entity.CurrentVersion;
				if (currentVersion != null && currentVersion.Content != null && model.Version.Content != null)
				{
					flag = !currentVersion.Content.ToString().Equals(model.Version.Content.ToString());
					if (flag && model.SaveToCurrentVersion)
					{
						flag = false;
						currentVersion.Content = model.Version.Content;
					}
				}
			}
			if (flag)
			{
				model.Version.Document = model.Entity;
				model.Version.Status = DocumentVersionStatus.Current;
				model.Entity.Versions.Add(model.Version);
			}
		}
		if (encrypt)
		{
			DocumentManager.Instance.UpdateEncryptedProperties(model.Entity, model.DecryptPassword);
		}
		DocumentManager.Instance.EditSave(model.Entity);
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{
				"id",
				model.Entity.Id
			}
		};
		if (model.CurrentViewProvider != Guid.Empty)
		{
			routeValueDictionary.Add("viewMode", model.CurrentViewProvider);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", routeValueDictionary);
	}

	[HttpPost]
	public ActionResult AddComment(CommentWithAttachments model)
	{
		IDocument document = base.Manager.Load(model.ObjectId);
		if (model.ActionModel.Comment != null)
		{
			model.ActionModel.Comment.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
			document.Comments.Add(model.ActionModel.Comment);
		}
		base.Manager.Save(document);
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.ObjectId,
			selectedTab = "Comments"
		});
	}

	public ActionResult OpenAttachmentLoaderPopup(Guid typeUid, string prefix, string attachmentContainerId, string zoneId)
	{
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		((ControllerBase)this).get_ViewData().set_Item("CreatorRequest", (object)true.ToString());
		((ControllerBase)this).get_ViewData().set_Item("CreatorPrefix", (object)prefix);
		CommentAttachmentLoader commentAttachmentLoader = new CommentAttachmentLoader
		{
			AttachmentContainerId = attachmentContainerId,
			ZoneId = zoneId,
			ActionModel = InterfaceActivator.Create<ICommentActionModel>()
		};
		return (ActionResult)(object)((Controller)this).PartialView("AttachmentActionModelLoader", (object)commentAttachmentLoader);
	}

	public ActionResult Versions(long documentId)
	{
		IDocument document = base.Manager.Load(documentId);
		return (ActionResult)(object)((Controller)this).PartialView((object)document);
	}

	public ActionResult Links(long documentId)
	{
		IDocument document = base.Manager.Load(documentId);
		return (ActionResult)(object)((Controller)this).PartialView((object)document);
	}

	public ActionResult Comments(long documentId)
	{
		IDocument document = base.Manager.Load(documentId);
		return (ActionResult)(object)((Controller)this).PartialView((object)document);
	}

	public ActionResult Questions(long documentId)
	{
		IDocument document = base.Manager.Load(documentId);
		return (ActionResult)(object)((Controller)this).PartialView((object)document);
	}

	public ActionResult DocumentsSearch()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult PublishWebDocument(DocumentInfo doc)
	{
		doc.Version.Document = (IDocument)doc.Entity.Implementation();
		doc.Version.Status = DocumentVersionStatus.Current;
		doc.Entity.Versions.Add(doc.Version);
		doc.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = doc.Entity.Id
		});
	}

	[HttpGet]
	public ActionResult WebDocumentPortlet(WebDocumentPersonalization settings)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)settings.Document);
	}

	public ActionResult DownloadTools()
	{
		return (ActionResult)(object)((Controller)this).PartialView("DownloadTools");
	}

	[Obsolete("Метод перенесен в модуль ELMA Store")]
	public ActionResult AgentOSXPopup()
	{
		return (ActionResult)(object)((Controller)this).PartialView("AgentOSXPopup");
	}

	public ActionResult HasActiveTasksByDocuments(long[] documentIds)
	{
		List<IDocument> document = documentIds.Select((long i) => DocumentManager.Instance.Load(i)).ToList();
		long documentsTasksByDocumentCount = DocumentManager.Instance.GetDocumentsTasksByDocumentCount(document, TaskBaseExtensions.ActiveTaskStatuses.ToList());
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			tasks = documentsTasksByDocumentCount
		});
	}

	public ActionResult ArchiveCommentPopup(long[] documentIds, int archivate)
	{
		ArchiveModel archiveModel = new ArchiveModel
		{
			Archivate = (archivate == 1),
			DocumentIds = documentIds
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/ArchiveCommentPopup", (object)archiveModel);
	}

	[HttpPost]
	public ActionResult Archive(long[] documentIds, int? taskaction, string Comment)
	{
		List<long> archivingDocumentIds = DocumentManager.Instance.GetArchivingDocumentIds();
		IEnumerable<long> source = documentIds.Where((long id) => !archivingDocumentIds.Contains(id));
		if (documentIds.Any() && !source.Any())
		{
			base.Notifier.Error(SR.T("Архивирование уже выполняется."));
			if (!AjaxRequestExtensions.IsAjaxRequest(((Controller)this).get_Request()))
			{
				return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
			}
			return SuccessJson();
		}
		if (base.SystemFoldersService.ArchiveFolder == null)
		{
			base.Notifier.Error(SR.T("\"Архив\" указан неверно. Либо удален."));
			if (!AjaxRequestExtensions.IsAjaxRequest(((Controller)this).get_Request()))
			{
				return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
			}
			return SuccessJson();
		}
		CheckDocumentAction(DocumentManager.Instance.FindByIdArray(source.ToArray()).ToList(), DocumentActionProvider.DocumentSendToArchiveActionUID, DocumentActionProvider.DocumentArchiveActionsChapterInfoUID, out var documents, out var messages);
		WriteErrorMessages(messages);
		documents = documents.Where(delegate(IDocument o)
		{
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, o))
			{
				base.Notifier.Error(SR.T("Нет прав для отправки в архив документа: {0}", o.Name));
				return false;
			}
			return true;
		}).ToList();
		DocumentManager.Instance.Archive(documents);
		if (taskaction.HasValue && taskaction.Value == 1)
		{
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				DocumentManager.Instance.CloseAllTasks(documents, Comment);
			});
		}
		if (!AjaxRequestExtensions.IsAjaxRequest(((Controller)this).get_Request()))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		return SuccessJson();
	}

	[HttpPost]
	public ActionResult UnArchive(long[] documentIds)
	{
		IMyDocumentFolder myDocumentsFolder = base.SystemFoldersService.GetMyDocumentFolderForCurrentUser();
		if (base.SystemFoldersService.ArchiveFolder == null)
		{
			base.Notifier.Error(SR.T("\"Архив\" указан неверно. Либо удален."));
			return SuccessJson();
		}
		CheckDocumentAction(DocumentManager.Instance.FindByIdArray(documentIds).ToList(), DocumentActionProvider.DocumentReturnFromArchiveActionUID, DocumentActionProvider.DocumentArchiveActionsChapterInfoUID, out var checkedDocuments, out var messages);
		WriteErrorMessages(messages);
		List<MvcHtmlString> infoMessages = new List<MvcHtmlString>();
		checkedDocuments = checkedDocuments.Where(delegate(IDocument o)
		{
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, o))
			{
				base.Notifier.Error(SR.T("Нет прав для изъятия документа \"{0}\" из архива", o.Name));
				return false;
			}
			if (o.OldFolder == null)
			{
				base.Notifier.Warning(SR.T($"Родительская папка не объявлена. Документ \"{o.Name}\" перемещен в папку \"{myDocumentsFolder.Name}\""));
				o.OldFolder = myDocumentsFolder;
			}
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, o.OldFolder))
			{
				base.Notifier.Error(MvcHtmlString.Create(SR.T("Нет прав на изменение папки \"{0}\"", $"<a href=\"{((Controller)this).get_Url().Entity(o.OldFolder)}\">{o.OldFolder.Name.HtmlEncode()}</a>")));
				return false;
			}
			if (o.OldFolder.IsDeleted)
			{
				base.Notifier.Warning(SR.T("Папка \"{0}\" удалена либо не существует. Документ {2} перемещен в папку \"{1}\"", o.OldFolder.Name, myDocumentsFolder.Name, o.Name));
				o.OldFolder = myDocumentsFolder;
			}
			infoMessages.Add(MvcHtmlString.Create(SR.T("Документ \"{0}\" возвращен из архива в папку \"{1}\"", o.Name.HtmlEncode(), $"<a href=\"{((Controller)this).get_Url().Entity(o.OldFolder)}\">{o.OldFolder.Name.HtmlEncode()}</a>")));
			return true;
		}).ToList();
		DocumentManager.Instance.UnArchive(checkedDocuments);
		infoMessages.ForEach(delegate(MvcHtmlString i)
		{
			base.Notifier.Information(i);
		});
		return SuccessJson();
	}

	[HttpGet]
	public ActionResult SetStatusForm(long documentId, string popupId)
	{
		IDocument document = base.Manager.Load(documentId).CastAsRealType();
		if (!CheckDocumentAction(document, DocumentActionProvider.DocumentChangeStatusActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var _))
		{
			throw new DocumentActionException(document.Id, DocumentActionProvider.DocumentChangeStatusActionUID);
		}
		IMetadata metadata = MetadataLoader.LoadMetadata(((EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID(document.GetType()))).ImplementationUid, inherit: true, loadImplementation: false);
		LifeCycleStatusChangerFormModel lifeCycleStatusChangerFormModel = new LifeCycleStatusChangerFormModel
		{
			CurrentStatus = document.Status,
			DocumentType = metadata.Uid,
			Popupid = popupId,
			Document = document
		};
		lifeCycleStatusChangerFormModel.Init();
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/LifeCycleStatusChangerForm", (object)lifeCycleStatusChangerFormModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SetStatus(LifeCycleStatusChangerFormModel model)
	{
		if (model.Document != null && model.SelectedStatus != null)
		{
			if (!CheckDocumentAction(model.Document, DocumentActionProvider.DocumentChangeStatusActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, out var _))
			{
				throw new DocumentActionException(model.Document.Id, DocumentActionProvider.DocumentChangeStatusActionUID);
			}
			if (model.Document.Encrypt)
			{
				string password = CheckAndGetCryptPassword(model.Document);
				DocumentManager.Instance.SetStatus(model.Document, model.SelectedStatus, password, model.Comment);
			}
			else
			{
				DocumentManager.Instance.SetStatus(model.Document, model.SelectedStatus, model.Comment);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpGet]
	public ActionResult WatchInfo()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[HttpGet]
	public ActionResult Settings()
	{
		DocumentStorageSettings documentStorageSettings = new DocumentStorageSettings
		{
			BlockControllers = DocumentStorageSettingsBlocks
		};
		return (ActionResult)(object)((Controller)this).View((object)documentStorageSettings);
	}

	[HttpGet]
	public ActionResult EditSettings(Guid blockUid)
	{
		if (blockUid == Guid.Empty)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Неправильно задан идентификатор модуля")
			});
		}
		if (DocumentStorageSettingsBlocks == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно получить список доступных блоков для сохранения настроек")
			});
		}
		IDocumentStorageSettingsBlockController documentStorageSettingsBlockController = DocumentStorageSettingsBlocks.FirstOrDefault((IDocumentStorageSettingsBlockController b) => b.Block.BlockUid == blockUid);
		if (documentStorageSettingsBlockController == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно найти блок с идентификатором {0}", blockUid)
			});
		}
		return (ActionResult)(object)((Controller)this).PartialView("Document/StorageSettingsRenderEdit", (object)documentStorageSettingsBlockController);
	}

	[HttpPost]
	public ActionResult SaveSettings(Guid blockUid)
	{
		if (blockUid == Guid.Empty)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Неправильно задан идентификатор модуля")
			});
		}
		if (DocumentStorageSettingsBlocks == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно получить список доступных блоков для сохранения настроек")
			});
		}
		IDocumentStorageSettingsBlockController documentStorageSettingsBlockController = DocumentStorageSettingsBlocks.FirstOrDefault((IDocumentStorageSettingsBlockController b) => b.Block.BlockUid == blockUid);
		if (documentStorageSettingsBlockController == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Невозможно найти блок с идентификатором {0}", blockUid)
			});
		}
		try
		{
			((Controller)this).TryUpdateModel<object>(documentStorageSettingsBlockController.Block.Settings);
			GlobalSettingsSaveResult globalSettingsSaveResult = documentStorageSettingsBlockController.SaveSettings(((ControllerBase)this).get_ControllerContext());
			if (globalSettingsSaveResult != null && !globalSettingsSaveResult.Success)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = false,
					reason = SR.T("Ошибка при сохранении пользовательских настроек хранилища документов: {0}", globalSettingsSaveResult.ErrorMessage)
				});
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				reason = SR.T("Настройки успешно сохранены")
			});
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				reason = SR.T("Ошибка при сохранении пользовательских настроек хранилища документов: {0}", ex.Message)
			});
		}
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Send(long[] documentId)
	{
		List<IDocument> documents = documentId.Select((long id) => DocumentManager.Instance.Load(id)).ToList();
		DocumentManager.Instance.Send(documents);
		return SuccessJson();
	}

	public ActionResult DocumentParameters(Guid typeUid)
	{
		DocumentInfo documentInfo = CreateDocumentInfo(typeUid, null, ViewType.Edit, base.Notifier);
		return (ActionResult)(object)((Controller)this).PartialView("ContentSelectors/DocumentParameters", (object)documentInfo);
	}

	public JsonResult ElmaAgentMenuPermission(long? documentId, long? versionId)
	{
		long num = (versionId.HasValue ? versionId.Value : 0);
		string fileId = null;
		string notVisibleItems = "";
		IDocumentVersion documentVersion = null;
		bool flag = false;
		bool flag2 = false;
		string message = null;
		if (num > 0)
		{
			documentVersion = DocumentVersionManager.Load(num);
			fileId = documentVersion.File.Id;
			if (documentVersion.Encrypt)
			{
				notVisibleItems = "btnEAgentBlockEditVer,btnEAgentReadVer,btnEAgentEditVer,btnEAgentNewVer,btnToCompare,btnEAgentBlockNewVer";
				num = 0L;
				fileId = null;
				message = SR.T("Версия документа зашифрована. ELMA Агент не поддерживает работу с зашифрованными файлами документов.");
			}
			if (documentVersion.Document != null)
			{
				flag = base.SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, documentVersion.Document);
				flag2 = base.SecurityService.HasPermission(PermissionProvider.DocumentLoadPermission, documentVersion.Document);
				if (!base.SecurityService.HasPermission(PermissionProvider.DocumentVersionLoadPermission, documentVersion))
				{
					documentVersion = null;
					notVisibleItems = "btnEAgentBlockEditVer,btnEAgentReadVer,btnEAgentEditVer,btnEAgentNewVer,btnToCompare,btnEAgentBlockNewVer";
					num = 0L;
					message = SR.T("Нет прав на загрузку версии.");
				}
			}
		}
		else if (documentId.HasValue)
		{
			IDocument document = null;
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				document = DocumentManager.Instance.LoadOrNull(documentId.Value);
			});
			flag = base.SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, document);
			flag2 = base.SecurityService.HasPermission(PermissionProvider.DocumentLoadPermission, document);
			if (flag)
			{
				documentVersion = document.GetCurrentVersion();
				fileId = documentVersion.File.Id;
				if (documentVersion != null)
				{
					num = documentVersion.Id;
					if (documentVersion.Encrypt)
					{
						notVisibleItems = "btnEAgentBlockEditVer,btnEAgentReadVer,btnEAgentEditVer,btnEAgentNewVer,btnToCompare,btnEAgentBlockNewVer";
						num = 0L;
						fileId = null;
						message = SR.T("Версия документа зашифрована. ELMA Агент не поддерживает работу с зашифрованными файлами документов.");
					}
				}
			}
			else
			{
				notVisibleItems = "btnEAgentBlockEditVer,btnEAgentReadVer,btnEAgentEditVer,btnEAgentNewVer,btnToCompare,btnEAgentBlockNewVer";
				num = 0L;
			}
			if (!flag2)
			{
				documentVersion = null;
				notVisibleItems = "btnEAgentBlockEditVer,btnEAgentReadVer,btnEAgentEditVer,btnEAgentNewVer,btnToCompare,btnEAgentBlockNewVer";
				num = 0L;
				message = SR.T("Нет прав на загрузку документа.");
			}
		}
		if (documentVersion != null && documentVersion.Document != null && !documentVersion.Encrypt)
		{
			bool flag3 = base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, documentVersion.Document);
			bool editPermission = flag3 || base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, documentVersion.Document);
			List<string> values = EleWise.ELMA.Documents.Web.Extensions.HtmlExtensions.NotVisibleElmaAgentFolderMenu(documentVersion, flag, editPermission, flag3);
			notVisibleItems = string.Join(",", values);
		}
		return ((Controller)this).Json((object)new
		{
			currentVersion = num,
			fileId = fileId,
			notVisibleItems = notVisibleItems,
			message = message,
			canLoadFile = flag2
		}, (JsonRequestBehavior)0);
	}

	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "documentId")]
	public JsonResult DocumentMenuPermission(long documentId)
	{
		long currentVersion = 0L;
		try
		{
			IDocument document = DocumentManager.Instance.Load(documentId);
			string notVisibleItems = string.Join(",", EleWise.ELMA.Documents.Web.Extensions.HtmlExtensions.NotVisibleItems(document));
			IDocumentVersion currentVersion2 = document.GetCurrentVersion();
			if (currentVersion2 != null)
			{
				currentVersion = currentVersion2.Id;
			}
			return ((Controller)this).Json((object)new
			{
				id = documentId,
				currentVersion = currentVersion,
				notVisibleItems = notVisibleItems
			}, (JsonRequestBehavior)0);
		}
		catch (SecurityException)
		{
			return ((Controller)this).Json((object)new
			{
				id = documentId,
				currentVersion = currentVersion,
				noaccess = true
			}, (JsonRequestBehavior)0);
		}
	}

	public ActionResult CryptPopup(long id)
	{
		IDocument document = DocumentManager.Instance.Load(id);
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document))
		{
			throw new SecurityException(SR.T("Для шифрования документа необходимы полные права на него"));
		}
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = document
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/CryptPopup", (object)documentCryptInfo);
	}

	public ActionResult CryptEditPopup(long id)
	{
		IDocument document = DocumentManager.Instance.Load(id);
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document))
		{
			throw new SecurityException(SR.T("Для изменения шифрования документа необходимы полные права на него"));
		}
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = document
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/CryptEditPopup", (object)documentCryptInfo);
	}

	public ActionResult CryptCancelPopup(long id)
	{
		IDocument document = DocumentManager.Instance.Load(id);
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document))
		{
			throw new SecurityException(SR.T("Для шифрования документа необходимы полные права на него"));
		}
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = document
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/CryptCancelPopup", (object)documentCryptInfo);
	}

	public ActionResult CryptActionPopup(long id, string callback)
	{
		IDocument entity = DocumentManager.Instance.Load(id);
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = entity,
			AjaxPost = !string.IsNullOrEmpty(callback),
			Callback = callback
		};
		if (documentCryptInfo.AjaxPost)
		{
			documentCryptInfo.PostAction = "CryptActionPopup";
		}
		return (ActionResult)(object)((Controller)this).PartialView("Document/CryptActionPopup", (object)documentCryptInfo);
	}

	public static string CheckAndGetCryptPassword(IDocument document)
	{
		return DocumentManager.Instance.CheckAndGetCryptPassword(document);
	}

	public static IDocument CheckIsCrypt(IDocument document, bool needDecrypt = true)
	{
		if (document.Encrypt)
		{
			ICryptoContextAuthService serviceNotNull = Locator.GetServiceNotNull<ICryptoContextAuthService>();
			if (!serviceNotNull.IsSignForEntity(document))
			{
				document.Refresh();
				throw new EncryptDocumentException(document.Id);
			}
			if (needDecrypt)
			{
				document = (IDocument)serviceNotNull.DecryptFromContext(document);
			}
		}
		return document;
	}

	[HttpPost]
	public ActionResult Crypt(DocumentCryptInfo info)
	{
		if (info.Password != info.PasswordConfirm)
		{
			base.Notifier.Error(SR.T("Введеные пароли не совпадают"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, info.Entity))
		{
			throw new SecurityException(SR.T("Для шифрования документа необходимы полные права на него"));
		}
		DocumentManager.Instance.Encrypt(info.Entity, info.Password);
		info.Entity.Refresh();
		CryptoDocumentService.SignInForEntity(info.Entity, info.Password);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpPost]
	public ActionResult CryptEdit(DocumentCryptInfo info)
	{
		if (!DocumentManager.Instance.CheckPassword(info.Entity, info.OldPassword))
		{
			base.Notifier.Error(SR.T("Старый пароль введен неправильно"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		if (info.Password != info.PasswordConfirm)
		{
			base.Notifier.Error(SR.T("Введеные пароли не совпадают"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, info.Entity))
		{
			throw new SecurityException(SR.T("Для изменения шифрования документа необходимы полные права на него"));
		}
		DocumentManager.Instance.CancelEncrypt(info.Entity, info.OldPassword);
		info.Entity.Encrypt = false;
		DocumentManager.Instance.Encrypt(info.Entity, info.Password);
		CryptoDocumentService.SignOutForEntity(info.Entity);
		CryptoDocumentService.SignInForEntity(info.Entity, info.Password);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult CryptCancel(DocumentCryptInfo info)
	{
		if (!DocumentManager.Instance.CheckPassword(info.Entity, info.Password))
		{
			base.Notifier.Error(SR.T("Пароль введен неправильно"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, info.Entity))
		{
			throw new SecurityException(SR.T("Для изменения шифрования документа необходимы полные права на него"));
		}
		DocumentManager.Instance.CancelEncrypt(info.Entity, info.Password);
		CryptoDocumentService.SignOutForEntity(info.Entity);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult CryptActionPopup(DocumentCryptInfo info)
	{
		if (!CryptoDocumentService.SignInForEntity(info.Entity, info.Password))
		{
			((ControllerBase)this).get_ViewData().get_ModelState().Clear();
			((ControllerBase)this).get_ViewData().get_ModelState().AddModelError("WrongPassword", SR.T("Неверный пароль для расшифровки документа"));
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				auth = false
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			auth = true,
			password = info.Password
		});
	}

	[HttpGet]
	[Themed(false)]
	public ActionResult EncryptLogOn(long id)
	{
		IDocument entity = DocumentManager.Instance.Load(id);
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = entity
		};
		return (ActionResult)(object)((Controller)this).View((object)documentCryptInfo);
	}

	[HttpGet]
	public ActionResult EncryptLogOnFormSimple(long id)
	{
		IDocument entity = DocumentManager.Instance.Load(id);
		DocumentCryptInfo documentCryptInfo = new DocumentCryptInfo
		{
			Entity = entity
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/EncryptLogOnFormSimple", (object)documentCryptInfo);
	}

	[HttpPost]
	[Themed(false)]
	[TransactionAction]
	public ActionResult EncryptLogOn(DocumentCryptInfo info)
	{
		if (!CryptoDocumentService.SignInForEntity(info.Entity, info.Password))
		{
			((ControllerBase)this).get_ViewData().get_ModelState().Clear();
			((ControllerBase)this).get_ViewData().get_ModelState().AddModelError("WrongPassword", SR.T("Неверный пароль для расшифровки документа"));
			return (ActionResult)(object)((Controller)this).View((object)info);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public static bool CheckDocumentAction(IDocument document, Guid actionUid, Guid chapterUid, out string message)
	{
		message = string.Empty;
		bool result = true;
		if (!DocumentActionsProfileManager.Instance.ActionIsVisible(actionUid, chapterUid, document.TypeUid))
		{
			DocumentActionInfo actionInfo = DocumentActionsProfileManager.Instance.GetActionInfo(actionUid);
			result = false;
			message = SR.T("С документом \"{0}\" (Идентификатор: {1}) не может быть выполнено действие \"{2}\"", document.Name, document.Id, (actionInfo != null) ? actionInfo.ActionName : SR.T("Действие {0}", actionUid));
		}
		return result;
	}

	public static bool CheckDocumentAction(List<IDocument> documents, Guid actionUid, Guid chapterUid, out List<IDocument> checkedDocuments, out List<string> messages)
	{
		bool result = true;
		messages = new List<string>();
		checkedDocuments = new List<IDocument>(documents);
		foreach (IDocument document in documents)
		{
			if (!DocumentActionsProfileManager.Instance.ActionIsVisible(actionUid, chapterUid, document.TypeUid))
			{
				DocumentActionInfo actionInfo = DocumentActionsProfileManager.Instance.GetActionInfo(actionUid);
				result = false;
				messages.Add(SR.T("С документом \"{0}\" (Идентификатор: {1}) не может быть выполнено действие \"{2}\"", document.Name, document.Id, (actionInfo != null) ? actionInfo.ActionName : SR.T("Действие {0}", actionUid)));
				checkedDocuments.Remove(document);
			}
		}
		return result;
	}

	public ActionResult ActionException(long id, Guid actionUid, string message)
	{
		DocumentActionException ex = new DocumentActionException(id, actionUid, message);
		return (ActionResult)(object)((Controller)this).View("DocumentActionsProfile/ActionException", (object)ex);
	}

	public ActionResult ReplacementTaskAssign(long replacementTaskId, long objectId, Guid objectTypeUid, Guid propertyUid, bool setPermission)
	{
		IReplacementTask replacementTask = ReplacementTaskManager.LoadOrNull(replacementTaskId);
		if (replacementTask == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		replacementTask.SetAssignmentValue(new ReferenceOnEntity(objectId, objectTypeUid), propertyUid, setPermission.ToString(), delegate
		{
			bool flag = false;
			if (replacementTask.Replacement is IReplacementTaskDocumentPermission replacementTaskDocumentPermission)
			{
				flag = (bool)replacementTaskDocumentPermission.GetPropertyValue(propertyUid);
			}
			return flag.ToString();
		});
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}
}
