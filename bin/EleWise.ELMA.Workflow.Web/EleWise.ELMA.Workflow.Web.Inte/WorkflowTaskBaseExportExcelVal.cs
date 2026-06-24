using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration.Tasks;

[Component]
public class WorkflowTaskBaseExportExcelValueProvider : IExportExcelValueProvider
{
	private readonly Guid workflowBookmarkGuid = InterfaceActivator.PropertyUid((IWorkflowTaskBase t) => t.WorkflowBookmark);

	private readonly Dictionary<Guid, Func<IWorkflowBookmark, string>> fakePropertyUidToRealStringFunc = new Dictionary<Guid, Func<IWorkflowBookmark, string>>
	{
		{
			new Guid(CustomWorkflowTaskBaseColumns.InstanceName.UniqueName),
			(IWorkflowBookmark b) => b.Instance.InstanceName()
		},
		{
			new Guid(CustomWorkflowTaskBaseColumns.ProcessName.UniqueName),
			(IWorkflowBookmark b) => b.Instance.Process.Header.Name
		}
	};

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if (entity is IWorkflowTaskBase)
		{
			return fakePropertyUidToRealStringFunc.ContainsKey(propertyUid);
		}
		return false;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		if (!(((IWorkflowTaskBase)entity).GetPropertyValue(workflowBookmarkGuid) is IWorkflowBookmark arg))
		{
			return null;
		}
		return fakePropertyUidToRealStringFunc[propertyUid](arg);
	}
}
