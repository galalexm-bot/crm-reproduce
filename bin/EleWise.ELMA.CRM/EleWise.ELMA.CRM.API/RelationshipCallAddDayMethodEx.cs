using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipCallAddDayMethodExecutor : RelationshipAddDayMethodExecutor<IRelationshipCall>
{
	public const string MethodName = "AddDayRelationshipCall";

	public static string MethodDescription => SR.T("Отложить звонок на день");

	public RelationshipCallAddDayMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
