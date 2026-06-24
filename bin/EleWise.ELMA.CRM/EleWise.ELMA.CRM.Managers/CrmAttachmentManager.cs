using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;

namespace EleWise.ELMA.CRM.Managers;

public class CrmAttachmentManager : EntityManager<ICRMAttachment, long>
{
	public new static CrmAttachmentManager Instance => Locator.GetServiceNotNull<CrmAttachmentManager>();

	public static Guid TypeUid => InterfaceActivator.UID<ICRMAttachment>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Subqueries.PropertyIn("Id", DetachedCriteria.For(InterfaceActivator.TypeOf<ICRMAttachment>()).SetProjection((IProjection)(object)Projections.Id()).CreateCriteria("Files", (JoinType)0)), (ICriterion)(object)Subqueries.PropertyIn("Id", DetachedCriteria.For(InterfaceActivator.TypeOf<ICRMAttachment>()).SetProjection((IProjection)(object)Projections.Id()).CreateCriteria("Documents", (JoinType)0)
			.Add((ICriterion)(object)Restrictions.EqProperty(Projections.SqlFunction(Locator.GetServiceNotNull<ITransformationProvider>().Dialect.GetIsNullFunctionName(), (IType)(object)NHibernateUtil.Boolean, (IProjection[])(object)new IProjection[2]
			{
				(IProjection)Projections.Property("IsDeleted"),
				Projections.Constant((object)0)
			}), Projections.Constant((object)0))))));
	}
}
