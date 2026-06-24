using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Documents.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentCreateNotifierExtension
{
	void Notifier(BaseController controller, DocumentInfo doc);
}
