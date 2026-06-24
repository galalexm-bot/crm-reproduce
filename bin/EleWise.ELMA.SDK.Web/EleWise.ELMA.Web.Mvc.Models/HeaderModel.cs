using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Models;

public class HeaderModel
{
	private readonly IEntity entity;

	public string Title { get; set; }

	public string ImageUrl { get; set; }

	public Guid EntityTypeUid { get; set; }

	public object EntityId { get; set; }

	public string EntityIdString => Convert.ToString(EntityId);

	public bool SetTitle { get; set; }

	public bool Encode { get; set; }

	public bool ShowPaperPinButton { get; internal set; }

	public bool ShowWatchButton { get; internal set; }

	public IEntityTypeTagProvider TagProvider { get; internal set; }

	public HeaderModel(string title, IEntity entity)
		: this(title)
	{
		if (entity != null)
		{
			this.entity = entity;
			EntityId = entity.GetId();
			EntityTypeUid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
		}
	}

	public HeaderModel(string title, Guid entityTypeUid, object entityId)
		: this(title)
	{
		EntityId = entityId;
		EntityTypeUid = entityTypeUid;
	}

	public HeaderModel(string title)
	{
		SetTitle = true;
		Encode = true;
		Title = title;
	}

	public IEntity GetEntity()
	{
		if (entity != null)
		{
			return entity;
		}
		if (EntityTypeUid == Guid.Empty || EntityId == null)
		{
			return null;
		}
		Type entityType = ModelHelper.GetEntityType(EntityTypeUid);
		if (entityType == null)
		{
			return null;
		}
		IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
		if (entityManager == null)
		{
			return null;
		}
		return entityManager.LoadOrNull(EntityId).CastAsRealType() as IEntity<long>;
	}
}
