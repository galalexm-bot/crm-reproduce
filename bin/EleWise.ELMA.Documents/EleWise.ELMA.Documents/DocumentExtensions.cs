using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Managers.Filters;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents;

public static class DocumentExtensions
{
	public static List<IQuestion> GetQuestions(this IDocument document)
	{
		return QuestionManager.Instance.GetQuestions(document);
	}

	public static long GetQuestionsCount(this IDocument document)
	{
		return QuestionManager.Instance.GetQuestionsCount(document);
	}

	public static long GetLinksCount(this IDocument document)
	{
		return DocumentLinkManager.Instance.Count(new DocumentLinkFilter
		{
			Document = document,
			LinkType = DocumentLinkTypes.All
		});
	}

	public static string GetStringLinksCount(this IDocument document)
	{
		string text = document.GetLinksCount().ToString();
		foreach (IDocumentLinksCountExtension item in ComponentManager.Current.GetExtensionPoints<IDocumentLinksCountExtension>().ToList())
		{
			string text2 = item.StringLinksCount(document);
			if (!string.IsNullOrWhiteSpace(text2))
			{
				text = $"{text}/{text2}";
			}
		}
		return text;
	}

	public static bool HasCurrentVersion(this IDocument document)
	{
		return document.CurrentVersion != null;
	}
}
