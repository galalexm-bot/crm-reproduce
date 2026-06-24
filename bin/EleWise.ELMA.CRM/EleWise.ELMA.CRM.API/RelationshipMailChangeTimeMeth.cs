using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMailChangeTimeMethodExecutor : RelationshipChangeTimeMethodExecutor<IRelationshipMail>
{
	public const string MethodName = "ChangeTimeRelationshipMail";

	public static string MethodDescription => SR.T("Изменить время отправки письма");

	public RelationshipMailChangeTimeMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
