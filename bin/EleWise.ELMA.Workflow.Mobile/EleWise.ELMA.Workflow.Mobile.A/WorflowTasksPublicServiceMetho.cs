using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Workflow.API;

namespace EleWise.ELMA.Workflow.Mobile.API;

[Component]
internal class WorflowTasksPublicServiceMethodsProvider : IPublicServiceMethodsProvider
{
	private static IEnumerable<IPublicServiceMethod> methods = new PublicServiceMethod[3]
	{
		new PublicServiceMethod(WorkflowPublicService.UID, "StartableProcessesFromExternalApps", StartableProcessesFromExternalAppsMethodExecutor.Description, new Version(1, 0, 0), (WebData data) => new StartableProcessesFromExternalAppsMethodExecutor(data))
		{
			ParametersDescriptor = StartableProcessesFromExternalAppsMethodExecutor.ParametersDescriptor,
			ResultDescriptor = StartableProcessesFromExternalAppsMethodExecutor.ResultDescriptor
		},
		new PublicServiceMethod(WorkflowPublicService.UID, "HasDynamicForm", HasDynamicFormMethodExecutor.Description, new Version(1, 0, 3), (WebData data) => new HasDynamicFormMethodExecutor(data))
		{
			ParametersDescriptor = HasDynamicFormMethodExecutor.ParametersDescriptor,
			ResultDescriptor = HasDynamicFormMethodExecutor.ResultDescriptor
		},
		new PublicServiceMethod(WorkflowPublicService.UID, "HasDynamicForms", HasDynamicFormsMethodExecutor.Description, new Version(1, 0, 3), (WebData data) => new HasDynamicFormsMethodExecutor(data))
		{
			ParametersDescriptor = HasDynamicFormsMethodExecutor.ParametersDescriptor,
			ResultDescriptor = HasDynamicFormsMethodExecutor.ResultDescriptor
		}
	};

	public IEnumerable<IPublicServiceMethod> GetMethods()
	{
		return methods;
	}
}
