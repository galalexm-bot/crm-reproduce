using System;
using System.IO;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Previews;

namespace EleWise.ELMA.Web.Mvc.Components.Previews;

[Component(Order = 100)]
internal class TiffFilePreviewCreatorRenderer : BaseFilePreviewCreatorRenderer
{
	public static Guid UID = new Guid("{B4B61339-E0F2-471F-8168-E27834F846A2}");

	public override Guid Uid => UID;

	public override Type CreatorType => typeof(TiffFilePreviewCreator);

	public override bool Render(HtmlHelper helper, BinaryFile file)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (!CheckCrypt(helper, file))
		{
			return false;
		}
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(file);
		if (previewCreator != null && serviceNotNull.IsSupportPreview(file))
		{
			string xml = File.ReadAllText(previewCreator.GetMainFileName(file));
			TiffFilePreviewInfo tiffFilePreviewInfo = new TiffFilePreviewInfo
			{
				File = file,
				PreviewCreator = previewCreator,
				Descriptor = ClassSerializationHelper.DeserializeObjectByXml<TiffPagesDescriptor>(xml),
				InPopup = Convert.ToBoolean(helper.get_ViewData().get_Item("InPopup") ?? ((object)false))
			};
			RenderPartialExtensions.RenderPartial(helper, "Previews/TiffFilePreview", (object)tiffFilePreviewInfo);
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
