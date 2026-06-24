using EleWise.ELMA.Files;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class TemplateUploaderModel
{
	public string TemplateName { get; set; }

	public string Local { get; set; }

	public BinaryFile TemplateFile { get; set; }
}
