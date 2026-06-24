using System;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class DateTimeBinder : IModelBinder
{
	private bool noOffsetFlag;

	public DateTimeBinder()
	{
	}

	public DateTimeBinder(bool noOffsetFlag)
	{
		this.noOffsetFlag = noOffsetFlag;
	}

	internal static DateTimeSettings GetSettings(ModelBindingContext bindingContext)
	{
		object containerObject = bindingContext.get_ModelMetadata().GetContainerObject();
		IPropertyMetadata propertyMetadata = bindingContext.get_ModelMetadata().GetPropertyMetadata();
		if (containerObject is IEntity)
		{
			IEntity entity = containerObject as IEntity;
			if (propertyMetadata == null)
			{
				return null;
			}
			return ((containerObject != null) ? entity.GetPropertySettings(propertyMetadata.PropertyUid) : propertyMetadata.Settings) as DateTimeSettings;
		}
		string text = bindingContext.get_ModelName();
		if (text.Contains("."))
		{
			text = text.Substring(0, text.LastIndexOf('.'));
		}
		if (ContextVars.TryGetValue<IPropertyMetadata>(text, out var value) && value != null)
		{
			return value.Settings as DateTimeSettings;
		}
		if (propertyMetadata == null)
		{
			return null;
		}
		return propertyMetadata.Settings as DateTimeSettings;
	}

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		DateTime? parseDateTimeValue = NullableDateTimeBinder.GetParseDateTimeValue(bindingContext, noOffsetFlag);
		return parseDateTimeValue.HasValue ? parseDateTimeValue.Value : DateTime.MinValue;
	}

	internal static TZSettings GetTimeZoneOffset(ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue($"{bindingContext.get_ModelName()}.TZ");
		if (value == null || value.get_RawValue() == null)
		{
			return null;
		}
		int? num = value.get_RawValue() as int?;
		if (num.HasValue)
		{
			return TZ.Utc(num.Value);
		}
		if (!(value.get_RawValue() is string[] array) || array.Length < 1 || string.IsNullOrWhiteSpace(array[0]))
		{
			return null;
		}
		if (int.TryParse(array[0], out var result))
		{
			return TZ.Utc(result);
		}
		return null;
	}

	internal static bool NoOffset(ModelBindingContext bindingContext)
	{
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue($"{bindingContext.get_ModelName()}.NoOffset");
		if (value == null || value.get_RawValue() == null)
		{
			return false;
		}
		bool? flag = value.get_RawValue() as bool?;
		if (flag.HasValue)
		{
			return flag.Value;
		}
		if (!(value.get_RawValue() is string[] array) || array.Length < 1 || string.IsNullOrWhiteSpace(array[0]))
		{
			return false;
		}
		if (bool.TryParse(array[0], out var result))
		{
			return result;
		}
		return false;
	}
}
