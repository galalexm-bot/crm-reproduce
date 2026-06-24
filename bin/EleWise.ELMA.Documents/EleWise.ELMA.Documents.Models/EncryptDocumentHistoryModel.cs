using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class EncryptDocumentHistoryModel : HistoryBaseModel, IDocumentHistoryBaseModel, IHistoryBaseModel
{
	public EncryptDocumentHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
