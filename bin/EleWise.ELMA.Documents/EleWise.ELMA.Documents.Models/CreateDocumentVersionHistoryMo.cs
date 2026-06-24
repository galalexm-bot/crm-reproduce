using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class CreateDocumentVersionHistoryModel : HistoryBaseModel, ICreatedHistoryModel<IDocumentVersion>, IHistoryBaseModel, IDocumentHistoryBaseModel
{
	public IDocumentVersion Entity { get; set; }

	public CreateDocumentVersionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
