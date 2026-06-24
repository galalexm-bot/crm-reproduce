using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.MultiEdit;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class MultiEditController : Controller
{
	public JsonResult PingFromPageOne(long objectId, long userId, Guid editSessionUid, Guid extUid)
	{
		IMultiEditProvider multiEditProvider = ComponentManager.Current.GetExtensionPoints<IMultiEditProvider>().FirstOrDefault((IMultiEditProvider m) => m.ExtensionUid == extUid);
		if (multiEditProvider == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		MultiEditEditorStoreModel[] users = multiEditProvider.PingFromPage(objectId, userId, editSessionUid);
		return ((Controller)this).Json((object)new
		{
			users = users,
			success = true
		}, (JsonRequestBehavior)0);
	}

	public JsonResult PingFromPageMany(string objectIds, long userId, Guid editSessionUid, Guid extUid)
	{
		long[] array = (from m in objectIds.Split(",".ToCharArray())
			select Convert.ToInt64(m)).ToArray();
		IMultiEditProvider multiEditProvider = ComponentManager.Current.GetExtensionPoints<IMultiEditProvider>().FirstOrDefault((IMultiEditProvider m) => m.ExtensionUid == extUid);
		if (multiEditProvider == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		List<MultiEditEditorStoreModel> list = new List<MultiEditEditorStoreModel>();
		long[] array2 = array;
		foreach (long objectId in array2)
		{
			MultiEditEditorStoreModel[] array3 = multiEditProvider.PingFromPage(objectId, userId, editSessionUid);
			if (array3.Length != 0)
			{
				list.AddRange(array3);
			}
		}
		return ((Controller)this).Json((object)new
		{
			users = list.ToArray(),
			success = true
		}, (JsonRequestBehavior)0);
	}

	public JsonResult FinishMultiEditSession(long objectId, long userId, Guid editSessionUid, Guid extUid)
	{
		IMultiEditProvider multiEditProvider = ComponentManager.Current.GetExtensionPoints<IMultiEditProvider>().FirstOrDefault((IMultiEditProvider m) => m.ExtensionUid == extUid);
		if (multiEditProvider == null)
		{
			return ((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		multiEditProvider.FinishMultiEditSession(objectId, userId, editSessionUid);
		return ((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}
}
