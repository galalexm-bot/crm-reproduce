using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IRelationshipMeeting))]
public interface IRelationshipMeetingFilter : IRelationshipFilter, IEntityFilter
{
	string Place { get; set; }

	bool? TimeNotSet { get; set; }
}
