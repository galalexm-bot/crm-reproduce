using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.FullTextSearch.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface INeedFullTextSearchCheck
{
	void HasUserFields(IDocumentFilter filter, CheckFullTextSearchModel checkResult);
}
