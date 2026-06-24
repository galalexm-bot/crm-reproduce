using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.CRM.Listeners;

[Component]
public class CRMPostFlushEventListener : PostFlushEventListener
{
	public SaleManager SaleManager { get; set; }

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		base.OnPostUpdate(@event);
		ProcessSaleFunel((AbstractPostDatabaseOperationEvent)(object)@event);
		ProcessLead(@event);
		ProcessSale(@event);
		ProcessMarketingBase((AbstractPostDatabaseOperationEvent)(object)@event);
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		base.OnPostInsert(@event);
		ProcessSaleFunel((AbstractPostDatabaseOperationEvent)(object)@event);
		ProcessLead(@event);
		ProcessSale(@event);
		ProcessMarketingBase((AbstractPostDatabaseOperationEvent)(object)@event);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		ProduceDeleteSaleFunel(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
	}

	private void ProcessLead(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ILead lead)
		{
			LeadStatus oldValue = GetOldValue<LeadStatus>(@event, "Status");
			bool oldValue2 = GetOldValue<bool>(@event, "IsDeleted");
			if (oldValue != lead.Status || oldValue2 != lead.IsDeleted)
			{
				LeadManager.Instance.UpdateMarketingCounters(lead);
			}
		}
	}

	private void ProcessLead(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ILead lead)
		{
			LeadManager.Instance.UpdateMarketingCounters(lead);
		}
	}

	private void ProcessSale(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISale sale && GetOldValue<SaleStatus>(@event, "SaleStatus") != sale.SaleStatus)
		{
			if (GetOldValue<bool>(@event, "IsDeleted") != sale.IsDeleted)
			{
				SaleManager.UpdateMarketingCounters(sale);
			}
			if (SaleManager.SaleClosedStatuses.Contains(sale.SaleStatus))
			{
				SaleManager.CloseAllRelationships(sale.Id);
			}
		}
	}

	private void ProcessSale(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ISale sale)
		{
			SaleManager.UpdateMarketingCounters(sale);
		}
	}

	private void ProcessSaleFunel(AbstractPostDatabaseOperationEvent @event)
	{
		if (!(@event.get_Entity() is ISaleFunnel saleFunnel))
		{
			return;
		}
		if (saleFunnel.Filter == null)
		{
			SaleFunnelManager.Instance.CreateSaleFunnelReportFilter(saleFunnel);
			return;
		}
		PostUpdateEvent val = (PostUpdateEvent)(object)((@event is PostUpdateEvent) ? @event : null);
		if (val != null)
		{
			string oldValue = GetOldValue<string>(val, "Name");
			if (saleFunnel.Name != oldValue)
			{
				saleFunnel.Filter.Name = saleFunnel.Name;
				saleFunnel.Filter.Save();
			}
		}
	}

	private void ProduceDeleteSaleFunel(object entity)
	{
		if (entity is ISaleFunnel saleFunnel)
		{
			SaleFunnelManager.Instance.DeleteSaleFunnelReportFilters(saleFunnel);
		}
	}

	private void ProcessMarketingBase(AbstractPostDatabaseOperationEvent @event)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (!(@event.get_Entity() is IMarketingBase marketingBase) || !(@event is PostUpdateEvent))
		{
			return;
		}
		string oldValue = GetOldValue<string>((PostUpdateEvent)@event, "TagsHash");
		if (!(oldValue != marketingBase.TagsHash))
		{
			return;
		}
		List<long> list = ((oldValue != null) ? (from x in oldValue.Split(new string[1] { ", " }, StringSplitOptions.RemoveEmptyEntries)
			select Convert.ToInt64(x)).ToList() : new List<long>());
		List<long> list2 = ((marketingBase.TagsHash != null) ? (from x in marketingBase.TagsHash.Split(new string[1] { ", " }, StringSplitOptions.RemoveEmptyEntries)
			select Convert.ToInt64(x)).ToList() : new List<long>());
		IEnumerable<long> first = list.Except(list2);
		IEnumerable<long> second = list2.Except(list);
		UtmType utmType = marketingBase.GetUtmType();
		foreach (long item in first.Union(second))
		{
			IMarketingTag marketingTag = EntityManager<IMarketingTag>.Instance.LoadOrNull(item);
			if (marketingTag != null)
			{
				LeadManager.Instance.UpdateMarketingLink(utmType, marketingTag.Name);
			}
		}
		LeadManager.Instance.BatchUpdateMarketingCounters(marketingBase);
	}

	protected T GetOldValue<T>(PostUpdateEvent @event, string propertyName)
	{
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_OldState()[num] : null);
	}

	protected T GetValue<T>(PostUpdateEvent @event, string propertyName)
	{
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		return (T)((num >= 0) ? @event.get_State()[num] : null);
	}
}
