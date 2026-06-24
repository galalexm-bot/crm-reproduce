using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchListModel
{
	private readonly object entityId;

	private EntityMetadata _metadata;

	private object _entity;

	public Guid Type { get; private set; }

	public string EntityIdString => Convert.ToString(entityId);

	public string PopupId { get; set; }

	public List<IWatch> GlobalWatches { get; set; }

	public List<IWatch> Watches { get; set; }

	public bool CurrentInGlobalWatch { get; set; }

	public bool CurrentInWatch { get; set; }

	public WatchStatus WatchStatus { get; set; }

	public WatchStatus GlobalWatchStatus { get; set; }

	public string GlobalWatchDescription { get; set; }

	public string WatchDescription { get; set; }

	public string Callback { get; set; }

	public EntityMetadata Metadata
	{
		get
		{
			if (_metadata == null && Type != Guid.Empty)
			{
				_metadata = (EntityMetadata)MetadataLoader.LoadMetadata(Type);
			}
			return _metadata;
		}
	}

	public string EntityName
	{
		get
		{
			if (_entity == null && entityId != null)
			{
				IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(Type));
				_entity = entityManager.Load(entityId);
			}
			if (_entity == null)
			{
				return "";
			}
			return _entity.ToString();
		}
	}

	public WatchListModel(Guid entityTypeUid, object entityId)
	{
		Type = entityTypeUid;
		this.entityId = entityId;
	}
}
