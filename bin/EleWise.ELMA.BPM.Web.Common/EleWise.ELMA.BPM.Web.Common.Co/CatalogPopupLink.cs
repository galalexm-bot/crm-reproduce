using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 1000000000)]
public class CatalogPopupLink : IObjectPopupLink
{
	public bool CheckType(Type type)
	{
		Guid uid = InterfaceActivator.UID(type);
		return CatalogsController.EntityList.OfType<EntityMetadata>().Any((EntityMetadata c) => c.ImplementationUid == uid);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		UrlHelper val = new UrlHelper(context);
		Guid uid = InterfaceActivator.UID(obj.GetType().GetTypeWithoutProxy());
		return val.Action("ViewItem", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			id = ((IEntity)obj).GetId(),
			inPopUp = true
		});
	}
}
