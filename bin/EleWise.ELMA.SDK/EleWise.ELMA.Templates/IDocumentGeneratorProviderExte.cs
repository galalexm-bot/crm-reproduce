using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates;

[ExtensionPoint(ComponentType.All)]
public interface IDocumentGeneratorProviderExtension : IDocumentGeneratorProvider
{
	DocumentGeneratorBase Create(Stream templateFileStream, IGeneratorProvider provider = null);
}
