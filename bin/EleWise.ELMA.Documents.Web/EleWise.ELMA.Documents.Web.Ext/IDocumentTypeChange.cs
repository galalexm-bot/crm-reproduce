using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentTypeChange
{
	string GetScript();

	string GetCallScript();
}
