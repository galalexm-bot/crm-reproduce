using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.ExtensionPoints;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
public class CRMListener : EntityEventsListener, IUnitOfWorkEventListener
{
	private const string MarketingEffectUid = "2c2ae8eb-9f42-4d3e-b990-157357c1a535";

	public static IUnitOfWorkManager _unitOfWorkManager;

	public static IUnitOfWorkManager UnitOfWorkManager => _unitOfWorkManager ?? (_unitOfWorkManager = Locator.GetServiceNotNull<IUnitOfWorkManager>());

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		ProduceContact(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		ProduceSale((AbstractPreDatabaseOperationEvent)(object)@event);
		ProduceInpayment((AbstractPreDatabaseOperationEvent)(object)@event);
		ProduceRelationship((AbstractPreDatabaseOperationEvent)(object)@event);
		ProcessMarketingEffectProperty(@event);
		ProcessLead(@event);
		ProcessSaveEntityAddressFields(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		return false;
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		ProduceContact(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		ProduceSale((AbstractPreDatabaseOperationEvent)(object)@event);
		ProduceInpayment((AbstractPreDatabaseOperationEvent)(object)@event);
		ProduceRelationship((AbstractPreDatabaseOperationEvent)(object)@event);
		ProduceContractor(@event);
		ProcessMarketingEffectProperty(@event);
		ProcessLead(@event);
		ProcessSaveEntityAddressFields(((AbstractPreDatabaseOperationEvent)@event).get_Entity());
		return false;
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (@event != null && ((AbstractPreDatabaseOperationEvent)@event).get_Entity() != null && ((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ICurrency currency)
		{
			ExchangeCurrencyRateManager.Instance.DeleteExchangeRatesByCurrency(currency);
		}
		return false;
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() != null)
		{
			HistorySlaveContractor((AbstractPostDatabaseOperationEvent)(object)@event, ContractorActions.AddSlaveGuid);
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() != null)
		{
			HistorySlaveContractor((AbstractPostDatabaseOperationEvent)(object)@event, ContractorActions.DelSlaveGuid);
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		ProcessMarketingEffectProperty(@event);
		if (@event != null && ((AbstractPostDatabaseOperationEvent)@event).get_Entity() != null)
		{
			HistorySlaveContractor((AbstractPostDatabaseOperationEvent)(object)@event, ContractorActions.AddSlaveGuid);
		}
	}

	private void ProduceContact(object entity)
	{
		if (!(entity is IContact contact))
		{
			return;
		}
		try
		{
			if (contact.Year.HasValue && contact.Month.HasValue && contact.Day.HasValue)
			{
				contact.Birthday = new DateTime((int)contact.Year.Value, (int)contact.Month.Value, (int)contact.Day.Value);
			}
			else
			{
				contact.Birthday = null;
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error(exception, $"DateTime conversion error. Year:{contact.Year} Month:{contact.Month} Day:{contact.Day}.");
			contact.Year = null;
			contact.Month = null;
			contact.Day = null;
			contact.Birthday = null;
		}
	}

	private void ProduceSale(AbstractPreDatabaseOperationEvent @event)
	{
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		ISale sale = @event.get_Entity() as ISale;
		if (sale == null)
		{
			return;
		}
		if (sale.Contractor != null)
		{
			sale.ContractorIndustry = sale.Contractor.Industry;
			sale.Region = sale.Contractor.Region;
		}
		foreach (IInpayment item in EntityManager<IInpayment>.Instance.Find((IInpayment x) => x.Sale == sale).ToList())
		{
			item.Contractor = sale.Contractor;
		}
		if (sale.SaleType != null)
		{
			sale.SaleFunnel = sale.SaleType.SaleFunnel;
		}
		if (sale.SaleStage != null && sale.SaleStage.SaleFunnel != sale.SaleFunnel)
		{
			throw new Exception(SR.T("Стадия сделки \"{0}\" не относится к воронке \"{1}\".", sale.SaleStage.Name, (sale.SaleFunnel != null) ? sale.SaleFunnel.Name : string.Empty));
		}
		if (@event is PreInsertEvent)
		{
			if (sale.SaleStage != null)
			{
				ISaleStageHistory saleStageHistory = InterfaceActivator.Create<ISaleStageHistory>();
				saleStageHistory.ChangeAuthor = (IUser)AuthenticationService.GetCurrentUser();
				saleStageHistory.ChangeDate = DateTime.Now;
				saleStageHistory.Sale = sale;
				saleStageHistory.SaleStage = sale.SaleStage;
				saleStageHistory.Save();
			}
		}
		else if (@event is PreUpdateEvent)
		{
			PreUpdateEvent val = (PreUpdateEvent)@event;
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "SaleStage");
			if (num >= 0 && ((val.get_OldState()[num] != null) ? ((ISaleStage)val.get_OldState()[num]) : null) != sale.SaleStage)
			{
				ISaleStageHistory saleStageHistory2 = InterfaceActivator.Create<ISaleStageHistory>();
				saleStageHistory2.ChangeAuthor = (IUser)AuthenticationService.GetCurrentUser();
				saleStageHistory2.ChangeDate = DateTime.Now;
				saleStageHistory2.Sale = sale;
				saleStageHistory2.SaleStage = sale.SaleStage;
				saleStageHistory2.Save();
			}
		}
	}

	private void ProduceInpayment(AbstractPreDatabaseOperationEvent @event)
	{
		if (!(@event.get_Entity() is IInpayment inpayment))
		{
			return;
		}
		if (inpayment.Sale != null)
		{
			inpayment.Contractor = inpayment.Sale.Contractor;
		}
		PreUpdateEvent val = (PreUpdateEvent)(object)((@event is PreUpdateEvent) ? @event : null);
		if (val == null)
		{
			return;
		}
		int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "Status");
		if (num >= 0)
		{
			InpaymentStatus inpaymentStatus = ((val.get_OldState()[num] != null) ? ((InpaymentStatus)val.get_OldState()[num]) : InpaymentStatus.InPlan);
			if (inpayment.Status != inpaymentStatus)
			{
				inpayment.ChangeStatusDate = DateTime.Now;
			}
		}
	}

	private void ProduceRelationship(AbstractPreDatabaseOperationEvent @event)
	{
		IRelationship relationship = @event.get_Entity() as IRelationship;
		if (relationship == null)
		{
			return;
		}
		if (relationship.Contractor != null)
		{
			RelationshipManager.Instance.UpdateNextRelationship(relationship.Contractor, relationship);
			foreach (IContact item in (IEnumerable<IContact>)relationship.ContractorsContacts)
			{
				RelationshipManager.Instance.UpdateNextRelationship(item, relationship);
			}
		}
		if (relationship.Contact != null)
		{
			RelationshipManager.Instance.UpdateNextRelationship(relationship.Contact, relationship);
		}
		if (relationship.Lead != null)
		{
			RelationshipManager.Instance.UpdateNextRelationship(relationship.Lead, relationship);
		}
		if (relationship.Sale != null)
		{
			RelationshipManager.Instance.UpdateNextRelationship(relationship.Sale, relationship);
		}
		PreUpdateEvent val = (PreUpdateEvent)(object)((@event is PreUpdateEvent) ? @event : null);
		if (val == null)
		{
			return;
		}
		IContractor oldValue = GetOldValue<IContractor>(val, "Contractor");
		if (oldValue != null && relationship.Contractor != oldValue)
		{
			RelationshipManager.Instance.UpdateNextRelationship(oldValue);
		}
		IEnumerable<IContact> oldValue2 = GetOldValue<IEnumerable<IContact>>(val, "ContractorsContacts");
		if (oldValue2 != null)
		{
			foreach (IContact item2 in oldValue2.Where((IContact c) => !((ICollection<IContact>)relationship.ContractorsContacts).Contains(c)))
			{
				RelationshipManager.Instance.UpdateNextRelationship(item2);
			}
		}
		IContact oldValue3 = GetOldValue<IContact>(val, "Contact");
		if (oldValue3 != null && relationship.Contact != oldValue3)
		{
			RelationshipManager.Instance.UpdateNextRelationship(oldValue3);
		}
		ILead oldValue4 = GetOldValue<ILead>(val, "Lead");
		if (oldValue4 != null && relationship.Lead != oldValue4)
		{
			RelationshipManager.Instance.UpdateNextRelationship(oldValue4);
		}
		ISale oldValue5 = GetOldValue<ISale>(val, "Sale");
		if (oldValue5 != null && relationship.Sale != oldValue5)
		{
			RelationshipManager.Instance.UpdateNextRelationship(oldValue5);
		}
	}

	private void ProduceContractor(PreUpdateEvent @event)
	{
		if (!(((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IContractor))
		{
			return;
		}
		int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "IsDeleted");
		if (num < 0)
		{
			return;
		}
		bool num2 = ((bool?)@event.get_OldState()[num]) ?? false;
		bool flag = ((bool?)@event.get_State()[num]) ?? false;
		if (!(!num2 && flag))
		{
			return;
		}
		try
		{
			foreach (ISale item in SaleManager.Instance.Find((ISale x) => x.Contractor == ((AbstractPreDatabaseOperationEvent)@event).get_Entity() && ((int)x.SaleStatus == 1 || (int)x.SaleStatus == 2)))
			{
				SaleManager.Instance.ChangeStatus(item, SaleStatus.NegativeClosed, SR.T("Сделка закрыта в связи с удалением контрагента"));
			}
		}
		catch (Exception exception)
		{
			Logger.Log.Error(SR.T("Ошибка закрытия сделки при удалении контрагента"), exception);
		}
	}

	private void ProcessMarketingEffectProperty(PreInsertEvent @event)
	{
		if (!(((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IEntity entity))
		{
			return;
		}
		Type type = entity.GetType();
		if (!(MetadataLoader.LoadMetadata(type) is EntityMetadata entityMetadata))
		{
			Logger.Log.Debug($"Type {type.ToString()} has no EntityMetadata");
			return;
		}
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.SubTypeUid == new Guid("2c2ae8eb-9f42-4d3e-b990-157357c1a535") && ((MarketingEffectSettings)p.Settings).IsComposite);
		if (propertyMetadata == null)
		{
			return;
		}
		MarketingEffectSettings settings = (MarketingEffectSettings)propertyMetadata.Settings;
		PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.MarketingGroupPropertyUid);
		PropertyMetadata propertyMetadata3 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.MarketingActivityPropertyUid);
		PropertyInfo reflectionProperty = type.GetReflectionProperty(propertyMetadata2.Name);
		PropertyInfo reflectionProperty2 = type.GetReflectionProperty(propertyMetadata3.Name);
		PropertyInfo reflectionProperty3 = type.GetReflectionProperty(propertyMetadata.Name);
		IMarketingActivity marketingActivity = reflectionProperty2.GetValue(entity, null) as IMarketingActivity;
		if (reflectionProperty3.GetValue(entity, null) is IMarketingEffect marketingEffect)
		{
			reflectionProperty2.SetValue(entity, marketingEffect.MarketingActivity, null);
			if (marketingEffect.MarketingActivity.MarketingGroup != null)
			{
				reflectionProperty.SetValue(entity, marketingEffect.MarketingActivity.MarketingGroup, null);
			}
		}
		else if (marketingActivity != null && marketingActivity.MarketingGroup != null)
		{
			reflectionProperty.SetValue(entity, marketingActivity.MarketingGroup, null);
		}
	}

	private void ProcessMarketingEffectProperty(PreUpdateEvent @event)
	{
		if (!(((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IEntity entity))
		{
			return;
		}
		Type type = entity.GetType();
		if (!(MetadataLoader.LoadMetadata(type) is EntityMetadata entityMetadata))
		{
			Logger.Log.Debug($"Type {type.ToString()} has no EntityMetadata");
			return;
		}
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.SubTypeUid == new Guid("2c2ae8eb-9f42-4d3e-b990-157357c1a535") && ((MarketingEffectSettings)p.Settings).IsComposite);
		if (propertyMetadata == null)
		{
			return;
		}
		MarketingEffectSettings settings = (MarketingEffectSettings)propertyMetadata.Settings;
		PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.MarketingGroupPropertyUid);
		PropertyMetadata propertyMetadata3 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == settings.MarketingActivityPropertyUid);
		PropertyInfo reflectionProperty = type.GetReflectionProperty(propertyMetadata2.Name);
		PropertyInfo reflectionProperty2 = type.GetReflectionProperty(propertyMetadata3.Name);
		PropertyInfo reflectionProperty3 = type.GetReflectionProperty(propertyMetadata.Name);
		IMarketingGroup oldValue = GetOldValue<IMarketingGroup>(@event, propertyMetadata2.Name);
		IMarketingActivity oldValue2 = GetOldValue<IMarketingActivity>(@event, propertyMetadata3.Name);
		IMarketingEffect oldValue3 = GetOldValue<IMarketingEffect>(@event, propertyMetadata.Name);
		IMarketingGroup marketingGroup = reflectionProperty.GetValue(entity, null) as IMarketingGroup;
		IMarketingActivity marketingActivity = reflectionProperty2.GetValue(entity, null) as IMarketingActivity;
		IMarketingEffect marketingEffect = reflectionProperty3.GetValue(entity, null) as IMarketingEffect;
		if (oldValue3 != marketingEffect && marketingEffect != null)
		{
			if (marketingActivity != marketingEffect.MarketingActivity)
			{
				reflectionProperty2.SetValue(entity, marketingEffect.MarketingActivity, null);
				SetValue(@event, propertyMetadata3.Name, marketingEffect.MarketingActivity);
			}
			if (marketingEffect.MarketingActivity != null && marketingGroup != marketingEffect.MarketingActivity.MarketingGroup)
			{
				reflectionProperty.SetValue(entity, marketingEffect.MarketingActivity.MarketingGroup, null);
				SetValue(@event, propertyMetadata2.Name, marketingEffect.MarketingActivity.MarketingGroup);
			}
		}
		else if (oldValue2 != marketingActivity && marketingActivity != null)
		{
			if (marketingGroup != marketingActivity.MarketingGroup)
			{
				reflectionProperty.SetValue(entity, marketingActivity.MarketingGroup, null);
				SetValue(@event, propertyMetadata2.Name, marketingActivity.MarketingGroup);
			}
			if (marketingEffect != null && marketingEffect.MarketingActivity != marketingActivity)
			{
				reflectionProperty3.SetValue(entity, null, null);
				SetValue(@event, propertyMetadata.Name, null);
			}
		}
		else if (oldValue != marketingGroup && marketingGroup != null)
		{
			if (marketingActivity != null && marketingActivity.MarketingGroup != marketingGroup)
			{
				reflectionProperty2.SetValue(entity, null, null);
				SetValue(@event, propertyMetadata3.Name, null);
			}
			if (marketingEffect != null && marketingEffect.MarketingActivity != marketingActivity)
			{
				reflectionProperty3.SetValue(entity, null, null);
				SetValue(@event, propertyMetadata.Name, null);
			}
		}
		else if (marketingEffect != null)
		{
			reflectionProperty2.SetValue(entity, marketingEffect.MarketingActivity, null);
			SetValue(@event, propertyMetadata3.Name, marketingEffect.MarketingActivity);
			if (marketingEffect.MarketingActivity != null)
			{
				reflectionProperty.SetValue(entity, marketingEffect.MarketingActivity.MarketingGroup, null);
				SetValue(@event, propertyMetadata2.Name, marketingEffect.MarketingActivity.MarketingGroup);
			}
		}
		else if (marketingActivity != null)
		{
			reflectionProperty.SetValue(entity, marketingActivity.MarketingGroup, null);
			SetValue(@event, propertyMetadata2.Name, marketingActivity.MarketingGroup);
		}
	}

	private void ProcessMarketingEffectProperty(PostUpdateEvent @event)
	{
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IEntity entity))
		{
			return;
		}
		if (entity is ILead)
		{
			ILead lead = (ILead)entity.CastAsRealType();
			IMarketingGroup oldValue = GetOldValue<IMarketingGroup>(@event, "MarketingGroup");
			IMarketingActivity oldValue2 = GetOldValue<IMarketingActivity>(@event, "MarketingActivity");
			IMarketingEffect oldValue3 = GetOldValue<IMarketingEffect>(@event, "MarketingEffect");
			List<IMarketingEffect> list = new List<IMarketingEffect>();
			List<IMarketingActivity> list2 = new List<IMarketingActivity>();
			List<IMarketingGroup> list3 = new List<IMarketingGroup>();
			if (oldValue != lead.MarketingGroup)
			{
				list3.Add(oldValue);
				list3.Add(lead.MarketingGroup);
			}
			if (oldValue2 != lead.MarketingActivity)
			{
				list2.Add(oldValue2);
				list2.Add(lead.MarketingActivity);
			}
			if (oldValue3 != lead.MarketingEffect)
			{
				list.Add(oldValue3);
				list.Add(lead.MarketingEffect);
			}
			LeadManager.Instance.UpdateMarketingCounters(list3, list2, list);
		}
		else if (entity is ISale)
		{
			ISale sale = (ISale)entity.CastAsRealType();
			IMarketingGroup oldValue4 = GetOldValue<IMarketingGroup>(@event, "MarketingGroup");
			IMarketingActivity oldValue5 = GetOldValue<IMarketingActivity>(@event, "MarketingActivity");
			IMarketingEffect oldValue6 = GetOldValue<IMarketingEffect>(@event, "MarketingEffect");
			List<IMarketingEffect> list4 = new List<IMarketingEffect>();
			List<IMarketingActivity> list5 = new List<IMarketingActivity>();
			List<IMarketingGroup> list6 = new List<IMarketingGroup>();
			if (oldValue4 != sale.MarketingGroup)
			{
				list6.Add(oldValue4);
				list6.Add(sale.MarketingGroup);
			}
			if (oldValue5 != sale.MarketingActivity)
			{
				list5.Add(oldValue5);
				list5.Add(sale.MarketingActivity);
			}
			if (oldValue6 != sale.MarketingEffect)
			{
				list4.Add(oldValue6);
				list4.Add(sale.MarketingEffect);
			}
			SaleManager.Instance.UpdateMarketingCounters(list6, list5, list4);
		}
	}

	private void ProcessLead(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ILead lead)
		{
			if (!string.IsNullOrEmpty(lead.UtmSource) || !string.IsNullOrEmpty(lead.UtmMedium) || !string.IsNullOrEmpty(lead.UtmCampaign))
			{
				LeadManager.Instance.CreateMarketing(lead);
			}
			LeadManager.Instance.CheckDublicateLead(lead);
		}
	}

	private void ProcessLead(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ILead lead && (GetOldValue<string>(@event, "UtmSource") != lead.UtmSource || GetOldValue<string>(@event, "UtmMedium") != lead.UtmMedium || GetOldValue<string>(@event, "UtmCampaign") != lead.UtmCampaign))
		{
			LeadManager.Instance.CreateMarketing(lead);
		}
	}

	protected T GetOldValue<T>(PreUpdateEvent @event, string propertyName) where T : class
	{
		int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_OldState()[num] : null);
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
		ProcessEntities(entities);
	}

	protected void ProcessEntities(IEnumerable<object> entitites)
	{
		foreach (object entitite in entitites)
		{
			if (entitite is IContractor contractor)
			{
				Process(contractor);
			}
			else if (entitite is IMarketingBase marketingBase)
			{
				Process(marketingBase);
			}
		}
	}

	private void Process(IContractor contractor)
	{
		Process(contractor, (IContractor u) => u.Categories, delegate(IContractor u, string v)
		{
			u.CategoriesHash = v;
		});
	}

	private void Process(IMarketingBase marketingBase)
	{
		Process(marketingBase, (IMarketingBase u) => u.Tags, delegate(IMarketingBase u, string v)
		{
			u.TagsHash = v;
		});
	}

	private void Process<EntityT, CollectionEntryT>(EntityT entity, Func<EntityT, ISet<CollectionEntryT>> collectionAccessor, Action<EntityT, string> hashSetter) where EntityT : IEntity where CollectionEntryT : IEntity
	{
		if (!NHibernateUtil.IsInitialized((object)entity))
		{
			return;
		}
		ISet<CollectionEntryT> val = collectionAccessor(entity);
		if (val.IsInitialized<CollectionEntryT>())
		{
			hashSetter(entity, string.Join(", ", (from i in (IEnumerable<CollectionEntryT>)val
				select i.GetId() into id
				orderby id
				select id).ToArray()));
		}
	}

	private void ProcessSaveEntityAddressFields(object entity)
	{
		IAddress address = entity as IAddress;
		if (address != null && address.Country != null)
		{
			Action<IAddress> saveNewFieldsAction = (from p in ComponentManager.Current.GetExtensionPoints<IAddressProvider>()
				where p.CountryCode == address.Country.CountryCode
				select p).Select((Func<IAddressProvider, Action<IAddress>>)((IAddressProvider p) => p.SaveNewFields)).Concat(new Action<IAddress>[1] { SaveNewFields }).First();
			UnitOfWorkManager.RegisterPostCommitAction(delegate
			{
				saveNewFieldsAction(address);
			});
		}
	}

	internal static void SaveNewFields(IAddress address)
	{
		BackgroundTask backgroundTask = new BackgroundTask(delegate
		{
			using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				var source = new[]
				{
					new
					{
						name = address.Region,
						type = AddresType.Region
					},
					new
					{
						name = address.District,
						type = AddresType.District
					},
					new
					{
						name = address.City,
						type = AddresType.City
					},
					new
					{
						name = address.Locality,
						type = AddresType.Locality
					},
					new
					{
						name = address.Street,
						type = AddresType.Street
					}
				};
				Guid value = Guid.Empty;
				foreach (var item in source.Where(i => !string.IsNullOrWhiteSpace(i.name)))
				{
					Guid guid = AddrManager.Instance.FindInExistItems(item.name, value, address.Country.CountryCode) ?? Guid.Empty;
					value = ((guid == Guid.Empty) ? AddrManager.Instance.Save(item.name, (long)item.type, value, address.Country.CountryCode).Uid : guid);
				}
				unitOfWork.Commit();
			}
			catch (Exception message)
			{
				Logger.Log.Error(message);
				unitOfWork.Rollback();
			}
		}, typeof(IAddrBase), "SaveNewFields", "Создание новых адресов ФИАС");
		Thread thread = new Thread((ThreadStart)delegate
		{
			backgroundTask.Execute();
		});
		thread.CurrentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
		thread.CurrentUICulture = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
		thread.Start();
		thread.Join();
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	protected T GetOldValue<T>(PostUpdateEvent @event, string propertyName) where T : class
	{
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_OldState()[num] : null);
	}

	protected T GetValue<T>(PreUpdateEvent @event, string propertyName)
	{
		int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_State()[num] : null);
	}

	protected void SetValue(PreUpdateEvent @event, string propertyName, object value)
	{
		int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		if (num >= 0)
		{
			@event.get_State()[num] = value;
		}
	}

	protected T GetValue<T>(PostUpdateEvent @event, string propertyName)
	{
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_State()[num] : null);
	}

	private void HistorySlaveContractor(AbstractPostDatabaseOperationEvent @event, Guid actionGuid)
	{
		PostUpdateEvent val = (PostUpdateEvent)(object)((@event is PostUpdateEvent) ? @event : null);
		object entity = @event.get_Entity();
		if (entity == null)
		{
			return;
		}
		if (entity is IContact)
		{
			IContact contact = entity as IContact;
			IContractor contractor = contact.Contractor;
			if (val != null)
			{
				int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "Contractor");
				if (num >= 0)
				{
					IContractor contractor2 = ((val.get_OldState()[num] != null) ? ((IContractor)val.get_OldState()[num]) : null);
					if (contractor2 != null && contractor != null && contractor2.Id != contractor.Id)
					{
						ContractorManager instance = ContractorManager.Instance;
						IContact contact2 = contact;
						instance.HistoryActionToSlaveObject(contractor2, ContractorActions.DelSlaveGuid, contact2);
						ContractorManager instance2 = ContractorManager.Instance;
						contact2 = contact;
						instance2.HistoryActionToSlaveObject(contractor, ContractorActions.AddSlaveGuid, contact2);
					}
					else if (contractor2 != null && contractor == null)
					{
						ContractorManager instance3 = ContractorManager.Instance;
						IContact contact2 = contact;
						instance3.HistoryActionToSlaveObject(contractor2, ContractorActions.DelSlaveGuid, contact2);
					}
					else if (contractor2 == null && contractor != null)
					{
						ContractorManager instance4 = ContractorManager.Instance;
						IContact contact2 = contact;
						instance4.HistoryActionToSlaveObject(contractor, ContractorActions.AddSlaveGuid, contact2);
					}
				}
			}
			else if (contractor != null)
			{
				ContractorManager instance5 = ContractorManager.Instance;
				IContact contact2 = contact;
				instance5.HistoryActionToSlaveObject(contractor, actionGuid, contact2);
			}
		}
		else if (entity is ISale)
		{
			ISale sale = entity as ISale;
			IContractor contractor3 = sale.Contractor;
			if (val != null)
			{
				int num2 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "Contractor");
				if (num2 >= 0)
				{
					IContractor contractor4 = ((val.get_OldState()[num2] != null) ? ((IContractor)val.get_OldState()[num2]) : null);
					if (contractor4 != null && contractor3 != null && contractor4.Id != contractor3.Id)
					{
						ContractorManager instance6 = ContractorManager.Instance;
						IContractor contractor5 = contractor4.CastAsRealType();
						ISale sale2 = sale;
						instance6.HistoryActionToSlaveObject(contractor5, ContractorActions.DelSlaveGuid, null, null, sale2);
						ContractorManager instance7 = ContractorManager.Instance;
						sale2 = sale;
						instance7.HistoryActionToSlaveObject(contractor3, ContractorActions.AddSlaveGuid, null, null, sale2);
					}
					else if (contractor4 != null && contractor3 == null)
					{
						ContractorManager instance8 = ContractorManager.Instance;
						IContractor contractor6 = contractor4.CastAsRealType();
						ISale sale2 = sale;
						instance8.HistoryActionToSlaveObject(contractor6, ContractorActions.DelSlaveGuid, null, null, sale2);
					}
					else if (contractor4 == null && contractor3 != null)
					{
						ContractorManager instance9 = ContractorManager.Instance;
						ISale sale2 = sale;
						instance9.HistoryActionToSlaveObject(contractor3, ContractorActions.AddSlaveGuid, null, null, sale2);
					}
				}
			}
			else if (contractor3 != null)
			{
				ContractorManager instance10 = ContractorManager.Instance;
				ISale sale2 = sale;
				instance10.HistoryActionToSlaveObject(contractor3, actionGuid, null, null, sale2);
			}
		}
		else
		{
			if (!(entity is IRelationship))
			{
				return;
			}
			IRelationship relationship = entity as IRelationship;
			IContractor contractor7 = relationship.Contractor;
			if (val != null)
			{
				int num3 = Array.IndexOf(((AbstractPostDatabaseOperationEvent)val).get_Persister().get_PropertyNames(), "Contractor");
				if (num3 >= 0)
				{
					IContractor contractor8 = ((val.get_OldState()[num3] != null) ? ((IContractor)val.get_OldState()[num3]) : null);
					if (contractor8 != null && contractor7 != null && contractor8.Id != contractor7.Id)
					{
						ContractorManager instance11 = ContractorManager.Instance;
						IRelationship relationship2 = relationship;
						instance11.HistoryActionToSlaveObject(contractor8, ContractorActions.DelSlaveGuid, null, relationship2);
						ContractorManager instance12 = ContractorManager.Instance;
						relationship2 = relationship;
						instance12.HistoryActionToSlaveObject(contractor7, ContractorActions.AddSlaveGuid, null, relationship2);
					}
					else if (contractor8 != null && contractor7 == null)
					{
						ContractorManager instance13 = ContractorManager.Instance;
						IRelationship relationship2 = relationship;
						instance13.HistoryActionToSlaveObject(contractor8, ContractorActions.DelSlaveGuid, null, relationship2);
					}
					else if (contractor8 == null && contractor7 != null)
					{
						ContractorManager instance14 = ContractorManager.Instance;
						IRelationship relationship2 = relationship;
						instance14.HistoryActionToSlaveObject(contractor7, ContractorActions.AddSlaveGuid, null, relationship2);
					}
				}
			}
			else if (relationship.Contractor != null)
			{
				ContractorManager instance15 = ContractorManager.Instance;
				IContractor contractor9 = relationship.Contractor;
				IRelationship relationship2 = relationship;
				instance15.HistoryActionToSlaveObject(contractor9, actionGuid, null, relationship2);
			}
		}
	}
}
