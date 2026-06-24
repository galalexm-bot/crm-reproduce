using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Serializable]
internal sealed class PortletPersonalizationStateWrapper
{
	public Guid PortletUid { get; set; }

	public IDictionary<string, string> Values { get; set; }
}
