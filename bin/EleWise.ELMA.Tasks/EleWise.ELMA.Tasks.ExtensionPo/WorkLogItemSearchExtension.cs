using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class WorkLogItemSearchExtension : IWorkLogItemSearchExtension
{
	public IAuthenticationService AuthenticationService { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public ITransformationProvider TransformationProvider { get; set; }

	[NotNull]
	public ISecurityService SecurityService { get; set; }

	public void SetupCriteria(ICriteria criteria, IWorkLogItemSearchFilter filter)
	{
		Conjunction val = Restrictions.Conjunction();
		SetupCriteria((Junction)(object)val, filter);
		criteria.Add((ICriterion)(object)val);
	}

	private void SetupCriteria(Junction junction, IWorkLogItemSearchFilter filter)
	{
		EleWise.ELMA.Security.Models.IUser user = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() ?? filter.WorkLogItemAuthors.FirstOrDefault();
		if (user == null)
		{
			throw new InvalidOperationException(SR.T("Текущий пользователь не может быть null"));
		}
		if (!filter.ShowDraft.HasValue || !filter.ShowDraft.Value)
		{
			junction.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)WorkLogItemStatus.Draft)));
		}
		if (filter.ObjectUids.HasItems())
		{
			junction.Add((ICriterion)(object)Restrictions.In("ObjectUID", (ICollection)filter.ObjectUids));
		}
		if (filter.ExcludeIds.HasItems())
		{
			junction.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In("Id", (ICollection)filter.ExcludeIds)));
		}
		if (filter.Ids.HasItems())
		{
			junction.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)filter.Ids));
		}
		DateTimeRange dateTimeRange = RelativeDateTimeDescriptor.GetDateTimeRange(filter.WorkLogItemDate);
		if (dateTimeRange.From.HasValue)
		{
			junction.Add((ICriterion)(object)Restrictions.Ge("Date", (object)dateTimeRange.From.Value.Date));
		}
		if (filter.WorkLogItemDate != null && dateTimeRange.To.HasValue)
		{
			junction.Add((ICriterion)(object)Restrictions.Le("Date", (object)dateTimeRange.To.Value.Date));
		}
		if (filter.WorkLogItemStatus.HasValue)
		{
			junction.Add((ICriterion)(object)Restrictions.Eq("Status", (object)filter.WorkLogItemStatus));
		}
		if (filter.WorkLogItemStatuses.HasItems())
		{
			junction.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)filter.WorkLogItemStatuses.Select((WorkLogItemStatus e) => e).ToArray()));
		}
		if (filter.WorkLogItemActivities != null)
		{
			junction.Add((ICriterion)(object)Restrictions.In("WorkLogActivity.Id", (ICollection)filter.WorkLogItemActivities.Select((IWorkLogActivity e) => e.Id).ToArray()));
		}
		if (filter.WorkLogItemHarmonizators != null)
		{
			junction.Add((ICriterion)(object)Restrictions.In("Harmonizator.Id", (ICollection)filter.WorkLogItemHarmonizators.Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		bool flag = filter.DisableSecurity || SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission);
		bool flag2 = filter.OnlyMy.HasValue && filter.OnlyMy.Value;
		bool flag3 = filter.MyDepartment.HasValue && filter.MyDepartment.Value;
		bool num = !flag2 && !flag3 && !flag;
		if (filter.WorkLogItemAuthors != null && filter.WorkLogItemAuthors.Count > 0)
		{
			junction.Add((ICriterion)(object)Restrictions.In("CreationAuthor.Id", (ICollection)filter.WorkLogItemAuthors.Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		bool flag4 = false;
		bool flag5 = false;
		if (!flag || flag2)
		{
			flag4 = true;
		}
		if ((!flag && !flag2) || flag3)
		{
			flag5 = true;
			if (!filter.MyDepartment.HasValue)
			{
				flag4 = true;
			}
		}
		Disjunction creationAuthorCondition = Restrictions.Disjunction();
		bool creationAuthorConditionExists = false;
		Action<ICriterion> action = delegate(ICriterion criterion)
		{
			((Junction)creationAuthorCondition).Add(criterion);
			creationAuthorConditionExists = true;
		};
		if (num)
		{
			action((ICriterion)(object)Restrictions.Eq("CreationAuthor.Id", (object)user.Id));
			action((ICriterion)(object)Restrictions.Eq("Harmonizator.Id", (object)user.Id));
		}
		if (flag4)
		{
			action((ICriterion)(object)Restrictions.Eq("CreationAuthor.Id", (object)user.Id));
		}
		if (flag5)
		{
			SqlSubQuery subordinateByUserQuery = GetSubordinateByUserQuery(user.Id);
			action((ICriterion)(object)Expression.Sql("{alias}.CreationAuthor in (" + subordinateByUserQuery.Sql + ")", subordinateByUserQuery.ParametersValues, subordinateByUserQuery.ParametersTypes));
		}
		if (creationAuthorConditionExists)
		{
			junction.Add((ICriterion)(object)creationAuthorCondition);
		}
		if (filter.WorkLogItemObjectId.HasValue)
		{
			junction.Add((ICriterion)(object)Restrictions.Eq("ObjectId", (object)filter.WorkLogItemObjectId.Value));
		}
		if (filter.WorkLogItemObjectTypeUid.HasValue)
		{
			junction.Add((ICriterion)(object)Restrictions.Eq("ObjectUID", (object)filter.WorkLogItemObjectTypeUid.Value));
		}
		if (filter.FilterList == null || !filter.FilterList.Any())
		{
			return;
		}
		Disjunction val = Restrictions.Disjunction();
		foreach (IWorkLogItemSearchFilter filter2 in filter.FilterList)
		{
			Conjunction val2 = Restrictions.Conjunction();
			SetupCriteria((Junction)(object)val2, filter2);
			((Junction)val).Add((ICriterion)(object)val2);
		}
		junction.Add((ICriterion)(object)val);
	}

	private SqlSubQuery GetSubordinateByUserQuery(long userId)
	{
		return SessionProvider.GetSession("").CreateSQLSubQuery(string.Format("select u.{0} from {1} u where u.{0} in (select SubordinateUserId from UserSecuritySetCache where UserId <> SubordinateUserId and UserId = :userId)", TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("User"))).SetParameter("userId", userId);
	}
}
