using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Models;

public class CreateTaskHistoryModel : HistoryBaseModel, IAttachedHistoryModel, IHistoryBaseModel, ICreatedHistoryModel<ITask>, ITaskHistoryBaseModel
{
	public ICollection<IAttachment> Attachments { get; set; }

	public ITask Entity { get; set; }

	public CreateTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
