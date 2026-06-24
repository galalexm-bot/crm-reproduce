using System;
using System.Web.Routing;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityCreatorInfo : EntityModeIInfo
{
	public string CreateEntityCallback { get; set; }

	public string PreviosPopupId { get; set; }

	public override RouteValueDictionary GetRoute(Guid typeUid, string prefix)
	{
		if (base.Creator == null)
		{
			return null;
		}
		RouteValueDictionary routeValueDictionary = base.Creator.Route(base.Type, prefix, null, new FormBindingModel
		{
			TypeUid = typeUid
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
