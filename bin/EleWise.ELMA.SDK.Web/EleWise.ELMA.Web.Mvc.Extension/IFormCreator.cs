using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFormCreator
{
	bool IsBase { get; }

	bool HideCreator { get; }

	bool CheckType(Type type);

	bool InitActionMap(Type type, Type controllerType);

	string Action(Type type);

	string Controller(Type type);

	RouteValueDictionary Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel);

	string ParameterName(Type type);

	string PostAction(Type type);

	string PostController(Type type);

	RouteValueDictionary PostRoute(Type type);

	string OnSubmitScript(HtmlHelper html, string prefix);

	string PopupHeader(Type type);

	IDictionary<string, object> GetServerParams(object container, IPropertyMetadata propertyMetadata);

	string GetParamsFunc(HtmlHelper html, string extprefix);
}
