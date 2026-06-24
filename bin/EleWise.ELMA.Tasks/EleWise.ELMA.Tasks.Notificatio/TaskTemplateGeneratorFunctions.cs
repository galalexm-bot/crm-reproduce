using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.Tasks.Notifications;

[Component]
public class TaskTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
{
	public static FormatedValue GetInformToExceptMembers(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count < 2 || context.Parameters[0] == null || context.Parameters[1] == null)
		{
			return null;
		}
		ITaskBase taskBase = context.Parameters[0].Value as ITaskBase;
		ITaskBase taskBase2 = context.Parameters[1].Value as ITaskBase;
		if (taskBase == null || taskBase2 == null)
		{
			return null;
		}
		return new FormatedValue(((IEnumerable<IUser>)taskBase.InformTo).Except((IEnumerable<IUser>)taskBase2.InformTo, new CollectionExtensions.DelegateComparer<IUser>((IUser f, IUser s) => f.Id == s.Id, (IUser u) => u.Id.GetHashCode())).ToList());
	}

	public static FormatedValue GetObjectTypeName(FunctionEvaluationContext context)
	{
		if (context.Parameters.Count == 0 || context.Parameters[0] == null)
		{
			return null;
		}
		if (!(context.Parameters[0].Value is IAccessRequestTask accessRequestTask) || !accessRequestTask.AccessRequestApproved.HasValue)
		{
			return null;
		}
		IEntityPermissionAccessRequestProvider entityPermissionAccessRequestProvider = AccessRequestTaskManager.Instance.GetEntityPermissionAccessRequestProvider(accessRequestTask);
		if (entityPermissionAccessRequestProvider == null)
		{
			return null;
		}
		return new FormatedValue(entityPermissionAccessRequestProvider.GetObjectTypeName(accessRequestTask.EntityReference.Object));
	}
}
