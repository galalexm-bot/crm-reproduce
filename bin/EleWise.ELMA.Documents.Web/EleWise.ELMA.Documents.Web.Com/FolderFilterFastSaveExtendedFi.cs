using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 100)]
public class FolderFilterFastSaveExtendedFields : IFilterFastSaveExtendedFields
{
	public bool CheckType(FilterModel model)
	{
		return model.Entity is IFilterDocumentFolder;
	}

	public MvcHtmlString Render(HtmlHelper html, FilterModel model)
	{
		if (model.Entity is IFilterDocumentFolder filterDocumentFolder)
		{
			if (filterDocumentFolder.Folder == null)
			{
				filterDocumentFolder.Folder = Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
			}
			else
			{
				ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
				if (!serviceNotNull.HasPermission(PermissionProvider.DocumentEditPermission, filterDocumentFolder.Folder) && !serviceNotNull.HasPermission(PermissionProvider.DocumentFullAccessPermission, filterDocumentFolder.Folder))
				{
					filterDocumentFolder.Folder = Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser();
				}
			}
		}
		return PartialExtensions.Partial(html, "FilterDocument/ExtendedFieldsFastSave", (object)model);
	}

	public Dictionary<string, object> ExtendedDataFilter(HtmlHelper html, FilterModel model)
	{
		if (!(model.Entity is IFilterDocumentFolder filterDocumentFolder) || filterDocumentFolder.Folder == null)
		{
			return new Dictionary<string, object>();
		}
		return new Dictionary<string, object> { 
		{
			html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName("Entity.Folder.Id"),
			filterDocumentFolder.Folder.Id
		} };
	}

	public string ClientValidateFunction(HtmlHelper html, FilterModel model)
	{
		return html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("EntityFolderValidate");
	}
}
