using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Helpers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Security;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingBaseManager<T, TId> : EntityManager<T, TId> where T : IMarketingBase, IEntity<TId>
{
	public override void Save(T obj)
	{
		foreach (IMarketingTag item in (IEnumerable<IMarketingTag>)obj.Tags)
		{
			if (item.IsNew())
			{
				item.Save();
			}
		}
		if (obj.BudgetType == MarketingBudgetType.Manual)
		{
			if (obj.IsNew())
			{
				MarketingPaymentManager.Instance.CreatePaymentOnBudget(obj);
			}
			else
			{
				IMarketingPayment marketingPayment = ((IEnumerable<IMarketingPayment>)obj.Payments).FirstOrDefault();
				if (marketingPayment != null)
				{
					marketingPayment.Sum = obj.Budget;
					marketingPayment.CreationDate = DateTime.Today;
					marketingPayment.Save();
					((ICollection<IMarketingPayment>)obj.Payments).Clear();
					obj.Payments.Add(marketingPayment);
				}
				else
				{
					MarketingPaymentManager.Instance.CreatePaymentOnBudget(obj);
				}
			}
		}
		base.Save(obj);
	}

	public double CalcMarketingBudget(IMarketingBase marketingBase)
	{
		double result = 0.0;
		if (marketingBase is IMarketingGroup marketingGroup)
		{
			result = ((IEnumerable<IMarketingPayment>)marketingGroup.Payments).Sum((IMarketingPayment s) => s.Sum) + ((marketingGroup.BudgetType == MarketingBudgetType.Manual) ? 0.0 : ((IEnumerable<IMarketingActivity>)marketingGroup.MarketingActivities).Sum((IMarketingActivity e) => CalcMarketingBudget(e)));
		}
		if (marketingBase is IMarketingActivity marketingActivity)
		{
			result = ((IEnumerable<IMarketingPayment>)marketingActivity.Payments).Sum((IMarketingPayment s) => s.Sum) + ((marketingActivity.BudgetType == MarketingBudgetType.Manual) ? 0.0 : ((IEnumerable<IMarketingEffect>)marketingActivity.MarketingEffects).Sum((IMarketingEffect e) => CalcMarketingBudget(e)));
		}
		if (marketingBase is IMarketingEffect marketingEffect)
		{
			result = ((IEnumerable<IMarketingPayment>)marketingEffect.Payments).Sum((IMarketingPayment s) => s.Sum);
		}
		return result;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IMarketingBaseFilter marketingBaseFilter && marketingBaseFilter.TypeUid.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq(GetTypeUidPropertyName(filter), (object)marketingBaseFilter.TypeUid.Value));
		}
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class MarketingBaseManager : MarketingBaseManager<IMarketingBase, long>
{
	public new static MarketingBaseManager Instance => Locator.GetServiceNotNull<MarketingBaseManager>();

	public GroupPermissionManager GroupPermissionManager { get; set; }

	[Transaction]
	public virtual void Archive(IMarketingBase marketingBase, ICommentActionModel commentAction)
	{
		Locator.GetServiceNotNull<ICommentActionHandler>().Process(marketingBase, commentAction);
		marketingBase.Status = MarketingObjectStatus.Archived;
		marketingBase.ArchiveDate = DateTime.Now;
		marketingBase.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, marketingBase, "03210724-db9f-467a-a607-c602906a16eb"));
		IMarketingBase marketingBase2 = marketingBase.CastAsRealType();
		if (marketingBase2 is IMarketingActivity)
		{
			InstanceOf<IMarketingEffectFilter> instanceOf = new InstanceOf<IMarketingEffectFilter>();
			instanceOf.New.MarketingActivity = (IMarketingActivity)marketingBase2;
			IMarketingEffectFilter @new = instanceOf.New;
			{
				foreach (IMarketingEffect item in MarketingEffectManager.Instance.Find(@new, FetchOptions.All))
				{
					Archive(item, commentAction);
				}
				return;
			}
		}
		if (!(marketingBase2 is IMarketingGroup))
		{
			return;
		}
		InstanceOf<IMarketingActivityFilter> instanceOf2 = new InstanceOf<IMarketingActivityFilter>();
		instanceOf2.New.MarketingGroup = (IMarketingGroup)marketingBase2;
		IMarketingActivityFilter new2 = instanceOf2.New;
		foreach (IMarketingActivity item2 in MarketingActivityManager.Instance.Find(new2, FetchOptions.All))
		{
			Archive(item2, commentAction);
		}
	}

	[Transaction]
	public virtual void Activate(IMarketingBase marketingBase, ICommentActionModel commentAction)
	{
		Locator.GetServiceNotNull<ICommentActionHandler>().Process(marketingBase, commentAction);
		marketingBase.Status = MarketingObjectStatus.Active;
		marketingBase.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, marketingBase, "e74d3c28-fcaf-47ef-b58e-f2be948be113"));
		IMarketingBase marketingBase2 = marketingBase.CastAsRealType();
		if (marketingBase2 is IMarketingEffect)
		{
			IMarketingEffect marketingEffect = (IMarketingEffect)marketingBase;
			if (marketingEffect.MarketingActivity != null && marketingEffect.MarketingActivity.Status != 0)
			{
				Activate(marketingEffect.MarketingActivity, commentAction);
			}
		}
		else if (marketingBase2 is IMarketingActivity)
		{
			IMarketingActivity marketingActivity = (IMarketingActivity)marketingBase;
			if (marketingActivity.MarketingGroup != null && marketingActivity.MarketingGroup.Status != 0)
			{
				Activate(marketingActivity.MarketingGroup, commentAction);
			}
		}
	}

	public IEnumerable<MarketingTreeItem> TreeRoot()
	{
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IMarketingActivity>()).Add((ICriterion)(object)Restrictions.EqProperty("MarketingGroup", "mg.Id")).Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active))
			.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")));
		ICriteria val2 = CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingGroup>(), "mg").Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Name"), "Name")
			.Add((IProjection)(object)Projections.Property(GetTypeUidPropertyName(typeof(IMarketingGroup))), "TypeUid")
			.Add(Projections.SubQuery(val), "ChildrenCount") });
		DetachedCriteria val3 = DetachedCriteria.For(InterfaceActivator.TypeOf<IMarketingEffect>()).Add((ICriterion)(object)Restrictions.EqProperty("MarketingActivity", "ma.Id")).Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active))
			.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")));
		ICriteria val4 = CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingActivity>(), "ma").Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active)).Add((ICriterion)(object)Restrictions.IsNull("MarketingGroup")).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Name"), "Name")
			.Add((IProjection)(object)Projections.Property(GetTypeUidPropertyName(typeof(IMarketingActivity))), "TypeUid")
			.Add(Projections.SubQuery(val3), "ChildrenCount") });
		return val2.SetResultTransformer((IResultTransformer)new AliasToBeanResultTransformer(typeof(MarketingTreeItem))).List<MarketingTreeItem>().Union(val4.SetResultTransformer((IResultTransformer)new AliasToBeanResultTransformer(typeof(MarketingTreeItem))).List<MarketingTreeItem>());
	}

	public IEnumerable<MarketingTreeItem> TreeGroup(IMarketingGroup group)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IMarketingEffect>()).Add((ICriterion)(object)Restrictions.EqProperty("MarketingActivity", "ma.Id")).Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active))
			.SetProjection((IProjection)(object)Projections.ProjectionList().Add((IProjection)(object)Projections.Count("Id")));
		return CreateCriteria(FetchOptions.All, InterfaceActivator.TypeOf<IMarketingActivity>(), "ma").Add((ICriterion)(object)Restrictions.Eq("Status", (object)MarketingObjectStatus.Active)).Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)group)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "Id").Add((IProjection)(object)Projections.Property("Name"), "Name")
			.Add((IProjection)(object)Projections.Property(GetTypeUidPropertyName(typeof(IMarketingActivity))), "TypeUid")
			.Add(Projections.SubQuery(val), "ChildrenCount") })
			.SetResultTransformer((IResultTransformer)new AliasToBeanResultTransformer(typeof(MarketingTreeItem)))
			.List<MarketingTreeItem>();
	}

	[Transaction]
	public virtual void EnableInheritPermissions(IMarketingBase marketingObj, bool enable)
	{
		marketingObj.InheritPermissions = enable;
		if (enable)
		{
			AddPermissionsFromParent(marketingObj);
		}
		else
		{
			CopyPermissionsFromInherited(marketingObj);
		}
		Save(marketingObj);
	}

	private void CopyPermissionsFromInherited(IMarketingBase marketingObj)
	{
		((IEnumerable<IMarketingPersonPermission>)marketingObj.Permission).ForEach(delegate(IMarketingPersonPermission p)
		{
			p.PermissionSource = null;
		});
		List<IMarketingBase> parents = MarketingObjectsWalker.EnumerateParents(marketingObj).ToList();
		MarketingObjectsWalker.EnumerateTreeItemsWithEnabledInheritance(marketingObj).SelectMany((IMarketingBase m) => (IEnumerable<IMarketingPersonPermission>)m.Permission).ToList()
			.ForEach(delegate(IMarketingPersonPermission p)
			{
				if (p.PermissionSource != null && parents.Any((IMarketingBase m) => m.Id == p.PermissionSource.Id))
				{
					p.PermissionSource = marketingObj;
				}
			});
	}

	public virtual void AddPermissionsFromParent(IMarketingBase targetObj)
	{
		Contract.ArgumentNotNull(targetObj, "marketingObj");
		IMarketingBase marketingBase = targetObj.CastAsRealType();
		IEnumerable<IMarketingPersonPermission> source = ((MarketingObjectsWalker.GetParent(marketingBase) != null) ? MarketingObjectPermissionsCreator.GetInheritedPermissions(marketingBase) : GetMarketingDefaultPermissions(marketingBase));
		((ICollection<IMarketingPersonPermission>)targetObj.Permission).AddSequense(source);
	}

	private IEnumerable<IMarketingPersonPermission> GetMarketingDefaultPermissions(IMarketingBase marketingObj)
	{
		IUserGroup[] marketingReadOnlyAccessGroups = GroupPermissionManager.GetGroupsByPermission(CRMPermissionProvider.MarketingAccessPermission).ToArray();
		return MarketingObjectPermissionsCreator.GetDefaultPermissions(marketingObj, marketingReadOnlyAccessGroups);
	}
}
