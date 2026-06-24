using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class WorkTimeBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		WorkTimeBinder binder = new WorkTimeBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(WorkTime), (IModelBinder)(object)binder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(WorkTime?), (IModelBinder)(object)binder);
	}
}
