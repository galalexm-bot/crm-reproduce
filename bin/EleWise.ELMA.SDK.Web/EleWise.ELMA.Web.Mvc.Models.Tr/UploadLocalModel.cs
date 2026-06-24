using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class UploadLocalModel
{
	[RequiredField]
	public string Local { get; set; }

	public BinaryFile ZipFile { get; set; }
}
