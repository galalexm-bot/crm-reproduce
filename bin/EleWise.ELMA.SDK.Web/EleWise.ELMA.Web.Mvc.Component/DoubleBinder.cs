using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Components;

public class DoubleBinder : DefaultModelBinder
{
	private readonly Func<object, int, MidpointRounding, object> roundFunc;

	public static DoubleBinder Create<T>(Func<T, int, MidpointRounding, T> roundFunc) where T : struct
	{
		return new DoubleBinder((object val, int digits, MidpointRounding mode) => roundFunc((T)val, digits, mode));
	}

	private DoubleBinder(Func<object, int, MidpointRounding, object> roundFunc)
	{
		this.roundFunc = roundFunc;
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		object obj = ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
		if (obj != null)
		{
			IEntity entity = bindingContext.get_ModelMetadata().GetContainerObject() as IEntity;
			IPropertyMetadata propertyMetadata = bindingContext.get_ModelMetadata().GetPropertyMetadata();
			DoubleSettings doubleSettings = ((propertyMetadata != null) ? (((entity != null) ? entity.GetPropertySettings(propertyMetadata.PropertyUid) : propertyMetadata.Settings) as DoubleSettings) : null);
			if (doubleSettings != null && doubleSettings.Precision.HasValue)
			{
				int arg = Math.Min(Math.Max(doubleSettings.Precision.Value, 0), 15);
				obj = roundFunc(obj, arg, MidpointRounding.AwayFromZero);
			}
		}
		return obj;
	}
}
