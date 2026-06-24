using System;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Integration.Views;

[Component(Order = 400)]
internal class CatalogsFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (MetadataLoader.LoadMetadata(type) is IEntityCatalog entityCatalog && entityCatalog.ShowInCatalogList)
		{
			return InitActionMap(type, typeof(CatalogsController));
		}
		return false;
	}

	public override RouteValueDictionary Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel)
	{
		RouteValueDictionary routeValueDictionary = base.Route(type, prefix, entity, bindingModel);
		if (routeValueDictionary.TryGetValue("id", out var value))
		{
			routeValueDictionary["id"] = value.ToString();
		}
		else if (value == null && entity != null)
		{
			string text = entity.GetId().ToString();
			if (text != "0")
			{
				routeValueDictionary["id"] = text;
			}
		}
		return routeValueDictionary;
	}
}
