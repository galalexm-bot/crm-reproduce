using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace EleWise.ELMA.Documents.Models;

[XmlRoot]
public class DocumentActionSettingsHolder
{
	[XmlArray]
	public List<DocumentChapterState> Chapters { get; set; }

	[XmlArray]
	public List<DocumentActionState> Actions { get; set; }

	public DocumentActionSettingsHolder()
	{
		Actions = new List<DocumentActionState>();
		Chapters = new List<DocumentChapterState>();
	}

	public bool ActionIsVisible(Guid action)
	{
		return ActionIsVisible(Guid.Empty, action);
	}

	public bool ChapterIsVisible(Guid chapter)
	{
		DocumentChapterState documentChapterState = Chapters.FirstOrDefault((DocumentChapterState a) => a.ChapterUid == chapter);
		if (documentChapterState != null)
		{
			if (documentChapterState.Visible.HasValue)
			{
				return documentChapterState.Visible.Value;
			}
			return false;
		}
		return true;
	}

	public bool ActionIsVisible(Guid? chapter, Guid action)
	{
		if (chapter.HasValue && chapter.Value != Guid.Empty && !ChapterIsVisible(chapter.Value))
		{
			return false;
		}
		DocumentActionState documentActionState = ((chapter.HasValue && chapter.Value != Guid.Empty) ? Actions.FirstOrDefault((DocumentActionState a) => a.ChapterUid == chapter.Value && a.ActionUid == action) : Actions.FirstOrDefault((DocumentActionState a) => a.ActionUid == action));
		if (documentActionState != null)
		{
			if (documentActionState.Visible.HasValue)
			{
				return documentActionState.Visible.Value;
			}
			return false;
		}
		return true;
	}
}
