using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Audit;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CategoryManager : EntityManager<ICategory, long>
{
	private readonly UserManager userManager;

	private readonly ITransformationProvider transformationProvider;

	public static readonly Guid NoCategoryUid = new Guid("B53287AB-211B-4498-A054-2776C4D270AD");

	private readonly IndexQueueManager indexQueueManager;

	public ILockManager LockManager { get; set; }

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	public ICacheService CacheService { get; set; }

	private ISessionProvider sessionProvider { get; set; }

	public new static CategoryManager Instance => Locator.GetServiceNotNull<CategoryManager>();

	public static Guid TypeUid => InterfaceActivator.UID<ICategory>();

	public CategoryManager(UserManager userManager, ITransformationProvider transformationProvider, IndexQueueManager indexQueueManager)
	{
		this.userManager = userManager;
		this.transformationProvider = transformationProvider;
		this.indexQueueManager = indexQueueManager;
	}

	[PublicApiMember]
	public override void Delete(ICategory obj)
	{
		if (obj.Uid == NoCategoryUid)
		{
			throw new Exception(SR.T("Нельзя удалить системную категорию \"{0}\"", obj.Name));
		}
		((IEnumerable<ITemplateContractorPermission>)EntityManager<IContContractorPermission>.Instance.Load(obj.ContainerContractorPermission.Uid).TemplateContractorPermission).ForEach(delegate(ITemplateContractorPermission a)
		{
			a.DelPermission = true;
			a.Save();
		});
		((IEnumerable<ITemplateLeadPermission>)EntityManager<IContLeadPermission>.Instance.Load(obj.ContainerLeadPermission.Uid).TemplateLeadPermission).ForEach(delegate(ITemplateLeadPermission a)
		{
			a.DelPermission = true;
			a.Save();
		});
		base.Delete(obj);
	}

	public IEnumerable<ICategory> GetAllCategories()
	{
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.ShowNoCategory = true;
		return Find(categoryFilter, FetchOptions.All);
	}

	public ICategory GetCategoryWithTitleNoCategory()
	{
		return Load(NoCategoryUid);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is ICategoryFilter categoryFilter)
		{
			if (!categoryFilter.ShowNoCategory)
			{
				criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Uid", (object)NoCategoryUid)));
			}
		}
		else
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Uid", (object)NoCategoryUid)));
		}
	}

	public bool CheckUpdateCategoryContractorPermission(ICategory category = null)
	{
		IContContractorPermission contContractorPermission = null;
		if (category != null && category.ContainerContractorPermission != null)
		{
			contContractorPermission = EntityManager<IContContractorPermission>.Instance.LoadOrNull(category.ContainerContractorPermission.Id);
		}
		ITemplateContractorPermissionFilter templateContractorPermissionFilter = InterfaceActivator.Create<ITemplateContractorPermissionFilter>();
		if (contContractorPermission != null)
		{
			templateContractorPermissionFilter.ContainerContractor = contContractorPermission;
		}
		templateContractorPermissionFilter.Query = "(DelPermission=1 or AddPermission=1)";
		ICollection<ITemplateContractorPermission> collection = EntityManager<ITemplateContractorPermission>.Instance.Find(templateContractorPermissionFilter, null);
		if (collection != null && collection.Any())
		{
			return true;
		}
		return false;
	}

	public void CreateContainerPermission(ICategory category, bool save)
	{
		EleWise.ELMA.Security.Models.IUser user = userManager.LoadOrNull(SecurityConstants.SystemUserUid);
		bool flag = false;
		if (category.ContainerContractorPermission == null)
		{
			IContContractorPermission contContractorPermission = AbstractNHEntityManager<IContContractorPermission, long>.Instance.Create();
			contContractorPermission.CreationAuthor = user;
			contContractorPermission.Responsible = user;
			contContractorPermission.Informs = user;
			if (save)
			{
				contContractorPermission.Save();
			}
			category.ContainerContractorPermission = contContractorPermission;
			flag = true;
		}
		else
		{
			IContContractorPermission containerContractorPermission = category.ContainerContractorPermission;
			if (containerContractorPermission.Responsible == null)
			{
				containerContractorPermission.Responsible = user;
				if (save)
				{
					containerContractorPermission.Save();
				}
			}
			if (containerContractorPermission.CreationAuthor == null)
			{
				containerContractorPermission.CreationAuthor = user;
				if (save)
				{
					containerContractorPermission.Save();
				}
			}
			if (containerContractorPermission.Informs == null)
			{
				containerContractorPermission.Informs = user;
				if (save)
				{
					containerContractorPermission.Save();
				}
			}
		}
		if (category.ContainerLeadPermission == null)
		{
			IContLeadPermission contLeadPermission = AbstractNHEntityManager<IContLeadPermission, long>.Instance.Create();
			contLeadPermission.CreationAuthor = user;
			contLeadPermission.Responsible = user;
			contLeadPermission.Informs = user;
			if (save)
			{
				contLeadPermission.Save();
			}
			category.ContainerLeadPermission = contLeadPermission;
			flag = true;
		}
		else
		{
			IContLeadPermission containerLeadPermission = category.ContainerLeadPermission;
			if (containerLeadPermission.Responsible == null)
			{
				containerLeadPermission.Responsible = user;
				if (save)
				{
					containerLeadPermission.Save();
				}
			}
			if (containerLeadPermission.CreationAuthor == null)
			{
				containerLeadPermission.CreationAuthor = user;
				if (save)
				{
					containerLeadPermission.Save();
				}
			}
			if (containerLeadPermission.Informs == null)
			{
				containerLeadPermission.Informs = user;
				if (save)
				{
					containerLeadPermission.Save();
				}
			}
		}
		if (flag && save)
		{
			category.Save();
		}
	}

	public bool CheckUpdateCategoryPermission(ICategory category = null)
	{
		if (CheckUpdateCategoryLeadPermission() || CheckUpdateCategoryLeadPermission(category))
		{
			return true;
		}
		return CheckUpdateCategoryContractorPermission(category);
	}

	public bool CheckUpdateCategoryLeadPermission()
	{
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.DisableSoftDeletable = true;
		categoryFilter.IsDeleted = true;
		return Find(categoryFilter, null).Any();
	}

	public bool CheckUpdateCategoryLeadPermission(ICategory category = null)
	{
		IContLeadPermission contLeadPermission = null;
		if (category != null && category.ContainerLeadPermission != null)
		{
			contLeadPermission = EntityManager<IContLeadPermission>.Instance.LoadOrNull(category.ContainerLeadPermission.Id);
		}
		ITemplateLeadPermissionFilter templateLeadPermissionFilter = InterfaceActivator.Create<ITemplateLeadPermissionFilter>();
		if (contLeadPermission != null)
		{
			templateLeadPermissionFilter.ContainerLead = contLeadPermission;
		}
		templateLeadPermissionFilter.Query = "(DelPermission=1 or AddPermission=1)";
		ICollection<ITemplateLeadPermission> collection = EntityManager<ITemplateLeadPermission>.Instance.Find(templateLeadPermissionFilter, null);
		if (collection != null && collection.Any())
		{
			return true;
		}
		return false;
	}

	public bool CheckLockEditPermission()
	{
		return ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
	}

	public bool RecalculateCategoryPermission()
	{
		return RecalculateCategoryPermission(inThread: false);
	}

	public bool RecalculateCategoryPermissionInThread()
	{
		return RecalculateCategoryPermission(inThread: true);
	}

	private bool RecalculateCategoryPermission(bool inThread)
	{
		if (!CheckUpdateCategoryPermission())
		{
			return true;
		}
		if (sessionProvider == null)
		{
			sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
		}
		bool availability = false;
		CachePermissionModel orAdd = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", delegate
		{
			availability = true;
			return new CachePermissionModel
			{
				TimestampTime = DateTime.Now,
				Blocking = true,
				NumberBlock = 1
			};
		});
		if (orAdd.Blocking && !availability && orAdd.TimestampTime > DateTime.Now.AddMinutes(-30.0))
		{
			return false;
		}
		ComplexCacheService.RefreshTimestamp("LockNameReroutePermissionTimestamp");
		ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel
		{
			TimestampTime = DateTime.Now,
			Blocking = true
		});
		Func<bool, bool> recalculate = delegate(bool throwOnError)
		{
			IDisposable @lock = null;
			try
			{
				if (LockManager.TryLock("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", out @lock))
				{
					WaitEndBlocked();
					List<CategoryContractorChangeAccessActionEventArgs> categories = GetCategories();
					ExecuteSqlQuery("ExecUpdateCategoryPermissions");
					DeleteCategories();
					sessionProvider.GetSession("").Flush();
					ExecuteSqlQuery("ExecAddDefaultCategoriesContractor");
					ExecuteSqlQuery("ExecAddDefaultCategoriesLead");
					sessionProvider.GetSession("").CleanUpCache(typeof(IContractorPersonPermission), typeof(IContactPersonPermission), typeof(ISalePersonPermission), typeof(ILeadPersonPermission), typeof(IRelationshipPersonPermission));
					string sql = string.Format("select {0} from {1}", transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("CheckContractorCategTmp"));
					List<long> list = new List<long>();
					using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql))
					{
						while (dataReader.Read())
						{
							object value = dataReader.GetValue(0);
							if (!(value is DBNull))
							{
								list.Add(Convert.ToInt64(value));
							}
						}
					}
					List<KeyValuePair<string, object>> list2 = new List<KeyValuePair<string, object>>();
					KeyValuePair<string, object> item = new KeyValuePair<string, object>("Key31AA4139D3194D5F917DBF47E08B3CB9", list);
					list2.Add(item);
					IEntityManager<ITemplateContractorPermission> instance = EntityManager<ITemplateContractorPermission>.Instance;
					foreach (CategoryContractorChangeAccessActionEventArgs item2 in categories)
					{
						ITemplateContractorPermissionFilter templateContractorPermissionFilter = InterfaceActivator.Create<ITemplateContractorPermissionFilter>();
						templateContractorPermissionFilter.ContainerContractor = (IContContractorPermission)item2.New;
						ICollection<ITemplateContractorPermission> source = instance.Find(templateContractorPermissionFilter, null);
						item2.FillInfoNew(source.ToList());
						SendChangeAccess(item2);
					}
					indexQueueManager.AddReindexObjectPartItem(typeof(IContractorFullTextSearchObject), 0L, InterfaceActivator.UID<IContractor>(), list2, visualData: true);
					CacheService.Remove("34839AAF-916F-4FEF-917D-21EA38656268");
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Ошибка пересчета прав для категорий ExecUpdateCategoryPermissions"), ex);
				CacheService.Insert("34839AAF-916F-4FEF-917D-21EA38656268", ex.Message);
				if (throwOnError)
				{
					throw new TransactionRollbackException(SR.T("Ошибка пересчета прав для категорий ExecUpdateCategoryPermissions"), ex);
				}
				return false;
			}
			finally
			{
				ComplexCacheService.RefreshTimestamp("LockNameReroutePermissionTimestamp");
				CacheService.Remove("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E");
				@lock?.Dispose();
			}
		};
		if (inThread)
		{
			ThreadStarter.StartNewThread(new BackgroundTask(delegate
			{
				recalculate(arg: false);
			}, GetType(), "RecalculateCategoryPermission" + Guid.NewGuid(), "RecalculateCategoryPermission" + Guid.NewGuid()).Execute);
			return true;
		}
		return recalculate(arg: true);
	}

	private List<CategoryContractorChangeAccessActionEventArgs> GetCategories()
	{
		ICollection<ICategory> collection = FindAll();
		List<CategoryContractorChangeAccessActionEventArgs> list = new List<CategoryContractorChangeAccessActionEventArgs>();
		foreach (ICategory item in collection)
		{
			if (item.ContainerContractorPermission != null)
			{
				List<ITemplateContractorPermission> oldPermissions = ((IEnumerable<ITemplateContractorPermission>)item.ContainerContractorPermission.TemplateContractorPermission).Where((ITemplateContractorPermission a) => (!a.AddPermission && !a.DelPermission) || (!a.AddPermission && a.DelPermission)).ToList();
				if (((IEnumerable<ITemplateContractorPermission>)item.ContainerContractorPermission.TemplateContractorPermission).Any((ITemplateContractorPermission a) => a.AddPermission || a.DelPermission))
				{
					CategoryContractorChangeAccessActionEventArgs categoryContractorChangeAccessActionEventArgs = new CategoryContractorChangeAccessActionEventArgs(item.ContainerContractorPermission, item.ContainerContractorPermission, ContContractorPermissionActions.ChangeAccessGuid);
					categoryContractorChangeAccessActionEventArgs.FillInfoOld(oldPermissions);
					categoryContractorChangeAccessActionEventArgs.AddCategory(item.Id);
					list.Add(categoryContractorChangeAccessActionEventArgs);
				}
			}
		}
		return list;
	}

	private void DeleteCategories()
	{
		ICategoryFilter categoryFilter = InterfaceActivator.Create<ICategoryFilter>();
		categoryFilter.DisableSoftDeletable = true;
		categoryFilter.IsDeleted = true;
		Find(categoryFilter, null).ForEach(delegate(ICategory a)
		{
			a.HardDelete = true;
			a.Delete();
		});
	}

	private void ExecuteSqlQuery(string name)
	{
		IQuery namedQuery = sessionProvider.GetSession("").GetNamedQuery(name);
		namedQuery.CleanUpCache(cleanUpCache: false);
		namedQuery.SetTimeout(0);
		namedQuery.ExecuteUpdate();
	}

	private void WaitEndBlocked()
	{
		CachePermissionModel value;
		while (CacheService.TryGetValue<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "CRMPermission", out value) && value.NumberBlock > 0 && !(value.TimestampTime < DateTime.Now.AddMinutes(-1.0)))
		{
			Thread.Sleep(1000);
		}
	}

	[Transaction]
	public virtual void SendChangeAccess(CategoryContractorChangeAccessActionEventArgs changeEvent)
	{
		Locator.GetServiceNotNull<IEntityActionHandler>().ActionExecuted(changeEvent);
	}

	internal IEnumerable<HistoryCollectorRelatedModel> GetContractorCategoryRelatedHistory(long id)
	{
		ICriteria val = CreateCriteria();
		val.CreateAlias("Contractors", "contractor");
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property("ContainerContractorPermission.Id"), "EntityId").Add((IProjection)(object)Projections.Property("contractor.CreationDate"), "AdditionalInformation") });
		val.Add((ICriterion)(object)Restrictions.Eq("contractor.Id", (object)id));
		val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryCollectorRelatedModel)));
		return val.List<HistoryCollectorRelatedModel>();
	}
}
