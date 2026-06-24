using System;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

[Service]
public class DocumentFileManager : IDocumentFileManager
{
	private readonly IMimeMappingService mimeMappingService;

	protected IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

	public DocumentFileManager(IMimeMappingService mimeMappingService)
	{
		this.mimeMappingService = mimeMappingService;
	}

	public BinaryFile GetFileByDocumentId(long documentId)
	{
		IDocument document = DocumentManager.Instance.LoadOrNull(documentId);
		if (document == null || document.CurrentVersion == null)
		{
			return null;
		}
		if (!WebDocumentManager.Instance.IsWebDocument(document))
		{
			return document.CurrentVersion.File;
		}
		if (document.CurrentVersion.Content == null)
		{
			return null;
		}
		try
		{
			return BinaryFile.CreateNew().Name($"{document.Name}.html").ContentType(mimeMappingService.GetTypeByExtension(".html"))
				.Content(Encoding.UTF8.GetBytes(document.CurrentVersion.Content.ToString()))
				.Build();
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return null;
		}
	}
}
