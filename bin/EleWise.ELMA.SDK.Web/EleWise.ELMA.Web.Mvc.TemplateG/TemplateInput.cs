using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public abstract class TemplateInput : ITemplateInput
{
	public abstract Guid TypeUid { get; }

	public virtual Guid[] SubTypeUids => null;

	public abstract string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode);
}
