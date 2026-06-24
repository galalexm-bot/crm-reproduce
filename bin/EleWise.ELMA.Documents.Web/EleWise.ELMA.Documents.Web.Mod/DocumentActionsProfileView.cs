using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentActionsProfileView : EntityModel<DocumentActionSettingsHolderView>
{
	private Lazy<List<DocumentActionChapterInfo>> _chapters;

	private Lazy<List<DocumentActionInfo>> _actions;

	protected List<DocumentActionChapterInfo> Chapters
	{
		get
		{
			if (_chapters == null)
			{
				_chapters = new Lazy<List<DocumentActionChapterInfo>>(() => ComponentManager.Current.GetExtensionPoints<IDocumentActionProvider>().SelectMany((IDocumentActionProvider p) => p.Groups).ToList());
			}
			return _chapters.Value;
		}
	}

	protected List<DocumentActionInfo> Actions
	{
		get
		{
			if (_actions == null)
			{
				_actions = new Lazy<List<DocumentActionInfo>>(() => ComponentManager.Current.GetExtensionPoints<IDocumentActionProvider>().SelectMany((IDocumentActionProvider p) => p.Actions).ToList());
			}
			return _actions.Value;
		}
	}

	public bool HasChapter(Guid chapterUid)
	{
		return Chapters.Any((DocumentActionChapterInfo ch) => ch.Uid == chapterUid);
	}

	public string GetChapterName(Guid chapterUid)
	{
		DocumentActionChapterInfo documentActionChapterInfo = Chapters.FirstOrDefault((DocumentActionChapterInfo ch) => ch.Uid == chapterUid);
		if (documentActionChapterInfo == null)
		{
			return string.Empty;
		}
		return documentActionChapterInfo.Name;
	}

	public bool HasAction(Guid chapterUid, Guid actionUid)
	{
		return Actions.Any((DocumentActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
	}

	public string GetActionName(Guid chapterUid, Guid actionUid)
	{
		DocumentActionInfo documentActionInfo = Actions.FirstOrDefault((DocumentActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
		if (documentActionInfo == null)
		{
			return string.Empty;
		}
		return documentActionInfo.ActionName;
	}

	public string GetActionImageUrl(HtmlHelper html, Guid chapterUid, Guid actionUid)
	{
		DocumentActionInfo documentActionInfo = Actions.FirstOrDefault((DocumentActionInfo a) => a.ActionChapterUid == chapterUid && a.ActionUid == actionUid);
		if (documentActionInfo == null)
		{
			return string.Empty;
		}
		if (!string.IsNullOrEmpty(documentActionInfo.Image))
		{
			return documentActionInfo.Image.Replace("{Local}", "~/Modules/EleWise.ELMA.Documents.Web/Content/Images/");
		}
		return null;
	}
}
