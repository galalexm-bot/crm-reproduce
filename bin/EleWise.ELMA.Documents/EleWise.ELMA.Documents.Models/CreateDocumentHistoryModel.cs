using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class CreateDocumentHistoryModel : HistoryBaseModel, IAttachedHistoryModel, IHistoryBaseModel, ICreatedHistoryModel<IDocument>, IDocumentHistoryBaseModel
{
	public ICollection<IAttachment> Attachments { get; set; }

	public IDocument Entity { get; set; }

	public CreateDocumentHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
