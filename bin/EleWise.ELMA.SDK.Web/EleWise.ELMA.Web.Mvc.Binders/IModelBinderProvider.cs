using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Binders;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IModelBinderProvider
{
	IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders();
}
