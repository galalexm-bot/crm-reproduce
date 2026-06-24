using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;

namespace EleWise.ELMA.Documents.Web.FullTextSearch.Extensions;

public abstract class NeedFullTextSearchCheck : INeedFullTextSearchCheck
{
	public virtual void HasUserFields(IDocumentFilter filter, CheckFullTextSearchModel checkResult)
	{
	}
}
