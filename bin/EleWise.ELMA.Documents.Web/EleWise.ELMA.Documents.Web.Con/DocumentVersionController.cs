using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.Components;
using EleWise.ELMA.Documents.Web.Extensions.SignDocumentVersion;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Services;
using Orchard.Themes;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class DocumentVersionController : DmsController<IDocumentVersion, long>
{
	public DocumentVersionManager DocumentVersionManager { get; set; }

	public DocumentManager DocumentManager { get; set; }

	public EntityService EntityService { get; set; }

	public IPreviewValidationService PreviewValidationService { get; set; }

	public ActionResult List(DocumentVersionGrid grid)
	{
		IDocument document = DocumentManager.Instance.Load(grid.DocumentId);
		bool flag = !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionCreateActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionEditActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionChangeStatusActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionLockActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid);
		grid.AllowEdit = !flag && base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document);
		grid.FullAccess = base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document) || base.SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	[CustomGridAction]
	public ActionResult SelectableGrid(GridCommand command, DocumentVersionGrid grid, [Bind(Prefix = "DocumentVersionFilter")] IDocumentVersionFilter filter)
	{
		IDocument document = DocumentManager.Instance.Load(grid.DocumentId);
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IDocumentVersionFilter>();
		}
		filter.Document = document;
		GridData<IDocumentVersion, IDocumentVersionFilter> gridData2 = (grid.Data = base.Manager.CreateGridData(command, filter));
		if (!grid.SelectedVersion.HasValue)
		{
			IDocumentVersion documentVersion = ((IEnumerable<IDocumentVersion>)document.Versions).FirstOrDefault((IDocumentVersion v) => !v.IsBlocked && !DocumentVersionManager.IsSigned(v) && v.Status == DocumentVersionStatus.Current);
			if (documentVersion == null)
			{
				documentVersion = ((IEnumerable<IDocumentVersion>)document.Versions).FirstOrDefault((IDocumentVersion v) => !v.IsBlocked && !DocumentVersionManager.IsSigned(v));
			}
			if (documentVersion != null)
			{
				grid.SelectedVersion = documentVersion.Id;
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	[InNewNHSession(SessionName = "DocumentVersions", OnlyGet = true)]
	[CustomGridAction]
	public ActionResult Grid(GridCommand command, CustomGridCommand customCommand, DocumentVersionGrid grid)
	{
		if (customCommand != null)
		{
			if (customCommand.Ids == null)
			{
				customCommand.Ids = new long[0];
			}
			switch (customCommand.CommandName)
			{
			case "Lock":
				customCommand.Ids.ToList().ForEach(delegate(long a)
				{
					IDocumentVersion version = DocumentVersionManager.Load(a);
					DocumentVersionManager.Lock(version);
				});
				break;
			case "UnLock":
				customCommand.Ids.ToList().ForEach(delegate(long a)
				{
					IDocumentVersion version2 = DocumentVersionManager.Load(a);
					DocumentVersionManager.UnLock(version2);
				});
				break;
			case "ChangeStatus":
				customCommand.Ids.ToList().ForEach(delegate(long a)
				{
					IDocumentVersion version3 = DocumentVersionManager.Load(a);
					DocumentVersionManager.ChangeStatus(version3, (DocumentVersionStatus)Convert.ToInt32(customCommand.GetParameter(((Controller)this).get_HttpContext(), "status")));
				});
				break;
			}
		}
		IDocument document = DocumentManager.Instance.Load(grid.DocumentId);
		IDocumentVersionFilter documentVersionFilter = InterfaceActivator.Create<IDocumentVersionFilter>();
		documentVersionFilter.Document = document;
		GridData<IDocumentVersion, IDocumentVersionFilter> gridData2 = (grid.Data = base.Manager.CreateGridData(command, documentVersionFilter));
		bool flag = !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionCreateActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionEditActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionChangeStatusActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid) && !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionLockActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, document.TypeUid);
		grid.AllowEdit = !flag && base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document);
		grid.FullAccess = base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document) || base.SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission);
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	public ActionResult Info(long versionId, bool elmaAgentButton = true)
	{
		IDocumentVersion documentVersion = base.Manager.Load(versionId);
		((ControllerBase)this).get_ViewData().set_Item("elmaAgentButton", (object)elmaAgentButton);
		return (ActionResult)(object)((Controller)this).PartialView("Info", (object)documentVersion);
	}

	public ActionResult CurrentVersion(long documentId)
	{
		IDocument doc = null;
		EntityService.RunWithSoftDeletable(delegate
		{
			doc = DocumentManager.Instance.Load(documentId);
		});
		CurrentDocumentVersionInfo currentDocumentVersionInfo = new CurrentDocumentVersionInfo
		{
			Document = doc,
			Version = doc.CurrentVersion
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)currentDocumentVersionInfo);
	}

	public ActionResult EditForm(long? id, long documentId, string callback, string popupId = null, bool needSign = false, bool forceNeedSign = false, bool noAjax = false)
	{
		IDocument document = DocumentManager.Instance.Load(documentId);
		IDocumentVersion documentVersion = base.Manager.Create();
		documentVersion.Document = document;
		if (id.HasValue && id.Value > 0)
		{
			documentVersion = base.Manager.Load(id.Value);
			documentVersion.File = null;
		}
		DocumentVersionModel documentVersionModel = new DocumentVersionModel
		{
			FormId = "DocVerForm" + UIExtensions.PrepareId(Guid.NewGuid().ToString()),
			Document = document,
			Version = documentVersion,
			Callback = callback,
			NotAjax = noAjax
		};
		if (!string.IsNullOrWhiteSpace(popupId))
		{
			documentVersionModel.PopupId = popupId;
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.CastAsRealType().GetType());
		IDocumentMetadataProfile documentMetadataProfile = DocumentMetadataProfileManager.Instance.LoadByDocumentType(documentMetadata.ImplementationUid);
		if (documentMetadataProfile != null)
		{
			documentVersionModel.Profile = documentMetadataProfile;
		}
		if (DocumentVersionManager.HasPermissionToSign(documentVersion))
		{
			documentVersionModel.ForceNeedSign = forceNeedSign;
			if (needSign)
			{
				documentVersionModel.NeedSign = true;
			}
			else
			{
				DoCurrentAndSignState doCurrentAndSignState = PersonalizationAdministration.LoadState<DoCurrentAndSignState>("u_" + EleWise.ELMA.Security.Services.AuthenticationService.CurrentUserName, "DoCurrentAndSign");
				if (doCurrentAndSignState != null)
				{
					documentVersionModel.NeedSign = doCurrentAndSignState.Checked;
				}
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)documentVersionModel);
	}

	[HttpGet]
	public ActionResult GridWindow(DocumentVersionGridWindow model)
	{
		return (ActionResult)(object)((Controller)this).PartialView((object)model);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Create(DocumentVersionModel model)
	{
		string text = string.Empty;
		bool flag = model.Version.IsNew();
		if (model.Version.Document.Encrypt && DocumentManager.Instance.IsVersionsNeedEncrypt(model.Version.Document))
		{
			text = DocumentController.CheckAndGetCryptPassword(model.Version.Document.CastAsRealType());
			if (!flag)
			{
				DocumentVersionManager.Decrypt(model.Version, text);
				model.Version.Encrypt = false;
				model.Version.Salt = null;
				model.Version.EncryptDate = null;
				model.Version.EncryptUser = null;
			}
		}
		if (!model.UseFile && model.Profile != null && !model.UseFile && model.Version.Document.Template != null)
		{
			model.Version.File = DocumentController.ExecuteTemplate(model.Version.Document, model.Version.Document.Template);
		}
		if (model.Version.File != null && !string.IsNullOrEmpty(model.Version.File.Name) && !model.CreatedVersionId.HasValue)
		{
			DocumentVersionManager.Save(model.Version);
			if (model.Version.Document.Encrypt && DocumentManager.Instance.IsVersionsNeedEncrypt(model.Version.Document) && text != null)
			{
				DocumentVersionManager.Encrypt(model.Version, text);
			}
		}
		if (model.CreatedVersionId.HasValue && model.Version.Id == 0L)
		{
			model.Version = DocumentVersionManager.Load(model.CreatedVersionId.Value);
		}
		if (model.IsCurrent)
		{
			DocumentVersionManager.ChangeStatus(model.Version, DocumentVersionStatus.Current);
		}
		string text2 = null;
		try
		{
			if (!model.ForceNeedSign)
			{
				DoCurrentAndSignState state = new DoCurrentAndSignState
				{
					Checked = model.NeedSign
				};
				PersonalizationAdministration.SaveState("u_" + EleWise.ELMA.Security.Services.AuthenticationService.CurrentUserName, "DoCurrentAndSign", state);
			}
		}
		catch (Exception ex)
		{
			text2 = ex.Message;
		}
		if (model.NotAjax)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Document", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				id = model.Version.Document.Id,
				selectedTab = "Versions"
			});
		}
		if (model.CreatedVersionId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = string.IsNullOrEmpty(text2),
				error = text2
			}, "text/html", (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text2),
			versionId = model.Version.Id,
			error = text2
		}, "text/html", (JsonRequestBehavior)0);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Sign(DocumentVersionModel model)
	{
		string text = null;
		bool flag = true;
		try
		{
			if (model.CreatedVersionId.HasValue && model.Version.Id == 0L)
			{
				model.Version = DocumentVersionManager.Load(model.CreatedVersionId.Value);
			}
			List<ISignDocumentVersion> list = ComponentManager.Current.GetExtensionPoints<ISignDocumentVersion>().ToList();
			if (list != null)
			{
				try
				{
					foreach (ISignDocumentVersion item in list)
					{
						item.DoSign(model.Version, model.AttributesDigitalSignature, model.ContentDigitalSignature, model.UseAttributesDigitalSignature, model.UseContentDigitalSignature);
					}
				}
				catch (Exception ex)
				{
					text = ((ex.InnerException != null) ? ex.InnerException.Message : ex.Message);
					flag = false;
				}
			}
		}
		catch (Exception ex2)
		{
			text = ex2.Message;
		}
		bool attrSignatureCreated = flag && model.UseAttributesDigitalSignature && !string.IsNullOrWhiteSpace(model.AttributesDigitalSignature);
		bool contentSignatureCreated = flag && model.UseContentDigitalSignature && !string.IsNullOrWhiteSpace(model.ContentDigitalSignature);
		if (model.CreatedVersionId.HasValue)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = string.IsNullOrEmpty(text),
				error = text,
				attrSignatureCreated = attrSignatureCreated,
				contentSignatureCreated = contentSignatureCreated
			});
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = string.IsNullOrEmpty(text),
			versionId = ((model.Version != null) ? new long?(model.Version.Id) : null),
			error = text,
			attrSignatureCreated = attrSignatureCreated,
			contentSignatureCreated = contentSignatureCreated
		});
	}

	public ActionResult Lock(long id)
	{
		IDocumentVersion version = base.Manager.Load(id);
		DocumentVersionManager.Lock(version);
		return SuccessJson();
	}

	[HttpGet]
	[WithoutSpa]
	[AuthenticationFilterAttribute.SkipUserAuthenticationChecker(HeaderName = "X-Requested-With", HeaderValue = "ElmaAgent")]
	public ActionResult Download(long id)
	{
		IDocumentVersion documentVersion = DocumentVersionManager.Load(id);
		BinaryFile file = documentVersion.File;
		string id2 = ((file.Uid != Guid.Empty) ? file.Uid.ToString() : file.Id);
		file = DataAccessManager.FileManager.LoadFile(id2);
		documentVersion = CheckIsCrypt(documentVersion, DocumentVersionActions.DownloadGuid);
		IDocument document = documentVersion.Document;
		if (document != null)
		{
			IDocument target = document.CastAsRealType();
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, target))
			{
				throw new SecurityException(SR.T("Нет прав на чтение документа"));
			}
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentLoadPermission, target))
			{
				throw new SecurityException(SR.T("Нет прав на загрузку документа"));
			}
		}
		(from p in ComponentManager.Current.GetExtensionPoints<IPrepareFileToDownload>()
			where p.Check(file)
			select p).ForEach(delegate(IPrepareFileToDownload p)
		{
			file = p.Prepare(file);
		});
		BinaryFilesController.SetFileNameHeaders(file.Name, ((Controller)this).get_Request(), ((Controller)this).get_Response());
		documentVersion.Refresh();
		documentVersion.Document.Refresh();
		DocumentVersionManager.Download(documentVersion);
		return (ActionResult)(object)File(file);
	}

	public ActionResult GetDocumentVersion(long versionId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		AutoCompleteDocumentVersionItem item = AutoCompleteDocumentVersionItem.GetItem(DocumentVersionManager.Load(versionId));
		JsonResult val = new JsonResult();
		val.set_Data((object)item);
		return (ActionResult)val;
	}

	public ActionResult GetDocumentVersionTile(TileModel tile)
	{
		IDocumentVersion documentVersion2 = (tile.Entity = DocumentVersionManager.Load(tile.VersionId));
		return (ActionResult)(object)((Controller)this).PartialView("Tile", (object)tile);
	}

	public ActionResult GetDocumentVersions(long documentId, string text = "", int max = 100)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		IDocument document = DocumentManager.Instance.Load(documentId);
		FetchOptions fetchOptions = new FetchOptions(0, max, null);
		InstanceOf<IDocumentVersionFilter> instanceOf = new InstanceOf<IDocumentVersionFilter>();
		instanceOf.New.Document = document;
		IDocumentVersionFilter @new = instanceOf.New;
		AutoCompleteDocumentVersionItem[] items = AutoCompleteDocumentVersionItem.GetItems(DocumentVersionManager.Find(@new, fetchOptions));
		JsonResult val = new JsonResult();
		val.set_Data((object)items);
		return (ActionResult)val;
	}

	private ToCompareGridModel getToCompareGridModel(long versionId)
	{
		IDocument document = null;
		GridData<IDocumentVersion> gridData = null;
		IDocumentVersion documentVersion = DocumentVersionManager.LoadOrNull(versionId);
		if (documentVersion != null && documentVersion.Document != null)
		{
			document = documentVersion.Document;
			gridData = new GridData<IDocumentVersion>();
			gridData.Count = ((ICollection<IDocumentVersion>)document.Versions).Count;
			gridData.DataSource = (IEnumerable)document.Versions;
		}
		return new ToCompareGridModel
		{
			Data = gridData,
			Version = documentVersion
		};
	}

	public ActionResult ToCompareS(string versionIdS)
	{
		long.TryParse(versionIdS, out var result);
		return (ActionResult)(object)((Controller)this).PartialView("ElmaAgent/ToCompare", (object)getToCompareGridModel(result));
	}

	public ActionResult ToCompare(long versionId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("ElmaAgent/ToCompare", (object)getToCompareGridModel(versionId));
	}

	[CustomGridAction]
	public ActionResult ToCompareGrid(GridCommand command, long versionId)
	{
		return (ActionResult)(object)((Controller)this).PartialView("ElmaAgent/ToCompareGrid", (object)getToCompareGridModel(versionId));
	}

	public ActionResult GetStatus(Guid uid)
	{
		IStatusScanedService serviceNotNull = Locator.GetServiceNotNull<IStatusScanedService>();
		if (serviceNotNull != null)
		{
			StatusScanedFileEnum status = serviceNotNull.GetStatus(uid);
			return (ActionResult)(object)((Controller)this).Json((object)new { status });
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			status = StatusScanedFileEnum.SCAN_FINISHED_ERROR
		});
	}

	public ActionResult SetStatus(Guid uid, int status)
	{
		IStatusScanedService serviceNotNull = Locator.GetServiceNotNull<IStatusScanedService>();
		if (serviceNotNull != null)
		{
			try
			{
				serviceNotNull.SetStatus(uid, (StatusScanedFileEnum)status);
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					result = true
				});
			}
			catch
			{
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = false
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SetCurrentStatus(long[] versions)
	{
		base.Manager.FindByIdArray(versions).ToList().ForEach(delegate(IDocumentVersion v)
		{
			DocumentVersionManager.ChangeStatus(v, DocumentVersionStatus.Current);
		});
		return SuccessJson();
	}

	public ActionResult GetNewBinaryFile(Guid uid, string prefix, bool? uploadButton, bool? showDescription)
	{
		IMimeMappingService serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		if (uploadButton.HasValue && !uploadButton.Value)
		{
			((ControllerBase)this).get_ViewData().set_Item("CustomRemoveFunc", (object)"ClearFileUpload");
			((ControllerBase)this).get_ViewData().set_Item("CustomBottomText", (object)SR.T("Файл загружен. Для нового сканирования нажмите кнопку \"Сканировать\""));
			((ControllerBase)this).get_ViewData().set_Item("ReadOnly", (object)true);
		}
		if (showDescription.HasValue && showDescription.Value)
		{
			((ControllerBase)this).get_ViewData().set_Item("CustomBottomText", (object)SR.T("Создать версию документа из прикрепляемого с компьютера файла"));
		}
		BinaryFile binaryFile = ((base.CacheFilesService != null && serviceNotNull != null) ? base.CacheFilesService.GetBinaryFile(uid) : null);
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/BinaryFile", (object)binaryFile);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult DragDropCreate(XhrPostedFile file)
	{
		string value = ((Controller)this).get_Request().Headers["documentId"];
		IDocument document = ((!string.IsNullOrEmpty(value)) ? DocumentManager.Instance.Load(Convert.ToInt64(value)) : null);
		if (document == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не задан документ для версии")
			}, (JsonRequestBehavior)0);
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, document) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, document))
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Недостаточно прав для создания версии в документе \"{0}\"", document.Name)
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
		AddDocumentVersionResult addDocumentVersionResult;
		try
		{
			addDocumentVersionResult = DocumentVersionManager.AddVersionAndFlush(document, binaryFile);
		}
		catch (EncryptDocumentException)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				error = SR.T("Не задан пароль для шифрования документа. Вы можете зайти в документ и создать версию обычным способом или путем перетаскивания файла на карточку документа.")
			}, (JsonRequestBehavior)0);
		}
		object obj = null;
		if (!addDocumentVersionResult.IsWebDocument)
		{
			obj = new
			{
				filename = binaryFile.Name,
				versionId = addDocumentVersionResult.NewDocumentVersion.Id
			};
		}
		if (obj != null)
		{
			return (ActionResult)(object)((Controller)this).Json(obj, (JsonRequestBehavior)0);
		}
		return SuccessJson();
	}

	internal static IDocumentVersion CheckIsCrypt(IDocumentVersion version, Guid actionUid)
	{
		if (version.Encrypt)
		{
			ICryptoContextAuthService serviceNotNull = Locator.GetServiceNotNull<ICryptoContextAuthService>();
			IEntity entity;
			if (version.Document.Encrypt)
			{
				version.Document = version.Document.CastAsRealType();
				entity = version.Document;
			}
			else
			{
				entity = version;
			}
			if (serviceNotNull.IsSignForEntity(entity))
			{
				IEntity entity2 = serviceNotNull.DecryptFromContext(entity);
				if (entity2 is IDocument document)
				{
					return ((IEnumerable<IDocumentVersion>)document.Versions).FirstOrDefault((IDocumentVersion v) => v.Id == version.Id);
				}
				if (entity2 is IDocumentVersion result)
				{
					return result;
				}
			}
			version.Document.Refresh();
			version.Refresh();
			if (version.Document.Encrypt)
			{
				throw new EncryptDocumentException(version.Document.Id);
			}
			throw new EncryptDocumentVersionException(version.Id, actionUid);
		}
		return version;
	}

	public static IDocumentVersion CheckIsCrypt(IDocumentVersion version)
	{
		return CheckIsCrypt(version, Guid.Empty);
	}

	[HttpGet]
	[Themed(false)]
	public ActionResult EncryptLogOn(long id)
	{
		IDocumentVersion entity = DocumentVersionManager.Instance.Load(id);
		DocumentVersionCryptInfo documentVersionCryptInfo = new DocumentVersionCryptInfo
		{
			Entity = entity
		};
		string returnUrl = ((!string.IsNullOrEmpty(((Controller)this).get_Request().Params.Get("ReturnUrl"))) ? ((Controller)this).get_Request().Params.Get("ReturnUrl") : "~/");
		string text = ((!string.IsNullOrEmpty(((Controller)this).get_Request().Params.Get("DownloadUrl"))) ? ((Controller)this).get_Request().Params.Get("DownloadUrl") : null);
		documentVersionCryptInfo.ReturnUrl = returnUrl;
		if (text != null)
		{
			documentVersionCryptInfo.AjaxPost = true;
			documentVersionCryptInfo.DownloadUrl = text;
			documentVersionCryptInfo.Callback = "callbackAfterSubmit(data);";
		}
		return (ActionResult)(object)((Controller)this).View((object)documentVersionCryptInfo);
	}

	[HttpPost]
	[Themed(false)]
	[TransactionAction]
	public ActionResult EncryptLogOn(DocumentVersionCryptInfo info)
	{
		if (!Locator.GetServiceNotNull<ICryptoContextAuthService>().SignInForEntity(info.Entity, info.Password))
		{
			string text = SR.T("Неверный пароль для расшифрования файла версии документа");
			if (info.AjaxPost)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					auth = false,
					errMsg = text
				});
			}
			((ControllerBase)this).get_ViewData().get_ModelState().Clear();
			((ControllerBase)this).get_ViewData().get_ModelState().AddModelError("WrongPassword", text);
			return (ActionResult)(object)((Controller)this).View((object)info);
		}
		if (info.AjaxPost)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				auth = true
			});
		}
		return (ActionResult)(object)((Controller)this).Redirect(info.ReturnUrl ?? ((Controller)this).get_Url().ReturnUrl());
	}

	[HttpGet]
	public ActionResult DownloadPreviewSelectorPopup(long? id, long? documentId, bool readOnly = false)
	{
		if (!id.HasValue && !documentId.HasValue)
		{
			throw new Exception(SR.T("Нужно задать либо id версии, либо id документа"));
		}
		IDocumentVersion version = (id.HasValue ? DocumentVersionManager.Load(id.Value) : DocumentVersionManager.GetCurrentVersion(documentId.Value).FirstOrDefault());
		version = CheckIsCrypt(version);
		((ControllerBase)this).get_ViewData().set_Item("ReadOnly", (object)readOnly);
		return (ActionResult)(object)((Controller)this).PartialView("Previews/VersionPreviewSelectorPopup", (object)version);
	}

	[HttpGet]
	public ActionResult HasPreview(long? id, long? documentId)
	{
		if (!id.HasValue && !documentId.HasValue)
		{
			throw new Exception(SR.T("Нужно задать либо id версии, либо id документа"));
		}
		IDocumentVersion documentVersion = (id.HasValue ? DocumentVersionManager.Load(id.Value) : DocumentVersionManager.GetCurrentVersion(documentId.Value).FirstOrDefault());
		if (documentVersion.File == null)
		{
			throw new Exception(SR.T("В версии документа должен быть файл"));
		}
		IPreviewValidationResult previewValidationResult = PreviewValidationService.HasPreviewValidation(new PreviewValidationParams
		{
			BinaryFile = documentVersion.File
		});
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = previewValidationResult.PreviewIsPossible,
			hideSelector = false,
			fileName = documentVersion.File.Name,
			renderer = previewValidationResult.RendererUid,
			errorMessage = previewValidationResult.ErrorMessage,
			fileUid = documentVersion.File.Uid,
			fileId = documentVersion.File.Id,
			uniquePreviewGlobalPrefix = UIExtensions.PrepareId(documentVersion.File.Id),
			canLoadFile = base.SecurityService.HasPermission(PermissionProvider.DocumentLoadPermission, documentVersion.Document)
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult PreviewPanel(long id)
	{
		IDocumentVersion documentVersion = DocumentVersionManager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView("Previews/PreviewPanelControl", (object)documentVersion.File);
	}
}
