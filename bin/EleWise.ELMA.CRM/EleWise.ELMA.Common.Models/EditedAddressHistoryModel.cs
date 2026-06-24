using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Common.Models;

public class EditedAddressHistoryModel : EditedEntityHistoryModel
{
	public ReferenceOnEntity SlaveObject { get; set; }

	public string SlavePropertyName { get; set; }

	public EditedAddressHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
