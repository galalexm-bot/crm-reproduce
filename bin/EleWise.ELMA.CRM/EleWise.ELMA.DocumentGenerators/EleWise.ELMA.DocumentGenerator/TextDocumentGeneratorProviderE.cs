using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.DocumentGenerators;

[Component(Order = 300)]
internal sealed class TextDocumentGeneratorProviderExtension : TextDocumentGeneratorProvider, IDocumentGeneratorProviderExtension, IDocumentGeneratorProvider
{
	public DocumentGeneratorBase Create(Stream templateFileStream, IGeneratorProvider provider = null)
	{
		return new TextDocumentGenerator(templateFileStream, provider);
	}
}
