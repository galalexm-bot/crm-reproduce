using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMailCompleteMethodExecutor : RelationshipBaseMethodExecutor<IRelationshipMail>
{
	public const string MethodName = "CompleteRelationshipMail";

	public static string MethodDescription => SR.T("Закрыть взаимоотношение");

	public RelationshipMailCompleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
