using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICreatePopupDocumentExtension
{
	void Fill(IDocument document, HttpRequestBase request, UrlHelper url);
}
