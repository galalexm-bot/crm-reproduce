using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.Models.Previews;

public class BaseFilePreviewInfo
{
	public IFilePreviewCreator PreviewCreator { get; set; }

	public BinaryFile File { get; set; }

	public bool InPopup { get; set; }
}
