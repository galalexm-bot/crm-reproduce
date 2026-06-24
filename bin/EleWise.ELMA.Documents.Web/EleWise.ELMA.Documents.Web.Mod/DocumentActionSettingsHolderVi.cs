using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentActionSettingsHolderView
{
	public List<DocumentActionChapterStateInfo> Chapters { get; set; }

	public DocumentActionSettingsHolderView()
	{
		Chapters = new List<DocumentActionChapterStateInfo>();
	}

	public DocumentActionSettingsHolder GetHolder()
	{
		DocumentActionSettingsHolder documentActionSettingsHolder = new DocumentActionSettingsHolder();
		foreach (DocumentActionChapterStateInfo chapter in Chapters)
		{
			DocumentChapterState item = new DocumentChapterState
			{
				ChapterUid = chapter.ChapterUid,
				Visible = chapter.Visible
			};
			documentActionSettingsHolder.Chapters.Add(item);
			documentActionSettingsHolder.Actions.AddRange(chapter.Actions);
		}
		return documentActionSettingsHolder;
	}

	public static DocumentActionSettingsHolderView Create(DocumentActionSettingsHolder holder)
	{
		if (holder == null)
		{
			return null;
		}
		DocumentActionSettingsHolderView documentActionSettingsHolderView = new DocumentActionSettingsHolderView();
		foreach (DocumentChapterState chapter2 in holder.Chapters)
		{
			DocumentChapterState chapter = chapter2;
			DocumentActionChapterStateInfo item = new DocumentActionChapterStateInfo
			{
				ChapterUid = chapter.ChapterUid,
				Visible = chapter.Visible,
				Actions = holder.Actions.Where((DocumentActionState a) => a.ChapterUid == chapter.ChapterUid).ToList()
			};
			documentActionSettingsHolderView.Chapters.Add(item);
		}
		return documentActionSettingsHolderView;
	}
}
