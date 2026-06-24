using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Extensions.SignDocumentVersion;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISignDocumentVersion
{
	void DoSign(IDocumentVersion model, string attributesDigitalSignature, string contentDigitalSignature, bool attributesSignatureMustPresent, bool contentSignatureMustPresent);
}
