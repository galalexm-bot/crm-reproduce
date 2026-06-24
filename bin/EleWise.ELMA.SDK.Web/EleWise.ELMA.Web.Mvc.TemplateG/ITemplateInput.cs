using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITemplateInput
{
	Guid TypeUid { get; }

	Guid[] SubTypeUids { get; }

	string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode);
}
