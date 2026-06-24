using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class DateTimeRangeBinderProvider : IModelBinderProvider
{
	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		DateTimeRangeBinder value = new DateTimeRangeBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(DateTimeRange), (IModelBinder)(object)value);
		RelativeDateTimeBinder value2 = new RelativeDateTimeBinder();
		yield return new KeyValuePair<Type, IModelBinder>(typeof(RelativeDateTime), (IModelBinder)(object)value2);
	}
}
