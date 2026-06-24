using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class ExcelFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{93775FF9-C661-426C-8FF9-FC2F1A399E5F}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(ExcelFilePreviewCreator);

	public override bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(file);
		if (previewCreator != null && serviceNotNull.IsSupportPreview(file))
		{
			BaseFilePreviewInfo baseFilePreviewInfo = new BaseFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/ExcelFilePreview", (object)baseFilePreviewInfo);
		}
		return true;
	}
}
