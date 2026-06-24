using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal sealed class AddressHistoryCollector : IEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private readonly AddrManager addressManager;

	private Dictionary<long, string> propertyNames;

	private Dictionary<long, object> relatedEntities;

	private List<Guid> addressImplementations;

	public AddressHistoryCollector(AddrManager addressManager)
	{
		this.addressManager = addressManager;
		collectorGuid = new Guid("774D14CD-F1BF-47C0-921E-ADA8DBE31B0B");
	}

	public bool CanUse(long id, Guid actionObject)
	{
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		Guid contractorTypeUid = InterfaceActivator.UID<IContractor>();
		return baseClasses.Any((ClassMetadata c) => c.Uid == contractorTypeUid);
	}

	public IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		FillNamedProperties(relatedEventList, actionObject);
		foreach (EntityActionEventArgs relatedEvent in relatedEventList)
		{
			if (relatedEvent.Action == null || relatedEvent.Metadata == null || relatedEvent.New == null || relatedEvent.Action.Uid != DefaultEntityActions.UpdateGuid)
			{
				continue;
			}
			foreach (HistoryCollectorRelatedModel relatedObject in relatedObjectList)
			{
				if (!(relatedObject.CollectorGuid != collectorGuid) && !(relatedEvent.Metadata.Uid != relatedObject.EntityTypeUid) && (long)relatedEvent.New.GetId() == relatedObject.EntityId)
				{
					string value = string.Empty;
					propertyNames.TryGetValue(relatedObject.EntityId, out value);
					relatedEvent.ExtendedProperties["Theme"] = value;
					if (relatedEntities.TryGetValue(relatedObject.EntityId, out var value2))
					{
						relatedEvent.ExtendedProperties["RelatedModel"] = value2;
					}
					yield return relatedEvent;
				}
			}
		}
	}

	public IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		IEnumerable<HistoryCollectorRelatedModel> contractorAddressRelatedHistory = addressManager.GetContractorAddressRelatedHistory(id, actionObject);
		foreach (HistoryCollectorRelatedModel item in contractorAddressRelatedHistory)
		{
			item.CollectorGuid = collectorGuid;
		}
		return contractorAddressRelatedHistory;
	}

	private void FillNamedProperties(IEnumerable<EntityActionEventArgs> relatedEventList, Guid actionObject)
	{
		propertyNames = new Dictionary<long, string>();
		relatedEntities = new Dictionary<long, object>();
		if (addressImplementations == null || !addressImplementations.Any())
		{
			EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(InterfaceActivator.UID<IAddress>()) as EntityMetadata;
			addressImplementations = MetadataLoader.GetChildClasses(entityMetadata).SelectMany(delegate(ClassMetadata impl)
			{
				EntityMetadata entityMetadata3 = impl as EntityMetadata;
				return new Guid[2] { entityMetadata3.Uid, entityMetadata3.ImplementationUid };
			}).ToList();
			addressImplementations.AddRange(new Guid[2] { entityMetadata.Uid, entityMetadata.ImplementationUid });
		}
		foreach (EntityActionEventArgs relatedEvent in relatedEventList)
		{
			if (!(relatedEvent.New is IContractor) && !(relatedEvent.New is IContact))
			{
				continue;
			}
			List<IPropertyMetadata> list = new List<IPropertyMetadata>();
			if (relatedEvent.New is IContractor)
			{
				EntityMetadata entityMetadata2 = MetadataLoader.LoadMetadata(actionObject) as EntityMetadata;
				list.AddRange(entityMetadata2.Properties.Where((PropertyMetadata p) => addressImplementations.Contains(p.SubTypeUid)));
			}
			if (relatedEvent.New is IContact value)
			{
				IEnumerable<PropertyMetadata> enumerable = (MetadataLoader.LoadMetadata(typeof(IContact)) as EntityMetadata).Properties.Where((PropertyMetadata p) => addressImplementations.Contains(p.SubTypeUid));
				list.AddRange(enumerable);
				foreach (PropertyMetadata item in enumerable)
				{
					if (relatedEvent.Old != null && relatedEvent.Old.GetPropertyValue(item.Uid) is IAddress address)
					{
						relatedEntities.AddIfNotContainsKey(address.Id, value);
					}
					if (relatedEvent.New != null && relatedEvent.New.GetPropertyValue(item.Uid) is IAddress address2)
					{
						relatedEntities.AddIfNotContainsKey(address2.Id, value);
					}
				}
			}
			foreach (IPropertyMetadata item2 in list)
			{
				string displayName = item2.DisplayName;
				if (relatedEvent.Old != null && relatedEvent.Old.GetPropertyValue(item2.Uid) is IAddress address3)
				{
					propertyNames.AddIfNotContainsKey(address3.Id, displayName);
				}
				if (relatedEvent.New != null && relatedEvent.New.GetPropertyValue(item2.Uid) is IAddress address4)
				{
					propertyNames.AddIfNotContainsKey(address4.Id, displayName);
				}
			}
		}
	}
}
