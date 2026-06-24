using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipCallCompleteMethodExecutor : RelationshipBaseMethodExecutor<IRelationshipCall>
{
	public const string MethodName = "CompleteRelationshipCall";

	public static string MethodDescription => SR.T("Закрыть взаимоотношение");

	public RelationshipCallCompleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
