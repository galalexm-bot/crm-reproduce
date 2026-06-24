using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public class ReferenceOnEntityTemplateGeneratorFormatter : ITemplateGeneratorFormatter
{
	private const string InputsKey = " EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput";

	public string FormatValue(GenerationContext context, FormatedValue value, TemplateRenderMode renderMode)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		ReferenceOnEntity referenceOnEntity = ((value != null && value.Value != null) ? (value.Value as ReferenceOnEntity) : null);
		if (referenceOnEntity == null)
		{
			return null;
		}
		if (referenceOnEntity.ObjectType == null)
		{
			return null;
		}
		IEntity @object = referenceOnEntity.Object;
		if (@object != null)
		{
			IEntityTemplateInput entityTemplateInput = FindInput(@object.GetType());
			if (entityTemplateInput != null)
			{
				return entityTemplateInput.FormatValue(@object, renderMode);
			}
			string text = UrlExtensions.ObjectLink(new UrlHelper(HttpContext.Current.Request.RequestContext), @object);
			if (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			return $"<a href=\"{{#BaseUrl#}}{text}\">{@object}</a>";
		}
		return null;
	}

	private static IEnumerable<IEntityTemplateInput> GetInputs()
	{
		IEnumerable<IEntityTemplateInput> enumerable;
		if (HttpContext.Current != null)
		{
			enumerable = (HttpContext.Current.Items.Contains(" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput") ? ((IEnumerable<IEntityTemplateInput>)HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput"]) : null);
			if (enumerable != null)
			{
				return enumerable;
			}
		}
		enumerable = ComponentManager.Current.GetExtensionPoints<IEntityTemplateInput>();
		if (HttpContext.Current != null)
		{
			HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.IHtmlTemplateInput"] = enumerable;
		}
		return enumerable;
	}

	private static IEntityTemplateInput FindInput(Type itemType)
	{
		if (itemType == null)
		{
			return null;
		}
		IEntityTemplateInput entityTemplateInput = GetInputs().FirstOrDefault((IEntityTemplateInput i) => i.SupportedTypes.Contains(itemType));
		if (entityTemplateInput != null)
		{
			return entityTemplateInput;
		}
		return FindInput(itemType.BaseType);
	}
}
