using EleWise.ELMA.Model.Types.Validation;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class PublishLocalModel
{
	[RequiredField]
	public string PublishedLocal { get; set; }
}
