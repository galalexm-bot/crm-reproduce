using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceFilterPropertyTypeResolver : IFilterPropertyTypeResolver
{
	public bool CheckType(IFilter model)
	{
		if (model == null || model.ObjectsType == null)
		{
			return false;
		}
		return model.ObjectsType.TypeUid == InterfaceActivator.UID<IWorkflowInstance>();
	}

	public Dictionary<Guid, Type> GetFilterPropertyTypes(IFilter filter)
	{
		Dictionary<Guid, Type> dictionary = new Dictionary<Guid, Type>();
		if (filter.FilterFields == null)
		{
			return dictionary;
		}
		IWorkflowInstanceFilter workflowInstanceFilter = (IWorkflowInstanceFilter)UniversalFilterSaver.UnPack(filter.FilterFields);
		if (workflowInstanceFilter == null)
		{
			return dictionary;
		}
		if (workflowInstanceFilter.ProcessHeader == null || workflowInstanceFilter.ProcessHeader.Published == null)
		{
			return dictionary;
		}
		PropertyMetadata propertyMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IWorkflowInstanceFilter>())).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "ContextFilter");
		if (propertyMetadata == null)
		{
			return dictionary;
		}
		Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(workflowInstanceFilter.ProcessHeader.Published);
		if (instanceContextFilterType != null)
		{
			dictionary.Add(propertyMetadata.Uid, instanceContextFilterType);
			PropertyInfo reflectionProperty = workflowInstanceFilter.GetType().GetReflectionProperty(propertyMetadata.Name);
			if (reflectionProperty.GetValue(workflowInstanceFilter, null) == null)
			{
				reflectionProperty.SetValue(workflowInstanceFilter, InterfaceActivator.Create(instanceContextFilterType), null);
			}
		}
		return dictionary;
	}
}
