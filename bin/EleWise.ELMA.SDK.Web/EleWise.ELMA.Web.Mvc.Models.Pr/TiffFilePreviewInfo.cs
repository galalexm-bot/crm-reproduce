using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Models.Previews;

public class TiffFilePreviewInfo : ImgFilePreviewInfo
{
	public TiffPagesDescriptor Descriptor { get; set; }
}
