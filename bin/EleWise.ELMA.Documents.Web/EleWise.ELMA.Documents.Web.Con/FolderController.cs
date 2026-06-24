using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Documents.Enums;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Documents.Web.Portlets;
using EleWise.ELMA.Documents.Web.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Services;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class FolderController : DmsController<IFolder, long>
{
	public IMetadataRuntimeService IMetadataRuntimeService { get; set; }

	public FolderManager FolderManager { get; set; }

	public DmsObjectManager DmsObjectManager { get; set; }

	public MyDocumentFolderManager MyDocumentFolderManager { get; set; }

	public IFolderViewService FolderViewService { get; set; }

	public DocumentsSettingsModule SettingsModule { get; set; }

	public IEntityManager<IPortletPage> PortletPageManager { get; set; }

	public IEnumerable<IEntityFilterProvider> EntityFilterProviders { get; set; }

	public IEnumerable<IEntityTitleResolver> EntityTitleResolvers { get; set; }

	public EntityUrlResolverService EntityUrlResolverService { get; set; }

	public DocumentManager DocumentManager { get; set; }

	public FullTextTreeService FullTextTreeService { get; set; }

	public IDmsObjectTreeNodeStateService DmsObjectTreeNodeStateService { get; set; }

	private int FolderTreePartCount => SR.GetSetting("Documents.Tree.FolderTreePartCount", 0);

	private bool FolderTreePartAsyncLoading => SR.GetSetting("Documents.Tree.FolderTreePartAsyncLoading", defaultValue: false);

	public ActionResult EditWindow(long? id)
	{
		IFolder folder = base.Manager.Create();
		if (id.HasValue)
		{
			folder.Folder = base.Manager.Load(id.Value);
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditWindow", (object)folder);
	}

	[HttpPost]
	public ActionResult Create(IFolder model)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		((Controller)this).get_ModelState().Remove("Id");
		((Controller)this).get_ModelState().Remove("Folder.Name");
		if (((Controller)this).get_ModelState().get_IsValid())
		{
			model.CreationAuthor = currentUser;
			base.Manager.Save(model);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = model.Folder.Id
		});
	}

	public ActionResult View(long? id, bool modeViewWebDocument = true)
	{
		IFolder folder = GetFolder(id).CastAsRealType();
		if (folder is IFilterDocumentFolder)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "FilterDocument", (object)new
			{
				area = "EleWise.ELMA.Documents.Web",
				Filterid = id
			});
		}
		if (folder.WebDocument != null && folder.WebDocument.CurrentVersion != null)
		{
			IDocumentVersion currentVersion = folder.WebDocument.CurrentVersion;
			return (ActionResult)(object)((Controller)this).View((object)new FolderModel
			{
				Entity = folder,
				ModeWebDocument = modeViewWebDocument,
				Version = currentVersion
			});
		}
		if (!id.HasValue || id.Value != folder.Id)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				id = folder.Id
			});
		}
		FolderModel folderModel = new FolderModel
		{
			Entity = folder,
			UniqueGridId = (SettingsModule.Settings != null && SettingsModule.Settings.SaveGridStateForFolder)
		};
		((Controller)(object)this).SetCurrentMenuItem("documents-tree-menu");
		return (ActionResult)(object)((Controller)this).View((object)folderModel);
	}

	[HttpGet]
	public ActionResult Edit(long id, string popupId)
	{
		IFolder entity = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)new FolderModel
		{
			Entity = entity,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult Edit(FolderModel folder)
	{
		folder.Entity.Save();
		Uri urlReferrer = ((Controller)this).get_Request().UrlReferrer;
		if (urlReferrer != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect(urlReferrer.ToString());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = folder.Entity.Id
		});
	}

	[HttpGet]
	public ActionResult Delete(long id, string popupId)
	{
		IFolder folder = base.Manager.Load(id);
		bool flag = (folder != null && folder.Folder == null) || folder.Uid == DocumentConstants.ArchiveFolderUid;
		bool flag2 = FolderManager.Instance.HasChildsByType(folder, InterfaceActivator.UID<IDocument>());
		return (ActionResult)(object)((Controller)this).PartialView((object)new FolderModel
		{
			Entity = folder,
			CanRemoved = (!flag2 && !flag),
			PopupId = popupId,
			IsArchive = flag
		});
	}

	[HttpPost]
	public ActionResult Delete(FolderModel folder)
	{
		try
		{
			bool flag = FolderManager.Instance.HasChildsByType(folder.Entity, InterfaceActivator.UID<IDocument>());
			if (folder.IsArchive)
			{
				base.Notifier.Error(SR.T("Невозможно удалить, так как папка является системной"));
				return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
				{
					id = folder.Entity.Id
				});
			}
			if (!flag)
			{
				folder.Entity.Delete();
			}
			else
			{
				base.Notifier.Error(SR.T("Невозможно удалить, так как папка не пустая"));
			}
		}
		catch (Exception ex)
		{
			base.Logger.Log(LogLevel.Error, ex, ex.Message);
			FormNotifierExtensions.Error(base.Notifier, ex);
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				id = folder.Entity.Id
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = folder.Entity.Folder.Id
		});
	}

	[HttpGet]
	public ActionResult Move(long id, string popupId)
	{
		IFolder entity = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView("Move", (object)new FolderModel
		{
			Entity = entity,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult Move(FolderModel folder)
	{
		if (folder.Entity.Folder == null)
		{
			base.Notifier.Error(SR.T("Для переноса необходимо указать папку"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				id = folder.Entity.Id
			});
		}
		if (folder.Entity == folder.Entity.Folder)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				id = folder.Entity.Id
			});
		}
		if (folder.Entity != null && FolderManager.Instance.IsParentFolder(folder.Entity, folder.Entity.Folder))
		{
			base.Notifier.Error(SR.T("Нельзя перенести в папку, являющуюся дочерней"));
			return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
			{
				id = folder.Entity.Id
			});
		}
		folder.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = folder.Entity.Folder.Id
		});
	}

	[HttpGet]
	public JsonResult CheckFolderWithSameName(long? parentId, string name)
	{
		if (!parentId.HasValue)
		{
			return ((Controller)this).Json((object)new
			{
				result = false
			}, (JsonRequestBehavior)0);
		}
		IFolder folder = base.Manager.LoadOrNull(parentId);
		if (folder == null)
		{
			return ((Controller)this).Json((object)new
			{
				result = false
			}, (JsonRequestBehavior)0);
		}
		bool result = FolderManager.CheckFolderWithSameName(folder, name);
		return ((Controller)this).Json((object)new
		{
			result = result,
			parentName = folder.Name
		}, (JsonRequestBehavior)0);
	}

	public static IFolder GetFolder(long? id)
	{
		IFolder folder = null;
		if (id.HasValue)
		{
			folder = FolderManager.Instance.Load(id.Value);
		}
		else
		{
			folder = Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
			if (folder == null)
			{
				throw new InvalidOperationException(SR.T("Не удалось загрузить папку \"Мои документы\""));
			}
		}
		return folder;
	}

	public static GridData<IDmsObject, IDmsObjectFilter> GenerateGrid(GridCommand command, long? id, bool? enableChecked, bool? needBackFolder, RouteData routeData, ViewDataDictionary viewData)
	{
		IFolder folder = GetFolder(id);
		Guid? provider = viewData.get_Item("StateProvider") as Guid?;
		GridState gridState = GridPersonalizationAdministration.LoadState(GridHelper.GetGridId(routeData), provider);
		if (gridState == null)
		{
			gridState = GridState.CreateNew(GridHelper.GetGridId(routeData), InterfaceActivator.TypeOf<IDmsObject>());
			GridPersonalizationAdministration.SaveState(gridState.GridId, gridState, provider);
		}
		viewData.set_Item("EnableChecked", (object)(!enableChecked.HasValue || enableChecked.Value));
		return GetFolderGrid(folder, gridState, command, null, !needBackFolder.HasValue || needBackFolder.Value);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, long? id, bool? enableChecked, bool? needBackFolder, bool? portlet, Guid? gridStateProviderUid)
	{
		((ControllerBase)this).get_ViewData().set_Item("Portlet", (object)portlet);
		((ControllerBase)this).get_ViewData().set_Item("StateProvider", (object)gridStateProviderUid);
		bool flag = IsExportExcel();
		GridData<IDmsObject, IDmsObjectFilter> folderData = GenerateGrid(command, id, enableChecked, flag ? new bool?(false) : needBackFolder, ((Controller)this).get_RouteData(), ((ControllerBase)this).get_ViewData());
		return ExportExcel(folderData, typeof(IDmsObject), () => (ActionResult)(object)((Controller)this).PartialView((object)folderData));
	}

	public static GridData<TO, TF> GetDocumentGrid<TO, TF>(GridCommand command, TF filter, Type EntityType) where TF : IEntityFilter
	{
		GridData<TO, TF> obj = new GridData<TO, TF>
		{
			Command = command,
			DataFilter = filter,
			EntityType = EntityType
		};
		IEntityManager manager = ModelHelper.GetEntityManager(EntityType);
		obj.SetCount((GridData<TO, TF> d, FetchOptions f) => manager.Count(d.DataFilter));
		obj.SetDataSource((GridData<TO, TF> d, FetchOptions f) => manager.Find(d.DataFilter, f));
		return obj;
	}

	private static GridData<IDmsObject, IDmsObjectFilter> GetFolderGrid(IFolder folder, GridState state, GridCommand command = null, IDmsObjectFilter dmsFilter = null, bool needBackFolder = true)
	{
		IDmsObjectFilter dmsObjectFilter = dmsFilter;
		if (dmsObjectFilter == null)
		{
			InstanceOf<IDmsObjectFilter> instanceOf = new InstanceOf<IDmsObjectFilter>();
			instanceOf.New.Folder = folder;
			dmsObjectFilter = instanceOf.New;
		}
		IDmsObjectFilter dmsObjectFilter2 = dmsObjectFilter;
		dmsObjectFilter2.PermissionId = PermissionProvider.DocumentViewPermission.Id;
		dmsObjectFilter2.SearchAlsoEncrypted = dmsObjectFilter2.SearchAlsoEncrypted ?? true;
		GridData<IDmsObject, IDmsObjectFilter> gridData = new GridData<IDmsObject, IDmsObjectFilter>
		{
			Command = command,
			DataFilter = dmsObjectFilter2
		};
		DmsObjectManager dmsObjectManager = Locator.GetServiceNotNull<DmsObjectManager>();
		gridData.SetCount((GridData<IDmsObject, IDmsObjectFilter> d, FetchOptions f) => dmsObjectManager.Count(d.DataFilter));
		gridData.SetDataSource((GridData<IDmsObject, IDmsObjectFilter> d, FetchOptions f) => dmsObjectManager.Find(gridData.DataFilter, f));
		return gridData;
	}

	public ActionResult Archive()
	{
		IFilterDocumentFolder archiveFolderForCurrentUser = base.SystemFoldersService.GetArchiveFolderForCurrentUser();
		RouteValueDictionary routeValues = getRouteValues(archiveFolderForCurrentUser.Id, "FilterId");
		routeValues.Add("area", "EleWise.ELMA.Documents.Web");
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "FilterDocument", routeValues);
	}

	public JsonResult GetStringValue(string str, bool isFrom)
	{
		DateTime? result;
		string errorMessage;
		if (isFrom)
		{
			RelativeDateTimeParser.TryParseFromDate(str, out result, out errorMessage);
		}
		else
		{
			RelativeDateTimeParser.TryParseToDate(str, out result, out errorMessage);
		}
		return ((Controller)this).Json((object)new
		{
			Data = result,
			Error = errorMessage
		});
	}

	private RouteValueDictionary getRouteValues(long folderId, string keyIdName = "id")
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary { { keyIdName, folderId } };
		if ("lite".Equals(((Controller)this).get_Request().QueryString["interface"] ?? string.Empty))
		{
			routeValueDictionary.Add("interface", "lite");
			if ("portal".Equals(((Controller)this).get_Request().QueryString["litemode"] ?? string.Empty))
			{
				routeValueDictionary.Add("litemode", "portal");
			}
		}
		return routeValueDictionary;
	}

	[ContentItem(Name = "SR.M('Мои документы')", Id = "documents-my", Image24 = "#user.svg")]
	public ActionResult MyDocuments()
	{
		IMyDocumentFolder myDocumentFolderForCurrentUser = base.SystemFoldersService.GetMyDocumentFolderForCurrentUser();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", getRouteValues(myDocumentFolderForCurrentUser.Id));
	}

	[ContentItem(Name = "SR.M('Избранное')", Id = "documents-favorites", Image24 = "#star_outline.svg")]
	public ActionResult Favorites()
	{
		IFavoritesFolder favoritesFolderForCurrentUser = base.SystemFoldersService.GetFavoritesFolderForCurrentUser();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", getRouteValues(favoritesFolderForCurrentUser.Id));
	}

	[ContentItem(Name = "SR.M('Общие папки')", Id = "documents-shared-folders", Image24 = "#folders.svg")]
	public ActionResult SharedFolders()
	{
		IFolder folder = FolderManager.Load(DocumentConstants.SharedFolderUid);
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = folder.Id
		});
	}

	[CustomGridAction]
	public ActionResult DocumentSearchGrid(GridCommand command, [Bind(Prefix = "DocumentFilter")] IDocumentFilter filter, string gridId)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IDocumentFilter>();
		}
		Type entityType = ((filter.Types != null && filter.Types != null && filter.Types.Count == 1) ? filter.Types.First().EntityType : InterfaceActivator.TypeOf<IDocument>());
		((ControllerBase)this).get_ViewData().set_Item("ResultGridId", (object)(gridId ?? "document_search_grid_view"));
		GridData<IDocument, IDocumentFilter> model = GetDocumentGrid<IDocument, IDocumentFilter>(command, filter, entityType);
		return ExportExcel(model, typeof(IDmsObject), () => (ActionResult)(object)((Controller)this).PartialView((object)model));
	}

	public ActionResult EditForm(long? id, long? editFolderId)
	{
		IFolder folder = GetFolder(id);
		IFolder folder2 = base.Manager.Create();
		folder2.Folder = folder;
		if (editFolderId.HasValue && editFolderId.Value > 0)
		{
			folder2 = base.Manager.Load(editFolderId.Value);
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditForm", (object)folder2);
	}

	public override ActionResult SaveTreeNodeState(string treeId, string nodeId, bool expanded)
	{
		IUser currentUser = GetCurrentUser();
		long result;
		bool flag = long.TryParse(nodeId, out result);
		if (flag)
		{
			DmsObjectTreeNodeStateService.SaveNodeState(treeId, currentUser, result, expanded);
			FolderManager.ClearFolderTreeCacheForCurrentUser(null, treeId);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = flag
		}, (JsonRequestBehavior)0);
	}

	private TreeModel BuildFolderTreeModel(string treeId = null, bool url = true, bool loadOnDemand = false, bool onlyModel = false, bool notVirtual = false, bool calcByPermission = false, long? rootNodeId = null, long? currentFolderId = null, bool? iscreatedocument = false, bool isTemp = false, int package = 0, bool partialLoading = false)
	{
		TreeModel treeModel = new TreeModel
		{
			Id = (treeId ?? Guid.NewGuid().ToString()),
			AjaxDataBinding = true,
			ControllerName = "Folder",
			ActionName = "AjaxFolderTree",
			RouteValues = new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.Documents.Web" },
				{ "url", url },
				{ "treeId", treeId },
				{ "calcByPermission", calcByPermission },
				{ "notVirtual", notVirtual },
				{ "iscreatedocument", iscreatedocument },
				{ "isTemp", isTemp }
			},
			PartialTree = partialLoading,
			AsyncPartialLoading = FolderTreePartAsyncLoading
		};
		long rootDepth;
		List<FolderTreePackage> stack;
		ILookup<long?, FolderTreeNode> lookup;
		if (!onlyModel)
		{
			rootDepth = 0L;
			stack = new List<FolderTreePackage>();
			DmsObjectTreeNodeStateService.InsertStateIfNotExists(currentFolderId, treeModel.Id, GetCurrentUser(), isTemp);
			lookup = FolderManager.LoadTree(rootNodeId, (!loadOnDemand) ? LoadTreeMode.Full : LoadTreeMode.DownByState, treeModel.Id).ToLookup((FolderTreeNode n) => n.FolderId);
			IEnumerable<FolderTreeNode> enumerable = lookup[rootNodeId];
			treeModel.Children.AddRange(ConvertToNodes(enumerable, rootNodeId ?? 0, enumerable.FirstOrDefault()?.Depth ?? 0));
			treeModel.LoadingStack = new JsonSerializer().Serialize(from s in stack
				orderby s.Depth descending, s.FolderId
				select s);
		}
		return treeModel;
		TreeMenuNode BuildMenuNode(FolderTreeNode treeNode, long depth)
		{
			string id = treeNode.Id.ToString();
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				text = treeNode.Name,
				id = id,
				icon = (treeNode.ImageUrl ?? ((Controller)this).get_Url().Action("Object", "Images", (object)new
				{
					area = "EleWise.ELMA.SDK.Web",
					id = treeNode.NodeTypeUid,
					useParent = true
				})),
				checkable = false,
				typeuid = treeNode.NodeTypeUid,
				Virtual = treeNode.Virtual,
				expanded = treeNode.Expanded
			};
			if (url)
			{
				string text = ((Controller)this).get_Url().Entity(treeNode.NodeTypeUid, treeNode.Id);
				treeMenuNode.href = text ?? ((Controller)this).get_Url().Action("View", "Folder", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					id = treeNode.Id
				});
				treeMenuNode.onclick = ((text != null && text.StartsWith("javascript:")) ? text : string.Empty);
			}
			bool flag = treeNode.Expanded || treeNode.Id == rootNodeId;
			if (loadOnDemand && !treeMenuNode.expanded)
			{
				treeMenuNode.expanded = flag;
				treeMenuNode.loadOnDemand = treeNode.HasChild;
			}
			else
			{
				IEnumerable<FolderTreeNode> nodes2 = lookup[treeNode.Id];
				treeMenuNode.children = ConvertToNodes(nodes2, treeNode.Id, depth + 1);
				treeMenuNode.expanded = flag || treeMenuNode.children.Any((TreeMenuNode n) => n.expanded);
			}
			if (calcByPermission)
			{
				bool flag2 = treeNode.HasPermission(PermissionProvider.DocumentFullAccessPermission.Id);
				bool flag3 = treeNode.HasPermission(PermissionProvider.DocumentCreatePermission.Id);
				bool flag4 = treeNode.HasPermission(PermissionProvider.DocumentEditPermission.Id);
				treeMenuNode.HtmlAttributes = new RouteValueDictionary(treeMenuNode.HtmlAttributes ?? new RouteValueDictionary())
				{
					{
						"iseditnode",
						Convert.ToInt32(flag2 || flag4)
					},
					{
						"iscreatedocument",
						Convert.ToInt32(flag2 || flag3)
					}
				};
			}
			return treeMenuNode;
		}
		List<TreeMenuNode> ConvertToNodes(IEnumerable<FolderTreeNode> nodes, long folderId, long depth)
		{
			int localPackage = ((depth == rootDepth) ? package : 0);
			return (from n in nodes.Where((FolderTreeNode n) => (!notVirtual || !n.Virtual) && n.HasPermission((iscreatedocument == true) ? PermissionProvider.DocumentCreatePermission.Id : PermissionProvider.DocumentViewPermission.Id)).If(partialLoading, delegate(IEnumerable<FolderTreeNode> childNodes)
				{
					if (childNodes.Count() > (localPackage + 1) * FolderTreePartCount)
					{
						FolderTreeNode folderTreeNode = childNodes.ElementAt(localPackage * FolderTreePartCount);
						stack.Add(new FolderTreePackage(folderTreeNode.FolderId ?? 0, localPackage + 1, folderTreeNode.Depth));
					}
					return childNodes.Take(localPackage * FolderTreePartCount, FolderTreePartCount);
				})
				select BuildMenuNode(n, depth)).ToList();
		}
	}

	[AcceptVerbs(/*Could not decode attribute arguments.*/)]
	public ActionResult AjaxFolderTree(TreeViewItem node, bool url = true, bool calcByPermission = false, bool notVirtual = false, bool clearCache = false, bool? iscreatedocument = false, string treeId = null, bool isTemp = true, int package = 0)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		long? num = ((node != null && !string.IsNullOrEmpty(node.get_Value())) ? new long?(Convert.ToInt64(node.get_Value())) : null);
		if (clearCache)
		{
			FolderManager.ClearFolderTreeCache();
		}
		string treeId2 = (string.IsNullOrEmpty(treeId) ? "MainFolderTree" : treeId);
		long? rootNodeId = num;
		TreeModel treeModel = BuildFolderTreeModel(treeId2, url, loadOnDemand: true, onlyModel: false, notVirtual, calcByPermission, rootNodeId, null, iscreatedocument, isTemp, package, FolderTreePartCount > 0);
		if (!num.HasValue && package == 0)
		{
			treeModel.Children.Insert(0, new TreeMenuNode
			{
				href = ((Controller)this).get_Url().Action("Search", "FilterDocument", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					searchOnOpen = false
				}),
				text = SR.T("Поиск документов"),
				icon = "#search.svg",
				id = "0",
				checkable = false
			});
		}
		List<TreeMenuNode> allNodes = new List<TreeMenuNode>();
		Func<TreeMenuNode, TreeViewItem> makeAjaxNode = null;
		makeAjaxNode = delegate(TreeMenuNode treeNode)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			allNodes.Add(treeNode);
			TreeViewItem val2 = new TreeViewItem();
			((NavigationItem<TreeViewItem>)val2).set_Text(treeNode.GetEncodedText());
			((NavigationItem<TreeViewItem>)val2).set_ImageUrl(((Controller)this).get_Url().Image(treeNode.icon));
			val2.set_Expanded(treeNode.expanded);
			val2.set_Value(treeNode.id);
			val2.set_LoadOnDemand(treeNode.loadOnDemand);
			val2.set_Checkable(false);
			TreeViewItem ajaxNode = val2;
			if (!string.IsNullOrEmpty(treeNode.href))
			{
				((NavigationItem<TreeViewItem>)(object)ajaxNode).set_Url(treeNode.href);
			}
			if (!string.IsNullOrEmpty(treeNode.onclick))
			{
				((NavigationItem<TreeViewItem>)(object)ajaxNode).set_Url(treeNode.onclick);
			}
			if (treeNode.children.Count > 0)
			{
				ajaxNode.set_Items((IList<TreeViewItem>)treeNode.children.Select(makeAjaxNode).ToList());
			}
			if (calcByPermission)
			{
				treeNode.HtmlAttributes.ForEach(delegate(KeyValuePair<string, object> t)
				{
					ajaxNode.get_ExtHtmlAttributes().AddIfNotContainsKey(t.Key, t.Value);
				});
			}
			return ajaxNode;
		};
		List<TreeViewItem> nodes = treeModel.Children.Select(makeAjaxNode).ToList();
		ActionResult[] obj = new ActionResult[2]
		{
			(ActionResult)((Controller)this).PartialView("FolderTreeActions", (object)allNodes),
			default(ActionResult)
		};
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			nodes = nodes,
			stack = treeModel.LoadingStack
		});
		val.set_MaxJsonLength((int?)int.MaxValue);
		obj[1] = (ActionResult)val;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)obj)
		{
			ResultType = ActionResultType.Json
		};
	}

	[ContentItem(Name = "SR.M('Хранилище документов')", Id = "documents-repository", Image24 = "#folder_tree.svg")]
	public ActionResult DocumentRepository()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult DocumentRepositoryTree()
	{
		bool onlyModel = true;
		TreeModel treeModel = BuildFolderTreeModel("MainFolderRepository", url: true, loadOnDemand: true, onlyModel, notVirtual: false, calcByPermission: false, null, null, false, isTemp: false, 0, FolderTreePartCount > 0);
		return (ActionResult)(object)((Controller)this).PartialView("Folder/DocumentRepositoryTree", (object)treeModel);
	}

	[Obsolete("Данный метод больше не используется и будет вскоре удален", true)]
	public ActionResult Tree(bool url = true, bool docPage = false)
	{
		return (ActionResult)(object)((Controller)this).HttpNotFound();
	}

	public JsonResult Select(string text, Guid uid, string displayPermissionId, string id = null, int max = 10, string filterProviderUid = null, string filterProviderData = null, string sortExpression = null, bool? notVirtual = null)
	{
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		IDmsObjectFilter dmsObjectFilter = InterfaceActivator.Create(typeof(IDmsObjectFilter)) as IDmsObjectFilter;
		try
		{
			if (notVirtual.HasValue)
			{
				dmsObjectFilter.Virtual = !notVirtual.Value;
			}
			if (displayPermissionId != null)
			{
				dmsObjectFilter.Permissions = (from q in displayPermissionId.Split(',')
					select Guid.Parse(q)).ToList();
			}
		}
		catch (Exception ex)
		{
			base.Logger.Error(ex.Message, ex);
		}
		try
		{
			return EntityController.SelectEntitiesForComboBox(new EntitiesForComboboxSelectionModel
			{
				Text = text,
				Uid = uid,
				Id = id,
				ShowOnlyGroups = false,
				Limit = max,
				FilterProviderUid = filterProviderUid,
				FilterProviderData = filterProviderData,
				SortExpression = sortExpression,
				Localize = false,
				EntityManager = FolderManager.Instance,
				EntityFilter = (dmsObjectFilter as Filter),
				EntityUrlResolverService = EntityUrlResolverService,
				Controller = (Controller)(object)this,
				MetadataRuntimeService = IMetadataRuntimeService,
				EntityNameFunc = delegate(IEntity entity)
				{
					if (!(entity is IFolder folder))
					{
						return string.Empty;
					}
					IUser user = ((folder is IHasOwner hasOwner) ? hasOwner.Owner : null);
					string path = folder.GetPath();
					return (user != null) ? $"{path} ({user.GetShortName()})" : path;
				},
				DropDownTextFunc = (IEntity entity) => (!(entity is IFolder entity2)) ? string.Empty : GetFullEntityTitle(entity2)
			});
		}
		catch (Exception ex2)
		{
			base.Logger.Error(ex2.Message, ex2);
			string message = ex2.Message;
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				error = message
			});
			return val;
		}
	}

	protected string GetFullEntityTitle(IFolder entity)
	{
		if (entity == null)
		{
			return string.Empty;
		}
		return ((object)EntityTitleResolvers.FirstOrDefault((IEntityTitleResolver r) => r.CheckType(entity))?.GetTitle(entity, ((Controller)this).get_Url())).ToString();
	}

	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "none")]
	public ActionResult TreeInput(string treeId, bool notVirtual, bool url = false, bool isedit = false, bool? iscreatedocument = false, long? folderId = null, bool isTemp = true)
	{
		TreeModel treeModel = BuildFolderTreeModel(treeId, url, loadOnDemand: true, onlyModel: false, notVirtual, calcByPermission: true, null, folderId, false, isTemp, 0, FolderTreePartCount > 0);
		((ControllerBase)this).get_ViewData().set_Item("isedit", (object)isedit);
		((ControllerBase)this).get_ViewData().set_Item("onSearchTextChangeUrl", (object)((Controller)this).get_Url().Action("TreeInputUpdate"));
		((ControllerBase)this).get_ViewData().set_Item("iscreatedocument", (object)iscreatedocument);
		if (folderId.HasValue)
		{
			((ControllerBase)this).get_ViewData().set_Item("selectedElementId", (object)folderId.Value);
		}
		return (ActionResult)(object)((Controller)this).PartialView("InputFolderTree", (object)treeModel);
	}

	[HttpPost]
	public ActionResult TreeInputUpdate(string treeId, string text, bool isTemp = true)
	{
		TreeModel treeModel = BuildFolderTreeModel(treeId, url: false, string.IsNullOrEmpty(text), onlyModel: false, notVirtual: true, calcByPermission: true, null, null, false, isTemp);
		treeModel.Children = treeModel.Children.FilterTreeNodes(text);
		treeModel.AjaxDataBinding = string.IsNullOrEmpty(text);
		treeModel.PartialTree = false;
		return (ActionResult)(object)((Controller)this).PartialView("FolderTree", (object)treeModel);
	}

	public ActionResult GetFolderPath(long id)
	{
		string text = string.Empty;
		base.SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			IFolder folder = base.Manager.Load(id);
			text = folder.GetPath();
		});
		return (ActionResult)(object)((Controller)this).Json((object)new { id, text }, (JsonRequestBehavior)0);
	}

	public ActionResult TreePage()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult Access(long id)
	{
		IFolder folder = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)folder);
	}

	[HttpGet]
	public ActionResult AttachWebDocument(long id, string popupId)
	{
		IFolder entity = FolderManager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)new FolderModel
		{
			Entity = entity,
			PopupId = popupId
		});
	}

	[HttpPost]
	public ActionResult AttachWebDocument(FolderModel model)
	{
		if (model.Entity.WebDocument != null)
		{
			model.Entity.ImageUrl = "#web.svg";
		}
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Entity.Id
		});
	}

	[HttpPost]
	public ActionResult DettachWebDocument(FolderModel model)
	{
		model.Entity.WebDocument = null;
		model.Entity.ImageUrl = null;
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = model.Entity.Id
		});
	}

	[CustomGridAction]
	public ActionResult ExplorerGrid(GridCommand command, [Bind(Prefix = "Data.DataFilter")] IDmsObjectFilter filter, string popupId, string inputId, string inputPrefix, string inputPostFix, bool? multiSelect = false, string filterProviderUid = null, string filterProviderData = null)
	{
		IFolder folder2 = (filter.Folder = (string.IsNullOrEmpty(filterProviderUid) ? GetFolder((filter.Folder != null) ? new long?(filter.Folder.Id) : null) : null));
		if (!string.IsNullOrEmpty(filter.SearchString))
		{
			filter.Folder = null;
		}
		GridData<IDmsObject, IDmsObjectFilter> gridData = null;
		gridData = ((!string.IsNullOrEmpty(filterProviderUid)) ? GetExplorerDocumentGrid(command, filter, filterProviderUid, filterProviderData) : GetFolderGrid(folder2, null, command, filter));
		EleWise.ELMA.Documents.Web.Models.ExplorerModel explorerModel = new EleWise.ELMA.Documents.Web.Models.ExplorerModel
		{
			Data = gridData,
			PopupId = popupId,
			FolderId = (folder2?.Id ?? 0),
			InputId = inputId,
			MultiSelect = (multiSelect.HasValue && multiSelect.Value),
			InputPrefix = inputPrefix,
			InputPostFix = inputPostFix,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData
		};
		return (ActionResult)(object)((Controller)this).PartialView("Folder/ExplorerGrid", (object)explorerModel);
	}

	[CustomGridAction]
	public ActionResult DocumentFolderExplorerGrid(GridCommand command, [Bind(Prefix = "Data.DataFilter")] IDmsObjectFilter filter, string popupId, string inputId, string inputPrefix, string inputPostFix, bool? multiSelect = false, string filterProviderUid = null, string filterProviderData = null, string prefixUid = null)
	{
		IFolder folder2 = (filter.Folder = (string.IsNullOrEmpty(filterProviderUid) ? GetFolder((filter.Folder != null) ? new long?(filter.Folder.Id) : null) : null));
		filter.Virtual = false;
		if (!string.IsNullOrEmpty(filter.SearchString))
		{
			filter.Folder = null;
		}
		GridData<IDmsObject, IDmsObjectFilter> data = (string.IsNullOrEmpty(filterProviderUid) ? GetFolderGrid(folder2, null, command, filter) : GetExplorerDocumentGrid(command, filter, filterProviderUid, filterProviderData));
		EleWise.ELMA.Documents.Web.Models.ExplorerModel explorerModel = new EleWise.ELMA.Documents.Web.Models.ExplorerModel
		{
			Data = data,
			PopupId = popupId,
			FolderId = (folder2?.Id ?? 0),
			InputId = inputId,
			MultiSelect = (multiSelect.HasValue && multiSelect.Value),
			PrefixUid = prefixUid,
			InputPrefix = inputPrefix,
			InputPostFix = inputPostFix,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData
		};
		return (ActionResult)(object)((Controller)this).PartialView("Folder/DocumentFolderExplorerGrid", (object)explorerModel);
	}

	private GridData<IDmsObject, IDmsObjectFilter> GetExplorerDocumentGrid(GridCommand command, IDmsObjectFilter filter, string filterProviderUid = null, string filterProviderData = null)
	{
		Guid uid = filter.DocumentType ?? InterfaceActivator.UID<IDocument>();
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
		object datafilter = UniversalFilterSaver.Pack(filter);
		IDocumentFilter filter2 = InterfaceActivator.Create<IDocumentFilter>();
		filter2 = (IDocumentFilter)UniversalFilterSaver.UnPack(datafilter, null, filter2);
		if (!string.IsNullOrEmpty(filterProviderUid))
		{
			if (Guid.TryParse(filterProviderUid, out var uidFP) && uidFP != Guid.Empty)
			{
				IEntityFilterProvider entityFilterProvider = ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First((IEntityFilterProvider p) => p.ProviderUid == uidFP);
				IEntityFilter filter3 = entityFilterProvider.GetFilter(uid, filter2);
				if (filter3 != null)
				{
					filter2 = (IDocumentFilter)filter3;
				}
				entityFilterProvider.ApplyFilter(filter2, filterProviderData);
			}
		}
		GridData<IDmsObject, IDmsObjectFilter> obj = new GridData<IDmsObject, IDmsObjectFilter>
		{
			Command = command,
			DataFilter = filter2,
			EntityType = typeByUid
		};
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		obj.SetCount((GridData<IDmsObject, IDmsObjectFilter> d, FetchOptions f) => manager.Count(d.DataFilter));
		obj.SetDataSource((GridData<IDmsObject, IDmsObjectFilter> d, FetchOptions f) => manager.Find(d.DataFilter, f));
		return obj;
	}

	[CustomGridAction]
	public ActionResult Explorer(GridCommand command, [Bind(Prefix = "Data.DataFilter")] IDmsObjectFilter filter, string popupId, string inputId, string inputPrefix, string inputPostFix, bool? multiSelect = false, string filterProviderUid = null, string filterProviderData = null)
	{
		IFolder folder2 = (filter.Folder = (string.IsNullOrEmpty(filterProviderUid) ? GetFolder((filter.Folder != null) ? new long?(filter.Folder.Id) : null) : null));
		if (!string.IsNullOrEmpty(filter.SearchString))
		{
			filter.Folder = null;
		}
		GridData<IDmsObject, IDmsObjectFilter> gridData = null;
		gridData = (string.IsNullOrEmpty(filterProviderUid) ? GetFolderGrid(folder2, null, command, filter) : GetExplorerDocumentGrid(command, filter, filterProviderUid, filterProviderData));
		EleWise.ELMA.Documents.Web.Models.ExplorerModel explorerModel = new EleWise.ELMA.Documents.Web.Models.ExplorerModel
		{
			Data = gridData,
			PopupId = popupId,
			FolderId = (folder2?.Id ?? 0),
			Filter = filter,
			MultiSelect = (multiSelect.HasValue && multiSelect.Value),
			InputId = inputId,
			InputPrefix = inputPrefix,
			InputPostFix = inputPostFix,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData
		};
		return (ActionResult)(object)((Controller)this).PartialView("Folder/Explorer", (object)explorerModel);
	}

	[CreatorForm]
	[CustomGridAction]
	public ActionResult DocumentFolderExplorer(GridCommand command, [Bind(Prefix = "Data.DataFilter")] IDmsObjectFilter filter, string popupId, string inputId, string inputPrefix, string inputPostFix, bool? multiSelect = false, string filterProviderUid = null, string filterProviderData = null, string prefixUid = null)
	{
		IFolder folder2 = (filter.Folder = (string.IsNullOrEmpty(filterProviderUid) ? GetFolder((filter.Folder != null && !filter.Folder.IsNew()) ? new long?(filter.Folder.Id) : null) : null));
		filter.Virtual = false;
		if (!string.IsNullOrEmpty(filter.SearchString))
		{
			filter.Folder = null;
		}
		GridData<IDmsObject, IDmsObjectFilter> gridData = null;
		gridData = ((string.IsNullOrEmpty(filterProviderUid) && string.IsNullOrEmpty(filterProviderData)) ? GetFolderGrid(folder2, null, command, filter) : GetExplorerDocumentGrid(command, filter, filterProviderUid, filterProviderData));
		EleWise.ELMA.Documents.Web.Models.ExplorerModel explorerModel = new EleWise.ELMA.Documents.Web.Models.ExplorerModel
		{
			Data = gridData,
			PopupId = popupId,
			FolderId = (folder2?.Id ?? 0),
			Filter = filter,
			MultiSelect = (multiSelect.HasValue && multiSelect.Value),
			InputId = inputId,
			PrefixUid = prefixUid,
			InputPrefix = inputPrefix,
			InputPostFix = inputPostFix,
			FilterProviderUid = filterProviderUid,
			FilterProviderData = filterProviderData
		};
		return (ActionResult)(object)((Controller)this).PartialView("Folder/DocumentFolderExplorer", (object)explorerModel);
	}

	[HttpPost]
	public ActionResult GetCrumbs(string query, string gridId, string inputId, long? id)
	{
		string template = string.Format("refreshGrid('{0}', function(){{}}, {{{{ 'Data.DataFilter.Folder.Id' : {{0}}, {1} 'Data.DataFilter.HierarchicalByFolder' : {2} }}}}); refreshCrumbs{3}({{0}});", gridId, (!string.IsNullOrEmpty(query)) ? ("'Data.DataFilter.Query':" + string.Format("'{0}'", query.Replace("'", "\\'")) + ",") : "", (!string.IsNullOrEmpty(query)) ? "true" : "false", inputId);
		IFolder folder = FolderManager.LoadOrNull(id.Value);
		if (folder == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				crumbs = "Мои документы"
			}, (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			crumbs = GetHtmlHelper().GetFolderCrumbs(folder, template)
		}, (JsonRequestBehavior)0);
	}

	[HttpGet]
	public ActionResult FolderPortlet(FolderPortletPersonalization settings)
	{
		IFolder folderByType = settings.GetFolderByType();
		string gridIdPostfix = settings.GridIdPostfix;
		string text = $"douments_portlet_grid_{settings.InstanceId}{gridIdPostfix}";
		if (folderByType != null && folderByType.WebDocument != null)
		{
			IDocumentVersion version = ((IEnumerable<IDocumentVersion>)folderByType.WebDocument.Versions).FirstOrDefault((IDocumentVersion m) => m.Status == DocumentVersionStatus.Current) ?? ((IEnumerable<IDocumentVersion>)folderByType.WebDocument.Versions).OrderBy((IDocumentVersion m) => m.CreationDate).LastOrDefault();
			return (ActionResult)(object)((Controller)this).PartialView((object)new FolderModel
			{
				Entity = folderByType,
				GridId = text,
				GridStateProviderUid = settings.GridStateProvider,
				ModeWebDocument = settings.ViewAsWebDocument,
				Version = version,
				DropDownContainer = $"#{text}",
				NeedBackFolder = false
			});
		}
		FolderModel folderModel = new FolderModel
		{
			Entity = folderByType,
			GridId = text,
			GridStateProviderUid = settings.GridStateProvider,
			DropDownContainer = $"#{text}",
			EnableChecked = false,
			NeedBackFolder = false
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)folderModel);
	}

	public ActionResult ChangeFolderView(Guid uid, long folderId)
	{
		IFolder folder = FolderManager.Load(folderId);
		if (FolderViewService.GetCurrent(folder) != null)
		{
			FolderViewService.Save(folder, uid);
		}
		return SuccessJson();
	}

	[OutputCache(NoStore = true, Duration = 0, VaryByParam = "folderId")]
	public JsonResult FolderMenuPermission(long folderId)
	{
		IFolder folder = null;
		string text = "";
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			folder = FolderManager.Instance.LoadOrNull(folderId);
		});
		text = string.Join(",", HtmlExtensions.NotVisibleItems(folder));
		return ((Controller)this).Json((object)new
		{
			id = folderId,
			currentVersion = 0,
			notVisibleItems = text
		}, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public JsonResult HasIndexingFolders()
	{
		return ((Controller)this).Json((object)new
		{
			has = (FullTextTreeService.IndexingIsSupport() && DocumentManager.HasIndexingDocumentCards())
		}, (JsonRequestBehavior)0);
	}
}
