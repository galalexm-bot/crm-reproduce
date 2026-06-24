using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMeetingChangeTimeMethodExecutor : RelationshipChangeTimeMethodExecutor<IRelationshipMeeting>
{
	public const string MethodName = "ChangeTimeRelationshipMeeting";

	public static string MethodDescription => SR.T("Изменить время встречи");

	public RelationshipMeetingChangeTimeMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
