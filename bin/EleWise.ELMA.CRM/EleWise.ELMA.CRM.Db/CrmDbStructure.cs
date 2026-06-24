using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Security;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Db;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Db;

public class CrmDbStructure : DbStructureExtension
{
	private bool skipSecondSiteConvert;

	public override Guid ProviderUid => Guid.Empty;

	public override Type[] References => new Type[1] { typeof(SecurityDbStructure) };

	public void FillContractorTypeReference()
	{
		if (ContractorTypeManager.Instance.LoadOrNull(ContractorTypeManager.PartnerItemUid) == null)
		{
			ContractorTypeManager.Instance.CreateDefaultItems();
		}
	}

	public void AddSystemCategory2()
	{
		if (CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid) == null)
		{
			ICategory category = InterfaceActivator.Create<ICategory>();
			category.Uid = CategoryManager.NoCategoryUid;
			category.Name = SR.T("Без категории");
			category.CategoryType = CategoryType.Normal;
			category.Save();
			CategoryManager.Instance.CreateContainerPermission(category, save: true);
		}
	}

	public void UpdateSalesVolume()
	{
		string text = "Sale";
		string text2 = "SalesVolume";
		string text3 = "Sale";
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(text3, text2);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists(text, text2) && serviceNotNull.ColumnExists(text3, deletingColumnTemporaryName))
		{
			string sql = string.Format("UPDATE {0} SET {1} = (SELECT o.{2} FROM {3} o WHERE o.{4} = {0}.{4})", text, text2, deletingColumnTemporaryName, text3, serviceNotNull.Dialect.QuoteIfNeeded("Id"));
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	protected void CrmTaskToCrmTaskBase_ColumnMove(string columnName)
	{
		string text = "TaskBase";
		string text2 = "Task";
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(text2, columnName);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists(text, columnName) && serviceNotNull.ColumnExists(text2, deletingColumnTemporaryName))
		{
			string sql = string.Format("UPDATE {0} SET {1} = (SELECT o.{2} FROM {3} o WHERE o.{4} = {0}.{4})", text, columnName, deletingColumnTemporaryName, text2, serviceNotNull.Dialect.QuoteIfNeeded("Id"));
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	public void CrmTaskToCrmTaskBase()
	{
		CrmTaskToCrmTaskBase_ColumnMove("Contractor");
		CrmTaskToCrmTaskBase_ColumnMove("Contact");
		CrmTaskToCrmTaskBase_ColumnMove("Lead");
		CrmTaskToCrmTaskBase_ColumnMove("Sale");
	}

	public void FixWrongMarketingActivity()
	{
		try
		{
			foreach (IMarketingActivity item in EntityManager<IMarketingActivity>.Instance.Find((IMarketingActivity m) => m.Name == null && m.Responsible == null))
			{
				IContractorFilter contractorFilter = InterfaceActivator.Create<IContractorFilter>();
				contractorFilter.MarketingObjects.Add((IMarketingBase)item);
				contractorFilter.DisableSecurity = true;
				foreach (IContractor item2 in EntityManager<IContractor>.Instance.Find(contractorFilter, FetchOptions.All))
				{
					item2.MarketingActivity = null;
					item2.Save();
				}
				ILeadFilter leadFilter = InterfaceActivator.Create<ILeadFilter>();
				leadFilter.MarketingObjects.Add((IMarketingBase)item);
				leadFilter.DisableSecurity = true;
				foreach (ILead item3 in EntityManager<ILead>.Instance.Find(leadFilter, FetchOptions.All))
				{
					item3.MarketingActivity = null;
					item3.Save();
				}
				item.Delete();
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Error while fixing wrong MarketingActivity entities after Excel Import.", exception);
		}
	}

	public void SaleStagesRelationshipConvert()
	{
		string text = "M_SaleFunnel_SaleStages";
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (!serviceNotNull.TableExists(text))
		{
			return;
		}
		string sql = string.Format("SELECT {0}, {1} FROM {2}", serviceNotNull.Dialect.QuoteIfNeeded("SaleStage"), serviceNotNull.Dialect.QuoteIfNeeded("SaleFunnel"), serviceNotNull.Dialect.QuoteIfNeeded(text));
		List<Tuple<long, long>> list = new List<Tuple<long, long>>();
		try
		{
			using IDataReader dataReader = serviceNotNull.ExecuteQuery(sql);
			while (dataReader.Read())
			{
				list.Add(new Tuple<long, long>(Convert.ToInt64(dataReader[0]), Convert.ToInt64(dataReader[1])));
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error($"Error while reading records from table {text}", exception);
		}
		if (!list.Any())
		{
			return;
		}
		foreach (long stageId in list.Select((Tuple<long, long> x) => x.Item1).Distinct())
		{
			ISaleStage stage = EntityManager<ISaleStage>.Instance.Load(stageId);
			List<long> list2 = (from x in list
				where x.Item1 == stageId
				select x.Item2).ToList();
			for (int i = 0; i < list2.Count; i++)
			{
				ISaleFunnel funnel = EntityManager<ISaleFunnel>.Instance.Load(list2[i]);
				if (i == 0)
				{
					stage.SaleFunnel = funnel;
					stage.GlobalOrder = (from x in list
						where x.Item2 == funnel.Id
						select x.Item1).ToList().IndexOf(stage.Id) + 1;
					stage.Save();
					continue;
				}
				ISaleStage saleStage = null;
				try
				{
					saleStage = CloneHelperBuilder.Create(stage).Restrictions(delegate(RestrictionsBuilder<ISaleStage> m)
					{
						m.Rule().ForPropertyName((ISaleStage s) => s.Color).Clone();
						m.Rule().ForPropertyName((ISaleStage s) => s.SaleFunnel).Ignore();
					}).Clone();
				}
				catch (Exception exception2)
				{
					Logger.Log.Error("CloneHelperBuilder error", exception2);
				}
				if (saleStage == null)
				{
					continue;
				}
				saleStage.Uid = Guid.NewGuid();
				saleStage.SaleFunnel = funnel;
				saleStage.GlobalOrder = (from x in list
					where x.Item2 == funnel.Id
					select x.Item1).ToList().IndexOf(stage.Id) + 1;
				saleStage.Save();
				foreach (ISaleType item in EntityManager<ISaleType>.Instance.Find((ISaleType x) => x.SaleFunnel == funnel).ToList())
				{
					ISaleType type = item;
					foreach (ISale item2 in EntityManager<ISale>.Instance.Find((ISale x) => x.SaleStage == stage && x.SaleType == type).ToList())
					{
						item2.SaleStage = saleStage;
						item2.Save();
					}
				}
			}
		}
		try
		{
			serviceNotNull.RemoveTable(text);
		}
		catch (Exception exception3)
		{
			Logger.Log.Error($"Error while removing table {text}", exception3);
		}
	}

	public void CreateSaleFunnelReportFilters()
	{
		foreach (ISaleFunnel item in SaleFunnelManager.Instance.FindAll())
		{
			SaleFunnelManager.Instance.CreateSaleFunnelReportFilter(item);
		}
	}

	public void FillSalesSaleFunnel()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("UPDATE Sale SET SaleFunnel = (SELECT o.SaleFunnel FROM SaleType o WHERE o.{0} = Sale.SaleType)", serviceNotNull.Dialect.QuoteIfNeeded("Id"));
		serviceNotNull.ExecuteNonQuery(sql);
	}

	public void ZipConvert()
	{
		string text = "Address";
		string text2 = "Zip";
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(text, text2);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists(text, text2) && serviceNotNull.ColumnExists(text, deletingColumnTemporaryName))
		{
			string sql = string.Format("UPDATE {0} SET {1} = {2}", text, serviceNotNull.Dialect.QuoteIfNeeded(text2), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName), serviceNotNull.Dialect.QuoteIfNeeded("Id"));
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	protected void DirectColumnConvert(string tableName, string columnName)
	{
		string deletingColumnTemporaryName = Locator.GetServiceNotNull<DbModelUpdater>().GetDeletingColumnTemporaryName(tableName, columnName);
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		if (serviceNotNull.ColumnExists(tableName, columnName) && serviceNotNull.ColumnExists(tableName, deletingColumnTemporaryName))
		{
			string sql = string.Format("UPDATE {0} SET {1} = {2}", serviceNotNull.Dialect.QuoteIfNeeded(tableName), serviceNotNull.Dialect.QuoteIfNeeded(columnName), serviceNotNull.Dialect.QuoteIfNeeded(deletingColumnTemporaryName), serviceNotNull.Dialect.QuoteIfNeeded("Id"));
			serviceNotNull.ExecuteNonQuery(sql);
		}
	}

	public void SiteConvert()
	{
		DirectColumnConvert("Contractor", "Site");
		DirectColumnConvert("Contact", "Site");
		DirectColumnConvert("Lead", "Site");
		skipSecondSiteConvert = true;
	}

	public void SiteConvertRevert()
	{
		if (!skipSecondSiteConvert)
		{
			DirectColumnConvert("Contractor", "Site");
			DirectColumnConvert("Contact", "Site");
			DirectColumnConvert("Lead", "Site");
		}
	}

	public void FixWrongLeadStatus()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("update {0} set {1} = 0 where {1} = 4", serviceNotNull.Dialect.QuoteIfNeeded("Lead"), serviceNotNull.Dialect.QuoteIfNeeded("Status"));
		serviceNotNull.ExecuteNonQuery(sql);
	}

	public void LeadContactUpdateDateAndAuthor1()
	{
		IEnumerable enumerable = ModelHelper.GetEntityManager(InterfaceActivator.TypeOf<ILeadContact>()).FindAll();
		EleWise.ELMA.Security.Models.IUser creationAuthor = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
		foreach (ILeadContact item in enumerable)
		{
			bool flag = false;
			if (item.CreationDate == DateTime.MinValue)
			{
				item.CreationDate = DateTime.Now;
				flag = true;
			}
			if (item.CreationAuthor == null)
			{
				item.CreationAuthor = creationAuthor;
				flag = true;
			}
			if (flag)
			{
				item.Save();
			}
		}
	}

	public void MarketingActivityUpdateDateAndAuthor1()
	{
		IEnumerable enumerable = ModelHelper.GetEntityManager(InterfaceActivator.TypeOf<IMarketingActivity>()).FindAll();
		EleWise.ELMA.Security.Models.IUser creationAuthor = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
		foreach (IMarketingActivity item in enumerable)
		{
			bool flag = false;
			if (item.CreationDate == DateTime.MinValue)
			{
				item.CreationDate = DateTime.Now;
				flag = true;
			}
			if (item.CreationAuthor == null)
			{
				item.CreationAuthor = creationAuthor;
				flag = true;
			}
			if (flag)
			{
				item.Save();
			}
		}
	}

	public void SaleUpdateDateAndAuthor1()
	{
		foreach (ISale item in from ISale s in ModelHelper.GetEntityManager(InterfaceActivator.TypeOf<ISale>()).FindAll()
			where s.CreationDate == DateTime.MinValue
			select s)
		{
			item.CreationDate = DateTime.Now;
			item.Save();
		}
	}

	public void SaleHistoryConverter()
	{
		if (EntityManager<ISaleStageHistory>.Instance.Exists())
		{
			return;
		}
		ILogger logger = Logger.GetLogger("ElmaDbUpdate");
		logger.Info(SR.T("Начало сбора истории изменений стадии сделок"));
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		List<long> list = session.CreateCriteria(InterfaceActivator.TypeOf<ISaleStage>()).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("Id")) }).List<object>()
			.Select(Convert.ToInt64)
			.ToList();
		IEntityActionHistoryEventService serviceNotNull = Locator.GetServiceNotNull<IEntityActionHistoryEventService>();
		ICriteria val = session.CreateCriteria(InterfaceActivator.TypeOf<IEntityActionHistory>()).Add((ICriterion)(object)Restrictions.Eq("ActionObjectUid", (object)InterfaceActivator.UID<ISale>())).Add((ICriterion)(object)Restrictions.Eq("ActionTypeUid", (object)DefaultEntityActions.UpdateGuid))
			.AddOrder(Order.Asc("ActionObjectId"))
			.AddOrder(Order.Asc("ActionDate"));
		int num = 0;
		ISale sale = null;
		bool flag = false;
		logger.Info(SR.T("Размер пачки: {0}", 100));
		List<IEntityActionHistory> list2;
		do
		{
			logger.Info(SR.T("Старт загрузки пачки с {0}", num));
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			list2 = (from e in val.SetFirstResult(num).SetMaxResults(100).List<IEntityActionHistory>()
				where e != null && e.AdditionalData != null
				select e).ToList();
			stopwatch.Stop();
			logger.Info(SR.T("загружено за {0} мс.", stopwatch.ElapsedMilliseconds));
			foreach (IEntityActionHistory item in list2)
			{
				if (sale == null || sale.Id != item.ActionObjectId.Value)
				{
					sale = SaleManager.Instance.LoadOrNull(item.ActionObjectId.Value);
					if (sale == null)
					{
						continue;
					}
					flag = true;
				}
				EntityActionEventArgs entityActionEventArgs = serviceNotNull.Create<EntityActionEventArgs>(sale, item.ActionObjectUid, item.ActionTypeUid, item.EventArgsUid);
				if (entityActionEventArgs == null || entityActionEventArgs.Action == null || entityActionEventArgs.Object == null || entityActionEventArgs.Old == null || entityActionEventArgs.New == null)
				{
					continue;
				}
				entityActionEventArgs.ActionDate = item.ActionDate;
				entityActionEventArgs.UnitOfWorkUid = item.UnitOfWorkUid;
				entityActionEventArgs.ActionAuthor = item.CreationAuthor;
				entityActionEventArgs.SetAdditionalData(item.AdditionalData);
				ISale sale2 = (ISale)entityActionEventArgs.Old;
				ISale sale3 = (ISale)entityActionEventArgs.New;
				if (sale2.SaleStage != sale3.SaleStage)
				{
					if (flag && sale2.SaleStage != null && list.Contains(sale2.SaleStage.Id))
					{
						ISaleStageHistory saleStageHistory = InterfaceActivator.Create<ISaleStageHistory>();
						saleStageHistory.ChangeAuthor = sale2.Author;
						saleStageHistory.ChangeDate = sale2.CreationDate;
						saleStageHistory.Sale = sale;
						saleStageHistory.SaleStage = sale2.SaleStage;
						saleStageHistory.Save();
					}
					if (sale3.SaleStage != null && list.Contains(sale3.SaleStage.Id))
					{
						ISaleStageHistory saleStageHistory2 = InterfaceActivator.Create<ISaleStageHistory>();
						saleStageHistory2.ChangeAuthor = (EleWise.ELMA.Security.Models.IUser)entityActionEventArgs.ActionAuthor;
						saleStageHistory2.ChangeDate = entityActionEventArgs.ActionDate;
						saleStageHistory2.Sale = sale;
						saleStageHistory2.SaleStage = sale3.SaleStage;
						saleStageHistory2.Save();
					}
					flag = false;
				}
			}
			num += 100;
		}
		while (list2.Count == 100);
		logger.Info(SR.T("Запись изменений"));
		session.Flush();
		DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<ISaleStageHistory>(), "ou").Add((ICriterion)(object)Restrictions.EqProperty("ou.Sale", "rt.Id")).SetProjection((IProjection)(object)Projections.Count("ou.Id"));
		val = session.CreateCriteria(InterfaceActivator.TypeOf<ISale>(), "rt").Add((ICriterion)(object)Subqueries.Eq((object)0, val2)).Add((ICriterion)(object)Restrictions.IsNotNull("SaleStage"));
		logger.Info(SR.T("Получение сделок без изменения стадии"));
		List<ISale> list3 = val.List<ISale>().ToList();
		if (list3.Count > 0)
		{
			logger.Info(SR.T("Обработка {0} сделок", list3.Count));
		}
		foreach (ISale item2 in list3)
		{
			if (item2.SaleStage != null && list.Contains(item2.SaleStage.Id))
			{
				ISaleStageHistory saleStageHistory3 = InterfaceActivator.Create<ISaleStageHistory>();
				saleStageHistory3.ChangeAuthor = item2.Author;
				saleStageHistory3.ChangeDate = item2.CreationDate;
				saleStageHistory3.Sale = item2;
				saleStageHistory3.SaleStage = item2.SaleStage;
				saleStageHistory3.Save();
			}
		}
		logger.Info(SR.T("Сбор истории завершен"));
	}

	public void CreatePresetMarketingTypes()
	{
		IMarketingGroupType marketingGroupType = InterfaceActivator.Create<IMarketingGroupType>();
		marketingGroupType.Name = SR.T("Базовый тип");
		marketingGroupType.Save();
		IMarketingActivityType marketingActivityType = InterfaceActivator.Create<IMarketingActivityType>();
		marketingActivityType.Name = SR.T("Базовый тип");
		marketingActivityType.Save();
		IMarketingEffectType marketingEffectType = InterfaceActivator.Create<IMarketingEffectType>();
		marketingEffectType.Name = SR.T("Базовый тип");
		marketingEffectType.Save();
	}

	public void CreatePresetMarketingFilters4()
	{
		ReferenceOnEntityType type = new ReferenceOnEntityType
		{
			TypeUid = InterfaceActivator.UID<IMarketingBase>()
		};
		IFilterFolder parentFolder = FilterFolderManager.Instance.LoadOrCreateSharedFilterFolder(type);
		IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFilter filter = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingGroupsFilterUid);
		if (filter == null)
		{
			filter = CreateMarketingFilter<IMarketingGroupFilter>(CrmConstants.MarketingGroupsFilterUid, SR.T("Группы мероприятий"), 5L);
			SetAllToReadFilter(filter, group);
		}
		else
		{
			IFilter filter2 = filter;
			InstanceOf<IMarketingBaseFilter> instanceOf = new InstanceOf<IMarketingBaseFilter>();
			instanceOf.New.TypeUid = InterfaceActivator.UID<IMarketingGroup>();
			instanceOf.New.Status = MarketingObjectStatus.Active;
			filter2.FilterFields = UniversalFilterSaver.Pack(instanceOf.New);
			filter.UseDefaultSettings = false;
		}
		filter.ParentFolder = parentFolder;
		filter.Save();
		IFilter filter3 = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingActivitiesFilterUid);
		if (filter3 == null)
		{
			filter3 = CreateMarketingFilter<IMarketingActivityFilter>(CrmConstants.MarketingActivitiesFilterUid, SR.T("Мероприятия"), 10L);
			SetAllToReadFilter(filter3, group);
		}
		else
		{
			IFilter filter4 = filter3;
			InstanceOf<IMarketingBaseFilter> instanceOf2 = new InstanceOf<IMarketingBaseFilter>();
			instanceOf2.New.TypeUid = InterfaceActivator.UID<IMarketingActivity>();
			instanceOf2.New.Status = MarketingObjectStatus.Active;
			filter4.FilterFields = UniversalFilterSaver.Pack(instanceOf2.New);
			filter3.UseDefaultSettings = false;
		}
		filter3.ParentFolder = parentFolder;
		filter3.Save();
		IFilter filter5 = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingEffectsFilterUid);
		if (filter5 == null)
		{
			filter5 = CreateMarketingFilter<IMarketingEffectFilter>(CrmConstants.MarketingEffectsFilterUid, SR.T("Воздействия"), 15L);
			SetAllToReadFilter(filter5, group);
		}
		else
		{
			IFilter filter6 = filter5;
			InstanceOf<IMarketingBaseFilter> instanceOf3 = new InstanceOf<IMarketingBaseFilter>();
			instanceOf3.New.TypeUid = InterfaceActivator.UID<IMarketingEffect>();
			instanceOf3.New.Status = MarketingObjectStatus.Active;
			filter6.FilterFields = UniversalFilterSaver.Pack(instanceOf3.New);
			filter5.UseDefaultSettings = false;
		}
		filter5.ParentFolder = parentFolder;
		filter5.Save();
		IFilter filter7 = CreateMarketingFilter<IMarketingBaseFilter>(CrmConstants.MarketingArchiveFilterUid, SR.T("Архив"), 2147483647L);
		SetAllToReadFilter(filter7, group);
		InstanceOf<IMarketingBaseFilter> instanceOf4 = new InstanceOf<IMarketingBaseFilter>();
		instanceOf4.New.Status = MarketingObjectStatus.Archived;
		filter7.FilterFields = UniversalFilterSaver.Pack(instanceOf4.New);
		filter7.Save();
	}

	private IFilter CreateMarketingFilter<T>(Guid filterUid, string name, long? weight) where T : IMarketingBaseFilter
	{
		IFilter filter = AbstractNHEntityManager<IFilter, long>.Instance.LoadOrNull(filterUid);
		if (filter != null)
		{
			return filter;
		}
		InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
		instanceOf.New.FilterType = FilterType.SystemFilter;
		instanceOf.New.Uid = filterUid;
		instanceOf.New.Name = name;
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = InterfaceActivator.UID<IMarketingBase>()
		};
		instanceOf.New.UseDefaultSettings = false;
		IFilter @new = instanceOf.New;
		InstanceOf<T> instanceOf2 = new InstanceOf<T>();
		T new2 = instanceOf2.New;
		new2.Status = MarketingObjectStatus.Active;
		@new.FilterFields = UniversalFilterSaver.Pack(instanceOf2.New);
		instanceOf.New.Weight = weight;
		return instanceOf.New;
	}

	private void SetAllToReadFilter(IFilter filter, IUserGroup group, bool edit = false, bool full = false)
	{
		ISet<IFilterPermission> permissions = filter.Permissions;
		InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
		instanceOf.New.Filter = filter;
		instanceOf.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterViewPermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf.New.Group = group;
		instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
		permissions.Add(instanceOf.New);
		if (edit)
		{
			ISet<IFilterPermission> permissions2 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf2 = new InstanceOf<IFilterPermission>();
			instanceOf2.New.Filter = filter;
			instanceOf2.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterEditPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf2.New.Group = group;
			instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
			permissions2.Add(instanceOf2.New);
		}
		if (full)
		{
			ISet<IFilterPermission> permissions3 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
			instanceOf3.New.Filter = filter;
			instanceOf3.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterFullAccessPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf3.New.Group = group;
			instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(group.Id);
			permissions3.Add(instanceOf3.New);
		}
	}

	public void MarketingPropertyUidRestore()
	{
		DirectColumnConvert("Contractor", "MarketingActivity");
		DirectColumnConvert("Lead", "MarketingActivity");
		DirectColumnConvert("Sale", "MarketingActivity");
	}

	public void ChangeMarketingFilterObjectType()
	{
		IFilter filter = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingGroupsFilterUid);
		if (filter != null)
		{
			IMarketingBaseFilter marketingBaseFilter = (IMarketingBaseFilter)UniversalFilterSaver.UnPack(filter.FilterFields);
			if (!(marketingBaseFilter is IMarketingGroupFilter))
			{
				InstanceOf<IMarketingGroupFilter> instanceOf = new InstanceOf<IMarketingGroupFilter>();
				instanceOf.New.Status = marketingBaseFilter.Status;
				marketingBaseFilter = instanceOf.New;
				filter.FilterFields = UniversalFilterSaver.Pack(marketingBaseFilter);
				filter.Save();
			}
		}
		IFilter filter2 = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingActivitiesFilterUid);
		if (filter2 != null)
		{
			IMarketingBaseFilter marketingBaseFilter2 = (IMarketingBaseFilter)UniversalFilterSaver.UnPack(filter2.FilterFields);
			if (!(marketingBaseFilter2 is IMarketingActivityFilter))
			{
				InstanceOf<IMarketingActivityFilter> instanceOf2 = new InstanceOf<IMarketingActivityFilter>();
				instanceOf2.New.Status = marketingBaseFilter2.Status;
				marketingBaseFilter2 = instanceOf2.New;
				filter2.FilterFields = UniversalFilterSaver.Pack(marketingBaseFilter2);
				filter2.Save();
			}
		}
		IFilter filter3 = FilterManager.Instance.LoadOrNull(CrmConstants.MarketingEffectsFilterUid);
		if (filter3 != null)
		{
			IMarketingBaseFilter marketingBaseFilter3 = (IMarketingBaseFilter)UniversalFilterSaver.UnPack(filter3.FilterFields);
			if (!(marketingBaseFilter3 is IMarketingEffectFilter))
			{
				InstanceOf<IMarketingEffectFilter> instanceOf3 = new InstanceOf<IMarketingEffectFilter>();
				instanceOf3.New.Status = marketingBaseFilter3.Status;
				marketingBaseFilter3 = instanceOf3.New;
				filter3.FilterFields = UniversalFilterSaver.Pack(marketingBaseFilter3);
				filter3.Save();
			}
		}
	}

	public void CreateTempTableForPermission()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		bool flag = serviceNotNull.TableExists("ContractorPersonPermTmp");
		bool flag2 = flag && serviceNotNull.ColumnExists("ContractorPersonPermTmp", "Uid");
		if ((!flag || !flag2) && !flag)
		{
			Table table = new Table
			{
				Name = "ContractorPersonPermTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("Uid", DbType.Guid),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Contractor", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table);
		}
		flag = serviceNotNull.TableExists("ContactPersonPermTmp");
		flag2 = flag && serviceNotNull.ColumnExists("ContactPersonPermTmp", "Uid");
		if ((!flag || !flag2) && !flag)
		{
			Table table2 = new Table
			{
				Name = "ContactPersonPermTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("Uid", DbType.Guid),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Contact", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table2);
		}
		flag = serviceNotNull.TableExists("SalePersonPermissionTmp");
		flag2 = flag && serviceNotNull.ColumnExists("SalePersonPermissionTmp", "Uid");
		if ((!flag || !flag2) && !flag)
		{
			Table table3 = new Table
			{
				Name = "SalePersonPermissionTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("Uid", DbType.Guid),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Sale", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table3);
		}
		flag = serviceNotNull.TableExists("LeadPersonPermissionTmp");
		flag2 = flag && serviceNotNull.ColumnExists("LeadPersonPermissionTmp", "Uid");
		if ((!flag || !flag2) && !flag)
		{
			Table table4 = new Table
			{
				Name = "LeadPersonPermissionTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("Uid", DbType.Guid),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Lead", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table4);
		}
		flag = serviceNotNull.TableExists("RelationshipPersPermTmp");
		flag2 = flag && serviceNotNull.ColumnExists("RelationshipPersPermTmp", "Uid");
		if ((!flag || !flag2) && !flag)
		{
			Table table5 = new Table
			{
				Name = "RelationshipPersPermTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey),
					new Column("Uid", DbType.Guid),
					new Column("PermissionId", DbType.Guid),
					new Column("User", DbType.Int64),
					new Column("Group", DbType.Int64),
					new Column("OrganizationItemPosition", DbType.Int64),
					new Column("UserSecuritySetCacheId", DbType.Int64),
					new Column("PermissionRole", DbType.Guid),
					new Column("OrganizationItemEmployee", DbType.Int64),
					new Column("Relationship", DbType.Int64),
					new Column("InheritedFromNumber", DbType.Int64)
				},
				Sequence = true
			};
			serviceNotNull.AddTable(table5);
		}
		if (!serviceNotNull.TableExists("CheckContractorCategTmp"))
		{
			Table table6 = new Table
			{
				Name = "CheckContractorCategTmp",
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64)
				}
			};
			serviceNotNull.AddTable(table6);
		}
	}

	public void CreateTempTableForPermissionKeys()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		foreach (ForeignKey item in new List<ForeignKey>
		{
			new ForeignKey
			{
				Name = "FK_M_IDX_OX_ContrPerPermTmp",
				TableName = "ContractorPersonPermTmp",
				Columns = new List<string> { "OrganizationItemEmployee" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_contr_ContrPerPermTmp",
				TableName = "ContractorPersonPermTmp",
				Columns = new List<string> { "Contractor" },
				RefTableName = "Contractor",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_UG_ContrPerPermTmp",
				TableName = "ContractorPersonPermTmp",
				Columns = new List<string> { "Group" },
				RefTableName = "UserGroup",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_User_ContrPerPermTmp",
				TableName = "ContractorPersonPermTmp",
				Columns = new List<string> { "User" },
				RefTableName = "User",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OI_ContrPerPermTmp",
				TableName = "ContractorPersonPermTmp",
				Columns = new List<string> { "OrganizationItemPosition" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OX_ContPerPermTmp",
				TableName = "ContactPersonPermTmp",
				Columns = new List<string> { "OrganizationItemEmployee" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_contr_ContPerPermTmp",
				TableName = "ContactPersonPermTmp",
				Columns = new List<string> { "Contact" },
				RefTableName = "Contact",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_UG_ContPerPermTmp",
				TableName = "ContactPersonPermTmp",
				Columns = new List<string> { "Group" },
				RefTableName = "UserGroup",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_User_ContPerPermTmp",
				TableName = "ContactPersonPermTmp",
				Columns = new List<string> { "User" },
				RefTableName = "User",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OI_ContPerPermTmp",
				TableName = "ContactPersonPermTmp",
				Columns = new List<string> { "OrganizationItemPosition" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OX_SalePerPermTmp",
				TableName = "SalePersonPermissionTmp",
				Columns = new List<string> { "OrganizationItemEmployee" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_contr_SalePerPermTmp",
				TableName = "SalePersonPermissionTmp",
				Columns = new List<string> { "Sale" },
				RefTableName = "Sale",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_UG_SalePerPermTmp",
				TableName = "SalePersonPermissionTmp",
				Columns = new List<string> { "Group" },
				RefTableName = "UserGroup",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_User_SalePerPermTmp",
				TableName = "SalePersonPermissionTmp",
				Columns = new List<string> { "User" },
				RefTableName = "User",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OI_SalePerPermTmp",
				TableName = "SalePersonPermissionTmp",
				Columns = new List<string> { "OrganizationItemPosition" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OX_LeadPerPermTmp",
				TableName = "LeadPersonPermissionTmp",
				Columns = new List<string> { "OrganizationItemEmployee" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_contr_LeadPerPermTmp",
				TableName = "LeadPersonPermissionTmp",
				Columns = new List<string> { "Lead" },
				RefTableName = "Lead",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_UG_LeadPerPermTmp",
				TableName = "LeadPersonPermissionTmp",
				Columns = new List<string> { "Group" },
				RefTableName = "UserGroup",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_User_LeadPerPermTmp",
				TableName = "LeadPersonPermissionTmp",
				Columns = new List<string> { "User" },
				RefTableName = "User",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OI_LeadPerPermTmp",
				TableName = "LeadPersonPermissionTmp",
				Columns = new List<string> { "OrganizationItemPosition" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OX_RelPersPermTmp",
				TableName = "RelationshipPersPermTmp",
				Columns = new List<string> { "OrganizationItemEmployee" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_contr_RelPersPermTmp",
				TableName = "RelationshipPersPermTmp",
				Columns = new List<string> { "Relationship" },
				RefTableName = "Relationship",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_UG_RelPersPermTmp",
				TableName = "RelationshipPersPermTmp",
				Columns = new List<string> { "Group" },
				RefTableName = "UserGroup",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_User_RelPersPermTmp",
				TableName = "RelationshipPersPermTmp",
				Columns = new List<string> { "User" },
				RefTableName = "User",
				RefColumns = new List<string> { "Id" }
			},
			new ForeignKey
			{
				Name = "FK_M_IDX_OI_RelPersPermTmp",
				TableName = "RelationshipPersPermTmp",
				Columns = new List<string> { "OrganizationItemPosition" },
				RefTableName = "OrganizationItem",
				RefColumns = new List<string> { "Id" }
			}
		})
		{
			serviceNotNull.AddForeignKey(item);
		}
	}

	public void CreateGroupUpdate()
	{
		CreateGroupUpdate(CRMPermissionProvider.CRMContactCreatePermission);
		CreateGroupUpdate(CRMPermissionProvider.CRMSaleCreatePermission);
		CreateGroupUpdate(CRMPermissionProvider.CRMLeadCreatePermission);
		CreateGroupUpdate(CRMPermissionProvider.CRMproductCreatePermission);
		CreateGroupUpdate(CRMPermissionProvider.CRMMarketingCreatePermission);
		foreach (KeyValuePair<Guid, Permission> item in CRMPermissionProvider.ListContractorType)
		{
			CreateGroupUpdate(item.Value);
		}
	}

	public void UpdateSystemUser()
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.LoadOrNull(SecurityConstants.AdminUserUid);
		EleWise.ELMA.Security.Models.IUser user2 = UserManager.Instance.LoadOrNull(SecurityConstants.SystemUserUid);
		if (user != null && user2 != null)
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			string[] columns = new string[1] { "User" };
			object[] values = new object[1] { user2.Id };
			string where = string.Format("{0} in ({1}PermissionRoleTypeResponsible,{1}PermissionRoleTypeInforms,{1}PermissionRoleAuthor,{1}PermRoleTypeParticipantWork) and {2}={1}adminUser", serviceNotNull.Dialect.QuoteIfNeeded("PermissionRole"), serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.QuoteIfNeeded("User"));
			Dictionary<string, object> paramValues = new Dictionary<string, object>
			{
				{
					"PermissionRoleTypeResponsible",
					CommonRoleTypes.Responsible.Id
				},
				{
					"PermissionRoleTypeInforms",
					CommonRoleTypes.Informs.Id
				},
				{
					"PermissionRoleAuthor",
					CommonRoleTypes.Author.Id
				},
				{
					"PermRoleTypeParticipantWork",
					CommonRoleTypes.ParticipantWork.Id
				},
				{ "adminUser", user.Id }
			};
			serviceNotNull.Update("TemplateContractorPermission", columns, values, where, paramValues);
			serviceNotNull.Update("TemplateLeadPermission", columns, values, where, paramValues);
			serviceNotNull.Update("ContractorPersonPermission", columns, values, where, paramValues);
			serviceNotNull.Update("ContactPersonPermission", columns, values, where, paramValues);
			serviceNotNull.Update("LeadPersonPermission", columns, values, where, paramValues);
			serviceNotNull.Update("RelationshipPersonPermission", columns, values, where, paramValues);
			serviceNotNull.Update("SalePersonPermission", columns, values, where, paramValues);
			columns = new string[3]
			{
				serviceNotNull.Dialect.QuoteIfNeeded("CreationAuthor"),
				serviceNotNull.Dialect.QuoteIfNeeded("Responsible"),
				serviceNotNull.Dialect.QuoteIfNeeded("Informs")
			};
			values = new object[3] { user2.Id, user2.Id, user2.Id };
			serviceNotNull.Update(((EntityMetadata)InterfaceActivator.LoadMetadata<IContContractorPermission>(inherit: true, loadImplementation: false)).TableName, columns, values, "");
			serviceNotNull.Update(((EntityMetadata)InterfaceActivator.LoadMetadata<IContLeadPermission>(inherit: true, loadImplementation: false)).TableName, columns, values, "");
		}
	}

	private void CreateGroupUpdate(Permission permission)
	{
		GroupPermissionManager serviceNotNull = Locator.GetServiceNotNull<GroupPermissionManager>();
		IEntityManager<IAssignedRoleStereotype> instance = EntityManager<IAssignedRoleStereotype>.Instance;
		IEnumerable<PermissionStereotype> permissionStereotypes = new CRMPermissionProvider().GetPermissionStereotypes();
		if (!serviceNotNull.GetGroupsByPermissionUid(new Guid("{1df995f3-0755-4fe8-a1f8-f62ba3dc12fa}")).Any())
		{
			return;
		}
		foreach (PermissionStereotype item in permissionStereotypes)
		{
			IAssignedRoleStereotype assignedRoleStereotype = InterfaceActivator.Create<IAssignedRoleStereotype>();
			assignedRoleStereotype.GroupUid = item.DefaultAssignee.Uid;
			assignedRoleStereotype.PermissionUid = permission.Id;
			instance.Save(assignedRoleStereotype);
		}
		foreach (IUserGroup item2 in serviceNotNull.GetGroupsByPermissionUid(new Guid("{1df995f3-0755-4fe8-a1f8-f62ba3dc12fa}")))
		{
			serviceNotNull.GrantPermission(item2, permission);
		}
	}

	public void CreateDefaultColorStepScoring()
	{
		if (EntityManager<IColor>.Instance.LoadOrNull(CrmConstants.DefaultColorYellowUid) == null)
		{
			IColor color = InterfaceActivator.Create<IColor>();
			color.Uid = CrmConstants.DefaultColorYellowUid;
			color.ColorCode = "#fff100";
			color.Save();
		}
		if (EntityManager<IColor>.Instance.LoadOrNull(CrmConstants.DefaultColorRedUid) == null)
		{
			IColor color2 = InterfaceActivator.Create<IColor>();
			color2.Uid = CrmConstants.DefaultColorRedUid;
			color2.ColorCode = "#eaa59b";
			color2.Save();
		}
		LeadStepScoring.CreateDefaultStep();
	}

	private void CreateCreationLeadFilter(string name, Guid uid, RelativeDateTime relativeCreationDate, long weight, IUserGroup allUsersGroup)
	{
		InstanceOf<IFilter> instanceOf = new InstanceOf<IFilter>();
		instanceOf.New.FilterType = FilterType.SystemFilter;
		instanceOf.New.Uid = uid;
		instanceOf.New.Name = name;
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = InterfaceActivator.UID<ILead>()
		};
		instanceOf.New.UseDefaultSettings = true;
		IFilter @new = instanceOf.New;
		InstanceOf<ILeadFilter> instanceOf2 = new InstanceOf<ILeadFilter>();
		instanceOf2.New.RelativeCreationDate = relativeCreationDate;
		@new.FilterFields = UniversalFilterSaver.Pack(instanceOf2.New);
		instanceOf.New.Weight = weight;
		IFilter new2 = instanceOf.New;
		ISet<IFilterPermission> permissions = new2.Permissions;
		InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
		instanceOf3.New.Filter = new2;
		instanceOf3.New.PermissionId = EleWise.ELMA.Common.PermissionProvider.FilterViewPermission.Id;
		instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf3.New.Group = allUsersGroup;
		instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(allUsersGroup.Id);
		permissions.Add(instanceOf3.New);
		new2.Save();
	}

	public void CreateCreationLeadFilters()
	{
		IUserGroup allUsersGroup = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		CreateCreationLeadFilter(SR.T("Текущая неделя"), LeadManager.ThisWeekFilterUid, new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0w",
			RelativeTo = "0w"
		}, -4L, allUsersGroup);
		CreateCreationLeadFilter(SR.T("Прошлая неделя"), LeadManager.LastWeekFilterUid, new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "-1w",
			RelativeTo = "-1w"
		}, -3L, allUsersGroup);
		CreateCreationLeadFilter(SR.T("Текущий месяц"), LeadManager.ThisMonthFilterUid, new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "0m",
			RelativeTo = "0m"
		}, -2L, allUsersGroup);
		CreateCreationLeadFilter(SR.T("Прошлый месяц"), LeadManager.LastMonthFilterUid, new RelativeDateTime
		{
			IsRelative = true,
			RelativeFrom = "-1m",
			RelativeTo = "-1m"
		}, -1L, allUsersGroup);
	}

	public void UpdateLeadDublicateStatus()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string sql = string.Format("update {0} set {1} = (case when {2} = 4 then 3 else 2 end) where {1} is null", serviceNotNull.Dialect.QuoteIfNeeded("Lead"), serviceNotNull.Dialect.QuoteIfNeeded("LeadDublicateStatus"), serviceNotNull.Dialect.QuoteIfNeeded("Status"));
		serviceNotNull.ExecuteNonQuery(sql);
	}

	public void CreateLeadDublicateState()
	{
		ILeadFilter leadFilter = InterfaceActivator.Create<ILeadFilter>();
		leadFilter.Query = "not (Id in (from LeadDublicateState select Lead where Lead = parent.Id))";
		foreach (ILead item in LeadManager.Instance.Find(leadFilter, FetchOptions.All))
		{
			LeadDublicateStateManager.Instance.SetDublicateState(item, item.LeadDublicateStatus.HasValue ? item.LeadDublicateStatus.Value : LeadDublicateStatus.New);
		}
	}

	public void CreateCalendarActionFilter()
	{
		IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFilterActionLink filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(CrmConstants.CalendarActionFilter);
		if (filterActionLink == null)
		{
			InstanceOf<IFilterActionLink> instanceOf = new InstanceOf<IFilterActionLink>();
			instanceOf.New.FilterType = FilterType.SystemFilter;
			instanceOf.New.Uid = CrmConstants.CalendarActionFilter;
			instanceOf.New.Name = SR.T("Календарь");
			instanceOf.New.Description = SR.T("Переход на страницу с календарем");
			instanceOf.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = InterfaceActivator.UID<IMarketingBase>()
			};
			instanceOf.New.Code = CrmConstants.CalendarFilterCode;
			instanceOf.New.UseDefaultSettings = true;
			instanceOf.New.ActionTypeProviderId = "ActionsLinkTypeProvider";
			instanceOf.New.ActionId = "EleWise.ELMA.CRM.Web-Module-CalendarPage";
			instanceOf.New.Weight = 0L;
			filterActionLink = instanceOf.New;
			SetAllToReadFilter(filterActionLink, group);
			filterActionLink.Save();
			FilterDefaultManager.Instance.SaveSystemDefaultFilter(filterActionLink);
		}
	}

	public void CreateMarketingStatisticActionFilter()
	{
		IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IFilterActionLink filterActionLink = AbstractNHEntityManager<IFilterActionLink, long>.Instance.LoadOrNull(CrmConstants.MarketingStatisticActionFilter);
		if (filterActionLink == null)
		{
			InstanceOf<IFilterActionLink> instanceOf = new InstanceOf<IFilterActionLink>();
			instanceOf.New.FilterType = FilterType.SystemFilter;
			instanceOf.New.Uid = CrmConstants.MarketingStatisticActionFilter;
			instanceOf.New.Name = SR.T("Статистика");
			instanceOf.New.Description = SR.T("Переход на страницу со статистикой");
			instanceOf.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = InterfaceActivator.UID<IMarketingBase>()
			};
			instanceOf.New.Code = CrmConstants.MarketingStatisticFilterCode;
			instanceOf.New.UseDefaultSettings = true;
			instanceOf.New.ActionTypeProviderId = "ActionsLinkTypeProvider";
			instanceOf.New.ActionId = "EleWise.ELMA.CRM.Web-Module-MarketingStatisticPage";
			instanceOf.New.Weight = 0L;
			filterActionLink = instanceOf.New;
			SetAllToReadFilter(filterActionLink, group);
			filterActionLink.Save();
			FilterDefaultManager.Instance.SaveSystemDefaultFilter(filterActionLink);
		}
	}

	public void UpdateArchiveDate()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string expression = string.Format("(select max(a.{0}) from {1} a where a.{2} = {3}.{4} and a.{5} = {6}actionTypeUid)", serviceNotNull.Dialect.QuoteIfNeeded("ActionDate"), serviceNotNull.Dialect.QuoteIfNeeded("EntityActionHistory"), serviceNotNull.Dialect.QuoteIfNeeded("ActionObjectId"), serviceNotNull.Dialect.QuoteIfNeeded("MarketingBase"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("ActionTypeUid"), serviceNotNull.ParameterSeparator);
		string where = string.Format("{0} is null and {1} = {2}", serviceNotNull.Dialect.QuoteIfNeeded("ArchiveDate"), serviceNotNull.Dialect.QuoteIfNeeded("Status"), 1);
		serviceNotNull.Update("MarketingBase", new string[1] { "ArchiveDate" }, new object[1]
		{
			new SqlExpressionParameter(expression)
		}, where, new Dictionary<string, object> { 
		{
			"actionTypeUid",
			MarketingBaseActions.ArchiveGuid
		} });
	}

	public void CreateMarketingFirstPayment()
	{
		IMarketingBaseFilter marketingBaseFilter = InterfaceActivator.Create<IMarketingBaseFilter>();
		marketingBaseFilter.Query = "BudgetType = 0 and Payments is EMPTY";
		foreach (IMarketingBase item in MarketingBaseManager.Instance.Find(marketingBaseFilter, FetchOptions.All))
		{
			MarketingPaymentManager.Instance.CreatePaymentOnBudget(item);
		}
	}

	public void UpdateDateMarketingActivity()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string expression = string.Format("(select {1} from {2} a where a.{3} = {0}.{3})", serviceNotNull.Dialect.QuoteIfNeeded("MarketingActivity"), serviceNotNull.Dialect.QuoteIfNeeded("CreationDate"), serviceNotNull.Dialect.QuoteIfNeeded("MarketingBase"), serviceNotNull.Dialect.QuoteIfNeeded("Id"));
		serviceNotNull.Update("MarketingActivity", new string[2] { "StartDate", "EndDate" }, new object[2]
		{
			new SqlExpressionParameter(expression),
			new SqlExpressionParameter(expression)
		}, string.Format("{0} is null", serviceNotNull.Dialect.QuoteIfNeeded("StartDate")));
	}

	public void UpdateDateMarketingEffect()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string expression = string.Format("(select {1} from {2} a where a.{3} = {0}.{3})", serviceNotNull.Dialect.QuoteIfNeeded("MarketingEffect"), serviceNotNull.Dialect.QuoteIfNeeded("CreationDate"), serviceNotNull.Dialect.QuoteIfNeeded("MarketingBase"), serviceNotNull.Dialect.QuoteIfNeeded("Id"));
		serviceNotNull.Update("MarketingEffect", new string[2] { "StartDate", "EndDate" }, new object[2]
		{
			new SqlExpressionParameter(expression),
			new SqlExpressionParameter(expression)
		}, string.Format("{0} is null", serviceNotNull.Dialect.QuoteIfNeeded("StartDate")));
	}

	public void UpdateMarketingEffectBudgetType()
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string where = string.Format("{0} in (select {0} from {1})", serviceNotNull.Dialect.QuoteIfNeeded("Id"), serviceNotNull.Dialect.QuoteIfNeeded("MarketingEffect"));
		serviceNotNull.Update("MarketingBase", new string[1] { "BudgetType" }, new object[1] { 1 }, where);
	}

	public void AddDefaultCategoryPermission()
	{
		bool flag = false;
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		ICategory category = CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid);
		if (category != null && category.ContainerContractorPermission != null && category.ContainerContractorPermission.TemplateContractorPermission != null)
		{
			ISet<ITemplateContractorPermission> templateContractorPermission = category.ContainerContractorPermission.TemplateContractorPermission;
			if (!((IEnumerable<ITemplateContractorPermission>)templateContractorPermission).Any())
			{
				InstanceOf<ITemplateContractorPermission> instanceOf = new InstanceOf<ITemplateContractorPermission>();
				instanceOf.New.ContainerContractor = category.ContainerContractorPermission;
				instanceOf.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf.New.PermissionId = CRMPermissionProvider.ViewContractorPermission.Id;
				instanceOf.New.User = user;
				instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf.New.AddPermission = true;
				templateContractorPermission.Add(instanceOf.New);
				InstanceOf<ITemplateContractorPermission> instanceOf2 = new InstanceOf<ITemplateContractorPermission>();
				instanceOf2.New.ContainerContractor = category.ContainerContractorPermission;
				instanceOf2.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf2.New.PermissionId = CRMPermissionProvider.EditContractorPermission.Id;
				instanceOf2.New.User = user;
				instanceOf2.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf2.New.AddPermission = true;
				templateContractorPermission.Add(instanceOf2.New);
				InstanceOf<ITemplateContractorPermission> instanceOf3 = new InstanceOf<ITemplateContractorPermission>();
				instanceOf3.New.ContainerContractor = category.ContainerContractorPermission;
				instanceOf3.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf3.New.PermissionId = CRMPermissionProvider.CRMContractorCreateElementPermission.Id;
				instanceOf3.New.User = user;
				instanceOf3.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf3.New.AddPermission = true;
				templateContractorPermission.Add(instanceOf3.New);
				InstanceOf<ITemplateContractorPermission> instanceOf4 = new InstanceOf<ITemplateContractorPermission>();
				instanceOf4.New.ContainerContractor = category.ContainerContractorPermission;
				instanceOf4.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf4.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf4.New.PermissionId = CRMPermissionProvider.CRMContractorFullAccessPermission.Id;
				instanceOf4.New.User = user;
				instanceOf4.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf4.New.AddPermission = true;
				templateContractorPermission.Add(instanceOf4.New);
				InstanceOf<ITemplateContractorPermission> instanceOf5 = new InstanceOf<ITemplateContractorPermission>();
				instanceOf5.New.ContainerContractor = category.ContainerContractorPermission;
				instanceOf5.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf5.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf5.New.PermissionId = CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id;
				instanceOf5.New.User = user;
				instanceOf5.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf5.New.AddPermission = true;
				templateContractorPermission.Add(instanceOf5.New);
				category.ContainerContractorPermission.Save();
				flag = true;
			}
		}
		if (category != null && category.ContainerLeadPermission != null && category.ContainerLeadPermission.TemplateLeadPermission != null)
		{
			ISet<ITemplateLeadPermission> templateLeadPermission = category.ContainerLeadPermission.TemplateLeadPermission;
			if (!((IEnumerable<ITemplateLeadPermission>)templateLeadPermission).Any())
			{
				InstanceOf<ITemplateLeadPermission> instanceOf6 = new InstanceOf<ITemplateLeadPermission>();
				instanceOf6.New.ContainerLead = category.ContainerLeadPermission;
				instanceOf6.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf6.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf6.New.PermissionId = CRMPermissionProvider.ViewLeadPermission.Id;
				instanceOf6.New.User = user;
				instanceOf6.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf6.New.AddPermission = true;
				templateLeadPermission.Add(instanceOf6.New);
				InstanceOf<ITemplateLeadPermission> instanceOf7 = new InstanceOf<ITemplateLeadPermission>();
				instanceOf7.New.ContainerLead = category.ContainerLeadPermission;
				instanceOf7.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf7.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf7.New.PermissionId = CRMPermissionProvider.EditLeadPermission.Id;
				instanceOf7.New.User = user;
				instanceOf7.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf7.New.AddPermission = true;
				templateLeadPermission.Add(instanceOf7.New);
				InstanceOf<ITemplateLeadPermission> instanceOf8 = new InstanceOf<ITemplateLeadPermission>();
				instanceOf8.New.ContainerLead = category.ContainerLeadPermission;
				instanceOf8.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf8.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf8.New.PermissionId = CRMPermissionProvider.CRMLeadCreateElementPermission.Id;
				instanceOf8.New.User = user;
				instanceOf8.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf8.New.AddPermission = true;
				templateLeadPermission.Add(instanceOf8.New);
				InstanceOf<ITemplateLeadPermission> instanceOf9 = new InstanceOf<ITemplateLeadPermission>();
				instanceOf9.New.ContainerLead = category.ContainerLeadPermission;
				instanceOf9.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf9.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf9.New.PermissionId = CRMPermissionProvider.CRMLeadFullAccessPermission.Id;
				instanceOf9.New.User = user;
				instanceOf9.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf9.New.AddPermission = true;
				templateLeadPermission.Add(instanceOf9.New);
				InstanceOf<ITemplateLeadPermission> instanceOf10 = new InstanceOf<ITemplateLeadPermission>();
				instanceOf10.New.ContainerLead = category.ContainerLeadPermission;
				instanceOf10.New.PermissionRole = CommonRoleTypes.Author.UID;
				instanceOf10.New.TypeRoleId = CommonRoleTypes.Author.Id;
				instanceOf10.New.PermissionId = CRMPermissionProvider.CRMLeadIssuanceElementPermission.Id;
				instanceOf10.New.User = user;
				instanceOf10.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(user.Id);
				instanceOf10.New.AddPermission = true;
				templateLeadPermission.Add(instanceOf10.New);
				flag = true;
				category.ContainerLeadPermission.Save();
			}
		}
		if (flag)
		{
			Locator.GetServiceNotNull<ISessionProvider>().GetSession("").Flush();
			CategoryManager.Instance.RecalculateCategoryPermission();
		}
	}

	public void ConvertMarketingTagColumns()
	{
		Locator.GetServiceNotNull<ITransformationProvider>().ConvertColumnString("MarketingTag", InterfaceActivator.PropertyName((IMarketingTag t) => t.Name), 100, substringStrings: true);
	}

	internal void UpdateDuplicateCodeCountries()
	{
		long num = 0L;
		long num2 = 0L;
		int num3 = 10000;
		ILogger logger = Logger.GetLogger("ElmaDbUpdate");
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		IList<ICountry> list = session.CreateCriteria(InterfaceActivator.TypeOf<ICountry>()).Add((ICriterion)(object)Restrictions.Eq("CountryCode", (object)null)).List<ICountry>();
		IList<ICountry> list2 = ((IQuery)session.CreateSQLQuery(string.Format("\r\nSELECT {{country.*}} FROM {0} WHERE {1} IN\r\n(\r\nSELECT {1} FROM {0} GROUP BY {1} HAVING COUNT(*) > 1\r\n)\r\nORDER BY {1}", serviceNotNull.Dialect.QuoteIfNeeded("Country"), serviceNotNull.Dialect.QuoteIfNeeded("CountryCode"))).AddEntity("country", InterfaceActivator.TypeOf<ICountry>())).List<ICountry>();
		foreach (ICountry item in list)
		{
			num = num3 + item.Id;
			logger.Info(SR.T("Код страны {0} изменен с null на {1}", item.Name, num));
			item.CountryCode = num;
			item.Save();
		}
		foreach (ICountry item2 in list2)
		{
			if (item2.CountryCode == num2)
			{
				num = num3 + item2.Id;
				logger.Info(SR.T("Код страны {0} изменен с {1} на {2}", item2.Name, item2.CountryCode, num));
				num2 = item2.CountryCode;
				item2.CountryCode = num;
				item2.Save();
			}
			else
			{
				num2 = item2.CountryCode;
			}
		}
	}

	internal void SetDefaultPermissionsToMarketingGroups()
	{
		IUserGroup[] marketingReadOnlyAccessGroups = Locator.GetServiceNotNull<GroupPermissionManager>().GetGroupsByPermission(CRMPermissionProvider.MarketingAccessPermission).ToArray();
		foreach (IMarketingGroup item in EntityManager<IMarketingGroup>.Instance.Find(FetchOptions.All))
		{
			((ICollection<IMarketingPersonPermission>)item.Permission).AddSequense(MarketingObjectPermissionsCreator.GetDefaultPermissions(item, marketingReadOnlyAccessGroups));
			foreach (IMarketingActivity item2 in (IEnumerable<IMarketingActivity>)item.MarketingActivities)
			{
				item2.InheritPermissions = true;
				((ICollection<IMarketingPersonPermission>)item2.Permission).AddSequense(MarketingObjectPermissionsCreator.GetInheritedPermissions(item2));
				foreach (IMarketingEffect item3 in (IEnumerable<IMarketingEffect>)item2.MarketingEffects)
				{
					item3.InheritPermissions = true;
					((ICollection<IMarketingPersonPermission>)item3.Permission).AddSequense(MarketingObjectPermissionsCreator.GetInheritedPermissions(item3));
				}
			}
			item.Save();
		}
		InstanceOf<IMarketingActivityFilter> instanceOf = new InstanceOf<IMarketingActivityFilter>();
		instanceOf.New.Query = "MarketingGroup is null";
		IMarketingActivityFilter @new = instanceOf.New;
		foreach (IMarketingActivity item4 in EntityManager<IMarketingActivity>.Instance.Find(@new, FetchOptions.All))
		{
			((ICollection<IMarketingPersonPermission>)item4.Permission).AddSequense(MarketingObjectPermissionsCreator.GetDefaultPermissions(item4, marketingReadOnlyAccessGroups));
			foreach (IMarketingEffect item5 in (IEnumerable<IMarketingEffect>)item4.MarketingEffects)
			{
				item5.InheritPermissions = true;
				((ICollection<IMarketingPersonPermission>)item5.Permission).AddSequense(MarketingObjectPermissionsCreator.GetInheritedPermissions(item5));
			}
		}
	}

	internal void MoveSalesAttachmentFromElma3()
	{
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeof(ICRMAttachment)) as EntityMetadata;
		EntitySettings entitySettings = (entityMetadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Name == "Sale") as EntityPropertyMetadata).Settings as EntitySettings;
		StringSettings stringSettings = (entityMetadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Name == "Comment") as EntityPropertyMetadata).Settings as StringSettings;
		string deletingColumnTemporaryName = base.Transformation.GetDeletingColumnTemporaryName(entityMetadata.TableName, entitySettings.FieldName);
		string deletingColumnTemporaryName2 = base.Transformation.GetDeletingColumnTemporaryName(entityMetadata.TableName, stringSettings.FieldName);
		if (base.Transformation.ColumnExists(entityMetadata.TableName, deletingColumnTemporaryName) && base.Transformation.ColumnExists(entityMetadata.TableName, entitySettings.FieldName) && base.Transformation.ColumnExists(entityMetadata.TableName, stringSettings.FieldName) && base.Transformation.ColumnExists(entityMetadata.TableName, deletingColumnTemporaryName2))
		{
			base.Transformation.ExecuteNonQuery($"update {base.Transformation.Dialect.QuoteIfNeeded(entityMetadata.TableName)} set {base.Transformation.Dialect.QuoteIfNeeded(entitySettings.FieldName)} = {base.Transformation.Dialect.QuoteIfNeeded(deletingColumnTemporaryName)}, {base.Transformation.Dialect.QuoteIfNeeded(stringSettings.FieldName)} = {base.Transformation.Dialect.QuoteIfNeeded(deletingColumnTemporaryName2)}");
		}
	}
}
