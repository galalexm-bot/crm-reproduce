using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentCommentHistoryPartProvider : CommentHistoryPartProviderBase
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IDocument;
	}

	protected override bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData)
	{
		return eventData is IDocumentHistoryBaseModel;
	}
}
