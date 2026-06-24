namespace EleWise.ELMA.Web.Service;

public abstract class AbstractDocumentationElement : IDocumentationElement
{
	public string Summary { get; set; }

	protected AbstractDocumentationElement(string summary)
	{
		Summary = summary;
	}
}
