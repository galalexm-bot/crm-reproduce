using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates.TemplateGenerator;

[ExtensionPoint(ComponentType.All)]
public interface ITemplateGeneratorFormatter
{
	string FormatValue(GenerationContext context, FormatedValue value, TemplateRenderMode renderMode);
}
