using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Enums;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Extensions;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Processes.Web.Portlets;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using EleWise.ELMA.Workflow.Web;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
public class ProcessHeaderController : BPMController<IProcessHeader, long>
{
	public static Guid ProcessGroupNode = new Guid("{1B9CBAB6-EFAC-406B-917F-4066FD0A0DC3}");

	public static Guid ProcessHeaderNode = new Guid("{31D7CC66-DD96-4E5F-B2CF-923938E78A2D}");

	public WorkflowTaskBaseManager WorkflowTaskBaseManager { get; set; }

	public ProcessHeaderManager ProcessHeaderManager { get; set; }

	public WorkflowInstanceContextService WorkflowInstanceContextService { get; set; }

	public ProcessGroupManager ProcessGroupManager { get; set; }

	public IWorkflowQueueService WorkflowQueueService { get; set; }

	public new ICacheFilesService CacheFilesService { get; set; }

	public IWorkflowMetadataLoaderService WorkflowMetadataLoaderService { get; set; }

	public IDiagramExporterService DiagramExporterService { get; set; }

	[HttpPost]
	public ActionResult Start(StartProcessViewModel model)
	{
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		IWorkflowProcess published = base.Manager.Load(model.ProcessHeaderId).Published;
		if (published == null)
		{
			throw new Exception(SR.T("Процесс не опубликован"));
		}
		if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.StartProcess, published))
		{
			base.Notifier.Error(SR.T("Текущий пользователь не входит в стартовую зону ответственности процесса"));
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
		}
		IWorkflowRuntimeService serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
		base.Logger.Debug("Start process run");
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.Create();
		workflowInstance.Process = published;
		workflowInstance.Name = model.Name;
		if (model.ContextDict != null)
		{
			new EntityJsonSerializer().ConvertFromSerializable(workflowInstance.Context, model.ContextDict);
		}
		((Controller)this).TryUpdateModel<WorkflowInstanceContext>(workflowInstance.Context, "Context");
		workflowInstance.Initiator = base.AuthenticationService.GetCurrentUser<IUser>();
		try
		{
			serviceNotNull.Run(workflowInstance);
		}
		catch (Exception ex)
		{
			if (ex.InnerException != null)
			{
				base.Notifier.Error(ex.InnerException.Message);
			}
			else
			{
				base.Notifier.Error(ex.Message);
			}
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
		}
		base.Logger.Debug("End process run");
		WorkflowQueueService.WaitWhileQueued(workflowInstance);
		IList<IWorkflowTaskBase> list = WorkflowTaskBaseManager.FindMyActiveTasks(workflowInstance, allowSubInstances: true);
		if (list.Count > 0)
		{
			UrlHelper url = new UrlHelper(((ControllerBase)this).get_ControllerContext().get_RequestContext());
			return (ActionResult)(object)((Controller)this).Redirect(WorkflowLinkHelper.TaskUrl(url, list[0]));
		}
		base.Notifier.HtmlAction("ExecuteInfo", "WorkflowInstance", new RouteValueDictionary(new
		{
			area = "EleWise.ELMA.Workflow.Web",
			id = workflowInstance.Id
		}));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	public ActionResult StartProcess(StartProcessViewModel model)
	{
		((ControllerBase)this).get_ViewData().get_ModelState().Clear();
		if (!string.IsNullOrEmpty(model.CreatorPrefix))
		{
			((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(model.CreatorPrefix);
		}
		IProcessHeader processHeader = ProcessHeaderManager.Instance.LoadOrNull(model.ProcessHeaderId);
		WorkflowMetadataLoaderService.CheckOrLoadMetadata(processHeader.Published);
		if (processHeader.RunAvailability == WorkflowProcessRunAvailability.Denied)
		{
			return (ActionResult)(object)((Controller)this).PartialView("ProcessRunUnavailableException");
		}
		if (!base.SecurityService.HasPermission(WorkflowPermissionProvider.StartProcess, processHeader.Published))
		{
			return (ActionResult)(object)((Controller)this).PartialView("ProcessRunUnavailableException", (object)SR.T("Текущий пользователь не входит в стартовую зону ответственности процесса"));
		}
		model.Instance = InterfaceActivator.Create<IWorkflowInstance>();
		model.Instance.Process = processHeader.Published;
		model.Context = model.Instance.Context;
		if (model.ContextDict != null)
		{
			new EntityJsonSerializer().ConvertFromSerializable(model.Context, model.ContextDict);
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(model.Instance.Context.GetType());
		model.TypeUid = classMetadata.Uid;
		return (ActionResult)(object)((Controller)this).PartialView("StartProcess", (object)model);
	}

	public ActionResult StartProcessDialog(string model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("StartProcessDialog", (object)model);
	}

	public ActionResult Tree(string treeId)
	{
		TreeModel treeModel = BuidTree(treeId, showAll: false);
		return (ActionResult)(object)((Controller)this).PartialView("Tree", (object)treeModel);
	}

	public ActionResult TreeWindow(string treeId)
	{
		ProcessTreeModel processTreeModel = new ProcessTreeModel
		{
			Id = treeId
		};
		return (ActionResult)(object)((Controller)this).PartialView("ProcessTreeWindow", (object)processTreeModel);
	}

	[HttpPost]
	public ActionResult ViewTree(string text, string treeId)
	{
		TreeModel treeModel = BuidTree(treeId, showAll: false);
		if (!text.IsNullOrEmpty())
		{
			ApplyTreeFilter(treeModel, text, ">.*?<");
		}
		return (ActionResult)(object)((Controller)this).PartialView("TreeContent", (object)treeModel);
	}

	private void ApplyTreeFilter(TreeModel treeModel, string query, string regex)
	{
		for (int i = 0; i < treeModel.Children.Count; i++)
		{
			TreeMenuNode treeMenuNode = treeModel.Children[i];
			SearchTreeItem(treeMenuNode, query.ToLower(), regex);
			if (!treeMenuNode.expanded)
			{
				treeModel.Children.Remove(treeMenuNode);
				i--;
			}
		}
	}

	private void SearchTreeItem(TreeMenuNode node, string filter, string regex)
	{
		if (node.children.Any())
		{
			for (int i = 0; i < node.children.Count; i++)
			{
				TreeMenuNode treeMenuNode = node.children[i];
				SearchTreeItem(treeMenuNode, filter, regex);
				if (treeMenuNode.expanded)
				{
					node.expanded = true;
					continue;
				}
				node.children.Remove(treeMenuNode);
				i--;
			}
		}
		if (((!string.IsNullOrWhiteSpace(regex)) ? Regex.Match(node.text, regex).ToString() : node.text).ToString().ToLower().Contains(filter))
		{
			node.expanded = true;
		}
	}

	public ActionResult Map(long id, bool displayAsImage = false, bool inPopup = true)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (((Controller)this).get_Request().ServerVariables["http_referer"] == null)
		{
			inPopup = false;
		}
		IProcessHeader processHeader = base.Manager.LoadOrNull(id);
		if (processHeader != null && processHeader.Published != null)
		{
			if (displayAsImage)
			{
				return (ActionResult)new FileStreamResult(DiagramExporterService.ExportDiagramWorkflowProcess(processHeader.Published), "image/jpeg");
			}
			PageApplicationData pageApplicationData = new PageApplicationData(new Guid("e0da7969-da1a-4622-9ac7-97abffa0a2d1"), new Dictionary<string, object> { { "ProcessId", id } });
			if (inPopup)
			{
				pageApplicationData.ApplicationId = new Guid("{12ACB165-D355-40FF-80EE-35512A3800FC}");
				return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageApplication", (object)pageApplicationData);
			}
			return (ActionResult)(object)((Controller)this).PartialView("Shared/UI/PageApplicationLayout", (object)new PageApplicationLayoutData
			{
				Title = SR.T("Карта процесса"),
				PageData = pageApplicationData
			});
		}
		return null;
	}

	public ActionResult ProcessList(long? id)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Expected O, but got Unknown
		WorkflowProcessFilter filter = new WorkflowProcessFilter
		{
			SearchString = "",
			Published = true
		};
		List<IWorkflowProcess> source = WorkflowProcessManager.Instance.Find(filter, FetchOptions.All).ToList();
		JsonResult val = new JsonResult();
		val.set_Data((object)new SelectList((IEnumerable)(from u in source
			select new
			{
				id = u.Header.Id,
				text = SR.T(u.Name)
			} into r
			orderby r.text
			select r).ToList(), "id", "text"));
		return (ActionResult)val;
	}

	[AntiForgeryToken(true)]
	public ActionResult RunByWebQuery(string id)
	{
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		IProcessHeader processHeader = base.Manager.Find((IProcessHeader h) => h.Token == id).FirstOrDefault();
		if (processHeader == null)
		{
			throw new Exception(SR.T("Для токена '{0}' не существует процессов.", id));
		}
		WorkflowMetadataLoaderService.CheckOrLoadMetadata(processHeader.Published);
		string httpMethod = ((Controller)this).get_Request().HttpMethod;
		if (!processHeader.RunByFromExternalSystem || (!processHeader.RunByWebQueryGET && !processHeader.RunByWebQueryPOST))
		{
			throw new Exception(SR.T("Процесс не может быть запущен, т.к. не установлены соответствующие настройки"));
		}
		if ((httpMethod == "GET" || httpMethod == "HEAD") && !processHeader.RunByWebQueryGET)
		{
			throw new Exception(SR.T("Процесс не может быть запущен посредством веб-запроса GET, т.к. не установлены соответствующие настройки"));
		}
		if (httpMethod == "POST" && !processHeader.RunByWebQueryPOST)
		{
			throw new Exception(SR.T("Процесс не может быть запущен посредством веб-запроса POST, т.к. не установлены соответствующие настройки"));
		}
		IWorkflowProcess published = processHeader.Published;
		if (published == null)
		{
			throw new Exception(SR.T("Процесс не опубликован"));
		}
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.Create();
		workflowInstance.Process = published;
		NameValueCollection nameValueCollection = new NameValueCollection();
		string[] allKeys;
		if (((Controller)this).get_Request().RequestType == "POST")
		{
			nameValueCollection.Add(((Controller)this).get_Request().Form);
		}
		else if (((ControllerBase)this).get_TempData().get_Item("Form") is NameValueCollection nameValueCollection2)
		{
			allKeys = nameValueCollection2.AllKeys;
			foreach (string name in allKeys)
			{
				nameValueCollection[name] = nameValueCollection2[name];
			}
		}
		nameValueCollection.Add(((Controller)this).get_Request().QueryString);
		nameValueCollection.Add(((Controller)this).get_Request().Headers);
		HttpFileCollectionBase files = ((Controller)this).get_Request().Files;
		allKeys = files.AllKeys;
		foreach (string text in allKeys)
		{
			try
			{
				HttpPostedFileBase httpPostedFileBase = files[text];
				if (httpPostedFileBase != null && !string.IsNullOrWhiteSpace(httpPostedFileBase.FileName) && httpPostedFileBase.ContentLength > 0)
				{
					string fileName = Path.GetFileName(httpPostedFileBase.FileName);
					Guid uid = CacheFilesService.CreateCacheFile(fileName);
					httpPostedFileBase.SaveAs(CacheFilesService.GetFilePath(uid));
					nameValueCollection.Add($"{text}.Uid", uid.ToString());
				}
			}
			catch (Exception ex)
			{
				HttpPostedFileBase httpPostedFileBase2 = files[text];
				base.Notifier.Error($"RunByWebQuery error file. File variable: {text} File name: {httpPostedFileBase2.FileName}. Error: {ex.Message}");
			}
		}
		if (((ControllerBase)this).get_TempData().get_Item("Files") is Dictionary<string, Guid> dictionary && dictionary.Count > 0)
		{
			foreach (KeyValuePair<string, Guid> item in dictionary)
			{
				if (!string.IsNullOrEmpty(CacheFilesService.GetFilePath(item.Value)))
				{
					nameValueCollection.Add($"{item.Key}.Uid", item.Value.ToString());
				}
			}
		}
		Dictionary<string, Exception> errors = new Dictionary<string, Exception>();
		new EntityJsonSerializer().ConvertFromSerializable(workflowInstance.Context, nameValueCollection, ref errors);
		foreach (KeyValuePair<string, Exception> item2 in errors)
		{
			base.Notifier.Error((item2.Value.InnerException != null) ? item2.Value.InnerException.Message : item2.Value.Message);
		}
		IWorkflowRuntimeService serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
		workflowInstance.Initiator = base.AuthenticationService.GetCurrentUser<IUser>();
		try
		{
			serviceNotNull.Run(workflowInstance);
		}
		catch (Exception ex2)
		{
			if (ex2.InnerException != null)
			{
				base.Notifier.Error(ex2.InnerException.Message);
			}
			else
			{
				base.Notifier.Error(ex2.Message);
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Home", "Page", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			});
		}
		WorkflowQueueService.WaitWhileQueued(workflowInstance);
		IList<IWorkflowTaskBase> list = WorkflowTaskBaseManager.FindMyActiveTasks(workflowInstance, allowSubInstances: true);
		if (list.Count > 0)
		{
			UrlHelper url = new UrlHelper(((ControllerBase)this).get_ControllerContext().get_RequestContext());
			return (ActionResult)(object)((Controller)this).Redirect(WorkflowLinkHelper.TaskUrl(url, list[0]));
		}
		base.Notifier.HtmlAction("ExecuteInfo", "WorkflowInstance", new RouteValueDictionary(new
		{
			area = "EleWise.ELMA.Workflow.Web",
			id = workflowInstance.Id
		}));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Home", "Page", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Content"
		});
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		if (!base.DynamicViewHelper.NeedRenderView)
		{
			return (ActionResult)(object)((Controller)this).PartialView();
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)base.Manager.CreateGridData(command));
	}

	[EntityListLink(typeof(IProcessHeader))]
	public ActionResult MyProcesses(MyProcessesInfo model)
	{
		HttpContextAccessor.CurrentContext.Items.Add("showFiltersTree", true);
		model.Headers = ProcessHeaderManager.Instance.GetProcessesInfo(null).ToList();
		model.Headers = SortHeaders(model.Headers);
		((Controller)(object)this).SetCurrentMenuItem("my-processes");
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	public ActionResult MyProcessesSettings()
	{
		base.AuthenticationService.GetCurrentUser<IUser>();
		List<ProcessHeaderInfo> infos = ProcessHeaderManager.Instance.GetProcessesInfo(null).ToList();
		infos = SortHeaders(infos);
		return (ActionResult)(object)((Controller)this).View((object)infos);
	}

	[HttpPost]
	public ActionResult MyProcessesSettings(string OrderValue)
	{
		string[] source = OrderValue.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		MyProcessesSettings myProcessesSettings = PersonalizationAdministration.LoadState<MyProcessesSettings>(currentUser.UserName, "MyProcessesSettings");
		if (myProcessesSettings == null)
		{
			myProcessesSettings = new MyProcessesSettings();
		}
		myProcessesSettings.ProcessHeaders = source.Select((string v) => Convert.ToInt64(v)).ToList();
		PersonalizationAdministration.SaveState(currentUser.UserName, "MyProcessesSettings", myProcessesSettings);
		return (ActionResult)(object)((Controller)this).RedirectToAction("MyProcesses");
	}

	[HttpGet]
	[AnyPermission(new string[] { "0B298062-9DE5-46E5-8D1D-C46B3680809A", "6F77877D-8DD0-42EF-ACC2-778C3103C169" })]
	public ActionResult Permissions()
	{
		ProcessHeadersTree processHeadersTree = BuildPermissionTree();
		return (ActionResult)(object)((Controller)this).View((object)processHeadersTree);
	}

	[HttpPost]
	public ActionResult PermissionTree(string query)
	{
		ProcessHeadersTree processHeadersTree = BuildPermissionTree();
		if (!string.IsNullOrWhiteSpace(query))
		{
			ApplyTreeFilter(processHeadersTree.Tree, query, null);
		}
		return (ActionResult)(object)((Controller)this).PartialView("HeaderTreeContent", (object)processHeadersTree);
	}

	[HttpGet]
	public ActionResult AccessGroups()
	{
		ProcessHeadersTree processHeadersTree = BuildAccessGroupTree();
		return (ActionResult)(object)((Controller)this).View((object)processHeadersTree);
	}

	[HttpPost]
	public ActionResult AccessGroupTree(string query)
	{
		ProcessHeadersTree processHeadersTree = BuildAccessGroupTree();
		if (!string.IsNullOrWhiteSpace(query))
		{
			ApplyTreeFilter(processHeadersTree.Tree, query, null);
		}
		return (ActionResult)(object)((Controller)this).PartialView("HeaderTreeContent", (object)processHeadersTree);
	}

	private ProcessHeadersTree BuildPermissionTree()
	{
		Func<long, string> createUrlAction = (long id) => ((Controller)this).get_Url().Action("EntityPermissionSettings", "PermissionManagment", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security",
			id = id,
			type = InterfaceActivator.TypeOf<IProcessHeader>().AssemblyQualifiedName
		});
		TreeModel treeModel = new TreeModel
		{
			Id = "ProcessHeadersTree",
			ActionName = "PermissionTree",
			ControllerName = "ProcessHeader",
			ShowExpandCollapseButtons = true,
			HtmlAttributes = new { }
		};
		return new ProcessHeadersTree
		{
			Tree = BuildProcessHeadersTree(treeModel, ProcessHeaderManager.GetPublishedProcessHeads, createUrlAction)
		};
	}

	private ProcessHeadersTree BuildAccessGroupTree()
	{
		TreeModel treeModel = new TreeModel
		{
			Id = "ProcessHeadersTree",
			ActionName = "AccessGroupTree",
			ControllerName = "ProcessHeader",
			ShowExpandCollapseButtons = true,
			HtmlAttributes = new { }
		};
		return new ProcessHeadersTree
		{
			Tree = BuildProcessHeadersTree(treeModel, ProcessHeaderManager.GetRootProcessHeaders, (long id) => ((Controller)this).get_Url().Action("Edit", "ProcessAccessGroup", (object)new
			{
				processHeaderId = id
			}))
		};
	}

	private TreeModel BuildProcessHeadersTree(TreeModel treeModel, Func<IProcessGroup, IEnumerable<IProcessHeader>> getProcessHeaders, Func<long, string> createUrlAction)
	{
		TreeState treeState = TreePersonalizationAdministration.LoadState(treeModel.Id);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = treeModel.Id
			};
			TreePersonalizationAdministration.SaveState(treeModel.Id, treeState);
		}
		TreeMenuNode treeMenuNode = new TreeMenuNode
		{
			id = "RootProcessNode",
			text = SR.T("Все процессы"),
			icon = "#folder.svg",
			expanded = true
		};
		treeModel.Children.Add(treeMenuNode);
		IEnumerable<IProcessGroup> subGroups = ProcessGroupManager.LoadRootGroups();
		IEnumerable<IProcessHeader> processHeads = getProcessHeaders(null);
		FillGroupChilds(treeMenuNode, subGroups, processHeads, treeState, getProcessHeaders, createUrlAction);
		return treeModel;
	}

	private void FillGroupChilds(TreeMenuNode group, IEnumerable<IProcessGroup> subGroups, IEnumerable<IProcessHeader> processHeads, TreeState state, Func<IProcessGroup, IEnumerable<IProcessHeader>> getProcessHeaders, Func<long, string> createUrlAction)
	{
		foreach (IProcessGroup subGroup in subGroups)
		{
			string id = $"Group_{subGroup.Id}";
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				id = id,
				text = subGroup.Name,
				typeuid = ProcessGroupNode,
				icon = "#folder.svg",
				expanded = state[id]
			};
			IEnumerable<IProcessHeader> processHeads2 = getProcessHeaders(subGroup);
			FillGroupChilds(treeMenuNode, (IEnumerable<IProcessGroup>)subGroup.SubGroups, processHeads2, state, getProcessHeaders, createUrlAction);
			if (treeMenuNode.children.Count > 0)
			{
				group.children.Add(treeMenuNode);
			}
		}
		foreach (IProcessHeader processHead in processHeads)
		{
			FillProcessHeader(group, processHead, state, createUrlAction);
		}
	}

	private void FillProcessHeader(TreeMenuNode parentNode, IProcessHeader processHead, TreeState state, Func<long, string> createUrlAction)
	{
		string id = $"Header_{processHead.Id}";
		string href = createUrlAction(processHead.Id);
		TreeMenuNode treeMenuNode = new TreeMenuNode
		{
			id = id,
			text = processHead.Name,
			typeuid = ProcessHeaderNode,
			icon = "#process.svg",
			href = href,
			expanded = state[id]
		};
		foreach (IProcessHeader item in ((IEnumerable<IProcessHeader>)processHead.SubHeaders).Where((IProcessHeader a) => a.Status != WorkflowProcessStatus.Deleted))
		{
			FillProcessHeader(treeMenuNode, item, state, createUrlAction);
		}
		parentNode.children.Add(treeMenuNode);
	}

	public ActionResult CommonInfo(long id)
	{
		IProcessHeader processHeader = base.Manager.Load(id);
		ProcessGeneralInfo model = new ProcessGeneralInfo
		{
			Header = processHeader
		};
		IBPMNProcess iBPMNProcess = AbstractNHEntityManager<IBPMNProcess, long>.Instance.Load(processHeader.Published.Id);
		IResponsibilityMatrixItem responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).FirstOrDefault((IResponsibilityMatrixItem i) => i.ResponsibilityLevel == ResponsibilityLevel.Owner);
		if (responsibilityMatrixItem != null)
		{
			if (responsibilityMatrixItem.WorkerType == InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false) && responsibilityMatrixItem.WorkerId.HasValue)
			{
				IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(responsibilityMatrixItem.WorkerId.Value);
				if (organizationItem != null)
				{
					if (organizationItem.User != null)
					{
						model.OwnerUser = organizationItem.User;
					}
					else
					{
						model.OwnerOrganizationItem = organizationItem;
					}
				}
			}
			else if (responsibilityMatrixItem.WorkerType == InterfaceActivator.UID<IUserGroup>(loadImplementation: false) && responsibilityMatrixItem.WorkerId.HasValue)
			{
				model.OwnerUserGroup = UserGroupManager.Instance.Load(responsibilityMatrixItem.WorkerId.Value);
			}
		}
		((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).Where((IResponsibilityMatrixItem i) => i.IsCurator).ToList().ForEach(delegate(IResponsibilityMatrixItem curatorItem)
		{
			if (curatorItem.WorkerType == InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false) && curatorItem.WorkerId.HasValue)
			{
				IOrganizationItem organizationItem2 = OrganizationItemManager.Instance.LoadOrNull(curatorItem.WorkerId.Value);
				if (organizationItem2 != null)
				{
					if (organizationItem2.User != null)
					{
						model.CuratorUsers.Add(organizationItem2.User);
					}
					else
					{
						model.CuratorOrganizationItems.Add(organizationItem2);
					}
				}
			}
			else if (curatorItem.WorkerType == InterfaceActivator.UID<IUserGroup>(loadImplementation: false) && curatorItem.WorkerId.HasValue)
			{
				model.CuratorUserGroups.Add(UserGroupManager.Instance.Load(curatorItem.WorkerId.Value));
			}
		});
		return (ActionResult)(object)((Controller)this).PartialView((object)model);
	}

	public ActionResult StartProcessPortlet(StartProcessPortletPersonalization settings)
	{
		StartProcessPortletModel startProcessPortletModel = new StartProcessPortletModel();
		IOrderedEnumerable<ProcessGroupDTO> groups = from g in ProcessGroupManager.LoadGroupsTree()
			where !string.IsNullOrEmpty(g.Name)
			orderby g.Name.ToLower()
			select g;
		IOrderedEnumerable<IProcessHeader> processes = from h in ProcessHeaderManager.Instance.GetStartableProcesses()
			where !string.IsNullOrEmpty(h.Name)
			orderby h.Name.ToLower()
			select h;
		AddStartProcessPortletItems(startProcessPortletModel, new ProcessGroupDTO
		{
			Id = 0L,
			Name = SR.T("Процессы WorkFlow")
		}, groups, processes);
		return (ActionResult)(object)((Controller)this).PartialView("StartProcessPortlet", (object)startProcessPortletModel);
	}

	public ActionResult MyProcessesPortlet(MyProcessesPortletPersonalization settings)
	{
		MyProcessesInfo myProcessesInfo = new MyProcessesInfo();
		myProcessesInfo.InstanceGridPrefix = "ActiveInstancePortletGrid";
		myProcessesInfo.IsPortlet = true;
		if (settings.ViewMode != MyProcessesViewMode.ShowByFilter)
		{
			myProcessesInfo.Mode = MyProcessesInfo.ViewMode.List;
			myProcessesInfo.ShowStartDateColumn = false;
			myProcessesInfo.Headers = (from i in ProcessHeaderManager.Instance.GetProcessesInfo(null)
				where settings == null || settings.ViewMode == MyProcessesViewMode.ShowAll || settings.IsVisible(i.Id)
				select i).ToList();
			myProcessesInfo.Headers = SortHeaders(myProcessesInfo.Headers);
			myProcessesInfo.GridId = settings.InstanceId.ToString();
		}
		else
		{
			myProcessesInfo.Mode = MyProcessesInfo.ViewMode.Filter;
			myProcessesInfo.Filter = settings.GetFilter();
			if (myProcessesInfo.Filter != null)
			{
				myProcessesInfo.GridId = $"Portlet_{settings.InstanceId}_{myProcessesInfo.Filter.Id}";
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("MyProcessesView", (object)myProcessesInfo);
	}

	protected TreeModel BuidTree(string treeId, bool showAll)
	{
		TreeModel treeModel = new TreeModel();
		treeModel.Id = treeId ?? Guid.NewGuid().ToString();
		IOrderedEnumerable<ProcessGroupDTO> groups = from g in ProcessGroupManager.LoadGroupsTree()
			where !string.IsNullOrEmpty(g.Name)
			orderby g.Name.ToLower()
			select g;
		IEnumerable<IProcessHeader> enumerable2;
		if (!showAll)
		{
			IEnumerable<IProcessHeader> enumerable = from h in ProcessHeaderManager.Instance.GetStartableProcesses()
				where !string.IsNullOrEmpty(h.Name)
				orderby h.Name.ToLower()
				select h;
			enumerable2 = enumerable;
		}
		else
		{
			enumerable2 = ProcessHeaderManager.Instance.GetStartableProcessesAll();
		}
		IEnumerable<IProcessHeader> processes = enumerable2;
		AddGroupNodes(treeModel.Children, new ProcessGroupDTO
		{
			Id = 0L
		}, groups, processes);
		return treeModel;
	}

	protected void AddGroupNodes(List<TreeMenuNode> nodes, ProcessGroupDTO group, IEnumerable<ProcessGroupDTO> groups, IEnumerable<IProcessHeader> processes)
	{
		foreach (ProcessGroupDTO item2 in groups.Where((ProcessGroupDTO g) => g.ParentId == group.Id))
		{
			TreeMenuNode treeMenuNode = new TreeMenuNode
			{
				text = SR.T(item2.Name),
				id = $"EleWise.ELMA.Model.Entities.Workflow.ProcessGroup-{item2.Id}",
				icon = "#folder.svg",
				HtmlClass = new List<string> { "process-subGroup-icon" }
			};
			AddGroupNodes(treeMenuNode.children, item2, groups, processes);
			if (treeMenuNode.children.Any())
			{
				nodes.Add(treeMenuNode);
			}
		}
		HtmlHelper htmlHelper = GetHtmlHelper();
		foreach (IProcessHeader item3 in processes.Where((IProcessHeader h) => ((h.ParentGroup != null) ? h.ParentGroup.Id : 0) == group.Id))
		{
			TreeMenuNode item = new TreeMenuNode
			{
				text = GetProcessHeaderButtonWithMap(htmlHelper, item3),
				isHtml = true,
				id = $"EleWise.ELMA.Model.Entities.Workflow.ProcessHeader-{item3.Id}",
				icon = "#process.svg"
			};
			nodes.Add(item);
		}
	}

	protected void AddStartProcessPortletItems(StartProcessPortletModel model, ProcessGroupDTO group, IEnumerable<ProcessGroupDTO> groups, IEnumerable<IProcessHeader> processes)
	{
		StartProcessPortletModel.Group group2 = new StartProcessPortletModel.Group
		{
			Name = group.Name
		};
		foreach (IProcessHeader item in processes.Where((IProcessHeader h) => ((h.ParentGroup != null) ? h.ParentGroup.Id : 0) == group.Id))
		{
			group2.Headers.Add(item);
		}
		if (group2.Headers.Count > 0)
		{
			model.Groups.Add(group2);
		}
		foreach (ProcessGroupDTO item2 in groups.Where((ProcessGroupDTO g) => g.ParentId == group.Id))
		{
			AddStartProcessPortletItems(model, item2, groups, processes);
		}
	}

	public static List<ProcessHeaderInfo> SortHeaders(List<ProcessHeaderInfo> infos)
	{
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		MyProcessesSettings state = PersonalizationAdministration.LoadState<MyProcessesSettings>(currentUser.UserName, "MyProcessesSettings");
		if (state == null)
		{
			state = new MyProcessesSettings();
		}
		IEnumerable<ProcessHeaderInfo> source = infos.Where((ProcessHeaderInfo h) => state.ProcessHeaders.Count((long id) => id == h.Id) == 0);
		state.ProcessHeaders.AddRange(source.Select((ProcessHeaderInfo h) => h.Id));
		infos.ForEach(delegate(ProcessHeaderInfo h)
		{
			h.Order = state.ProcessHeaders.IndexOf(h.Id);
		});
		infos.Sort(new ProcessHeaderInfoComparer());
		return infos;
	}

	[AnyPermission(new string[] { "0B298062-9DE5-46E5-8D1D-C46B3680809A", "6F77877D-8DD0-42EF-ACC2-778C3103C169" })]
	[ContentItem(Name = "SR.M('Процессы')", Image24 = "#process.svg", Order = 80)]
	public ActionResult Settings()
	{
		return (ActionResult)(object)((Controller)this).View("ModuleSettingsPage", (object)ComponentManager.Current.GetExtensionPoints<IModuleSettingsProcessesPageProvider>().ToList());
	}

	public PartialViewResult HomePortlet(ProcessesHomePortletPersonalization settings)
	{
		ModuleSettingsPortletModel moduleSettingsPortletModel = new ModuleSettingsPortletModel
		{
			Providers = ComponentManager.Current.GetExtensionPoints<IModuleSettingsProcessesPageProvider>().ToList(),
			HeaderText = SR.T("Бизнес-процессы"),
			PortletCssClass = "border-green",
			PortletName = "ProcessesHome",
			HeaderUrl = (UrlHelper helper) => helper.Action("Settings", "ProcessHeader", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web"
			}),
			ImageUrl = (UrlHelper helper) => "#process.svg"
		};
		return ((Controller)this).PartialView("ModuleSettingsPortlet", (object)moduleSettingsPortletModel);
	}

	public ActionResult SelectorTree(string treeId, bool showAll)
	{
		TreeModel treeModel = BuidTree(treeId, showAll && base.SecurityService.HasPermission(PermissionProvider.ContentAdminPermission));
		return (ActionResult)(object)((Controller)this).PartialView("ContentSelectors/StartWorkflowSelectorTree", (object)treeModel);
	}

	private void AddContextViewItems(EntityMetadata metadata, List<Guid> visiblePropertyUids, FormViewItem view, RootViewItem parentViewItem)
	{
		foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
		{
			if (visiblePropertyUids != null && !visiblePropertyUids.Contains(propertiesAndTablePart.PropertyUid))
			{
				continue;
			}
			PropertyMetadata propertyMetadata = propertiesAndTablePart as PropertyMetadata;
			bool value = false;
			if (propertyMetadata != null && propertyMetadata.ViewSettings != null)
			{
				ViewAttribute forView = propertyMetadata.ViewSettings.GetForView(view.ViewType);
				if (!forView.Visible)
				{
					continue;
				}
				value = forView.ReadOnly;
			}
			PropertyViewItem propertyViewItem = new PropertyViewItem
			{
				Uid = propertiesAndTablePart.PropertyUid,
				PropertyUid = propertiesAndTablePart.PropertyUid,
				Attributes = 
				{
					ReadOnly = value
				}
			};
			parentViewItem.Items.Add(propertyViewItem);
			if (propertiesAndTablePart is TablePartMetadata metadata2)
			{
				AddContextViewItems(metadata2, visiblePropertyUids, view, propertyViewItem);
			}
		}
	}

	public ActionResult StartWorkflowParameters(long id)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(id);
		Type instanceContextType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextType(processHeader.Published);
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(instanceContextType);
		FormViewItem formViewItem = new FormViewItem
		{
			ViewType = ViewType.Edit
		};
		List<Guid> visiblePropertyUids = (from EntityPropertyMetadata p in entityMetadata.Properties
			where p.Input
			select p.Uid).ToList();
		AddContextViewItems(entityMetadata, visiblePropertyUids, formViewItem, formViewItem);
		return (ActionResult)(object)((Controller)this).PartialView("ContentSelectors/StartWorkflowParameters", (object)new StartWorkflowElementParametersModel
		{
			ContextDict = (IEntity)InterfaceActivator.Create(instanceContextType),
			View = formViewItem
		});
	}

	private string GetProcessHeaderButtonWithMap(HtmlHelper htmlHelper, IProcessHeader header)
	{
		string arg = htmlHelper.Button().AsLink().Attributes(new
		{
			@class = "process-map-link-button"
		})
			.Size(UISize.Small)
			.Url(((Controller)this).get_Url().Action("Map", (object)new
			{
				id = header.Id,
				inPopup = false
			}))
			.Click(string.Format("{0};return false;", htmlHelper.RefreshPopup("WorkflowHeaderMap", ((Controller)this).get_Url().Action("Map", (object)new
			{
				id = header.Id
			}))))
			.Text(SR.T("Карта"))
			.ToHtmlString();
		return $"<span class=\"item-name\">{HttpUtility.HtmlEncode(SR.T(header.Name))}</span> ({arg})";
	}
}
