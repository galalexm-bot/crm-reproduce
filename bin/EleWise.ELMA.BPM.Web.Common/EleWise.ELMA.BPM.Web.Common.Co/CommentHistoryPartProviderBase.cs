using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class CommentHistoryPartProviderBase : IHistoryPartProvider
{
	public const string HistoryPartType = "comment";

	public virtual IEnumerable<HistoryPartButton> GetButtons(HtmlHelper html, IEntity entity)
	{
		if (CheckEntity(html, entity))
		{
			yield return new HistoryPartButton
			{
				HistoryPartType = "comment",
				ImageUrl = html.Url().Image("#add.svg"),
				Index = 0,
				Text = SR.T("Комментарии")
			};
		}
	}

	protected abstract bool CheckEntity(HtmlHelper html, IEntity entity);

	protected virtual MvcHtmlString RenderDelegate(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is IMultiCommentHistoryModel)
		{
			ICollection<IComment> comments = ((IMultiCommentHistoryModel)eventData).Comments;
			if (comments != null && comments.Any())
			{
				return PartialExtensions.Partial(html, "HistoryParts/MultiComment", (object)eventData);
			}
		}
		if (eventData is ICommentedHistoryModel && ((ICommentedHistoryModel)eventData).Comment != null)
		{
			return PartialExtensions.Partial(html, "HistoryParts/Comment", (object)eventData);
		}
		return null;
	}

	public virtual IEnumerable<HistoryPartViewBlock> GetBlocks(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (CheckEventData(html, eventData))
		{
			yield return new HistoryPartViewBlock
			{
				HistoryPartType = "comment",
				Index = 0,
				RenderDelegate = RenderDelegate
			};
		}
	}

	protected virtual bool CheckEventData(HtmlHelper html, IHistoryBaseModel eventData)
	{
		if (eventData is ICommentedHistoryModel eventData2)
		{
			return CheckEventActionObject(html, eventData2);
		}
		return false;
	}

	protected abstract bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData);
}
