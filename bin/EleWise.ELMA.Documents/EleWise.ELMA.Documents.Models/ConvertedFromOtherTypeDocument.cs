using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class ConvertedFromOtherTypeDocumentHistoryModel : ConvertedFromOtherTypeHistoryModel, IDocumentHistoryBaseModel, IHistoryBaseModel
{
	public ConvertedFromOtherTypeDocumentHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
