using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentActionChapterStateInfo : DocumentChapterState
{
	public List<DocumentActionState> Actions { get; set; }

	public DocumentActionChapterStateInfo()
	{
		Actions = new List<DocumentActionState>();
	}
}
