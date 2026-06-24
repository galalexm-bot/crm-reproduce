using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Web.Integration;

[Component]
public class WorkflowTaskFormProvider : IDynamicFormsProvider
{
	public static readonly Guid UID = new Guid("{F3E1B306-F6D0-454E-BC9B-11650BB29CD2}");

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
		IWorkflowTaskBase workflowTaskBase = (IWorkflowTaskBase)TaskBaseManager.Instance.Load(id);
		if (workflowTaskBase.WorkflowBookmark == null)
		{
			return;
		}
		IWorkflowInstance instance = workflowTaskBase.WorkflowBookmark.Instance;
		if (instance.Process.Context.ViewModelMetadata != null && view is FormViewItem formViewItem && formViewItem.RuntimeVersion == RuntimeVersion.Version2)
		{
			return;
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
		service.ExecuteScript(instance, scriptName, dictionary, delegate(string name, Type type)
		{
			if (name != "form")
			{
				return null;
			}
			if (CheckParameterType(type))
			{
				IMetadata metadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]);
				return Activator.CreateInstance(type, formView, metadata);
			}
			Type baseType = type.BaseType;
			if (baseType != null && CheckParameterType(baseType))
			{
				ClassMetadata classMetadata = MetadataLoader.LoadMetadata(baseType.GetGenericArguments()[0]) as ClassMetadata;
				ConstructorInfo constructorInfo = Array.Find(type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (ConstructorInfo ctorInfo) => ctorInfo.GetParameters().Length == 3);
				Type parameterType = constructorInfo.GetParameters()[0].ParameterType;
				object obj = Activator.CreateInstance(parameterType);
				parameterType.GetProperty("Model")?.SetValue(obj, instance.Context);
				return constructorInfo.Invoke(new object[3] { obj, formView, classMetadata });
			}
			return null;
		});
	}

	private static bool CheckParameterType(Type parameterType)
	{
		if (parameterType.IsGenericType)
		{
			return parameterType.GetGenericTypeDefinition() == typeof(FormViewBuilder<>);
		}
		return false;
	}
}
