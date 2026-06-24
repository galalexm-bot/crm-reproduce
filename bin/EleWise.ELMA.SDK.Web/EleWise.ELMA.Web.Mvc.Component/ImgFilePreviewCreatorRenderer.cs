using System;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class ImgFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{AED98B53-42EC-4348-8E71-138F36C4D0D3}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(ImgFilePreviewCreator);

	public override bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewCreator previewCreator = Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(file);
		if (previewCreator != null)
		{
			if (!CheckCrypt(helper, file))
			{
				return false;
			}
			int width = 700;
			int height = 500;
			if (!file.Encrypt)
			{
				using Stream stream = file.GetContent(GetContentOptions.NonSeekable);
				Image image = Image.FromStream(stream);
				width = image.Width;
				height = image.Height;
			}
			ImgFilePreviewInfo imgFilePreviewInfo = new ImgFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				Height = height,
				Width = width,
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/ImgFilePreview", (object)imgFilePreviewInfo);
		}
		return true;
	}

	public override string InitFunctionName(string uniquePrefix)
	{
		return string.Format("InitPreview_{0}", string.IsNullOrEmpty(uniquePrefix) ? "{0}" : uniquePrefix);
	}

	public override string CalcToolbarFunctionName(string uniquePrefix)
	{
		return string.Format("CalcPositionPreviewToolbar_{0}", string.IsNullOrEmpty(uniquePrefix) ? "{0}" : uniquePrefix);
	}
}
