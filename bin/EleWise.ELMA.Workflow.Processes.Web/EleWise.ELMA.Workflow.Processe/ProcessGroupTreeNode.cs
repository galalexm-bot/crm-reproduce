using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class ProcessGroupTreeNode
{
	protected const string RowTemplate = "{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"Owner\":\"{12}\",\"AvailableCount\":\"{3}\",\"AssignToMeCount\":\"{4}\",\"CompleteCount\":\"{5}\",\"InterruptedCount\":\"{6}\",\"isLeaf\":\"{7}\",\"parent\":\"{8}\",\"level\":\"{9}\", \"loaded\":\"true\",\"realid\":\"{10}\",\"expanded\":\"{11}\",\"uiicon\":\"\"}}";

	protected const string DocumentationRowTemplate = "{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"Owner\":\"{3}\",\"CreationAuthor\":\"{4}\",\"VersionNumber\":\"{5}\",\"DocumentationLink\":\"{6}\",\"isLeaf\":\"{7}\",\"parent\":\"{8}\",\"level\":\"{9}\", \"loaded\":\"true\",\"realid\":\"{10}\",\"expanded\":\"{11}\",\"uiicon\":\"\"}}";

	protected const string ImprovementRowTemplate = "{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"AvailableCount\":\"{3}\",\"CompleteCount\":\"{4}\",\"InterruptedCount\":\"{5}\",\"isLeaf\":\"{6}\",\"parent\":\"{7}\",\"level\":\"{8}\", \"loaded\":\"true\",\"realid\":\"{9}\",\"expanded\":\"{10}\",\"uiicon\":\"\"}}";

	public long Id { get; set; }

	public string Name { get; set; }

	public int TypeNode { get; set; }

	public ProcessHeaderInfo Info { get; set; }

	public DocumentationProcessHeaderInfo DocumentationInfo { get; set; }

	public ProcessGroupTreeNode ParentNode { get; set; }

	public List<ProcessGroupTreeNode> Nodes { get; set; }

	public bool ExpandAll { get; set; }

	public long GlobalIndex { get; set; }

	public ProcessGroupTreeNode()
	{
		Nodes = new List<ProcessGroupTreeNode>();
	}

	public string ToMonitorJson(UrlHelper helper)
	{
		return ToMonitorJson(helper, isEmulation: false);
	}

	public string ToMonitorJson(UrlHelper helper, bool isEmulation)
	{
		List<string> list = new List<string>();
		string text = ((!Nodes.Any()) ? "true" : "false");
		int num = 0;
		for (ProcessGroupTreeNode parentNode = ParentNode; parentNode != null; parentNode = parentNode.ParentNode)
		{
			num++;
		}
		string text2 = $"<span>{GetFolderIcon(helper)} {HttpUtility.JavaScriptStringEncode(Name)}</span>";
		string text3 = ((Info != null) ? Info.AvailableCount.ToString() : "");
		string text4 = ((Info != null) ? Info.AssignToMeCount.ToString() : "");
		string text5 = ((Info != null) ? Info.CompleteCount.ToString() : "");
		string text6 = ((Info != null) ? Info.InterruptedCount.ToString() : "");
		string text7 = ((Info != null && Info.OwnerName != null) ? HttpUtility.JavaScriptStringEncode(Info.OwnerName.Replace(Environment.NewLine, string.Empty)) : "");
		Guid guid;
		if (Info != null)
		{
			_ = Info.OwnerType;
			guid = Info.OwnerType;
		}
		else
		{
			guid = Guid.Empty;
		}
		Guid guid2 = guid;
		long num2 = ((Info != null) ? Info.OwnerId : 0);
		if (TypeNode == 1)
		{
			RouteValueDictionary routeValueDictionary = new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.Workflow.Processes.Web" },
				{ "InstanceFilter.ProcessHeader.Id", Id },
				{
					"InstanceFilter.__TypeName",
					InterfaceActivator.TypeOf<IWorkflowInstanceFilter>()
				},
				{ "InstanceFilter.IsEmulation", isEmulation }
			};
			RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Current
			} };
			RouteValueDictionary routeValueDictionary3 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Completed
			} };
			RouteValueDictionary routeValueDictionary4 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Terminated
			} };
			RouteValueDictionary routeValueDictionary5 = new RouteValueDictionary(routeValueDictionary2) { { "selectedTab", 1 } };
			text2 = ((Info == null || Info.Status != WorkflowProcessStatus.Deleted) ? string.Format("<a href='{2}'>{0} {1}</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Index", "Monitor", routeValueDictionary)) : string.Format("<a href='{2}' style='color:red;'>{0} {1} ({3})</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Index", "Monitor", routeValueDictionary), SR.T("удален")));
			text3 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Monitor", routeValueDictionary2), text3);
			text4 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Monitor", routeValueDictionary5), text4);
			text5 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Monitor", routeValueDictionary3), text5);
			text6 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Monitor", routeValueDictionary4), text6);
			text7 = ((guid2 == OrganizationItemDTO.MetadataUid) ? $"<a href='javascript:showUserInfo({num2});'>{text7}</a>" : text7);
		}
		list.Add(string.Format("{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"Owner\":\"{12}\",\"AvailableCount\":\"{3}\",\"AssignToMeCount\":\"{4}\",\"CompleteCount\":\"{5}\",\"InterruptedCount\":\"{6}\",\"isLeaf\":\"{7}\",\"parent\":\"{8}\",\"level\":\"{9}\", \"loaded\":\"true\",\"realid\":\"{10}\",\"expanded\":\"{11}\",\"uiicon\":\"\"}}", GlobalIndex, TypeNode, text2, text3, text4, text5, text6, text, (ParentNode != null) ? ParentNode.GlobalIndex.ToString() : "null", num, Id, (ParentNode == null || ExpandAll) ? "true" : "false", text7));
		list.AddRange(Nodes.Select((ProcessGroupTreeNode n) => n.ToMonitorJson(helper, isEmulation)));
		return string.Join(",", list);
	}

	public string ToDocumentationJson(UrlHelper helper)
	{
		List<string> list = new List<string>();
		string text = ((!Nodes.Any()) ? "true" : "false");
		int num = 0;
		for (ProcessGroupTreeNode parentNode = ParentNode; parentNode != null; parentNode = parentNode.ParentNode)
		{
			num++;
		}
		string text2 = $"<span>{GetFolderIcon(helper)} {HttpUtility.JavaScriptStringEncode(Name)}</span>";
		string text3 = ((DocumentationInfo != null && DocumentationInfo.WorkerName != null) ? HttpUtility.JavaScriptStringEncode(DocumentationInfo.WorkerName.Replace(Environment.NewLine, string.Empty)) : "");
		Guid? guid = ((DocumentationInfo != null && DocumentationInfo.WorkerType.HasValue) ? DocumentationInfo.WorkerType : new Guid?(Guid.Empty));
		long? num2 = ((DocumentationInfo != null && DocumentationInfo.WorkerId.HasValue) ? DocumentationInfo.WorkerId : new long?(0L));
		if (TypeNode == 1)
		{
			text2 = ((Info == null || Info.Status != WorkflowProcessStatus.Deleted) ? string.Format("<a href='{2}'>{0} {1}</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Folder", "Documentation", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web",
				id = Id
			})) : string.Format("<a href='{2}' style='color:red;'>{0} {1} ({3})</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Folder", "Documentation", (object)new
			{
				area = "EleWise.ELMA.Workflow.Processes.Web",
				id = Id
			}), SR.T("удален")));
			text3 = ((guid == OrganizationItemDTO.MetadataUid) ? $"<a href='javascript:showUserInfo({num2});'>{text3}</a>" : text3);
		}
		string text4 = ((DocumentationInfo != null) ? $"<a href='javascript:showUserInfo({DocumentationInfo.CreationAuthorId});'>{HttpUtility.JavaScriptStringEncode(DocumentationInfo.CreationAuthor.HtmlEncode())}</a>" : string.Empty);
		string text5 = ((DocumentationInfo != null && DocumentationInfo.VersionNumber > 0) ? DocumentationInfo.VersionNumber.ToString() : string.Empty);
		string text6 = ((DocumentationInfo != null && DocumentationInfo.CurrentVersionId > 0) ? $"{Path.GetDirectoryName(Locator.GetServiceNotNull<IRuntimeApplication>().Configuration.Config.FilePath)}/Documentation/{DocumentationInfo.CurrentVersionId}/index.html" : string.Empty);
		if (!File.Exists(text6))
		{
			text6 = string.Empty;
		}
		string text7 = ((DocumentationInfo != null && !string.IsNullOrEmpty(text6)) ? string.Format("<a href='{0}/index.html' target='_blank'>{1}</a>", helper.Action("View", "Documentation", (object)new
		{
			area = "EleWise.ELMA.Workflow.Processes.Web",
			id = DocumentationInfo.CurrentVersionId
		}), HttpUtility.JavaScriptStringEncode(SR.T("Документация"))) : string.Empty);
		list.Add(string.Format("{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"Owner\":\"{3}\",\"CreationAuthor\":\"{4}\",\"VersionNumber\":\"{5}\",\"DocumentationLink\":\"{6}\",\"isLeaf\":\"{7}\",\"parent\":\"{8}\",\"level\":\"{9}\", \"loaded\":\"true\",\"realid\":\"{10}\",\"expanded\":\"{11}\",\"uiicon\":\"\"}}", GlobalIndex, TypeNode, text2, text3, text4, text5, text7, text, (ParentNode != null) ? ParentNode.GlobalIndex.ToString() : "null", num, Id, (ParentNode == null) ? "true" : "false"));
		list.AddRange(Nodes.Select((ProcessGroupTreeNode n) => n.ToDocumentationJson(helper)));
		return string.Join(",", list);
	}

	public string ToImprovementJson(UrlHelper helper)
	{
		List<string> list = new List<string>();
		string text = ((!Nodes.Any()) ? "true" : "false");
		int num = 0;
		for (ProcessGroupTreeNode parentNode = ParentNode; parentNode != null; parentNode = parentNode.ParentNode)
		{
			num++;
		}
		string text2 = $"<span>{GetFolderIcon(helper)} {HttpUtility.JavaScriptStringEncode(Name)}</span>";
		string text3 = ((Info != null) ? Info.AvailableCount.ToString() : "");
		string text4 = ((Info != null) ? Info.CompleteCount.ToString() : "");
		string text5 = ((Info != null) ? Info.InterruptedCount.ToString() : "");
		if (TypeNode == 1)
		{
			RouteValueDictionary routeValueDictionary = new RouteValueDictionary
			{
				{ "area", "EleWise.ELMA.Workflow.Processes.Web" },
				{ "InstanceFilter.ImprovedProcessHeader.Id", Id }
			};
			RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Current
			} };
			RouteValueDictionary routeValueDictionary3 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Completed
			} };
			RouteValueDictionary routeValueDictionary4 = new RouteValueDictionary(routeValueDictionary) { 
			{
				"InstanceFilter.GeneralStatus",
				WorkflowInstanceGeneralStatus.Terminated
			} };
			text2 = ((Info == null || Info.Status != WorkflowProcessStatus.Deleted) ? string.Format("<a href='{2}'>{0} {1}</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Index", "Improvement", routeValueDictionary)) : string.Format("<a href='{2}' style='color:red;'>{0} {1} ({3})</a>", GetProcessIcon(helper), HttpUtility.JavaScriptStringEncode(Name), helper.Action("Index", "Improvement", routeValueDictionary), SR.T("удален")));
			text3 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Improvement", routeValueDictionary2), text3);
			text4 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Improvement", routeValueDictionary3), text4);
			text5 = string.Format("<a href='{0}'>{1}</a>", helper.Action("Index", "Improvement", routeValueDictionary4), text5);
		}
		list.Add(string.Format("{{\"id\":\"{0}\",\"TypeNode\":\"{1}\",\"Name\":\"{2}\",\"AvailableCount\":\"{3}\",\"CompleteCount\":\"{4}\",\"InterruptedCount\":\"{5}\",\"isLeaf\":\"{6}\",\"parent\":\"{7}\",\"level\":\"{8}\", \"loaded\":\"true\",\"realid\":\"{9}\",\"expanded\":\"{10}\",\"uiicon\":\"\"}}", GlobalIndex, TypeNode, text2, text3, text4, text5, text, (ParentNode != null) ? ParentNode.GlobalIndex.ToString() : "null", num, Id, (ParentNode == null) ? "true" : "false"));
		list.AddRange(Nodes.Select((ProcessGroupTreeNode n) => n.ToImprovementJson(helper)));
		return string.Join(",", list);
	}

	private string GetProcessIcon(UrlHelper helper)
	{
		return HtmlExtensions.Image(helper, "#process.svg", SR.T("Процесс"), "", new
		{
			align = "absmiddle",
			@class = "process-tree-icon"
		}).Replace("\"", "'");
	}

	private string GetFolderIcon(UrlHelper helper)
	{
		return HtmlExtensions.Image(helper, "#folder.svg", SR.T("Папка"), "", new
		{
			align = "absmiddle",
			@class = "process-tree-icon"
		}).Replace("\"", "'");
	}
}
