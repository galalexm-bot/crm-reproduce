using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMeetingAddDayMethodExecutor : RelationshipAddDayMethodExecutor<IRelationshipMeeting>
{
	public const string MethodName = "AddDayRelationshipMeeting";

	public static string MethodDescription => SR.T("Отложить встречу на день");

	public RelationshipMeetingAddDayMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
