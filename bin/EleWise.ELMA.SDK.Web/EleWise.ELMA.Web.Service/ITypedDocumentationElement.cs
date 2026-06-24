using System;

namespace EleWise.ELMA.Web.Service;

public interface ITypedDocumentationElement : IDocumentationElement
{
	Type Type { get; set; }
}
