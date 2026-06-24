using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMeetingCompleteMethodExecutor : RelationshipBaseMethodExecutor<IRelationshipMeeting>
{
	public const string MethodName = "CompleteRelationshipMeeting";

	public static string MethodDescription => SR.T("Закрыть взаимоотношение");

	public RelationshipMeetingCompleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
