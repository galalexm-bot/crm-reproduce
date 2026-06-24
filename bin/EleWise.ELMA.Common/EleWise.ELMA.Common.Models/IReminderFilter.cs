using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IReminder))]
public interface IReminderFilter : IEntityFilter
{
	ReferenceOnEntity RefObject { get; set; }

	DateTimeRange RemindDate { get; set; }

	string PropertyName { get; set; }

	bool? Posted { get; set; }

	IUser CreationAuthor { get; set; }

	IReminderFilter Template { get; set; }
}
