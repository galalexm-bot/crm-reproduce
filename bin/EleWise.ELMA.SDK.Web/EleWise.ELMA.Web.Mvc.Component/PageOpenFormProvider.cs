using System;
using System.Linq;
using System.Reflection;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = 10)]
internal class PageOpenFormProvider : IOpenFormProvider
{
	private static string _methodName;

	private static string _areaName;

	private static string _paramName;

	public bool CheckType(Guid typeUid)
	{
		return typeUid == PageMetadata.TypeUid;
	}

	public EntityFormInfo GetFormInfo(Guid typeUid, IEntity entity, FormBindingModel formBindingModel, string viewItemId)
	{
		if (string.IsNullOrEmpty(_methodName))
		{
			MethodInfo methodInfo = null;
			MethodInfo[] methods = typeof(UIController).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
			foreach (MethodInfo methodInfo2 in methods)
			{
				EntityFormAttribute attribute = AttributeHelper<EntityFormAttribute>.GetAttribute(methodInfo2, inherited: false);
				if (attribute != null)
				{
					_methodName = methodInfo2.Name;
					_areaName = attribute.AreaName;
					methodInfo = methodInfo2;
					break;
				}
			}
			if (methodInfo == null)
			{
				return null;
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length != 0)
			{
				ParameterInfo parameterInfo = parameters.FirstOrDefault((ParameterInfo q) => AttributeHelper<ParameterContainerAttribute>.GetAttribute(q, inherited: false) != null);
				if (parameterInfo != null)
				{
					_paramName = parameterInfo.Name;
				}
			}
			if (string.IsNullOrEmpty(_paramName))
			{
				return null;
			}
		}
		RouteValueDictionary route = new RouteValueDictionary
		{
			{ "area", _areaName },
			{
				_paramName,
				new ParameterContainer(entity)
			},
			{ "headerUid", formBindingModel.HeaderUid },
			{ "map", formBindingModel.FormPropertyMap }
		};
		return new EntityFormInfo
		{
			Action = _methodName,
			Controller = "UI",
			Route = route,
			ReadOnly = true
		};
	}
}
