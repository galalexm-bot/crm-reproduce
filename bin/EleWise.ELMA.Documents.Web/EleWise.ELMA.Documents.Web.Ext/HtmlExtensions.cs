using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Web.Controllers;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Buttons;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.Panels;

namespace EleWise.ELMA.Documents.Web.Extensions;

public static class HtmlExtensions
{
	public static ActionToolbarItem CreateWebDocumentButton([NotNull] this HtmlHelper html, long folderId)
	{
		long? folderId2 = ((folderId == 0L) ? null : new long?(folderId));
		ActionToolbarItem actionToolbarItem = new ActionToolbarItem("toolbar-click-commonCreateWebDocument")
		{
			Text = SR.T("Создать веб-документ"),
			ToolTip = SR.T("Перейти к форме создания веб-документа"),
			Url = html.Url().Action("Create", "Document", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				uid = InterfaceActivator.UID<IWebDocument>(),
				folderId = folderId2
			})
		};
		IEnumerable<DocumentMetadata> creatableTypes = DocumentMetadataProfileManager.Instance.CreateableDocumentTypes("", null, disabledInWeb: false);
		List<ClassMetadata> list = (from t in WebDocumentManager.Instance.GetWebDocumentTypes(onlyChild: false)
			where creatableTypes.Any((DocumentMetadata ct) => ct.Uid == t.Uid)
			select t).ToList();
		if (list.Count > 1)
		{
			foreach (ClassMetadata item2 in list)
			{
				ActionToolbarItem actionToolbarItem2 = new ActionToolbarItem($"toolbar-click-{UIExtensions.PrepareId(item2.Uid.ToString())}");
				actionToolbarItem2.Text = SR.T("Создать \"{0}\"", item2.DisplayName);
				actionToolbarItem2.IconUrl = html.Url().Action("Object", "Images", (object)new
				{
					area = "EleWise.ELMA.SDK.Web",
					id = item2.Uid,
					size = 16,
					useParent = true
				});
				actionToolbarItem2.ToolTip = SR.T("Перейти к форме создания \"{0}\"", item2.DisplayName);
				actionToolbarItem2.Url = html.Url().Action("Create", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					uid = item2.Uid,
					folderId = folderId2
				});
				ActionToolbarItem item = actionToolbarItem2;
				actionToolbarItem.Items.Add(item);
			}
			return actionToolbarItem;
		}
		return actionToolbarItem;
	}

	public static MvcHtmlString GetFullFolderCrumbs([NotNull] this HtmlHelper html, IFolder currentFolder, string template = null)
	{
		Contract.ArgumentNotNull(html, "html");
		return html.GetBreadcrumbs(currentFolder, template, null);
	}

	public static MvcHtmlString GetFolderCrumbs([NotNull] this HtmlHelper html, IFolder currentFolder, string template = null)
	{
		Contract.ArgumentNotNull(html, "html");
		return html.GetBreadcrumbs(currentFolder, template, (IFolder folder) => folder.Id != currentFolder.Id);
	}

	public static MvcHtmlString GetFolderCrumbs([NotNull] this HtmlHelper html, long id, string template = null)
	{
		Contract.ArgumentNotNull(html, "html");
		IFolder currentFolder = FolderManager.Instance.LoadOrNull(id);
		return html.GetFolderCrumbs(currentFolder, template);
	}

	public static MvcHtmlString Explorer(this HtmlHelper html, string popupId, long? id, Guid? typeUid, string filterQuery, bool multiSelect, string inputId, string inputPrefix = null, string inputPostFix = null, string filterProviderUid = null, string filterProviderData = null)
	{
		string value = string.Empty;
		if (inputPrefix != null && inputPostFix != null)
		{
			value = inputPrefix.Replace("." + inputPostFix, "");
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "popupId", popupId },
			{ "multiSelect", multiSelect },
			{ "inputId", inputId },
			{ "inputPrefix", value },
			{
				"inputPostFix",
				"." + inputPostFix
			},
			{ "Data.DataFilter.DocumentType", typeUid },
			{ "Data.DataFilter.Folder.Id", id },
			{ "Data.DataFilter.Query", filterQuery },
			{ "filterProviderUid", filterProviderUid },
			{ "filterProviderData", filterProviderData }
		};
		return html.PopupWindow(new Popup
		{
			PopupId = popupId,
			PopupHeader = SR.T("Выберите документ"),
			ActionUrl = html.Url().Action("Explorer", "Folder", routeValueDictionary)
		});
	}

	[CreatorForm]
	public static MvcHtmlString DocumentExplorer(this HtmlHelper html, Guid? typeUid, string filterQuery, bool multiSelect, string inputId, string inputPrefix = null, string inputPostFix = null, string filterProviderUid = null, string filterProviderData = null, string prefixUid = null)
	{
		if (string.IsNullOrWhiteSpace(prefixUid))
		{
			prefixUid = Guid.Empty.ToString("n");
		}
		string text = $"ExplorerPopup_{prefixUid}";
		string value = string.Empty;
		if (inputPrefix != null && inputPostFix != null)
		{
			value = inputPrefix.Replace("." + inputPostFix, "");
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "popupId", text },
			{ "multiSelect", multiSelect },
			{ "inputId", inputId },
			{ "inputPrefix", value },
			{
				"inputPostFix",
				"." + inputPostFix
			},
			{ "Data.DataFilter.DocumentType", typeUid },
			{ "Data.DataFilter.Query", filterQuery },
			{ "filterProviderUid", filterProviderUid },
			{ "filterProviderData", filterProviderData },
			{ "prefixUid", prefixUid }
		};
		return html.PopupWindow(new Popup
		{
			PopupId = text,
			PopupHeader = SR.T("Выберите документ"),
			ActionUrl = html.Url().Action("DocumentExplorer", "FilterDocument", routeValueDictionary)
		});
	}

	public static string ExplorerUrl(this HtmlHelper html, string popupId, long? id, Guid? typeUid, string filterQuery, bool multiSelect, string inputId, string inputPrefix = null, string inputPostFix = null, string filterProviderUid = null, string filterProviderData = null)
	{
		string value = string.Empty;
		if (inputPrefix != null && inputPostFix != null)
		{
			value = inputPrefix.Replace("." + inputPostFix, "");
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "popupId", popupId },
			{ "multiSelect", multiSelect },
			{ "inputId", inputId },
			{ "inputPrefix", value },
			{
				"inputPostFix",
				"." + inputPostFix
			},
			{ "typeUid", typeUid },
			{ "Data.DataFilter.DocumentType", typeUid },
			{ "Data.DataFilter.Folder.Id", id },
			{ "Data.DataFilter.Query", filterQuery },
			{ "filterProviderUid", filterProviderUid },
			{ "filterProviderData", filterProviderData }
		};
		return html.Url().Action("Explorer", "Folder", routeValueDictionary);
	}

	[CreatorForm]
	public static string DocumentExplorerUrl(this HtmlHelper html, Guid? typeUid, string filterQuery, bool multiSelect, string inputId, string inputPrefix = null, string inputPostFix = null, string filterProviderUid = null, string filterProviderData = null, string prefixUid = null)
	{
		if (string.IsNullOrWhiteSpace(prefixUid))
		{
			prefixUid = Guid.Empty.ToString("n");
		}
		string value = $"ExplorerPopup_{prefixUid}";
		string value2 = string.Empty;
		if (inputPrefix != null && inputPostFix != null)
		{
			value2 = inputPrefix.Replace("." + inputPostFix, "");
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.Documents.Web" },
			{ "popupId", value },
			{ "multiSelect", multiSelect },
			{ "inputId", inputId },
			{ "inputPrefix", value2 },
			{
				"inputPostFix",
				"." + inputPostFix
			},
			{ "typeUid", typeUid },
			{ "filterQuery", filterQuery },
			{ "Data.DataFilter.Query", filterQuery },
			{ "filterProviderUid", filterProviderUid },
			{ "filterProviderData", filterProviderData },
			{ "prefixUid", prefixUid }
		};
		return html.Url().Action("DocumentExplorer", "FilterDocument", routeValueDictionary);
	}

	public static MvcHtmlString Explorer(this HtmlHelper html, string popupId, long? id, Guid? typeUid, string inputId, string inputPrefix = null, string inputPostFix = null)
	{
		return html.Explorer(popupId, id, typeUid, null, multiSelect: true, inputId, inputPrefix, inputPostFix);
	}

	[CreatorForm]
	public static MvcHtmlString DocumentExplorer(this HtmlHelper html, Guid? typeUid, string inputId, string inputPrefix = null, string inputPostFix = null, string prefixUid = null)
	{
		return html.DocumentExplorer(typeUid, null, multiSelect: true, inputId, inputPrefix, inputPostFix, null, null, prefixUid);
	}

	public static MvcHtmlString DragAndDropInfo(this HtmlHelper html, DragAndDropInfo info = null)
	{
		if (info == null)
		{
			info = new DragAndDropInfo();
		}
		return PartialExtensions.Partial(html, "DragAndDropInfo", (object)info);
	}

	public static List<string> NotVisibleItems(IDmsObject dmsObject)
	{
		List<string> res = new List<string>();
		if (dmsObject == null)
		{
			return res;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool flag = serviceNotNull.HasPermission(PermissionProvider.DocumentFullAccessPermission, dmsObject);
		bool flag2 = serviceNotNull.HasPermission(PermissionProvider.DocumentManagerAccessPermission, dmsObject);
		bool flag3 = flag || serviceNotNull.HasPermission(PermissionProvider.DocumentEditPermission, dmsObject);
		bool flag4 = serviceNotNull.HasPermission(PermissionProvider.DocumentDeletePermission);
		bool flag5 = true;
		if (dmsObject.Folder != null)
		{
			flag5 = serviceNotNull.HasPermission(PermissionProvider.DocumentFullAccessPermission, dmsObject.Folder) || serviceNotNull.HasPermission(PermissionProvider.DocumentEditPermission, dmsObject.Folder);
		}
		AddButtonKey("btnMoveDmsObjects", res, flag3 && flag5 && dmsObject.TypeUid != InterfaceActivator.UID<IFavoritesFolder>());
		AddButtonKey("btnDeleteFolder", res, flag3 && dmsObject.TypeUid != InterfaceActivator.UID<IFavoritesFolder>());
		AddButtonKey("btnAccessFolder", res, flag || flag2);
		AddButtonKey("btnEditFolder", res, flag3 && dmsObject.TypeUid != InterfaceActivator.UID<IActionFolder>() && dmsObject.TypeUid != InterfaceActivator.UID<IFavoritesFolder>());
		AddButtonKey("btnEditActionFolder", res, flag3 && dmsObject.TypeUid == InterfaceActivator.UID<IActionFolder>());
		AddButtonKey("btnDeleteDocumentLink", res, flag3 && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentDelLinkActionUID, DocumentActionProvider.DocumentLinksActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnMoveLink", res, flag3);
		AddButtonKey("btnEditLink", res, flag3 && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentEditLinkActionUID, DocumentActionProvider.DocumentLinksActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnDeleteFolderLink", res, flag3);
		AddButtonKey("btnMoveLink", res, flag3);
		AddButtonKey("btnEditLink", res, flag3);
		AddButtonKey("btnCreateFolderLink", res, dmsObject.TypeUid != InterfaceActivator.UID<IActionFolder>());
		AddButtonKey("btnFolderFavorites", res, dmsObject.TypeUid != InterfaceActivator.UID<IActionFolder>());
		AddButtonKey("btnMoveDocument", res, flag3 && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentMoveActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnArchiveDocument", res, flag && (!dmsObject.IsArchived.HasValue || !dmsObject.IsArchived.Value) && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentSendToArchiveActionUID, DocumentActionProvider.DocumentArchiveActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnUnArchiveDocument", res, flag && dmsObject.IsArchived.HasValue && dmsObject.IsArchived.Value && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentReturnFromArchiveActionUID, DocumentActionProvider.DocumentArchiveActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnDeleteDmsObject", res, flag && flag4 && dmsObject.IsArchived.HasValue && dmsObject.IsArchived.Value && DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentDeleteActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnCopyDocument", res, DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentConvertActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, dmsObject.TypeUid));
		AddButtonKey("btnCreateReference", res, DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentAddLinkActionUID, DocumentActionProvider.DocumentGeneralActionsChapterInfoUID, dmsObject.TypeUid));
		res.AddRange(NotVisibleElmaAgentFolderMenu(dmsObject, flag3, flag));
		ComponentManager.Current.GetExtensionPoints<IContextDocumentMenuFolderMenuButton>().ToList().ForEach(delegate(IContextDocumentMenuFolderMenuButton p)
		{
			res.AddRange(p.NotVisibleItems(null, dmsObject));
		});
		return res;
	}

	public static List<string> NotVisibleItems(this HtmlHelper html, IDmsObject dmsObject)
	{
		return NotVisibleItems(dmsObject);
	}

	public static List<string> NotVisibleElmaAgentFolderMenu(IDmsObject dmsObject, bool editPermission, bool fullPermission)
	{
		List<string> result = new List<string>();
		if (dmsObject != null && (dmsObject is IDocument || dmsObject is IDocumentReference))
		{
			IDocument document = ((dmsObject is IDocument) ? ((IDocument)dmsObject) : ((IDocumentReference)dmsObject).Reference);
			result = NotVisibleElmaAgentFolderMenu(DocumentManager.Instance.GetCurrentVersionOrNull(document), viewPermission: true, editPermission, fullPermission);
		}
		return result;
	}

	public static List<string> NotVisibleElmaAgentFolderMenu(IDocumentVersion version, bool viewPermission, bool editPermission, bool fullPermission)
	{
		List<string> list = new List<string>();
		if (version == null || version.Document == null || !viewPermission || version.Encrypt || !DocumentActionsProfileManager.Instance.ActionIsVisible(DocumentActionProvider.DocumentVersionELMAAgentActionUID, DocumentActionProvider.DocumentVersionGeneralActionsChapterInfoUID, version.Document.TypeUid))
		{
			AddButtonKey("btnElmaAgent", list, @case: false);
		}
		else
		{
			AddButtonKey("btnElmaAgent", list, !WebDocumentManager.Instance.IsWebDocument(version.Document.TypeUid));
			bool @case = version.CanEdit();
			AddButtonKey("btnElmaAgent", list, @case: true);
			AddButtonKey("btnEAgentBlockEditVer", list, @case);
			AddButtonKey("btnEAgentEditVer", list, @case);
			AddButtonKey("btnEAgentNewVer", list, editPermission);
			AddButtonKey("btnEAgentReadVer", list, !editPermission && !fullPermission);
			AddButtonKey("btnToCompare", list, @case: true);
			AddButtonKey("btnEAgentBlockNewVer", list, @case);
		}
		return list;
	}

	public static List<string> NotVisibleElmaAgentFolderMenu(this HtmlHelper html, IDmsObject dmsObject, bool editPermission, bool fullPermission)
	{
		return NotVisibleElmaAgentFolderMenu(dmsObject, editPermission, fullPermission);
	}

	private static void AddButtonKey(string key, List<string> res, bool @case)
	{
		if (!@case)
		{
			res.Add(key);
		}
	}

	private static void AddButtonKey(string key, List<string> res, Func<bool> @case)
	{
		if (!@case())
		{
			res.Add(key);
		}
	}

	public static MvcHtmlString VersionCreator(this HtmlHelper html, VersionCreatorModel model)
	{
		if (model.Version != null && model.Version.Document != null && WebDocumentManager.Instance.IsWebDocument(model.Version.Document))
		{
			return PartialExtensions.Partial(html, "EditorTemplates/WebVersionCreator", (object)model);
		}
		return PartialExtensions.Partial(html, "EditorTemplates/VersionCreator", (object)model);
	}

	public static MvcHtmlString CreateDocumentPopup(this HtmlHelper html, Guid? uid, string popupId, string callback, long? folderId = null, Action<DocumentInfo> info = null)
	{
		DocumentInfo documentInfo = DocumentController.CreateDocumentInfo(uid, folderId, ViewType.Create, null);
		documentInfo.PopupId = popupId;
		documentInfo.Callback = callback;
		info?.Invoke(documentInfo);
		return PartialExtensions.Partial(html, "Document/DocumentPopup", (object)documentInfo);
	}

	public static MvcHtmlString LifeCycleStatusChanger(this HtmlHelper html, LifeCycleStatusChangerModel model)
	{
		return PartialExtensions.Partial(html, "EditorTemplates/LifeCycleStatusChanger", (object)model);
	}

	public static MvcHtmlString WebDocumentHelpButton(this HtmlHelper html, Guid typeUid, ITaskBase task = null, string htmlAttributes = null)
	{
		IDocumentHelp documentHelp = ComponentManager.Current.GetExtensionPoints<IDocumentHelp>().FirstOrDefault((IDocumentHelp c) => c.CheckType(typeUid));
		if (documentHelp == null)
		{
			return MvcHtmlString.Empty;
		}
		WebDocumentHelpButtonInfo webDocumentHelpButtonInfo = new WebDocumentHelpButtonInfo
		{
			Component = documentHelp,
			Metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeUid),
			Task = task,
			HtmlAttributes = htmlAttributes
		};
		if (webDocumentHelpButtonInfo.Document == null || webDocumentHelpButtonInfo.Document.CurrentVersion == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "WebDocument/HelpButton", (object)webDocumentHelpButtonInfo);
	}

	public static MvcHtmlString DocumentAgentButton(this HtmlHelper html, IDocument document)
	{
		return html.DocumentAgentButton(document.Id);
	}

	public static MvcHtmlString DocumentAgentButton(this HtmlHelper html, long documentId)
	{
		return MvcHtmlString.Create(string.Format("<span class='DocumentAgentButton' documentId='{0}' tooltiptext='{1}'></span>", documentId, SR.T("Открыть через ELMA Агент")));
	}

	public static void RegisterContentForDocumentAgentButton(this HtmlHelper html, long versionId)
	{
		html.RegisterContent("ToCompareKey", (dynamic p) => html.PopupWindow("ToCompare", SR.T("Отправить на сравнение"), html.Url().Action("ToCompare", "DocumentVersion", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			versionId = versionId
		}), 800));
	}

	public static string PreviewSelectorPopupOpen(this HtmlHelper html, IDocumentVersion version)
	{
		return html.PreviewSelectorPopupOpen(version, readOnly: false);
	}

	public static string PreviewSelectorPopupOpen(this HtmlHelper html, IDocumentVersion version, bool readOnly)
	{
		if (version == null || version.File == null)
		{
			return string.Empty;
		}
		if (!html.IsSupportPreview(version.File))
		{
			return string.Empty;
		}
		return string.Format("refreshPopup('DownloadPreviewSelector', '{0}', null, '{1}', null, null, null, true, true); return false;", html.Url().Action("DownloadPreviewSelectorPopup", "DocumentVersion", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = version.Id,
			popupId = "DownloadPreviewSelector",
			readOnly = readOnly
		}), HttpUtility.JavaScriptStringEncode((version.Document != null) ? version.Document.Name : version.File.Name));
	}

	public static MvcHtmlString FolderHref(this HtmlHelper html, IFolder dmsObject)
	{
		if (dmsObject.Folder == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Folder/GridParentFolder", (object)dmsObject);
	}

	private static MvcHtmlString GetBreadcrumbs(this HtmlHelper html, IFolder currentFolder, string template, Func<IFolder, bool> expression)
	{
		if (currentFolder == null)
		{
			return MvcHtmlString.Empty;
		}
		IFolder folder = currentFolder;
		bool hasTemplate = !string.IsNullOrEmpty(template);
		ButtonGroupBuilder buttonGroupBuilder = html.Breadcrumbs("DocumentsWebFolderCrumbs");
		while (folder != null)
		{
			if (expression == null || expression(folder))
			{
				buttonGroupBuilder.Insert(0, delegate(ActionButtonBuilder button)
				{
					if (hasTemplate)
					{
						button.Click(string.Format(template.Replace("{}", "{{}}"), folder.Id));
					}
					else
					{
						button.Url(html.Url().Action("View", "Folder", (object)new
						{
							area = "EleWise.ELMA.Documents.Web",
							id = folder.Id
						}));
					}
					button.Text(folder.GetFolderConvertedName().HtmlEncode());
				});
			}
			folder = folder.Folder;
		}
		return MvcHtmlString.Create(buttonGroupBuilder.ToHtmlString());
	}
}
