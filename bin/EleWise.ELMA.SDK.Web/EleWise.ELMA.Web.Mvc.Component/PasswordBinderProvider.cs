using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class PasswordBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		PasswordBinder value = new PasswordBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(PasswordInfo), (IModelBinder)(object)value);
	}
}
