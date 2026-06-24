using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class DoubleBinderProvider : IModelBinderProvider
{
	private static float Round(float value, int digits, MidpointRounding mode)
	{
		return (float)Math.Round(value, digits, mode);
	}

	public IEnumerable<KeyValuePair<Type, IModelBinder>> GetModelBinders()
	{
		DoubleBinder floatBinder = DoubleBinder.Create<float>(Round);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(float), (IModelBinder)(object)floatBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(float?), (IModelBinder)(object)floatBinder);
		DoubleBinder decimalBinder = DoubleBinder.Create<decimal>(Math.Round);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(decimal), (IModelBinder)(object)decimalBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(decimal?), (IModelBinder)(object)decimalBinder);
		DoubleBinder doubleBinder = DoubleBinder.Create<double>(Math.Round);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(double), (IModelBinder)(object)doubleBinder);
		yield return new KeyValuePair<Type, IModelBinder>(typeof(double?), (IModelBinder)(object)doubleBinder);
	}
}
