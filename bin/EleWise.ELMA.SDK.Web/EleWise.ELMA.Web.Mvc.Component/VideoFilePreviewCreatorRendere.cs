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
internal class VideoFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{DA3EB696-F79B-4DA1-9AA3-FFF14340CDBC}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(VideoPreviewCreator);

	public override string CloseFunctionName(string uniquePrefix)
	{
		return "CloseVideoPreview";
	}

	public override bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewCreator previewCreator = Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(file);
		if (previewCreator != null)
		{
			BaseFilePreviewInfo baseFilePreviewInfo = new BaseFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/VideoFilePreview", (object)baseFilePreviewInfo);
		}
		return true;
	}
}
