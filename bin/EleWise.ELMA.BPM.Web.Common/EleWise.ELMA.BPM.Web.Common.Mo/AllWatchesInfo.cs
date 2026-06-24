using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class AllWatchesInfo
{
	public List<WatchDescription> Watches { get; set; }

	public AllWatchesInfo()
	{
		Watches = new List<WatchDescription>();
	}

	public WatchDescription FormatWatchItem(IWatch watch)
	{
		WatchDescription res = new WatchDescription
		{
			Watch = watch
		};
		if (watch.TypeUid == Guid.Empty)
		{
			return res;
		}
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		EntityMetadata entityMetadata = (EntityMetadata)service.GetMetadata(watch.TypeUid);
		if (watch.EntityId == null)
		{
			res.Global = true;
			res.Description = entityMetadata.DisplayName;
		}
		else
		{
			Type typeByUid = service.GetTypeByUid(watch.TypeUid);
			IEntityManager manager = EntityHelper.GetEntityManager(typeByUid);
			Locator.GetService<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
			{
				IEntity entity = (IEntity)manager.LoadOrNull(ModelHelper.TryConvertEntityId(watch.TypeUid, watch.EntityId));
				if (entity != null)
				{
					if (entity is ISoftDeletable && ((ISoftDeletable)entity).IsDeleted)
					{
						entity = null;
						res.Description = "";
					}
					res.Entity = entity;
				}
			});
		}
		if (string.IsNullOrEmpty(res.Description) && res.Entity == null)
		{
			return null;
		}
		return res;
	}

	public void Init()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		List<IWatch> allWatchesByUser = WatchManager.Instance.GetAllWatchesByUser(currentUser);
		Watches = new List<WatchDescription>();
		allWatchesByUser.ForEach(delegate(IWatch a)
		{
			WatchDescription watchDescription = FormatWatchItem(a);
			if (watchDescription != null)
			{
				Watches.Add(watchDescription);
			}
		});
		WatchDescriptionComparer comparer = new WatchDescriptionComparer();
		Watches = (from w in Watches.Distinct(comparer)
			orderby w.Global
			select w).ToList();
	}
}
