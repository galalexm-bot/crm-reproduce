using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;

namespace EleWise.ELMA.Tasks.Components;

[Service]
internal class CurrentControllersFilterService : ICurrentControllersFilterService
{
	private ITransformationProvider transformationProvider;

	public CurrentControllersFilterService(ITransformationProvider transformationProvider)
	{
		this.transformationProvider = transformationProvider;
	}

	public void SetupCurrentControllersFilter(ICriteria criteria, bool? filterUnderControl, TaskControlType? filterControlType, IUser filterControlUser, ISet<IUser> filterCurrentControllers, string taskTable, string currentControllersLinkTable, string currentControllersTaskIdColumn, string currentControllersUserIdColumn)
	{
		if (filterCurrentControllers != null && ((IEnumerable<IUser>)filterCurrentControllers).Any() && (filterControlType != TaskControlType.Current || filterControlUser == null || !((ICollection<IUser>)filterCurrentControllers).Contains(filterControlUser)))
		{
			long[] array = ((IEnumerable<IUser>)filterCurrentControllers).Select((IUser u) => u.Id).ToArray();
			List<object> list = new List<object>();
			List<IType> list2 = new List<IType>();
			string text = string.Format("select {0} from {1} t left join {2} cc on t.{0}=cc.{3} where {4}", transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded(taskTable), transformationProvider.Dialect.QuoteIfNeeded(currentControllersLinkTable), transformationProvider.Dialect.QuoteIfNeeded(currentControllersTaskIdColumn), ElmaInExpression.ToString("cc." + transformationProvider.Dialect.QuoteIfNeeded(currentControllersUserIdColumn), array, list, list2));
			bool flag = false;
			if (filterControlUser == null)
			{
				if (!filterControlType.HasValue)
				{
					text = text + " or " + ElmaInExpression.ToString("t." + transformationProvider.Dialect.QuoteIfNeeded("ControlUser"), array, list, list2) + " and t." + transformationProvider.Dialect.QuoteIfNeeded("ControlType") + "=" + 2;
					flag = true;
				}
				else if (filterControlType == TaskControlType.Current)
				{
					text = text + " or " + ElmaInExpression.ToString("t." + transformationProvider.Dialect.QuoteIfNeeded("ControlUser"), array, list, list2);
					flag = true;
				}
			}
			else if (((ICollection<IUser>)filterCurrentControllers).Contains(filterControlUser) && !filterControlType.HasValue)
			{
				text = text + " or t." + transformationProvider.Dialect.QuoteIfNeeded("ControlType") + "=" + 2;
				flag = true;
			}
			if (filterUnderControl.HasValue)
			{
				text = text + (flag ? " and " : " or ") + "t." + transformationProvider.Dialect.QuoteIfNeeded("UnderControl") + "=" + (filterUnderControl.Value ? 1 : 0);
			}
			criteria.Add((ICriterion)(object)Expression.Sql("{alias}." + transformationProvider.Dialect.QuoteIfNeeded("Id") + " in (" + text + ")", list.ToArray(), list2.ToArray()));
		}
		else if (filterUnderControl == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("UnderControl", (object)false)).Add((ICriterion)(object)Restrictions.IsEmpty("CurrentControllers"));
		}
		else if (filterUnderControl == true)
		{
			criteria.Add((ICriterion)(object)((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq("UnderControl", (object)true)).Add((ICriterion)(object)Restrictions.IsNotEmpty("CurrentControllers")));
		}
		if (filterControlType.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("ControlType", (object)filterControlType.Value));
		}
		if (filterControlUser != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("ControlUser", (object)filterControlUser));
		}
	}
}
