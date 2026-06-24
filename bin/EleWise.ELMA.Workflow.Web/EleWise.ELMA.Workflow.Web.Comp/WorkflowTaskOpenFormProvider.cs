using System;
using System.Reflection;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Controllers;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(Order = 10)]
internal class WorkflowTaskOpenFormProvider : IOpenFormProvider
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static string _methodName;

	private static string _areaName;

	public WorkflowTaskOpenFormProvider(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	public bool CheckType(Guid typeUid)
	{
		Type typeByUidOrNull = metadataRuntimeService.GetTypeByUidOrNull(typeUid);
		if (typeByUidOrNull != null)
		{
			return typeof(IWorkflowInstanceContext).IsAssignableFrom(typeByUidOrNull);
		}
		return false;
	}

	public EntityFormInfo GetFormInfo(Guid typeUid, IEntity entity, FormBindingModel formBindingModel, string viewItemId)
	{
		if (string.IsNullOrEmpty(_methodName))
		{
			EntityFormAttribute entityFormAttribute = null;
			MethodInfo[] methods = typeof(WorkflowTaskController).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
			foreach (MethodInfo methodInfo in methods)
			{
				entityFormAttribute = AttributeHelper<EntityFormAttribute>.GetAttribute(methodInfo, inherited: false);
				if (entityFormAttribute != null)
				{
					_methodName = methodInfo.Name;
					break;
				}
			}
			if (entityFormAttribute == null)
			{
				return null;
			}
			_areaName = entityFormAttribute.AreaName;
		}
		EntityFormInfo entityFormInfo = new EntityFormInfo
		{
			Action = _methodName,
			Controller = "WorkflowTask",
			CreatorPrefix = "Bind" + UIExtensions.PrepareId(Guid.NewGuid().ToString())
		};
		entityFormInfo.Route = new RouteValueDictionary(new
		{
			area = _areaName,
			prefix = entityFormInfo.CreatorPrefix,
			id = long.Parse(viewItemId),
			formUid = formBindingModel.FormUid
		});
		return entityFormInfo;
	}
}
