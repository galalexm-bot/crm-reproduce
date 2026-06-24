using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Web.Integration;

[Component]
public class WorkflowStartEventFormProvider : IDynamicFormsProvider
{
	public static readonly Guid UID = new Guid("{0F137C67-7EEE-43b4-9479-354F34A2C58E}");

	public Guid Uid => UID;

	public Type GetEntityType(DynamicFormSettings settings)
	{
		return null;
	}

	public string GetPropertyValueChangeScriptName(IEntity entity, RootViewItem view, DynamicFormSettings settings, string propertyName)
	{
		long id = long.Parse(settings.DynamicFormsProviderData);
		IWorkflowTaskBase workflowTaskBase = (IWorkflowTaskBase)TaskBaseManager.Instance.Load(id);
		if (workflowTaskBase.WorkflowBookmark == null)
		{
			return null;
		}
		IWorkflowInstance instance = workflowTaskBase.WorkflowBookmark.Instance;
		if (Locator.GetService<IWorkflowScriptingService>() == null)
		{
			return null;
		}
		Type type = instance.Context.GetType();
		EntityMetadata entityMetadata = ((entity != null) ? ((EntityMetadata)MetadataLoader.LoadMetadata(entity.GetType())) : ((EntityMetadata)MetadataLoader.LoadMetadata(type)));
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == propertyName);
		if (propertyMetadata == null)
		{
			return null;
		}
		if (view == null)
		{
			return null;
		}
		PropertyViewItem propertyViewItem = view.FindItem((PropertyViewItem p) => p.PropertyUid == propertyMetadata.Uid);
		if (propertyViewItem == null || propertyViewItem.Attributes == null || string.IsNullOrEmpty(propertyViewItem.Attributes.OnChangeScriptName))
		{
			if (string.IsNullOrEmpty(propertyMetadata.OnChangeScriptName))
			{
				return null;
			}
			return propertyMetadata.OnChangeScriptName;
		}
		return propertyViewItem.Attributes.OnChangeScriptName;
	}

	public void ExecuteScript(IEntity entity, RootViewItem view, DynamicFormSettings settings, string scriptName, DynamicFormResultData resultData)
	{
		long id = long.Parse(settings.DynamicFormsProviderData);
		IWorkflowInstance workflowInstance = entity as IWorkflowInstance;
		WorkflowInstanceContext workflowInstanceContext = entity as WorkflowInstanceContext;
		ITablePartItem tablePartItem = entity as ITablePartItem;
		if (workflowInstance != null)
		{
			workflowInstanceContext = workflowInstance.Context;
			workflowInstance.Context.GetType();
		}
		else if (tablePartItem != null)
		{
			while (tablePartItem != null && tablePartItem.Parent != null)
			{
				workflowInstanceContext = tablePartItem.Parent as WorkflowInstanceContext;
				if (workflowInstanceContext != null)
				{
					break;
				}
				tablePartItem = tablePartItem.Parent as ITablePartItem;
			}
		}
		if (workflowInstance == null)
		{
			if (workflowInstanceContext == null)
			{
				return;
			}
			PropertyInfo property = workflowInstanceContext.GetType().GetProperty("WorkflowInstance");
			if (property == null)
			{
				return;
			}
			workflowInstance = property.GetValue(workflowInstanceContext, null) as IWorkflowInstance;
			if (workflowInstance == null)
			{
				workflowInstance = WorkflowInstanceManager.Instance.Create();
				property.SetValue(workflowInstanceContext, workflowInstance, null);
			}
			if (workflowInstance.Process == null)
			{
				workflowInstance.Process = WorkflowProcessManager.Instance.Load(id);
			}
			workflowInstance.Context = workflowInstanceContext;
			workflowInstanceContext.GetType();
		}
		IWorkflowScriptingService service = Locator.GetService<IWorkflowScriptingService>();
		if (service == null)
		{
			return;
		}
		EntityMetadata entityMetadata = ((entity != null) ? ((EntityMetadata)MetadataLoader.LoadMetadata(entity.GetType())) : null);
		RootViewItem formView = view;
		if (formView == null)
		{
			return;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (entity != null && entityMetadata is TablePartMetadata)
		{
			dictionary["item"] = entity;
		}
		service.ExecuteScript(workflowInstance, scriptName, dictionary, delegate(string name, Type type)
		{
			if (name == "form" && type.IsGenericType && type.GetGenericTypeDefinition() == typeof(FormViewBuilder<>))
			{
				IMetadata metadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]);
				return Activator.CreateInstance(type, formView, metadata);
			}
			return null;
		});
	}
}
