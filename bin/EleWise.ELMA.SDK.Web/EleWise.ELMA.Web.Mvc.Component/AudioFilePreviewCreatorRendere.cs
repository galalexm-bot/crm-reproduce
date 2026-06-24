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
internal class AudioFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{336F207D-790A-4CC8-A26D-6B7AD14A5752}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(AudioPreviewCreator);

	public override string CloseFunctionName(string uniquePrefix)
	{
		return "CloseAudioPreview";
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
			RenderPartialExtensions.RenderPartial(helper, "Previews/AudioFilePreview", (object)baseFilePreviewInfo);
		}
		return true;
	}
}
