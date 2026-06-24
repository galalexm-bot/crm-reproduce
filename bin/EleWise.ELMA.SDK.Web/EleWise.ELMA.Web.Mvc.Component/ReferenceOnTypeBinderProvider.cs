using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types.References;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class ReferenceOnTypeBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		return new KeyValuePair<Type, IModelBinder>[1]
		{
			new KeyValuePair<Type, IModelBinder>(typeof(ReferenceOnType), (IModelBinder)(object)new ReferenceOnTypeBinder())
		};
	}
}
