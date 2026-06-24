using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6")]
[Permission("E33F5F85-D627-41C0-A938-358C14811367")]
public class DocumentationController : BPMController<IProcessHeader, long>
{
	private const string jsonTempl = "{{\"records\":0,\"page\":0,\"total\":{0},\"rows\":[{1}]}}";

	public ProcessGroupManager ProcessGroupManager { get; set; }

	public ProcessHeaderManager ProcessHeaderManager { get; set; }

	public WorkflowProcessManager WorkflowProcessManager { get; set; }

	[ContentItem(Name = "SR.M('Документирование')", Image24 = "#moduledoc.svg", Order = 90)]
	public ActionResult ChapterIndex()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[ContentItem(Name = "SR.M('Мои процессы')", Image24 = "#process.svg", Order = 100)]
	public ActionResult Index()
	{
		DocumentationIndexModel documentationIndexModel = new DocumentationIndexModel
		{
			Headers = ProcessHeaderManager.Instance.LoadMyResponsibilityProcess().ToList()
		};
		documentationIndexModel.RoleInfos = ((documentationIndexModel.Headers.Count > 0) ? WorkflowProcessManager.GetResponsibilityMatrixItems(documentationIndexModel.Headers.Select((IProcessHeader p) => p.Published).ToList()).ToList() : new List<ProcessResponsibilityItemInfo>());
		return (ActionResult)(object)((Controller)this).View((object)documentationIndexModel);
	}

	public ActionResult Folder(long id)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)processHeader);
	}

	[CustomGridAction]
	public ActionResult VersionsGrid(GridCommand command, long id)
	{
		GridData<IWorkflowProcess> gridData = new GridData<IWorkflowProcess>
		{
			Command = command
		};
		IWorkflowProcessFilter filter = InterfaceActivator.Create<IWorkflowProcessFilter>();
		filter.Header = ProcessHeaderManager.Instance.Load(id);
		filter.NonZeroVersion = true;
		gridData.SetCount((GridData<IWorkflowProcess> d, FetchOptions f) => WorkflowProcessManager.Instance.Count(filter));
		gridData.SetDataSource((GridData<IWorkflowProcess> d, FetchOptions f) => (d.Count <= 0) ? new List<IWorkflowProcess>() : WorkflowProcessManager.Instance.Find(filter, f));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[Permission("168AC634-6688-427B-8D2E-B72CB6B00747")]
	[ContentItem(Name = "SR.M('Вся документация')", Image24 = "#moduledoc.svg", Order = 110)]
	public ActionResult FullIndex()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[Permission("168AC634-6688-427B-8D2E-B72CB6B00747")]
	public ActionResult FullTreeGrid(bool showDeleted = false)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		long nodeCount = 0L;
		List<ProcessGroupTreeNode> list = BuildMonitorTree(out nodeCount, showDeleted);
		ProcessGroupTreeNode treeModel = new ProcessGroupTreeNode
		{
			Name = SR.T("Все процессы"),
			Id = 0L,
			TypeNode = 0,
			Nodes = list,
			GlobalIndex = 0L
		};
		list.ForEach(delegate(ProcessGroupTreeNode t)
		{
			t.ParentNode = treeModel;
		});
		string arg = treeModel.ToDocumentationJson(((Controller)this).get_Url());
		string content = $"{{\"records\":0,\"page\":0,\"total\":{nodeCount},\"rows\":[{arg}]}}";
		ContentResult val = new ContentResult();
		val.set_ContentType("text/x-json;charset=utf-8");
		val.set_Content(content);
		return (ActionResult)val;
	}

	protected List<ProcessGroupTreeNode> BuildMonitorTree(out long nodeCount, bool showDeleted = false)
	{
		List<ProcessGroupDTO> groupTree = ProcessGroupManager.LoadGroupsTree().ToList();
		List<DocumentationProcessHeaderInfo> headerInfo = ((!showDeleted) ? (from x in ProcessHeaderManager.LoadDocumentationProcessHeadFullTree()
			where x.Status != WorkflowProcessStatus.Deleted
			select x) : ProcessHeaderManager.LoadDocumentationProcessHeadFullTree()).ToList();
		nodeCount = groupTree.Count + headerInfo.Count;
		List<ProcessGroupTreeNode> list = new List<ProcessGroupTreeNode>();
		int globalIndex = 1;
		Func<ProcessGroupDTO, ProcessGroupTreeNode, ProcessGroupTreeNode> makeGroupNode = null;
		Func<DocumentationProcessHeaderInfo, ProcessGroupTreeNode, ProcessGroupTreeNode> makeHeaderNode = null;
		makeHeaderNode = delegate(DocumentationProcessHeaderInfo head, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode treeNode2 = new ProcessGroupTreeNode
			{
				Id = head.Id,
				Info = new ProcessHeaderInfo
				{
					Id = head.Id,
					Name = SR.T(head.Name).HtmlEncode(),
					Status = head.Status
				},
				Name = SR.T(head.Name).HtmlEncode(),
				TypeNode = 1,
				DocumentationInfo = head,
				ParentNode = parent,
				GlobalIndex = globalIndex
			};
			globalIndex++;
			IEnumerable<DocumentationProcessHeaderInfo> source3 = headerInfo.Where((DocumentationProcessHeaderInfo h) => h.ParentProcessId == treeNode2.Id);
			treeNode2.Nodes.AddRange(source3.Select((DocumentationProcessHeaderInfo h) => makeHeaderNode(h, treeNode2)));
			return treeNode2;
		};
		makeGroupNode = delegate(ProcessGroupDTO group, ProcessGroupTreeNode parent)
		{
			ProcessGroupTreeNode treeNode = new ProcessGroupTreeNode
			{
				Id = group.Id,
				Name = SR.T(group.Name).HtmlEncode(),
				TypeNode = 0,
				ParentNode = parent,
				GlobalIndex = globalIndex
			};
			globalIndex++;
			IEnumerable<ProcessGroupDTO> source = groupTree.Where((ProcessGroupDTO n) => n.ParentId == treeNode.Id);
			treeNode.Nodes = source.Select((ProcessGroupDTO ch) => makeGroupNode(ch, treeNode)).ToList();
			IEnumerable<DocumentationProcessHeaderInfo> source2 = headerInfo.Where((DocumentationProcessHeaderInfo h) => h.ParentId == treeNode.Id);
			treeNode.Nodes.AddRange(source2.Select((DocumentationProcessHeaderInfo h) => makeHeaderNode(h, treeNode)));
			return treeNode;
		};
		IEnumerable<ProcessGroupTreeNode> collection = from g in groupTree
			where g.ParentId == 0
			select g into r
			select makeGroupNode(r, null);
		IEnumerable<ProcessGroupTreeNode> collection2 = from h in headerInfo
			where h.ParentId == 0L && h.ParentProcessId == 0
			select makeHeaderNode(h, null);
		list.AddRange(collection);
		list.AddRange(collection2);
		return list;
	}
}
