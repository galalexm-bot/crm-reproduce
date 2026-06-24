using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Component(Order = 500)]
public class FormCreator : IFormCreator
{
	private class ActionMap
	{
		public string Action;

		public string Controller;

		public string PostAction;

		public string PostController;

		public string AreaName;

		public string ParameterContainerName;

		public RouteValueDictionary PostRoute;

		public IEntityMetadata Metadata;
	}

	private ConcurrentDictionary<Type, ActionMap> actionMapDictionary = new ConcurrentDictionary<Type, ActionMap>();

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public virtual bool IsBase => false;

	public virtual bool HideCreator => false;

	public virtual bool CheckType(Type type)
	{
		if (actionMapDictionary.ContainsKey(type))
		{
			return true;
		}
		IEntityMetadata entityMetadata = MetadataLoader.LoadMetadata(type) as IEntityMetadata;
		if (entityMetadata == null)
		{
			return false;
		}
		Type typeByUidOrNull = MetadataRuntimeService.GetTypeByUidOrNull(entityMetadata.GetImplementationUid(), loadImplementation: false);
		if (typeByUidOrNull == null)
		{
			return false;
		}
		while (entityMetadata != null && entityMetadata.GetBaseClassUid() != Guid.Empty)
		{
			entityMetadata = MetadataLoader.LoadMetadata(entityMetadata.GetBaseClassUid()) as IEntityMetadata;
		}
		if (entityMetadata == null)
		{
			return false;
		}
		IRuntimeTypeDescriptor runtimeTypeDescriptor = ((entityMetadata is IEntityIdentifier entityIdentifier) ? (MetadataRuntimeService.GetIdTypeDescriptor(entityIdentifier.IdTypeUid) as IRuntimeTypeDescriptor) : null);
		Type type2 = typeof(IBaseController<, >).MakeGenericType(typeByUidOrNull, (runtimeTypeDescriptor != null) ? runtimeTypeDescriptor.RuntimeType : ModelHelper.GetEntityIdType(ModelHelper.GetEntityType(entityMetadata.Uid)));
		Type type3 = ComponentManager.Current.GetExtensionPointTypes(type2).FirstOrDefault();
		if (type3 != null)
		{
			return InitActionMap(type, type3);
		}
		return false;
	}

	public bool InitActionMap(Type type, Type controllerType)
	{
		if (actionMapDictionary.ContainsKey(type))
		{
			return true;
		}
		MethodInfo methodInfo = null;
		EntityFormAttribute entityFormAttribute = null;
		MethodInfo[] methods = controllerType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		foreach (MethodInfo methodInfo2 in methods)
		{
			entityFormAttribute = AttributeHelper<EntityFormAttribute>.GetAttribute(methodInfo2, inherited: false);
			if (entityFormAttribute != null)
			{
				methodInfo = methodInfo2;
				break;
			}
		}
		if (entityFormAttribute == null)
		{
			return false;
		}
		ActionMap actionMap = new ActionMap
		{
			Action = methodInfo.Name,
			Controller = controllerType.Name.Replace("Controller", ""),
			PostAction = entityFormAttribute.PostAction
		};
		ParameterInfo[] parameters = methodInfo.GetParameters();
		if (parameters.Length != 0)
		{
			ParameterInfo parameterInfo = parameters.FirstOrDefault((ParameterInfo q) => AttributeHelper<ParameterContainerAttribute>.GetAttribute(q, inherited: false) != null);
			if (parameterInfo != null)
			{
				actionMap.ParameterContainerName = parameterInfo.Name;
			}
		}
		actionMap.PostController = actionMap.Controller;
		actionMap.AreaName = entityFormAttribute.AreaName;
		actionMap.PostRoute = new RouteValueDictionary(new
		{
			area = entityFormAttribute.AreaName
		});
		actionMap.Metadata = MetadataLoader.LoadMetadata(type) as IEntityMetadata;
		return actionMapDictionary.TryAdd(type, actionMap);
	}

	public virtual string Action(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.Action;
	}

	public virtual string Controller(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.Controller;
	}

	public virtual string ParameterName(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.ParameterContainerName;
	}

	public virtual RouteValueDictionary Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "uid", bindingModel.TypeUid },
			{ "prefix", prefix },
			{ "formReadOnly", bindingModel.ReadOnly }
		};
		if (actionMapDictionary.TryGetValue(type, out var value))
		{
			routeValueDictionary["area"] = value.AreaName;
		}
		if (bindingModel.FormUid.HasValue)
		{
			routeValueDictionary.Add("formUid", bindingModel.FormUid.Value);
		}
		else
		{
			routeValueDictionary.Add("viewType", (!bindingModel.ViewType.HasValue) ? ViewType.Create : bindingModel.ViewType.Value);
		}
		string text = ParameterName(type);
		if (bindingModel.FormPropertyMap != null && entity != null)
		{
			PropertyMapItem propertyMapItem = bindingModel.FormPropertyMap.Items[0];
			IEntity entity2 = (IEntity)entity.GetPropertyValue(propertyMapItem.RightPropertyUid);
			if (entity2 == null)
			{
				return routeValueDictionary;
			}
			routeValueDictionary.Add("id", (long)entity2.GetId());
			if (!string.IsNullOrEmpty(text))
			{
				routeValueDictionary.Add(text, new ParameterContainer(entity2.CastAsRealType()));
			}
		}
		else if (!string.IsNullOrEmpty(text))
		{
			routeValueDictionary.Add(text, new ParameterContainer(entity.CastAsRealType()));
		}
		return routeValueDictionary;
	}

	public virtual string PostAction(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.PostAction;
	}

	public virtual string PostController(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.PostController;
	}

	public virtual RouteValueDictionary PostRoute(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return null;
		}
		return value.PostRoute;
	}

	public virtual string OnSubmitScript(HtmlHelper html, string prefix)
	{
		return string.Empty;
	}

	public string PopupHeader(Type type)
	{
		if (!actionMapDictionary.TryGetValue(type, out var value))
		{
			return SR.T("Новая запись");
		}
		return SR.T("Работа с объектом \"{0}\"", value.Metadata.DisplayName);
	}

	public virtual IDictionary<string, object> GetServerParams(object container, IPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public virtual string GetParamsFunc(HtmlHelper html, string extprefix)
	{
		return null;
	}
}
