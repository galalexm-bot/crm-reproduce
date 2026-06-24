using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SaleManager : BaseCrmManager<ISale>
{
	public static readonly SaleStatus[] SaleClosedStatuses = new SaleStatus[2]
	{
		SaleStatus.NegativeClosed,
		SaleStatus.PositiveClosed
	};

	public ITransformationProvider TransformationProvider { get; set; }

	public IEntityManager<ISalePersonPermission> SalePersonPermissionManager { get; set; }

	protected override string DefaultCriteriaAlias => "saleMn";

	public new static SaleManager Instance => Locator.GetServiceNotNull<SaleManager>();

	public List<ISale> GetSales(EleWise.ELMA.Security.Models.IUser user)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)user)).Add((ICriterion)(object)Restrictions.In("SaleStatus", (ICollection)new SaleStatus[1] { SaleStatus.Active })).List<ISale>()
			.ToList();
	}

	public double SalesVolume(IEntityFilter filter)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Sum("SalesVolume") });
		return Convert.ToDouble(val.UniqueResult());
	}

	public IDictionary<string, double> SalesVolumeByCurrency(IEntityFilter filter = null)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(((SimpleProjection)Projections.Sum("SalesVolume")).As("SalesVolume")).Add(((SimpleProjection)Projections.GroupProperty("Currency")).As("Currency")) }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(SaleVolumeByCurrencyModel)));
		string withoutCur = SR.M("Без указания валюты");
		return val.List<SaleVolumeByCurrencyModel>().ToDictionary(delegate(SaleVolumeByCurrencyModel p)
		{
			ICurrency currency = p.Currency;
			if (currency == null)
			{
				return withoutCur;
			}
			return string.IsNullOrWhiteSpace(currency.Name) ? (string.IsNullOrWhiteSpace(currency.ShortName) ? withoutCur : currency.ShortName) : currency.Name;
		}, (SaleVolumeByCurrencyModel p) => p.SalesVolume);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		base.SetupFilter(criteria, filter);
		if (!(filter is ISaleFilter saleFilter))
		{
			return;
		}
		if (saleFilter.Categories != null && ((IEnumerable<ICategory>)saleFilter.Categories).Any())
		{
			criteria.CreateAlias("Contractor", "cc");
			DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IContractor>()).CreateAlias("Categories", "Categoriesalias", (JoinType)0).Add((ICriterion)(object)Restrictions.In("Categoriesalias.Id", (ICollection)((IEnumerable<ICategory>)saleFilter.Categories).Select((ICategory c) => c.Id).ToArray()))
				.SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.Add((ICriterion)(object)Subqueries.PropertyIn("cc.Id", val));
		}
		EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)saleFilter.GetPropertyValue("Responsible", null);
		if (user != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)user));
		}
		if (saleFilter.Responsibles != null && ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)saleFilter.Responsibles).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Responsible", (ICollection)((IEnumerable<EleWise.ELMA.Security.Models.IUser>)saleFilter.Responsibles).ToList()));
		}
		ISaleStage saleStage = (ISaleStage)saleFilter.GetPropertyValue("SaleStage", null);
		if (saleStage != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("SaleStage", (object)saleStage));
		}
		if (saleFilter.SaleStages != null && ((IEnumerable<ISaleStage>)saleFilter.SaleStages).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("SaleStage", (ICollection)((IEnumerable<ISaleStage>)saleFilter.SaleStages).ToList()));
		}
		IContractor contractor = (IContractor)saleFilter.GetPropertyValue("Contractor", null);
		if (contractor != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Contractor", (object)contractor));
		}
		if (saleFilter.Contractors != null && ((IEnumerable<IContractor>)saleFilter.Contractors).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Contractor", (ICollection)((IEnumerable<IContractor>)saleFilter.Contractors).ToList()));
		}
		IContractorRegion contractorRegion = (IContractorRegion)saleFilter.GetPropertyValue("Region", null);
		if (contractorRegion != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Region", (object)contractorRegion));
		}
		if (saleFilter.Regions != null && ((IEnumerable<IContractorRegion>)saleFilter.Regions).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Region", (ICollection)((IEnumerable<IContractorRegion>)saleFilter.Regions).ToList()));
		}
		IContractorIndustry contractorIndustry = (IContractorIndustry)saleFilter.GetPropertyValue("ContractorIndustry", null);
		if (contractorIndustry != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("ContractorIndustry", (object)contractorIndustry));
		}
		if (saleFilter.ContractorIndustries != null && ((IEnumerable<IContractorIndustry>)saleFilter.ContractorIndustries).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("ContractorIndustry", (ICollection)((IEnumerable<IContractorIndustry>)saleFilter.ContractorIndustries).ToList()));
		}
		IMarketingActivity marketingActivity = (IMarketingActivity)saleFilter.GetPropertyValue("MarketingActivity", null);
		if (marketingActivity != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)marketingActivity));
		}
		List<IMarketingActivity> list = ((IEnumerable)saleFilter.GetPropertyValue("MarketingActivities", null)).Cast<IMarketingActivity>().ToList();
		if (list.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("MarketingActivity", (ICollection)list));
		}
		IMarketingGroup marketingGroup = (IMarketingGroup)saleFilter.GetPropertyValue("MarketingGroup", null);
		if (marketingGroup != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingGroup));
		}
		IMarketingEffect marketingEffect = (IMarketingEffect)saleFilter.GetPropertyValue("MarketingEffect", null);
		if (marketingEffect != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingEffect", (object)marketingEffect));
		}
		if (saleFilter.MarketingObjects != null && ((IEnumerable<IMarketingBase>)saleFilter.MarketingObjects).Any())
		{
			List<IMarketingGroup> list2 = new List<IMarketingGroup>();
			List<IMarketingActivity> list3 = new List<IMarketingActivity>();
			List<IMarketingEffect> list4 = new List<IMarketingEffect>();
			foreach (IMarketingBase item in (IEnumerable<IMarketingBase>)saleFilter.MarketingObjects)
			{
				if (item is IMarketingGroup)
				{
					list2.Add((IMarketingGroup)item);
					continue;
				}
				if (item is IMarketingActivity)
				{
					list3.Add((IMarketingActivity)item);
					continue;
				}
				if (item is IMarketingEffect)
				{
					list4.Add((IMarketingEffect)item);
					continue;
				}
				throw new NotSupportedException(SR.T("Неподдерживаемый тип объекта маркетинга: {0}", item.GetType().FullName));
			}
			criteria.Add((ICriterion)(object)((Junction)new Disjunction()).Add((ICriterion)(object)Restrictions.In("MarketingGroup", (ICollection)list2)).Add((ICriterion)(object)Restrictions.In("MarketingActivity", (ICollection)list3)).Add((ICriterion)(object)Restrictions.In("MarketingEffect", (ICollection)list4)));
		}
		SalePriority? salePriority = (SalePriority?)saleFilter.GetPropertyValue("Priority", null);
		if (salePriority.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Priority", (object)salePriority));
		}
		if (saleFilter.Priorities != null && saleFilter.Priorities.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Priority", (ICollection)saleFilter.Priorities.ToList()));
		}
		ISaleType saleType = (ISaleType)saleFilter.GetPropertyValue("SaleType", null);
		if (saleType != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("SaleType", (object)saleType));
		}
		if (saleFilter.SaleTypes != null && ((IEnumerable<ISaleType>)saleFilter.SaleTypes).Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("SaleType", (ICollection)((IEnumerable<ISaleType>)saleFilter.SaleTypes).ToList()));
		}
		if (saleFilter.ShowOnlyMy)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)base.AuthenticationService.GetCurrentUser()));
		}
		if (saleFilter.Closed == true)
		{
			criteria.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.NegativeClosed), (ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.PositiveClosed)));
		}
		else if (saleFilter.Closed == false)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.NegativeClosed), (ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.PositiveClosed))));
		}
		if (saleFilter.Products != null && ((IEnumerable<IProduct>)saleFilter.Products).Any())
		{
			criteria.CreateAlias("Products", "pr");
			criteria.Add((ICriterion)(object)Restrictions.In("pr.Product", (ICollection)((IEnumerable<IProduct>)saleFilter.Products).ToList()));
		}
	}

	public List<SaleFunnelReportInfo> SaleFunnelReport(IEntityFilter filter)
	{
		ICriteria val = CreateCriteria(filter);
		if (CacheEnabled)
		{
			val = val.SetCacheable(true);
		}
		SetupFilter(val, filter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty("SaleStage"), "SaleStage").Add((IProjection)(object)Projections.Count("Id"), "Count") });
		Func<object[], SaleFunnelReportInfo> selector = (object[] a) => new SaleFunnelReportInfo
		{
			SaleStage = (ISaleStage)a[0],
			Count = (int)a[1]
		};
		return val.List<object[]>().Select(selector).ToList();
	}

	protected override void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		if (fetchOptions.SortExpression.In("SaleStage", PropertyHelper.GetNameSortExpression((ISale x) => x.SaleStage)))
		{
			fetchOptions.SortExpression = "SaleStage.GlobalOrder";
		}
		base.SetupFetchOptions(criteria, fetchOptions, entityType);
	}

	[ActionCheck("3d41953b-d41b-440e-a5ba-da9aafa1c97b")]
	public virtual bool CanChangeStatus(ISale sale, SaleStatus status, string comment)
	{
		return base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, sale);
	}

	[ActionMethod("3d41953b-d41b-440e-a5ba-da9aafa1c97b")]
	[Transaction]
	public virtual ISale ChangeStatus(ISale sale, SaleStatus status, string comment)
	{
		if (sale == null)
		{
			return null;
		}
		if (!string.IsNullOrEmpty(comment))
		{
			IComment comment2 = InterfaceActivator.Create<IComment>();
			comment2.Text = comment;
			comment2.Save();
			sale.Comments.Add(comment2);
			sale.StatusChangeComment = comment2;
		}
		else
		{
			sale.StatusChangeComment = null;
		}
		if (sale.SaleStatus != status)
		{
			sale.SaleStatus = status;
			sale.StatusChangeDate = DateTime.Now;
			if (status == SaleStatus.NegativeClosed || status == SaleStatus.PositiveClosed)
			{
				sale.EndDate = DateTime.Now;
			}
		}
		sale.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, sale, "3d41953b-d41b-440e-a5ba-da9aafa1c97b"));
		return sale;
	}

	[ActionCheck("a8ab9be9-5631-4fea-8970-44438cea3f2a")]
	public virtual bool CanChangeStage(ISale sale, ISaleStage stage, string comment)
	{
		return base.SecurityService.HasPermission(CRMPermissionProvider.EditSalePermission, sale);
	}

	[ActionMethod("a8ab9be9-5631-4fea-8970-44438cea3f2a")]
	[Transaction]
	public virtual ISale ChangeStage(ISale sale, ISaleStage stage, string comment)
	{
		if (sale == null)
		{
			return null;
		}
		IComment comment2 = null;
		if (!string.IsNullOrEmpty(comment))
		{
			comment2 = InterfaceActivator.Create<IComment>();
			comment2.Text = comment;
			comment2.Save();
			sale.Comments.Add(comment2);
		}
		sale.StageChangeComment = comment2;
		if (sale.SaleStage != stage)
		{
			sale.PreviousStage = sale.SaleStage;
			sale.SaleStage = stage;
			sale.StageChangeDate = DateTime.Now;
			if (sale.SaleStage != null && sale.SaleStage.SaleFunnel != null)
			{
				long maxOrder = ((IEnumerable<ISaleStage>)sale.SaleStage.SaleFunnel.SaleStages).Max((ISaleStage s) => s.GlobalOrder);
				ISaleStage saleStage = ((IEnumerable<ISaleStage>)sale.SaleStage.SaleFunnel.SaleStages).FirstOrDefault((ISaleStage s) => s.GlobalOrder == maxOrder);
				if (sale.SaleStage == saleStage)
				{
					sale.SaleStatus = SaleStatus.PositiveClosed;
					sale.StatusChangeDate = DateTime.Now;
					sale.StatusChangeComment = comment2;
					sale.EndDate = DateTime.Now;
				}
			}
		}
		sale.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, sale, "a8ab9be9-5631-4fea-8970-44438cea3f2a"));
		return sale;
	}

	public void LinkToMarketing(ISale sale, IMarketingBase marketingBase)
	{
		if (sale == null)
		{
			throw new ArgumentException("Null argument: sale");
		}
		IMarketingBase marketingBase2 = marketingBase.CastAsRealType();
		if (marketingBase2 is IMarketingGroup)
		{
			sale.MarketingGroup = (IMarketingGroup)marketingBase2;
		}
		else if (marketingBase2 is IMarketingActivity)
		{
			sale.MarketingActivity = (IMarketingActivity)marketingBase2;
		}
		else
		{
			if (!(marketingBase2 is IMarketingEffect))
			{
				throw new Exception(SR.T("Неизвестный тип объекта маркетинга"));
			}
			sale.MarketingEffect = (IMarketingEffect)marketingBase2;
		}
		sale.Save();
	}

	private void UpdateMarketingCounters(IMarketingBase marketingBase, string propName)
	{
		if (marketingBase != null)
		{
			AbstractCriterion criterion = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.PositiveClosed));
			AbstractCriterion criterion2 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("SaleStatus", (object)SaleStatus.NegativeClosed));
			MarketingSaleCount marketingSaleCount = CreateCriteria(new Filter
			{
				DisableSoftDeletable = true
			}).Add((ICriterion)(object)Restrictions.Eq(propName, (object)marketingBase)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Alias(Projections.RowCount(), "CreatedCount")).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion), "PositiveCount"))
				.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion2), "NegativeCount")) }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(MarketingSaleCount)))
				.UniqueResult<MarketingSaleCount>();
			marketingBase.CreatedSaleCount = marketingSaleCount.CreatedCount;
			marketingBase.PositiveSaleCount = marketingSaleCount.PositiveCount;
			marketingBase.NegativeSaleCount = marketingSaleCount.NegativeCount;
			marketingBase.Save();
		}
	}

	public void UpdateMarketingCounters(List<IMarketingGroup> changedGroups, List<IMarketingActivity> changedActivities, List<IMarketingEffect> changedEffects)
	{
		foreach (IMarketingGroup changedGroup in changedGroups)
		{
			UpdateMarketingCounters(changedGroup, "MarketingGroup");
		}
		foreach (IMarketingActivity changedActivity in changedActivities)
		{
			UpdateMarketingCounters(changedActivity, "MarketingActivity");
		}
		foreach (IMarketingEffect changedEffect in changedEffects)
		{
			UpdateMarketingCounters(changedEffect, "MarketingEffect");
		}
	}

	public void UpdateMarketingCounters(ISale sale)
	{
		UpdateMarketingCounters(sale.MarketingGroup, "MarketingGroup");
		UpdateMarketingCounters(sale.MarketingActivity, "MarketingActivity");
		UpdateMarketingCounters(sale.MarketingEffect, "MarketingEffect");
	}

	[Transaction]
	internal virtual void CloseAllRelationships(long? saleId = null)
	{
		Func<IEnumerable<string>, string> func = delegate(IEnumerable<string> columns)
		{
			string text = string.Join(", ", columns.Select((string c) => string.Format("r.{0} {0}", TransformationProvider.Dialect.QuoteIfNeeded(c))));
			string text2 = string.Format("select {1}\r\nfrom {2}\r\ninner join {3} on s.{0} = r.{4}\r\nwhere s.{5} in ({6}) and (r.{7} is null or r.{7} = 0)", TransformationProvider.Dialect.QuoteIfNeeded("Id"), text, TransformationProvider.NoLockTableExpression("Relationship", "r"), TransformationProvider.NoLockTableExpression("Sale", "s"), TransformationProvider.Dialect.QuoteIfNeeded("Sale"), TransformationProvider.Dialect.QuoteIfNeeded("SaleStatus"), string.Join(",", SaleClosedStatuses.Select((SaleStatus st) => (int)st)), TransformationProvider.Dialect.QuoteIfNeeded("Completed"));
			if (saleId.HasValue)
			{
				text2 = string.Format("{0} and s.{1} = {2}", text2, TransformationProvider.Dialect.QuoteIfNeeded("Id"), saleId.Value);
			}
			return text2;
		};
		DateTime now = DateTime.Now;
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
		string parametrName = TransformationProvider.Dialect.QuoteString(base.Session.GetSessionImplementation().get_SessionId().ToString());
		string parametrName2 = TransformationProvider.Dialect.QuoteString(Guid.NewGuid().ToString());
		string parametrName3 = TransformationProvider.Dialect.QuoteString("786919b5-d160-426a-a578-f74b503cf966");
		string parametrName4 = TransformationProvider.Dialect.QuoteString(InterfaceActivator.UID<EntityActionEventArgs>().ToString());
		string arg = func(new string[2] { "Id", "TypeUid" });
		TransformationProvider.Insert("EntityActionHistory", new string[9] { "Uid", "ActionDate", "CreationAuthor", "SessionUid", "UnitOfWorkUid", "ActionObjectId", "ActionObjectUid", "ActionTypeUid", "EventArgsUid" }, string.Format("{0} col_Uid, {1} col_ActionDate, {2} col_CreationAuthor, {3} col_SessionUid, {4} col_UnitOfWorkUid, res.{5} col_ActionObjectId, res.{6} col_ActionObjectUid, {7} col_ActionTypeUid, {8} col_EventArgsUid", TransformationProvider.Dialect.GenUid(), TransformationProvider.Dialect.DateTimeToSql(now), user.Id, TransformationProvider.Dialect.CharToGuidFromSqlWithoutQuote(parametrName), TransformationProvider.Dialect.CharToGuidFromSqlWithoutQuote(parametrName2), TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("TypeUid"), TransformationProvider.Dialect.CharToGuidFromSqlWithoutQuote(parametrName3), TransformationProvider.Dialect.CharToGuidFromSqlWithoutQuote(parametrName4)), $"({arg}) res", isNeedInsertId: true);
		string arg2 = func(new string[1] { "Id" });
		TransformationProvider.Update("Relationship", new string[1] { "Completed" }, new object[1] { 1 }, string.Format("{0} in ({1})", TransformationProvider.Dialect.QuoteIfNeeded("Id"), arg2));
	}

	[Transaction]
	public virtual void EnableInheritPermissions(ISale sale, bool enable)
	{
		if (enable)
		{
			sale.InheritPermissions = true;
			AddPermissionsFromParent(sale);
		}
		else
		{
			sale.InheritPermissions = false;
			CopyPermissionsFromInherited(sale);
		}
		Save(sale);
	}

	public virtual void CopyPermissionsFromInherited(ISale sale)
	{
		((IEnumerable<ISalePersonPermission>)sale.Permission).ForEach(delegate(ISalePersonPermission p)
		{
			p.InheritedFromNumber = null;
			p.PermissionRole = ((p.PermissionRole == CommonRoleTypes.Informs.UID || p.PermissionRole == CommonRoleTypes.ParticipantWork.UID) ? new Guid?(CommonRoleTypes.User.UID) : p.PermissionRole);
		});
	}

	public virtual void DeleteAllPermissionInSale(ISale sale)
	{
		foreach (ISalePersonPermission item in (IEnumerable<ISalePersonPermission>)sale.Permission)
		{
			item.Delete();
		}
		((ICollection<ISalePersonPermission>)sale.Permission).Clear();
	}

	public virtual void DeleteAllInheritedPermissionInSale(ISale sale)
	{
		List<ISalePersonPermission> list = ((IEnumerable<ISalePersonPermission>)sale.Permission).Where((ISalePersonPermission p) => p.InheritedFromNumber.HasValue).ToList();
		foreach (ISalePersonPermission item in list)
		{
			item.Delete();
		}
		sale.Permission.RemoveAll((ICollection<ISalePersonPermission>)list);
	}

	public virtual void AddPermissionsFromParent(ISale sale)
	{
		if (sale.Contractor == null)
		{
			return;
		}
		foreach (IContractorPersonPermission item in (IEnumerable<IContractorPersonPermission>)sale.Contractor.Permission)
		{
			if (item != null)
			{
				Guid empty = Guid.Empty;
				empty = ((item.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id) ? CRMPermissionProvider.CRMSaleCreateElementPermission.Id : ((item.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id) ? CRMPermissionProvider.ViewSalePermission.Id : ((item.PermissionId == CRMPermissionProvider.EditContractorPermission.Id) ? CRMPermissionProvider.EditSalePermission.Id : ((item.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id) ? CRMPermissionProvider.CRMSaleIssuanceElementPermission.Id : ((!(item.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id)) ? item.PermissionId : CRMPermissionProvider.CRMSaleFullAccessPermission.Id)))));
				EleWise.ELMA.Security.Models.IUser user = item.User;
				if (item.PermissionRole == CommonRoleTypes.Responsible.Id)
				{
					user = sale.Responsible;
				}
				if (user == null && item.OrganizationItemEmployee == null && item.Group == null && item.OrganizationItemPosition == null)
				{
					user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
				}
				if (item.PermissionRole.HasValue && item.PermissionRole == CommonRoleTypes.Author.Id)
				{
					user = sale.Author;
				}
				if (empty != Guid.Empty)
				{
					InstanceOf<ISalePersonPermission> instanceOf = new InstanceOf<ISalePersonPermission>();
					instanceOf.New.Sale = sale;
					instanceOf.New.User = user;
					instanceOf.New.Group = item.Group;
					instanceOf.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
					instanceOf.New.OrganizationItemPosition = item.OrganizationItemPosition;
					instanceOf.New.PermissionId = empty;
					instanceOf.New.TypeRoleId = item.TypeRoleId;
					instanceOf.New.PermissionRole = item.PermissionRole;
					instanceOf.New.InheritedFromNumber = 1L;
					ISalePersonPermission @new = instanceOf.New;
					@new.Save();
					sale.Permission.Add(@new);
				}
			}
		}
	}

	[PublicApiMember]
	public virtual void SetStage(ISale sale, ISaleStage saleStage, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		if (saleStage == null)
		{
			throw new NullReferenceException(SR.T("Стадия сделки не может быть null"));
		}
		Instance.ChangeStage(sale, saleStage, comment);
	}

	[PublicApiMember]
	public virtual void SetStatus(ISale sale, SaleStatus saleStatus, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		Instance.ChangeStatus(sale, saleStatus, comment);
	}

	[PublicApiMember]
	public virtual void SetActiveStatus(ISale sale, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		Instance.ChangeStatus(sale, SaleStatus.Active, comment);
	}

	[PublicApiMember]
	public virtual void SetPostponedStatus(ISale sale, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		Instance.ChangeStatus(sale, SaleStatus.Postponed, comment);
	}

	[PublicApiMember]
	public virtual void SetPositiveClosedStatus(ISale sale, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		Instance.ChangeStatus(sale, SaleStatus.PositiveClosed, comment);
	}

	[PublicApiMember]
	public virtual void SetNegativeClosedStatus(ISale sale, string comment = null)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		Instance.ChangeStatus(sale, SaleStatus.NegativeClosed, comment);
	}

	[PublicApiMember]
	public virtual IEnumerable<IInpayment> GetAllInpayments(ISale sale)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		IInpaymentFilter inpaymentFilter = InterfaceActivator.Create<IInpaymentFilter>();
		inpaymentFilter.Sale = sale;
		ICollection<IInpayment> collection = EntityManager<IInpayment>.Instance.Find(inpaymentFilter, null);
		if (collection == null || !collection.Any())
		{
			throw new NullReferenceException(SR.T("Поступления не найдены"));
		}
		return collection;
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(ISale sale, string comment)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(sale, commentActionModel);
		sale.Comments.Add(comment2);
		sale.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, sale, SaleActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public virtual void AddComment(ISale sale, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(sale, comment);
			});
		}
		else
		{
			AddComment(sale, comment);
		}
	}

	[PublicApiMember]
	public IInpayment CreateInpayment(ISale sale)
	{
		IInpayment inpayment = InterfaceActivator.Create<IInpayment>();
		inpayment.Sale = sale;
		return inpayment;
	}

	[PublicApiMember]
	public ISaleType LoadSaleTypeOrNull(string saleTypeName)
	{
		ISaleTypeFilter saleTypeFilter = InterfaceActivator.Create<ISaleTypeFilter>();
		saleTypeFilter.Name = saleTypeName;
		ICollection<ISaleType> collection = EntityManager<ISaleType>.Instance.Find(saleTypeFilter, null);
		if (collection != null && collection.Count > 1)
		{
			throw new ArgumentException(SR.T("Найдено больше одного типа сделки с данным именем"));
		}
		return collection.FirstOrDefault();
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, EleWise.ELMA.Security.Models.IUser user)
	{
		DeletePermission(sale, user, CRMPermissionProvider.ViewSalePermission);
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, IUserGroup userGroup)
	{
		DeletePermission(sale, userGroup, CRMPermissionProvider.ViewSalePermission);
	}

	[PublicApiMember]
	public void DeleteAuthorPermission(ISale sale, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		DelAuthorPermission(permission, sale);
		if (permission == CRMPermissionProvider.ViewSalePermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale);
			DelAuthorPermission(CRMPermissionProvider.EditSalePermission, sale);
			DelAuthorPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale);
			DelAuthorPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale);
		}
		if (permission == CRMPermissionProvider.EditSalePermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale);
		}
		if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.EditSalePermission, sale);
			DelAuthorPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale);
		}
		if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale);
		}
		sale.Save();
	}

	[PublicApiMember]
	public void AddAuthorPermission(ISale sale, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (permission == CRMPermissionProvider.CRMSaleFullAccessPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale);
			AddAuthorOnePermission(CRMPermissionProvider.ViewSalePermission, sale);
			AddAuthorOnePermission(CRMPermissionProvider.EditSalePermission, sale);
			AddAuthorOnePermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale);
		}
		if (permission == CRMPermissionProvider.EditSalePermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale);
			AddAuthorOnePermission(CRMPermissionProvider.ViewSalePermission, sale);
		}
		if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewSalePermission, sale);
		}
		if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewSalePermission, sale);
		}
		sale.Save();
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, IOrganizationItem orgItem)
	{
		DeletePermission(sale, orgItem, CRMPermissionProvider.ViewSalePermission);
	}

	[PublicApiMember]
	public void EnableInheritPermissions(ISale sale)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(sale, enable: true);
	}

	[PublicApiMember]
	public void DisableInheritPermissions(ISale sale)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(sale, enable: false);
	}

	[PublicApiMember]
	public void AddPermission(ISale sale, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		if (AddOnePermission(permission, sale, user))
		{
			if (permission == CRMPermissionProvider.CRMSaleFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, user);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, user);
				AddOnePermission(CRMPermissionProvider.EditSalePermission, sale, user);
				AddOnePermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, user);
			}
			if (permission == CRMPermissionProvider.EditSalePermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, user);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, user);
			}
			if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, user);
			}
			if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, user);
			}
		}
		sale.Save();
	}

	[PublicApiMember]
	public void AddPermission(ISale sale, IUserGroup userGroup, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (AddOnePermission(permission, sale, userGroup))
		{
			if (permission == CRMPermissionProvider.CRMSaleFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, userGroup);
				AddOnePermission(CRMPermissionProvider.EditSalePermission, sale, userGroup);
				AddOnePermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, userGroup);
			}
			if (permission == CRMPermissionProvider.EditSalePermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, userGroup);
			}
		}
		sale.Save();
	}

	[PublicApiMember]
	public void AddPermission(ISale sale, IOrganizationItem orgItem, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		if (AddOnePermission(permission, sale, orgItem))
		{
			if (permission == CRMPermissionProvider.CRMSaleFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, orgItem);
				AddOnePermission(CRMPermissionProvider.EditSalePermission, sale, orgItem);
				AddOnePermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, orgItem);
			}
			if (permission == CRMPermissionProvider.EditSalePermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewSalePermission, sale, orgItem);
			}
		}
		sale.Save();
	}

	private bool AddOnePermission(Permission permission, ISale sale, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!((IEnumerable<ISalePersonPermission>)sale.Permission).Any((ISalePersonPermission r) => r.Assigned == user && r.PermissionId == permission.Id && !r.InheritedFromNumber.HasValue))
		{
			ISalePersonPermission salePersonPermission = SalePersonPermissionManager.Create();
			salePersonPermission.Sale = sale;
			salePersonPermission.PermissionId = permission.Id;
			salePersonPermission.User = user;
			salePersonPermission.PermissionRole = CommonRoleTypes.User.Id;
			sale.Permission.Add(salePersonPermission);
			return true;
		}
		return false;
	}

	private bool AddOnePermission(Permission permission, ISale sale, IUserGroup userGroup)
	{
		if (!((IEnumerable<ISalePersonPermission>)sale.Permission).Any((ISalePersonPermission r) => r.Assigned == userGroup && r.PermissionId == permission.Id))
		{
			ISalePersonPermission salePersonPermission = SalePersonPermissionManager.Create();
			salePersonPermission.Sale = sale;
			salePersonPermission.PermissionId = permission.Id;
			salePersonPermission.Group = userGroup;
			salePersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			sale.Permission.Add(salePersonPermission);
		}
		return true;
	}

	private bool AddOnePermission(Permission permission, ISale sale, IOrganizationItem orgItem)
	{
		if (!((IEnumerable<ISalePersonPermission>)sale.Permission).Any((ISalePersonPermission r) => r.Assigned == orgItem && r.PermissionId == permission.Id))
		{
			ISalePersonPermission salePersonPermission = SalePersonPermissionManager.Create();
			salePersonPermission.Sale = sale;
			salePersonPermission.PermissionId = permission.Id;
			salePersonPermission.OrganizationItemPosition = orgItem;
			salePersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			sale.Permission.Add(salePersonPermission);
		}
		return true;
	}

	private void AddAuthorOnePermission(Permission permission, ISale sale)
	{
		if (!((IEnumerable<ISalePersonPermission>)sale.Permission).Any(delegate(ISalePersonPermission r)
		{
			if (r.Assigned == sale.Author && r.PermissionId == permission.Id)
			{
				Guid? permissionRole = r.PermissionRole;
				Guid id = CommonRoleTypes.Author.Id;
				if (!permissionRole.HasValue)
				{
					return false;
				}
				if (!permissionRole.HasValue)
				{
					return true;
				}
				return permissionRole.GetValueOrDefault() == id;
			}
			return false;
		}))
		{
			ISalePersonPermission salePersonPermission = SalePersonPermissionManager.Create();
			salePersonPermission.Sale = sale;
			salePersonPermission.PermissionId = permission.Id;
			salePersonPermission.User = sale.Author;
			salePersonPermission.PermissionRole = CommonRoleTypes.Author.Id;
			sale.Permission.Add(salePersonPermission);
		}
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permission, sale);
		});
		if (hasPermission)
		{
			DelPermission(permission, sale, user);
			if (permission == CRMPermissionProvider.ViewSalePermission)
			{
				DelPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, user);
				DelPermission(CRMPermissionProvider.EditSalePermission, sale, user);
				DelPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, user);
				DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, user);
			}
			if (permission == CRMPermissionProvider.EditSalePermission)
			{
				DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, user);
			}
			if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
			{
				DelPermission(CRMPermissionProvider.EditSalePermission, sale, user);
				DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, user);
			}
			if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
			{
				DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, user);
			}
			sale.Save();
		}
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, IUserGroup userGroup, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		DelPermission(permission, sale, userGroup);
		if (permission == CRMPermissionProvider.ViewSalePermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, userGroup);
			DelPermission(CRMPermissionProvider.EditSalePermission, sale, userGroup);
			DelPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, userGroup);
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, userGroup);
		}
		if (permission == CRMPermissionProvider.EditSalePermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditSalePermission, sale, userGroup);
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, userGroup);
		}
		sale.Save();
	}

	[PublicApiMember]
	public void DeletePermission(ISale sale, IOrganizationItem orgItem, Permission permission)
	{
		if (sale == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		DelPermission(permission, sale, orgItem);
		if (permission == CRMPermissionProvider.ViewSalePermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, sale, orgItem);
			DelPermission(CRMPermissionProvider.EditSalePermission, sale, orgItem);
			DelPermission(CRMPermissionProvider.CRMSaleIssuanceElementPermission, sale, orgItem);
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, orgItem);
		}
		if (permission == CRMPermissionProvider.EditSalePermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMSaleCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditSalePermission, sale, orgItem);
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMSaleIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMSaleFullAccessPermission, sale, orgItem);
		}
		sale.Save();
	}

	private void DelPermission(Permission permissions, ISale sale, IUserGroup userGroup)
	{
		((ICollection<ISalePersonPermission>)sale.Permission).Remove(((IEnumerable<ISalePersonPermission>)sale.Permission).FirstOrDefault((ISalePersonPermission r) => r.Assigned == userGroup && r.PermissionId == permissions.Id));
	}

	private void DelAuthorPermission(Permission permissions, ISale sale)
	{
		((ICollection<ISalePersonPermission>)sale.Permission).Remove(((IEnumerable<ISalePersonPermission>)sale.Permission).FirstOrDefault((ISalePersonPermission r) => r.PermissionRole == CommonRoleTypes.Author.Id && r.PermissionId == permissions.Id));
	}

	private void DelPermission(Permission permissions, ISale sale, EleWise.ELMA.Security.Models.IUser user)
	{
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permissions, sale);
		});
		if (hasPermission)
		{
			((ICollection<ISalePersonPermission>)sale.Permission).Remove(((IEnumerable<ISalePersonPermission>)sale.Permission).FirstOrDefault((ISalePersonPermission r) => r.Assigned == user && r.PermissionId == permissions.Id));
		}
	}

	private void DelPermission(Permission permissions, ISale sale, IOrganizationItem orgItem)
	{
		((ICollection<ISalePersonPermission>)sale.Permission).Remove(((IEnumerable<ISalePersonPermission>)sale.Permission).FirstOrDefault((ISalePersonPermission r) => r.Assigned == orgItem && r.PermissionId == permissions.Id));
	}
}
