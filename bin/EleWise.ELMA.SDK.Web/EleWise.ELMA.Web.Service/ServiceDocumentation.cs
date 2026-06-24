using System;

namespace EleWise.ELMA.Web.Service;

public class ServiceDocumentation
{
	public Type ServiceType { get; set; }

	public string ServiceUrl { get; set; }

	public Guid Uid { get; set; }

	public ClassDocumentationElement Contract { get; set; }
}
