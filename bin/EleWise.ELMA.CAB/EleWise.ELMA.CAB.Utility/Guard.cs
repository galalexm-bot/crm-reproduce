using System;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Utility;

public static class Guard
{
	public static void ArgumentNotNullOrEmptyString(string argumentValue, string argumentName)
	{
		ArgumentNotNull(argumentValue, argumentName);
		if (argumentValue.Length == 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.StringCannotBeEmpty, new object[1] { argumentName }));
		}
	}

	public static void ArgumentNotNull(object argumentValue, string argumentName)
	{
		if (argumentValue == null)
		{
			throw new ArgumentNullException(argumentName);
		}
	}

	public static void EnumValueIsDefined(Type enumType, object value, string argumentName)
	{
		if (!Enum.IsDefined(enumType, value))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidEnumValue, new object[2] { argumentName, enumType }));
		}
	}

	public static void TypeIsAssignableFromType(Type assignee, Type providedType, string argumentName)
	{
		if (!providedType.IsAssignableFrom(assignee))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.TypeNotCompatible, new object[2] { assignee, providedType }), argumentName);
		}
	}
}
