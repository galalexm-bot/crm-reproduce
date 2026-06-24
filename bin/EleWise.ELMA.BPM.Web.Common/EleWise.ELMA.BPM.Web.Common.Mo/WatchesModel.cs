using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchesModel
{
	private object _entity;

	public Guid Type { get; private set; }

	public object ObjectId { get; private set; }

	public string ObjectIdString => Convert.ToString(ObjectId);

	public List<IWatch> Watches { get; set; }

	public bool DynamicLoad { get; set; }

	public string AddWatchScript { get; set; }

	public string RemoveWatchScript { get; set; }

	public string WatchPanel { get; set; }

	public string EntityName
	{
		get
		{
			if (_entity == null && ObjectId != null)
			{
				IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(Type));
				_entity = entityManager.LoadOrNull(ObjectId);
			}
			if (_entity == null)
			{
				return "";
			}
			return _entity.ToString();
		}
	}

	public WatchesModel(Guid entityTypeUid, object objectId)
	{
		Type = entityTypeUid;
		ObjectId = objectId;
	}

	public WatchesModel()
	{
		WatchPanel = "IconInfoWatch";
	}

	public bool IsCurrentIsWatch(object objectId)
	{
		if (Watches == null)
		{
			return false;
		}
		IAuthenticationService service = Locator.GetService<IAuthenticationService>();
		IUser currentUser = service.GetCurrentUser<IUser>();
		string sObjectId = Convert.ToString(objectId);
		return Watches.Any((IWatch w) => w.User.Id == currentUser.Id && ((objectId != null && sObjectId == w.EntityId) || (objectId == null && string.IsNullOrEmpty(w.EntityId))));
	}
}
