using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Exceptions;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class LeadManager : BaseCrmManager<ILead>
{
	private ITransformationProvider transformationProvider;

	private UserManager userManager;

	public static readonly Guid ThisWeekFilterUid = new Guid("A6DFDF57-7794-40A8-BD8B-77DE886C727C");

	public static readonly Guid LastWeekFilterUid = new Guid("9D991967-6D6E-4405-8EB8-785962A1548C");

	public static readonly Guid ThisMonthFilterUid = new Guid("B27BAA8C-B75B-4C48-B6D7-22914FC1C107");

	public static readonly Guid LastMonthFilterUid = new Guid("9C06CB78-5107-4F23-A5A6-564B8C5F312D");

	private ISessionProvider sessionProvider;

	private IThreadPool _pool;

	private ILogger log = EleWise.ELMA.Logging.Logger.GetLogger(typeof(LeadManager));

	private Type thisType;

	private MethodInfo convertPermissionContractorInfo;

	private MethodInfo fillDublicateContractorInfo;

	private MethodInfo fillDublicateLeadInfo;

	public ICacheService CacheService { get; set; }

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public ContractorManager ContractorManager { get; set; }

	public new IAuthenticationService AuthenticationService { get; set; }

	protected override string DefaultCriteriaAlias => "leadMn";

	public IEntityManager<ILeadPersonPermission> LeadPersonPermissionManager { get; set; }

	public new static LeadManager Instance => Locator.GetServiceNotNull<LeadManager>();

	private Type ThisType => thisType ?? (thisType = typeof(LeadManager));

	private MethodInfo ConvertPermissionContractorInfo => convertPermissionContractorInfo ?? (convertPermissionContractorInfo = ThisType.GetMethod("ConvertPermissionContractor", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[2]
	{
		typeof(ILead),
		typeof(IContractor)
	}, null));

	private MethodInfo FillDublicateContractorInfo => fillDublicateContractorInfo ?? (fillDublicateContractorInfo = ThisType.GetMethod("FillDublicateContractor", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(ILead) }, null));

	private MethodInfo FillDublicateLeadInfo => fillDublicateLeadInfo ?? (fillDublicateLeadInfo = ThisType.GetMethod("FillDublicateLead", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(ILead) }, null));

	public LeadManager(ITransformationProvider transformationProvider, UserManager userManager)
	{
		this.userManager = userManager;
		this.transformationProvider = transformationProvider;
	}

	public bool ForceShowSummary(IFilter filter)
	{
		if (filter != null)
		{
			if (!(filter.Uid == ThisWeekFilterUid) && !(filter.Uid == LastWeekFilterUid) && !(filter.Uid == ThisMonthFilterUid))
			{
				return filter.Uid == LastMonthFilterUid;
			}
			return true;
		}
		return false;
	}

	[Transaction]
	public virtual UpdateLeadsModel UpdateSqlLeadResponsible(long[] leadsId, long responsibleId)
	{
		UpdateLeadsModel updateLeadsModel = new UpdateLeadsModel();
		if (leadsId.Length == 0 || responsibleId == 0L)
		{
			return updateLeadsModel;
		}
		using IUnitOfWork unitOfWork = base.UnitOfWorkManager.Create(string.Empty, transactional: true, IsolationLevel.ReadCommitted);
		try
		{
			string text = LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead h) => h.Id));
			ILeadFilter leadFilter = InterfaceActivator.Create<ILeadFilter>();
			leadFilter.PermissionId = CRMPermissionProvider.EditLeadPermission.Id;
			EleWise.ELMA.Security.Models.IUser user = AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>.Instance.Load(responsibleId);
			IList<LeadAndResponsibleIdModel> list = CreateCriteria(leadFilter).Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property(text), (ICollection)leadsId)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id"), "LeadId").Add((IProjection)(object)Projections.Property("Responsible.Id"), "ResponsibleId") }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(LeadAndResponsibleIdModel)))
				.List<LeadAndResponsibleIdModel>();
			long[] array = list.Select((LeadAndResponsibleIdModel x) => x.LeadId).ToArray();
			long[] array2 = leadsId.Except(array).ToArray();
			if (array2.Length != 0)
			{
				updateLeadsModel.LeadsWithoutEditPermission = CreateCriteria().Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property(text), (ICollection)array2)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead h) => h.Name))) }).List<string>();
			}
			if (list.Count == 0)
			{
				unitOfWork.Commit();
				return updateLeadsModel;
			}
			string[] setsUpdate = new string[1] { string.Format("{0} = :responsible", transformationProvider.Dialect.QuoteIfNeeded("Responsible")) };
			Dictionary<string, long> parameters = new Dictionary<string, long> { { "responsible", user.Id } };
			updateLeadsModel.AnySuccess = ExecuteUpdateSqlColumnByIds(array, setsUpdate, null, parameters);
			UpdateLeadRolePermissions(CommonRoleTypes.Responsible, array, user.Id);
			AddToHistoryResponsible(list, user);
			unitOfWork.Commit();
			return updateLeadsModel;
		}
		catch (Exception error)
		{
			unitOfWork.Rollback();
			updateLeadsModel.Error = error;
			return updateLeadsModel;
		}
	}

	public LeadCounts SummaryLeadCounts(ILeadFilter filter)
	{
		bool disableSoftDeletable = filter.DisableSoftDeletable;
		filter.DisableSoftDeletable = true;
		SummaryLeadStatus? summaryLeadStatus = filter.SummaryLeadStatus;
		filter.SummaryLeadStatus = null;
		SimpleExpression criterion = Restrictions.Eq("IsDeleted", (object)false);
		AbstractCriterion criterion2 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.New));
		AbstractCriterion criterion3 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.InHand), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.ConversationNotStart)));
		AbstractCriterion criterion4 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Qualified));
		AbstractCriterion criterion5 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Unqualified));
		AbstractCriterion criterion6 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Dublicate));
		SimpleExpression criterion7 = Restrictions.Eq("IsDeleted", (object)true);
		ICriteria val = CreateCriteria(FetchOptions.All, base.ImplementationType, DefaultCriteriaAlias, filter).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion), "AllCount")).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion2), "NewCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion3), "InHandCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion4), "QualifiedCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion5), "UnqualifiedCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion6), "DublicateCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion7), "DeletedCount")) });
		SetupFilter(val, filter);
		filter.DisableSoftDeletable = disableSoftDeletable;
		filter.SummaryLeadStatus = summaryLeadStatus;
		return val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(LeadCounts))).UniqueResult<LeadCounts>();
	}

	public LeadMarketingStatisticCounts SummaryLeadMarketingStatisticCounts(ILeadFilter filter)
	{
		bool disableSoftDeletable = filter.DisableSoftDeletable;
		filter.DisableSoftDeletable = true;
		SummaryLeadStatus? summaryLeadStatus = filter.SummaryLeadStatus;
		filter.SummaryLeadStatus = null;
		SimpleExpression criterion = Restrictions.Eq("IsDeleted", (object)false);
		AbstractCriterion criterion2 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.New));
		AbstractCriterion criterion3 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.InHand), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.ConversationNotStart)));
		AbstractCriterion criterion4 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Qualified));
		AbstractCriterion criterion5 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Unqualified));
		AbstractCriterion criterion6 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Dublicate));
		SimpleExpression criterion7 = Restrictions.Eq("IsDeleted", (object)true);
		SimpleExpression criterion8 = Restrictions.Eq("s.SaleStatus", (object)SaleStatus.Active);
		SimpleExpression criterion9 = Restrictions.Eq("s.SaleStatus", (object)SaleStatus.PositiveClosed);
		SimpleExpression criterion10 = Restrictions.Eq("s.SaleStatus", (object)SaleStatus.NegativeClosed);
		ICriteria val = CreateCriteria(FetchOptions.All, base.ImplementationType, DefaultCriteriaAlias, filter).CreateAlias("Sale", "s", (JoinType)1).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion), "AllCount")).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion2), "NewCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion3), "InHandCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion4), "QualifiedCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion5), "UnqualifiedCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion6), "DublicateCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion7), "DeletedCount"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion8), "SaleCurrent"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion9), "SalePositive"))
			.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion10), "SaleNegative")) });
		SetupFilter(val, filter);
		filter.DisableSoftDeletable = disableSoftDeletable;
		filter.SummaryLeadStatus = summaryLeadStatus;
		ICriteria obj = CreateCriteria(FetchOptions.All, base.ImplementationType, "l").CreateAlias("Sale", "s", (JoinType)2, (ICriterion)(object)Restrictions.EqProperty("s.Id", "l.Sale")).Add((ICriterion)(object)Restrictions.IsNull("l.Id")).Add((ICriterion)(object)Restrictions.Eq("s.IsDeleted", (object)false))
			.Add((ICriterion)(object)Restrictions.Between("s.CreationDate", (object)filter.RelativeCreationDate.FromValue, (object)filter.RelativeCreationDate.ToValue))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNotNull("s.MarketingGroup"), (ICriterion)(object)Restrictions.IsNotNull("s.MarketingActivity")), (ICriterion)(object)Restrictions.IsNotNull("s.MarketingEffect")))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion8), "SaleCurrent")).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion9), "SalePositive"))
				.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion10), "SaleNegative")) });
		LeadMarketingStatisticCounts leadMarketingStatisticCounts = val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(LeadMarketingStatisticCounts))).UniqueResult<LeadMarketingStatisticCounts>();
		LeadMarketingStatisticCounts leadMarketingStatisticCounts2 = obj.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(LeadMarketingStatisticCounts))).UniqueResult<LeadMarketingStatisticCounts>();
		leadMarketingStatisticCounts.SaleCurrent += leadMarketingStatisticCounts2.SaleCurrent;
		leadMarketingStatisticCounts.SaleNegative += leadMarketingStatisticCounts2.SaleNegative;
		leadMarketingStatisticCounts.SalePositive += leadMarketingStatisticCounts2.SalePositive;
		return leadMarketingStatisticCounts;
	}

	public List<LeadDynamicCount> SummaryDynamicLeadCounts(List<DateTimeRange> periods, long marketingObjectId, bool isArchive)
	{
		IMarketingBase marketingBase = ((marketingObjectId > 0) ? MarketingBaseManager.Instance.Load(marketingObjectId) : null);
		SimpleExpression val = Restrictions.Eq(DefaultCriteriaAlias + ".IsDeleted", (object)false);
		SimpleExpression val2 = Restrictions.Eq(DefaultCriteriaAlias + ".Status", (object)LeadStatus.Qualified);
		List<ICriterion> list = periods.Select((DateTimeRange m) => DateTimeRangeDescriptor.GetCriterion(m, showTime: true, DefaultCriteriaAlias, "CreationDate")).ToList();
		ICriteria val3 = CreateCriteria(FetchOptions.All, base.ImplementationType, DefaultCriteriaAlias).CreateAlias("MarketingGroup", "mg", (JoinType)1).CreateAlias("MarketingActivity", "ma", (JoinType)1).CreateAlias("MarketingEffect", "me", (JoinType)1)
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("mg.IsDeleted"), (ICriterion)(object)Restrictions.Eq("mg.IsDeleted", (object)false)))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("ma.IsDeleted"), (ICriterion)(object)Restrictions.Eq("ma.IsDeleted", (object)false)))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("me.IsDeleted"), (ICriterion)(object)Restrictions.Eq("me.IsDeleted", (object)false)))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull("mg.Id"), (ICriterion)(object)Restrictions.Eq("mg.Status", (object)(isArchive ? MarketingObjectStatus.Archived : MarketingObjectStatus.Active))), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull("ma.Id"), (ICriterion)(object)Restrictions.Eq("ma.Status", (object)(isArchive ? MarketingObjectStatus.Archived : MarketingObjectStatus.Active)))), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull("me.Id"), (ICriterion)(object)Restrictions.Eq("me.Status", (object)(isArchive ? MarketingObjectStatus.Archived : MarketingObjectStatus.Active)))));
		ProjectionList val4 = Projections.ProjectionList().Add(Projections.Alias((IProjection)(object)Projections.GroupProperty(DefaultCriteriaAlias + ".MarketingGroup"), "MarketingGroup"));
		int num = 0;
		foreach (ICriterion item in list)
		{
			val4.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)Restrictions.And((ICriterion)(object)val, item)), "AllCountMonth" + num)).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.And((ICriterion)(object)val, (ICriterion)(object)val2), item)), "ConvertedCountMonth" + num));
			num++;
		}
		if (marketingObjectId == 0L)
		{
			val4.Add(Projections.Alias((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((ILead b) => b.MarketingActivity)), "MarketingActivity"));
			val3.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingActivity"), (ICriterion)(object)Restrictions.IsNull("MarketingGroup")));
		}
		else if (isArchive)
		{
			val4.Add(Projections.Alias((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((ILead b) => b.MarketingActivity)), "MarketingActivity"));
			val4.Add(Projections.Alias((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((ILead b) => b.MarketingEffect)), "MarketingEffect"));
			val3.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingGroup"), (ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingActivity")), (ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingEffect")));
		}
		else if (marketingBase != null)
		{
			if (marketingBase is IMarketingGroup)
			{
				val4.Add(Projections.Alias((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((ILead b) => b.MarketingActivity)), "MarketingActivity"));
				val3.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq(DefaultCriteriaAlias + ".MarketingGroup", (object)marketingBase), (ICriterion)(object)Restrictions.IsNotNull("MarketingActivity")));
			}
			else if (marketingBase is IMarketingActivity)
			{
				val4.Add(Projections.Alias((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((ILead b) => b.MarketingEffect)), "MarketingEffect"));
				val3.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq(DefaultCriteriaAlias + ".MarketingActivity", (object)marketingBase), (ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingEffect")));
			}
		}
		else
		{
			val3.Add((ICriterion)(object)Restrictions.IsNotNull(DefaultCriteriaAlias + ".MarketingGroup"));
		}
		val3.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)val4 });
		return val3.SetResultTransformer((IResultTransformer)(object)new LeadDynamicCountTransformer(periods.Count)).List<LeadDynamicCount>().ToList();
	}

	protected override ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		if (filter is ILeadFilter leadFilter && leadFilter.SummaryLeadStatus == SummaryLeadStatus.Deleted)
		{
			bool disableSoftDeletable = filter.DisableSoftDeletable;
			filter.DisableSoftDeletable = true;
			ICriteria result = base.CreateCriteria(fetchOptions, type, alias, filter);
			filter.DisableSoftDeletable = disableSoftDeletable;
			return result;
		}
		return base.CreateCriteria(fetchOptions, type, alias, filter);
	}

	[Obsolete]
	private void SetupObsoleteFilter(ICriteria criteria, ILeadFilter leadFilter)
	{
		if (leadFilter.MarketingGroup != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)leadFilter.MarketingGroup));
		}
		if (leadFilter.MarketingActivity != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)leadFilter.MarketingActivity));
		}
		if (leadFilter.MarketingEffect != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingEffect", (object)leadFilter.MarketingEffect));
		}
		ICriterion criterion = DateTimeRangeDescriptor.GetCriterion(leadFilter.CreationDate, showTime: true, (criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias, "CreationDate");
		if (criterion != null)
		{
			criteria.Add(criterion);
		}
		ICriterion criterion2 = DateTimeRangeDescriptor.GetCriterion(leadFilter.ChangeDate, showTime: true, (criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias, "ChangeDate");
		if (criterion2 != null)
		{
			criteria.Add(criterion2);
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		base.SetupFilter(criteria, filter);
		if (!(filter is ILeadFilter leadFilter))
		{
			return;
		}
		SetupObsoleteFilter(criteria, leadFilter);
		if (leadFilter.Active.HasValue)
		{
			AbstractCriterion val = Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.New), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.InHand), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.ConversationNotStart)));
			if (leadFilter.Active == false)
			{
				val = Restrictions.Not((ICriterion)(object)val);
			}
			criteria.Add((ICriterion)(object)val);
		}
		if (leadFilter.ShowOnlyMy)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)AuthenticationService.GetCurrentUser()));
		}
		if (!string.IsNullOrEmpty(leadFilter.Phone))
		{
			string alias = "PhoneAlias";
			DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<ILead>()).Add((ICriterion)(object)ElmaRestrictions.Like("PhoneAlias.PhoneString", leadFilter.Phone, MatchMode.Exact)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Phone", "Phone", (JoinType)0, ref alias).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
		}
		if (!string.IsNullOrEmpty(leadFilter.Email))
		{
			string alias2 = "EmailAlias";
			DetachedCriteria val3 = DetachedCriteria.For(InterfaceActivator.TypeOf<ILead>()).Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike("EmailAlias.EmailString", leadFilter.Email, MatchMode.Anywhere)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Email", "Email", (JoinType)0, ref alias2).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val3));
		}
		if (leadFilter.MarketingObjects != null && ((IEnumerable<IMarketingBase>)leadFilter.MarketingObjects).Any())
		{
			List<IMarketingGroup> list = new List<IMarketingGroup>();
			List<IMarketingActivity> list2 = new List<IMarketingActivity>();
			List<IMarketingEffect> list3 = new List<IMarketingEffect>();
			foreach (IMarketingBase item in (IEnumerable<IMarketingBase>)leadFilter.MarketingObjects)
			{
				if (item is IMarketingGroup)
				{
					list.Add((IMarketingGroup)item);
					continue;
				}
				if (item is IMarketingActivity)
				{
					list2.Add((IMarketingActivity)item);
					continue;
				}
				if (item is IMarketingEffect)
				{
					list3.Add((IMarketingEffect)item);
					continue;
				}
				throw new NotSupportedException(SR.T("Неподдерживаемый тип объекта маркетинга: {0}", item.GetType().FullName));
			}
			criteria.Add((ICriterion)(object)((Junction)new Disjunction()).Add((ICriterion)(object)Restrictions.In("MarketingGroup", (ICollection)list)).Add((ICriterion)(object)Restrictions.In("MarketingActivity", (ICollection)list2)).Add((ICriterion)(object)Restrictions.In("MarketingEffect", (ICollection)list3)));
		}
		if (leadFilter.RelativeCreationDate != null)
		{
			ICriterion criterion = DateTimeRangeDescriptor.GetCriterion(RelativeDateTimeDescriptor.GetDateTimeRange(leadFilter.RelativeCreationDate), showTime: true, (criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias, "CreationDate");
			if (criterion != null)
			{
				criteria.Add(criterion);
			}
		}
		if (leadFilter.RelativeChangeDate != null)
		{
			ICriterion criterion2 = DateTimeRangeDescriptor.GetCriterion(RelativeDateTimeDescriptor.GetDateTimeRange(leadFilter.RelativeChangeDate), showTime: true, (criteria is DetachedCriteriaAdapter) ? criteria.get_Alias() : DefaultCriteriaAlias, "ChangeDate");
			if (criterion2 != null)
			{
				criteria.Add(criterion2);
			}
		}
		if (leadFilter.SummaryLeadStatus.HasValue)
		{
			if (leadFilter.SummaryLeadStatus == SummaryLeadStatus.Deleted)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)true));
			}
			else if (leadFilter.SummaryLeadStatus == SummaryLeadStatus.Closed)
			{
				criteria.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Qualified), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Unqualified))));
			}
			else if (leadFilter.SummaryLeadStatus == SummaryLeadStatus.InHand)
			{
				criteria.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.InHand), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.ConversationNotStart))));
			}
			else
			{
				criteria.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)(LeadStatus)leadFilter.SummaryLeadStatus.Value)));
			}
		}
	}

	public PropertyMap ConvertToContractorMap(Type destType)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<ILead>());
		ClassMetadata classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(destType);
		PropertyMap propertyMap = new PropertyMap
		{
			LeftClassUid = classMetadata.Uid,
			RightClassUid = classMetadata2.Uid
		};
		foreach (PropertyMetadata prop in classMetadata.Properties)
		{
			if (!prop.Name.Equals("Id") && !prop.Name.Equals("CreationDate") && !prop.Name.Equals("CreationAuthor") && !prop.Name.Equals("ChangeAuthor") && !prop.Name.Equals("ChangeDate") && !prop.Name.Equals("Permission") && !prop.Name.Equals("InheritPermissions") && !prop.Name.Equals("Contacts"))
			{
				PropertyMetadata propertyMetadata = classMetadata2.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == prop.Name);
				if (propertyMetadata != null)
				{
					propertyMap.Items.Add(new PropertyMapItem
					{
						LeftPropertyUid = prop.Uid,
						RightPropertyUid = propertyMetadata.Uid
					});
				}
			}
		}
		Guid legalAddressPropertyUid = classMetadata2.Properties.First((PropertyMetadata p) => p.Name.Equals("LegalAddress")).Uid;
		if (!propertyMap.Items.Exists((PropertyMapItem m) => m.RightPropertyUid == legalAddressPropertyUid))
		{
			propertyMap.Items.Add(new PropertyMapItem
			{
				LeftPropertyUid = classMetadata.Properties.First((PropertyMetadata p) => p.Name.Equals("Address")).Uid,
				RightPropertyUid = legalAddressPropertyUid
			});
		}
		else
		{
			Guid postalAddressPropertyUid = classMetadata2.Properties.First((PropertyMetadata p) => p.Name.Equals("PostalAddress")).Uid;
			if (!propertyMap.Items.Exists((PropertyMapItem m) => m.RightPropertyUid == postalAddressPropertyUid))
			{
				propertyMap.Items.Add(new PropertyMapItem
				{
					LeftPropertyUid = classMetadata.Properties.First((PropertyMetadata p) => p.Name.Equals("Address")).Uid,
					RightPropertyUid = postalAddressPropertyUid
				});
			}
		}
		return propertyMap;
	}

	public PropertyMap ConvertToContactMap()
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<ILeadContact>());
		ClassMetadata classMetadata2 = (ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContact>());
		PropertyMap propertyMap = new PropertyMap
		{
			LeftClassUid = classMetadata.Uid,
			RightClassUid = classMetadata2.Uid
		};
		foreach (PropertyMetadata prop in classMetadata.Properties)
		{
			if (!prop.Name.Equals("Id") && !prop.Name.Equals("CreationDate") && !prop.Name.Equals("CreationAuthor") && !prop.Name.Equals("ChangeAuthor") && !prop.Name.Equals("ChangeDate"))
			{
				PropertyMetadata propertyMetadata = classMetadata2.Properties.FirstOrDefault((PropertyMetadata p) => p.Name.ToUpper() == prop.Name.ToUpper());
				if (propertyMetadata != null)
				{
					propertyMap.Items.Add(new PropertyMapItem
					{
						LeftPropertyUid = prop.Uid,
						RightPropertyUid = propertyMetadata.Uid
					});
				}
			}
		}
		return propertyMap;
	}

	[ActionCheck("67d829bf-c660-43bf-8fe5-251181c95e0a")]
	public virtual bool CanConvertComplete([NotNull] ILead lead, [NotNull] IContractor contractor, IEnumerable<IContact> contacts, ISale sale, IRelationship relationship, string commentText)
	{
		if (lead.Status != LeadStatus.Qualified)
		{
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
		}
		return false;
	}

	[Transaction]
	[ActionMethod("67d829bf-c660-43bf-8fe5-251181c95e0a")]
	public virtual void ConvertComplete([NotNull] ILead lead, [NotNull] IContractor contractor, IEnumerable<IContact> contacts, ISale sale, IRelationship relationship, string commentText)
	{
		ContractorManager.SaveWithCategoryRules(contractor, RuleDeletedCategoryAction.Revert);
		ConvertPermissionContractor(lead, contractor);
		contractor.Save();
		if (sale != null)
		{
			lead.Sale = sale;
			sale.Save();
		}
		relationship?.Save();
		lead.Status = LeadStatus.Qualified;
		lead.Contractor = contractor;
		lead.ConvertDate = DateTime.Now;
		IComment comment = null;
		if (!string.IsNullOrEmpty(commentText))
		{
			comment = InterfaceActivator.Create<IComment>();
			comment.Text = commentText;
			comment.Save();
			lead.Comments.Add(comment);
		}
		lead.ConvertComment = comment;
		lead.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(lead, lead, LeadActions.QualifiedGuid));
		base.Session.Flush();
		ReconfigurePermissionAfterConvert(contractor);
	}

	private static ISet<IComment> CloneComments(ISet<IComment> comments)
	{
		if (comments == null || !((IEnumerable<IComment>)comments).Any())
		{
			return null;
		}
		HashedSet<IComment> val = new HashedSet<IComment>();
		((Set<IComment>)(object)val).Clear();
		foreach (IComment item in (IEnumerable<IComment>)comments)
		{
			IComment comment = InterfaceActivator.Create<IComment>();
			comment.Text = item.Text;
			((Set<IComment>)(object)val).Add(comment);
		}
		return (ISet<IComment>)(object)val;
	}

	private static ISet<IEmail> CloneEmail(ISet<IEmail> email)
	{
		if (email == null || !((IEnumerable<IEmail>)email).Any())
		{
			return null;
		}
		HashedSet<IEmail> val = new HashedSet<IEmail>();
		((Set<IEmail>)(object)val).Clear();
		foreach (IEmail item in (IEnumerable<IEmail>)email)
		{
			IEmail email2 = InterfaceActivator.Create<IEmail>();
			email2.EmailString = item.EmailString;
			((Set<IEmail>)(object)val).Add(email2);
		}
		return (ISet<IEmail>)(object)val;
	}

	private static ISet<IPhone> ClonePhone(ISet<IPhone> phone)
	{
		if (phone == null || !((IEnumerable<IPhone>)phone).Any())
		{
			return null;
		}
		HashedSet<IPhone> val = new HashedSet<IPhone>();
		((Set<IPhone>)(object)val).Clear();
		foreach (IPhone item in (IEnumerable<IPhone>)phone)
		{
			IPhone phone2 = InterfaceActivator.Create<IPhone>();
			phone2.PhoneString = item.PhoneString;
			((Set<IPhone>)(object)val).Add(phone2);
		}
		return (ISet<IPhone>)(object)val;
	}

	private static IAddress CloneAddress(IAddress address)
	{
		if (address == null)
		{
			return null;
		}
		return CloneHelperBuilder.Create(address).Clone();
	}

	private void CloneContacts(ISet<IContact> srcContacts, ISet<ILeadContact> tgtContacts)
	{
		if (tgtContacts == null || !((IEnumerable<ILeadContact>)tgtContacts).Any())
		{
			return;
		}
		foreach (ILeadContact item in (IEnumerable<ILeadContact>)tgtContacts)
		{
			IContact contact = InterfaceActivator.Create<IContact>();
			contact.Email = CloneEmail(item.Email);
			contact.Firstname = item.Firstname;
			contact.Icq = item.ICQ;
			contact.Middlename = item.Middlename;
			contact.Name = item.Name;
			contact.Phone = ClonePhone(item.Phone);
			contact.Position = item.Position;
			contact.Skype = item.Skype;
			contact.Surname = item.Surname;
			srcContacts.Add(contact);
		}
	}

	[ActionCheck("69949aae-a844-4920-8e8a-db4cffeebe91")]
	public virtual bool CanFail(ILead lead, bool convert, string commentText)
	{
		if (lead.Status != LeadStatus.Unqualified)
		{
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
		}
		return false;
	}

	[Transaction]
	[ActionMethod("69949aae-a844-4920-8e8a-db4cffeebe91")]
	public virtual void Fail(ILead lead, bool convert, string commentText)
	{
		if (convert)
		{
			IContractorLegal contractorLegal = InterfaceActivator.Create<IContractorLegal>();
			contractorLegal.Comments = CloneComments(lead.Comments);
			contractorLegal.Description = lead.Description;
			contractorLegal.Email = CloneEmail(lead.Email);
			contractorLegal.Phone = ClonePhone(lead.Phone);
			contractorLegal.LegalAddress = CloneAddress(lead.Address);
			CloneContacts(contractorLegal.Contacts, lead.Contacts);
			contractorLegal.LegalForm = lead.LegalForm;
			contractorLegal.Name = lead.Name;
			contractorLegal.Responsible = lead.Responsible;
			contractorLegal.Site = lead.Site;
			contractorLegal.Save();
			lead.Contractor = contractorLegal;
		}
		lead.Status = LeadStatus.Unqualified;
		lead.ConvertDate = DateTime.Now;
		IComment comment = null;
		if (!string.IsNullOrEmpty(commentText))
		{
			comment = InterfaceActivator.Create<IComment>();
			comment.Text = commentText;
			comment.Save();
			lead.Comments.Add(comment);
		}
		lead.ConvertComment = comment;
		lead.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(lead, lead, LeadActions.UnqualifiedGuid));
	}

	[ActionCheck("932ce7e9-1d01-4d19-b44f-80b015650d70")]
	public virtual bool CanBeginWork(ILead lead)
	{
		if (lead.Status == LeadStatus.New)
		{
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
		}
		return false;
	}

	[Transaction]
	[ActionMethod("932ce7e9-1d01-4d19-b44f-80b015650d70")]
	public virtual void BeginWork(ILead lead)
	{
		lead.Status = LeadStatus.InHand;
		lead.InHandDate = DateTime.Now;
		lead.Save();
	}

	[Transaction]
	public virtual void ConversationNotStart(ILead lead)
	{
		lead.Status = LeadStatus.ConversationNotStart;
		lead.InHandDate = DateTime.Now;
		lead.Save();
	}

	[ActionCheck("769ca33f-c027-4659-b9e9-00d0d2098616")]
	public virtual bool CanActivate(ILead lead)
	{
		if (lead.Status == LeadStatus.Unqualified || lead.Status == LeadStatus.Dublicate)
		{
			return base.SecurityService.HasPermission(CRMPermissionProvider.EditLeadPermission, lead);
		}
		return false;
	}

	[Transaction]
	public virtual UpdateLeadsModel ActivateManyLeads(long[] leadsId)
	{
		UpdateLeadsModel updateLeadsModel = new UpdateLeadsModel();
		if (leadsId.Length == 0)
		{
			return updateLeadsModel;
		}
		try
		{
			string text = LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead h) => h.Id));
			ILeadFilter leadFilter = InterfaceActivator.Create<ILeadFilter>();
			leadFilter.PermissionId = CRMPermissionProvider.EditLeadPermission.Id;
			IList<ILead> list = CreateCriteria(leadFilter).Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property(text), (ICollection)leadsId)).List<ILead>();
			long[] array = leadsId.Except(list.Select((ILead x) => x.Id)).ToArray();
			if (array.Length != 0)
			{
				updateLeadsModel.LeadsWithoutEditPermission = CreateCriteria().Add((ICriterion)(object)Restrictions.In((IProjection)(object)Projections.Property(text), (ICollection)array)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead h) => h.Name))) }).List<string>();
			}
			if (list.Count == 0)
			{
				return updateLeadsModel;
			}
			List<ILead> list2 = new List<ILead>();
			foreach (ILead item in list)
			{
				switch (item.Status)
				{
				case LeadStatus.Unqualified:
					list2.Add(item);
					break;
				case LeadStatus.Dublicate:
					ActivateDuplicate(item, needHistory: true);
					break;
				default:
					updateLeadsModel.LeadsIncorrectStatus.Add(item.Name);
					break;
				}
			}
			ChangeStatusAndResponsibleForLeads(list2);
			return updateLeadsModel;
		}
		catch (Exception ex)
		{
			Exception ex3 = (updateLeadsModel.Error = ex);
			return updateLeadsModel;
		}
	}

	private bool ChangeStatusAndResponsibleForLeads(ICollection<ILead> leads)
	{
		if (leads.Count == 0)
		{
			return false;
		}
		string arg = transformationProvider.Dialect.QuoteIfNeeded("Status");
		string arg2 = transformationProvider.Dialect.QuoteIfNeeded("Responsible");
		string[] setsUpdate = new string[3]
		{
			$"{arg} = :status",
			string.Format("{0} = null", transformationProvider.Dialect.QuoteIfNeeded("ConvertComment")),
			string.Format("{0} = null", transformationProvider.Dialect.QuoteIfNeeded("ConvertDate"))
		};
		Dictionary<string, long> parameters = new Dictionary<string, long> { { "status", 0L } };
		bool result = ExecuteUpdateSqlColumnByIds(leads.Select((ILead i) => i.Id).ToArray(), setsUpdate, null, parameters);
		IEnumerable<ILead> source = leads.Where((ILead i) => i.Responsible == null);
		if (source.Any())
		{
			EleWise.ELMA.Security.Models.IUser currentUser = userManager.GetCurrentUser();
			setsUpdate = new string[1] { $"{arg2} = :responsible" };
			parameters = new Dictionary<string, long> { { "responsible", currentUser.Id } };
			string[] moreWhere = new string[2]
			{
				$"{arg2} is null",
				$"{arg} = {0L}"
			};
			ExecuteUpdateSqlColumnByIds(source.Select((ILead x) => x.Id).ToArray(), setsUpdate, moreWhere, parameters);
			AddToHistoryResponsible(source.Select((ILead x) => new LeadAndResponsibleIdModel
			{
				LeadId = x.Id,
				ResponsibleId = ((x.Responsible != null) ? x.Responsible.Id : 0)
			}).ToList(), currentUser);
		}
		foreach (ILead lead in leads)
		{
			base.ActionHandler.ActionExecuted(new EntityActionEventArgs(lead, lead, LeadActions.ActivatedGuid));
		}
		return result;
	}

	private void AddToHistoryResponsible(IList<LeadAndResponsibleIdModel> leadsAndOldResponsible, EleWise.ELMA.Security.Models.IUser newResponsible)
	{
		if (leadsAndOldResponsible.Count == 0)
		{
			return;
		}
		EleWise.ELMA.Security.Models.IUser[] source = (from a in leadsAndOldResponsible
			where a.ResponsibleId != 0
			select a into i
			select i.ResponsibleId).Distinct().Select(userManager.Load).ToArray();
		foreach (LeadAndResponsibleIdModel lead in leadsAndOldResponsible)
		{
			ILead @new = new InstanceOf<ILead>().New;
			ILead new2 = new InstanceOf<ILead>().New;
			@new.Id = lead.LeadId;
			if (lead.ResponsibleId != 0L)
			{
				@new.Responsible = source.Where((EleWise.ELMA.Security.Models.IUser i) => i.Id == lead.ResponsibleId).FirstOrDefault();
			}
			new2.Id = lead.LeadId;
			new2.Responsible = newResponsible;
			base.ActionHandler.ActionExecuted(new EditEntityActionEventArgs(@new, new2, new string[1] { "Responsible" }));
		}
	}

	private bool ExecuteUpdateSqlColumnByIds(long[] ids, IEnumerable<string> setsUpdate, IEnumerable<string> moreWhere = null, Dictionary<string, long> parameters = null)
	{
		if (!ids.Any() || !setsUpdate.Any())
		{
			return false;
		}
		string text = LinqUtils.NameOf((Expression<Func<ILead, object>>)((ILead h) => h.Id));
		string text2 = string.Format("Update Lead set {0} where {1} {2}", string.Join(", ", setsUpdate), ElmaInExpression.ToString(text, ids), (moreWhere != null && moreWhere.Any()) ? (" AND " + string.Join(" AND ", moreWhere)) : string.Empty);
		ISQLQuery val = base.Session.CreateSQLQuery(text2);
		if (parameters != null)
		{
			foreach (KeyValuePair<string, long> parameter in parameters)
			{
				((IQuery)val).SetParameter<long>(parameter.Key, parameter.Value);
			}
		}
		return ((IQuery)(object)val).ExecuteUpdate(cleanUpCache: false) > 0;
	}

	private void UpdateLeadRolePermissions(PermissionRoleType roleType, long[] ids, long setUserId)
	{
		if (ids.Length != 0)
		{
			EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<ILeadPersonPermission>(inherit: false);
			string text = base.Transformation.Dialect.QuoteIfNeeded(entityMetadata.TableName);
			string text2 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<ILeadPersonPermission, object>>)((ILeadPersonPermission h) => h.Lead)));
			string text3 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<ILeadPersonPermission, object>>)((ILeadPersonPermission h) => h.User)));
			string text4 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<ILeadPersonPermission, object>>)((ILeadPersonPermission h) => h.PermissionRole)));
			string text5 = base.Transformation.Dialect.QuoteIfNeeded(LinqUtils.NameOf((Expression<Func<ILeadPersonPermission, object>>)((ILeadPersonPermission h) => h.UserSecuritySetCacheId)));
			string text6 = $"UPDATE {text} SET {text3} = :user, {text5} = :cacheId WHERE {text4} = :role AND {ElmaInExpression.ToString(text2, ids)}";
			((IQuery)base.Session.CreateSQLQuery(text6)).SetParameter<long>("user", setUserId).SetParameter<long>("cacheId", UserSecuritySetHelper.GetUserMask(setUserId)).SetParameter<Guid>("role", roleType.Id)
				.ExecuteUpdate(cleanUpCache: false);
		}
	}

	private void ActivateDuplicate(ILead lead, bool needHistory = false)
	{
		lead.Status = LeadStatus.New;
		lead.DublicateContractor = null;
		lead.DublicateLead = null;
		lead.DublicateSale = null;
		lead.PossibleDublicateContractor = (ISet<IDublicateContractor>)(object)new Set<IDublicateContractor>();
		lead.PossibleDublicateLead = (ISet<IDublicateLead>)(object)new Set<IDublicateLead>();
		lead.DublicateComment = null;
		CheckDublicateLead(lead);
		if (lead.Responsible == null)
		{
			lead.Responsible = userManager.GetCurrentUser();
		}
		lead.ConvertComment = null;
		lead.ConvertDate = null;
		lead.Save();
		if (needHistory)
		{
			base.ActionHandler.ActionExecuted(new EntityActionEventArgs(lead, lead, LeadActions.ActivatedGuid));
		}
	}

	[Transaction]
	[ActionMethod("769ca33f-c027-4659-b9e9-00d0d2098616")]
	public virtual void Activate(ILead lead)
	{
		bool flag = false;
		switch (lead.Status)
		{
		case LeadStatus.Qualified:
		case LeadStatus.Unqualified:
			lead.Status = LeadStatus.New;
			flag = true;
			break;
		case LeadStatus.Dublicate:
			ActivateDuplicate(lead);
			flag = true;
			break;
		}
		if (lead.Responsible == null)
		{
			lead.Responsible = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			flag = true;
		}
		if (flag)
		{
			lead.ConvertComment = null;
			lead.ConvertDate = null;
			lead.Save();
			base.ActionHandler.ActionExecuted(new EntityActionEventArgs(lead, lead, LeadActions.ActivatedGuid));
		}
	}

	[ActionCheck("e6e05588-fa3b-44fc-b817-a76be2505c87")]
	public virtual bool CanDublicate([NotNull] ILead thisLead, string comment, bool copyContacts, IContractor contractor = null, ILead lead = null, ISale sale = null)
	{
		if (thisLead.Status != LeadStatus.Qualified && thisLead.Status != LeadStatus.Unqualified && thisLead.Status != LeadStatus.Dublicate)
		{
			return CRMPermissionProvider.CheckAny(new Permission[1] { CRMPermissionProvider.CRMDublicateLeadPermission });
		}
		return false;
	}

	[ActionMethod("e6e05588-fa3b-44fc-b817-a76be2505c87")]
	[Transaction]
	public virtual ILead Dublicate([NotNull] ILead thisLead, string comment, bool copyContacts, IContractor contractor = null, ILead lead = null, ISale sale = null)
	{
		if (sale != null)
		{
			thisLead.DublicateSale = sale;
			thisLead.DublicateContractor = sale.Contractor;
			thisLead.Responsible = sale.Responsible;
		}
		else if (contractor != null)
		{
			thisLead.DublicateContractor = contractor;
			thisLead.Responsible = contractor.Responsible;
		}
		else if (lead != null)
		{
			thisLead.DublicateLead = lead;
			thisLead.Responsible = lead.Responsible;
		}
		if (copyContacts && thisLead.DublicateLead != null && thisLead.Contacts != null)
		{
			foreach (ILeadContact item in (IEnumerable<ILeadContact>)thisLead.Contacts)
			{
				ILeadContact leadContact = CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<ILeadContact> r)
				{
					r.Rule().ForPropertyName((ILeadContact c) => c.Lead).Ignore();
				}).Clone();
				leadContact.Lead = thisLead.DublicateLead;
				leadContact.Save();
			}
		}
		if (copyContacts && thisLead.DublicateContractor != null && thisLead.Contacts != null)
		{
			PropertyMap map = ConvertToContactMap();
			foreach (ILeadContact item2 in (IEnumerable<ILeadContact>)thisLead.Contacts)
			{
				IContact contact = InterfaceActivator.Create<IContact>();
				PropertyMapHelper.Map(item2, contact, map);
				contact.Contractor = thisLead.DublicateContractor;
				contact.Save();
			}
		}
		LeadDublicateStateManager.Instance.SetDublicateState(thisLead, LeadDublicateStatus.Dublicate);
		thisLead.Status = LeadStatus.Dublicate;
		if (!string.IsNullOrEmpty(comment))
		{
			IComment comment2 = InterfaceActivator.Create<IComment>();
			comment2.Text = comment;
			comment2.Save();
			thisLead.Comments.Add(comment2);
		}
		thisLead.DublicateComment = comment;
		thisLead.Save();
		base.ActionHandler.ActionExecuted(new EntityActionEventArgs(null, thisLead, "e6e05588-fa3b-44fc-b817-a76be2505c87"));
		return thisLead;
	}

	private ICriteria GetDublicateContractorCriteria(ILead lead, FetchOptions fetchOptions = null)
	{
		return CreateCriteria(fetchOptions, InterfaceActivator.TypeOf<IDublicateContractor>()).Add((ICriterion)(object)Restrictions.Eq("Lead", (object)lead));
	}

	private ICriteria GetDublicateLeadCriteria(ILead lead, FetchOptions fetchOptions = null)
	{
		return CreateCriteria(fetchOptions, InterfaceActivator.TypeOf<IDublicateLead>()).Add((ICriterion)(object)Restrictions.Eq("Lead", (object)lead));
	}

	[ContextCache]
	public virtual long GetMaxPercentPossibleDublicateContractors(ILead lead)
	{
		return GetDublicateContractorCriteria(lead).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Max((IProjection)(object)Projections.Property("Weight")) }).UniqueResult<long>();
	}

	[ContextCache]
	public virtual long GetMaxPercentPossibleDublicateLeads(ILead lead)
	{
		return GetDublicateLeadCriteria(lead).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Max((IProjection)(object)Projections.Property("Weight")) }).UniqueResult<long>();
	}

	[ContextCache]
	public virtual long DublicateContractorsCount(ILead lead)
	{
		return ReturnCount(GetDublicateContractorCriteria(lead));
	}

	[ContextCache]
	public virtual long DublicateLeadsCount(ILead lead)
	{
		return ReturnCount(GetDublicateLeadCriteria(lead));
	}

	public ICollection<IDublicateContractor> DublicateContractors(FetchOptions fetchOptions, ILead lead)
	{
		return GetDublicateContractorCriteria(lead, fetchOptions).SetFetchMode("Dublicate", (FetchMode)2).List<IDublicateContractor>();
	}

	public ICollection<IDublicateLead> DublicateLeads(FetchOptions fetchOptions, ILead lead)
	{
		return GetDublicateLeadCriteria(lead, fetchOptions).SetFetchMode("Dublicate", (FetchMode)2).List<IDublicateLead>();
	}

	public SaveWithCategoryRulesResult SaveWithCategoryRules(ILead lead, RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
	{
		return CategoryAssignMethodManager.Instance.SaveWithCategoryRules(lead, lead.Categories, CategoryRuleType.RuleForLeads, ruleDeletedCategoryAction);
	}

	[Transaction]
	[PublicApiMember]
	public override void Delete(ILead obj)
	{
		foreach (IRelationship item in RelationshipManager.Instance.Find((IRelationship x) => x.Lead == obj))
		{
			if (item.Contractor != null)
			{
				item.Lead = null;
				item.Save();
			}
			else
			{
				item.Delete();
			}
		}
		base.Delete(obj);
	}

	public void LinkToMarketing(ILead lead, IMarketingBase marketingBase)
	{
		if (lead == null)
		{
			throw new ArgumentException("Null argument: lead");
		}
		IMarketingBase marketingBase2 = marketingBase.CastAsRealType();
		if (marketingBase2 is IMarketingGroup)
		{
			lead.MarketingGroup = (IMarketingGroup)marketingBase2;
		}
		else if (marketingBase2 is IMarketingActivity)
		{
			lead.MarketingActivity = (IMarketingActivity)marketingBase2;
		}
		else
		{
			if (!(marketingBase2 is IMarketingEffect))
			{
				throw new Exception(SR.T("Неизвестный тип объекта маркетинга"));
			}
			lead.MarketingEffect = (IMarketingEffect)marketingBase2;
		}
		lead.Save();
	}

	private void UpdateMarketingCounters(IMarketingBase marketingBase, string propName)
	{
		if (marketingBase != null)
		{
			AbstractCriterion criterion = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Dublicate)));
			AbstractCriterion criterion2 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.In("Status", (ICollection)new LeadStatus[4]
			{
				LeadStatus.InHand,
				LeadStatus.ConversationNotStart,
				LeadStatus.Qualified,
				LeadStatus.Unqualified
			}));
			AbstractCriterion criterion3 = Restrictions.And((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false), (ICriterion)(object)Restrictions.Eq("Status", (object)LeadStatus.Qualified));
			MarketingLeadCount marketingLeadCount = CreateCriteria(new Filter
			{
				DisableSoftDeletable = true
			}).Add((ICriterion)(object)Restrictions.Eq(propName, (object)marketingBase)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add(Projections.Alias(Projections.RowCount(), "DirtyCount")).Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion), "CleanCount"))
				.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion2), "AcceptedCount"))
				.Add(Projections.Alias((IProjection)(object)new ConditionalCountProjection((ICriterion)(object)criterion3), "QualifiedCount")) }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(MarketingLeadCount)))
				.UniqueResult<MarketingLeadCount>();
			marketingBase.DirtyLeadCount = marketingLeadCount.DirtyCount;
			marketingBase.CleanLeadCount = marketingLeadCount.CleanCount;
			marketingBase.AcceptedLeadCount = marketingLeadCount.AcceptedCount;
			marketingBase.QualifiedLeadCount = marketingLeadCount.QualifiedCount;
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

	public void UpdateMarketingCounters(ILead lead)
	{
		UpdateMarketingCounters(lead.MarketingGroup, "MarketingGroup");
		UpdateMarketingCounters(lead.MarketingActivity, "MarketingActivity");
		UpdateMarketingCounters(lead.MarketingEffect, "MarketingEffect");
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddComment(ILead lead, string comment)
	{
		if (lead == null)
		{
			throw new NullReferenceException(SR.T("Возможность не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(lead, commentActionModel);
		lead.Comments.Add(comment2);
		lead.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, lead, LeadActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public virtual void AddComment(ILead lead, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(lead, comment);
			});
		}
		else
		{
			AddComment(lead, comment);
		}
	}

	[PublicApiMember]
	public void SetStatus(ILead lead, LeadStatus leadStatus)
	{
		SetStatus(lead, leadStatus, string.Empty);
	}

	[PublicApiMember]
	public void SetStatus(ILead lead, LeadStatus leadStatus, string comment)
	{
		switch (leadStatus)
		{
		case LeadStatus.New:
			Activate(lead);
			break;
		case LeadStatus.InHand:
			BeginWork(lead);
			break;
		case LeadStatus.ConversationNotStart:
			ConversationNotStart(lead);
			break;
		case LeadStatus.Unqualified:
			Fail(lead, convert: false, null);
			break;
		case LeadStatus.Qualified:
		case LeadStatus.Dublicate:
			throw new ArgumentException(SR.T("Статус не должен быть Dublicate или Qualified"));
		}
		if (!string.IsNullOrEmpty(comment))
		{
			if (leadStatus == LeadStatus.Unqualified || leadStatus == LeadStatus.New)
			{
				IComment comment2 = InterfaceActivator.Create<IComment>();
				comment2.Text = comment;
				comment2.CreationDate = DateTime.Now;
				comment2.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				comment2.Save();
				lead.Comments.Add(comment2);
				lead.Save();
			}
			else
			{
				AddComment(lead, comment);
			}
		}
	}

	[PublicApiMember]
	public void Dublicate(ILead lead, IContractor contractor, string comment = null, bool copyContacts = true)
	{
		Dublicate(lead, comment, copyContacts, contractor);
	}

	[PublicApiMember]
	public void Dublicate(ILead thisLead, ILead lead, string comment = null, bool copyContacts = true)
	{
		Dublicate(thisLead, comment, copyContacts, null, lead);
	}

	[PublicApiMember]
	public void Dublicate(ILead lead, ISale sale, string comment = null)
	{
		Dublicate(lead, comment, copyContacts: false, null, null, sale);
	}

	[PublicApiMember]
	[Transaction]
	public virtual void NotDublicate(ILead lead)
	{
		LeadDublicateStateManager.Instance.SetDublicateState(lead, LeadDublicateStatus.NotDublicate);
	}

	[PublicApiMember]
	public virtual IContractor ConvertLeadToContractorLegal(ILead lead)
	{
		Guid uid = InterfaceActivator.UID<IContractorLegal>();
		IContractor contractor = (IContractor)InterfaceActivator.Create(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid));
		PropertyMap map = Instance.ConvertToContractorMap(contractor.GetType());
		PropertyMapHelper.Map(lead, contractor, map);
		PropertyMap map2 = Instance.ConvertToContactMap();
		((ICollection<IContact>)contractor.Contacts).Clear();
		foreach (ILeadContact item in (IEnumerable<ILeadContact>)lead.Contacts)
		{
			IContact contact = InterfaceActivator.Create<IContact>();
			PropertyMapHelper.Map(item, contact, map2);
			contact.Contractor = contractor;
			contractor.Contacts.Add(contact);
		}
		Instance.ConvertComplete(lead, contractor, (IEnumerable<IContact>)contractor.Contacts, null, null, null);
		return contractor;
	}

	private void RecalcMarketingGroup(IMarketingGroup group)
	{
		if (group != null)
		{
			base.Session.GetNamedQuery("ExecMarketingGroupRecalc").SetParameter<long>("group", group.Id).ExecuteUpdate(cleanUpCache: false);
			base.Session.CleanUpCache(typeof(IMarketingEffect), typeof(IMarketingActivity), typeof(IMarketingBase));
		}
	}

	private void RecalcMarketingActivity(IMarketingActivity activity)
	{
		if (activity != null)
		{
			base.Session.GetNamedQuery("ExecMarketingActivityRecalc").SetParameter<long>("activity", activity.Id).ExecuteUpdate(cleanUpCache: false);
			base.Session.CleanUpCache(typeof(IMarketingEffect), typeof(IMarketingBase));
		}
	}

	public void BatchUpdateMarketingCounters(IMarketingBase marketingObject)
	{
		marketingObject = marketingObject.CastAsRealType();
		if (marketingObject is IMarketingGroup)
		{
			RecalcMarketingGroup((IMarketingGroup)marketingObject);
		}
		else if (marketingObject is IMarketingActivity)
		{
			IMarketingActivity marketingActivity = (IMarketingActivity)marketingObject;
			if (marketingActivity.MarketingGroup != null)
			{
				RecalcMarketingGroup(marketingActivity.MarketingGroup);
			}
			else
			{
				RecalcMarketingActivity(marketingActivity);
			}
		}
		else
		{
			if (!(marketingObject is IMarketingEffect))
			{
				return;
			}
			IMarketingEffect marketingEffect = (IMarketingEffect)marketingObject;
			if (marketingEffect.MarketingActivity != null)
			{
				if (marketingEffect.MarketingActivity.MarketingGroup != null)
				{
					RecalcMarketingGroup(marketingEffect.MarketingActivity.MarketingGroup);
				}
				else
				{
					RecalcMarketingActivity(marketingEffect.MarketingActivity);
				}
			}
		}
	}

	public void UpdateMarketingLink(UtmType utmType, string tagName)
	{
		base.Session.GetNamedQuery("ExecLeadUtmBinding").SetParameter<string>("source", (utmType == UtmType.Source) ? tagName : "").SetParameter<string>("medium", (utmType == UtmType.Medium) ? tagName : "")
			.SetParameter<string>("campaign", (utmType == UtmType.Campaign) ? tagName : "")
			.ExecuteUpdate(cleanUpCache: false);
		base.Session.CleanUpCache(typeof(ILead));
	}

	public void UpdateMarketingLink(ILead lead)
	{
		if (!string.IsNullOrEmpty(lead.UtmSource))
		{
			lead.MarketingGroup = MarketingGroupManager.Instance.FindByUtm(lead.UtmSource);
			if (!string.IsNullOrEmpty(lead.UtmMedium))
			{
				lead.MarketingActivity = MarketingActivityManager.Instance.FindByUtm(lead.MarketingGroup, lead.UtmMedium);
				if (!string.IsNullOrEmpty(lead.UtmCampaign) && lead.MarketingActivity != null)
				{
					lead.MarketingEffect = MarketingEffectManager.Instance.FindByUtm(lead.MarketingActivity, lead.UtmCampaign);
				}
				else
				{
					lead.MarketingEffect = null;
				}
			}
			else
			{
				lead.MarketingActivity = null;
				lead.MarketingEffect = null;
			}
		}
		else
		{
			lead.MarketingGroup = null;
			lead.MarketingActivity = null;
			lead.MarketingEffect = null;
		}
		lead.Save();
	}

	public virtual void ReconfigurePermissionAfterConvert(IContractor contractor)
	{
		sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
		if (contractor.Categories == null)
		{
			return;
		}
		foreach (ICategory item in (IEnumerable<ICategory>)contractor.Categories)
		{
			AddCategory(item, contractor);
		}
	}

	public void CreateMarketing(ILead lead)
	{
		IMarketingGroup marketingGroup = null;
		if (!string.IsNullOrEmpty(lead.UtmSource))
		{
			marketingGroup = MarketingGroupManager.Instance.FindByUtm(lead.UtmSource);
			if (marketingGroup == null)
			{
				marketingGroup = InterfaceActivator.Create<IMarketingGroup>();
				marketingGroup.Name = $"{lead.UtmSource} ({lead.CreationDate.ToShortDateString()})";
				marketingGroup.Responsible = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				marketingGroup.BudgetType = MarketingBudgetType.SumOfChild;
				marketingGroup.Status = MarketingObjectStatus.Active;
				IMarketingTag marketingTag = InterfaceActivator.Create<IMarketingTag>();
				marketingTag.Name = lead.UtmSource;
				marketingTag.MarketingObject = marketingGroup;
				marketingTag.Save();
				marketingGroup.Tags.Add(marketingTag);
			}
			lead.MarketingGroup = marketingGroup;
		}
		else
		{
			lead.MarketingGroup = null;
		}
		if (!string.IsNullOrEmpty(lead.UtmMedium))
		{
			IMarketingActivity marketingActivity = ((lead.MarketingGroup != null) ? MarketingActivityManager.Instance.FindByUtm(lead.MarketingGroup, lead.UtmMedium) : MarketingActivityManager.Instance.FindByUtm(lead.UtmMedium));
			if (marketingActivity == null)
			{
				marketingActivity = InterfaceActivator.Create<IMarketingActivity>();
				marketingActivity.Name = $"{lead.UtmMedium} ({lead.CreationDate.ToShortDateString()})";
				marketingActivity.Responsible = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				marketingActivity.BudgetType = MarketingBudgetType.SumOfChild;
				marketingActivity.Status = MarketingObjectStatus.Active;
				IMarketingTag marketingTag2 = InterfaceActivator.Create<IMarketingTag>();
				marketingTag2.Name = lead.UtmMedium;
				marketingTag2.MarketingObject = marketingActivity;
				marketingTag2.Save();
				marketingActivity.Tags.Add(marketingTag2);
			}
			if (marketingGroup != null)
			{
				marketingActivity.MarketingGroup = marketingGroup;
			}
			marketingActivity.Save();
			lead.MarketingActivity = marketingActivity;
			if (!string.IsNullOrEmpty(lead.UtmCampaign))
			{
				IMarketingEffect marketingEffect = MarketingEffectManager.Instance.FindByUtm(lead.MarketingActivity, lead.UtmCampaign);
				if (marketingEffect == null)
				{
					marketingEffect = InterfaceActivator.Create<IMarketingEffect>();
					marketingEffect.Name = $"{lead.UtmCampaign} ({lead.CreationDate.ToShortDateString()})";
					marketingEffect.Responsible = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					marketingEffect.BudgetType = MarketingBudgetType.SumOfChild;
					marketingEffect.Status = MarketingObjectStatus.Active;
					IMarketingTag marketingTag3 = InterfaceActivator.Create<IMarketingTag>();
					marketingTag3.Name = lead.UtmCampaign;
					marketingTag3.MarketingObject = marketingEffect;
					marketingTag3.Save();
					marketingEffect.Tags.Add(marketingTag3);
				}
				marketingEffect.MarketingActivity = marketingActivity;
				marketingEffect.Save();
				lead.MarketingEffect = marketingEffect;
			}
			else
			{
				lead.MarketingEffect = null;
			}
		}
		else
		{
			lead.MarketingActivity = null;
			lead.MarketingEffect = null;
		}
		lead.Save();
	}

	public void CheckDublicateLead(ILead lead)
	{
		CheckDublicateLead(lead.Id);
	}

	public void CheckDublicateLead(long leadId)
	{
		if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.LeadSearchDublicate)
		{
			LeadDublicateStateManager.Instance.SetDublicateState(leadId);
			Locator.GetServiceNotNull<IUnitOfWorkManager>().RegisterPostCommitAction(delegate
			{
				CheckDublicateLeadInternal(leadId);
			});
		}
	}

	internal void CheckDublicateLeadInternal(long leadId)
	{
		_pool = _pool ?? new ThreadSubPool("CheckDublicateLead.PoolSize", 3);
		_pool.Queue(delegate
		{
			new BackgroundTask(delegate
			{
				base.SecurityService.RunWithElevatedPrivilegies(delegate
				{
					try
					{
						log.InfoFormat("Start FillDublicates Lead#{0}", leadId);
						ILead lead = Load(leadId);
						FillDublicates(lead);
						log.InfoFormat("End FillDublicates Lead#{0}", leadId);
					}
					catch (Exception exception)
					{
						log.Error(exception, "Error FillDublicates Lead#{0}", leadId);
					}
				});
			}, typeof(ILead), "BeforeSaveLead", SR.T("Выполнение действий, перед сохранением возможности с ID={0}", leadId)).Execute();
		});
	}

	[Transaction]
	protected virtual void FillDublicates(ILead lead)
	{
		FillDublicateContractor(lead);
		FillDublicateLead(lead);
		LeadDublicateStateManager.Instance.SetDublicateState(lead, (((ICollection<IDublicateLead>)lead.PossibleDublicateLead).Count > 0 || ((ICollection<IDublicateContractor>)lead.PossibleDublicateContractor).Count > 0) ? LeadDublicateStatus.PossibleDublicate : LeadDublicateStatus.NotDublicate);
	}

	private void FillDublicateContractor(ILead lead)
	{
		ListDublicate dublicate1;
		IDublicateContractor dub;
		DiagnosticsManager.StartCall(() => new MethodCallInfo(ThisType, FillDublicateContractorInfo, new object[1] { lead }), delegate
		{
			Type type = InterfaceActivator.TypeOf<IContractor>();
			if (MetadataLoader.LoadMetadata(type) is ClassMetadata classMetadata)
			{
				log.DebugFormat("FillDublicateContractor Lead#{0}", lead.Id);
				List<LeadScoringSettings> leadScoringSettings = LeadScoringSettings.GetLeadScoringSettings();
				List<ListDublicate> list = new List<ListDublicate>();
				foreach (LeadScoringSettings item in leadScoringSettings)
				{
					EntityPropertyMetadata property = (EntityPropertyMetadata)classMetadata.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == item.ContractorProperty);
					if (property != null)
					{
						ICriteria val = CreateCriteria(null, type);
						val.Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false));
						ICollection<long> collection = new List<long>();
						ILeadFilterProperty leadFilterProperty = ComponentManager.Current.GetExtensionPoints<ILeadFilterProperty>().FirstOrDefault((ILeadFilterProperty q) => q.Check(property));
						if (leadFilterProperty != null)
						{
							collection = leadFilterProperty.GetFilterPropertyList(val, typeof(IContractor), property, lead.GetPropertyValue(property.Name, null), "Id");
							if (!collection.Any() && item.UseContractorContactProperty)
							{
								Type type2 = InterfaceActivator.TypeOf<IContact>();
								EntityPropertyMetadata entityPropertyMetadata = (EntityPropertyMetadata)(MetadataLoader.LoadMetadata(type2) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == item.ContractorContactProperty);
								if (entityPropertyMetadata != null)
								{
									ICriteria val2 = CreateCriteria(null, type2);
									val2.CreateAlias("Contractor", "contractor");
									val2.Add((ICriterion)(object)Restrictions.Eq("contractor.IsDeleted", (object)false));
									collection = leadFilterProperty.GetFilterPropertyList(val2, typeof(IContact), entityPropertyMetadata, lead.GetPropertyValue(property.Name, null), "Contractor.Id");
									if (!collection.Any())
									{
										foreach (ILeadContact item2 in (IEnumerable<ILeadContact>)lead.Contacts)
										{
											ICollection<long> filterPropertyList = leadFilterProperty.GetFilterPropertyList(val, typeof(IContractor), property, item2.GetPropertyValue(property.Name, null), "Id");
											ICollection<long> filterPropertyList2 = leadFilterProperty.GetFilterPropertyList(val2, typeof(IContact), entityPropertyMetadata, item2.GetPropertyValue(property.Name, null), "Contractor.Id");
											collection = filterPropertyList.Union(filterPropertyList2).ToList();
										}
									}
								}
							}
						}
						foreach (long itemResult in collection)
						{
							ListDublicate listDublicate = list.FirstOrDefault((ListDublicate m) => m.Id == itemResult);
							if (listDublicate != null)
							{
								listDublicate.Weight += item.ContractorPercentValue;
								listDublicate.PropertyList.Add(item.ContractorProperty);
							}
							else
							{
								list.Add(new ListDublicate
								{
									Id = itemResult,
									Weight = item.ContractorPercentValue,
									PropertyList = new List<Guid> { item.ContractorProperty }
								});
							}
						}
					}
				}
				List<LeadStepScoring> listStepScoring = LeadStepScoring.GetListStepScoring();
				LeadStepScoring minStep = listStepScoring.OrderBy((LeadStepScoring m) => m.PercentValue).FirstOrDefault();
				List<ListDublicate> list2 = list.Where((ListDublicate m) => m.Weight >= minStep.PercentValue).ToList();
				((IEnumerable<IDublicateContractor>)lead.PossibleDublicateContractor).ForEach(delegate(IDublicateContractor a)
				{
					a.Delete();
				});
				((ICollection<IDublicateContractor>)lead.PossibleDublicateContractor).Clear();
				if (list2.Count > 0)
				{
					if (log.IsTraceEnabled())
					{
						log.TraceFormat("FillDublicateContractor Lead#{0}: {1}", lead.Id, string.Join(", ", list2.Select((ListDublicate d) => d.Id)));
					}
					else
					{
						log.DebugFormat("FillDublicateContractor Lead#{0} count: {1}", lead.Id, list2.Count);
					}
					foreach (ListDublicate item3 in list2)
					{
						try
						{
							dublicate1 = item3;
							dub = InterfaceActivator.Create<IDublicateContractor>();
							dub.Lead = lead;
							dub.Weight = item3.Weight;
							dub.DublicateField = item3.PropertyList;
							base.SecurityService.RunWithElevatedPrivilegies(delegate
							{
								dub.Dublicate = ContractorManager.Instance.Load(dublicate1.Id);
							});
							dub.Save();
							lead.PossibleDublicateContractor.Add(dub);
						}
						catch (Exception exception)
						{
							log.Error(exception, "FillDublicateContractor Lead#{0}", lead.Id);
							throw;
						}
					}
				}
				log.DebugFormat("FillDublicateContractor Lead#{0} complete", lead.Id);
			}
		});
	}

	private void FillDublicateLead(ILead lead)
	{
		ListDublicate dublicate1;
		IDublicateLead dub;
		DiagnosticsManager.StartCall(() => new MethodCallInfo(ThisType, FillDublicateLeadInfo, new object[1] { lead }), delegate
		{
			if (MetadataLoader.LoadMetadata(base.ImplementationType) is EntityMetadata entityMetadata)
			{
				log.DebugFormat("FillDublicateLead Lead#{0}", lead.Id);
				List<LeadScoringSettings> leadScoringSettings = LeadScoringSettings.GetLeadScoringSettings();
				List<ListDublicate> list = new List<ListDublicate>();
				foreach (LeadScoringSettings item in leadScoringSettings)
				{
					ICriteria val = CreateCriteria();
					val.Add((ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false));
					val.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((ILead m) => m.Status), (ICollection)new LeadStatus[4]
					{
						LeadStatus.New,
						LeadStatus.InHand,
						LeadStatus.Unqualified,
						LeadStatus.ConversationNotStart
					}));
					val.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((ILead m) => m.Id), (object)lead.Id)));
					EntityPropertyMetadata property = (EntityPropertyMetadata)entityMetadata.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == item.Property);
					ICollection<long> source = new List<long>();
					ILeadFilterProperty leadFilterProperty = ComponentManager.Current.GetExtensionPoints<ILeadFilterProperty>().FirstOrDefault((ILeadFilterProperty q) => q.Check(property));
					if (leadFilterProperty != null)
					{
						source = leadFilterProperty.GetFilterPropertyList(val, base.ImplementationType, property, lead.GetPropertyValue(property.Name, null), "Id");
						if (!source.Any() && item.UseLeadContactProperty)
						{
							Type type = InterfaceActivator.TypeOf<ILeadContact>();
							EntityPropertyMetadata entityPropertyMetadata = (EntityPropertyMetadata)(MetadataLoader.LoadMetadata(type) as ClassMetadata).Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == item.LeadContactProperty);
							if (entityPropertyMetadata != null)
							{
								ICriteria val2 = CreateCriteria(null, type);
								val2.CreateAlias("Lead", "lead");
								val2.Add((ICriterion)(object)Restrictions.Eq("lead.IsDeleted", (object)false));
								source = leadFilterProperty.GetFilterPropertyList(val2, typeof(ILeadContact), entityPropertyMetadata, lead.GetPropertyValue(property.Name, null), "Lead.Id");
								if (!source.Any())
								{
									foreach (ILeadContact item2 in (IEnumerable<ILeadContact>)lead.Contacts)
									{
										ICollection<long> filterPropertyList = leadFilterProperty.GetFilterPropertyList(val, base.ImplementationType, property, item2.GetPropertyValue(property.Name, null), "Id");
										ICollection<long> filterPropertyList2 = leadFilterProperty.GetFilterPropertyList(val2, typeof(ILeadContact), entityPropertyMetadata, item2.GetPropertyValue(property.Name, null), "Lead.Id");
										source = filterPropertyList.Union(filterPropertyList2).ToList();
									}
								}
							}
						}
					}
					foreach (long itemResult in source.Where((long m) => m != lead.Id))
					{
						ListDublicate listDublicate = list.FirstOrDefault((ListDublicate m) => m.Id == itemResult);
						if (listDublicate != null)
						{
							listDublicate.Weight += item.LeadPercentValue;
							listDublicate.PropertyList.Add(item.Property);
						}
						else
						{
							list.Add(new ListDublicate
							{
								Id = itemResult,
								Weight = item.LeadPercentValue,
								PropertyList = new List<Guid> { item.Property }
							});
						}
					}
				}
				List<LeadStepScoring> listStepScoring = LeadStepScoring.GetListStepScoring();
				LeadStepScoring minStep = listStepScoring.OrderBy((LeadStepScoring m) => m.PercentValue).FirstOrDefault();
				List<ListDublicate> list2 = list.Where((ListDublicate m) => m.Weight >= minStep.PercentValue).ToList();
				((IEnumerable<IDublicateLead>)lead.PossibleDublicateLead).ForEach(delegate(IDublicateLead a)
				{
					a.Delete();
				});
				((ICollection<IDublicateLead>)lead.PossibleDublicateLead).Clear();
				if (list2.Count > 0)
				{
					if (log.IsTraceEnabled())
					{
						log.TraceFormat("FillDublicateLead Lead#{0}: {1}", lead.Id, string.Join(", ", list2.Select((ListDublicate d) => d.Id)));
					}
					else
					{
						log.DebugFormat("FillDublicateLead Lead#{0} count: {1}", lead.Id, list2.Count);
					}
					foreach (ListDublicate item3 in list2)
					{
						try
						{
							dublicate1 = item3;
							dub = InterfaceActivator.Create<IDublicateLead>();
							dub.Lead = lead;
							base.SecurityService.RunWithElevatedPrivilegies(delegate
							{
								dub.Dublicate = Load(dublicate1.Id);
							});
							dub.Weight = item3.Weight;
							dub.DublicateField = item3.PropertyList;
							dub.Save();
							lead.PossibleDublicateLead.Add(dub);
						}
						catch (Exception exception)
						{
							log.Error(exception, "FillDublicateLead Lead#{0}", lead.Id);
							throw;
						}
					}
				}
				log.DebugFormat("FillDublicateLead Lead#{0} complete", lead.Id);
			}
		});
	}

	private void AddCategory(ICategory category, IContractor contractor)
	{
		LockBlocing();
		try
		{
			ISession session = sessionProvider.GetSession("");
			IQuery obj = session.GetNamedQuery("ExecCheckPermWhenAddCategories").SetParameter<long>("CategoryId", category.Id).SetParameter<long>("ContractorId", contractor.Id);
			obj.CleanUpCache(cleanUpCache: false);
			obj.SetTimeout(0);
			obj.ExecuteUpdate();
			session.CleanUpCache(typeof(IContractorPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission), typeof(IRelationshipPersonPermission));
		}
		catch (Exception exception)
		{
			base.Logger.Error(SR.T("Ошибка пересчета прав при добавлении категории в контрагента (ExecCheckPermWhenAddCategories) CategoryId={0}, ContractorId={1}", category.Id, contractor.Id), exception);
			throw;
		}
		finally
		{
			UnLockBlocing();
		}
	}

	private void CheckLockGlobalBlocing()
	{
		if (!ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return;
		}
		int num = 0;
		bool flag = true;
		while (flag)
		{
			if (!ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
			{
				flag = false;
			}
			else
			{
				if (num > 20)
				{
					throw new BlockedPermissionException();
				}
				Thread.Sleep(1000);
			}
			num++;
		}
	}

	private void LockBlocing()
	{
		CheckLockGlobalBlocing();
		if (!CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out var value) && value == null)
		{
			value = new CachePermissionModel
			{
				Blocking = true,
				NumberBlock = 1,
				TimestampTime = DateTime.Now
			};
		}
		else
		{
			if (value.TimestampTime < DateTime.Now.AddMinutes(-1.0))
			{
				value.NumberBlock = 0;
			}
			value.NumberBlock++;
			value.TimestampTime = DateTime.Now;
		}
		CacheService.Insert("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", value, "CRMPermission");
	}

	private void UnLockBlocing()
	{
		if (CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out var value) && value != null)
		{
			value.NumberBlock--;
			value.TimestampTime = DateTime.Now;
			CacheService.Insert("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", value, "CRMPermission");
		}
	}

	private void ConvertPermissionContractor(ILead lead, IContractor contractor)
	{
		DiagnosticsManager.StartCall(() => new MethodCallInfo(ThisType, ConvertPermissionContractorInfo, new object[2] { lead, contractor }), delegate
		{
			EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
			if (lead.Permission != null)
			{
				if (contractor.Permission == null)
				{
					contractor.Permission = (ISet<IContractorPersonPermission>)(object)new Set<IContractorPersonPermission>();
				}
				foreach (ILeadPersonPermission item in ((IEnumerable<ILeadPersonPermission>)lead.Permission).Where((ILeadPersonPermission d) => !d.InheritedFromNumber.HasValue))
				{
					if (item != null && ((!(item.PermissionRole == CommonRoleTypes.ParticipantWork.Id) && !(item.PermissionRole == CommonRoleTypes.Informs.Id)) || item.User.Id == user.Id))
					{
						if (lead.Informs != null && item.PermissionRole == CommonRoleTypes.Informs.Id)
						{
							foreach (EleWise.ELMA.Security.Models.IUser item2 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)lead.Informs)
							{
								Guid guid = ReplasePermissionContractor(item);
								if (guid != Guid.Empty)
								{
									InstanceOf<IContractorPersonPermission> instanceOf = new InstanceOf<IContractorPersonPermission>();
									instanceOf.New.Contractor = contractor;
									instanceOf.New.User = item2;
									instanceOf.New.Group = item.Group;
									instanceOf.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
									instanceOf.New.OrganizationItemPosition = item.OrganizationItemPosition;
									instanceOf.New.PermissionId = guid;
									instanceOf.New.TypeRoleId = item.TypeRoleId;
									instanceOf.New.PermissionRole = item.PermissionRole;
									instanceOf.New.InheritedFromNumber = null;
									IContractorPersonPermission @new = instanceOf.New;
									contractor.Permission.Add(@new);
								}
								if (lead.ParticipantWork != null && item.PermissionRole == CommonRoleTypes.ParticipantWork.Id)
								{
									foreach (EleWise.ELMA.Security.Models.IUser item3 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)lead.ParticipantWork)
									{
										Guid guid2 = ReplasePermissionContractor(item);
										if (guid2 != Guid.Empty)
										{
											InstanceOf<IContractorPersonPermission> instanceOf2 = new InstanceOf<IContractorPersonPermission>();
											instanceOf2.New.Contractor = contractor;
											instanceOf2.New.User = item3;
											instanceOf2.New.Group = item.Group;
											instanceOf2.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
											instanceOf2.New.OrganizationItemPosition = item.OrganizationItemPosition;
											instanceOf2.New.PermissionId = guid2;
											instanceOf2.New.TypeRoleId = item.TypeRoleId;
											instanceOf2.New.PermissionRole = item.PermissionRole;
											instanceOf2.New.InheritedFromNumber = null;
											IContractorPersonPermission new2 = instanceOf2.New;
											contractor.Permission.Add(new2);
										}
									}
								}
							}
						}
						Guid guid3 = ReplasePermissionContractor(item);
						if (guid3 != Guid.Empty)
						{
							InstanceOf<IContractorPersonPermission> instanceOf3 = new InstanceOf<IContractorPersonPermission>();
							instanceOf3.New.Contractor = contractor;
							instanceOf3.New.User = item.User;
							instanceOf3.New.Group = item.Group;
							instanceOf3.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
							instanceOf3.New.OrganizationItemPosition = item.OrganizationItemPosition;
							instanceOf3.New.PermissionId = guid3;
							instanceOf3.New.TypeRoleId = item.TypeRoleId;
							instanceOf3.New.PermissionRole = item.PermissionRole;
							instanceOf3.New.InheritedFromNumber = null;
							IContractorPersonPermission new3 = instanceOf3.New;
							contractor.Permission.Add(new3);
						}
					}
				}
			}
		});
	}

	private Guid ReplasePermissionContractor(ILeadPersonPermission perm)
	{
		Guid result = Guid.Empty;
		if (perm.PermissionId == CRMPermissionProvider.CRMLeadCreateElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMContractorCreateElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.ViewLeadPermission.Id)
		{
			result = CRMPermissionProvider.ViewContractorPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.EditLeadPermission.Id)
		{
			result = CRMPermissionProvider.EditContractorPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMLeadIssuanceElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMLeadFullAccessPermission.Id)
		{
			result = CRMPermissionProvider.CRMContractorFullAccessPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMFullAccessPermission.Id)
		{
			result = perm.PermissionId;
		}
		return result;
	}

	public virtual void AddPermissionsFromParent(ILead lead)
	{
		List<ILeadPersonPermission> list = new List<ILeadPersonPermission>();
		foreach (ICategory item in (lead.Categories != null && ((IEnumerable<ICategory>)lead.Categories).Any()) ? ((IEnumerable<ICategory>)lead.Categories).ToList() : new List<ICategory> { CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid) })
		{
			if (item == null || item.ContainerLeadPermission == null || item.ContainerLeadPermission.TemplateLeadPermission == null)
			{
				continue;
			}
			foreach (ITemplateLeadPermission item2 in ((IEnumerable<ITemplateLeadPermission>)item.ContainerLeadPermission.TemplateLeadPermission).Where((ITemplateLeadPermission a) => !a.AddPermission && !a.DelPermission))
			{
				EleWise.ELMA.Security.Models.IUser user = item2.User;
				if (item2.PermissionRole == CommonRoleTypes.Author.UID)
				{
					user = lead.CreationAuthor;
				}
				if (item2.PermissionRole == CommonRoleTypes.Responsible.UID)
				{
					user = lead.Responsible;
				}
				list.Add(AddPermission(item2, user, lead));
				if (item2.PermissionRole == CommonRoleTypes.ParticipantWork.UID)
				{
					foreach (EleWise.ELMA.Security.Models.IUser item3 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)lead.ParticipantWork)
					{
						list.Add(AddPermission(item2, item3, lead));
					}
				}
				if (!(item2.PermissionRole == CommonRoleTypes.Informs.UID))
				{
					continue;
				}
				foreach (EleWise.ELMA.Security.Models.IUser item4 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)lead.Informs)
				{
					list.Add(AddPermission(item2, item4, lead));
				}
			}
		}
		(from s in list
			group s by new { s.User, s.PermissionId, s.Group, s.OrganizationItemPosition, s.PermissionRole, s.OrganizationItemEmployee, s.TypeRoleId }).ForEach(g =>
		{
			InstanceOf<ILeadPersonPermission> instanceOf = new InstanceOf<ILeadPersonPermission>();
			instanceOf.New.Lead = lead;
			instanceOf.New.User = g.Key.User;
			instanceOf.New.Group = g.Key.Group;
			instanceOf.New.OrganizationItemEmployee = g.Key.OrganizationItemEmployee;
			instanceOf.New.OrganizationItemPosition = g.Key.OrganizationItemPosition;
			instanceOf.New.PermissionId = g.Key.PermissionId;
			instanceOf.New.TypeRoleId = g.Key.TypeRoleId;
			instanceOf.New.PermissionRole = g.Key.PermissionRole;
			instanceOf.New.InheritedFromNumber = g.Count();
			instanceOf.New.Save();
		});
	}

	[Transaction]
	public virtual void EnableInheritPermissions(ILead lead, bool enable)
	{
		if (enable)
		{
			lead.InheritPermissions = true;
			AddPermissionsFromParent(lead);
		}
		else
		{
			lead.InheritPermissions = false;
			((IEnumerable<ILeadPersonPermission>)lead.Permission).ForEach(delegate(ILeadPersonPermission p)
			{
				p.InheritedFromNumber = null;
			});
		}
		Save(lead);
	}

	private ILeadPersonPermission AddPermission(ITemplateLeadPermission perm, EleWise.ELMA.Security.Models.IUser user, ILead lead)
	{
		ILeadPersonPermission leadPersonPermission = InterfaceActivator.Create<ILeadPersonPermission>();
		leadPersonPermission.Lead = lead;
		leadPersonPermission.User = user;
		leadPersonPermission.Group = perm.Group;
		leadPersonPermission.OrganizationItemEmployee = perm.OrganizationItemEmployee;
		leadPersonPermission.OrganizationItemPosition = perm.OrganizationItemPosition;
		leadPersonPermission.PermissionId = perm.PermissionId;
		leadPersonPermission.TypeRoleId = perm.TypeRoleId;
		leadPersonPermission.PermissionRole = perm.PermissionRole;
		leadPersonPermission.InheritedFromNumber = 1L;
		return leadPersonPermission;
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, EleWise.ELMA.Security.Models.IUser user)
	{
		DeletePermission(lead, user, CRMPermissionProvider.ViewLeadPermission);
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, IUserGroup userGroup)
	{
		DeletePermission(lead, userGroup, CRMPermissionProvider.ViewLeadPermission);
	}

	[PublicApiMember]
	public void DeleteAuthorPermission(ILead lead, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		DelAuthorPermission(permission, lead);
		if (permission == CRMPermissionProvider.ViewLeadPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead);
			DelAuthorPermission(CRMPermissionProvider.EditLeadPermission, lead);
			DelAuthorPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead);
			DelAuthorPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead);
		}
		if (permission == CRMPermissionProvider.EditLeadPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead);
		}
		if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.EditLeadPermission, lead);
			DelAuthorPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead);
		}
		if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead);
		}
		lead.Save();
	}

	[PublicApiMember]
	public void AddAuthorPermission(ILead lead, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (permission == CRMPermissionProvider.CRMLeadFullAccessPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead);
			AddAuthorOnePermission(CRMPermissionProvider.ViewLeadPermission, lead);
			AddAuthorOnePermission(CRMPermissionProvider.EditLeadPermission, lead);
			AddAuthorOnePermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead);
		}
		if (permission == CRMPermissionProvider.EditLeadPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead);
			AddAuthorOnePermission(CRMPermissionProvider.ViewLeadPermission, lead);
		}
		if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewLeadPermission, lead);
		}
		if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewLeadPermission, lead);
		}
		lead.Save();
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, IOrganizationItem orgItem)
	{
		DeletePermission(lead, orgItem, CRMPermissionProvider.ViewLeadPermission);
	}

	[PublicApiMember]
	public void EnableInheritPermissions(ILead lead)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(lead, enable: true);
	}

	[PublicApiMember]
	public void DisableInheritPermissions(ILead lead)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(lead, enable: false);
	}

	[PublicApiMember]
	public void AddPermission(ILead lead, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		if (AddOnePermission(permission, lead, user))
		{
			if (permission == CRMPermissionProvider.CRMLeadFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, user);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, user);
				AddOnePermission(CRMPermissionProvider.EditLeadPermission, lead, user);
				AddOnePermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.EditLeadPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, user);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, user);
			}
		}
		lead.Save();
	}

	[PublicApiMember]
	public void AddPermission(ILead lead, IUserGroup userGroup, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (AddOnePermission(permission, lead, userGroup))
		{
			if (permission == CRMPermissionProvider.CRMLeadFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, userGroup);
				AddOnePermission(CRMPermissionProvider.EditLeadPermission, lead, userGroup);
				AddOnePermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, userGroup);
			}
			if (permission == CRMPermissionProvider.EditLeadPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, userGroup);
			}
		}
		lead.Save();
	}

	[PublicApiMember]
	public void AddPermission(ILead lead, IOrganizationItem orgItem, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		if (AddOnePermission(permission, lead, orgItem))
		{
			if (permission == CRMPermissionProvider.CRMLeadFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, orgItem);
				AddOnePermission(CRMPermissionProvider.EditLeadPermission, lead, orgItem);
				AddOnePermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, orgItem);
			}
			if (permission == CRMPermissionProvider.EditLeadPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewLeadPermission, lead, orgItem);
			}
		}
		lead.Save();
	}

	private bool AddOnePermission(Permission permission, ILead lead, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!((IEnumerable<ILeadPersonPermission>)lead.Permission).Any((ILeadPersonPermission r) => r.Assigned == user && r.PermissionId == permission.Id && !r.InheritedFromNumber.HasValue))
		{
			ILeadPersonPermission leadPersonPermission = LeadPersonPermissionManager.Create();
			leadPersonPermission.Lead = lead;
			leadPersonPermission.PermissionId = permission.Id;
			leadPersonPermission.User = user;
			leadPersonPermission.PermissionRole = CommonRoleTypes.User.Id;
			lead.Permission.Add(leadPersonPermission);
			return true;
		}
		return false;
	}

	private bool AddOnePermission(Permission permission, ILead lead, IUserGroup userGroup)
	{
		if (!((IEnumerable<ILeadPersonPermission>)lead.Permission).Any((ILeadPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permission.Id))
		{
			ILeadPersonPermission leadPersonPermission = LeadPersonPermissionManager.Create();
			leadPersonPermission.Lead = lead;
			leadPersonPermission.PermissionId = permission.Id;
			leadPersonPermission.Group = userGroup;
			leadPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			lead.Permission.Add(leadPersonPermission);
		}
		return true;
	}

	private bool AddOnePermission(Permission permission, ILead lead, IOrganizationItem orgItem)
	{
		if (!((IEnumerable<ILeadPersonPermission>)lead.Permission).Any((ILeadPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permission.Id))
		{
			ILeadPersonPermission leadPersonPermission = LeadPersonPermissionManager.Create();
			leadPersonPermission.Lead = lead;
			leadPersonPermission.PermissionId = permission.Id;
			leadPersonPermission.OrganizationItemPosition = orgItem;
			leadPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			lead.Permission.Add(leadPersonPermission);
		}
		return true;
	}

	private void AddAuthorOnePermission(Permission permission, ILead lead)
	{
		if (!((IEnumerable<ILeadPersonPermission>)lead.Permission).Any(delegate(ILeadPersonPermission r)
		{
			if (r.Assigned == lead.CreationAuthor && r.PermissionId == permission.Id)
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
			ILeadPersonPermission leadPersonPermission = LeadPersonPermissionManager.Create();
			leadPersonPermission.Lead = lead;
			leadPersonPermission.PermissionId = permission.Id;
			leadPersonPermission.User = lead.CreationAuthor;
			leadPersonPermission.PermissionRole = CommonRoleTypes.Author.Id;
			lead.Permission.Add(leadPersonPermission);
		}
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (lead == null)
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
			hasPermission = base.SecurityService.HasPermission(user, permission, lead);
		});
		if (hasPermission)
		{
			DelPermission(permission, lead, user);
			if (permission == CRMPermissionProvider.ViewLeadPermission)
			{
				DelPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, user);
				DelPermission(CRMPermissionProvider.EditLeadPermission, lead, user);
				DelPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, user);
				DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.EditLeadPermission)
			{
				DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
			{
				DelPermission(CRMPermissionProvider.EditLeadPermission, lead, user);
				DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, user);
			}
			if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
			{
				DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, user);
			}
			lead.Save();
		}
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, IUserGroup userGroup, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		DelPermission(permission, lead, userGroup);
		if (permission == CRMPermissionProvider.ViewLeadPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, userGroup);
			DelPermission(CRMPermissionProvider.EditLeadPermission, lead, userGroup);
			DelPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, userGroup);
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, userGroup);
		}
		if (permission == CRMPermissionProvider.EditLeadPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditLeadPermission, lead, userGroup);
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, userGroup);
		}
		lead.Save();
	}

	[PublicApiMember]
	public void DeletePermission(ILead lead, IOrganizationItem orgItem, Permission permission)
	{
		if (lead == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		DelPermission(permission, lead, orgItem);
		if (permission == CRMPermissionProvider.ViewLeadPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, lead, orgItem);
			DelPermission(CRMPermissionProvider.EditLeadPermission, lead, orgItem);
			DelPermission(CRMPermissionProvider.CRMLeadIssuanceElementPermission, lead, orgItem);
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, orgItem);
		}
		if (permission == CRMPermissionProvider.EditLeadPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMLeadCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditLeadPermission, lead, orgItem);
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMLeadIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMLeadFullAccessPermission, lead, orgItem);
		}
		lead.Save();
	}

	private void DelPermission(Permission permissions, ILead lead, IUserGroup userGroup)
	{
		((ICollection<ILeadPersonPermission>)lead.Permission).Remove(((IEnumerable<ILeadPersonPermission>)lead.Permission).FirstOrDefault((ILeadPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permissions.Id));
	}

	private void DelAuthorPermission(Permission permissions, ILead lead)
	{
		((ICollection<ILeadPersonPermission>)lead.Permission).Remove(((IEnumerable<ILeadPersonPermission>)lead.Permission).FirstOrDefault((ILeadPersonPermission r) => r.PermissionRole == CommonRoleTypes.Author.Id && r.PermissionId == permissions.Id));
	}

	private void DelPermission(Permission permissions, ILead lead, EleWise.ELMA.Security.Models.IUser user)
	{
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permissions, lead);
		});
		if (hasPermission)
		{
			((ICollection<ILeadPersonPermission>)lead.Permission).Remove(((IEnumerable<ILeadPersonPermission>)lead.Permission).FirstOrDefault((ILeadPersonPermission r) => r.Assigned == user && r.PermissionId == permissions.Id));
		}
	}

	private void DelPermission(Permission permissions, ILead lead, IOrganizationItem orgItem)
	{
		((ICollection<ILeadPersonPermission>)lead.Permission).Remove(((IEnumerable<ILeadPersonPermission>)lead.Permission).FirstOrDefault((ILeadPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permissions.Id));
	}
}
