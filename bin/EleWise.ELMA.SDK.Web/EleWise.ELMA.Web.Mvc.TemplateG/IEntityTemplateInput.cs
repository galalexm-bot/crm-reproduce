using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityTemplateInput
{
	Type[] SupportedTypes { get; }

	string GetListSeparator(TemplateRenderMode renderMode);

	string FormatValue(object value, TemplateRenderMode renderMode);
}
