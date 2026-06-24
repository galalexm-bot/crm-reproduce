using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipCallChangeTimeMethodExecutor : RelationshipChangeTimeMethodExecutor<IRelationshipCall>
{
	public const string MethodName = "ChangeTimeRelationshipCall";

	public static string MethodDescription => SR.T("Изменить время звонка");

	public RelationshipCallChangeTimeMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
