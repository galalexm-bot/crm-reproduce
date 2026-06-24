using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentHistoryProfileView : EntityModel<IDocumentHistoryProfile>
{
	private Lazy<List<IDocumentHistoryChapterInfo>> _chapters;

	private Lazy<List<IDocumentHistoryActionInfo>> _actions;

	protected List<IDocumentHistoryChapterInfo> Chapters
	{
		get
		{
			if (_chapters == null)
			{
				_chapters = new Lazy<List<IDocumentHistoryChapterInfo>>(() => ComponentManager.Current.GetExtensionPoints<IDocumentHistoryChapterInfo>().ToList());
			}
			return _chapters.Value;
		}
	}

	protected List<IDocumentHistoryActionInfo> Actions
	{
		get
		{
			if (_actions == null)
			{
				_actions = new Lazy<List<IDocumentHistoryActionInfo>>(() => ComponentManager.Current.GetExtensionPoints<IDocumentHistoryActionInfo>().ToList());
			}
			return _actions.Value;
		}
	}

	public bool HasChapter(Guid chapterUid)
	{
		return Chapters.Any((IDocumentHistoryChapterInfo ch) => ch.Uid == chapterUid);
	}

	public string GetChapterName(Guid chapterUid)
	{
		IDocumentHistoryChapterInfo documentHistoryChapterInfo = Chapters.FirstOrDefault((IDocumentHistoryChapterInfo ch) => ch.Uid == chapterUid);
		if (documentHistoryChapterInfo == null)
		{
			return string.Empty;
		}
		return documentHistoryChapterInfo.Name;
	}

	public bool HasAction(Guid chapterUid, Guid actionUid)
	{
		return Actions.Any((IDocumentHistoryActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
	}

	public string GetActionName(Guid chapterUid, Guid actionUid)
	{
		IDocumentHistoryActionInfo documentHistoryActionInfo = Actions.FirstOrDefault((IDocumentHistoryActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
		if (documentHistoryActionInfo == null)
		{
			return string.Empty;
		}
		return documentHistoryActionInfo.ActionName;
	}

	public string GetActionImageUrl(HtmlHelper html, Guid chapterUid, Guid actionUid)
	{
		IDocumentHistoryActionInfo documentHistoryActionInfo = Actions.FirstOrDefault((IDocumentHistoryActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
		if (documentHistoryActionInfo == null)
		{
			return string.Empty;
		}
		if (!string.IsNullOrEmpty(documentHistoryActionInfo.CustomImage))
		{
			return documentHistoryActionInfo.CustomImage;
		}
		return html.Url().Action("AuditAction", "Images", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			actionId = documentHistoryActionInfo.ActionUid
		});
	}
}
