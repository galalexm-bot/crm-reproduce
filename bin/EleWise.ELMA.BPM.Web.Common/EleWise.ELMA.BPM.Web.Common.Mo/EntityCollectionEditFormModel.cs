using System;
using System.Web.Routing;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityCollectionEditFormModel : EntityModeIInfo
{
	public long EntityId { get; set; }

	public string EditEntityCallback { get; set; }

	public string EditEntityFormContainerId { get; set; }

	public Guid? EditFormUid { get; set; }

	[Obsolete("Свойство устарело и будет удалено. Используйте свойство CreatorPrefix")]
	public string EditFormId
	{
		get
		{
			return base.CreatorPrefix;
		}
		set
		{
			base.CreatorPrefix = value;
		}
	}

	[Obsolete("Свойство устарело и будет удалено. Используйте свойство PopupId")]
	public string EditEntityPopup
	{
		get
		{
			return base.PopupId;
		}
		set
		{
			base.PopupId = value;
		}
	}

	[Obsolete("Свойство устарело и будет удалено. Используйте свойство ContainerId")]
	public string ContainderId
	{
		get
		{
			return base.ContainerId;
		}
		set
		{
			base.ContainerId = value;
		}
	}

	[Obsolete("Свойство устарело и будет удалено. Используйте свойство EntityType")]
	public Guid EntityUid
	{
		get
		{
			return base.EntityType;
		}
		set
		{
			base.EntityType = value;
		}
	}

	public override RouteValueDictionary GetRoute(Guid typeUid, string prefix)
	{
		if (base.Creator == null)
		{
			return null;
		}
		IEntity entity = (IEntity)ModelHelper.GetEntityManager(base.Type).LoadOrNull(EntityId);
		if (entity == null)
		{
			return null;
		}
		RouteValueDictionary routeValueDictionary = base.Creator.Route(base.Type, prefix, entity, new FormBindingModel
		{
			TypeUid = typeUid,
			ViewType = ViewType.Edit,
			FormUid = EditFormUid
		});
		if (routeValueDictionary == null)
		{
			return null;
		}
		RouteValueDictionary routeValueDictionary2 = new RouteValueDictionary(routeValueDictionary);
		if (base.CreatorParams != null)
		{
			foreach (ObjectCreatorParam param in base.CreatorParams.Params)
			{
				if (!routeValueDictionary2.ContainsKey(param.Key))
				{
					routeValueDictionary2.Add(param.Key, param.Value);
				}
			}
			return routeValueDictionary2;
		}
		return routeValueDictionary2;
	}
}
