using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 40)]
public class WebDocumentViewProvider : IDocumentViewProvider
{
	public static Guid UID = new Guid("{C61F01BF-3E26-4414-BD58-0B1F5F2B20BA}");

	public Guid Uid => UID;

	public string DisplayName => SR.T("Простой вид");

	public string GetIconUrl(int size)
	{
		_ = 16;
		return "#webdoc.svg";
	}

	public bool CheckType(IDocument document)
	{
		return WebDocumentManager.Instance.IsWebDocument(document);
	}

	public void Render<T>(HtmlHelper html, DocumentInfo viewModel) where T : class, IDocument
	{
		RenderPartialExtensions.RenderPartial(html, "WebDocumentView", (object)viewModel);
	}
}
