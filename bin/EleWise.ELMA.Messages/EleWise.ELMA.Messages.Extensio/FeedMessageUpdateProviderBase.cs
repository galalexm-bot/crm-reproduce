using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.ExtensionPoints;

public abstract class FeedMessageUpdateProviderBase<TEntity> : IFeedMessageUpdateProvider where TEntity : class, IEntity
{
	private readonly Type entityType = typeof(TEntity);

	protected IFeedModelMappingService MappingService => Locator.GetServiceNotNull<IFeedModelMappingService>();

	public IAuditManager AuditManager { get; set; }

	bool IFeedMessageUpdateProvider.CanUpdateMessage(Guid actionType, Guid objectType, long objectId)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectType);
		if (typeByUidOrNull == null || !entityType.IsAssignableFrom(typeByUidOrNull))
		{
			return false;
		}
		if (!(MetadataLoader.LoadMetadata(typeByUidOrNull) is EntityMetadata entityMetadata))
		{
			return false;
		}
		return Actions(entityMetadata).Contains(actionType);
	}

	IFeedMessageUpdater IFeedMessageUpdateProvider.GetMessageUpdater(Guid actionType, Guid objectType, long objectId)
	{
		return new FeedMessageUpdater(OnUpdateMessageModel, OnGetPriorityForRecipient);
	}

	private FeedPriority OnGetPriorityForRecipient(FeedModel model, IUser user, IEntity entity)
	{
		return GetPriorityForRecipient(model, user, entity as TEntity);
	}

	private bool OnUpdateMessageModel(FeedModel model, IEntity entity)
	{
		TEntity val = entity as TEntity;
		IEntity parentEntity = GetParentEntity(val, model);
		FeedModel parentModel = null;
		if (parentEntity != null)
		{
			parentModel = MappingService.Map(parentEntity);
		}
		return UpdateMessage(model, parentModel, val, parentEntity);
	}

	protected virtual IEntity GetParentEntity(TEntity tEntity, FeedModel model)
	{
		return tEntity;
	}

	public static FeedMessageAttachmentList GetMessageAttachments(IEntity entity)
	{
		IEnumerable<IFeedMessageAttachmentProvider> serviceNotNull = Locator.GetServiceNotNull<IEnumerable<IFeedMessageAttachmentProvider>>();
		List<MessageAttachment> list = new List<MessageAttachment>();
		list.AddRange(serviceNotNull.SelectMany((IFeedMessageAttachmentProvider p) => p.GetMessageAtachments(entity)));
		return new FeedMessageAttachmentList((list.Count > 0) ? list.ToArray() : null);
	}

	protected virtual IEnumerable<Guid> Actions(EntityMetadata entityMetadata)
	{
		IAuditObject @object = AuditManager.GetObject(entityMetadata.Uid);
		if (@object != null)
		{
			return from a in AuditManager.GetActions(@object)
				select a.Uid;
		}
		return new Guid[0];
	}

	protected virtual FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, TEntity entity)
	{
		if (feedModel == null)
		{
			throw new ArgumentNullException("feedModel");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		return FeedPriority.Normal;
	}

	protected virtual bool UpdateMessage(FeedModel messageModel, [CanBeNull] FeedModel parentModel, TEntity entity, [CanBeNull] IEntity parentEntity)
	{
		if (entity == null || messageModel == null)
		{
			return false;
		}
		if (parentModel == null)
		{
			return true;
		}
		if (messageModel.ActionUid == DefaultEntityActions.CreateGuid && entity == parentEntity)
		{
			parentModel.CopyTo(messageModel);
		}
		else
		{
			messageModel.Parent = parentModel;
			messageModel.IsParent = false;
			messageModel.ParentObjectId = parentModel.ActionObjectId;
			messageModel.ParentObjectUid = parentModel.ActionObjectUid;
		}
		return true;
	}
}
