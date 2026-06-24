using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Documents.Managers;

public class LifeCycleStatusManager : EntityManager<ILifeCycleStatus, long>
{
	public new static LifeCycleStatusManager Instance => Locator.GetServiceNotNull<LifeCycleStatusManager>();

	public new ILifeCycleStatus Load(Guid uid)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Uid", (object)uid)).SetCacheable(true).UniqueResult<ILifeCycleStatus>();
	}

	public ILifeCycleStatus LoadByName(string name)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Name", (object)name)).SetCacheable(true).List<ILifeCycleStatus>()
			.FirstOrDefault();
	}

	[PublicApiMember]
	public override void Delete(ILifeCycleStatus obj)
	{
		if (CanDelete(obj))
		{
			base.Delete(obj);
		}
	}

	public new bool CanDelete(ILifeCycleStatus obj)
	{
		if (obj.Uid != DocumentConstants.DocumentStatusNewUID && obj.Uid != DocumentConstants.DocumentStatusActiveUID)
		{
			return obj.Uid != DocumentConstants.DocumentStatusCancelUID;
		}
		return false;
	}

	public List<ILifeCycleStatus> GetStatusesByTypes(string text, List<ReferenceOnEntityType> documentsTypes)
	{
		if (documentsTypes != null)
		{
			DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<ILifeCycleStatus>()).CreateAlias("LifeCycles", "lc", (JoinType)0).Add((ICriterion)(object)Restrictions.In("lc.DocumentType", (ICollection)documentsTypes.Select((ReferenceOnEntityType dt) => dt.TypeUid).ToList()))
				.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")));
			if (!string.IsNullOrEmpty(text))
			{
				return CreateCriteria().Add((ICriterion)(object)Subqueries.PropertyIn("Id", val)).Add((ICriterion)(object)ElmaRestrictions.Like("Name", text)).List<ILifeCycleStatus>()
					.ToList();
			}
			return CreateCriteria().Add((ICriterion)(object)Subqueries.PropertyIn("Id", val)).List<ILifeCycleStatus>().ToList();
		}
		if (!string.IsNullOrEmpty(text))
		{
			return CreateCriteria().Add((ICriterion)(object)ElmaRestrictions.Like("Name", text)).List<ILifeCycleStatus>().ToList();
		}
		return FindAll().ToList();
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<ILifeCycleStatus>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Description",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "LifeCycles",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Name",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Uid",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
