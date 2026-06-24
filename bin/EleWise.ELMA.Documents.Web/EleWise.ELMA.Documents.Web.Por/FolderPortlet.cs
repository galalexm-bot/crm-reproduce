using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Portlets;

[Component]
public class FolderPortlet : Portlet<FolderPortletPersonalization>
{
	public static string UID_S = "{20006B14-3D2A-4E9A-AD8C-8D8C3BE32945}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Список документов");

	public override string Description => SR.T("Портлет отображения документов");

	public override bool AllowMultipleInstance => true;

	public FolderPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.Customizable = true;
		_profile.ImageUrl = "#moduledoc.svg";
	}

	public override MvcHtmlString Content(HtmlHelper html, FolderPortletPersonalization data)
	{
		return RenderContentAction(html, "FolderPortlet", "Folder", "EleWise.ELMA.Documents.Web", data);
	}

	public override PortletPersonalization CreateDefaultSettings(string path)
	{
		FolderPortletPersonalization folderPortletPersonalization = base.CreateDefaultSettings(path) as FolderPortletPersonalization;
		if (folderPortletPersonalization != null)
		{
			folderPortletPersonalization.FolderType = FolderType.MyDocuments;
		}
		return folderPortletPersonalization;
	}

	public override MvcHtmlString Settings(HtmlHelper html, FolderPortletPersonalization data, string path)
	{
		return RenderSettingsPartialView(html, "Folder/FolderPortletSettings", data);
	}

	public override void BeforeRender(HtmlHelper html, FolderPortletPersonalization data)
	{
		if (data.Folder != null)
		{
			string text = html.Url().Entity(data.Folder);
			if (string.IsNullOrEmpty(data.NameUrl) || Portlet<FolderPortletPersonalization>.IsUrlsEquas(data.NameUrl, text))
			{
				data.NameUrl = text;
			}
		}
	}

	protected override Permission PortletPermission()
	{
		return PermissionProvider.DocumentsAccessPermission;
	}
}
