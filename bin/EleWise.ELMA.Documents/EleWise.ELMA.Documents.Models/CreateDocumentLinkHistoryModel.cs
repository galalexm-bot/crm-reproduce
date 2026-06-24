using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class CreateDocumentLinkHistoryModel : HistoryBaseModel, ICreatedHistoryModel<IDocumentLink>, IHistoryBaseModel, IDocumentHistoryBaseModel
{
	public IDocumentLink Entity { get; set; }

	public CreateDocumentLinkHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
