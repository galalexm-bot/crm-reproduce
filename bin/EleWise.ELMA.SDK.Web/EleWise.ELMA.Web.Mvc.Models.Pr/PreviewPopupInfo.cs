using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.Models.Previews;

public class PreviewPopupInfo
{
	public BinaryFile File { get; set; }

	public string UniqueGlobalPrefix { get; set; }

	public bool CanLoadFile { get; set; }
}
