using System;
using EleWise.ELMA.Core.Exceptions;

namespace EleWise.ELMA.Core.Diagnostics;

public static class Contract
{
	public static void NotNull(object value, string valueName)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			throw new NullReferenceException(SR.T("Значение переменной \"{0}\" не может быть неопределенным.", valueName));
		}
	}

	public static void NotNullOrEmpty(string value, string valueName)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(value))
		{
			throw new NullReferenceException(SR.T("Значение переменной \"{0}\" не может быть неопределенным или пустым.", valueName));
		}
	}

	public static void ArgumentNotNull(object value, string argumentName)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			throw new ArgumentNullException(argumentName);
		}
	}

	public static void ArgumentNotNullOrEmpty(string value, string argumentName)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(value))
		{
			throw new ArgumentException(SR.T("Значение аргумента \"{0}\" не может быть неопределенным или пустым.", argumentName));
		}
	}

	public static void CheckArgument(bool condition, string conditionText)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!condition)
		{
			throw new ArgumentException(SR.T("Неверное значение аргумента. Нарушено условие: {0}", conditionText));
		}
	}

	public static void ServiceNotNull(object service, string serviceName)
	{
		if (service == null)
		{
			throw new ServiceNotFoundException(serviceName);
		}
	}
}
