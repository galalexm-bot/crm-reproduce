using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Menu;

[Component]
public class ContentActionProvider : ControllerActionProviderBase
{
	public const string CreateDocument = "EleWise.ELMA.Documents.Web-Module-CreateDocument";

	public const string CreateFolder = "EleWise.ELMA.Documents.Web-Module-CreateFolder";

	public const string CreateActionFolder = "EleWise.ELMA.Documents.Web-Module-CreateActionFolderAct";

	public const string WatchesOnDocuments = "EleWise.ELMA.BPM.Web.Common-Module-Watches-Documents";

	public const string SearchDocumentId = "EleWise.ELMA.Documents.Web-Module-Search";

	public const string HomeDocumentPageId = "EleWise.ELMA.Documents.Web-Module-HomePage";

	public const string ArchiveDocumentsPageId = "EleWise.ELMA.Documents.Web-Module-ArchivePage";

	public const string EncryptDocumentActionId = "EleWise.ELMA.Documents.Web-Module-EncryptDocument";

	public const string EncryptEditDocumentActionId = "EleWise.ELMA.Documents.Web-Module-EncryptEditDocument";

	public const string EncryptCancelDocumentActionId = "EleWise.ELMA.Documents.Web-Module-EncryptCancelDocument";

	private const string AREA = "EleWise.ELMA.Documents.Web";

	private readonly ContentAction documents;

	private readonly ContentAction folders;

	private readonly ContentAction search;

	private readonly ContentAction createDocument;

	private readonly ContentAction createFolder;

	private readonly ContentAction createActionFolder;

	private readonly ContentAction settingsDMS;

	private readonly ContentAction watches;

	private readonly ContentAction archive;

	private readonly ContentAction encryptDocument;

	private readonly ContentAction encryptEditDocument;

	private readonly ContentAction encryptCancelDocument;

	public ISecurityService SecurityService { get; set; }

	public ContentActionProvider()
	{
		documents = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module",
			DescriptionForLocalization = SR.M("Документы"),
			Image24 = "#moduledoc.svg",
			NameForLocalization = SR.M("Документы"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("View", "Folder", new
			{
				area = "EleWise.ELMA.Documents.Web"
			})
		};
		folders = new ContentAction
		{
			Id = "documents-tree",
			DescriptionForLocalization = SR.M("Папки"),
			Image24 = "#folders.svg",
			NameForLocalization = SR.M("Папки"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("View", "Folder", new
			{
				area = "EleWise.ELMA.Documents.Web"
			})
		};
		settingsDMS = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-ModuleSettings",
			DescriptionForLocalization = SR.M("Настройки документов"),
			Image24 = "#moduledoc.svg",
			NameForLocalization = SR.M("Документы"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("Index", "Settings", new
			{
				area = "EleWise.ELMA.Documents.Web"
			})
		};
		search = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-Search",
			DescriptionForLocalization = SR.M("Поиск документов"),
			Image24 = "#search.svg",
			NameForLocalization = SR.M("Поиск"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("Search", "FilterDocument", new
			{
				area = "EleWise.ELMA.Documents.Web"
			})
		};
		createDocument = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-CreateDocument",
			DescriptionForLocalization = SR.M("Документ"),
			Image24 = "#add_doc.svg",
			NameForLocalization = SR.M("Документ"),
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("MainTypeDocumentSelector")).ToString().PrepareJavascriptHref(),
			IsAvalilableDelegate = (RequestContext target) => SecurityService.HasPermission(PermissionProvider.DocumentsAccessPermission),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				RouteValueDictionary values9 = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values;
				object id2 = null;
				if ("View".Equals(values9["action"]) && "Folder".Equals(values9["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values9["area"]))
				{
					id2 = values9["id"];
				}
				if (values9["EleWise.ELMA.Documents.Web.DocumentFolderId"] != null)
				{
					id2 = values9["EleWise.ELMA.Documents.Web.DocumentFolderId"];
				}
				object documentParameters = null;
				if (values9["EleWise.ELMA.Documents.Web.DocumentParameters"] != null)
				{
					documentParameters = values9["EleWise.ELMA.Documents.Web.DocumentParameters"];
				}
				html.RegisterContent("DocumentTypeSelectorWindow", (dynamic d) => ChildActionExtensions.Action(html, "TypeSelectorWindow", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					folderId = id2,
					parameters = documentParameters
				}));
			}
		};
		createFolder = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-CreateFolder",
			DescriptionForLocalization = SR.M("Папку"),
			Image24 = "#folder_add.svg",
			NameForLocalization = SR.M("Папку"),
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("FolderEditDiv")).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				RouteValueDictionary values8 = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values;
				object id = null;
				if ("View".Equals(values8["action"]) && "Folder".Equals(values8["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values8["area"]))
				{
					id = values8["id"];
				}
				html.RegisterContent("CreateFolderWindow", (dynamic d) => ChildActionExtensions.Action(html, "EditWindow", "Folder", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					id = id
				}));
			}
		};
		createActionFolder = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-CreateActionFolderAct",
			DescriptionForLocalization = SR.M("Добавить папку-действие"),
			Image24 = "#folder_action.svg",
			NameForLocalization = SR.M("Добавить папку-действие"),
			ActionType = ContentAction.ActionTypeDialog,
			LinkTemplate = (RequestContext cc) => ((object)UIExtensions.OpenPopup("CreateActionFolderWindow")).ToString().PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				RouteValueDictionary values7 = ((ControllerContext)html.get_ViewContext()).get_RouteData().Values;
				object parentId = null;
				if ("View".Equals(values7["action"]) && "Folder".Equals(values7["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values7["area"]))
				{
					parentId = values7["id"];
				}
				html.RegisterContent("CreateActionFolderWindowContent", (dynamic d) => html.AdaptivePopupWindow("CreateActionFolderWindow", SR.T("Папка-действие"), html.Url().Action("EditForm", "ActionFolder", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					parentId = parentId
				}), "m"));
			}
		};
		watches = new ContentAction
		{
			Id = "EleWise.ELMA.BPM.Web.Common-Module-Watches-Documents",
			DescriptionForLocalization = SR.M("Список подписок на изменения по документам"),
			Image24 = "#document_complete.svg",
			NameForLocalization = SR.M("Подписки на документы"),
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("WatchInfo", "Document", new
			{
				area = "EleWise.ELMA.Documents.Web"
			})
		};
		archive = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-ArchivePage",
			NameForLocalization = SR.M("Архив документов"),
			DescriptionForLocalization = SR.M("Перейти в раздел \"Архив документов\""),
			Image24 = "#messages_all_written.svg",
			ReferenceType = "ActionPage",
			Routes = new ActionRoute("Archive", "Folder", new
			{
				area = "EleWise.ELMA.Documents.Web"
			}),
			IsAvalilableDelegate = delegate
			{
				bool flag = false;
				try
				{
					return Locator.GetServiceNotNull<ISystemFoldersService>().GetArchiveFolderForCurrentUser(noSecurityException: true) != null;
				}
				catch (Exception)
				{
					return false;
				}
			}
		};
		encryptDocument = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-EncryptDocument",
			DescriptionForLocalization = SR.M("Зашифровать секретный документ"),
			Image24 = "#access.svg",
			NameForLocalization = SR.M("Зашифровать документ"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = delegate(RequestContext html)
			{
				RouteValueDictionary values6 = html.RouteData.Values;
				object obj6 = null;
				if ("Document".Equals(values6["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values6["area"]) && values6.ContainsKey("id"))
				{
					obj6 = values6["id"];
				}
				if (obj6 == null)
				{
					return false;
				}
				IDocument document3 = DocumentManager.Instance.Load(Convert.ToInt64(obj6));
				return ((DocumentMetadata)MetadataLoader.LoadMetadata(document3.TypeUid)).EnableCrypto && !document3.Encrypt && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, document3);
			},
			LinkTemplate = delegate(RequestContext cc)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				UrlHelper val3 = new UrlHelper(cc);
				RouteValueDictionary values5 = cc.RouteData.Values;
				object obj5 = null;
				if ("Document".Equals(values5["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values5["area"]) && values5.ContainsKey("id"))
				{
					obj5 = values5["id"];
				}
				return (obj5 == null) ? string.Empty : ((object)UIExtensions.RefreshPopup("CryptoDocGroupPopup", val3.Action("CryptPopup", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					id = obj5
				}))).ToString().PrepareJavascriptHref();
			},
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CryptoDocGroupPopup", (dynamic d) => html.PopupWindow("CryptoDocGroupPopup", SR.T("Введите пароль"), ""));
			}
		};
		encryptEditDocument = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-EncryptEditDocument",
			DescriptionForLocalization = SR.M("Изменить пароль зашифрованного документа"),
			Image24 = "#edit.svg",
			NameForLocalization = SR.M("Изменить пароль"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = delegate(RequestContext html)
			{
				RouteValueDictionary values4 = html.RouteData.Values;
				object obj4 = null;
				if ("Document".Equals(values4["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values4["area"]) && values4.ContainsKey("id"))
				{
					obj4 = values4["id"];
				}
				if (obj4 == null)
				{
					return false;
				}
				IDocument document2 = DocumentManager.Instance.Load(Convert.ToInt64(obj4));
				return ((DocumentMetadata)MetadataLoader.LoadMetadata(document2.TypeUid)).EnableCrypto && document2.Encrypt && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, document2);
			},
			LinkTemplate = delegate(RequestContext cc)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				UrlHelper val2 = new UrlHelper(cc);
				RouteValueDictionary values3 = cc.RouteData.Values;
				object obj3 = null;
				if ("Document".Equals(values3["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values3["area"]) && values3.ContainsKey("id"))
				{
					obj3 = values3["id"];
				}
				return (obj3 == null) ? string.Empty : ((object)UIExtensions.RefreshPopup("CryptoEditDocGroupPopup", val2.Action("CryptEditPopup", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					id = obj3
				}))).ToString().PrepareJavascriptHref();
			},
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CryptoEditDocGroupPopup", (dynamic d) => html.PopupWindow("CryptoEditDocGroupPopup", SR.T("Изменить пароль"), ""));
			}
		};
		encryptCancelDocument = new ContentAction
		{
			Id = "EleWise.ELMA.Documents.Web-Module-EncryptCancelDocument",
			DescriptionForLocalization = SR.M("Отменить шифрование для документа. Документ смогут читать все, кто имеет к нему доступ."),
			Image24 = "#access.svg",
			NameForLocalization = SR.M("Отменить шифрование"),
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = delegate(RequestContext html)
			{
				RouteValueDictionary values2 = html.RouteData.Values;
				object obj2 = null;
				if ("Document".Equals(values2["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values2["area"]) && values2.ContainsKey("id"))
				{
					obj2 = values2["id"];
				}
				if (obj2 == null)
				{
					return false;
				}
				IDocument document = DocumentManager.Instance.Load(Convert.ToInt64(obj2));
				_ = (DocumentMetadata)MetadataLoader.LoadMetadata(document.TypeUid);
				return document.Encrypt && Locator.GetServiceNotNull<ISecurityService>().HasPermission(PermissionProvider.DocumentFullAccessPermission, document);
			},
			LinkTemplate = delegate(RequestContext cc)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected O, but got Unknown
				UrlHelper val = new UrlHelper(cc);
				RouteValueDictionary values = cc.RouteData.Values;
				object obj = null;
				if ("Document".Equals(values["controller"]) && "EleWise.ELMA.Documents.Web".Equals(values["area"]) && values.ContainsKey("id"))
				{
					obj = values["id"];
				}
				return (obj == null) ? string.Empty : ((object)UIExtensions.RefreshPopup("CryptoCancelDocGroupPopup", val.Action("CryptCancelPopup", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					id = obj
				}))).ToString().PrepareJavascriptHref();
			},
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CryptoCancelDocGroupPopup", (dynamic d) => html.PopupWindow("CryptoCancelDocGroupPopup", SR.T("Изменить пароль"), ""));
			}
		};
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		yield return documents;
		yield return search;
		yield return createDocument;
		yield return createFolder;
		yield return settingsDMS;
		yield return watches;
		yield return createActionFolder;
		yield return folders;
		yield return archive;
		yield return encryptDocument;
		yield return encryptEditDocument;
		yield return encryptCancelDocument;
	}
}
