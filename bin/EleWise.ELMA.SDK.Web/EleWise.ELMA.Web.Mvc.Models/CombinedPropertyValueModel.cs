using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class CombinedPropertyValueModel
{
	public string ButtonText { get; set; }

	public WebViewAttributes Attributes { get; set; }

	public IList<CombinedMarkupContentModel> Content { get; set; }
}
