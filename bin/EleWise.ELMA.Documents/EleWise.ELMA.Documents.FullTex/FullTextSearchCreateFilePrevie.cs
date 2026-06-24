using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
public class FullTextSearchCreateFilePreviewItemIndex : ICreateFilePreviewItemIndex
{
	private readonly Guid _previewItemIndexUid = new Guid("5C1D8BFB-CEED-4779-869E-1D702C0C2025");

	public Guid Uid => _previewItemIndexUid;

	public void AddPreviewToIndexQueue(BinaryFile file)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing || !serviceNotNull.Settings.IndexingVersion)
		{
			return;
		}
		IDocumentVersionFilter documentVersionFilter = InterfaceActivator.Create<IDocumentVersionFilter>();
		documentVersionFilter.File = file;
		IDocumentVersion documentVersion = DocumentVersionManager.Instance.Find(documentVersionFilter, new FetchOptions(0, 1)).FirstOrDefault();
		if (documentVersion != null && documentVersion.Document != null && documentVersion.Status == DocumentVersionStatus.Current)
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion)), documentVersion.Id));
			IndexQueueManager.Instance.AddReindexObjectPartItem(typeof(IDocumentsFullTextSearchObject), documentVersion.Document.Id, documentVersion.Document.TypeUid, list);
		}
	}
}
