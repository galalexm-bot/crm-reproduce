using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 100)]
public class DocumentTitleResolver : IEntityTitleResolver
{
	public bool CheckType(IEntity entity)
	{
		return entity is IDocument;
	}

	public MvcHtmlString GetTitle(IEntity entity, UrlHelper helper)
	{
		IDocument document = (IDocument)entity;
		document.Name = document.Name.HtmlEncode();
		string text = FolderManager.Instance.GetFolderPath(document.Folder).HtmlEncode();
		return MvcHtmlString.Create(string.Format("<div><a target=\"_blank\" href=\"{3}\">{0}</a>{1}</div><div class=\"comment\">{2}</div>", HtmlExtensions.Image(helper.ObjectIcon(ObjectIconFormat.x16, document), new
		{
			align = "absmiddle",
			style = "padding-right:3px;"
		}), document.Name, text, helper.Action("View", "Document", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			id = document.Id
		})));
	}
}
