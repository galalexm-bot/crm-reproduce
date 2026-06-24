using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate;

namespace EleWise.ELMA.Tasks;

[Component(Order = 9)]
public class TaskInstanceExpressionPermissionManagerBehaviorHack : EntityManagerBehavior
{
	public ISecurityService SecurityService { get; set; }

	private static bool Contains(ISet<EleWise.ELMA.Security.Models.IUser> collection, EleWise.ELMA.Security.Models.IUser user)
	{
		if (collection != null && ((ICollection<EleWise.ELMA.Security.Models.IUser>)collection).Count == 1)
		{
			return ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)collection).First() == user;
		}
		return false;
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		if (filter == null)
		{
			return;
		}
		ITaskBaseFilter taskBaseFilter = filter as ITaskBaseFilter;
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (currentUser != null && criteria.GetRootEntityTypeIfAvailable().IsInheritOrSame<ITaskBase>() && SecurityService.HasPermission(currentUser, PermissionProvider.AccessToAllTasks))
		{
			filter.DisableSecurity = true;
		}
		else if (!filter.DisableSecurity)
		{
			if (taskBaseFilter != null && (taskBaseFilter.CreationAuthor == currentUser || taskBaseFilter.Executor == currentUser || Contains(taskBaseFilter.InformTo, currentUser) || Contains(taskBaseFilter.Executors, currentUser) || Contains(taskBaseFilter.CreationAuthors, currentUser)))
			{
				filter.DisableSecurity = true;
			}
			else if (filter is ITaskFilter taskFilter && (taskFilter.ControlUser == currentUser || Contains(taskFilter.CurrentControllers, currentUser)))
			{
				filter.DisableSecurity = true;
			}
		}
	}
}
