using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Documents.Web.Portlets;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Web.Components.HomePage;

[Component]
public class DocumentsDefaultHomePagePortletsProvider : IDocumentsDefaultHomePagePortletsProvider
{
	public LastObjectPortlet LastObjectPortlet { get; set; }

	public SearchDocumentPortlet SearchDocumentPortlet { get; set; }

	public IEnumerable<DocumentDefaultHomePagePortlet> Portlets()
	{
		yield return new DocumentDefaultHomePagePortlet(SearchDocumentPortlet, "00_0100_0", 30, PortletFrame.None);
		yield return new DocumentDefaultHomePagePortlet(LastObjectPortlet, "01_5050_1", 30, PortletFrame.Full);
	}
}
