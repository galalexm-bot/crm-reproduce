using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.API;

public class RelationshipMailDeleteMethodExecutor : RelationshipDeleteMethodExecutor<IRelationshipMail>
{
	public const string MethodName = "DeleteRelationshipMail";

	public static string MethodDescription => SR.T("Удалить письмо");

	public RelationshipMailDeleteMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}
}
