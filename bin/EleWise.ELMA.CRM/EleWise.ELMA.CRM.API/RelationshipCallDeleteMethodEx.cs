using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipCallDeleteMethodExecutor : RelationshipDeleteMethodExecutor<IRelationshipCall>
{
	public const string MethodName = "DeleteRelationshipCall";

	public static string MethodDescription => SR.T("Удалить звонок");

	public RelationshipCallDeleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
