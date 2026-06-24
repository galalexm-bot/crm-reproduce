using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public abstract class AbstractObjectCreator : IFormCreator
{
	public virtual bool HideCreator => false;

	public virtual bool IsBase => false;

	public abstract Guid CreatorUid { get; }

	public virtual string Action => null;

	public virtual string Controller => null;

	public virtual string PostAction => null;

	public virtual string PostController => null;

	public virtual object PostRoute => null;

	public abstract string PopupHeader { get; }

	public virtual string PopupWidth => null;

	public abstract bool CheckType(Type type);

	public bool InitActionMap(Type type, Type controllerType)
	{
		return false;
	}

	string IFormCreator.Action(Type type)
	{
		return Action;
	}

	string IFormCreator.Controller(Type type)
	{
		return Controller;
	}

	RouteValueDictionary IFormCreator.Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel)
	{
		return Route(type, prefix, entity, bindingModel);
	}

	public string ParameterName(Type type)
	{
		return null;
	}

	string IFormCreator.PostAction(Type type)
	{
		return PostAction;
	}

	string IFormCreator.PostController(Type type)
	{
		return PostController;
	}

	RouteValueDictionary IFormCreator.PostRoute(Type type)
	{
		return new RouteValueDictionary(PostRoute);
	}

	string IFormCreator.PopupHeader(Type type)
	{
		return PopupHeader;
	}

	public virtual string OnSubmitScript(HtmlHelper html, string prefix)
	{
		return string.Empty;
	}

	public virtual string GetParamsFunc(HtmlHelper html, string extprefix)
	{
		return null;
	}

	public virtual IDictionary<string, object> GetServerParams(object container, IPropertyMetadata propertyMetadata)
	{
		return null;
	}

	public virtual object GetRoute(Guid typeUid, string prefix)
	{
		return null;
	}

	public virtual RouteValueDictionary Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel)
	{
		return null;
	}

	public virtual bool HasPermission(Guid typeUid)
	{
		return true;
	}
}
