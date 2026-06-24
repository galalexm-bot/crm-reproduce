using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMailAddDayMethodExecutor : RelationshipAddDayMethodExecutor<IRelationshipMail>
{
	public const string MethodName = "AddDayRelationshipMail";

	public static string MethodDescription => SR.T("Отложить письмо  на день");

	public RelationshipMailAddDayMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
