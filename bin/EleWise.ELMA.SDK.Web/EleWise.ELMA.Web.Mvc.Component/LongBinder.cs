using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Components;

public class LongBinder : DefaultModelBinder
{
	private readonly Func<decimal, object> convertFunc;

	private static readonly Type DecimalType = typeof(decimal);

	private static readonly Type NullableDecimalType = typeof(decimal?);

	public static LongBinder Create<T>(Func<decimal, T> convertFunc) where T : struct
	{
		return new LongBinder((decimal val) => convertFunc(val));
	}

	private LongBinder(Func<decimal, object> convertFunc)
	{
		this.convertFunc = convertFunc;
	}

	public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName());
		if (value != null && !(value.get_RawValue() is string) && !(value.get_RawValue() is IEnumerable<string>))
		{
			return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
		}
		ModelMetadata modelMetadata = bindingContext.get_ModelMetadata();
		bindingContext.set_ModelMetadata(new ModelMetadata(ModelMetadataProviders.get_Current(), modelMetadata.get_ContainerType(), (Func<object>)(() => modelMetadata.get_Model()), modelMetadata.get_ModelType().IsGenericType ? NullableDecimalType : DecimalType, modelMetadata.get_PropertyName()));
		object obj = ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
		bindingContext.set_ModelMetadata(modelMetadata);
		if (obj == null)
		{
			return null;
		}
		return convertFunc(decimal.Round((decimal)obj, MidpointRounding.AwayFromZero));
	}
}
