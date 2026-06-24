using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class PreviewValidationParams : IPreviewValidationParams
{
	public BinaryFile BinaryFile { get; set; }
}
