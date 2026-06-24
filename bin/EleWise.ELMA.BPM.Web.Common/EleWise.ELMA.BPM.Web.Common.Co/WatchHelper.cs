using System;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public static class WatchHelper
{
	public static Pair<bool, string> NeedConfirmFromDelete(Guid entityTypeUid, object entityId)
	{
		Pair<bool, string> pair = new Pair<bool, string>(first: false, "");
		if (entityTypeUid != Guid.Empty)
		{
			IWatchProvider watchProvider = ComponentManager.Current.GetExtensionPoints<IWatchProvider>().FirstOrDefault((IWatchProvider p) => p.TypeUid.Contains(entityTypeUid));
			if (watchProvider != null && watchProvider.NeedConfirmFromDelete(entityTypeUid, entityId))
			{
				pair.First = true;
				string text = watchProvider.TextConfirmFromDelete(entityTypeUid, entityId);
				pair.Second = ((!string.IsNullOrEmpty(text)) ? text : "");
			}
		}
		return pair;
	}
}
