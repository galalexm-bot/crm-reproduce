using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Common.Models;

public class EditedEntityHistoryModel : EditedHistoryBaseModel<IEntity>
{
	public EditedEntityHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
