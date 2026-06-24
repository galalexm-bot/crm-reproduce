using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Components;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using EleWise.ELMA.Workflow.Web.Integration.Tasks;

namespace EleWise.ELMA.Workflow.Processes.Web;

[Component]
public class WorkflowExportExcelValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	private IEnumerable<IExportExcelValueProvider> exportExcelValueProviders;

	private readonly Guid ProcessNameUid = new Guid(CustomWorkflowInstanceColumns.ProcessName.UniqueName);

	private readonly Guid ProcessInstanceNameUid = new Guid(CustomWorkflowTaskBaseColumns.ProcessName.UniqueName);

	private readonly Guid currentOperationUid = new Guid(CustomWorkflowInstanceColumns.CurrentOperation.UniqueName);

	private readonly Dictionary<Guid, Guid> fakePropertyUidToRealPropertyUid = new Dictionary<Guid, Guid>
	{
		{
			new Guid(CustomWorkflowInstanceColumns.InstanceName.UniqueName),
			InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Name)
		},
		{
			new Guid(CustomWorkflowInstanceColumns.StartDate.UniqueName),
			InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.StartDate)
		},
		{
			new Guid(CustomWorkflowInstanceColumns.EndDate.UniqueName),
			InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.EndDate)
		},
		{
			new Guid(CustomWorkflowInstanceColumns.Responsible.UniqueName),
			InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Responsible)
		},
		{
			new Guid(CustomWorkflowTaskBaseColumns.InstanceName.UniqueName),
			InterfaceActivator.PropertyUid((IWorkflowInstance p) => p.Name)
		}
	};

	private EntityMetadata _workflowInstanceMetadata;

	private IEnumerable<IExportExcelValueProvider> ExportExcelValueProviders
	{
		get
		{
			if (exportExcelValueProviders == null)
			{
				Type type = GetType();
				exportExcelValueProviders = (from p in ComponentManager.Current.GetExtensionPoints<IExportExcelValueProvider>()
					where p.GetType() != type
					select p).ToArray();
			}
			return exportExcelValueProviders;
		}
	}

	private EntityMetadata WorkflowInstanceMetadata => _workflowInstanceMetadata ?? (_workflowInstanceMetadata = MetadataLoader.LoadMetadata(typeof(IWorkflowInstance)) as EntityMetadata);

	private string GetElementName(IWorkflowQueueItem item)
	{
		Element element = item.Instance.Process.Diagram.Elements.FirstOrDefault((Element e) => e.Uid == item.ElementUid);
		if (element == null)
		{
			return string.Empty;
		}
		return "-> " + element.Name;
	}

	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		return GetValueInternal(entity, propertyUid, cellStyle);
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if (!(entity is IWorkflowInstanceContext))
		{
			return false;
		}
		if (fakePropertyUidToRealPropertyUid.ContainsKey(propertyUid) || propertyUid == ProcessNameUid || propertyUid == ProcessInstanceNameUid || propertyUid == currentOperationUid)
		{
			return true;
		}
		return WorkflowInstanceMetadata.Properties.Any((PropertyMetadata a) => a.Uid == propertyUid);
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		return GetStyledValue(entity, propertyUid, null);
	}

	private object GetValueInternal(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		IWorkflowInstanceContext workflowInstanceContext = (IWorkflowInstanceContext)entity;
		if (propertyUid == ProcessNameUid || propertyUid == ProcessInstanceNameUid)
		{
			return SR.T(workflowInstanceContext.WorkflowInstance.Process.Header.Name);
		}
		if (propertyUid == currentOperationUid)
		{
			OperationsModel operationsModel = new OperationsModel(workflowInstanceContext.WorkflowInstance, init: true, initTasks: true);
			StringBuilder result = new StringBuilder();
			if (operationsModel.Tasks != null && operationsModel.Tasks.Any())
			{
				operationsModel.Tasks.ForEach(delegate(IWorkflowTaskBase a)
				{
					result.AppendLine($"{a.Subject}({((a.Executor != null) ? a.Executor.FullName : string.Empty)})");
				});
			}
			if (operationsModel.QueueItems != null && operationsModel.QueueItems.Any())
			{
				operationsModel.QueueItems.ForEach(delegate(IWorkflowQueueItem a)
				{
					result.AppendLine(GetElementName(a));
				});
			}
			if (operationsModel.MessageBookmarkInfos != null && operationsModel.MessageBookmarkInfos.Any())
			{
				operationsModel.MessageBookmarkInfos.ForEach(delegate(WorkflowMessageBookmarkInfo a)
				{
					result.AppendLine(string.Format("{0}{1}", a.ElementName, SR.T("Тип") + ": " + ((a.MessageType != null && !string.IsNullOrEmpty(a.MessageType.Name)) ? a.MessageType.Name : "") + ((!string.IsNullOrEmpty(a.ControlParameterValue)) ? ("; " + SR.T("Контрольный параметр") + ": " + a.ControlParameterValue) : "")));
				});
			}
			if (operationsModel.Timers != null && operationsModel.Timers.Any())
			{
				operationsModel.Timers.ForEach(delegate(WorkflowInstanceTimerInfo a)
				{
					result.AppendLine(string.Format("{0}({1})", a.ElementName, a.ExecuteTime.HasValue ? a.ExecuteTime.Value.ToString("g") : SR.T("<Время не определено>")));
				});
			}
			if (operationsModel.SubInstances != null && operationsModel.SubInstances.Any())
			{
				operationsModel.SubInstances.ForEach(delegate(IWorkflowInstance a)
				{
					result.AppendLine($"{a.Name}({a.Process.Header.Name})");
				});
			}
			return result.ToString();
		}
		Guid value;
		return GetValueFromProvider(workflowInstanceContext.WorkflowInstance, fakePropertyUidToRealPropertyUid.TryGetValue(propertyUid, out value) ? value : propertyUid, cellStyle);
	}

	private object GetValueFromProvider(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		IExportExcelValueProvider exportExcelValueProvider = ExportExcelValueProviders.FirstOrDefault((IExportExcelValueProvider p) => p.Resolve(entity, propertyUid));
		bool flag = exportExcelValueProvider != null && exportExcelValueProvider is IExportExcelStyledValueProvider;
		if (cellStyle != null && !flag)
		{
			cellStyle.set_IsTextWrapped(true);
		}
		if (exportExcelValueProvider == null)
		{
			return entity.GetPropertyValue(propertyUid);
		}
		if (!flag || cellStyle == null)
		{
			return exportExcelValueProvider.GetValue(entity, propertyUid).CastAsRealType();
		}
		return ((IExportExcelStyledValueProvider)exportExcelValueProvider).GetStyledValue(entity, propertyUid, cellStyle).CastAsRealType();
	}
}
