using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

public static class CustomWorkflowInstanceColumns
{
	public static readonly CustomColumnDescriptor InstanceName = new CustomColumnDescriptor
	{
		UniqueName = InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Name).ToString(),
		DisplayName = SR.M("Название экземпляра"),
		SortExpression = "WorkflowInstance.Name",
		Sortable = true,
		Visible = true
	};

	public static readonly CustomColumnDescriptor ProcessName = new CustomColumnDescriptor
	{
		UniqueName = InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Process).ToString(),
		DisplayName = SR.M("Название процесса"),
		SortExpression = "WorkflowInstance.Process.Header.Name",
		Sortable = true,
		Visible = true
	};

	public static readonly CustomColumnDescriptor CurrentOperation = new CustomColumnDescriptor
	{
		UniqueName = new Guid("{F2BC28E0-81F3-4014-B4CB-37271EA06526}").ToString(),
		DisplayName = SR.M("Текущие задачи, операции, подпроцессы"),
		Visible = true
	};

	public static readonly CustomColumnDescriptor StartDate = new CustomColumnDescriptor
	{
		UniqueName = InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.StartDate).ToString(),
		DisplayName = SR.M("Дата запуска"),
		SortExpression = "WorkflowInstance.StartDate",
		Sortable = true,
		Visible = true
	};

	public static readonly CustomColumnDescriptor EndDate = new CustomColumnDescriptor
	{
		UniqueName = InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.EndDate).ToString(),
		DisplayName = SR.M("Дата завершения"),
		SortExpression = "WorkflowInstance.EndDate",
		Sortable = true,
		Visible = true
	};

	public static readonly CustomColumnDescriptor Responsible = new CustomColumnDescriptor
	{
		UniqueName = InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Responsible).ToString(),
		DisplayName = SR.M("Ответственный"),
		SortExpression = "WorkflowInstance.Responsible.FullName",
		Sortable = true,
		Visible = true
	};

	public static readonly CustomColumnDescriptor Map = new CustomColumnDescriptor
	{
		UniqueName = new Guid("{810BBEE9-7E58-4C94-940F-6712594C4FF8}").ToString(),
		DisplayName = SR.M("Карта"),
		Visible = true
	};

	public static List<CustomColumnDescriptor> GetAll()
	{
		return new List<CustomColumnDescriptor> { InstanceName, CurrentOperation, Map };
	}

	public static List<CustomColumnDescriptor> GetWorkflowInstanceColumns(GridState state)
	{
		List<CustomColumnDescriptor> all = GetAll();
		Type typeFromHandle = typeof(IWorkflowInstance);
		ClassMetadata metadata = MetadataLoader.LoadMetadata(typeFromHandle) as ClassMetadata;
		foreach (GridColumn defaultColumn in GridBuilderExtensions.GetDefaultColumns(typeFromHandle, metadata, state))
		{
			all.Add(new CustomColumnDescriptor
			{
				DisplayName = defaultColumn.Header.ToString(),
				Sortable = defaultColumn.Sortable,
				SortExpression = "WorkflowInstance." + defaultColumn.Name,
				UniqueName = defaultColumn.UniqueName
			});
		}
		return all;
	}
}
