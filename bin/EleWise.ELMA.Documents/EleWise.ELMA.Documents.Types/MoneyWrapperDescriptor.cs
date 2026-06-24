using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Types.Helpers;

namespace EleWise.ELMA.Documents.Types;

[Component(Order = 1000)]
public class MoneyWrapperDescriptor : ITypeWrapperDescriptor
{
	public Type OriginalType => typeof(SendInfo);

	public Type WrapperType => typeof(SendInfoWrapper);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new SendInfoWrapper((SendInfo)obj);
	}

	public object GetObject(object wrapper)
	{
		return ((SendInfoWrapper)wrapper).Info;
	}

	public bool TestType(Type type)
	{
		return false;
	}
}
