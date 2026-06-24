using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;

namespace EleWise.ELMA.Documents.Managers;

[Component(Order = 9)]
public class ArchiveManagerBehavior : EntityManagerBehavior
{
	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		//IL_000c: Expected O, but got Unknown
		Type type = null;
		try
		{
			type = criteria.GetRootEntityTypeIfAvailable();
		}
		catch (HibernateException val)
		{
			HibernateException val2 = val;
			Logger.Log.Error(((Exception)(object)val2).Message, (Exception)(object)val2);
			return;
		}
		if (typeof(IDmsObject).IsAssignableFrom(type) && filter is IDmsObjectFilter dmsObjectFilter && (!dmsObjectFilter.DisableArchive.HasValue || !dmsObjectFilter.DisableArchive.Value) && !dmsObjectFilter.IsArchived.HasValue)
		{
			ITransformationProvider service = Locator.GetService<ITransformationProvider>();
			if (service != null)
			{
				criteria.Add((ICriterion)(object)Restrictions.EqProperty(Projections.SqlFunction(service.Dialect.GetIsNullFunctionName(), (IType)(object)NHibernateUtil.Boolean, (IProjection[])(object)new IProjection[2]
				{
					(IProjection)Projections.Property("IsArchived"),
					Projections.Constant((object)0)
				}), Projections.Constant((object)0)));
			}
			else
			{
				criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsArchived"), (ICriterion)(object)Restrictions.Eq("IsArchived", (object)false)));
			}
		}
	}
}
