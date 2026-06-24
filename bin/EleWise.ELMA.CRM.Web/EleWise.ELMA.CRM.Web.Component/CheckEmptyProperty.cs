using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CheckEmptyProperty : ICheckEmptyProperty
{
	public bool? IsEmpty(PropertyInfo propertyInfo, object model)
	{
		object value = propertyInfo.GetValue(model, null);
		if (value is IAddress)
		{
			return string.IsNullOrEmpty(((IAddress)value).Name);
		}
		if (value is IEnumerable && value.GetType().IsGenericType)
		{
			Type[] interfaces = value.GetType().GetGenericArguments()[0].GetInterfaces();
			if (interfaces.Any((Type i) => i == typeof(IEmail)))
			{
				return ((IEnumerable)value).Cast<IEmail>().Any((IEmail e) => e != null && string.IsNullOrEmpty(e.EmailString));
			}
			if (interfaces.Any((Type i) => i == typeof(IPhone)))
			{
				return ((IEnumerable)value).Cast<IPhone>().Any((IPhone e) => e != null && string.IsNullOrEmpty(e.PhoneString));
			}
		}
		return null;
	}
}
