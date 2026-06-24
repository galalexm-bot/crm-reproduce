namespace EleWise.ELMA.Web.Service;

public class MethodDocumentationElement : AbstractDocumentationElement, INamedDocumentationElement, IDocumentationElement
{
	public string Name { get; set; }

	public string Version { get; set; }

	public bool RequiresAuthorization { get; set; }

	public ReturnValueDocumentationElement ReturnValue { get; set; }

	public ParameterDocumentationElement[] Parameters { get; set; }

	public MethodDocumentationElement(string summary, string name, string version)
		: base(summary)
	{
		Name = name;
		Version = version;
	}
}
