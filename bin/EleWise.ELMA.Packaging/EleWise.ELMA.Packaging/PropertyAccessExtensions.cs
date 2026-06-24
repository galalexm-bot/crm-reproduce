using System;

namespace EleWise.ELMA.Packaging;

public static class PropertyAccessExtensions
{
	public static T GetPropertyNotNull<T>(this T value, string propertyName) where T : class
	{
		if (value == null)
		{
			throw new InvalidOperationException(SR.T("Свойство '{0}' не инициализировано", propertyName));
		}
		return value;
	}
}
