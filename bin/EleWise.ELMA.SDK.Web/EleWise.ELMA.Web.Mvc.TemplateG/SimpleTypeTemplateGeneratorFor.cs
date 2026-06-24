using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public class SimpleTypeTemplateGeneratorFormatter : ITemplateGeneratorFormatter
{
	private const string InputsKey = " EleWise.ELMA.Web.Mvc.TemplateGenerators.ITemplateInput";

	public string FormatValue(GenerationContext context, FormatedValue value, TemplateRenderMode renderMode)
	{
		object obj = ((value != null && value.Value != null) ? value.Value : null);
		if (obj == null)
		{
			return null;
		}
		PropertyMetadata propertyMetadata = null;
		if (value is MetadataBasedValue metadataBasedValue && metadataBasedValue.Format is MetadataBasedFormat metadataBasedFormat)
		{
			propertyMetadata = metadataBasedFormat.PropertyMetadata;
		}
		return FindInput(obj.GetType())?.FormatValue(obj, propertyMetadata, null, null, renderMode);
	}

	private static IEnumerable<ITemplateInput> GetInputs()
	{
		IEnumerable<ITemplateInput> enumerable;
		if (HttpContext.Current != null)
		{
			enumerable = (HttpContext.Current.Items.Contains(" EleWise.ELMA.Web.Mvc.TemplateGenerators.ITemplateInput") ? ((IEnumerable<ITemplateInput>)HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.ITemplateInput"]) : null);
			if (enumerable != null)
			{
				return enumerable;
			}
		}
		enumerable = ComponentManager.Current.GetExtensionPoints<ITemplateInput>();
		if (HttpContext.Current != null)
		{
			HttpContext.Current.Items[" EleWise.ELMA.Web.Mvc.TemplateGenerators.ITemplateInput"] = enumerable;
		}
		return enumerable;
	}

	private static ITemplateInput FindInput(Type itemType)
	{
		if (itemType == null)
		{
			return null;
		}
		IEnumerable<ITemplateInput> inputs = GetInputs();
		Guid itemTypeGuid = itemType.GUID;
		ITemplateInput templateInput = inputs.FirstOrDefault((ITemplateInput i) => i.TypeUid.Equals(itemTypeGuid));
		if (templateInput != null)
		{
			return templateInput;
		}
		return FindInput(itemType.BaseType);
	}
}
