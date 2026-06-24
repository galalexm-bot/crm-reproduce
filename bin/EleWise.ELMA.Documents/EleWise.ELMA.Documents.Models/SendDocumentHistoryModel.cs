using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class SendDocumentHistoryModel : HistoryBaseModel, IDocumentHistoryBaseModel, IHistoryBaseModel
{
	public IDocument Document { get; set; }

	public SendDocumentHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
