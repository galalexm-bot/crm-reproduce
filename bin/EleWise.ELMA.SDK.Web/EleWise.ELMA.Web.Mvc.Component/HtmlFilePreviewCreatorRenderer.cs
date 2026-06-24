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
internal class HtmlFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{C3F6A675-3E1E-401A-8F31-A999611D80C4}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(HtmlFilePreviewCreator);

	public override bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewCreator previewCreator = Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(file);
		if (previewCreator != null)
		{
			if (!CheckCrypt(helper, file))
			{
				return false;
			}
			BaseFilePreviewInfo baseFilePreviewInfo = new BaseFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/TextFilePreview", (object)baseFilePreviewInfo);
		}
		return true;
	}
}
