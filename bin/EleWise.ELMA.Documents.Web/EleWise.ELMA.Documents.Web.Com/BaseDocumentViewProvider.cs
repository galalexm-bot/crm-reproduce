using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 50)]
public class BaseDocumentViewProvider : IDocumentViewProvider
{
	public static Guid UID = new Guid("{441B0159-5AFF-41AD-8B6E-9F3447470319}");

	public Guid Uid => UID;

	public string DisplayName => SR.T("Расширенный вид");

	public string GetIconUrl(int size)
	{
		return "#extension_document_type.svg";
	}

	public bool CheckType(IDocument document)
	{
		return true;
	}

	public void Render<T>(HtmlHelper html, DocumentInfo viewModel) where T : class, IDocument
	{
		RenderPartialExtensions.RenderPartial(html, "Document/TabView", (object)viewModel.Entity);
	}
}
