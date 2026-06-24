using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Common.Models;

public class CreateEntityHistoryModel : HistoryBaseModel, ICreatedHistoryModel<IEntity<long>>, IHistoryBaseModel
{
	public IEntity<long> Entity { get; set; }

	public CreateEntityHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
