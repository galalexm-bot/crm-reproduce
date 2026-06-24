using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;

namespace EleWise.ELMA.Tasks.Components;

public class WorkLogItemSearchProvider : WorkLogSearchProviderBase
{
	private class ConvertedDetachedCriteria : DetachedCriteria
	{
		public ConvertedDetachedCriteria(ICriteria criteria)
			: base((CriteriaImpl)criteria, criteria)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			((CriteriaImpl)criteria).set_Session((ISessionImplementor)null);
		}
	}

	private readonly List<IWorkLogItemSearchExtension> searchExtension = new List<IWorkLogItemSearchExtension>();

	private const string WorkLogItemAlias = "wliObjId";

	public override bool DisibleSearchString => true;

	public WorkLogItemSearchProvider()
	{
		searchExtension.AddRange(ComponentManager.Current.GetExtensionPoints<IWorkLogItemSearchExtension>().ToList());
	}

	public override void UpdateFilter(IEntityFilter filterEntity)
	{
		base.UpdateFilter(filterEntity);
		filterEntity.DisableSecurity = true;
	}

	public override ICriteria TransformPartCriteria(ISession session, ICriteria criteria, Guid baseObjectTypeUid, List<Guid> objectTypeUids, IWorkLogObjectSearchFilter filter)
	{
		ICriteria val = session.CreateCriteria(InterfaceActivator.TypeOf<IWorkLogItem>(), "wliObjId");
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)filter;
		workLogItemSearchFilter.ObjectUids = objectTypeUids;
		SetupFastSearchFilter(session, val, filter.SearchString, baseObjectTypeUid);
		foreach (IWorkLogItemSearchExtension item in searchExtension)
		{
			item.SetupCriteria(val, workLogItemSearchFilter);
		}
		criteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Id") });
		ConvertedDetachedCriteria convertedDetachedCriteria = new ConvertedDetachedCriteria(criteria);
		val.Add((ICriterion)(object)Subqueries.PropertyIn(string.Format("{0}.ObjectId", "wliObjId"), (DetachedCriteria)(object)convertedDetachedCriteria));
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("Id") });
		return val;
	}

	protected new static void SetupFastSearchFilter(ISession session, ICriteria criteria, string searchString, Guid objectTypeUid)
	{
		if (string.IsNullOrEmpty(searchString))
		{
			return;
		}
		Type entityType = ModelHelper.GetEntityType(objectTypeUid);
		if ((EntityMetadata)MetadataLoader.LoadMetadata(entityType) == null)
		{
			return;
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf<IWorkLogItem>());
		string[] array = searchString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			return;
		}
		string text = EleWise.ELMA.Helpers.SqlQueryBuilder.EntityTitleProperty(entityType);
		Conjunction val = Restrictions.Conjunction();
		bool flag = false;
		Conjunction val2 = Restrictions.Conjunction();
		string[] array2 = array;
		foreach (string obj in array2)
		{
			AbstractCriterion val3 = null;
			AbstractCriterion val4 = null;
			string value = obj;
			foreach (EntityPropertyMetadata item in from p in entityMetadata.Properties.OfType<EntityPropertyMetadata>()
				where p.InFastSearch && (p.TypeUid == StringDescriptor.UID || p.SubTypeUid == TextDescriptor.UID)
				select p)
			{
				val3 = ((val3 == null) ? ElmaRestrictions.InsensitiveLike(item.Name, value, MatchMode.Anywhere) : (val3 | ElmaRestrictions.InsensitiveLike(item.Name, value, MatchMode.Anywhere)));
			}
			if (!string.IsNullOrEmpty(text))
			{
				val4 = ElmaRestrictions.InsensitiveLike(text, value, MatchMode.Anywhere);
			}
			if (val3 != null && val != null)
			{
				((Junction)val).Add((ICriterion)(object)val3);
				flag = true;
			}
			if (val4 != null && val2 != null)
			{
				((Junction)val2).Add((ICriterion)(object)val4);
			}
		}
		Disjunction val5 = Restrictions.Disjunction();
		if (flag)
		{
			((Junction)val5).Add((ICriterion)(object)val);
		}
		if (!string.IsNullOrEmpty(text))
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			DetachedCriteria val6 = ((DetachedCriteria)new ConvertedDetachedCriteria(session.CreateCriteria(entityType, "wliEntity"))).Add((ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} = {1}.ObjectId", serviceNotNull.Dialect.QuoteIfNeeded("Id"), EleWise.ELMA.Helpers.SqlQueryBuilder.GetCriteriaAlias(criteria)))).Add((ICriterion)(object)val2).SetProjection((IProjection)(object)Projections.Property("Id"));
			((Junction)val5).Add((ICriterion)(object)Subqueries.PropertyIn(string.Format("{0}.{1}", criteria.get_Alias(), serviceNotNull.Dialect.QuoteIfNeeded("ObjectId")), val6));
		}
		criteria.Add((ICriterion)(object)val5);
	}

	public override bool CanPropertyFilter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.GetCustomAttributes(typeof(WorkLogItemSearchFieldAttribute), inherit: true).Length == 0)
		{
			return base.CanPropertyFilter(propertyInfo);
		}
		return true;
	}
}
