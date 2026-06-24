using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class BooleanBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		BooleanBinder binder = new BooleanBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(bool), (IModelBinder)(object)binder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(bool?), (IModelBinder)(object)binder);
	}
}
