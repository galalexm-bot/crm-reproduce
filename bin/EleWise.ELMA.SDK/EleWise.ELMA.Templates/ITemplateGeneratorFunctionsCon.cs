using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Templates;

[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ITemplateGeneratorFunctionsContainer
{
}
