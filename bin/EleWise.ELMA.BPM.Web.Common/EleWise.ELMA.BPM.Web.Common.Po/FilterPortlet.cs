using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Component]
public class FilterPortlet : Portlet<FilterPortletPersonalization>
{
	public static string UID_S = "{240D0B1B-488C-4D68-A6D2-457B65F5E3FC}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Category => SR.T("Фильтры");

	public override string Name => SR.T("Данные по фильтру");

	public override string Description => SR.T("Портлет для отображения данных по выбранному фильтру");

	public override bool AllowMultipleInstance => true;

	public FilterPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#filter.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, FilterPortletPersonalization data)
	{
		return RenderContentAction(html, "Portlet", "FilterPortlet", "EleWise.ELMA.BPM.Web.Common", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, FilterPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "FilterPortlet/PortletSettings", data);
	}

	public override void BeforeRender(HtmlHelper html, FilterPortletPersonalization data)
	{
		UpdateNameAndUrl(html, data);
	}

	public override void BeforeEditRender(HtmlHelper html, FilterPortletPersonalization data)
	{
		UpdateNameAndUrl(html, data);
	}

	protected virtual void UpdateNameAndUrl(HtmlHelper html, FilterPortletPersonalization data)
	{
		if (data.CheckFilter())
		{
			data.NameUrl = html.Url().Entity(data.Filter);
			ComponentManager.Current.GetExtensionPoints<IFilterPortletImageTitle>().First((IFilterPortletImageTitle p) => p.AvailableFilterType(data.Filter.ObjectsType.TypeUid)).GetImageTitle(data.Filter.ObjectsType.TypeUid, data.Filter.Code, out var imageUrl, out var _);
			data.ImageUrl = imageUrl;
			data.Name = (string.IsNullOrEmpty(data.CustomName) ? data.Filter.Name : data.CustomName);
			if (ComponentManager.Current.GetExtensionPoints<IFilterPortletShowOnlyMy>().Any((IFilterPortletShowOnlyMy p) => p.CheckShowOnlyMy(data.Filter.ObjectsType.TypeUid)) && data.ShowOnlyMy)
			{
				data.Name = SR.T("{0} , только мои", data.Name);
			}
		}
		else
		{
			data.ImageUrl = Profile.ImageUrl;
			data.Name = Name;
			data.NameUrl = null;
		}
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
