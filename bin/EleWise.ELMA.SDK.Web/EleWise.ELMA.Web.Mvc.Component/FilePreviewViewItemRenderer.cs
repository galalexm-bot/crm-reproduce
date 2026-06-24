using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Files.Previews.ViewItems;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component]
internal sealed class FilePreviewViewItemRenderer : ViewItemRendererBase<FilePreviewViewItem>
{
	private readonly IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable;

	private readonly IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators;

	private readonly IEnumerable<IPreviewExtendedFilePermissionValidator> previewExtendedFilePermissionValidator;

	public FilePreviewViewItemRenderer(IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable, IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators, IEnumerable<IPreviewExtendedFilePermissionValidator> previewExtendedFilePermissionValidator)
	{
		this.filePreviewViewItemAvailable = filePreviewViewItemAvailable;
		this.extendedFilePermissionValidators = extendedFilePermissionValidators;
		this.previewExtendedFilePermissionValidator = previewExtendedFilePermissionValidator;
	}

	public override bool IsHideEmpty(ViewItem viewItem)
	{
		return GetFile() == null;
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		BinaryFile file = GetFile();
		if (file != null)
		{
			string errorMessage = "";
			foreach (IPreviewExtendedFilePermissionValidator item in previewExtendedFilePermissionValidator)
			{
				if (item.HasPermission(ViewItemRenderer.Entity, file).IsValid)
				{
					return PartialExtensions.Partial(html, ViewName(viewItem), (object)file);
				}
			}
			if (extendedFilePermissionValidators.All((IExtendedFilePermissionValidator v) => v.HasPermission(file, out errorMessage)))
			{
				return PartialExtensions.Partial(html, ViewName(viewItem), (object)GetFile());
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
		return MvcHtmlString.Empty;
	}

	private BinaryFile GetFile()
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(ViewItemRenderer.Entity.GetType());
		return filePreviewViewItemAvailable.FirstOrDefault((IFilePreviewViewItemAvailable a) => a.IsAvailable(metadata))?.GetFile(ViewItemRenderer.Entity);
	}
}
