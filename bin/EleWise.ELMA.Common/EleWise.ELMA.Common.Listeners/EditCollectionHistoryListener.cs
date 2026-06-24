using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Audit;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH.Listeners;
using Iesi.Collections;
using Iesi.Collections.Generic;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal sealed class EditCollectionHistoryListener : EntityEventsListener
{
	private IEntityActionHandler entityActionHandler;

	private IEnumerable<IEntityCollectionPropertyHistoryProcessing> entityCollectionPropertyHistoryProcessing;

	public EditCollectionHistoryListener(IEntityActionHandler entityActionHandler, IEnumerable<IEntityCollectionPropertyHistoryProcessing> entityCollectionPropertyHistoryProcessing)
	{
		this.entityActionHandler = entityActionHandler;
		this.entityCollectionPropertyHistoryProcessing = entityCollectionPropertyHistoryProcessing;
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		if (!(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IEntity entity))
		{
			return;
		}
		EntityMetadata ownerMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
		if (ownerMetadata == null || !ownerMetadata.SaveHistory)
		{
			return;
		}
		CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
		IEnumerable<IEntity> newCollection = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<IEntity>();
		IEnumerable<IEntity> oldCollection = (collectionEntry.get_Snapshot() as IEnumerable).Cast<IEntity>();
		if (newCollection.All((IEntity newCollectionItem) => oldCollection.Contains(newCollectionItem)) && oldCollection.All((IEntity oldCollectionItem) => newCollection.Contains(oldCollectionItem)))
		{
			return;
		}
		string propertyName = collectionEntry.get_Role().Split('.').LastOrDefault();
		PropertyMetadata property = ownerMetadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Name == propertyName);
		if (property == null)
		{
			return;
		}
		IEntityCollectionPropertyHistoryProcessing entityCollectionPropertyHistoryProcessing = this.entityCollectionPropertyHistoryProcessing.FirstOrDefault((IEntityCollectionPropertyHistoryProcessing a) => a.CanProcessing(ownerMetadata, property));
		if (entityCollectionPropertyHistoryProcessing == null || !entityCollectionPropertyHistoryProcessing.NeedProcessing(ownerMetadata, property))
		{
			return;
		}
		try
		{
			IEntity entity2 = (IEntity)InterfaceActivator.Create(entity.CastAsRealType().GetType().GetTypeWithoutProxy());
			GenerateCollectionBySnapshot(oldCollection, propertyName, entity2);
			EditCollectionActionEventArgs editCollectionActionEventArgs = new EditCollectionActionEventArgs(entity2, entity, property.Uid, DefaultEntityActions.EditCollectionGuid);
			editCollectionActionEventArgs.Temporary = true;
			entityActionHandler.ActionExecuted(editCollectionActionEventArgs);
		}
		catch (TransactionRequiredException exception)
		{
			Logger.Log.Error(SR.T("Не удалось записать событие изменения состава коллекции. Событие произошло вне транзакции"), exception);
		}
	}

	private void GenerateCollectionBySnapshot(IEnumerable snapshot, string collectionPropertyName, IEntity oldEntity)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		PropertyInfo reflectionProperty = oldEntity.GetType().GetReflectionProperty(collectionPropertyName);
		Type propertyType = reflectionProperty.PropertyType;
		Type type = CheckPropertyType(propertyType);
		ISet val = null;
		if (propertyType.IsInterface)
		{
			if (propertyType.GetGenericTypeDefinition() == typeof(ISet<>))
			{
				val = (ISet)Activator.CreateInstance(typeof(HashedSet<>).MakeGenericType(propertyType.GetGenericArguments()));
			}
		}
		else
		{
			val = (ISet)Activator.CreateInstance(propertyType.GetGenericTypeDefinition().MakeGenericType(type));
		}
		if (val == null)
		{
			return;
		}
		val.Clear();
		foreach (object item in snapshot)
		{
			val.Add(item);
		}
		reflectionProperty.SetValue(oldEntity, val, null);
	}

	private Type CheckPropertyType(Type propertyType)
	{
		if (IsIEnumerableT(propertyType))
		{
			Type[] genericArguments = propertyType.GetGenericArguments();
			if (genericArguments.Length != 0)
			{
				return genericArguments[0];
			}
		}
		if (propertyType.IsGenericType || propertyType.IsArray)
		{
			Type @interface = propertyType.GetInterface(typeof(IEnumerable<>).FullName);
			if (@interface != null)
			{
				Type[] genericArguments2 = @interface.GetGenericArguments();
				if (genericArguments2.Any())
				{
					return genericArguments2[0];
				}
			}
		}
		return null;
	}

	private bool IsIEnumerableT(Type propertyType)
	{
		if (propertyType.IsGenericType)
		{
			return propertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
		}
		return false;
	}
}
