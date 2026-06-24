using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITextContentExtractor : IFileContentLoader
{
	string GetText(Stream stream);
}
