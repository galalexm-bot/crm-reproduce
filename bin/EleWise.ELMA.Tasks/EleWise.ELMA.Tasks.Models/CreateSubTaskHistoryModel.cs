using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Models;

public class CreateSubTaskHistoryModel : HistoryBaseModel, ICreatedHistoryModel<ITask>, IHistoryBaseModel, ITaskHistoryBaseModel
{
	public ITask Entity { get; set; }

	public IEnumerable<CreateSubTaskHistoryInfoModel> TasksInfo { get; set; }

	public CreateSubTaskHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
