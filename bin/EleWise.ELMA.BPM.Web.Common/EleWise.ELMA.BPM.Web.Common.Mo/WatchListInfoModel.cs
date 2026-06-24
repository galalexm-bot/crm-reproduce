using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchListInfoModel
{
	private readonly object entityId;

	private EntityMetadata _metadata;

	private object _entity;

	public IEnumerable<IGrouping<IUser, IWatch>> Watches { get; set; }

	public string PopupId { get; set; }

	public Guid Type { get; private set; }

	public string EntityIdString => Convert.ToString(entityId);

	public bool CanEdit { get; set; }

	public string TypeWatchesCaption { get; set; }

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

	public PermissionRoleTypeSelectorModel RoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> RoleTypeModels { get; set; }

	public IEnumerable<AssignedRoleTypeModel> GlobalRoleTypeModels { get; set; }

	public Guid? PermissionToValidate { get; set; }

	public Guid? TypeUidForPermission { get; set; }

	public WatchListInfoModel(Guid entityTypeUid, object entityId)
	{
		Type = entityTypeUid;
		this.entityId = entityId;
	}
}
