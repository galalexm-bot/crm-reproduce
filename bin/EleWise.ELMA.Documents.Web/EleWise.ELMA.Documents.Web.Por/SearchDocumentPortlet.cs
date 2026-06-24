using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Component]
public class SearchDocumentPortlet : Portlet<SearchDocumentPersonalization>
{
	public static string UID_S = "{785B64FB-CD32-4A9D-82F4-2CDF6B54F0D6}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Поиск документов");

	public override bool AllowMultipleInstance => true;

	public override string Description => SR.T("Форма поиска документов");

	public SearchDocumentPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#search.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, SearchDocumentPersonalization data)
	{
		return RenderContentAction(html, "SearchDocumentPortlet", "FilterDocument", "EleWise.ELMA.Documents.Web", data);
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.DocumentsAccessPermission;
	}
}
