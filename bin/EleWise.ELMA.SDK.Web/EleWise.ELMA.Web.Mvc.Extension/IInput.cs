using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IInput
{
	Guid TypeUid { get; }

	MvcHtmlString Editor(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes);

	MvcHtmlString Display(HtmlHelper html, IPropertyMetadata metadata, ModelMetadata modelMetadata, string expression, ViewAttributes viewAttributes);
}
