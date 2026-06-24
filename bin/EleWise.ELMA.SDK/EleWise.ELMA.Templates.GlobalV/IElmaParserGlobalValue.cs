using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator;

[ExtensionPoint(ComponentType.WebServer)]
public interface IElmaParserGlobalValue
{
	FormatedValue Parse(string[] propertyNames);
}
