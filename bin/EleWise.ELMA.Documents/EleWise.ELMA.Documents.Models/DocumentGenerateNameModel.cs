using System.Collections.Generic;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Templates;

namespace EleWise.ELMA.Documents.Models;

public class DocumentGenerateNameModel : GenerateTextModel
{
	public static Dictionary<string, string> AdditionalAttributes => new Dictionary<string, string> { 
	{
		"FileName",
		SR.T("Название файла")
	} };

	public IDocument Document { get; set; }

	public string FileName { get; set; }

	public override Dictionary<string, object> Properties => new Dictionary<string, object>
	{
		{
			"Document",
			MetadataServiceContext.Service.GetMetadata(InterfaceActivator.UID<IDocument>())
		},
		{
			"FileName",
			SR.T("Название файла")
		}
	};

	public DocumentGenerateNameModel()
	{
	}

	public DocumentGenerateNameModel(IDocument document)
	{
		Document = document;
	}
}
