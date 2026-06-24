using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Portlets.Binders;

public class PortletPersonalizationBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		yield return new KeyValuePair<Type, IModelBinder>(typeof(PortletPersonalization), (IModelBinder)(object)new PortletPersonalizationBinder());
	}
}
