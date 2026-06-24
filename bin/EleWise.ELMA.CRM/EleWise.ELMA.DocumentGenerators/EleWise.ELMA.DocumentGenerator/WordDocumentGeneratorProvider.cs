using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Words;

namespace EleWise.ELMA.DocumentGenerators;

[Component(Order = 100)]
public class WordDocumentGeneratorProvider : IDocumentGeneratorProvider
{
	public string[] SupportedExtensions => new string[3] { ".doc", ".docx", ".rtf" };

	public string SupportedFileTypesName => SR.T("Документы Word");

	public DocumentGeneratorBase Create(string templateFileName, IGeneratorProvider provider = null)
	{
		return new WordDocumentGenerator(templateFileName, provider);
	}
}
