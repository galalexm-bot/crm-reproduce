using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILeadContact))]
public interface ILeadContactFilter : IEntityFilter
{
	ILead Lead { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	DateTimeRange ChangeDate { get; set; }

	IUser ChangeAuthor { get; set; }
}
