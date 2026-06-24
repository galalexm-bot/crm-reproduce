using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentVersionDownloadAction : IDownloadBinaryFunction
{
	private DocumentVersionManager documentVersionManager;

	public DocumentVersionDownloadAction(DocumentVersionManager documentVersionManager)
	{
		this.documentVersionManager = documentVersionManager;
	}

	public void Execute(BinaryFile file)
	{
		if (file != null)
		{
			IDocumentVersion version = GetVersion(file);
			if (version != null && version.Document != null)
			{
				documentVersionManager.Download(version);
			}
		}
	}

	private IDocumentVersion GetVersion(BinaryFile file)
	{
		IDocumentVersionFilter documentVersionFilter = InterfaceActivator.Create<IDocumentVersionFilter>();
		documentVersionFilter.File = file;
		return documentVersionManager.Find(documentVersionFilter, FetchOptions.First).FirstOrDefault();
	}
}
