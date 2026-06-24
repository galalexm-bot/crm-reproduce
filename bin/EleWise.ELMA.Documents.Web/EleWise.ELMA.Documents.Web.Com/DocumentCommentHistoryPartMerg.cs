using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Components;

internal class DocumentCommentHistoryPartMerge : CommentAttachmentHistoryPartMerge
{
	protected override bool CheckEntity(HtmlHelper html, IEntity entity)
	{
		return entity is IDocument;
	}
}
