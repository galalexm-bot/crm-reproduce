using System;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Models;

public class VersionCreatorModel
{
	private bool _required;

	private Lazy<DocumentMetadata> _documentMetadata;

	public string UniquePrefix { get; set; }

	public string UseFilePropertyName { get; set; }

	public string TemplateIdPropertyName { get; set; }

	public IDocumentMetadataProfile Profile { get; set; }

	public IDocumentVersion Version { get; set; }

	public bool UseFile { get; set; }

	public long? SelectedTemplateId { get; set; }

	public bool Required
	{
		get
		{
			return _required;
		}
		set
		{
			_required = value;
		}
	}

	public DocumentMetadata DocumentMetadata
	{
		get
		{
			if (Version == null || Version.Document == null)
			{
				return null;
			}
			if (_documentMetadata == null)
			{
				_documentMetadata = new Lazy<DocumentMetadata>(() => (DocumentMetadata)MetadataLoader.LoadMetadata(Version.Document.CastAsRealType().GetType()));
			}
			return _documentMetadata.Value;
		}
	}

	public VersionCreatorModel()
	{
		UniquePrefix = UIExtensions.PrepareId(Guid.NewGuid().ToString());
	}
}
