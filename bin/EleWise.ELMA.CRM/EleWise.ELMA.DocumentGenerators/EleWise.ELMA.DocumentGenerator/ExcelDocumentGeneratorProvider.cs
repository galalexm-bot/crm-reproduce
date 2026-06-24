using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Cells;

namespace EleWise.ELMA.DocumentGenerators;

[Component(Order = 200)]
public class ExcelDocumentGeneratorProvider : IDocumentGeneratorProvider
{
	public string[] SupportedExtensions => new string[2] { ".xls", ".xlsx" };

	public string SupportedFileTypesName => SR.T("Документы Excel");

	public DocumentGeneratorBase Create(string templateFileName, IGeneratorProvider provider = null)
	{
		return new ExcelDocumentGenerator(templateFileName, provider);
	}
}
[Component(Order = 200)]
internal sealed class ExcelDocumentGeneratorProviderExtension : ExcelDocumentGeneratorProvider, IDocumentGeneratorProviderExtension, IDocumentGeneratorProvider
{
	public DocumentGeneratorBase Create(Stream templateFileStream, IGeneratorProvider provider = null)
	{
		return new ExcelDocumentGenerator(templateFileStream, provider);
	}
}
