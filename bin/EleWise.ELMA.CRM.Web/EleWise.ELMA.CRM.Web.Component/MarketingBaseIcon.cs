using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component(Order = 10)]
public class MarketingBaseIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return typeof(IMarketingBase).IsAssignableFrom(type);
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		if (obj != null)
		{
			if (obj is IMarketingGroup)
			{
				return "/Content/IconPack/targets.svg";
			}
			if (obj is IMarketingActivity)
			{
				return "/Content/IconPack/target.svg";
			}
			if (obj is IMarketingEffect)
			{
				return "/Content/IconPack/arrow.svg";
			}
		}
		return null;
	}
}
