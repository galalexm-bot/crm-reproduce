using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMeetingDeleteMethodExecutor : RelationshipDeleteMethodExecutor<IRelationshipMeeting>
{
	public const string MethodName = "DeleteRelationshipMeeting";

	public static string MethodDescription => SR.T("Удалить встречу");

	public RelationshipMeetingDeleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
