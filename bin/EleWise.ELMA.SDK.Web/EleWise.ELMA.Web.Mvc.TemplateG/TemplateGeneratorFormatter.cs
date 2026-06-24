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
public class TemplateGeneratorFormatter : ITemplateGeneratorFormatter
{
	private const string InputsKey = " EleWise.ELMA.Web.Mvc.TemplateGenerators.ITemplateInput";

	public string FormatValue(GenerationContext context, FormatedValue value, TemplateRenderMode renderMode)
	{
		if (value == null)
		{
			return null;
		}
		MetadataBasedFormat metadataBasedFormat = value.Format as MetadataBasedFormat;
		MetadataBasedValue metadataBasedValue = value as MetadataBasedValue;
		PropertyMetadata pm = metadataBasedFormat?.PropertyMetadata;
		if (metadataBasedFormat == null || pm == null)
		{
			return null;
		}
		IEnumerable<ITemplateInput> inputs = GetInputs();
		if (inputs == null || !inputs.Any())
		{
			return null;
		}
		ITemplateInput templateInput = inputs.FirstOrDefault((ITemplateInput i) => i.TypeUid == pm.TypeUid && i.SubTypeUids != null && i.SubTypeUids.Contains(pm.SubTypeUid));
		if (templateInput != null)
		{
			return templateInput.FormatValue(value.Value, pm, metadataBasedValue?.Container, metadataBasedValue?.ContainerMetadata, renderMode);
		}
		return inputs.FirstOrDefault((ITemplateInput i) => i.TypeUid == pm.TypeUid && i.SubTypeUids == null)?.FormatValue(value.Value, pm, metadataBasedValue?.Container, metadataBasedValue?.ContainerMetadata, renderMode);
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
}
