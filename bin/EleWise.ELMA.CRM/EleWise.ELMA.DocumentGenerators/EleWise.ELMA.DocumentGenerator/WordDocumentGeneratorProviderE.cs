using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Words;

namespace EleWise.ELMA.DocumentGenerators;

[Component(Order = 100)]
internal sealed class WordDocumentGeneratorProviderExtension : WordDocumentGeneratorProvider, IDocumentGeneratorProviderExtension, IDocumentGeneratorProvider
{
	public DocumentGeneratorBase Create(Stream templateFileStream, IGeneratorProvider provider = null)
	{
		return new WordDocumentGenerator(templateFileStream, provider);
	}
}
