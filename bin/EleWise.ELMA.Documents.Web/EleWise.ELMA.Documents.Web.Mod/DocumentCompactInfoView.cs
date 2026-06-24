using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentCompactInfoView
{
	public DocumentCompactInfoModel DocumentInfo { get; set; }

	public bool FullView { get; set; }

	public string IconUrl { get; set; }
}
