using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentPreviewViewItemRenderer : ViewItemRendererBase<DocumentPreviewViewItem>
{
	private readonly IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators;

	public ISecurityService SecurityService { get; set; }

	public DocumentPreviewViewItemRenderer(IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators)
	{
		this.extendedFilePermissionValidators = extendedFilePermissionValidators;
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		if (html.get_ViewData().get_Model() is IDocument document && document.CurrentVersion != null && document.CurrentVersion.File != null && document.CurrentVersion != null)
		{
			BinaryFile file = document.CurrentVersion.File;
			if (file != null)
			{
				string errorMessage = "";
				if (SecurityService.HasPermission(PermissionProvider.DocumentViewPermission, document) || extendedFilePermissionValidators.All((IExtendedFilePermissionValidator v) => v.HasPermission(file, out errorMessage)))
				{
					return base.Render(html, viewItem, model);
				}
				SecurityException ex = new SecurityException(errorMessage);
				AccessDeniedModel model2 = new AccessDeniedModel
				{
					Reason = ex.Message,
					Url = ex.Url
				};
				ViewDataDictionary val = new ViewDataDictionary();
				val.set_Model((object)model2);
				ViewDataDictionary val2 = val;
				return PartialExtensions.Partial(html, "~/Modules/EleWise.ELMA.BPM.Web.Common/Views/Shared/Warning.cshtml", val2);
			}
		}
		return MvcHtmlString.Empty;
	}
}
