using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class LastObjectInfoController : BPMController<ILastObjectInfo, long>
{
	[HttpPost]
	[TransactionAction]
	public ActionResult AddInfo(Guid typeUid, long objectId)
	{
		LastObjectInfoManager.Instance.AddInfo(new ReferenceOnEntity
		{
			ObjectTypeUId = typeUid,
			ObjectId = objectId
		});
		return SuccessJson();
	}

	[HttpGet]
	public ActionResult Portlet(LastObjectPortletPersonalization settings)
	{
		FetchOptions fetchOptions = new FetchOptions(0, settings.ObjectCount, ListSortDirection.Descending, "ChangeDate");
		LastObjectInfoPortletModel lastObjectInfoPortletModel = new LastObjectInfoPortletModel
		{
			PortletSettings = settings,
			DisplayInfos = LastObjectInfoManager.Instance.GetObjects(fetchOptions, (settings.RestrictTypes && settings.ObjectTypes != null) ? settings.ObjectTypes.ToList() : null)
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)lastObjectInfoPortletModel);
	}

	[HttpGet]
	public ActionResult Info(ILastObjectSettings settings)
	{
		FetchOptions fetchOptions = new FetchOptions(0, settings.ObjectCount, ListSortDirection.Descending, "ChangeDate");
		LastObjectInfoViewModel lastObjectInfoViewModel = new LastObjectInfoViewModel
		{
			DisplayInfos = LastObjectInfoManager.Instance.GetObjects(fetchOptions, (settings.RestrictTypes && settings.ObjectTypes != null) ? settings.ObjectTypes.ToList() : new List<Guid>())
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)lastObjectInfoViewModel);
	}
}
