using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.Templates;

[ExtensionPoint(ComponentType.All)]
public interface IDocumentGeneratorProvider
{
	string[] SupportedExtensions { get; }

	string SupportedFileTypesName { get; }

	DocumentGeneratorBase Create(string templateFileName, IGeneratorProvider provider = null);
}
