using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class NullableDateTimeBinder : IModelBinder
{
	private bool noOffsetFlag;

	public NullableDateTimeBinder()
	{
	}

	public NullableDateTimeBinder(bool noOffsetFlag)
	{
		this.noOffsetFlag = noOffsetFlag;
	}

	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		return GetParseDateTimeValue(bindingContext, noOffsetFlag);
	}

	internal static DateTime? GetParseDateTimeValue(ModelBindingContext bindingContext, bool noOffsetFlag)
	{
		Lazy<DateTimeSettings> lazy = new Lazy<DateTimeSettings>(() => DateTimeBinder.GetSettings(bindingContext));
		string value = bindingContext.GetValue<string>(bindingContext.get_ModelName());
		if (value.IsNullOrWhiteSpace())
		{
			return null;
		}
		CultureInfo[] array = new CultureInfo[2]
		{
			Thread.CurrentThread.CurrentCulture,
			CultureInfo.InvariantCulture
		};
		foreach (CultureInfo culture in array)
		{
			try
			{
				DateTime? value2 = bindingContext.GetValue<DateTime?>(bindingContext.get_ModelName(), culture);
				if (value2.HasValue)
				{
					if (noOffsetFlag || DateTimeBinder.NoOffset(bindingContext) || (lazy != null && lazy.Value != null && (lazy.Value.WithoutOffset || !lazy.Value.ShowTime)))
					{
						return value2;
					}
					return value2.Value.ToRuntimeDateTimeFromClient(DateTimeBinder.GetTimeZoneOffset(bindingContext));
				}
				return null;
			}
			catch (Exception)
			{
			}
		}
		throw new FormatException(SR.T("Неправильный формат даты: " + value));
	}
}
