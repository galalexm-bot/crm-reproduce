using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;

namespace EleWise.ELMA.DocumentGenerators;

[Component(Order = 300)]
public class TextDocumentGeneratorProvider : IDocumentGeneratorProvider
{
	public string[] SupportedExtensions => new string[3] { ".txt", ".xml", ".html" };

	public string SupportedFileTypesName => SR.T("Текстовые документы, HTML, XML");

	public DocumentGeneratorBase Create(string templateFileName, IGeneratorProvider provider = null)
	{
		return new TextDocumentGenerator(templateFileName, provider);
	}
}
