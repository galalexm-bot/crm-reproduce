using System;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Models;

public class WebDocumentHelpButtonInfo
{
	private Lazy<IDocument> _document;

	private Lazy<string> _description;

	public IDocumentHelp Component { get; set; }

	public ClassMetadata Metadata { get; set; }

	public ITaskBase Task { get; set; }

	public IDocument Document
	{
		get
		{
			if (Component == null || Metadata == null)
			{
				return null;
			}
			if (_document == null)
			{
				_document = new Lazy<IDocument>(delegate
				{
					try
					{
						return Component.ResolveDocument(Metadata, Task);
					}
					catch (Exception)
					{
						return null;
					}
				});
			}
			return _document.Value;
		}
	}

	public string Description
	{
		get
		{
			if (Component == null || Metadata == null)
			{
				return null;
			}
			if (_description == null)
			{
				_description = new Lazy<string>(() => Component.GetDescription(Metadata, Task));
			}
			return _description.Value;
		}
	}

	public string HtmlAttributes { get; set; }

	public bool IsWebDocument
	{
		get
		{
			if (Document == null)
			{
				return false;
			}
			return WebDocumentManager.Instance.IsWebDocument(Document);
		}
	}

	public string PrepareUrl(HtmlHelper html)
	{
		if (Document.CurrentVersion == null)
		{
			return string.Empty;
		}
		if (!IsWebDocument)
		{
			return html.Url().Action("Download", "DocumentVersion", "EleWise.ELMA.Documents.Web", new
			{
				id = Document.CurrentVersion.Id
			});
		}
		return html.Url().Action("VersionInfo", "WebDocument", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = Document.CurrentVersion.Id,
			popupId = "HelpPopupDocument",
			@readonly = true
		});
	}
}
