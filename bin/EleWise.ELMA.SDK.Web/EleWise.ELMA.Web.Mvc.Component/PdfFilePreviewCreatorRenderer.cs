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
internal class PdfFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{A3398D25-0679-4691-89D6-49E458E7720B}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(PdfFilePreviewCreator);

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
			RenderPartialExtensions.RenderPartial(helper, "Previews/PdfFilePreviewFrame", (object)baseFilePreviewInfo);
		}
		return true;
	}
}
